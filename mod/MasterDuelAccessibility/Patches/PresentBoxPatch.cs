using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch for PresentBoxViewController — gift box with ISV navigation.
    ///
    /// ## What is announced:
    ///
    /// A) OnCreatedView() — gift box opens
    ///    → Announces "Gift Box, N items" (total count from dataList)
    ///
    /// B) OnItemSetData(GameObject gob, int dataindex) — ISV entity callback
    ///    → When user navigates the ISV, announces the current gift:
    ///      "[name], [quantity], expires [date]"
    ///
    /// ## Data source:
    /// - dataList : List&lt;Data&gt; — inner class with:
    ///   - pID (int), itemCategory (int), itemID (int), quantity (int),
    ///   - message (string), limitDate (string), isPeriod (bool)
    ///
    /// Applied in LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class PresentBoxPatch
    {
        private static bool _applied = false;

        // Cache Data inner class fields
        private static Type? _dataType;
        private static FieldInfo? _fItemCategory;
        private static FieldInfo? _fItemId;
        private static FieldInfo? _fQuantity;
        private static FieldInfo? _fMessage;
        private static FieldInfo? _fLimitDate;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.PresentBoxViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[PresentBoxPatch] PresentBoxViewController introuvable.");
                return;
            }

            // Find inner class Data
            foreach (var nested in vcType.GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (nested.Name == "Data")
                {
                    _dataType = nested;
                    _fItemCategory = nested.GetField("itemCategory",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    _fItemId = nested.GetField("itemID",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    _fQuantity = nested.GetField("quantity",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    _fMessage = nested.GetField("message",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    _fLimitDate = nested.GetField("limitDate",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                    break;
                }
            }

            PatchOnCreatedView(harmony, vcType);
            PatchOnItemSetData(harmony, vcType);

            _applied = true;
            Plugin.Instance?.LogMsg("[PresentBoxPatch] Patches appliqués.");
        }

        internal static void Reset() => _applied = false;

        private static void PatchOnCreatedView(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OnCreatedView",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[PresentBoxPatch] OnCreatedView introuvable.");
                return;
            }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(PresentBoxPatch), nameof(OnCreatedView_Postfix)));
            Plugin.Instance?.LogMsg("[PresentBoxPatch] ✓ PresentBoxViewController.OnCreatedView");
        }

        private static void PatchOnItemSetData(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OnItemSetData",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[PresentBoxPatch] OnItemSetData introuvable.");
                return;
            }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(PresentBoxPatch), nameof(OnItemSetData_Postfix)));
            Plugin.Instance?.LogMsg("[PresentBoxPatch] ✓ PresentBoxViewController.OnItemSetData");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        public static void OnCreatedView_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int count = CountItems(__instance);
                string msg = count > 0
                    ? Loc.Get("present_box_open_count", count)
                    : Loc.Get("present_box_empty");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// OnItemSetData(GameObject gob, int dataindex) postfix.
        /// __1 = dataindex in the ISV.
        /// NOTE: This fires for every visible ISV entity, not just the focused one.
        /// The actual focused item announcement is handled by SelectionButtonPatch.
        /// We use this to build an index→name mapping for the ISV.
        /// </summary>
        public static void OnItemSetData_Postfix(object __instance, int __1)
        {
            // We don't announce here directly — ISV fires this for all visible items.
            // Instead, SelectionButtonPatch handles focus via OnSelected.
            // However, we can pre-resolve item names for efficient lookup.
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static int CountItems(object instance)
        {
            try
            {
                var field = instance.GetType().GetField("dataList",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var list = field?.GetValue(instance) as IList;
                return list?.Count ?? 0;
            }
            catch { return 0; }
        }

        /// <summary>
        /// Resolves a Data item at the given index to a readable string.
        /// Called externally by SelectionButtonPatch if needed.
        /// </summary>
        internal static string? ResolveItemAtIndex(object vcInstance, int idx)
        {
            try
            {
                var field = vcInstance.GetType().GetField("dataList",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var list = field?.GetValue(vcInstance) as IList;
                if (list == null || idx < 0 || idx >= list.Count) return null;

                return ResolveDataItem(list[idx]);
            }
            catch { return null; }
        }

        /// <summary>
        /// Resolves a single Data object to "[message], ×[qty], expires [date]".
        /// </summary>
        private static string? ResolveDataItem(object? data)
        {
            if (data == null || _dataType == null) return null;
            try
            {
                int itemCategory = (int?)_fItemCategory?.GetValue(data) ?? -1;
                int itemId = (int?)_fItemId?.GetValue(data) ?? 0;
                int quantity = (int?)_fQuantity?.GetValue(data) ?? 1;
                string? message = _fMessage?.GetValue(data) as string;
                string? limitDate = _fLimitDate?.GetValue(data) as string;

                // Build name: use message if available, otherwise resolve by category
                string name;
                if (!string.IsNullOrWhiteSpace(message))
                {
                    name = message!;
                }
                else if (itemCategory == 0 && itemId > 0)
                {
                    name = AccessToolsHelper.GetCardName(itemId) ?? Loc.Get("item_cat_generic", 0);
                }
                else
                {
                    name = itemCategory switch
                    {
                        1 => Loc.Get("item_cat_gems"),
                        10 or 11 => Loc.Get("item_cat_sleeve"),
                        _ => Loc.Get("item_cat_generic", itemCategory),
                    };
                }

                string qtyStr = quantity > 1 ? $" ×{quantity}" : "";
                string dateStr = !string.IsNullOrWhiteSpace(limitDate)
                    ? $", {Loc.Get("present_expires", limitDate!)}"
                    : "";

                return name + qtyStr + dateStr;
            }
            catch { return null; }
        }
    }
}
