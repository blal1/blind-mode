using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les widgets Mission non couverts par MissionViewControllerPatch :
    ///
    ///   Section 12.2 — Collecte de récompenses :
    ///     MissionBulkRecieveDialogWidget.OnPostAllInserted()
    ///       → "X récompenses collectées." (lit totalItems.Count)
    ///       Namespace : YgomGame.Mission
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class MissionMiscPatch
    {
        private static bool _applied = false;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var t = AccessToolsHelper.FindType("YgomGame.Mission.MissionBulkRecieveDialogWidget");
            if (t == null)
            {
                Plugin.Instance?.LogWarn("[MissionMiscPatch] MissionBulkRecieveDialogWidget introuvable.");
                _applied = true;
                return;
            }

            var m = t.GetMethod("OnPostAllInserted",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[MissionMiscPatch] MissionBulkRecieveDialogWidget.OnPostAllInserted introuvable.");
                _applied = true;
                return;
            }

            harmony.Patch(m, postfix: new HarmonyLib.HarmonyMethod(
                typeof(MissionMiscPatch), nameof(BulkReceive_Postfix)));
            Plugin.Instance?.LogMsg("[MissionMiscPatch] ✓ MissionBulkRecieveDialogWidget.OnPostAllInserted");

            _applied = true;
        }

        /// <summary>
        /// Fires after all scroll entries are inserted into the bulk-receive dialog.
        /// Reads totalItems (List&lt;EntryItemListData.Context&gt; at 0x48) count.
        /// Announces "X récompenses collectées." or generic fallback.
        /// </summary>
        public static void BulkReceive_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var f = __instance.GetType().GetField("totalItems",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                var list = f?.GetValue(__instance);
                int count = 0;
                if (list != null)
                {
                    var countProp = list.GetType().GetProperty("Count",
                        BindingFlags.Public | BindingFlags.Instance);
                    count = Convert.ToInt32(countProp?.GetValue(list) ?? 0);
                }

                string msg = count > 0
                    ? Loc.Get("mission_bulk_receive", count)
                    : Loc.Get("mission_bulk_receive_generic");
                tts.Speak(msg, interrupt: false);
            }
            catch { tts.Speak(Loc.Get("mission_bulk_receive_generic"), interrupt: false); }
        }
    }
}
