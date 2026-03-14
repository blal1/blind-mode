using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Duel.CommandOperation.SetCursor(int index) :
    ///   Annonce le nom de la commande sur laquelle le curseur se déplace
    ///   lorsque le joueur navigue dans le menu d'action d'une carte.
    ///
    /// Contexte :
    ///   Quand le joueur clique/sélectionne une carte en duel, CardCommand ouvre
    ///   un menu listant les actions disponibles (Attaquer, Activer l'effet,
    ///   Invoquer, etc.). La navigation au clavier/manette déplace le curseur
    ///   entre ces options via CommandOperation.SetCursor(int index).
    ///
    ///   Sans ce patch, un joueur non-voyant entend la liste complète des commandes
    ///   à l'ouverture (via CardCommandPatch) mais n'a aucun retour audio pendant
    ///   la navigation — il doit sélectionner "en aveugle".
    ///
    /// Implémentation :
    ///   CommandOperation a un champ privé `commandList` (List&lt;Engine.CommandType&gt;)
    ///   qui contient les commandes disponibles dans l'ordre d'affichage.
    ///   SetCursor(index) met à jour currentCommandIndex — on lit commandList[index]
    ///   via réflexion pour obtenir le type de commande et le convertir en libellé.
    ///
    /// Engine.CommandType (enum) :
    ///   Attack=0, Look=1, SummonSp=2, Action=3, Summon=4, Reverse=5,
    ///   SetMonst=6, Set=7, Pendulum=8, TurnAtk=9, TurnDef=10,
    ///   Surrender=11, Decide=12, Draw=13
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyDuelScenePatches() (type duel-spécifique).
    /// </summary>
    internal static class CommandOperationPatch
    {
        private static bool _applied = false;

        // Déduplication : évite de ré-annoncer si SetCursor est appelé plusieurs
        // fois de suite avec le même index (l'UI peut refresh sans changement réel).
        private static int _lastIndex = -1;

        internal static void Reset()
        {
            _applied   = false;
            _lastIndex = -1;
        }

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[CommandOperationPatch] Initialisation...");

            try
            {
                var type = LatePatches.FindType("YgomGame.Duel.CommandOperation");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[CommandOperationPatch] CommandOperation introuvable.");
                    return;
                }

                // SetCursor(int index) — public
                var method = type.GetMethod("SetCursor",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int) }, null);

                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[CommandOperationPatch] SetCursor(int) introuvable.");
                    return;
                }

                var postfix = typeof(CommandOperationPatch).GetMethod(
                    nameof(SetCursor_Postfix), BindingFlags.Static | BindingFlags.NonPublic);

                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[CommandOperationPatch] ✓ CommandOperation.SetCursor");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[CommandOperationPatch] Erreur Initialize: {ex.Message}");
            }

            _applied = true;
        }

        // ── Postfix ────────────────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour CommandOperation.SetCursor(int index).
        ///
        /// __instance = l'instance CommandOperation
        /// __0        = index de la commande dans commandList
        ///
        /// Lit commandList[index] (Engine.CommandType), le convertit en libellé
        /// et l'annonce avec position (ex : "Attaquer, 1 sur 3").
        /// </summary>
        private static void SetCursor_Postfix(object __instance, int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || !KeyboardShortcuts.IsInDuel) return;

            try
            {
                if (__0 < 0) return;

                // Dédup — même index répété sans changement
                if (__0 == _lastIndex) return;
                _lastIndex = __0;

                // Lire commandList via réflexion (champ privé)
                var listField = __instance.GetType().GetField(
                    "commandList", BindingFlags.NonPublic | BindingFlags.Instance);
                var list = listField?.GetValue(__instance) as System.Collections.IList;
                if (list == null || __0 >= list.Count) return;

                // commandList[index] = Engine.CommandType (int enum)
                int commandType = Convert.ToInt32(list[__0]);
                int total       = list.Count;

                string? key = GetCommandLocKey(commandType);
                if (key == null) return;

                string label = Loc.Get(key);

                // interrupt:true — l'utilisateur navigue activement, l'annonce
                // doit couper tout ce qui se lit (analogue au comportement des
                // écrans de navigation dans AccessibleArena BaseNavigator).
                tts.Speak(
                    Loc.Get("cmd_cursor", label, __0 + 1, total),
                    interrupt: false, addToHistory: false);
            }
            catch { }
        }

        // ── Helper ────────────────────────────────────────────────────────────

        /// <summary>
        /// Mappe Engine.CommandType (int) → clé Loc.
        /// Valeurs de l'enum extraites de dump/dump.cs ligne 246863.
        /// </summary>
        private static string? GetCommandLocKey(int commandType) => commandType switch
        {
            0  => "cmd_attack",
            1  => "cmd_look",
            2  => "cmd_summon_sp",
            3  => "cmd_action",
            4  => "cmd_summon",
            5  => "cmd_reverse",
            6  => "cmd_set_monst",
            7  => "cmd_set",
            8  => "cmd_pendulum",
            9  => "cmd_turn_atk",
            10 => "cmd_turn_def",
            11 => "cmd_surrender",
            12 => "cmd_decide",
            13 => "cmd_draw",
            _  => null
        };
    }
}
