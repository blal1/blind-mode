using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour CardReportTelopController.SetStateContent :
    ///   Annonce le bandeau de résultat d'effet qui apparaît après certains effets de carte.
    ///
    /// En duel, certains effets déclenchent un bandeau animé montrant une carte avec
    /// une stat et un message (ex : "Pot of Greed +2 pioches", "Raigeki -3 monstres").
    /// Ce bandeau est purement visuel — un joueur non-voyant ne le voit pas.
    ///
    /// ## API ciblée
    /// ```
    /// public void SetStateContent(int cardid, string message, string messageNum,
    ///                             string messageUnit, CardStatsData.CARD_STATS_EFFECT_TYPE effecttype)
    /// ```
    ///   cardid      = ID numérique de la carte (résolu via Content.Instance.GetName)
    ///   message     = texte du titre de l'effet (ex: "Pioches", "Destruction")
    ///   messageNum  = nombre lié à l'effet (ex: "+2", "-500")
    ///   messageUnit = unité (ex: "cartes", "ATK", "PV")
    ///   effecttype  = type visuel de l'effet (non utilisé ici)
    ///
    /// Annonce : "{nom de la carte} : {message} {messageNum} {messageUnit}"
    ///
    /// ## Appel
    /// Appliqué au démarrage par Plugin.ApplyPatches() (pas dépendant d'une scène).
    /// </summary>
    internal static class CardReportTelopPatch
    {
        // Déduplication : même carte + même message dans les 2 secondes → ignoré
        private static string   _lastKey  = "";
        private static DateTime _lastTime = DateTime.MinValue;
        private static readonly TimeSpan DedupWindow = TimeSpan.FromSeconds(2);

        /// <summary>
        /// Appelé par Plugin.ApplyPatches() — pas un patch de scène, disponible globalement.
        /// </summary>
        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = AccessToolsHelper.FindType("CardReportTelopController");
                if (type == null)
                {
                    // Type dans le namespace global (pas YgomGame.Duel)
                    Plugin.Instance?.LogWarn("[CardReportTelopPatch] CardReportTelopController introuvable.");
                    return;
                }

                // SetStateContent(int cardid, string message, string messageNum, string messageUnit, ...)
                var method = type.GetMethod("SetStateContent",
                    BindingFlags.Public | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[CardReportTelopPatch] SetStateContent introuvable.");
                    return;
                }

                var postfix = typeof(CardReportTelopPatch).GetMethod(
                    nameof(SetStateContent_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[CardReportTelopPatch] ✓ CardReportTelopController.SetStateContent");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[CardReportTelopPatch] Erreur Apply: {ex.Message}");
            }
        }

        // ── Postfix ────────────────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour SetStateContent(int cardid, string message, string messageNum, string messageUnit, ...).
        ///
        /// __0 = cardid (int)
        /// __1 = message (string)
        /// __2 = messageNum (string) — peut être vide
        /// __3 = messageUnit (string) — peut être vide
        /// </summary>
        private static void SetStateContent_Postfix(int __0, string __1, string __2, string __3)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (__0 <= 0 && string.IsNullOrWhiteSpace(__1)) return;

                // Résoudre le nom de la carte
                string cardName = ResolveCardName(__0);

                // Construire le texte
                string body = __1 ?? "";
                string num  = __2 ?? "";
                string unit = __3 ?? "";

                // Si on a un nombre et/ou une unité, on les combine avec le message
                string statPart = string.IsNullOrWhiteSpace(num)
                    ? (string.IsNullOrWhiteSpace(unit) ? body : $"{body} {unit}".Trim())
                    : $"{body} {num}{(string.IsNullOrWhiteSpace(unit) ? "" : " " + unit)}".Trim();

                string announcement = string.IsNullOrWhiteSpace(cardName)
                    ? statPart
                    : Loc.Get("card_report_telop", cardName, statPart);

                if (string.IsNullOrWhiteSpace(announcement)) return;

                // Déduplication : même annonce dans la fenêtre de 2 secondes → ignoré
                var now = DateTime.Now;
                if (announcement == _lastKey && now - _lastTime < DedupWindow) return;
                _lastKey  = announcement;
                _lastTime = now;

                Plugin.Instance?.LogMsg($"[CardReportTelopPatch] Telop: {announcement}");

                // Faible priorité pour ne pas couper l'annonce d'effet en cours
                tts.Speak(announcement, interrupt: false);
            }
            catch { }
        }

        // ── Helper ────────────────────────────────────────────────────────────

        private static string ResolveCardName(int cardId)
        {
            if (cardId <= 0) return "";
            try
            {
                var contentType = AccessToolsHelper.FindType("Content");
                if (contentType == null) return "";
                var inst = contentType.GetProperty("Instance",
                    BindingFlags.Public | BindingFlags.Static)?.GetValue(null);
                if (inst == null) return "";
                var getName = contentType.GetMethod("GetName",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int), typeof(bool) }, null);
                return getName?.Invoke(inst, new object[] { cardId, false }) as string ?? "";
            }
            catch { return ""; }
        }
    }
}
