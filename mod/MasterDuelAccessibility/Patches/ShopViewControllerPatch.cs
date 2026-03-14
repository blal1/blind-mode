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
