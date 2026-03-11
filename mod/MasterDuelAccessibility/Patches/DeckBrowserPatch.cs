using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour DeckBrowserViewController — visionneuse de deck (Solo, Structure, Deck public, etc.)
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — visionneuse ouverte
    ///    → "[Nom du deck]. Deck principal : N cartes. Extra Deck : M cartes."
    ///    ou → "[Type]. Deck principal : N cartes. Extra Deck : M cartes." si nom vide
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   DeckBrowserViewController (namespace YgomGame.DeckBrowser)
    ///     m_DeckName      (string 0x158) — nom du deck
    ///     m_NumMainCards  (int    0x1A8) — nombre de cartes du deck principal
    ///     m_NumExtraCards (int    0x1AC) — nombre de cartes de l'Extra Deck
    ///     m_BrowserType   (enum   0x298) — Solo=0, SoloNPC=1, StructureShop=2, StructureCopy=3,
    ///                                      StructureFirst=4, PublicDeck=5, NeuronMyDeck=6
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches() — types chargés dynamiquement.
    /// </summary>
    internal static class DeckBrowserPatch
    {
        private static bool _applied = false;

        // Caches de réflexion
        private static FieldInfo? _fDeckName;
        private static FieldInfo? _fNumMain;
        private static FieldInfo? _fNumExtra;
        private static FieldInfo? _fBrowserType;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.DeckBrowser.DeckBrowserViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[DeckBrowserPatch] DeckBrowserViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[DeckBrowserPatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(DeckBrowserPatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[DeckBrowserPatch] ✓ DeckBrowserViewController.NotificationStackEntry");
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();

                if (_fDeckName == null)
                    _fDeckName = FindField(t, "m_DeckName");
                if (_fNumMain == null)
                    _fNumMain = FindField(t, "m_NumMainCards");
                if (_fNumExtra == null)
                    _fNumExtra = FindField(t, "m_NumExtraCards");
                if (_fBrowserType == null)
                    _fBrowserType = FindField(t, "m_BrowserType");

                string? deckName = _fDeckName?.GetValue(__instance)?.ToString();
                int numMain  = (_fNumMain  != null) ? Convert.ToInt32(_fNumMain.GetValue(__instance))  : 0;
                int numExtra = (_fNumExtra != null) ? Convert.ToInt32(_fNumExtra.GetValue(__instance)) : 0;

                // Type de navigateur si pas de nom
                string label = !string.IsNullOrWhiteSpace(deckName)
                    ? deckName!
                    : GetBrowserTypeLabel(__instance);

                string msg = Loc.Get("deck_browser_open", label, numMain, numExtra);
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[DeckBrowserPatch] {ex.Message}");
            }
        }

        private static string GetBrowserTypeLabel(object instance)
        {
            try
            {
                if (_fBrowserType == null) return Loc.Get("deck_browser_title");
                int bt = Convert.ToInt32(_fBrowserType.GetValue(instance));
                return bt switch
                {
                    0 => Loc.Get("deck_browser_type_solo"),
                    1 => Loc.Get("deck_browser_type_solo_npc"),
                    2 or 3 or 4 => Loc.Get("deck_browser_type_structure"),
                    5 => Loc.Get("deck_browser_type_public"),
                    6 => Loc.Get("deck_browser_type_neuron"),
                    _ => Loc.Get("deck_browser_title"),
                };
            }
            catch { return Loc.Get("deck_browser_title"); }
        }

        private static FieldInfo? FindField(Type t, string name)
        {
            var cur = t;
            while (cur != null && cur != typeof(object))
            {
                var f = cur.GetField(name,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (f != null) return f;
                cur = cur.BaseType;
            }
            return null;
        }
    }
}
