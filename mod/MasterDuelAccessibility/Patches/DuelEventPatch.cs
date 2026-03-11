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

        public static void RunEffect_Postfix(int __0, int __1, int __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            // ViewType 5 = PhaseChange, 6 = TurnChange — délégués à PhasePatch
            if (__0 == 5) { PhasePatch.PhaseChange_Postfix(__1); return; }
            if (__0 == 6) { PhasePatch.TurnChange_Postfix(__1); return; }

            // ── RunCoin (61) : annonce le résultat du lancer de pièce ─────────
            // param1 = numThrows, param2 = faceBits (bit i = 1 → pile/Front, 0 → face/Back)
            // À vérifier en jeu — si les résultats sont incohérents, ajuster le mapping.
            if (__0 == 61)
            {
                string msg = GetCoinResultMessage(__1, __2);
                Plugin.Instance?.LogMsg($"[DuelEventPatch] RunCoin p1={__1} p2={__2} → {msg}");
                tts.Speak(msg, interrupt: true);
                return;
            }

            // ── RunDice (62) : annonce le résultat du lancer de dé ────────────
            // param1 = numThrows(?), param2 = diceResult(?)
            // À vérifier en jeu — log pour diagnostic.
            if (__0 == 62)
            {
                string msg = GetDiceResultMessage(__1, __2);
                Plugin.Instance?.LogMsg($"[DuelEventPatch] RunDice p1={__1} p2={__2} → {msg}");
                tts.Speak(msg, interrupt: true);
                return;
            }

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
                69 => GetCutinSummonKey(__1), // CutinSummon — param1 = CutinSummonType?
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
                72 => GetActivateKey(__1),   // CutinActivate — param1 = CutinActivateType?
                73 => "duel_set",            // CutinSet
                74 => "duel_flip",           // CutinReverse
                77 => "duel_turn_end_event", // CutinTurnEnd
                78 => "duel_damage",         // CutinDamage
                79 => "duel_destroy",        // CutinBreak
                54 => "duel_surrender",      // RunSurrender      [critique]
                64 => "duel_special_win",    // RunSpecialWin     [critique]
                90 => "duel_janken",         // RunJanken         [critique]
                26 => GetCardMoveKey(__1), // CardMove — param1 = Engine.CardMoveType
                28 => "duel_flip_facedown",  // CardFlipTurn — carte retournée face cachée
                34 => "duel_banish",         // CardExclude — carte bannie
                36 => "duel_negate",         // CardDisable — effet nié
                37 => "duel_equip",          // CardEquip — sort d'équipement appliqué
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

        /// <summary>
        /// Engine.CardMoveType (extrait du dump) :
        ///   Normal=0, Draw=9, Drop=10, Search=11, CostDrop=17
        /// Draw(9) ignoré délibérément — CutinDraw(68) l'annonce déjà.
        /// </summary>
        private static string? GetCardMoveKey(int moveType) => moveType switch
        {
            11 => "duel_search",    // Search — carte cherchée depuis le deck
            10 => "duel_discard",   // Drop — carte envoyée de la main au cimetière
            17 => "duel_cost_drop", // CostDrop — défaussée comme coût d'activation
            _  => null              // Draw(9) et autres → pas d'annonce supplémentaire
        };

        /// <summary>
        /// Engine.CutinSummonType (extrait du dump) :
        ///   Normal=0, Release1=1, Release2=2, Release3=3, Reverse=4,
        ///   SpByEffect=5, SpNormal=6, ReSummon=7, PreSynchro=8, PreXyz=9, PrePendulum=10
        ///
        /// Hypothèse : param1 = CutinSummonType. À vérifier en jeu via les logs.
        /// </summary>
        private static string GetCutinSummonKey(int summonType)
        {
            Plugin.Instance?.LogMsg($"[DuelEventPatch] CutinSummon type={summonType}");
            return summonType switch
            {
                4 => "duel_flip_summon",    // Reverse = flip summon
                5 => "duel_special_summon", // SpByEffect = special summon by card effect
                _ => "duel_summon"          // generic fallback
            };
        }

        /// <summary>
        /// Engine.CutinActivateType (extrait du dump) :
        ///   NoChain=0, FromField=1, FromHand=2, Activate=3, Effect=4, FldGrave=5, CostEffect=6
        ///
        /// Hypothèse : param1 = CutinActivateType. À vérifier en jeu via les logs.
        /// </summary>
        private static string GetActivateKey(int activateType)
        {
            Plugin.Instance?.LogMsg($"[DuelEventPatch] CutinActivate type={activateType}");
            return activateType switch
            {
                1 => "duel_activate_field",  // FromField
                2 => "duel_activate_hand",   // FromHand
                5 => "duel_activate_grave",  // FldGrave — from GY
                _ => "duel_activate"         // generic fallback
            };
        }

        private static string GetDuelEndKey(int resultType) => resultType switch
        {
            1 => "duel_end_win",
            2 => "duel_end_lose",
            3 => "duel_end_draw",
            4 => "duel_end_time",
            _ => "duel_end_generic"
        };

        /// <summary>
        /// Décode le résultat d'un lancer de pièce (RunCoin, ViewType 61).
        ///
        /// Hypothèse : param1 = numThrows, param2 = faceBits (bitmask).
        /// DuelCoinDialog.Result : Back=0 (face), Front=1 (pile).
        /// faceBits bit i = 1 → pile (Front), 0 → face (Back).
        /// À vérifier en jeu via les logs.
        /// </summary>
        private static string GetCoinResultMessage(int param1, int param2)
        {
            int numThrows = param1;
            int faceBits = param2;

            if (numThrows <= 0 || numThrows > 10)
                return Loc.Get("duel_coin"); // fallback générique

            if (numThrows == 1)
            {
                bool isFront = (faceBits & 1) == 1;
                return isFront
                    ? Loc.Get("duel_coin_front")
                    : Loc.Get("duel_coin_back");
            }

            // Multiple coins
            int frontCount = 0;
            for (int i = 0; i < numThrows; i++)
                if (((faceBits >> i) & 1) == 1) frontCount++;

            int backCount = numThrows - frontCount;
            return Loc.Get("duel_coin_multi", frontCount, backCount);
        }

        /// <summary>
        /// Décode le résultat d'un lancer de dé (RunDice, ViewType 62).
        ///
        /// Hypothèse : param2 = valeur du dé (1-6).
        /// À vérifier en jeu via les logs.
        /// </summary>
        private static string GetDiceResultMessage(int param1, int param2)
        {
            // Best guess: param2 = dice value
            if (param2 >= 1 && param2 <= 6)
                return Loc.Get("duel_dice_result", param2);

            // Alternative: param1 = dice value
            if (param1 >= 1 && param1 <= 6)
                return Loc.Get("duel_dice_result", param1);

            return Loc.Get("duel_dice"); // fallback générique
        }

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

            Plugin.Instance?.Tts?.Speak(Loc.WithHint(Loc.Get("duel_started"), "hint_help"));
        }

        public static void DuelEnd_Postfix()
        {
            KeyboardShortcuts.IsInDuel = false;
            GameState.CurrentMenu      = GameState.Menu.None;
        }
    }
}
