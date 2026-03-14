using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Duel.DuelRitualDialog :
    ///   - Begin(string message, Engine.DialogRitualType type, int remainNum, int maxNum)
    ///     → annonce les conditions de l'Invocation Rituel à l'ouverture du dialog.
    ///   - SetCount(int remainNum)
    ///     → annonce la progression au fil des tributs sélectionnés.
    ///
    /// ## Engine.DialogRitualType
    ///   Ritual=0 — total de Niveaux requis
    ///   Multi=1  — invocation multiple (Niveaux)
    ///   Atk=2    — total d'ATK requis
    ///   Sync=3   — Synchro (Niveaux)
    ///   Link=4   — Lien (markers)
    ///
    /// ## Champs publics utilisés (props auto-générées, accessibles via réflexion)
    ///   remainNum (int) — Niveaux/ATK restants à atteindre
    ///   maxNum    (int) — Maximum autorisé (0 = pas de limite supérieure)
    ///   message   (string) — Texte du dialog (déjà localisé par le jeu)
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyDuelScenePatches() en scène duel.
    /// </summary>
    internal static class DuelRitualDialogPatch
    {
        private static bool _applied    = false;
        private static int  _lastRemain = -1;

        internal static void Reset()
        {
            _applied    = false;
            _lastRemain = -1;
        }

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[DuelRitualDialogPatch] Initialisation...");

            PatchBegin(harmony);
            PatchSetCount(harmony);

            _applied = true;
            Plugin.Instance?.LogMsg("[DuelRitualDialogPatch] Patches appliqués.");
        }

        // ── Patch Begin ────────────────────────────────────────────────────────

        private static void PatchBegin(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("DuelRitualDialog");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[DuelRitualDialogPatch] DuelRitualDialog introuvable.");
                    return;
                }

                // Begin(string message, Engine.DialogRitualType type, int remainNum, int maxNum)
                var method = type.GetMethod("Begin", BindingFlags.Public | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[DuelRitualDialogPatch] Begin introuvable.");
                    return;
                }

                var postfix = typeof(DuelRitualDialogPatch).GetMethod(
                    nameof(Begin_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[DuelRitualDialogPatch] ✓ DuelRitualDialog.Begin");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelRitualDialogPatch] Erreur PatchBegin: {ex.Message}");
            }
        }

        // ── Patch SetCount ─────────────────────────────────────────────────────

        private static void PatchSetCount(HarmonyLib.Harmony harmony)
        {
            try
            {
                var type = LatePatches.FindType("DuelRitualDialog");
                if (type == null) return;

                // SetCount(int remainNum) — public
                var method = type.GetMethod("SetCount", BindingFlags.Public | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[DuelRitualDialogPatch] SetCount introuvable.");
                    return;
                }

                var postfix = typeof(DuelRitualDialogPatch).GetMethod(
                    nameof(SetCount_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[DuelRitualDialogPatch] ✓ DuelRitualDialog.SetCount");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelRitualDialogPatch] Erreur PatchSetCount: {ex.Message}");
            }
        }

        // ── Postfix : Begin ────────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour DuelRitualDialog.Begin(string message, DialogRitualType type, int remainNum, int maxNum).
        ///
        /// __0 = string message  — texte du dialog (déjà localisé)
        /// __1 = int type        — Engine.DialogRitualType (0=Ritual, 2=Atk, 4=Link, …)
        /// __2 = int remainNum   — niveaux/ATK restants à réunir
        /// __3 = int maxNum      — maximum autorisé (0 = pas de plafond)
        /// </summary>
        private static void Begin_Postfix(string __0, int __1, int __2, int __3)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                _lastRemain = __2;

                string unit = GetRitualUnit(__1);

                string msg = string.IsNullOrWhiteSpace(__0)
                    ? (__3 > 0
                        ? Loc.Get("ritual_begin_notext",      __2, __3, unit)
                        : Loc.Get("ritual_begin_notext_nomax", __2,       unit))
                    : (__3 > 0
                        ? Loc.Get("ritual_begin",      __0, __2, __3, unit)
                        : Loc.Get("ritual_begin_nomax", __0, __2,       unit));

                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        // ── Postfix : SetCount ─────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour DuelRitualDialog.SetCount(int remainNum).
        /// Annonce la valeur restante quand le joueur sélectionne/désélectionne un tribut.
        /// </summary>
        private static void SetCount_Postfix(int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (__0 == _lastRemain) return;
                _lastRemain = __0;

                string msg = __0 <= 0
                    ? Loc.Get("ritual_ready")
                    : Loc.Get("ritual_count_update", __0);

                tts.Speak(msg, interrupt: false, addToHistory: false);
            }
            catch { }
        }

        // ── Helper ─────────────────────────────────────────────────────────────

        /// <summary>
        /// Traduit Engine.DialogRitualType en unité lisible (Niveaux / ATK / Lien).
        /// Engine.DialogRitualType : Ritual=0, Multi=1, Atk=2, Sync=3, Link=4
        /// </summary>
        private static string GetRitualUnit(int type) => type switch
        {
            2 => Loc.Get("ritual_unit_atk"),
            4 => Loc.Get("ritual_unit_link"),
            _ => Loc.Get("ritual_unit_level"),
        };
    }
}
