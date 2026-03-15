using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour SeasonPointViewController — écran des points de saison (rang classé).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — écran ouvert
    ///    → "Points de saison. [texte du rang actuel si disponible]."
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   SeasonPointViewController (namespace YgomGame.SeasonPoint)
    ///     myInfo  (ElementObjectManager 0x180) — infos du joueur
    ///     myGroup (ElementObjectManager 0x178) — groupe joueur
    ///
    ///   Les données sont peuplées via ElementObjectManager + labels string privés.
    ///   Approche : lire tous les TMP_Text sous myGroup pour collecter rang/points.
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class SeasonPointPatch
    {
        private static bool _applied = false;

        private static FieldInfo? _fMyGroup;

        /// <summary>
        /// Dernière instance SeasonPointViewController ouverte dans cette session.
        /// Mise en cache pour que GetCurrentAnnouncement() puisse lire les données
        /// sans que l'écran soit ouvert (raccourci P hors duel).
        /// </summary>
        internal static object? ActiveInstance;

        internal static void Reset()
        {
            _applied = false;
            ActiveInstance = null;
        }

        /// <summary>
        /// Retourne l'annonce de saison pour le raccourci P hors duel.
        /// Null si aucune donnée de saison n'a encore été lue.
        /// </summary>
        internal static string? GetCurrentAnnouncement()
        {
            if (ActiveInstance == null) return null;
            try
            {
                string? rank = TryReadRankText(ActiveInstance);
                return !string.IsNullOrWhiteSpace(rank)
                    ? Loc.Get("season_point_open_rank", rank!)
                    : Loc.Get("season_point_open");
            }
            catch { return null; }
        }

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.SeasonPoint.SeasonPointViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[SeasonPointPatch] SeasonPointViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[SeasonPointPatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(SeasonPointPatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[SeasonPointPatch] ✓ SeasonPointViewController.NotificationStackEntry");
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            ActiveInstance = __instance;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Essayer de lire quelques textes depuis myGroup/myInfo via GO traversal
                string? rankText = TryReadRankText(__instance);

                string msg = !string.IsNullOrWhiteSpace(rankText)
                    ? Loc.Get("season_point_open_rank", rankText!)
                    : Loc.Get("season_point_open");

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[SeasonPointPatch] {ex.Message}");
            }
        }

        private static string? TryReadRankText(object instance)
        {
            try
            {
                if (_fMyGroup == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField("myGroup",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fMyGroup = f; break; }
                        t = t.BaseType;
                    }
                }
                if (_fMyGroup == null) return null;

                object? eom = _fMyGroup.GetValue(instance);
                if (eom == null) return null;

                // ElementObjectManager a une propriété gameObject
                var goProp = eom.GetType().GetProperty("gameObject",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var go = goProp?.GetValue(eom) as UnityEngine.GameObject;
                if (go == null) return null;

                // Collecter tous les TMP_Text non vides sous ce GO
                var tmType = AccessToolsHelper.FindType("TMPro.TMP_Text")
                          ?? AccessToolsHelper.FindType("TMPro.TextMeshProUGUI");
                if (tmType == null) return null;

                var comps = go.GetComponentsInChildren(Il2CppInterop.Runtime.Il2CppType.From(tmType), true);
                if (comps == null) return null;

                var textProp = tmType.GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);

                var parts = new System.Collections.Generic.List<string>();
                foreach (var comp in comps)
                {
                    if (comp == null) continue;
                    string? txt = textProp?.GetValue(comp)?.ToString();
                    if (!string.IsNullOrWhiteSpace(txt) && txt != "-")
                        parts.Add(txt!);
                    if (parts.Count >= 3) break; // garder concis
                }

                return parts.Count > 0 ? string.Join(", ", parts) : null;
            }
            catch
            {
                return null;
            }
        }
    }
}
