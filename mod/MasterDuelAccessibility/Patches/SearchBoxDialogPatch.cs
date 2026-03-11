using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour SearchBoxDialog — dialog de recherche de carte par nom (Deck Editor).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — dialog ouvert
    ///    → "Recherche de carte. [mot-clé actuel]." si un mot-clé est déjà saisi
    ///    → "Recherche de carte. Saisir le nom." sinon
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   SearchBoxDialog (namespace YgomGame.Deck)
    ///     m_InputFieldText (Text) — propriété privée, texte saisi
    ///     m_InputField (ExtendedInputField) — champ de saisie principal
    ///
    ///   Open(string keyword, Action<string> callback) — static
    ///     __0 = keyword — mot-clé pré-rempli (souvent vide)
    ///
    /// Appliqué via Plugin.ApplyPatches() — static, disponible partout.
    /// </summary>
    internal static class SearchBoxDialogPatch
    {
        private static bool _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Deck.SearchBoxDialog");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[SearchBoxDialogPatch] SearchBoxDialog introuvable.");
                return;
            }

            // Patch NotificationStackEntry (instance) — s'assure d'annoncer à chaque ouverture
            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack != null)
            {
                harmony.Patch(mStack, postfix: new HarmonyMethod(
                    typeof(SearchBoxDialogPatch), nameof(StackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[SearchBoxDialogPatch] ✓ SearchBoxDialog.NotificationStackEntry");
            }
            else
            {
                // Fallback : patcher la méthode statique Open(string, Action)
                System.Reflection.MethodInfo? mOpen = null;
                foreach (var m in vcType.GetMethods(BindingFlags.Public | BindingFlags.Static))
                {
                    if (m.Name == "Open" && m.GetParameters().Length == 2) { mOpen = m; break; }
                }
                if (mOpen != null)
                {
                    harmony.Patch(mOpen, postfix: new HarmonyMethod(
                        typeof(SearchBoxDialogPatch), nameof(Open_Postfix)));
                    Plugin.Instance?.LogMsg("[SearchBoxDialogPatch] ✓ SearchBoxDialog.Open (fallback)");
                }
                else
                {
                    Plugin.Instance?.LogWarn("[SearchBoxDialogPatch] NotificationStackEntry ni Open introuvable.");
                    return;
                }
            }

            _applied = true;
        }

        // ── Postfix NotificationStackEntry ────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? keyword = TryReadKeyword(__instance);
                string msg = !string.IsNullOrWhiteSpace(keyword)
                    ? Loc.Get("search_box_open_keyword", keyword!)
                    : Loc.Get("search_box_open");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[SearchBoxDialogPatch] {ex.Message}");
            }
        }

        // ── Postfix Open (fallback) ───────────────────────────────────────────

        public static void Open_Postfix(string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string msg = !string.IsNullOrWhiteSpace(__0)
                    ? Loc.Get("search_box_open_keyword", __0)
                    : Loc.Get("search_box_open");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[SearchBoxDialogPatch] Open {ex.Message}");
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string? TryReadKeyword(object instance)
        {
            try
            {
                // Essayer m_InputFieldText (Text component)
                var fText = instance.GetType().GetProperty("m_InputFieldText",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                object? txtComp = fText?.GetValue(instance);
                if (txtComp != null)
                {
                    var textProp = txtComp.GetType().GetProperty("text",
                        BindingFlags.Public | BindingFlags.Instance);
                    string? t = textProp?.GetValue(txtComp)?.ToString();
                    if (!string.IsNullOrWhiteSpace(t)) return t;
                }
                return null;
            }
            catch { return null; }
        }

    }
}
