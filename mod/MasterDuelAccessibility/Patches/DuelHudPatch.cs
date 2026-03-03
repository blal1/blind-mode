namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Postfix pour YgomGame.Duel.DuelLP.ChangeLP — annonce les changements de PV.
    /// Met aussi à jour KeyboardShortcuts.MyLP / OppLP pour le raccourci Espace.
    ///
    /// Signature observée (interop) :
    ///   DuelLP.ChangeLP(int afterLP, int damage, ...)
    ///   DuelLP.SetLP(int lp)
    ///
    /// m_IsNear == true → barre du joueur local.
    /// </summary>
    internal static class DuelHudPatch
    {
        public static void ChangeLP_Postfix(object __instance, int afterLP, int damage)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            bool isOpponent = IsOpponent(__instance);
            string msg = isOpponent
                ? (damage > 0
                    ? Loc.Get("duel_lp_damage_opp", afterLP, damage)
                    : Loc.Get("duel_lp_gain_opp",   afterLP, -damage))
                : (damage > 0
                    ? Loc.Get("duel_lp_damage_you", afterLP, damage)
                    : Loc.Get("duel_lp_gain_you",   afterLP, -damage));

            tts.Speak(msg);

            if (isOpponent) KeyboardShortcuts.OppLP = afterLP;
            else            KeyboardShortcuts.MyLP  = afterLP;

            if (afterLP < 1)
                KeyboardShortcuts.IsInDuel = false;
        }

        public static void SetLP_Postfix(object __instance, int lp, bool initialSet)
        {
            // initialSet=true → initialisation en début de duel, déjà couverte par DuelStart_Postfix
            if (initialSet) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            bool isOpponent = IsOpponent(__instance);
            tts.Speak(isOpponent
                ? Loc.Get("duel_lp_set_opp", lp)
                : Loc.Get("duel_lp_set_you", lp));

            if (isOpponent) KeyboardShortcuts.OppLP = lp;
            else            KeyboardShortcuts.MyLP  = lp;
        }

        private static bool IsOpponent(object instance)
        {
            try
            {
                // m_IsNear == true → local player's LP bar
                var field = instance?.GetType().GetField(
                    "m_IsNear",
                    System.Reflection.BindingFlags.NonPublic |
                    System.Reflection.BindingFlags.Instance);
                if (field != null)
                    return field.GetValue(instance) is bool isNear && !isNear;

                // Fallback: GameObject name contains "Far" for opponent side
                var nameProp = instance?.GetType()
                    .GetProperty("name",
                        System.Reflection.BindingFlags.Public |
                        System.Reflection.BindingFlags.Instance);
                return nameProp?.GetValue(instance)?.ToString()?.Contains("Far") == true;
            }
            catch { return false; }
        }
    }
}
