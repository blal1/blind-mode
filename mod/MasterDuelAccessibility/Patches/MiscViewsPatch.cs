using System;
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
            PatchNSE(harmony, "YgomGame.Solo.SoloPortalViewController",            nameof(SoloPortal_Postfix),           "SoloPortalViewController");
            PatchNSE(harmony, "YgomGame.Solo.SoloStartProductionViewController",   nameof(SoloStartProduction_Postfix),  "SoloStartProductionViewController");
            PatchNSE(harmony, "YgomGame.Solo.SoloClearViewController",             nameof(SoloClear_Postfix),            "SoloClearViewController");
            PatchNSE(harmony, "YgomGame.Scenario.ScenarioVolumeViewController",    nameof(ScenarioVolume_Postfix),       "ScenarioVolumeViewController");

            _applied = true;
        }

        private static void PatchNSE(
            HarmonyLib.Harmony harmony, string typeName, string postfixName, string logLabel)
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
            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(typeof(MiscViewsPatch), postfixName));
            Plugin.Instance?.LogMsg($"[MiscViewsPatch] ✓ {logLabel}.NotificationStackEntry");
        }

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
    }
}
