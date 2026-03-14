using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Postfix for YgomSystem.UI.ColorContainerGraphic.SetColor —
    /// announces icon-only buttons (no text label) when navigated to.
    ///
    /// Trigger: currentStatusMode == 2 (ColorContainer.StatusMode.Enter = hover/navigation).
    /// Note: SetColor() has no int parameter; currentStatusMode is read from the instance.
    ///
    /// Walks parent.parent then parent.parent.parent to find the button name
    /// and maps it to a readable label via Loc.
    /// </summary>
    internal static class ColorContainerPatch
    {
        // ColorContainer.StatusMode.Enter == 2
        private const int EnterMode = 2;

        private static readonly BindingFlags Pub =
            BindingFlags.Public | BindingFlags.Instance;

        // ── Trigger ──────────────────────────────────────────────────────────

        public static void SetColor_Postfix(object __instance)
        {
            if (ReadCurrentStatusMode(__instance) != EnterMode) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                string? label = FindButtonLabel(__instance);
                if (!string.IsNullOrWhiteSpace(label))
                    tts.Speak(label!, interrupt: false);
            }
            catch { /* silent reflection fail */ }
        }

        // ── currentStatusMode reader ──────────────────────────────────────────

        private static int ReadCurrentStatusMode(object instance)
        {
            var type = instance.GetType();
            while (type != null && type != typeof(object))
            {
                var prop = type.GetProperty("currentStatusMode",
                    BindingFlags.Public | BindingFlags.NonPublic |
                    BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (prop != null)
                    return Convert.ToInt32(prop.GetValue(instance));
                type = type.BaseType;
            }
            return -1;
        }

        // ── Hierarchy helpers ─────────────────────────────────────────────────

        private static object? Trans(object instance) =>
            instance.GetType().GetProperty("transform", Pub)?.GetValue(instance);

        private static object? Up(object? t) =>
            t?.GetType().GetProperty("parent", Pub)?.GetValue(t);

        private static string? ObjName(object? t) =>
            t?.GetType().GetProperty("name", Pub)?.GetValue(t)?.ToString();

        private static object? GO(object? t) =>
            t?.GetType().GetProperty("gameObject", Pub)?.GetValue(t);

        private static object? Child(object? t, int idx)
        {
            if (t == null) return null;
            var m = t.GetType().GetMethod("GetChild", Pub, null, new[] { typeof(int) }, null);
            return m?.Invoke(t, new object[] { idx });
        }

        private static string? ReadText(object? go)
        {
            if (go == null) return null;
            foreach (var typeName in new[] { "RubyTextGX", "ExtendedTextMeshProUGUI", "TMP_Text" })
            {
                var compType = AccessToolsHelper.FindType(typeName);
                if (compType == null) continue;

                var getCompsM = go.GetType().GetMethod(
                    "GetComponentsInChildren", Pub, null,
                    new[] { typeof(Type), typeof(bool) }, null);

                var arr = getCompsM?.Invoke(go, new object[] { compType, false }) as Array;
                if (arr == null) continue;

                var textProp = compType.GetProperty("text", Pub);
                foreach (var item in arr)
                {
                    var text = textProp?.GetValue(item)?.ToString();
                    if (!string.IsNullOrWhiteSpace(text)) return text;
                }
            }
            return null;
        }

        // ── Click SelectionButton via reflection ──────────────────────────────

        private static void ClickSelectionButton(object? go)
        {
            if (go == null) return;
            try
            {
                var sbType = AccessToolsHelper.FindType("YgomSystem.UI.SelectionButton");
                if (sbType == null) return;
                var getComp = go.GetType().GetMethod(
                    "GetComponent", Pub, null, new[] { typeof(Type) }, null);
                var sb = getComp?.Invoke(go, new object[] { sbType });
                if (sb == null) return;
                sbType.GetMethod("Click", Pub)?.Invoke(sb, null);
            }
            catch { }
        }

        // ── Label finder ──────────────────────────────────────────────────────

        private static string? FindButtonLabel(object instance)
        {
            var xform  = Trans(instance);
            var level1 = Up(xform);
            var level2 = Up(level1);
            if (level2 == null) return null;

            var name2 = ObjName(level2);

            // ── DuelListCard: in-duel card list ───────────────────────────────
            if (GameState.CurrentMenu == GameState.Menu.Duel
                && name2 != null && name2.Contains("DuelListCard"))
            {
                ClickSelectionButton(GO(level2));
                return null; // CardInfoPatch will announce the card name
            }

            // ── Level-2 (parent.parent) ───────────────────────────────────────
            if (name2 != null)
            {
                switch (name2)
                {
                    case "ButtonMaintenance":    return Loc.Get("btn_maintenance");
                    case "ButtonBug":            return Loc.Get("btn_bug");
                    case "ButtonNotification":   return Loc.Get("btn_notification");
                    case "InputButton":          return Loc.Get("btn_input");
                    case "AutoBuildButton":      return Loc.Get("btn_auto_build");
                    case "ButtonBookmark":       return Loc.Get("btn_bookmark_add");
                    case "BookmarkButton":       return Loc.Get("btn_bookmarks");
                    case "HowToGetButton":       return Loc.Get("btn_how_to_get");
                    case "RelatedCard":          return Loc.Get("btn_related_cards");

                    case "DismantleButton":
                    {
                        var cost = ReadText(GO(Child(level2, 6)));
                        return string.IsNullOrEmpty(cost)
                            ? Loc.Get("dismantle_cant")
                            : Loc.Get("dismantle_cost", cost);
                    }

                    case "CreateButton":
                    {
                        var cost = ReadText(GO(Child(level2, 6)));
                        return Loc.Get("create_cost", cost ?? "?");
                    }

                    case "AddButton":            return Loc.Get("btn_add");
                    case "RemoveButton":         return Loc.Get("btn_remove");
                    case "CardListButton":       return Loc.Get("btn_card_list");
                    case "HistotyButton":        return Loc.Get("btn_card_history");
                    case "CopyButton":           return Loc.Get("btn_copy_deck");
                    case "ButtonSave":           return Loc.Get("btn_save");
                    case "ButtonMenu":           return Loc.Get("btn_menu");
                    case "DuelMenuButton":       return Loc.Get("btn_duel_menu");
                    case "ButtonPickupCard":     return Loc.Get("btn_show_pack");
                    case "ButtonSecretPack":     return Loc.Get("btn_secret_pack");
                    case "ButtonRegulation":     return Loc.Get("btn_regulation");
                    case "ButtonInfoSwitching":  return Loc.Get("btn_switch_display");
                    case "FilterButton":         return Loc.Get("btn_filters");
                    case "SortButton":           return Loc.Get("btn_sort");
                    case "ClearButton":          return Loc.Get("btn_clear_filters");

                    case "Button0":
                    {
                        var prefix = ReadText(GO(Up(level2)));
                        return Loc.Get("btn_sort_asc", prefix ?? "");
                    }
                    case "Button1":
                    {
                        var prefix = ReadText(GO(Up(level2)));
                        return Loc.Get("btn_sort_desc", prefix ?? "");
                    }

                    case "ButtonDismantleIncrement": return Loc.Get("btn_increment");
                    case "ButtonDismantleDecrement": return Loc.Get("btn_decrement");
                    case "ButtonEnter":          return Loc.Get("btn_play");
                    case "OKButton":             return Loc.Get("btn_ok");
                    case "ShowOwnedNumToggle":   return Loc.Get("btn_show_owned");
                    case "BulkDecksDeletionButton": return Loc.Get("btn_bulk_delete");
                    case "ButtonOpenNeuronDecks": return Loc.Get("btn_neuron");
                }
            }

            // ── Level-3 (parent.parent.parent) ───────────────────────────────
            var name3 = ObjName(Up(level2));
            if (name3 != null)
            {
                switch (name3)
                {
                    case "TabMyDeck":      return Loc.Get("tab_my_deck");
                    case "TabRental":      return Loc.Get("tab_rental");
                    case "DuelMenuButton": return Loc.Get("btn_duel_menu");

                    case "ChapterDuel(Clone)":
                    {
                        var stars = ReadText(GO(Child(level2, 4)));
                        return Loc.Get("chapter_duel", stars ?? "?");
                    }
                }
            }

            return null;
        }
    }
}
