using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Duel.DuelTimer3D :
    ///   - SetRemainTime(float dueltime, float turntime) : alerte vocale quand le temps est critique
    ///
    /// En jeu classé (Ranked), chaque joueur dispose d'un temps limité par tour et pour le duel
    /// entier. Un joueur non-voyant n'a aucune information sur le temps restant (le timer est
    /// visuel uniquement). Ce patch annonce :
    ///   - "Attention : 60 secondes restantes" quand le temps de tour descend sous 60s
    ///   - "Attention : 30 secondes — fin de tour imminente" à 30s
    ///   - "URGENT : 10 secondes" à 10s
    ///
    /// Chaque seuil n'est annoncé qu'une seule fois par tour. Les seuils sont réinitialisés
    /// au changement de tour (via ResetTurnThresholds() appelé par PhasePatch.TurnChange_Postfix).
    ///
    /// ## API ciblée
    /// ```
    /// public void SetRemainTime(float dueltime, float turntime)
    /// ```
    ///   dueltime = secondes restantes pour tout le duel
    ///   turntime = secondes restantes pour ce tour
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyDuelScenePatches().
    /// </summary>
    internal static class DuelTimerPatch
    {
        private static bool _applied = false;

        // Seuils de temps de tour déjà annoncés (réinitialisés à chaque tour)
        private static bool _announced60 = false;
        private static bool _announced30 = false;
        private static bool _announced10 = false;

        // Seuil de temps de duel (global) — annoncé une seule fois
        private static bool _announcedDuel120 = false;
        private static bool _announcedDuel60  = false;
        private static bool _announcedDuel30  = false;

        internal static void Reset()
        {
            _applied = false;
            ResetTurnThresholds();
            ResetDuelThresholds();
        }

        /// <summary>
        /// Appelé par PhasePatch.TurnChange_Postfix à chaque changement de tour.
        /// </summary>
        internal static void ResetTurnThresholds()
        {
            _announced60 = false;
            _announced30 = false;
            _announced10 = false;
        }

        private static void ResetDuelThresholds()
        {
            _announcedDuel120 = false;
            _announcedDuel60  = false;
            _announcedDuel30  = false;
        }

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[DuelTimerPatch] Initialisation...");

            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.DuelTimer3D");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[DuelTimerPatch] DuelTimer3D introuvable.");
                    return;
                }

                // SetRemainTime(float dueltime, float turntime)
                var method = type.GetMethod("SetRemainTime",
                    BindingFlags.Public | BindingFlags.Instance);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[DuelTimerPatch] SetRemainTime introuvable.");
                    return;
                }

                var postfix = typeof(DuelTimerPatch).GetMethod(
                    nameof(SetRemainTime_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[DuelTimerPatch] ✓ DuelTimer3D.SetRemainTime");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelTimerPatch] Erreur Initialize: {ex.Message}");
            }

            _applied = true;
        }

        // ── Postfix ────────────────────────────────────────────────────────────

        /// <summary>
        /// Appelé après DuelTimer3D.SetRemainTime(float dueltime, float turntime).
        ///
        /// __0 = dueltime (secondes restantes pour l'ensemble du duel)
        /// __1 = turntime (secondes restantes pour ce tour)
        ///
        /// Les seuils sont des nombres entiers (trunc) pour éviter les déclenchements
        /// multiples dues aux valeurs flottantes.
        /// </summary>
        private static void SetRemainTime_Postfix(float __0, float __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int turnSecs = (int)__1;
                int duelSecs = (int)__0;

                // ── Seuils temps de TOUR ─────────────────────────────────────
                // Ordre décroissant — on vérifie toujours le seuil le plus bas d'abord
                // pour qu'une alerte urgente ne soit pas masquée par une alerte moins urgente.

                if (!_announced10 && turnSecs <= 10 && turnSecs > 0)
                {
                    _announced10 = true;
                    _announced30 = true;
                    _announced60 = true;
                    tts.Speak(Loc.Get("timer_warning_10"), interrupt: true, addToHistory: false);
                    return;
                }

                if (!_announced30 && turnSecs <= 30 && turnSecs > 10)
                {
                    _announced30 = true;
                    _announced60 = true;
                    tts.Speak(Loc.Get("timer_warning_30"), interrupt: false, addToHistory: false);
                    return;
                }

                if (!_announced60 && turnSecs <= 60 && turnSecs > 30)
                {
                    _announced60 = true;
                    tts.Speak(Loc.Get("timer_warning_60"), interrupt: false, addToHistory: false);
                    return;
                }

                // ── Seuils temps de DUEL (global) ────────────────────────────
                // Moins urgents — seulement si le timer de duel est actif (duelSecs > 0)
                if (duelSecs <= 0) return;

                if (!_announcedDuel30 && duelSecs <= 30)
                {
                    _announcedDuel30 = true;
                    _announcedDuel60 = true;
                    _announcedDuel120 = true;
                    tts.Speak(Loc.Get("timer_duel_warning_30"), interrupt: false, addToHistory: false);
                }
                else if (!_announcedDuel60 && duelSecs <= 60)
                {
                    _announcedDuel60 = true;
                    _announcedDuel120 = true;
                    tts.Speak(Loc.Get("timer_duel_warning_60"), interrupt: false, addToHistory: false);
                }
                else if (!_announcedDuel120 && duelSecs <= 120)
                {
                    _announcedDuel120 = true;
                    tts.Speak(Loc.Get("timer_duel_warning_120"), interrupt: false, addToHistory: false);
                }
            }
            catch { }
        }
    }
}
