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

        // OnFocusProductLine — m_SectionDatas lookup
        private static FieldInfo?    _fSectionDatas;
        private static string?       _lastFocusedSectionLabel;
        private static long          _lastProductFocusTick = 0L;
        private const  long          ProductFocusCooldownTicks = 2_000_000L; // 200 ms

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
        /// Lit le labelText de la section via ShowcaseData.m_SectionDatas[catId][subId][secId].
        /// Stratégie : ShowcaseData.m_SectionDatas est un Dictionary à 3 niveaux imbriqués.
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
                // 1. ShowcaseData
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

                // 2. m_SectionDatas : Dictionary<int, Dictionary<int, Dictionary<int, IShopProductGruopData>>>
                if (_fSectionDatas == null)
                    _fSectionDatas = showcase.GetType().GetField("m_SectionDatas",
                        BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (_fSectionDatas == null) return;

                var secDatas = _fSectionDatas.GetValue(showcase);
                if (secDatas == null) return;

                // 3. Navigate secDatas[__0][__1][__2]
                object? sectionData = DictNavigate(secDatas, __0, __1, __2);
                if (sectionData == null) return;

                // 4. labelText : IShopProductGruopData.labelText (public property)
                if (_pLabelText == null)
                    _pLabelText = sectionData.GetType().GetProperty("labelText",
                        BindingFlags.Public | BindingFlags.Instance);
                string? label = _pLabelText?.GetValue(sectionData)?.ToString();

                if (!string.IsNullOrWhiteSpace(label) && label != _lastFocusedSectionLabel)
                {
                    _lastFocusedSectionLabel = label;
                    tts.Speak(Loc.Get("shop_product_focus", label!), interrupt: false);
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ShopViewControllerPatch] OnFocusProductLine {ex.Message}");
            }
        }

        // ── Helper : navigue dans un dict 3 niveaux via réflexion ─────────────

        private static object? DictNavigate(object dict3, int key1, int key2, int key3)
        {
            // Level 1 : dict3[key1] → dict2
            object? dict2 = DictGetValue(dict3, key1);
            if (dict2 == null) return null;
            // Level 2 : dict2[key2] → dict1
            object? dict1 = DictGetValue(dict2, key2);
            if (dict1 == null) return null;
            // Level 3 : dict1[key3] → value
            return DictGetValue(dict1, key3);
        }

        private static object? DictGetValue(object dict, int key)
        {
            try
            {
                var tryGetMethod = dict.GetType().GetMethod("TryGetValue",
                    BindingFlags.Public | BindingFlags.Instance);
                if (tryGetMethod == null) return null;
                var parms = tryGetMethod.GetParameters();
                if (parms.Length != 2) return null;

                // Créer un tableau pour le ref out param
                object?[] args = { key, null };
                bool found = (bool)(tryGetMethod.Invoke(dict, args) ?? false);
                return found ? args[1] : null;
            }
            catch { return null; }
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
