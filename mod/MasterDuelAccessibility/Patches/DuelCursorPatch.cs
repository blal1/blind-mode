using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Duel.RunEffectWorker.OnCursorEnter(int team, int position, int viewIndex) :
    ///   Annonce la carte / zone sous le curseur quand le joueur navigue sur le terrain
    ///   pendant une phase de sélection (ciblage d'une attaque, sélection d'une cible d'effet,
    ///   sélection d'une zone pour invoquer, etc.).
    ///
    /// ## Contexte
    ///
    /// Pendant la résolution d'un effet ou une attaque, le jeu passe en "mode sélection" :
    /// les zones/cartes sélectionnables s'illuminent et le joueur doit désigner une cible.
    /// Sans ce patch, un joueur non-voyant ne sait pas quelle carte se trouve sous le curseur
    /// — il devait se souvenir de toutes les positions depuis la dernière lecture F4.
    ///
    /// Ce patch annonce, à chaque changement de position du curseur, le nom et les stats ATK
    /// de la carte (si présente) ou la zone vide sous le curseur.
    ///
    /// ## Paramètres de OnCursorEnter
    ///   team      : 0 = joueur local, 1 = adversaire
    ///   position  : index de zone (FieldPostion, 0–18)
    ///   viewIndex : index de la carte visible (pertinent pour XYZ empilées)
    ///
    /// ## Anti-spam
    ///   - Déduplication : même (team, position) consécutif → ignoré
    ///   - Cooldown : 200 ms minimum entre deux annonces (curseur qui bouge vite)
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyDuelScenePatches() en scène duel.
    /// </summary>
    internal static class DuelCursorPatch
    {
        private static bool _applied = false;

        // Déduplication par position : si le curseur revient sur la même zone, on ne relit pas
        private static int  _lastTeam     = -1;
        private static int  _lastPosition = -1;

        // Cooldown minimal pour éviter le flood quand le curseur se déplace rapidement
        private static DateTime _lastAt   = DateTime.MinValue;
        private static readonly TimeSpan Cooldown = TimeSpan.FromMilliseconds(200);

        internal static void Reset()
        {
            _applied      = false;
            _lastTeam     = -1;
            _lastPosition = -1;
            _lastAt       = DateTime.MinValue;
        }

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[DuelCursorPatch] Initialisation...");

            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.RunEffectWorker");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[DuelCursorPatch] RunEffectWorker introuvable.");
                    return;
                }

                // OnCursorEnter(int team, int position, int viewIndex) — private
                var enterMethod = type.GetMethod("OnCursorEnter",
                    BindingFlags.NonPublic | BindingFlags.Instance,
                    null, new[] { typeof(int), typeof(int), typeof(int) }, null);

                if (enterMethod != null)
                {
                    var enterPostfix = typeof(DuelCursorPatch).GetMethod(
                        nameof(OnCursorEnter_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                    harmony.Patch(enterMethod, postfix: new HarmonyMethod(enterPostfix));
                    Plugin.Instance?.LogMsg("[DuelCursorPatch] ✓ RunEffectWorker.OnCursorEnter");
                }
                else
                {
                    Plugin.Instance?.LogWarn("[DuelCursorPatch] OnCursorEnter introuvable.");
                }

                // OnSelectField(int team, int position, int viewIndex) — private
                // Fires when the player CONFIRMS a zone (press Enter/Space on a target).
                var selectMethod = type.GetMethod("OnSelectField",
                    BindingFlags.NonPublic | BindingFlags.Instance,
                    null, new[] { typeof(int), typeof(int), typeof(int) }, null);

                if (selectMethod != null)
                {
                    var selectPostfix = typeof(DuelCursorPatch).GetMethod(
                        nameof(OnSelectField_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                    harmony.Patch(selectMethod, postfix: new HarmonyMethod(selectPostfix));
                    Plugin.Instance?.LogMsg("[DuelCursorPatch] ✓ RunEffectWorker.OnSelectField");
                }
                else
                {
                    Plugin.Instance?.LogWarn("[DuelCursorPatch] OnSelectField introuvable.");
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[DuelCursorPatch] Erreur Initialize: {ex.Message}");
            }

            _applied = true;
        }

        // ── Postfix ────────────────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour RunEffectWorker.OnCursorEnter(int team, int position, int viewIndex).
        ///
        /// __0 = team (0=joueur, 1=adversaire)
        /// __1 = position (FieldPostion index, 0–18)
        /// __2 = viewIndex (ignoré — prend toujours la carte visible au-dessus)
        ///
        /// Stratégie :
        ///   1. Dédup : même zone que la dernière → ignorer
        ///   2. Cooldown 200 ms : anti-flood si curseur anime rapide
        ///   3. GetCardNameAndAtkAt(team, position) → nom + ATK
        ///   4. Si carte présente → "NomCarte ATK 2500, Zone Monstre 2 adversaire"
        ///      Si zone vide     → "Zone Sort/Piège 3 adversaire — vide"
        /// </summary>
        private static void OnCursorEnter_Postfix(object __instance, int __0, int __1, int __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || !KeyboardShortcuts.IsInDuel) return;

            try
            {
                int team = __0;
                int pos  = __1;

                // Dédup : même zone répétée
                if (team == _lastTeam && pos == _lastPosition) return;

                // Cooldown
                var now = DateTime.Now;
                if (now - _lastAt < Cooldown) return;

                _lastTeam     = team;
                _lastPosition = pos;
                _lastAt       = now;

                string zoneName = GetZoneLabel(team, pos);

                // Tenter de lire la carte à cette position
                var (cardName, atk) = AccessToolsHelper.GetCardNameAndAtkAt(team, pos);

                string announcement;
                if (!string.IsNullOrWhiteSpace(cardName))
                {
                    announcement = atk >= 0
                        ? Loc.Get("cursor_card_atk", cardName, atk, zoneName)
                        : Loc.Get("cursor_card",     cardName,      zoneName);
                }
                else
                {
                    // Zone vide (peut être une zone de sélection de placement)
                    announcement = Loc.Get("cursor_empty_zone", zoneName);
                }

                // interrupt:true — le joueur navigue activement, doit couper ce qui se lit
                tts.Speak(announcement, interrupt: false, addToHistory: false);
            }
            catch { }
        }

        // ── Postfix : OnSelectField ────────────────────────────────────────────

        /// <summary>
        /// Postfix pour RunEffectWorker.OnSelectField(int team, int position, int viewIndex).
        ///
        /// Déclenché quand le joueur CONFIRME une zone (appui sur la zone sélectionnée).
        /// Contrairement à OnCursorEnter (hover), cette méthode ne fire qu'une fois
        /// par sélection — pas de cooldown ni de déduplication nécessaires.
        ///
        /// Annonce : "Cible : NomCarte ATK 2500" ou "Zone sélectionnée : Zone Monstre 2 adverse"
        /// </summary>
        private static void OnSelectField_Postfix(object __instance, int __0, int __1, int __2)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || !KeyboardShortcuts.IsInDuel) return;

            try
            {
                int team = __0;
                int pos  = __1;

                var (cardName, atk) = AccessToolsHelper.GetCardNameAndAtkAt(team, pos);

                string announcement;
                if (!string.IsNullOrWhiteSpace(cardName))
                {
                    announcement = atk >= 0
                        ? Loc.Get("select_card_atk", cardName, atk)
                        : Loc.Get("select_card",     cardName);
                }
                else
                {
                    announcement = Loc.Get("select_zone", GetZoneLabel(team, pos));
                }

                tts.Speak(announcement, interrupt: false);
            }
            catch { }
        }

        // ── Helper ────────────────────────────────────────────────────────────

        /// <summary>
        /// Construit un libellé de zone complet incluant le propriétaire et le type de zone.
        /// Reprend les constantes FieldPostion de CardRoot, déjà utilisées dans KeyboardShortcuts.
        ///
        ///   0–4  : Zone Monstre 1–5 (zones principales)
        ///   5–6  : Zone Extra 1–2 (zones monstres additionnelles)
        ///   7–11 : Zone Sort/Piège 1–5
        ///   12   : Zone Terrain
        /// </summary>
        private static string GetZoneLabel(int team, int pos)
        {
            string owner = team == 0 ? Loc.Get("cursor_yours") : Loc.Get("cursor_opp");

            string zone = pos switch
            {
                >= 0 and <= 4  => Loc.Get("zone_monster",   pos + 1),
                5 or 6         => Loc.Get("zone_extra",      pos - 4),
                >= 7 and <= 11 => Loc.Get("zone_spelltrap",  pos - 6),
                12             => Loc.Get("zone_fieldspell"),
                13             => Loc.Get("zone_hand"),
                16             => Loc.Get("zone_grave"),
                17             => Loc.Get("zone_banished"),
                _              => Loc.Get("zone_unknown",   pos)
            };

            return $"{owner} {zone}";
        }
    }
}
