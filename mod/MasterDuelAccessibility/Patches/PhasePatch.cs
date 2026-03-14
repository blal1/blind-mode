using System;
using System.Threading;
using System.Threading.Tasks;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour PhaseSelectWindow — annonce les changements de phase et de tour.
    ///
    /// Engine.Phase : Draw=0, Standby=1, Main1=2, Battle=3, Main2=4, End=5
    ///
    /// Debounce (inspiré d'AccessibleArena BEST_PRACTICES) :
    ///   Les phases peuvent se déclencher en rafale lors de l'auto-skip (Draw → Standby → Main1
    ///   en ~60 ms). Sans debounce, chaque annonce interrompt la précédente et seule la toute
    ///   dernière serait prononcée — mais de façon aléatoire selon la vitesse d'exécution.
    ///   Avec un debounce de 150 ms, on attend la fin de la rafale et on n'annonce que
    ///   la DERNIÈRE phase reçue.
    ///
    ///   Les changements de tour sont annoncés immédiatement (ils ne se produisent jamais
    ///   en rafale et sont toujours importants).
    /// </summary>
    internal static class PhasePatch
    {
        private static readonly string[] PhaseKeys =
        {
            "duel_phase_draw",
            "duel_phase_standby",
            "duel_phase_main1",
            "duel_phase_battle",
            "duel_phase_main2",
            "duel_phase_end"
        };

        // Debounce state
        private static CancellationTokenSource? _phaseCts;
        private static readonly TimeSpan PhaseDebounce = TimeSpan.FromMilliseconds(150);

        public static void PhaseChange_Postfix(int nextphase)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            string text = nextphase >= 0 && nextphase < PhaseKeys.Length
                ? Loc.Get(PhaseKeys[nextphase])
                : Loc.Get("duel_phase_unknown", nextphase);

            // Track current phase for duel status summary (Shift+Space)
            GameState.CurrentPhaseLabel = text;

            SpeakDebounced(tts, text);
        }

        public static void TurnChange_Postfix(int team)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            // Le changement de tour est toujours prioritaire — annuler le debounce en cours
            // pour éviter qu'une phase retardée ne vienne après l'annonce de tour.
            _phaseCts?.Cancel();

            // Incrémenter le compteur de tours (réinitialisé par DuelStart_Postfix)
            GameState.CurrentTurn++;
            GameState.CurrentPlayer  = team;
            GameState.CurrentPhaseLabel = ""; // sera mis à jour dès le prochain PhaseChange

            tts.Speak(team == 0
                ? Loc.Get("duel_turn_yours_n", GameState.CurrentTurn)
                : Loc.Get("duel_turn_opp_n",   GameState.CurrentTurn),
                interrupt: false);
        }

        /// <summary>
        /// Parle après un délai de 150 ms. Si une autre annonce arrive avant,
        /// l'ancienne est annulée et seule la dernière est prononcée.
        /// </summary>
        private static void SpeakDebounced(TtsService tts, string text)
        {
            _phaseCts?.Cancel();
            _phaseCts = new CancellationTokenSource();
            var token = _phaseCts.Token;

            Task.Run(async () =>
            {
                try
                {
                    await Task.Delay(PhaseDebounce, token);
                    tts.Speak(text, interrupt: false);
                }
                catch (OperationCanceledException) { }
            });
        }
    }
}
