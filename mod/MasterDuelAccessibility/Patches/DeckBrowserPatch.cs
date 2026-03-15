using HarmonyLib;
using System;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour la navigation de decks :
    ///
    ///   DeckBrowserViewController.NotificationStackEntry()
    ///     → "[Nom du deck]. Deck principal : N cartes. Extra Deck : M cartes."
    ///
    ///   TrialDrawViewController.NotificationStackEntry()
    ///     → "Tirage d'essai" (annonce l'ouverture du simulateur de pioche)
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

        // ISV navigation — déduplication par mrk + cooldown
        private static int            _lastFocusedMrk    = -1;
        private static DateTime       _lastFocusedAt     = DateTime.MinValue;
        private static readonly TimeSpan _focusCooldown  = TimeSpan.FromMilliseconds(200);

        internal static void Reset()
        {
            _applied          = false;
            _lastFocusedMrk   = -1;
        }

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

            // TrialDrawViewController
            var trialType = AccessToolsHelper.FindType("TrialDrawViewController");
            if (trialType != null)
            {
                var mTrial = trialType.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mTrial != null)
                {
                    harmony.Patch(mTrial, postfix: new HarmonyMethod(
                        typeof(DeckBrowserPatch), nameof(TrialDraw_Entry_Postfix)));
                    Plugin.Instance?.LogMsg("[DeckBrowserPatch] ✓ TrialDrawViewController.NotificationStackEntry");
                }
            }

            // SetDetailViewCard(int mrk, int premiumId, bool isRental) — carte focalisée dans le browser
            var mDetail = vcType.GetMethods(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                .FirstOrDefault(m => m.Name == "SetDetailViewCard"
                    && m.GetParameters().Length == 3
                    && m.GetParameters()[0].ParameterType == typeof(int));
            if (mDetail != null)
            {
                harmony.Patch(mDetail, postfix: new HarmonyMethod(
                    typeof(DeckBrowserPatch), nameof(SetDetailViewCard_Postfix)));
                Plugin.Instance?.LogMsg("[DeckBrowserPatch] ✓ DeckBrowserViewController.SetDetailViewCard(int,int,bool)");
            }

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

        // ── SetDetailViewCard — ISV : carte focalisée dans le browser ─────────

        /// <summary>
        /// Appelé quand l'utilisateur navigue vers une carte dans le browser de deck.
        /// Annonce le nom de la carte (+ déduplication 200 ms).
        /// </summary>
        public static void SetDetailViewCard_Postfix(object __instance, int mrk, int premiumId, bool isRental)
        {
            if (mrk <= 0) return;

            // Déduplication : même carte + cooldown
            var now = DateTime.Now;
            if (mrk == _lastFocusedMrk && (now - _lastFocusedAt) < _focusCooldown)
                return;
            _lastFocusedMrk = mrk;
            _lastFocusedAt  = now;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string name = AccessToolsHelper.GetCardName(mrk) ?? mrk.ToString();
                tts.Speak(Loc.Get("deck_card_focus", name), interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[DeckBrowserPatch] SetDetailViewCard: {ex.Message}");
            }
        }

        // ── TrialDrawViewController.NotificationStackEntry ────────────────────

        /// <summary>Applied separately for TrialDrawViewController.</summary>
        public static void TrialDraw_Entry_Postfix(object __instance)
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("trial_draw"), interrupt: false);
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
