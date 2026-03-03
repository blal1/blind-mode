using System.Collections.Generic;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch YgomGame.Duel.CardCommand.Open :
    ///   Annonce les commandes disponibles quand le menu contextuel d'une carte
    ///   s'ouvre en duel (Attaquer, Activer l'effet, Invoquer normalement…).
    ///
    /// Signature : bool Open(uint command, int player, int position, int index,
    ///                       Vector2 screenPoint, Action affectButtonCallback)
    ///
    /// Le paramètre `command` est un masque de bits Engine.CommandBit :
    ///   Attack=1, Look=2, SummonSp=4, Action=8, Summon=16, Reverse=32,
    ///   SetMonst=64, Set=128, Pendulum=256, TurnAtk=512, TurnDef=1024,
    ///   Surrender=2048, Decide=4096, Draw=8192
    ///
    /// L'annonce est mise en queue (interrupt:false) pour ne pas couper
    /// l'annonce du nom de carte déjà prononcée par CardInfoPatch.
    /// </summary>
    internal static class CardCommandPatch
    {
        public static void Open_Postfix(uint __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || !KeyboardShortcuts.IsInDuel) return;

            uint mask = __0;
            if (mask == 0) return;

            var cmds = new List<string>(8);

            // Ordre de priorité pour un joueur aveugle :
            // actions offensives d'abord, utilitaires ensuite.
            if ((mask & 1u)    != 0) cmds.Add(Loc.Get("cmd_attack"));
            if ((mask & 8u)    != 0) cmds.Add(Loc.Get("cmd_action"));
            if ((mask & 4u)    != 0) cmds.Add(Loc.Get("cmd_summon_sp"));
            if ((mask & 16u)   != 0) cmds.Add(Loc.Get("cmd_summon"));
            if ((mask & 32u)   != 0) cmds.Add(Loc.Get("cmd_reverse"));
            if ((mask & 64u)   != 0) cmds.Add(Loc.Get("cmd_set_monst"));
            if ((mask & 128u)  != 0) cmds.Add(Loc.Get("cmd_set"));
            if ((mask & 256u)  != 0) cmds.Add(Loc.Get("cmd_pendulum"));
            if ((mask & 512u)  != 0) cmds.Add(Loc.Get("cmd_turn_atk"));
            if ((mask & 1024u) != 0) cmds.Add(Loc.Get("cmd_turn_def"));
            if ((mask & 2048u) != 0) cmds.Add(Loc.Get("cmd_surrender"));
            if ((mask & 2u)    != 0) cmds.Add(Loc.Get("cmd_look"));

            if (cmds.Count == 0) return;

            // interrupt:false → mis en queue après l'annonce du nom de carte
            tts.Speak(Loc.Get("cmd_menu", string.Join(", ", cmds)), interrupt: false);
        }
    }
}
