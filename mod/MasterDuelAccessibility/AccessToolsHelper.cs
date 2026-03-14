using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace MasterDuelAccessibility
{
    /// <summary>
    /// Wrapper léger autour de <see cref="AccessTools.TypeByName"/>
    /// pour centraliser la résolution de types du jeu par réflexion.
    /// </summary>
    internal static class AccessToolsHelper
    {
        private static readonly BindingFlags PubInst =
            BindingFlags.Public | BindingFlags.Instance;
        private static readonly BindingFlags PubStat =
            BindingFlags.Public | BindingFlags.Static;

        // ── Container-name exclusion list ─────────────────────────────────────
        // Generic UI container GO names that carry no semantic meaning as context
        // labels. Inspired by Monster Train's GetContextLabelFromHierarchy()
        // exclusion list. Used when walking the transform hierarchy to find a
        // meaningful label for a button (e.g. icon buttons, short text labels).
        // Add entries here when a parent name leaks into announcements.
        private static readonly HashSet<string> _containerKeywords =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "container", "panel",     "holder",     "group",   "content",
            "root",      "wrapper",   "area",        "layout",  "scroll",
            "viewport",  "mask",      "bg",          "background", "frame",
            "canvas",    "overlay",   "scrollview",  "scrollrect",
            "options",   "input",     "section",     "buttons",
            "items",     "list",      "entries",     "view",
        };

        /// <summary>
        /// Returns <c>true</c> if <paramref name="name"/> is a generic UI container
        /// name that should be skipped when walking the hierarchy for a context label.
        /// Matches any name that contains one of the container keywords (case-insensitive).
        /// </summary>
        public static bool IsContainerName(string? name)
        {
            if (string.IsNullOrEmpty(name)) return true;
            foreach (var keyword in _containerKeywords)
                if (name!.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    return true;
            return false;
        }
        /// <summary>
        /// Cherche un type par son nom court (ex. "CardInfo") ou son nom complet
        /// (ex. "YgomGame.Duel.CardInfo") dans tous les assemblies chargés.
        /// Retourne <c>null</c> si le type n'est pas trouvé.
        /// </summary>
        public static Type? FindType(string typeName)
        {
            try
            {
                return AccessTools.TypeByName(typeName);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Appelle <c>UnityEngine.GameObject.Find(path)</c> via réflexion statique.
        /// Retourne l'objet trouvé, ou <c>null</c> si introuvable.
        /// </summary>
        public static object? FindGameObjectByPath(string path)
        {
            try
            {
                var goType = FindType("UnityEngine.GameObject");
                if (goType == null) return null;
                var findM = goType.GetMethod("Find",
                    BindingFlags.Public | BindingFlags.Static, null,
                    new[] { typeof(string) }, null);
                return findM?.Invoke(null, new object[] { path });
            }
            catch { return null; }
        }

        /// <summary>
        /// Résout un identifiant de carte en nom lisible via Content.Instance.GetName().
        /// Retourne <c>null</c> si la résolution échoue.
        /// </summary>
        public static string? GetCardName(int cardId)
        {
            try
            {
                var contentType = FindType("Content");
                if (contentType == null) return null;

                var instanceProp = contentType.GetProperty("Instance",
                    BindingFlags.Public | BindingFlags.Static);
                var content = instanceProp?.GetValue(null);
                if (content == null) return null;

                var getNameMethod = contentType.GetMethod("GetName",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int), typeof(bool) }, null);

                return getNameMethod?.Invoke(content, new object[] { cardId, false }) as string;
            }
            catch { return null; }
        }

        /// <summary>
        /// Trouve le nom et l'ATK de la carte à une position précise du terrain.
        /// Retourne (null, -1) si introuvable. atk=-1 si la propriété n'est pas accessible.
        /// </summary>
        public static (string? Name, int Atk) GetCardNameAndAtkAt(int team, int position)
        {
            try
            {
                var rootType = FindType("CardRoot");
                if (rootType == null) return (null, -1);

                var findM = typeof(UnityEngine.Object).GetMethod(
                    "FindObjectsOfType", PubStat, null, new[] { typeof(Type) }, null);
                if (findM?.Invoke(null, new object[] { rootType }) is not Array roots)
                    return (null, -1);

                var teamProp   = rootType.GetProperty("team",   PubInst);
                var cardIdProp = rootType.GetProperty("cardId", PubInst);
                var posField   = rootType.GetField("position",  PubInst);
                var atkProp    = rootType.GetProperty("atk",    PubInst);

                foreach (var root in roots)
                {
                    if (root == null) continue;
                    if (teamProp?.GetValue(root) is not int t || t != team) continue;
                    if (posField?.GetValue(root) is not int pos || pos != position) continue;
                    if (cardIdProp?.GetValue(root) is not int cardId || cardId <= 0) continue;
                    string? name = GetCardName(cardId);
                    int atk = atkProp?.GetValue(root) is int a ? a : -1;
                    return (name, atk);
                }
                return (null, -1);
            }
            catch { return (null, -1); }
        }

        /// <summary>
        /// Trouve le nom de la carte à une position précise du terrain.
        /// team=0 = joueur local, team=1 = adversaire.
        /// position = zone CardRoot (0-12 terrain, 13 main, 14 extra deck, 16 cimetière…)
        /// Retourne null si aucune carte trouvée ou si la résolution échoue.
        /// </summary>
        public static string? GetCardNameAt(int team, int position)
        {
            try
            {
                var rootType = FindType("CardRoot");
                if (rootType == null) return null;

                var findM = typeof(UnityEngine.Object).GetMethod(
                    "FindObjectsOfType", PubStat, null, new[] { typeof(Type) }, null);
                if (findM?.Invoke(null, new object[] { rootType }) is not Array roots)
                    return null;

                var teamProp   = rootType.GetProperty("team",   PubInst);
                var cardIdProp = rootType.GetProperty("cardId", PubInst);
                var posField   = rootType.GetField("position",  PubInst);

                foreach (var root in roots)
                {
                    if (root == null) continue;
                    if (teamProp?.GetValue(root) is not int t || t != team) continue;
                    if (posField?.GetValue(root) is not int pos || pos != position) continue;
                    if (cardIdProp?.GetValue(root) is not int cardId || cardId <= 0) continue;
                    return GetCardName(cardId);
                }
                return null;
            }
            catch { return null; }
        }

        // ── Contextual label helper ───────────────────────────────────────────

        /// <summary>
        /// Returns a contextual label for a button whose visible text is short or absent.
        /// Inspired by Monster Train's GetTextWithContext() pattern.
        ///
        /// Algorithm:
        ///   1. rawText with ≥3 chars → returned unchanged (already meaningful).
        ///   2. rawText is empty or ≤2 chars (icon/abbreviation) → enrich from hierarchy:
        ///      a. Clean the button's own GO name (strip Unity suffixes, split CamelCase).
        ///         Skip if the name is a container/generic name.
        ///      b. Walk up ancestors (≤5 levels), skipping container names, using IsContainerName.
        ///      c. Return cleaned name alone (rawText empty) or "Name: rawText" (icon label).
        ///   3. Falls back to rawText if nothing meaningful found.
        ///
        /// Call site in SelectionButtonPatch:
        ///   if (string.IsNullOrWhiteSpace(text) || text.Length &lt;= 2)
        ///       text = AccessToolsHelper.GetContextualLabel(GetTransform(__instance), text) ?? text;
        /// </summary>
        public static string? GetContextualLabel(object? xform, string? rawText)
        {
            if (!string.IsNullOrWhiteSpace(rawText) && rawText.Length > 2)
                return rawText;

            if (xform == null) return rawText;

            try
            {
                // 1. Own GO name (the button's own object name, e.g. "RetryButton" → "Retry")
                string? ownName = CleanGoName(NameOf(GoOf(xform)));
                if (!string.IsNullOrEmpty(ownName))
                    return string.IsNullOrWhiteSpace(rawText)
                        ? ownName
                        : $"{ownName}: {rawText}";

                // 2. Walk up ancestors, skip containers, take first meaningful name
                var walker = ParentOf(xform);
                for (int depth = 0; depth < 5 && walker != null; depth++, walker = ParentOf(walker))
                {
                    string? pName = CleanGoName(NameOf(GoOf(walker)));
                    if (!string.IsNullOrEmpty(pName))
                        return string.IsNullOrWhiteSpace(rawText)
                            ? pName
                            : $"{pName}: {rawText}";
                }
            }
            catch { }

            return rawText;
        }

        // ── Private helpers for contextual-label hierarchy walking ────────────

        // Reflection shortcuts — keep allocations low by inlining.
        private static object? GoOf(object? xform) =>
            xform?.GetType().GetProperty("gameObject", PubInst)?.GetValue(xform);

        private static string? NameOf(object? go) =>
            go?.GetType().GetProperty("name", PubInst)?.GetValue(go)?.ToString();

        private static object? ParentOf(object? xform) =>
            xform?.GetType().GetProperty("parent", PubInst)?.GetValue(xform);

        // Generic single-word names that carry no information as labels.
        private static readonly HashSet<string> _genericGoNames =
            new HashSet<string>(StringComparer.OrdinalIgnoreCase)
        {
            "button", "text", "image", "icon", "gameobject", "sprite",
            "label", "toggle", "slider", "arrow",
        };

        /// <summary>
        /// Cleans a Unity GameObject name for use as a human-readable label:
        ///   - Strips "(Clone)" and trailing numbers after underscores.
        ///   - Returns null for container names (IsContainerName) and generic single-word names.
        ///   - Splits CamelCase into words ("RetryButton" → "Retry Button").
        ///   - Replaces underscores with spaces.
        /// </summary>
        internal static string? CleanGoName(string? raw)
        {
            if (string.IsNullOrEmpty(raw)) return null;

            // Strip "(Clone)" suffix (case-insensitive)
            int cloneIdx = raw!.IndexOf("(Clone)", StringComparison.OrdinalIgnoreCase);
            if (cloneIdx >= 0) raw = raw.Substring(0, cloneIdx).Trim();

            // Strip trailing _N or _NNN index suffixes (e.g. "Button_0", "Item_12")
            int uIdx = raw.LastIndexOf('_');
            if (uIdx > 0 && uIdx == raw.Length - 2 && char.IsDigit(raw[raw.Length - 1]))
                raw = raw.Substring(0, uIdx).Trim();

            if (string.IsNullOrEmpty(raw)) return null;
            if (IsContainerName(raw)) return null;
            if (_genericGoNames.Contains(raw)) return null;

            // Split CamelCase: "RetryButton" → "Retry Button"
            var sb = new StringBuilder(raw.Length + 4);
            for (int i = 0; i < raw.Length; i++)
            {
                char c = raw[i];
                if (c == '_')
                {
                    sb.Append(' ');
                    continue;
                }
                if (i > 0 && char.IsUpper(c))
                {
                    bool prevLower  = char.IsLower(raw[i - 1]);
                    bool nextLower  = i + 1 < raw.Length && char.IsLower(raw[i + 1]);
                    if (prevLower || nextLower)
                        sb.Append(' ');
                }
                sb.Append(c);
            }

            string result = sb.ToString().Trim();
            return string.IsNullOrEmpty(result) ? null : result;
        }
    }
}
