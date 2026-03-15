using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches pour les widgets d'achat dans la boutique :
    ///
    ///   ConfirmRegDialogProductWidget.InnerBinding(EntryInsertWidgetData entryData)
    ///     → "Confirmation : [headerText]. [hasText]. [numText]."
    ///     Namespace : YgomGame.Shop
    ///     Champs publics : headerText (0x30), hasText (0x38), numText (0x40)
    ///
    ///   BuyButtonGroupWidget.Binding(ProductContext productData, TextGroupLoadHolder)
    ///     → "Acheter : [productName]."
    ///     Namespace : YgomGame.Shop
    ///     Propriété virtuelle : productName (Slot 9)
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ShopBuyWidgetPatch
    {
        private static bool _applied = false;

        // ConfirmRegDialogProductWidget fields
        private static FieldInfo?    _fHeaderText;
        private static FieldInfo?    _fHasText;
        private static FieldInfo?    _fNumText;

        // BuyButtonGroupWidget fields
        private static PropertyInfo? _pProductName;
        private static FieldInfo?    _fButtonCtx;
        private static FieldInfo?    _fBtnNumText;
        private static FieldInfo?    _fBtnPriceText;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            // ConfirmRegDialogProductWidget.InnerBinding
            var confirmType = AccessToolsHelper.FindType("YgomGame.Shop.ConfirmRegDialogProductWidget");
            if (confirmType != null)
            {
                var mBind = confirmType.GetMethod("InnerBinding",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mBind != null)
                {
                    harmony.Patch(mBind, postfix: new HarmonyLib.HarmonyMethod(
                        typeof(ShopBuyWidgetPatch), nameof(ConfirmWidget_Postfix)));
                    Plugin.Instance?.LogMsg("[ShopBuyWidgetPatch] ✓ ConfirmRegDialogProductWidget.InnerBinding");
                }
                else
                {
                    Plugin.Instance?.LogWarn("[ShopBuyWidgetPatch] ConfirmRegDialogProductWidget.InnerBinding introuvable.");
                }
            }
            else
            {
                Plugin.Instance?.LogWarn("[ShopBuyWidgetPatch] ConfirmRegDialogProductWidget introuvable.");
            }

            // BuyButtonGroupWidget.Binding (global namespace — no YgomGame.Shop prefix)
            var buyType = AccessToolsHelper.FindType("BuyButtonGroupWidget");
            if (buyType != null)
            {
                var mBind = buyType.GetMethod("Binding",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (mBind != null)
                {
                    harmony.Patch(mBind, postfix: new HarmonyLib.HarmonyMethod(
                        typeof(ShopBuyWidgetPatch), nameof(BuyWidget_Postfix)));
                    Plugin.Instance?.LogMsg("[ShopBuyWidgetPatch] ✓ BuyButtonGroupWidget.Binding");
                }
                else
                {
                    Plugin.Instance?.LogWarn("[ShopBuyWidgetPatch] BuyButtonGroupWidget.Binding introuvable.");
                }
            }
            else
            {
                Plugin.Instance?.LogWarn("[ShopBuyWidgetPatch] BuyButtonGroupWidget introuvable.");
            }

            _applied = true;
        }

        // ── ConfirmRegDialogProductWidget.InnerBinding ────────────────────────
        // Fields (all public): headerText (0x30), hasText (0x38), numText (0x40)

        public static void ConfirmWidget_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var t = __instance.GetType();
                if (_fHeaderText == null) _fHeaderText = FindField(t, "headerText");
                if (_fHasText   == null) _fHasText   = FindField(t, "hasText");
                if (_fNumText   == null) _fNumText   = FindField(t, "numText");

                string? header = _fHeaderText?.GetValue(__instance) as string;
                string? has    = _fHasText?.GetValue(__instance) as string;
                string? num    = _fNumText?.GetValue(__instance) as string;

                if (string.IsNullOrWhiteSpace(header)) return;

                tts.Speak(Loc.Get("shop_confirm_product",
                    header!,
                    string.IsNullOrWhiteSpace(has) ? string.Empty : has!,
                    string.IsNullOrWhiteSpace(num) ? string.Empty : num!),
                    interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ShopBuyWidgetPatch] ConfirmWidget {ex.Message}");
            }
        }

        // ── BuyButtonGroupWidget.Binding ──────────────────────────────────────
        // Param __0 = ProductContext productData (productName property)
        // __instance.m_ButtonCtx (ButtonContext) has numText + priceText after binding

        public static void BuyWidget_Postfix(object __instance, object __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || __0 == null) return;
            try
            {
                // product name from ProductContext param
                if (_pProductName == null)
                    _pProductName = __0.GetType().GetProperty("productName",
                        BindingFlags.Public | BindingFlags.Instance);
                string? name = _pProductName?.GetValue(__0) as string;
                if (string.IsNullOrWhiteSpace(name)) return;

                // price & quantity from m_ButtonCtx (private field on BuyButtonGroupWidget)
                var instType = __instance.GetType();
                if (_fButtonCtx == null)
                    _fButtonCtx = FindField(instType, "m_ButtonCtx");

                string? numText   = null;
                string? priceText = null;
                var ctx = _fButtonCtx?.GetValue(__instance);
                if (ctx != null)
                {
                    var ctxType = ctx.GetType();
                    if (_fBtnNumText   == null) _fBtnNumText   = FindField(ctxType, "numText");
                    if (_fBtnPriceText == null) _fBtnPriceText = FindField(ctxType, "priceText");
                    numText   = _fBtnNumText?.GetValue(ctx)   as string;
                    priceText = _fBtnPriceText?.GetValue(ctx) as string;
                }

                tts.Speak(Loc.Get("shop_buy_widget_product", name!,
                    string.IsNullOrWhiteSpace(numText)   ? string.Empty : numText!,
                    string.IsNullOrWhiteSpace(priceText) ? string.Empty : priceText!),
                    interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ShopBuyWidgetPatch] BuyWidget {ex.Message}");
            }
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
    }
}
