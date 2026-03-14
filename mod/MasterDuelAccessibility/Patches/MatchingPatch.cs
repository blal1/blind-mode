using System;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour PvpMenuMatchingViewController :
    ///   - SetActiveView : annonce les changements d'état du matchmaking
    ///     (recherche en cours, match trouvé, délai dépassé)
    ///
    /// Signature cible (private) :
    ///   private void SetActiveView(PvpMenuMatchingViewController.View state)
    ///
    /// Enum PvpMenuMatchingViewController.View :
    ///   0 = SEARCHING, 1 = MATCHING, 2 = TIMEOUT
    ///
    /// Namespace : (global / vide)
    /// </summary>
    internal static class MatchingPatch
    {
        // ── Postfix PvpMenuMatchingViewController.SetActiveView ───────────────

        public static void SetActiveView_Postfix(object __instance, object state)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                int viewState = Convert.ToInt32(state);
                string key = viewState switch
                {
                    0 => "match_searching",
                    1 => "match_found",
                    2 => "match_timeout",
                    _ => ""
                };

                if (!string.IsNullOrEmpty(key))
                    tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { /* réflexion silencieuse */ }
        }
    }
}
