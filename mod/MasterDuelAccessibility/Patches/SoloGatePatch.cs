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
    /// B) OnItemSetDataMain(GameObject gob, int dataindex) — ISV navigation entre portails
    ///    → "Portail : [nom], X sur Y." (300 ms cooldown)
    ///    Chaîne : masterMainDataList[dataindex] → gateID
    ///             m_GateManager.masterDataDic[gateID] → SoloGateUtil.Data
    ///             Data.StrName (propriété internal) ou gateName (private field)
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   SoloGateViewController (namespace YgomGame.Solo)
    ///     ├─ mainDataList (List&lt;int&gt;, privé 0x1C8) — IDs des portails visibles
    ///     └─ m_GateManager (SoloGateUtil.GateManager, 0x1B8)
    ///          └─ masterDataDic (Dictionary&lt;int, Data&gt;) — lookup par gateID
    ///               └─ Data.StrName / Data.gateName — nom du portail
    ///
    /// Appliqué via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class SoloGatePatch
    {
        private static bool _applied = false;

        private static FieldInfo? _fMainDataList;

        // ISV navigation caches
        private static FieldInfo?    _fMasterMainDataList;
        private static FieldInfo?    _fGateManager;
        private static FieldInfo?    _fMasterDataDic;
        private static PropertyInfo? _pStrName;
        private static FieldInfo?    _fGateName;
        private static long          _lastISVTick = 0L;
        private const  long          ISVCooldownTicks = 3_000_000L; // 300 ms

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
            Plugin.Instance?.LogMsg("[SoloGatePatch] ✓ SoloGateViewController.NotificationStackEntry");

            // OnItemSetDataMain — ISV portal navigation
            var mISV = vcType.GetMethod("OnItemSetDataMain",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mISV != null)
            {
                harmony.Patch(mISV, postfix: new HarmonyMethod(
                    typeof(SoloGatePatch), nameof(OnItemSetDataMain_Postfix)));
                Plugin.Instance?.LogMsg("[SoloGatePatch] ✓ SoloGateViewController.OnItemSetDataMain");
            }

            _applied = true;
        }

        internal static void Reset()
        {
            _applied              = false;
            _fMainDataList        = null;
            _fMasterMainDataList  = null;
            _fGateManager         = null;
            _fMasterDataDic       = null;
            _pStrName             = null;
            _fGateName            = null;
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

        // ── ISV Navigation — OnItemSetDataMain ───────────────────────────────

        /// <summary>
        /// Postfix pour SoloGateViewController.OnItemSetDataMain(GameObject gob, int dataindex).
        /// Fires when an ISV item is set for a main portal. Announces portal name + N/M.
        /// Data chain: masterMainDataList[dataindex] → gateID → m_GateManager.masterDataDic[gateID] → Data.StrName
        /// </summary>
        public static void OnItemSetDataMain_Postfix(object __instance, object gob, int dataindex)
        {
            long now = DateTime.Now.Ticks;
            if (now - _lastISVTick < ISVCooldownTicks) return;
            _lastISVTick = now;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                var vcType = __instance.GetType();

                // masterMainDataList (List<int>) — gateIDs in display order
                if (_fMasterMainDataList == null)
                    _fMasterMainDataList = FindField(vcType, "masterMainDataList");
                var mainList = _fMasterMainDataList?.GetValue(__instance) as IList;
                if (mainList == null || dataindex < 0 || dataindex >= mainList.Count) return;

                int gateId = Convert.ToInt32(mainList[dataindex]);
                int total  = mainList.Count;

                // m_GateManager (SoloGateUtil.GateManager)
                if (_fGateManager == null)
                    _fGateManager = FindField(vcType, "m_GateManager");
                var gateManager = _fGateManager?.GetValue(__instance);
                if (gateManager == null) return;

                // masterDataDic (Dictionary<int, Data>)
                if (_fMasterDataDic == null)
                    _fMasterDataDic = gateManager.GetType().GetField("masterDataDic",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (_fMasterDataDic == null) return;

                var dict = _fMasterDataDic.GetValue(gateManager);
                if (dict == null) return;

                // dict[gateId] → SoloGateUtil.Data
                var getItem = dict.GetType().GetMethod("get_Item",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int) }, null);
                var gateData = getItem?.Invoke(dict, new object[] { gateId });
                if (gateData == null) return;

                // StrName property (internal string)
                string? name = null;
                if (_pStrName == null)
                    _pStrName = gateData.GetType().GetProperty("StrName",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                name = _pStrName?.GetValue(gateData) as string;

                // Fallback: private field gateName
                if (string.IsNullOrWhiteSpace(name))
                {
                    if (_fGateName == null)
                        _fGateName = FindField(gateData.GetType(), "gateName");
                    name = _fGateName?.GetValue(gateData) as string;
                }

                if (string.IsNullOrWhiteSpace(name)) return;

                tts.Speak(Loc.Get("solo_gate_isv_item", name, dataindex + 1, total), interrupt: true);
            }
            catch { }
        }

        private static FieldInfo? FindField(Type t, string name)
        {
            var cur = t;
            while (cur != null && cur != typeof(object))
            {
                var f = cur.GetField(name,
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (f != null) return f;
                cur = cur.BaseType;
            }
            return null;
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
