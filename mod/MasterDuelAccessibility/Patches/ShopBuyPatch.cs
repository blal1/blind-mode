using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour la boutique : ShopBuyViewController.
    ///
    /// ## Ce qui est announcé :
    ///
    /// A) NotificationStackEntry() — entrée dans l'écran boutique
    ///    → Annonce "Boutique" (l'utilisateur vient d'ouvrir l'écran boutique)
    ///
    /// B) OnChangedSelectionItem(SelectionItem prevItem, SelectionItem currentItem)
    ///    → Annonce le nom du produit actuellement sélectionné (nom + description courte)
    ///    → Lit depuis le sous-objet élément "ProductNameText" ou via réflexion sur ProductContext
    ///
    /// C) OnClickNextButton() / OnClickPrevButton()
    ///    → Annonce "Page suivante" / "Page précédente" pour la navigation entre produits
    ///
    /// D) OnFocusChanged(bool setfocus)
    ///    → Annonce le nom du produit courant quand ShopBuy reprend le focus (retour d'un dialog)
    ///
    /// ## Stratégie de lecture du nom du produit
    ///
    /// ShopBuyViewController.m_ProductContext contient le ProductContext courant.
    /// ProductContext.name (ou GetName()) retourne le nom du pack/produit.
    /// On lit via réflexion pour éviter la dépendance sur les types.
    /// </summary>
    internal static class ShopBuyPatch
    {
        private static string _lastAnnouncedProduct = "";

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            var type = AccessToolsHelper.FindType("YgomGame.Shop.ShopBuyViewController");
            if (type == null)
            {
                Plugin.Instance?.LogWarn("[ShopBuyPatch] ShopBuyViewController introuvable.");
                return;
            }

            PatchNotificationStackEntry(harmony, type);
            PatchOnChangedSelectionItem(harmony, type);
            PatchPageNavigation(harmony, type);
            PatchOnFocusChanged(harmony, type);
        }

        private static void PatchNotificationStackEntry(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[ShopBuyPatch] NotificationStackEntry introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(ShopBuyPatch), nameof(StackEntry_Postfix)));
            Plugin.Instance?.LogMsg("[ShopBuyPatch] ✓ ShopBuyViewController.NotificationStackEntry");
        }

        private static void PatchOnChangedSelectionItem(HarmonyLib.Harmony h, Type t)
        {
            // OnChangedSelectionItem(SelectionItem prevItem, SelectionItem currentItem)
            var m = t.GetMethod("OnChangedSelectionItem",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[ShopBuyPatch] OnChangedSelectionItem introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(ShopBuyPatch), nameof(SelectionItem_Postfix)));
            Plugin.Instance?.LogMsg("[ShopBuyPatch] ✓ ShopBuyViewController.OnChangedSelectionItem");
        }

        private static void PatchPageNavigation(HarmonyLib.Harmony h, Type t)
        {
            var next = t.GetMethod("OnClickNextButton",
                BindingFlags.NonPublic | BindingFlags.Instance);
            var prev = t.GetMethod("OnClickPrevButton",
                BindingFlags.NonPublic | BindingFlags.Instance);

            if (next != null)
            {
                h.Patch(next, postfix: new HarmonyMethod(
                    typeof(ShopBuyPatch), nameof(NextPage_Postfix)));
                Plugin.Instance?.LogMsg("[ShopBuyPatch] ✓ ShopBuyViewController.OnClickNextButton");
            }
            if (prev != null)
            {
                h.Patch(prev, postfix: new HarmonyMethod(
                    typeof(ShopBuyPatch), nameof(PrevPage_Postfix)));
                Plugin.Instance?.LogMsg("[ShopBuyPatch] ✓ ShopBuyViewController.OnClickPrevButton");
            }
        }

        private static void PatchOnFocusChanged(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OnFocusChanged",
                BindingFlags.Public | BindingFlags.Instance);
            if (m == null) return;

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(ShopBuyPatch), nameof(FocusChanged_Postfix)));
            Plugin.Instance?.LogMsg("[ShopBuyPatch] ✓ ShopBuyViewController.OnFocusChanged");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        private static void StackEntry_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                _lastAnnouncedProduct = "";
                tts.Speak(Loc.Get("screen_shop_buy"), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// OnChangedSelectionItem postfix.
        /// __1 = currentItem (SelectionItem)
        /// Lit le ProductContext depuis le ViewController parent via réflexion.
        /// Le nom du produit est dans m_ProductContext.GetName() ou .name.
        /// </summary>
        private static void SelectionItem_Postfix(object __instance, object __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Lit ProductContext depuis le champ m_ProductContext
                string? productName = ReadProductName(__instance);
                if (string.IsNullOrEmpty(productName) || productName == _lastAnnouncedProduct) return;
                _lastAnnouncedProduct = productName!;
                tts.Speak(productName!, interrupt: false);
            }
            catch { }
        }

        private static void NextPage_Postfix()
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("shop_page_next"), interrupt: false, addToHistory: false);
            _lastAnnouncedProduct = "";
        }

        private static void PrevPage_Postfix()
        {
            Plugin.Instance?.Tts?.Speak(Loc.Get("shop_page_prev"), interrupt: false, addToHistory: false);
            _lastAnnouncedProduct = "";
        }

        private static void FocusChanged_Postfix(object __instance, bool __0)
        {
            if (!__0) return; // setfocus=false → on ignore
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? name = ReadProductName(__instance);
                if (!string.IsNullOrEmpty(name) && name != _lastAnnouncedProduct)
                {
                    _lastAnnouncedProduct = name!;
                    tts.Speak(name!, interrupt: false);
                }
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>
        /// Lit le nom du produit courant via réflexion sur m_ProductContext.
        /// ProductContext.GetName() → string, sinon ProductContext.name, sinon DataContext.name.
        /// </summary>
        private static string? ReadProductName(object instance)
        {
            // Champ m_ProductContext
            var field = instance.GetType().GetField("m_ProductContext",
                BindingFlags.NonPublic | BindingFlags.Instance);
            var productCtx = field?.GetValue(instance);
            if (productCtx == null) return null;

            // Essayer GetName() en priorité
            var getNameMethod = productCtx.GetType().GetMethod("GetName",
                BindingFlags.Public | BindingFlags.Instance, null, Array.Empty<Type>(), null);
            if (getNameMethod != null)
                return getNameMethod.Invoke(productCtx, null) as string;

            // Fallback : propriété name
            var nameProp = productCtx.GetType().GetProperty("name",
                BindingFlags.Public | BindingFlags.Instance);
            return nameProp?.GetValue(productCtx) as string;
        }
    }
}
