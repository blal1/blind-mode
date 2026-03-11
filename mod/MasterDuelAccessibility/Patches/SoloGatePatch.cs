using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour SoloGateViewController — carte du monde Solo (liste des portails).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — écran ouvert
    ///    → "Portails Solo — N portail(s)."
    ///    ou → "Portails Solo." si le comptage échoue.
    ///
    /// Note : la navigation individuelle entre portails est couverte par
    /// SelectionButtonPatch.ProcessDuelMenu qui lit les textes du bouton focalisé.
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   SoloGateViewController (namespace YgomGame.Solo)
    ///     └─ mainDataList (List&lt;int&gt;, privé 0x1C8) — IDs des portails visibles
    ///
    /// Appliqué via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class SoloGatePatch
    {
        private static bool _applied = false;

        private static FieldInfo? _fMainDataList;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Solo.SoloGateViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[SoloGatePatch] SoloGateViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[SoloGatePatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(SoloGatePatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[SoloGatePatch] ✓ SoloGateViewController.NotificationStackEntry");
        }

        internal static void Reset()
        {
            _applied       = false;
            _fMainDataList = null;
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int count = GetMainListCount(__instance);
                string msg = count > 0
                    ? Loc.Get("solo_gate_open_count", count)
                    : Loc.Get("solo_gate_open");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[SoloGatePatch] StackEntry: {ex.Message}");
            }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static int GetMainListCount(object vc)
        {
            try
            {
                if (_fMainDataList == null)
                    _fMainDataList = vc.GetType().GetField("mainDataList",
                        BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var list = _fMainDataList?.GetValue(vc) as IList;
                return list?.Count ?? 0;
            }
            catch { return 0; }
        }
    }
}
