namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch DuelClient.InvokeDecideAttackTarget :
    ///   Annonce "Attaquant (ATK X) attaque Cible (ATK Y) !" ou "… : attaque directe !"
    ///   dès que la cible est sélectionnée (avant l'animation).
    ///
    /// Signature : public static void InvokeDecideAttackTarget(
    ///     int attackerPlayer, int attackerPosition, int attackerIndex,
    ///     int targetPlayer,   int targetPosition,   int targetIndex)
    ///
    /// Harmony — injection positionnelle :
    ///   __0 = attackerPlayer (0=local, 1=adversaire)
    ///   __1 = attackerPosition (zone terrain 0-12)
    ///   __3 = targetPlayer
    ///   __4 = targetPosition
    ///
    /// Les valeurs ATK sont incluses quand disponibles.
    /// Quand la cible est introuvable → attaque directe.
    /// </summary>
    internal static class DuelAttackPatch
    {
        public static void InvokeDecideAttackTarget_Postfix(
            int __0, int __1, int __3, int __4)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            var (attackerName, attackerAtk) = AccessToolsHelper.GetCardNameAndAtkAt(__0, __1);
            var (targetName,   targetAtk)   = AccessToolsHelper.GetCardNameAndAtkAt(__3, __4);

            string aName = attackerName ?? "?";
            string msg;

            if (targetName != null)
            {
                // Vs une carte — inclure ATK si les deux valeurs sont connues
                msg = (attackerAtk >= 0 && targetAtk >= 0)
                    ? Loc.Get("duel_attack_vs_stats", aName, attackerAtk, targetName, targetAtk)
                    : Loc.Get("duel_attack_vs",       aName, targetName);
            }
            else
            {
                // Attaque directe — inclure ATK de l'attaquant si connue
                msg = attackerAtk >= 0
                    ? Loc.Get("duel_attack_direct_stats", aName, attackerAtk)
                    : Loc.Get("duel_attack_direct",       aName);
            }

            tts.Speak(msg, interrupt: true);
        }
    }
}
