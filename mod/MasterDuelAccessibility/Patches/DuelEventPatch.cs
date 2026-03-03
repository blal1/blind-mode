namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour DuelClient :
    ///   - RunEffect  : annonce tous les événements visuels du duel
    ///   - Awake      : entrée en duel
    ///   - OnDestroy  : sortie de duel
    ///
    /// Paramètres de RunEffect : (int id, int param1, int param2, int param3)
    ///   id     = Engine.ViewType  (voir enum ci-dessous)
    ///   param1 = contexte dépendant du type (ex. Engine.ResultType pour DuelEnd)
    ///
    /// Paramètres Harmony : __0/__1 (injection positionnelle, indépendante du nom)
    ///
    /// Engine.ViewType (extrait du dump) :
    ///   DuelEnd=2, TributeRun=45, TuningRun=51, ChainSet=52, ChainRun=53,
    ///   RunSurrender=54, RunDialog=55, RunList=56, RunSummon=57, RunSpSummon=58,
    ///   RunFusion=59, RunDetail=60, RunCoin=61, RunDice=62, RunSpecialWin=64,
    ///   RunCommand=67, CutinDraw=68, CutinSummon=69, CutinFusion=70, CutinChain=71,
    ///   CutinActivate=72, CutinSet=73, CutinReverse=74, CutinTurnEnd=77, CutinDamage=78,
    ///   CutinBreak=79, OverlayRun=84, ChainEnd=86, LinkRun=89, HandShow=19,
    ///   BattleAttack=12
    ///
    /// Engine.ResultType : None=0, Win=1, Lose=2, Draw=3, Time=4
    ///
    /// Priorité des annonces (inspiré d'AccessibleArena BEST_PRACTICES) :
    ///   interrupt=true  → Critique : résultat, abandon, pièce, janken, IA réfléchit
    ///   interrupt=false → Informatif : invocations, chaîne, pioche, activations…
    ///                     Tolk les met en queue et les joue dans l'ordre.
    /// </summary>
    internal static class DuelEventPatch
    {
        // Événements critiques qui interrompent la lecture en cours.
        // Tous les autres sont mis en queue (interrupt:false).
        private static readonly System.Collections.Generic.HashSet<int> CriticalEvents =
            new System.Collections.Generic.HashSet<int> { 2, 54, 61, 62, 64, 80, 90 };

        public static void RunEffect_Postfix(int __0, int __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            // ViewType 5 = PhaseChange, 6 = TurnChange — délégués à PhasePatch
            if (__0 == 5) { PhasePatch.PhaseChange_Postfix(__1); return; }
            if (__0 == 6) { PhasePatch.TurnChange_Postfix(__1); return; }

            string? key = __0 switch
            {
                1  => null,              // DuelStart — annoncé par DuelStart_Postfix (Awake)
                2  => GetDuelEndKey(__1),    // DuelEnd           [critique]
                12 => null,  // BattleAttack — annoncé par DuelAttackPatch.InvokeDecideAttackTarget
                19 => "duel_hand_show",      // HandShow
                45 => "duel_tribute_summon", // TributeRun
                48 => "duel_materials_used", // MaterialRun — fusion/synchro/xyz materials combined
                51 => "duel_synchro_summon", // TuningRun
                57 => "duel_normal_summon",  // RunSummon
                58 => GetSpSummonKey(__1),   // RunSpSummon — param1 = Engine.SpSummonType
                59 => "duel_fusion_summon",  // RunFusion
                69 => "duel_summon",         // CutinSummon
                70 => "duel_fusion",         // CutinFusion
                76 => "duel_flip_summon",    // CutinFlip — flip summon cutin
                80 => "duel_cpu_thinking",   // CpuThinking       [critique]
                84 => "duel_xyz_summon",     // OverlayRun
                85 => "duel_effect_resolved",// CutinSuccess — effect resolved
                89 => "duel_link_summon",    // LinkRun
                52 => "duel_chain_start",    // ChainSet
                53 => "duel_chain_resolve",  // ChainRun
                71 => "duel_chain_response", // CutinChain
                86 => "duel_chain_end",      // ChainEnd
                92 => "duel_chain_step",     // ChainStep
                68 => "duel_draw",           // CutinDraw
                72 => "duel_activate",       // CutinActivate
                73 => "duel_set",            // CutinSet
                74 => "duel_flip",           // CutinReverse
                77 => "duel_turn_end_event", // CutinTurnEnd
                78 => "duel_damage",         // CutinDamage
                79 => "duel_destroy",        // CutinBreak
                54 => "duel_surrender",      // RunSurrender      [critique]
                64 => "duel_special_win",    // RunSpecialWin     [critique]
                61 => "duel_coin",           // RunCoin           [critique]
                62 => "duel_dice",           // RunDice           [critique]
                90 => "duel_janken",         // RunJanken         [critique]
                55 => null,  // RunDialog  — handled by DuelDialogPatch
                56 => null,  // RunList    — handled by DuelDialogPatch
                60 => null,  // RunDetail  — handled by CardInfoPatch
                _  => null
            };

            if (key != null)
                tts.Speak(Loc.Get(key), interrupt: CriticalEvents.Contains(__0));
        }

        /// <summary>
        /// Engine.SpSummonType : Fusion=0, SpFusion=1, Synchro=2, Ritual=3,
        ///                       Xyz=4, Pendulum=5, Link=6, Maximum=7
        /// Fusion/Synchro/Xyz/Link are announced by their dedicated ViewTypes;
        /// Ritual, Pendulum, and Maximum have no separate ViewType.
        /// </summary>
        private static string GetSpSummonKey(int spSummonType) => spSummonType switch
        {
            3 => "duel_ritual_summon",   // Ritual
            5 => "duel_pendulum_summon", // Pendulum
            7 => "duel_maximum_summon",  // Maximum (Rush Duel / Master Duel variant)
            _ => "duel_special_summon",  // generic fallback
        };

        private static string GetDuelEndKey(int resultType) => resultType switch
        {
            1 => "duel_end_win",
            2 => "duel_end_lose",
            3 => "duel_end_draw",
            4 => "duel_end_time",
            _ => "duel_end_generic"
        };

        public static void DuelStart_Postfix()
        {
            KeyboardShortcuts.IsInDuel = true;
            KeyboardShortcuts.MyLP     = 8000;
            KeyboardShortcuts.OppLP    = 8000;
            GameState.CurrentMenu        = GameState.Menu.Duel;
            GameState.CurrentTurn        = 0;
            GameState.CurrentPlayer      = 0;
            GameState.CurrentPhaseLabel  = "";

            // Réinitialise la déduplication des messages de duel entre deux parties.
            DuelEffectQueuePatch.ResetDuelState();

            Plugin.Instance?.Tts?.Speak(Loc.Get("duel_started"));
        }

        public static void DuelEnd_Postfix()
        {
            KeyboardShortcuts.IsInDuel = false;
            GameState.CurrentMenu      = GameState.Menu.None;
        }
    }
}
