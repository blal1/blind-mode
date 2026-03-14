using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour ShopViewController — boutique principale.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — boutique ouverte
    ///    → "Boutique — [catégorie courante]." si lisible
    ///    → "Boutique." sinon
    ///
    /// B) OnClickMainTab(int idx) — onglet de catégorie cliqué
    ///    → "Boutique — [catégorie]." quand l'utilisateur change d'onglet
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   ShopViewController (namespace YgomGame.Shop)
    ///     m_ShowcaseData (ShowcaseData 0x150)
    ///       currentCategoryId (public property)
    ///       GetCategoryData(int id) → IShopProductGruopData
    ///         labelText (public property string) — nom de la catégorie affiché
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ShopViewControllerPatch
    {
        private static bool _applied = false;

        private static FieldInfo?   _fShowcaseData;
        private static PropertyInfo? _pCurrentCategoryId;
        private static MethodInfo?   _mGetCategoryData;
        private static PropertyInfo? _pLabelText;

        // OnFocusProductLine — ISV product navigation
        private static FieldInfo?    _fProductContextMap;
        private static PropertyInfo? _pCategoryId;
        private static PropertyInfo? _pSubCategoryId;
        private static PropertyInfo? _pSectionId;
        private static PropertyInfo? _pProductName;
        private static long _lastProductFocusTick = 0L;
        private const  long ProductFocusCooldownTicks = 2_000_000L; // 200 ms

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Shop.ShopViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[ShopViewControllerPatch] ShopViewController introuvable.");
                return;
            }

            // NotificationStackEntry — ouverture de la boutique
            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack != null)
            {
                harmony.Patch(mStack, postfix: new HarmonyMethod(
                    typeof(ShopViewControllerPatch), nameof(StackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[ShopViewControllerPatch] ✓ ShopViewController.NotificationStackEntry");
            }
            else
            {
                Plugin.Instance?.LogWarn("[ShopViewControllerPatch] NotificationStackEntry introuvable.");
            }

            // OnClickMainTab(int idx) — changement d'onglet
            var mTab = vcType.GetMethod("OnClickMainTab",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mTab != null)
            {
                harmony.Patch(mTab, postfix: new HarmonyMethod(
                    typeof(ShopViewControllerPatch), nameof(OnClickMainTab_Postfix)));
                Plugin.Instance?.LogMsg("[ShopViewControllerPatch] ✓ ShopViewController.OnClickMainTab");
            }

            // OnFocusProductLine(int categoryId, int subCategoryId, int sectionId)
            var mFocus = vcType.GetMethod("OnFocusProductLine",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mFocus != null)
            {
                harmony.Patch(mFocus, postfix: new HarmonyMethod(
                    typeof(ShopViewControllerPatch), nameof(OnFocusProductLine_Postfix)));
                Plugin.Instance?.LogMsg("[ShopViewControllerPatch] ✓ ShopViewController.OnFocusProductLine");
            }

            _applied = true;
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? catName = TryGetCurrentCategoryName(__instance);
                string msg = !string.IsNullOrWhiteSpace(catName)
                    ? Loc.Get("shop_open_category", catName!)
                    : Loc.Get("shop_vc_open");
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ShopViewControllerPatch] StackEntry {ex.Message}");
            }
        }

        public static void OnClickMainTab_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? catName = TryGetCurrentCategoryName(__instance);
                if (!string.IsNullOrWhiteSpace(catName))
                    tts.Speak(Loc.Get("shop_tab_selected", catName!), interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ShopViewControllerPatch] OnClickMainTab {ex.Message}");
            }
        }

        // ── Helper — lire le nom de la catégorie courante ─────────────────────

        /// <summary>
        /// Postfix pour ShopViewController.OnFocusProductLine(int categoryId, int subCategoryId, int sectionId).
        /// ISV callback — fires when a product line enters focus during scroll.
        /// Finds the first ProductContext matching the given IDs in m_ShowcaseData.m_ProductContextMap
        /// and announces its productName.
        /// </summary>
        public static void OnFocusProductLine_Postfix(object __instance, int __0, int __1, int __2)
        {
            long now = DateTime.Now.Ticks;
            if (now - _lastProductFocusTick < ProductFocusCooldownTicks) return;
            _lastProductFocusTick = now;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                // Resolve m_ShowcaseData
                if (_fShowcaseData == null)
                {
                    var vt = __instance.GetType();
                    while (vt != null && vt != typeof(object))
                    {
                        var f = vt.GetField("m_ShowcaseData",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fShowcaseData = f; break; }
                        vt = vt.BaseType;
                    }
                }
                if (_fShowcaseData == null) return;

                object? showcase = _fShowcaseData.GetValue(__instance);
                if (showcase == null) return;

                // m_ProductContextMap : Dictionary<int, ProductContext>
                if (_fProductContextMap == null)
                    _fProductContextMap = showcase.GetType().GetField("m_ProductContextMap",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (_fProductContextMap == null) return;

                var mapObj = _fProductContextMap.GetValue(showcase);
                if (mapObj == null) return;

                var valuesObj = mapObj.GetType()
                    .GetProperty("Values", BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(mapObj) as System.Collections.IEnumerable;
                if (valuesObj == null) return;

                foreach (object? product in valuesObj)
                {
                    if (product == null) continue;
                    var pt = product.GetType();

                    if (_pCategoryId == null)
                        _pCategoryId = pt.GetProperty("categoryId", BindingFlags.Public | BindingFlags.Instance);
                    if (_pSubCategoryId == null)
                        _pSubCategoryId = pt.GetProperty("subCategoryId", BindingFlags.Public | BindingFlags.Instance);
                    if (_pSectionId == null)
                        _pSectionId = pt.GetProperty("sectionId", BindingFlags.Public | BindingFlags.Instance);

                    int catId = Convert.ToInt32(_pCategoryId?.GetValue(product) ?? -1);
                    if (catId != __0) continue;
                    int subId = Convert.ToInt32(_pSubCategoryId?.GetValue(product) ?? -1);
                    if (subId != __1) continue;
                    int secId = Convert.ToInt32(_pSectionId?.GetValue(product) ?? -1);
                    if (secId != __2) continue;

                    if (_pProductName == null)
                        _pProductName = pt.GetProperty("productName", BindingFlags.Public | BindingFlags.Instance);
                    string? name = _pProductName?.GetValue(product) as string;
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        tts.Speak(Loc.Get("shop_product_focus", name), interrupt: true);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ShopViewControllerPatch] OnFocusProductLine {ex.Message}");
            }
        }

        private static string? TryGetCurrentCategoryName(object vcInstance)
        {
            try
            {
                // m_ShowcaseData
                if (_fShowcaseData == null)
                {
                    var t = vcInstance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField("m_ShowcaseData",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fShowcaseData = f; break; }
                        t = t.BaseType;
                    }
                }
                if (_fShowcaseData == null) return null;

                object? showcase = _fShowcaseData.GetValue(vcInstance);
                if (showcase == null) return null;

                // currentCategoryId (public property)
                if (_pCurrentCategoryId == null)
                    _pCurrentCategoryId = showcase.GetType().GetProperty("currentCategoryId",
                        BindingFlags.Public | BindingFlags.Instance);

                int catId = (_pCurrentCategoryId != null)
                    ? Convert.ToInt32(_pCurrentCategoryId.GetValue(showcase))
                    : 0;

                // GetCategoryData(int id) → IShopProductGruopData
                if (_mGetCategoryData == null)
                    _mGetCategoryData = showcase.GetType().GetMethod("GetCategoryData",
                        BindingFlags.Public | BindingFlags.Instance);
                if (_mGetCategoryData == null) return null;

                object? catData = _mGetCategoryData.Invoke(showcase, new object[] { catId });
                if (catData == null) return null;

                // labelText (public property)
                if (_pLabelText == null)
                    _pLabelText = catData.GetType().GetProperty("labelText",
                        BindingFlags.Public | BindingFlags.Instance);

                return _pLabelText?.GetValue(catData)?.ToString();
            }
            catch { return null; }
        }
    }
}
