using HarmonyLib;

using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour SelectStandOperation.BeginSpSummon :
    ///   Annonce le contexte de placement lors d'une invocation spéciale
    ///   nécessitant de choisir une zone ou une position.
    ///
    /// ## Paramètres de BeginSpSummon
    ///   standType    : SelectStandOperation.StandType (quelles positions sont disponibles)
    ///   uniqueID     : int (id interne)
    ///   onExecuteSpSummon : Action<int,int,int,uint>
    ///   screenPoint  : Vector2
    ///   status       : SelectStandOperation.Status
    ///   zoneMode     : SelectStandOperation.ZoneMode
    ///
    /// ## SelectStandOperation.ZoneMode
    ///   SelectStand=0   → le joueur choisit une zone (pas de choix de position)
    ///   DecidePosition=1 → le joueur choisit la position du monstre (ATK/DEF/recto/verso)
    ///
    /// ## SelectStandOperation.StandType (pertinent quand ZoneMode=DecidePosition)
    ///   FaceAttackFaceDefense=0  → Attaque Recto ou Défense Recto
    ///   FaceAttackBackDefense=1  → Attaque Recto ou Défense Verso
    ///   FaceDefenseBackDefense=2 → Défense Recto ou Défense Verso
    ///   All=3                    → Attaque Recto, Défense Recto, ou Défense Verso
    ///   None=4                   → aucun choix (cas dégénéré)
    ///
    /// ## Appel
    /// Appliqué par LatePatches.ApplyDuelScenePatches() en scène duel.
    /// </summary>
    internal static class SelectStandOperationPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Initialize(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            Plugin.Instance?.LogMsg("[SelectStandOperationPatch] Initialisation...");

            try
            {
                var type = LatePatches.FindType("SelectStandOperation");
                if (type == null)
                {
                    Plugin.Instance?.LogWarn("[SelectStandOperationPatch] SelectStandOperation introuvable.");
                    return;
                }

                // BeginSpSummon(StandType, int, Action<int,int,int,uint>, Vector2, Status, ZoneMode)
                var method = type.GetMethod("BeginSpSummon", BindingFlags.Public | BindingFlags.Instance);
                if (method == null)
                {
                    Plugin.Instance?.LogWarn("[SelectStandOperationPatch] BeginSpSummon introuvable.");
                    return;
                }

                var postfix = typeof(SelectStandOperationPatch).GetMethod(
                    nameof(BeginSpSummon_Postfix), BindingFlags.Static | BindingFlags.NonPublic);
                harmony.Patch(method, postfix: new HarmonyMethod(postfix));
                Plugin.Instance?.LogMsg("[SelectStandOperationPatch] ✓ SelectStandOperation.BeginSpSummon");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[SelectStandOperationPatch] Erreur Initialize: {ex.Message}");
            }

            _applied = true;
        }

        // ── Postfix ────────────────────────────────────────────────────────────

        /// <summary>
        /// Fires after BeginSpSummon — reads zoneMode and standType from the instance
        /// and announces what the player must choose.
        ///
        /// Fields (from dump):
        ///   public SelectStandOperation.ZoneMode zoneMode;  // 0x70
        ///   private SelectStandOperation.StandType standType; // 0x74
        /// </summary>
        private static void BeginSpSummon_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || !KeyboardShortcuts.IsInDuel) return;

            try
            {
                var instType = __instance.GetType();

                var zoneModeField = instType.GetField("zoneMode",
                    BindingFlags.Public | BindingFlags.Instance);
                var standTypeField = instType.GetField("standType",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                int zoneMode  = zoneModeField  != null ? Convert.ToInt32(zoneModeField.GetValue(__instance))  : 0;
                int standType = standTypeField != null ? Convert.ToInt32(standTypeField.GetValue(__instance)) : 0;

                string key = zoneMode switch
                {
                    0 => "stand_select_zone",      // SelectStand — choose a zone
                    1 => GetDecidePositionKey(standType), // DecidePosition — choose position
                    _ => "stand_select_zone"
                };

                tts.Speak(Loc.Get(key), interrupt: false);
            }
            catch { }
        }

        // ── Helper ────────────────────────────────────────────────────────────

        private static string GetDecidePositionKey(int standType) => standType switch
        {
            0 => "stand_decide_atk_facedef",    // FaceAttackFaceDefense
            1 => "stand_decide_atk_backdef",    // FaceAttackBackDefense
            2 => "stand_decide_facedef_backdef",// FaceDefenseBackDefense
            3 => "stand_decide_any",            // All
            _ => "stand_decide_position"        // None or unknown — generic fallback
        };
    }
}
