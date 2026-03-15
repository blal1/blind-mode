using System;
using System.Linq;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les écrans secondaires non couverts par les patches spécialisés :
    ///
    ///   Section 6.4 — Accessoires / cosmétiques de deck :
    ///     IconViewerViewController.NotificationStackEntry()
    ///       → "Aperçu d'icône"
    ///     ItemPreviewViewController.NotificationStackEntry()
    ///       → "[catégorie] : [nom de l'objet]"  (lit m_ItemNameText + m_ItemCategoryText)
    ///     SetAccessoryDialog.NotificationStackEntry()
    ///       → lit m_TextTile.text (titre localisé par le jeu)
    ///
    ///   Section 6.7 — Recherche via Neuron :
    ///     NeuronDeckSearchViewController.NotificationStackEntry()
    ///       → "Recherche Neuron"
    ///
    ///   Section 8.2 — Ouverture de packs :
    ///     LotteryFirstInfoViewController.NotificationStackEntry()
    ///       → "Premier achat — informations"
    ///     LotteryFirstViewViewController.NotificationStackEntry()
    ///       → "Premier achat — aperçu"
    ///     LotterySubmissionViewController.NotificationStackEntry()
    ///       → "Confirmation d'achat de pack"
    ///
    ///   Section 8.3 — Résultat et historique :
    ///     LotteryHistoryViewController.NotificationStackEntry()
    ///       → "Historique des packs ouverts"
    ///
    ///   Section 8.4 — Taux et packs secrets :
    ///     CardPackRateListViewController.NotificationStackEntry()
    ///       → "Taux de drop"
    ///     SecretPackObtainViewController.NotificationStackEntry()
    ///       → "Pack secret débloqué : [nom]"  (lit m_PackName string)
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches() — types chargés dynamiquement.
    /// </summary>
    internal static class MiscViewsPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            // ── Cosmétiques deck ──────────────────────────────────────────────
            PatchNSE(harmony, "IconViewerViewController",              nameof(IconViewer_Postfix),      "IconViewerViewController");
            PatchNSE(harmony, "YgomGame.Menu.ItemPreviewViewController",  nameof(ItemPreview_Postfix),  "ItemPreviewViewController");
            PatchNSE(harmony, "YgomGame.Deck.SetAccessoryDialog",         nameof(SetAccessory_Postfix), "SetAccessoryDialog");

            // ── Neuron ────────────────────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Menu.NeuronDeckSearchViewController", nameof(NeuronDeckSearch_Postfix), "NeuronDeckSearchViewController");

            // ── Lottery / packs ───────────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Lottery.LotteryFirstInfoViewController",  nameof(LotteryFirstInfo_Postfix),  "LotteryFirstInfoViewController");
            PatchNSE(harmony, "YgomGame.Lottery.LotteryFirstViewViewController",  nameof(LotteryFirstView_Postfix),  "LotteryFirstViewViewController");
            PatchNSE(harmony, "YgomGame.Lottery.LotterySubmissionViewController", nameof(LotterySubmission_Postfix), "LotterySubmissionViewController");
            PatchNSE(harmony, "YgomGame.Lottery.LotteryHistoryViewController",    nameof(LotteryHistory_Postfix),    "LotteryHistoryViewController");
            PatchNSE(harmony, "YgomGame.CardPack.CardPackRateListViewController", nameof(PackRateList_Postfix),      "CardPackRateListViewController");
            PatchNSE(harmony, "YgomGame.CardPack.SecretPackObtainViewController", nameof(SecretPack_Postfix),        "SecretPackObtainViewController");

            // ── Solo / Scénario ───────────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Solo.SoloModeViewController",              nameof(SoloMode_Postfix),             "SoloModeViewController");
            PatchNSE(harmony, "YgomGame.Solo.SoloPortalViewController",            nameof(SoloPortal_Postfix),           "SoloPortalViewController");
            PatchNSE(harmony, "YgomGame.Solo.SoloStartProductionViewController",   nameof(SoloStartProduction_Postfix),  "SoloStartProductionViewController");
            PatchNSE(harmony, "YgomGame.Solo.SoloClearViewController",             nameof(SoloClear_Postfix),            "SoloClearViewController");
            PatchNSE(harmony, "YgomGame.Scenario.ScenarioVolumeViewController",    nameof(ScenarioVolume_Postfix),       "ScenarioVolumeViewController");

            // ── Colosseum (section 18) ────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumStartViewController",     nameof(ColosseumStart_Postfix),   "ColosseumStartViewController");
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumInfoViewController",      nameof(ColosseumInfo_Postfix),    "ColosseumInfoViewController");
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumHistoryViewController",   nameof(ColosseumHistory_Postfix), "ColosseumHistoryViewController");
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumRankingViewController",   nameof(ColosseumRanking_Postfix), "ColosseumRankingViewController");
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumRewardViewController",    nameof(ColosseumReward_Postfix),  "ColosseumRewardViewController");
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumSelectVersusViewController", nameof(ColosseumVersus_Postfix), "ColosseumSelectVersusViewController");

            // ── TDY / Tag Duel (section 21) ───────────────────────────────────
            PatchNSE(harmony, "YgomGame.Tdy.TDYMapViewController",   nameof(TdyMap_Postfix),    "TDYMapViewController");
            PatchNSE(harmony, "YgomGame.Tdy.TdyResultViewController", nameof(TdyResult_Postfix), "TdyResultViewController");

            // ── Panel Missions / Événements cartes (section 12.3) ─────────────
            PatchNSE(harmony, "PanelMissionContent", nameof(PanelMission_Postfix), "PanelMissionContent");

            // PanelMissionContent.OnSelectedPanel(PanelWidget) — navigation dans la carte
            var panelMissionType = AccessToolsHelper.FindType("PanelMissionContent")
                                ?? AccessToolsHelper.FindType("YgomGame.PanelMission.PanelMissionContent");
            if (panelMissionType != null)
            {
                var mOnSelected = panelMissionType.GetMethod("OnSelectedPanel",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mOnSelected != null)
                {
                    harmony.Patch(mOnSelected, postfix: new HarmonyLib.HarmonyMethod(
                        typeof(MiscViewsPatch), nameof(PanelMissionSelected_Postfix)));
                    Plugin.Instance?.LogMsg("[MiscViewsPatch] ✓ PanelMissionContent.OnSelectedPanel");
                }
                else
                    Plugin.Instance?.LogWarn("[MiscViewsPatch] PanelMissionContent.OnSelectedPanel introuvable.");
            }

            // ── Team (section 19) ────────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Team.TeamCreateViewController",               nameof(TeamCreate_Postfix),         "TeamCreateViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamDesignationViewController",          nameof(TeamDesignation_Postfix),    "TeamDesignationViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamInfoViewController",                 nameof(TeamInfo_Postfix),           "TeamInfoViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamNameSelectViewController",           nameof(TeamNameSelect_Postfix),     "TeamNameSelectViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamRegulationSetSelectViewController",  nameof(TeamRegulation_Postfix),     "TeamRegulationSetSelectViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamMemberViewController",               nameof(TeamMember_Postfix),         "TeamMemberViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamInviteViewController",               nameof(TeamInvite_Postfix),         "TeamInviteViewController",         bypassOriginal: true);
            PatchNSE(harmony, "YgomGame.Team.TeamLeaderMatchingViewController",       nameof(TeamLeaderMatching_Postfix), "TeamLeaderMatchingViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamMemberMatchingViewController",       nameof(TeamMemberMatching_Postfix), "TeamMemberMatchingViewController");
            PatchNSE(harmony, "YgomGame.Team.TeamMemberMatchedViewController",        nameof(TeamMemberMatched_Postfix),  "TeamMemberMatchedViewController",  bypassOriginal: true);
            PatchNSE(harmony, "YgomGame.Team.TeamWaitingWindowViewController",        nameof(TeamWaiting_Postfix),        "TeamWaitingWindowViewController",  bypassOriginal: true);
            PatchNSE(harmony, "YgomGame.Team.TeamResultViewController",               nameof(TeamResult_Postfix),         "TeamResultViewController",         bypassOriginal: true);
            PatchNSE(harmony, "YgomGame.Team.TeamResultEffectViewController",         nameof(TeamResult_Postfix),         "TeamResultEffectViewController",   bypassOriginal: true);
            PatchNSE(harmony, "YgomGame.Team.TeamRoomViewController",                 nameof(TeamRoom_Postfix),           "TeamRoomViewController",           bypassOriginal: true);

            // ── WCS (section 20) ─────────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.WCS.Portal.TopMenuViewController",  nameof(WcsMenu_Postfix),       "WCS TopMenuViewController");
            PatchNSE(harmony, "YgomGame.WCS.WatchMenuViewController",       nameof(WcsWatch_Postfix),      "WatchMenuViewController");
            PatchNSE(harmony, "YgomGame.WCS.WCSBattleInfoBaseViewController", nameof(WcsBattleInfo_Postfix), "WCSBattleInfoBaseViewController");
            PatchNSE(harmony, "YgomGame.WCS.WCSTeamRoomViewController",     nameof(WcsTeamRoom_Postfix),   "WCSTeamRoomViewController");

            // ── Colosseum résultats supplémentaires (section 18.2) ────────────
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumResultViewController", nameof(ColosseumResult_Postfix), "ColosseumResultViewController");

            // ── WCS Arène et Timer (section 20.2) ────────────────────────────
            PatchNSE(harmony, "WCSFinal_ColosseumViewController", nameof(WcsFinalArena_Postfix), "WCSFinal_ColosseumViewController");
            PatchNSE(harmony, "WCSFinal_TimerViewController",     nameof(WcsFinalTimer_Postfix), "WCSFinal_TimerViewController");

            // ── TurnOverPrize (section 27) ────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Prize.TurnOverPrize.TurnOverPrizeOpenViewController", nameof(TurnOverPrizeOpen_Postfix), "TurnOverPrizeOpenViewController");
            // RVA 0x3E4080 (empty stub) → bypass required
            PatchNSE(harmony, "TurnOverPrizeCollabEditViewController", nameof(TurnOverPrizeCollab_Postfix), "TurnOverPrizeCollabEditViewController", bypassOriginal: true);

            // ── DiceRally (section 18.3) ──────────────────────────────────────
            PatchNSE(harmony, "DiceRallyMapEditor.DiceRallyMapEditorViewController", nameof(DiceRallyMapEditor_Postfix), "DiceRallyMapEditorViewController");
            PatchNSE(harmony, "YgomGame.SubMenu.DiceRallySubMenuViewController",    nameof(DiceRallySubMenu_Postfix),   "DiceRallySubMenuViewController");

            // ── Colosseum supplémentaires (section 18.4) ─────────────────────
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumRankingViewController_Rate",   nameof(ColosseumRankingRate_Postfix),   "ColosseumRankingViewController_Rate");
            // RVA 0x3E4080 (empty stub) → bypass required
            PatchNSE(harmony, "YgomGame.Colosseum.ColosseumRewardDiceRallyViewController", nameof(ColosseumRewardDiceRally_Postfix), "ColosseumRewardDiceRallyViewController", bypassOriginal: true);

            // ── WCS Finale timer settings (section 20.3) ─────────────────────
            // RVA 0x3E4080 (empty stub) → bypass required
            PatchNSE(harmony, "WCSFinal_TimerSettingViewController", nameof(WcsFinalTimerSetting_Postfix), "WCSFinal_TimerSettingViewController", bypassOriginal: true);

            // ── DuelLive — écran principal (section 22) ───────────────────────
            // NSE à RVA 0xA0D640 (réel)
            PatchNSE(harmony, "YgomGame.DuelLive.DuelLiveViewController", nameof(DuelLive_Postfix), "DuelLiveViewController");

            // ── DuelLive — sélection carte (section 22) ───────────────────────
            PatchNSE(harmony, "YgomGame.DuelLive.DuelLiveSelectCardDialogViewController", nameof(DuelLiveSelectCard_Postfix), "DuelLiveSelectCardDialogViewController");

            // ── LotteryCardSelect (section 8) ────────────────────────────────
            // NSE à RVA 0xD9C590 (réel) — annonce vue + taille du pool
            PatchNSE(harmony, "LotteryCardSelectViewController", nameof(LotteryCardSelect_Postfix), "LotteryCardSelectViewController");

            // ── Card File (section 25) ────────────────────────────────────────
            PatchNSE(harmony, "YgomGame.CardFile.CardFileViewController",      nameof(CardFile_Postfix),        "CardFileViewController");
            PatchNSE(harmony, "YgomGame.CardFile.CardFileCardGetDialog",       nameof(CardFileCardGet_Postfix), "CardFileCardGetDialog");
            // NSE à RVA 0xCF0300 (réel) + OnEntityUpdate pour navigation ISV
            PatchNSE(harmony, "YgomGame.CardFile.CardFileTableViewController", nameof(CardFileTable_NSE_Postfix), "CardFileTableViewController");
            var cardFileTableType = AccessToolsHelper.FindType("YgomGame.CardFile.CardFileTableViewController");
            if (cardFileTableType != null)
            {
                var mEntity = cardFileTableType.GetMethod("OnEntityUpdate",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mEntity != null)
                {
                    harmony.Patch(mEntity, postfix: new HarmonyLib.HarmonyMethod(
                        typeof(MiscViewsPatch), nameof(CardFileTable_Entity_Postfix)));
                    Plugin.Instance?.LogMsg("[MiscViewsPatch] ✓ CardFileTableViewController.OnEntityUpdate");
                }
                else Plugin.Instance?.LogWarn("[MiscViewsPatch] CardFileTableViewController.OnEntityUpdate introuvable.");
            }

            // ── Déconnexion réseau sans dialog (section 31) ───────────────────
            // UINetworkHandler.networkDisconnectErrorDialog — annonce avant d'ouvrir le dialog
            var networkType = AccessToolsHelper.FindType("UINetworkHandler");
            if (networkType != null)
            {
                var mDisconnect = networkType.GetMethod("networkDisconnectErrorDialog",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mDisconnect != null)
                {
                    harmony.Patch(mDisconnect, prefix: new HarmonyLib.HarmonyMethod(
                        typeof(MiscViewsPatch), nameof(NetworkDisconnect_Prefix)));
                    Plugin.Instance?.LogMsg("[MiscViewsPatch] ✓ UINetworkHandler.networkDisconnectErrorDialog");
                }
                else Plugin.Instance?.LogWarn("[MiscViewsPatch] UINetworkHandler.networkDisconnectErrorDialog introuvable.");
            }

            // ── Certification (section 24) ────────────────────────────────────
            PatchNSE(harmony, "YgomGame.Certification.CertificationConfirmViewController",      nameof(CertificationConfirm_Postfix),      "CertificationConfirmViewController");
            PatchNSE(harmony, "YgomGame.Certification.CertificationDetailViewController",       nameof(CertificationDetail_Postfix),       "CertificationDetailViewController");
            PatchNSE(harmony, "YgomGame.Certification.CertificationExplanationViewController",  nameof(CertificationExplanation_Postfix),  "CertificationExplanationViewController");
            PatchNSE(harmony, "YgomGame.Certification.CertificationDuelFieldDialogViewController", nameof(CertificationDuelField_Postfix), "CertificationDuelFieldDialogViewController");
            PatchNSE(harmony, "YgomGame.Certification.CertificationWritingViewController",      nameof(CertificationWriting_Postfix),      "CertificationWritingViewController");
            PatchNSE(harmony, "YgomGame.Certification.CertificationWritingReslutViewController", nameof(CertificationResult_Postfix),     "CertificationWritingReslutViewController");

            // ── Dialogs secondaires (section 17.2) ────────────────────────────
            PatchNSE(harmony, "YgomGame.Menu.PlaceHolderDialogViewController",    nameof(PlaceHolder_Postfix),     "PlaceHolderDialogViewController");
            PatchNSE(harmony, "YgomGame.Menu.TextureImageDialogViewController",   nameof(TextureImage_Postfix),    "TextureImageDialogViewController");
            PatchNSE(harmony, "YgomGame.PasswordDialogViewController",            nameof(PasswordDialog_Postfix),  "PasswordDialogViewController");
            PatchNSE(harmony, "YgomGame.Menu.SaveDialogViewController",           nameof(SaveDialog_NSE_Postfix),  "SaveDialogViewController");
            // Patch SaveDialog.Open(title, message, 3×(label+Action)) — 8 params
            PatchOpen(harmony, "YgomGame.Menu.SaveDialogViewController", "Open", 8, nameof(SaveDialog_Open_Postfix));

            // ── PromoCodes (section 26) ───────────────────────────────────────
            // NSE à RVA 0x8ED800 (réel)
            PatchNSE(harmony, "YgomGame.PromoCodes.PromoCodesViewController", nameof(PromoCodes_Postfix), "PromoCodesViewController");

            // ── Market Pool (section 28) ──────────────────────────────────────
            // NSE à RVA 0x3E4080 (stub vide) → bypassOriginal requis
            PatchNSE(harmony, "YgomGame.Market.MarketPoolViewController", nameof(MarketPool_Postfix), "MarketPoolViewController", bypassOriginal: true);
            // OnCreatedView à RVA 0x976690 (réel) — annonce le nom du marché
            var marketType = AccessToolsHelper.FindType("YgomGame.Market.MarketPoolViewController");
            if (marketType != null)
            {
                var mOnCreated = marketType.GetMethod("OnCreatedView",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mOnCreated != null)
                {
                    harmony.Patch(mOnCreated, postfix: new HarmonyLib.HarmonyMethod(
                        typeof(MiscViewsPatch), nameof(MarketPoolOnCreated_Postfix)));
                    Plugin.Instance?.LogMsg("[MiscViewsPatch] ✓ MarketPoolViewController.OnCreatedView");
                }
                else Plugin.Instance?.LogWarn("[MiscViewsPatch] MarketPoolViewController.OnCreatedView introuvable.");
            }

            _applied = true;
        }

        private static void PatchOpen(
            HarmonyLib.Harmony harmony, string typeName, string methodName, int paramCount, string postfixName)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null) { Plugin.Instance?.LogWarn($"[MiscViewsPatch] {typeName} introuvable."); return; }
            var m = System.Array.Find(t.GetMethods(), x =>
                x.Name == methodName && x.GetParameters().Length == paramCount);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] {typeName}.{methodName} ({paramCount} params) introuvable.");
                return;
            }
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(MiscViewsPatch), postfixName));
            Plugin.Instance?.LogMsg($"[MiscViewsPatch] ✓ {typeName}.{methodName} ({paramCount} params)");
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel,
            bool bypassOriginal = false)
        {
            var t = AccessToolsHelper.FindType(typeName);
            if (t == null)
            {
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] {logLabel} introuvable.");
                return;
            }
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] {logLabel}.NotificationStackEntry introuvable.");
                return;
            }

            // bypassOriginal=true : patch avec prefix qui retourne false pour ne PAS appeler
            // l'original — nécessaire pour les méthodes à stub vide (RVA partagé 0x3E4080) qui
            // causent une récursion vtable infinie via il2cpp_runtime_invoke (stack overflow).
            // Harmony garantit que les postfix s'exécutent quand même même si le prefix
            // retourne false. On peut donc conserver le postfix pour l'annonce TTS.
            HarmonyLib.HarmonyMethod? prefix = bypassOriginal
                ? new HarmonyLib.HarmonyMethod(typeof(MiscViewsPatch), nameof(NseEmptyStubSkip_Prefix))
                : null;

            harmony.Patch(m,
                prefix: prefix,
                postfix: new HarmonyLib.HarmonyMethod(typeof(MiscViewsPatch), postfixName));
            Plugin.Instance?.LogMsg($"[MiscViewsPatch] ✓ {logLabel}.NotificationStackEntry{(bypassOriginal ? " [bypass]" : "")}");
        }

        /// <summary>
        /// Prefix universel pour les stubs NSE vides (RVA 0x3E4080).
        /// Retourne false → empêche l'appel de l'original via il2cpp_runtime_invoke,
        /// ce qui évite la récursion de vtable IL2CPP → stack overflow.
        /// Les postfix s'exécutent quand même (comportement Harmony standard).
        /// </summary>
        private static bool NseEmptyStubSkip_Prefix() => false;

        // ── Postfixes — simples (Loc string) ─────────────────────────────────

        public static void IconViewer_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("icon_viewer"), interrupt: false);

        public static void NeuronDeckSearch_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("neuron_deck_search"), interrupt: false);

        public static void LotteryFirstInfo_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("lottery_first_info"), interrupt: false);

        public static void LotteryFirstView_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("lottery_first_view"), interrupt: false);

        public static void LotterySubmission_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("lottery_submission"), interrupt: false);

        public static void LotteryHistory_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("lottery_history"), interrupt: false);

        public static void PackRateList_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("pack_rate_list"), interrupt: false);

        public static void SoloPortal_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("solo_portal"), interrupt: false);

        public static void SoloStartProduction_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("solo_start_production"), interrupt: false);

        /// <summary>
        /// SoloClearViewController : reads type field (ClearType enum) to announce clear/complete.
        /// ClearType: RENTAL=0, MYDECK=1, COMPLETE=2, GOAL=3
        /// </summary>
        public static void SoloClear_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = FindField(__instance.GetType(), "type");
                int clearType = f != null ? Convert.ToInt32(f.GetValue(__instance)) : -1;
                string key = clearType switch
                {
                    2 => "solo_clear_complete",
                    3 => "solo_clear_goal",
                    _ => "solo_clear"
                };
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("solo_clear"), interrupt: false); }
        }

        public static void ScenarioVolume_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("scenario_volume"), interrupt: false);

        // ── Postfixes — dialogs secondaires (section 17.2) ───────────────────

        public static void PlaceHolder_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("placeholder_dialog"), interrupt: false);

        /// <summary>
        /// TextureImageDialogViewController : reads the 'caption' (UnityEngine.UI.Text)
        /// field to announce the image title, e.g. "Protège-cartes : Magicien Sombre".
        /// </summary>
        public static void TextureImage_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f    = FindField(__instance.GetType(), "caption");
                var comp = f?.GetValue(__instance);
                string? text = comp != null
                    ? comp.GetType()
                        .GetProperty("text", BindingFlags.Public | BindingFlags.Instance)
                        ?.GetValue(comp) as string
                    : null;
                tts.Speak(!string.IsNullOrWhiteSpace(text) ? text! : Loc.Get("texture_image_dialog"),
                    interrupt: false);
            }
            catch { tts.Speak(Loc.Get("texture_image_dialog"), interrupt: false); }
        }

        /// <summary>
        /// PasswordDialogViewController : reads the INPUT_LABEL string field
        /// to tell the user what they are entering.
        /// </summary>
        public static void PasswordDialog_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f     = FindField(__instance.GetType(), "INPUT_LABEL");
                string? label = f?.GetValue(__instance) as string;
                tts.Speak(!string.IsNullOrWhiteSpace(label)
                    ? Loc.Get("password_dialog_label", label!)
                    : Loc.Get("password_dialog"),
                    interrupt: false);
            }
            catch { tts.Speak(Loc.Get("password_dialog"), interrupt: false); }
        }

        // SaveDialogViewController NSE — generic fallback
        public static void SaveDialog_NSE_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("save_dialog"), interrupt: false);

        /// <summary>
        /// SaveDialogViewController.Open(title, message, 3×label+Action) — 8 params.
        /// __0 = title, __1 = message. Announces "[title]. [message]." when both present.
        /// </summary>
        public static void SaveDialog_Open_Postfix(string __0, string __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string msg = !string.IsNullOrWhiteSpace(__0) && !string.IsNullOrWhiteSpace(__1)
                    ? Loc.Get("dialog_title_message", __0, __1)
                    : !string.IsNullOrWhiteSpace(__0) ? __0! : Loc.Get("save_dialog");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        // ── Postfixes — avec lecture de champs ───────────────────────────────

        /// <summary>
        /// SecretPackObtainViewController : reads m_PackName (string at 0x118).
        /// Announces "Pack secret débloqué : [nom]" or generic fallback.
        /// </summary>
        public static void SecretPack_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = FindField(__instance.GetType(), "m_PackName");
                string? packName = f?.GetValue(__instance) as string;
                string msg = string.IsNullOrWhiteSpace(packName)
                    ? Loc.Get("secret_pack_obtained")
                    : Loc.Get("secret_pack_obtained_name", packName);
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("secret_pack_obtained"), interrupt: false); }
        }

        /// <summary>
        /// SetAccessoryDialog : reads m_TextTile (TMP_Text at 0xE0) for the dialog title.
        /// Falls back to generic "Personnalisation du deck".
        /// </summary>
        public static void SetAccessory_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = FindField(__instance.GetType(), "m_TextTile");
                var tmp = f?.GetValue(__instance);
                string? title = tmp != null
                    ? tmp.GetType().GetProperty("text",
                        BindingFlags.Public | BindingFlags.Instance)?.GetValue(tmp) as string
                    : null;
                string msg = string.IsNullOrWhiteSpace(title)
                    ? Loc.Get("set_accessory_dialog")
                    : title!;
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("set_accessory_dialog"), interrupt: false); }
        }

        /// <summary>
        /// ItemPreviewViewController : reads m_ItemCategoryText + m_ItemNameText (TMP at 0x1C8/0x1B8).
        /// Announces "[catégorie] : [nom]" or generic "Aperçu de l'objet".
        /// </summary>
        public static void ItemPreview_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                string? catText  = ReadTmpField(t, __instance, "m_ItemCategoryText");
                string? nameText = ReadTmpField(t, __instance, "m_ItemNameText");

                if (string.IsNullOrWhiteSpace(nameText))
                {
                    tts.Speak(Loc.Get("item_preview"), interrupt: false);
                    return;
                }

                string msg = string.IsNullOrWhiteSpace(catText)
                    ? nameText!
                    : $"{catText} : {nameText}";
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("item_preview"), interrupt: false); }
        }

        // ── Postfixes — Colosseum (section 18) ──────────────────────────────

        /// <summary>
        /// ColosseumStartViewController : reads prefabType to describe the Colosseum mode.
        /// PrefabType: STANDARD=0, TOURNAMENT=1, WCS=2, TOURNAMENT_NOMESSAGE=3
        /// </summary>
        public static void ColosseumStart_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = FindField(__instance.GetType(), "prefabType");
                int mode = f != null ? Convert.ToInt32(f.GetValue(__instance)) : 0;
                string key = mode switch
                {
                    1 => "colosseum_start_tournament",
                    2 => "colosseum_start_wcs",
                    _ => "colosseum_start"
                };
                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("colosseum_start"), interrupt: false); }
        }

        public static void ColosseumInfo_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_info"), interrupt: false);

        public static void ColosseumHistory_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_history"), interrupt: false);

        public static void ColosseumRanking_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_ranking"), interrupt: false);

        public static void ColosseumReward_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_reward"), interrupt: false);

        public static void ColosseumVersus_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_versus"), interrupt: false);

        // ── Postfixes — TDY / Tag Duel (section 21) ─────────────────────────

        public static void TdyMap_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("tdy_map"), interrupt: false);

        /// <summary>
        /// TdyResultViewController : reads m_IsCompleteKizuna (bool) for extra detail.
        /// Announces "Résultat Tag Duel — Kizuna complète !" when the bond is complete.
        /// </summary>
        public static void TdyResult_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = FindField(__instance.GetType(), "m_IsCompleteKizuna");
                bool kizuna = f != null && Convert.ToBoolean(f.GetValue(__instance));
                tts.Speak(Loc.Get(kizuna ? "tdy_result_kizuna" : "tdy_result"), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("tdy_result"), interrupt: false); }
        }

        // ── Postfixes — Panel Missions (section 12.3) ────────────────────────

        public static void PanelMission_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("panel_mission"), interrupt: false);

        // Cache de réflexion pour PanelWidget
        private static PropertyInfo? _propPanelTitle;
        private static PropertyInfo? _propPanelProgress;
        private static PropertyInfo? _propPanelExistsProgress;
        private static PropertyInfo? _propTmpText;

        /// <summary>
        /// PanelMissionContent.OnSelectedPanel(PanelWidget) — utilisateur navigue vers un panneau.
        /// Annonce : "{titre}. {progression}." ou juste "{titre}."
        /// </summary>
        public static void PanelMissionSelected_Postfix(object __instance, object __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || __0 == null) return;
            try
            {
                var pw = __0.GetType();

                // Cache les propriétés sur le type PanelWidget la première fois
                if (_propPanelTitle == null)
                {
                    _propPanelTitle       = pw.GetProperty("titleText",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    _propPanelProgress    = pw.GetProperty("progressText",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    _propPanelExistsProgress = pw.GetProperty("existsProgressText",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                }

                // Lire titleText.text via reflection TMP_Text
                string? title = ReadTmpText(__0, _propPanelTitle);
                if (string.IsNullOrWhiteSpace(title)) return;

                // Lire progressText.text si existsProgressText == true
                string? progress = null;
                bool existsProgress = Convert.ToBoolean(_propPanelExistsProgress?.GetValue(__0) ?? false);
                if (existsProgress)
                    progress = ReadTmpText(__0, _propPanelProgress);

                string msg = !string.IsNullOrWhiteSpace(progress)
                    ? Loc.Get("panel_mission_item", title!, progress!)
                    : title!;
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] PanelMissionSelected: {ex.Message}");
            }
        }

        /// <summary>
        /// Lit le .text d'une propriété qui retourne un TMP_Text.
        /// </summary>
        private static string? ReadTmpText(object owner, PropertyInfo? prop)
        {
            if (prop == null) return null;
            var tmpObj = prop.GetValue(owner);
            if (tmpObj == null) return null;

            if (_propTmpText == null)
                _propTmpText = tmpObj.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                    ?? tmpObj.GetType().BaseType?.GetProperty("text",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);

            return _propTmpText?.GetValue(tmpObj)?.ToString();
        }

        // ── Postfixes — Team (section 19) ────────────────────────────────────

        public static void TeamCreate_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_create"), interrupt: false);
        public static void TeamDesignation_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_designation"), interrupt: false);
        public static void TeamInfo_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_info"), interrupt: false);
        public static void TeamNameSelect_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_name_select"), interrupt: false);
        public static void TeamRegulation_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_regulation"), interrupt: false);
        public static void TeamMember_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_members"), interrupt: false);
        public static void TeamInvite_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_invite"), interrupt: false);
        public static void TeamLeaderMatching_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_leader_matching"), interrupt: false);
        public static void TeamMemberMatching_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_member_matching"), interrupt: false);
        public static void TeamMemberMatched_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_member_matched"), interrupt: false);
        public static void TeamWaiting_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_waiting"), interrupt: false);
        public static void TeamResult_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_result"), interrupt: false);
        public static void TeamRoom_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("team_room"), interrupt: false);

        // ── Postfixes — WCS (section 20) ─────────────────────────────────────

        public static void WcsMenu_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("wcs_menu"), interrupt: false);
        public static void WcsWatch_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("wcs_watch"), interrupt: false);
        public static void WcsBattleInfo_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("wcs_battle_info"), interrupt: false);
        public static void WcsTeamRoom_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("wcs_team_room"), interrupt: false);

        // ── Postfixes — Colosseum résultats (section 18.2) ───────────────────

        public static void ColosseumResult_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_result"), interrupt: false);

        // ── Postfixes — Solo mode (section 9.1) ─────────────────────────────

        public static void SoloMode_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("solo_mode"), interrupt: false);

        // ── Postfixes — WCS Arène et Timer (section 20.2) ───────────────────

        public static void WcsFinalArena_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("wcs_final_arena"), interrupt: false);

        /// <summary>
        /// WCSFinal_TimerViewController : reads the last set hours/minutes/seconds
        /// from static fields to announce the configured timer value.
        /// Fallback: "Minuterie WCS."
        /// </summary>
        public static void WcsFinalTimer_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                int h = Convert.ToInt32(FindField(t, "lastsethour")?.GetValue(__instance) ?? 0);
                int m = Convert.ToInt32(FindField(t, "lastsetminute")?.GetValue(__instance) ?? 0);
                int s = Convert.ToInt32(FindField(t, "lastsetsecond")?.GetValue(__instance) ?? 0);
                string msg = (h + m + s > 0)
                    ? Loc.Get("wcs_final_timer_value", h, m, s)
                    : Loc.Get("wcs_final_timer");
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("wcs_final_timer"), interrupt: false); }
        }

        // ── Postfixes — TurnOverPrize (section 27) ───────────────────────────

        public static void TurnOverPrizeOpen_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("turn_over_prize_open"), interrupt: false);

        // ── Postfixes — Card File (section 25) ───────────────────────────────

        /// <summary>
        /// CardFileViewController : reads cfManager.cfi.possessingCardNum / totalCardNum.
        /// Announces "Collection : N / M cartes (X%)" or generic fallback.
        /// </summary>
        public static void CardFile_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // cfManager property → CardFileManager
                var t = __instance.GetType();
                var cfmProp = t.GetProperty("cfManager",
                    BindingFlags.Public | BindingFlags.Instance);
                var cfm = cfmProp?.GetValue(__instance);
                if (cfm == null) { tts.Speak(Loc.Get("screen_card_file"), interrupt: false); return; }

                // cfi property → CardFileInfo
                var cfiProp = cfm.GetType().GetProperty("cfi",
                    BindingFlags.Public | BindingFlags.Instance);
                var cfi = cfiProp?.GetValue(cfm);
                if (cfi == null) { tts.Speak(Loc.Get("screen_card_file"), interrupt: false); return; }

                var cfiType = cfi.GetType();
                var possessed = Convert.ToInt32(
                    cfiType.GetField("possessingCardNum",
                        BindingFlags.Public | BindingFlags.Instance)?.GetValue(cfi) ?? 0);
                var totalProp = cfiType.GetProperty("totalCardNum",
                    BindingFlags.Public | BindingFlags.Instance);
                var total = Convert.ToInt32(totalProp?.GetValue(cfi) ?? 0);

                if (total > 0)
                {
                    int pct = possessed * 100 / total;
                    tts.Speak(Loc.Get("card_file_open", possessed, total, pct), interrupt: false);
                }
                else
                    tts.Speak(Loc.Get("screen_card_file"), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("screen_card_file"), interrupt: false); }
        }

        /// <summary>
        /// CardFileCardGetDialog : reads m_BeforeHaveNum, m_AfterHaveNum, m_CompleteNum.
        /// Announces "Nouvelle carte. Avant : N, après : M. Complétées : C."
        /// </summary>
        public static void CardFileCardGet_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                int before   = Convert.ToInt32(FindField(t, "m_BeforeHaveNum")?.GetValue(__instance) ?? -1);
                int after    = Convert.ToInt32(FindField(t, "m_AfterHaveNum")?.GetValue(__instance) ?? -1);
                int complete = Convert.ToInt32(FindField(t, "m_CompleteNum")?.GetValue(__instance) ?? -1);

                if (before >= 0 && after >= 0)
                    tts.Speak(Loc.Get("card_file_card_get_detail", before, after, complete), interrupt: false);
                else
                    tts.Speak(Loc.Get("card_file_card_get"), interrupt: false);
            }
            catch { tts.Speak(Loc.Get("card_file_card_get"), interrupt: false); }
        }

        // ── Postfixes — CardFileTable (section 25) ───────────────────────────

        /// <summary>
        /// CardFileTableViewController.NotificationStackEntry (RVA 0xCF0300).
        /// Annonce : "Fichiers de cartes. N fichier(s)." si m_TableDataList peuplée.
        /// </summary>
        public static void CardFileTable_NSE_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var fList = FindField(__instance.GetType(), "m_TableDataList");
                int count = 0;
                if (fList?.GetValue(__instance) is System.Collections.ICollection col)
                    count = col.Count;
                string msg = count > 0
                    ? Loc.Get("card_file_table_open_count", count)
                    : Loc.Get("card_file_table_open");
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("card_file_table_open"), interrupt: false); }
        }

        // Cache dédup pour CardFileTable ISV
        private static int _cfLastEntityIndex = -1;
        private static string? _cfLastEntityText;

        /// <summary>
        /// CardFileTableViewController.OnEntityUpdate(GameObject gob, int dataindex).
        /// Lit le nom du fichier de carte depuis les TMP_Text de l'entité GO.
        /// 200 ms dedup par index pour éviter les doubles sur le même item.
        /// </summary>
        public static void CardFileTable_Entity_Postfix(object __instance, UnityEngine.GameObject gob, int dataindex)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || gob == null) return;
            try
            {
                // Dédup : même index que le dernier item annoncé → skip
                if (dataindex == _cfLastEntityIndex) return;
                _cfLastEntityIndex = dataindex;

                // Lire le texte du nom depuis les TMP_Text de l'entité
                var tmpType = AccessToolsHelper.FindType("TMPro.TMP_Text")
                           ?? AccessToolsHelper.FindType("TMPro.TextMeshProUGUI");
                if (tmpType == null) return;

                var textProp = tmpType.GetProperty("text", BindingFlags.Public | BindingFlags.Instance);
                var comps = gob.GetComponentsInChildren(Il2CppInterop.Runtime.Il2CppType.From(tmpType), true);
                if (comps == null) return;

                // Collecter les textes non vides — le premier long (>2 chars) = nom du fichier
                string? name = null;
                string? progress = null;
                foreach (var comp in comps)
                {
                    if (comp == null) continue;
                    string? txt = textProp?.GetValue(comp)?.ToString();
                    if (string.IsNullOrWhiteSpace(txt)) continue;
                    if (name == null && txt.Length > 2)
                        name = txt;
                    else if (progress == null && (txt.Contains("/") || txt.All(char.IsDigit)))
                        progress = txt;
                    if (name != null && progress != null) break;
                }

                if (string.IsNullOrWhiteSpace(name)) return;

                string msg = !string.IsNullOrWhiteSpace(progress)
                    ? Loc.Get("card_file_table_item", name!, progress!)
                    : name!;

                // Dedup par texte
                if (msg == _cfLastEntityText) return;
                _cfLastEntityText = msg;

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] CardFileTable.OnEntityUpdate: {ex.Message}");
            }
        }

        // ── Prefix — Déconnexion réseau (section 31) ─────────────────────────

        /// <summary>
        /// UINetworkHandler.networkDisconnectErrorDialog — annonce la déconnexion
        /// AVANT que le dialog système s'ouvre (SystemDialogPatch couvre le dialog lui-même).
        /// </summary>
        public static void NetworkDisconnect_Prefix(object __instance)
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("network_disconnect"), interrupt: true);
        }

        // ── Postfixes — DiceRally (section 18.3) ─────────────────────────────

        public static void DiceRallyMapEditor_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("dice_rally_map_editor"), interrupt: false);

        public static void DiceRallySubMenu_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("dice_rally_submenu"), interrupt: false);

        // ── Postfixes — Colosseum supplémentaires (section 18.4) ─────────────

        public static void ColosseumRankingRate_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_ranking_rate"), interrupt: false);

        public static void ColosseumRewardDiceRally_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("colosseum_reward_dice_rally"), interrupt: false);

        // ── Postfixes — TurnOverPrize collab (section 27) ────────────────────

        public static void TurnOverPrizeCollab_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("turn_over_prize_collab"), interrupt: false);

        // ── Postfixes — WCS Finale timer settings (section 20.3) ─────────────

        public static void WcsFinalTimerSetting_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("wcs_final_timer_setting"), interrupt: false);

        // ── Postfixes — DuelLive (section 22) ────────────────────────────────

        public static void DuelLive_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("screen_duel_live"), interrupt: false);

        public static void DuelLiveSelectCard_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("duel_live_select_card"), interrupt: false);

        // ── Postfixes — LotteryCardSelect (section 8) ────────────────────────

        /// <summary>
        /// LotteryCardSelectViewController.NotificationStackEntry (RVA 0xD9C590).
        /// Annonce : "Sélection de carte [du tirage]. Vue : Collection/Deck. N cartes dans le pool."
        ///
        /// Données lues :
        ///   currentView (protected ViewType 0x21C) : None=0, CardCollection=1, Deck=2
        ///   &lt;m_CardPool&gt;k__BackingField (List&lt;CardBaseData&gt; 0x198) : taille du pool
        /// </summary>
        public static void LotteryCardSelect_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Vue active : CardCollection=1, Deck=2
                var fView = FindField(__instance.GetType(), "currentView");
                int viewVal = Convert.ToInt32(fView?.GetValue(__instance) ?? 0);
                string viewLabel = viewVal switch
                {
                    1 => Loc.Get("lottery_card_select_collection"),
                    2 => Loc.Get("lottery_card_select_deck"),
                    _ => string.Empty,
                };

                // Pool de cartes disponibles (backing field de m_CardPool)
                var fPool = FindField(__instance.GetType(), "<m_CardPool>k__BackingField");
                int count = 0;
                if (fPool?.GetValue(__instance) is System.Collections.ICollection col)
                    count = col.Count;

                string msg;
                if (count > 0 && !string.IsNullOrWhiteSpace(viewLabel))
                    msg = Loc.Get("lottery_card_select_open_count", viewLabel, count);
                else if (!string.IsNullOrWhiteSpace(viewLabel))
                    msg = Loc.Get("lottery_card_select_open_view", viewLabel);
                else
                    msg = Loc.Get("screen_lottery_card_select");

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                tts.Speak(Loc.Get("screen_lottery_card_select"), interrupt: false);
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] LotteryCardSelect: {ex.Message}");
            }
        }

        // ── Postfixes — Certification (section 24) ───────────────────────────

        public static void CertificationConfirm_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("certification_confirm"), interrupt: false);

        public static void CertificationDetail_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("certification_detail"), interrupt: false);

        public static void CertificationExplanation_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("certification_explanation"), interrupt: false);

        public static void CertificationDuelField_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("certification_duel_field"), interrupt: false);

        public static void CertificationWriting_Postfix(object __instance)
            => Plugin.Instance?.Tts?.Speak(Loc.Get("certification_writing"), interrupt: false);

        /// <summary>
        /// CertificationWritingReslutViewController : reads isSuccess (bool) + correctAnswerNum (int).
        /// Announces "Certification : réussi/échoué. N bonne(s) réponse(s)."
        /// </summary>
        public static void CertificationResult_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                var fSuccess = FindField(t, "isSuccess");
                var fCorrect = FindField(t, "correctAnswerNum");
                bool success = fSuccess != null && Convert.ToBoolean(fSuccess.GetValue(__instance));
                int correct  = fCorrect != null ? Convert.ToInt32(fCorrect.GetValue(__instance)) : -1;

                string verdict = Loc.Get(success ? "certification_result_pass" : "certification_result_fail");
                string msg = correct >= 0
                    ? Loc.Get("certification_result_score", verdict, correct)
                    : verdict;
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("certification_result"), interrupt: false); }
        }

        // ── PromoCodes ────────────────────────────────────────────────────────

        public static void PromoCodes_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? modeMsg = TryReadPromoMode(__instance);
                tts.Speak(modeMsg ?? Loc.Get("screen_promo_codes"), interrupt: false);
            }
            catch (Exception ex)
            {
                tts.Speak(Loc.Get("screen_promo_codes"), interrupt: false);
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] PromoCodes: {ex.Message}");
            }
        }

        // ── Market Pool ───────────────────────────────────────────────────────

        /// <summary>
        /// NSE est un stub vide (RVA 0x3E4080) — bypassOriginal empêche la boucle infinie.
        /// L'annonce réelle est faite par MarketPoolOnCreated_Postfix.
        /// </summary>
        public static void MarketPool_Postfix(object __instance) { }

        public static void MarketPoolOnCreated_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? label = TryReadMarketLabel(__instance);
                string msg = !string.IsNullOrWhiteSpace(label)
                    ? Loc.Get("market_pool_open_name", label!)
                    : Loc.Get("screen_market");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                tts.Speak(Loc.Get("screen_market"), interrupt: false);
                Plugin.Instance?.LogWarn($"[MiscViewsPatch] MarketPool.OnCreatedView: {ex.Message}");
            }
        }

        // ── helpers ──────────────────────────────────────────────────────────

        private static FieldInfo? FindField(Type t, string name)
        {
            var cur = t;
            while (cur != null && cur != typeof(object))
            {
                var f = cur.GetField(name,
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (f != null) return f;
                cur = cur.BaseType;
            }
            return null;
        }

        private static string? ReadTmpField(Type t, object instance, string fieldName)
        {
            var f = FindField(t, fieldName);
            var tmp = f?.GetValue(instance);
            if (tmp == null) return null;
            return tmp.GetType()
                .GetProperty("text", BindingFlags.Public | BindingFlags.Instance)
                ?.GetValue(tmp) as string;
        }

        /// <summary>
        /// Lit le type du comportement actif dans PromoCodesViewController (m_Behaviour.type).
        /// IPromoCodeBehaviour.Type : SerialCode=0, InviteSend=1, InviteReceive=2.
        /// Retourne null pour SerialCode (écran générique) ou en cas d'échec.
        /// </summary>
        private static string? TryReadPromoMode(object instance)
        {
            try
            {
                var f = FindField(instance.GetType(), "m_Behaviour");
                var behaviour = f?.GetValue(instance);
                if (behaviour == null) return null;

                var typeProp = behaviour.GetType().GetProperty("type",
                    BindingFlags.Public | BindingFlags.Instance);
                if (typeProp == null) return null;

                int modeVal = Convert.ToInt32(typeProp.GetValue(behaviour));
                return modeVal switch
                {
                    1 => Loc.Get("promo_invite_send"),
                    2 => Loc.Get("promo_invite_receive"),
                    _ => null    // SerialCode → titre générique
                };
            }
            catch { return null; }
        }

        /// <summary>
        /// Lit le texte du label d'en-tête du MarketPoolViewController.
        /// Le label "Label" est un enfant direct du transform racine de la vue.
        /// </summary>
        private static string? TryReadMarketLabel(object instance)
        {
            try
            {
                var transformProp = instance.GetType()
                    .GetProperty("transform", BindingFlags.Public | BindingFlags.Instance);
                var transform = transformProp?.GetValue(instance);
                if (transform == null) return null;

                var findMethod = transform.GetType().GetMethod("Find",
                    BindingFlags.Public | BindingFlags.Instance, null,
                    new[] { typeof(string) }, null);
                var labelTransform = findMethod?.Invoke(transform, new object[] { "Label" });
                if (labelTransform == null) return null;

                var go = labelTransform.GetType()
                    .GetProperty("gameObject", BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(labelTransform);
                if (go == null) return null;

                var tmpType = AccessToolsHelper.FindType("TMPro.TMP_Text");
                if (tmpType == null) return null;

                var getComp = go.GetType().GetMethod("GetComponent",
                    BindingFlags.Public | BindingFlags.Instance, null,
                    new[] { typeof(Type) }, null);
                var comp = getComp?.Invoke(go, new object[] { tmpType });
                if (comp == null) return null;

                return tmpType.GetProperty("text", BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(comp) as string;
            }
            catch { return null; }
        }
    }
}
