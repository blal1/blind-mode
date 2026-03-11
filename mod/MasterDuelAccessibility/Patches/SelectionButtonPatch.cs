using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.RegularExpressions;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches for YgomSystem.UI.SelectionButton:
    ///   - OnSelected     : announces the focused button label, with menu context
    ///   - OnPointerClick : detects main menu changes and duel end
    ///
    /// Text reading strategy:
    ///   1. ReadText(gameObject) : RubyTextGX → ExtendedTextMeshProUGUI → TMP_Text
    ///   2. Dispatch to context processor based on GameState.CurrentMenu
    ///   3. The processor may replace or enrich the base text
    ///
    /// A 100 ms cooldown prevents repeated announcements on the same button.
    /// </summary>
    internal static class SelectionButtonPatch
    {
        private static string _lastSpoken = string.Empty;
        private static DateTime _lastSpokenAt = DateTime.MinValue;
        private static readonly TimeSpan Cooldown = TimeSpan.FromMilliseconds(100);

        // Elements that show card info after a click with a short delay
        // Elements that show card info after a click with a short delay
        private static readonly HashSet<string> _previewElements = new HashSet<string>
        {
            "CardPict", "CardClone", "CreateButton", "ImageCard",
            "NextButton", "PrevButton", "Related Cards", "ThumbButton",
            "SlotTemplate(Clone)", "Locator",
            "GoldpassRewardButton", "NormalpassRewardButton", "ButtonDuelPass",
        };

        private static readonly BindingFlags Pub =
            BindingFlags.Public | BindingFlags.Instance;

        // Boundary detection (Strings.cs: BeginningOfList / EndOfList pattern)
        private static object? _lastSelectedObject = null;
        private static DateTime _lastBoundaryAt = DateTime.MinValue;
        private static readonly TimeSpan BoundaryCooldown = TimeSpan.FromMilliseconds(600);

        // ── OnSelected ───────────────────────────────────────────────────────

        public static void OnSelected_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || __instance == null) return;

            try
            {
                // ── Boundary detection ────────────────────────────────────────
                // When the same element is re-selected (user tries to navigate past
                // beginning or end of a list), announce the boundary.
                // Pattern: Strings.cs BeginningOfList / EndOfList.
                var now = DateTime.Now;
                if (ReferenceEquals(__instance, _lastSelectedObject))
                {
                    if (now - _lastBoundaryAt > BoundaryCooldown)
                    {
                        _lastBoundaryAt = now;
                        // We can't distinguish direction here, so we announce a neutral boundary.
                        // Individual context processors may override with a more precise message.
                        tts.Speak(Loc.Get("nav_boundary"), interrupt: false, addToHistory: false);
                    }
                    return; // Don't re-announce the element text
                }
                _lastSelectedObject = __instance;

                // ── Lottery card buttons ─────────────────────────────────────
                // If this button was mapped to a card ID by LotteryRewardPatch,
                // announce the card name directly instead of the generic text.
                try
                {
                    var getIdM = __instance.GetType().GetMethod("GetInstanceID",
                        BindingFlags.Public | BindingFlags.Instance);
                    if (getIdM?.Invoke(__instance, null) is int iid)
                    {
                        string? lotteryCard = LotteryRewardPatch.TryGetCardName(iid);
                        if (lotteryCard != null)
                        {
                            tts.Speak(lotteryCard, interrupt: true);
                            return;
                        }
                    }
                }
                catch { /* non-critical fallback to normal path */ }

                string? text = ReadText(GetGO(GetTransform(__instance)));
                if (!string.IsNullOrWhiteSpace(text))
                    text = Regex.Replace(text, "<[^>]+>", "").Trim();

                string? contextText = ProcessContext(__instance, text);
                if (contextText != null)
                    text = contextText;

                if (string.IsNullOrWhiteSpace(text)) return;

                // Append "N sur M" position info when in a list context.
                var pos = GeneralMenuNavigator.GetPosition(GetTransform(__instance));
                if (pos.HasValue)
                    text += Loc.Get("nav_position", pos.Value.index, pos.Value.total);

                if (text == _lastSpoken && (now - _lastSpokenAt) < Cooldown) return;
                _lastSpoken = text;
                _lastSpokenAt = now;

                tts.Speak(text, interrupt: true);
            }
            catch { /* silent reflection fail */ }
        }


        // ── OnPointerClick ───────────────────────────────────────────────────

        public static void OnPointerClick_Postfix(object __instance)
        {
            try
            {
                string? name = GetName(__instance);

                // Schedule a delayed card info read for elements that update the card panel on click
                if (name != null && _previewElements.Contains(name))
                {
                    // DuelPass buttons take longer for the UI to settle
                    double delaySec = (name == "ButtonDuelPass"
                        || name == "GoldpassRewardButton"
                        || name == "NormalpassRewardButton") ? 1.5 : 0.5;
                    KeyboardShortcuts.PendingCardReadAt = DateTime.Now.AddSeconds(delaySec);
                }

                string? text = ReadText(GetGO(GetTransform(__instance)));
                if (!string.IsNullOrWhiteSpace(text))
                {
                    text = Regex.Replace(text, "<[^>]+>", "").Trim();
                    if (GameState.MenuNames.TryGetValue(text, out var menu))
                        GameState.CurrentMenu = menu;
                }

                if (name == "ButtonDecidePositive(Clone)" && KeyboardShortcuts.IsInDuel)
                    KeyboardShortcuts.IsInDuel = false;
            }
            catch { /* silent */ }
        }

        // ── OnDeselected ─────────────────────────────────────────────────────

        /// <summary>
        /// Reset the last-spoken cache when a button loses focus so that
        /// navigating away and back will always re-announce the button.
        /// </summary>
        public static void OnDeselected_Postfix()
        {
            _lastSpoken = string.Empty;
        }

        // ── Context dispatch ─────────────────────────────────────────────────

        private static string? ProcessContext(object instance, string? baseText)
        {
            switch (GameState.CurrentMenu)
            {
                case GameState.Menu.None:
                    return ProcessNotificationsPopup(instance)
                        ?? ProcessFriendsMenu(instance)
                        ?? ProcessProfile(instance, baseText)
                        ?? ProcessEventBanner(instance)
                        ?? ProcessTopicsBanner(instance);

                case GameState.Menu.Notifications:
                    return ReadNotificationText(instance);

                case GameState.Menu.Missions:
                    return ProcessMissionsMenu(instance);

                case GameState.Menu.Shop:
                    return ProcessPacks(instance)
                        ?? ProcessCardPack(instance);

                case GameState.Menu.DuelPass:
                    return ProcessDuelPass(instance, baseText);

                case GameState.Menu.Deck:
                    return ProcessNewDeck(instance)
                        ?? ProcessDecksMenu(instance, baseText);

                case GameState.Menu.Settings:
                    return ProcessSettingsMenu(instance);

                case GameState.Menu.CardBrowser:
                    return ProcessCardBrowser(instance);

                case GameState.Menu.Solo:
                case GameState.Menu.Duel:
                    return ProcessDuelGame(instance)
                        ?? ProcessDuelMenu(instance);

                default:
                    return null;
            }
        }

        // ── Context processors ────────────────────────────────────────────────

        private static string? ProcessNotificationsPopup(object instance)
        {
            var t = GetTransform(instance);
            for (int i = 0; i < 6; i++) t = GetParent(t);
            if (GetName(t) == "NotificationWidget")
                return ReadNotificationText(instance);
            return null;
        }

        private static string? ProcessFriendsMenu(object instance)
        {
            switch (GetName(instance))
            {
                case "SearchButton":
                    return Loc.Get("friends_add");
                case "OpenToggle":
                    return ReadText(GetGO(GetParent(GetTransform(instance))));
            }
            return null;
        }

        private static string? ProcessProfile(object instance, string? baseText)
        {
            if (GetName(instance) != "ButtonPlayer") return null;
            // transform.GetChild(0).GetChild(1).GetChild(1).GetChild(1) = player level
            var t = GetTransform(instance);
            var level = ChildAt(ChildAt(ChildAt(ChildAt(t, 0), 1), 1), 1);
            string? lvl = ReadText(GetGO(level));
            if (!string.IsNullOrEmpty(lvl))
                return Loc.Get("profile_level", baseText ?? "", lvl);
            return null;
        }

        private static string? ProcessEventBanner(object instance)
            => GetName(instance) == "DuelShortcut" ? Loc.Get("event_banner") : null;

        private static string? ProcessMissionsMenu(object instance)
        {
            if (GetName(instance) != "Locator") return null;
            try
            {
                var t = GetTransform(instance);

                var ancestor = t;
                for (int i = 0; i < 9; i++) ancestor = GetParent(ancestor);
                string? missionName = ReadText(GetGO(ancestor));

                var rewardChild = ChildAt(ChildAt(t, 0), 2);
                string? rewardRaw = ReadText(GetGO(rewardChild));
                string reward = !string.IsNullOrEmpty(rewardRaw) && rewardRaw!.Length > 1
                    ? "x" + rewardRaw.Substring(1)
                    : rewardRaw ?? "?";

                var timePath = ChildAt(ChildAt(ChildAt(ChildAt(ancestor, 1), 0), 3), 0);
                string? timeLeft = ReadText(GetGO(timePath)) ?? "–";

                return Loc.Get("mission_info", missionName ?? "?", reward, timeLeft);
            }
            catch { return null; }
        }

        private static string? ProcessPacks(object instance)
        {
            var t = GetTransform(instance);
            // Walk up to 5 ancestors to find a "Shop"-named container
            // (covers featured packs, bundles, structural decks in different layouts)
            bool inShopContext = false;
            var walker = GetParent(t);
            for (int i = 0; i < 5 && walker != null; i++, walker = GetParent(walker))
            {
                if ((GetName(walker) ?? "").Contains("Shop", System.StringComparison.OrdinalIgnoreCase))
                {
                    inShopContext = true;
                    break;
                }
            }
            if (!inShopContext) return null;
            try
            {
                var texts   = CollectAllTexts(GetGO(t));
                string? pickup  = FindByKey(texts, "PickupMessage");
                string? name    = FindByKey(texts, "Name");
                string? newText = FindByKey(texts, "New");
                string? limit   = FindByKey(texts, "Limit");
                string? price   = FindByKey(texts, "PriceGroup");

                // Category header from fixed scene path
                var headerGO = FindGameObjectByPath(
                    "UI/ContentCanvas/ContentManager/Shop/ShopUI(Clone)/Root/Main/" +
                    "ProductsRoot/ShowcaseWidget/ListRoot/ProductList/Viewport/Mask/" +
                    "Content/ShopGroupHeaderWidget(Clone)/Label");
                string? category = ReadText(headerGO);

                string packLabel = string.IsNullOrEmpty(name)
                    ? (pickup ?? "")
                    : string.IsNullOrEmpty(pickup) ? name : $"{pickup} - {name}";
                if (!string.IsNullOrEmpty(newText))
                    packLabel += $" ({newText})";

                return Loc.Get("shop_pack_info", packLabel, category ?? "",
                    limit ?? Loc.Get("shop_no_limit"), price ?? "");
            }
            catch { return null; }
        }

        private static string? ProcessDuelPass(object instance, string? baseText)
        {
            var name = GetName(instance);
            if (name == null || !name.Contains("passRewardButton")) return null;

            string passType = name.Contains("Normalpass")
                ? Loc.Get("duelpass_normal")
                : Loc.Get("duelpass_gold");
            string? grade = ReadText(GetGO(GetParent(GetParent(GetTransform(instance))))) ?? "?";
            string qty = !string.IsNullOrEmpty(baseText) && baseText!.Length > 1
                ? "x" + baseText.Substring(1)
                : baseText ?? "?";

            return Loc.Get("duelpass_info", passType, grade, qty);
        }

        private static string? ProcessNewDeck(object instance)
        {
            var iconT = FindChild(GetTransform(instance), "IconAddDeck");
            if (iconT != null && IsActive(GetGO(iconT)))
                return Loc.Get("new_deck");
            return null;
        }

        private static string? ProcessDecksMenu(object instance, string? baseText)
        {
            var t = GetTransform(instance);
            var level3name = GetName(GetParent(GetParent(GetParent(t))));
            if (level3name == "InputButton")     return Loc.Get("deck_rename");
            if (level3name == "AutoBuildButton") return Loc.Get("deck_auto_build");
            if (level3name == "Category")
            {
                string? catText = ReadText(GetGO(GetParent(GetParent(t))));
                if (!string.IsNullOrEmpty(catText))
                    return Loc.Get("deck_category", baseText ?? "", catText);
            }
            return null;
        }

        private static string? ProcessDuelGame(object instance)
        {
            if (!KeyboardShortcuts.IsInDuel) return null;
            var name = GetName(instance);
            if (name == null) return null;
            if (name.Contains("HandCard")) return null; // CardInfoPatch handles detail
            if (name.Contains("Anchor_"))
                return Loc.Get("duel_field_card_selected");
            return null;
        }

        private static string? ProcessCardPack(object instance)
        {
            if (GetName(instance) != "CardPict") return null;
            try
            {
                var t       = GetTransform(instance);
                var parentT = GetParent(t);

                // Quantity from NumTextArea sibling
                string? qty = ReadText(GetGO(FindChild(parentT, "NumTextArea")));
                if (!string.IsNullOrEmpty(qty) && qty!.Length > 1)
                    qty = "x" + qty.Substring(1);

                // Rarity from IconRarity → Image.sprite name
                string rarity = GetRarityLabel(GetGO(FindChild(parentT, "IconRarity")));

                // New flag
                bool isNew = IsActive(GetGO(FindChild(parentT, "NewIcon")));

                return Loc.Get("card_pack_entry", rarity,
                    isNew ? Loc.Get("yes") : Loc.Get("no"), qty ?? "?");
            }
            catch { return null; }
        }

        private static string? ProcessSettingsMenu(object instance)
        {
            if (GetName(instance) == "CancelButton") return null;
            var t  = GetTransform(instance);
            var pp = GetParent(GetParent(t));
            if (GetName(pp) == "Layout") return null;
            if (GetName(GetParent(pp)) == "EntryButtonsScrollView") return null;

            string? baseText = ReadText(GetGO(t));
            try
            {
                var go = GetGO(t);
                var sliderType = AccessToolsHelper.FindType("UnityEngine.UI.Slider");
                if (sliderType != null)
                {
                    var getCompM = go?.GetType().GetMethod(
                        "GetComponentInChildren", Pub, null,
                        new[] { typeof(Type), typeof(bool) }, null);
                    var slider = getCompM?.Invoke(go, new object[] { sliderType, false });
                    if (slider != null)
                    {
                        object val = sliderType.GetProperty("value",    Pub)?.GetValue(slider) ?? 0;
                        object max = sliderType.GetProperty("maxValue", Pub)?.GetValue(slider) ?? 0;
                        return Loc.Get("settings_slider", baseText ?? "", val, max);
                    }
                }

                // Fallback: find "ModeText" child for toggle/select values
                string? modeVal = ReadText(GetGO(FindChild(t, "ModeText")));
                if (!string.IsNullOrEmpty(modeVal))
                    return Loc.Get("settings_mode", baseText ?? "", modeVal);

                return null;
            }
            catch { return null; }
        }

        private static string? ProcessTopicsBanner(object instance)
        {
            if (GetName(instance) != "ButtonBanner") return null;
            try
            {
                var parentGO = GetGO(GetParent(GetTransform(instance)));
                var snapType = AccessToolsHelper.FindType("ScrollRectPageSnap");
                if (snapType != null && parentGO != null)
                {
                    var getComp = parentGO.GetType().GetMethod(
                        "GetComponent", Pub, null, new[] { typeof(Type) }, null);
                    var snap = getComp?.Invoke(parentGO, new object[] { snapType });
                    if (snap != null)
                    {
                        object hpage = snapType.GetProperty("hpage",
                            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance)
                            ?.GetValue(snap) ?? 0;
                        return Loc.Get("topic_banner", hpage);
                    }
                }
            }
            catch { }
            return Loc.Get("event_banner"); // fallback
        }

        private static string? ProcessDuelMenu(object instance)
        {
            try
            {
                // Check if 6 ancestors up is "SettingMenuArea" (in-duel settings)
                var anc = GetTransform(instance);
                for (int i = 0; i < 6; i++) anc = GetParent(anc);
                if (GetName(anc) == "SettingMenuArea")
                    return ProcessSettingsMenu(instance);

                // Check if first child is named "Main" — duel/solo mode button
                var t          = GetTransform(instance);
                var childCount = (int)(t?.GetType().GetProperty("childCount", Pub)?.GetValue(t) ?? 0);
                if (childCount > 0 && GetName(ChildAt(t, 0)) == "Main")
                {
                    var texts = CollectAllTexts(GetGO(t));
                    string? last = texts.Count > 0 ? texts[texts.Count - 1].Item2 : null;
                    string? comp = FindByKey(texts, "Complete");
                    if (!string.IsNullOrEmpty(last))
                        return comp != null ? Loc.Get("duel_mode_complete", last, comp) : last;
                }
            }
            catch { }
            return null;
        }

        // ── Card Browser : filtres ────────────────────────────────────────────

        /// <summary>
        /// Annonce le bouton de filtre courant dans le navigateur de cartes.
        ///
        /// Détecte le contexte "filtre" en remontant jusqu'à 7 niveaux dans la hiérarchie
        /// à la recherche d'un parent dont le nom contient des mots-clés de filtre
        /// (Filter, Search, TagRoot, AttributeRoot, TypeRoot, etc.).
        ///
        /// Si un contexte filtre est détecté :
        ///   - Lit le label du bouton (TMP_Text → nom du GO)
        ///   - Tente de lire l'état actif via Toggle.isOn ou la présence d'un child "Checkmark"
        ///   - Retourne "{label} (actif)" ou "{label} (inactif)"
        ///
        /// Si le bouton n'est pas dans un filtre : retourne null (texte de base utilisé).
        /// </summary>
        private static string? ProcessCardBrowser(object instance)
        {
            var t = GetTransform(instance);

            // Detect filter context via ancestor name patterns
            bool inFilterContext = false;
            var walker = GetParent(t);
            for (int i = 0; i < 7 && walker != null; i++, walker = GetParent(walker))
            {
                string? pName = GetName(walker);
                if (pName != null && IsFilterContextName(pName))
                {
                    inFilterContext = true;
                    break;
                }
            }

            if (!inFilterContext) return null;

            // Read the filter label (text child preferred, GO name as fallback)
            string? label = ReadText(GetGO(t));
            if (string.IsNullOrWhiteSpace(label))
                label = GetName(instance);
            if (string.IsNullOrWhiteSpace(label)) return null;

            // Try to determine if filter is currently active
            bool? active = ReadFilterActiveState(GetGO(t));
            if (active.HasValue)
                return active.Value
                    ? Loc.Get("card_filter_active",   label)
                    : Loc.Get("card_filter_inactive",  label);

            return label;
        }

        /// <summary>
        /// Returns true if <paramref name="name"/> indicates a filter-area parent.
        /// Matches common YGO card browser filter container names.
        /// </summary>
        private static bool IsFilterContextName(string name) =>
            name.IndexOf("Filter",    System.StringComparison.OrdinalIgnoreCase) >= 0 ||
            name.IndexOf("Search",    System.StringComparison.OrdinalIgnoreCase) >= 0 ||
            name == "TagRoot"       || name == "AttributeRoot" ||
            name == "TypeRoot"      || name == "RaceRoot"      ||
            name == "LevelRoot"     || name == "SortArea"      ||
            name == "FilterPanel"   || name == "FilterRoot"    ||
            name == "ConditionRoot" || name == "KeywordRoot";

        /// <summary>
        /// Tries to read the active state of a filter button's GO.
        /// Strategy 1: UnityEngine.UI.Toggle.isOn (Unity toggle).
        /// Strategy 2: first active child named "Checkmark", "Check", "Selected", "SelectIcon",
        ///             "ActiveState", or "OnIcon".
        /// Returns null if state cannot be determined.
        /// </summary>
        private static bool? ReadFilterActiveState(object? go)
        {
            if (go == null) return null;
            try
            {
                // Strategy 1: Unity Toggle component
                var toggleType = AccessToolsHelper.FindType("UnityEngine.UI.Toggle");
                if (toggleType != null)
                {
                    var getComp = go.GetType().GetMethod(
                        "GetComponent", Pub, null, new[] { typeof(Type) }, null);
                    var toggle = getComp?.Invoke(go, new object[] { toggleType });
                    if (toggle != null)
                    {
                        var isOnProp = toggleType.GetProperty("isOn", Pub);
                        if (isOnProp?.GetValue(toggle) is bool b)
                            return b;
                    }
                }

                // Strategy 2: named child active state
                var xform = go.GetType().GetProperty("transform", Pub)?.GetValue(go);
                foreach (string childName in new[]
                    { "Checkmark", "Check", "Selected", "SelectIcon", "ActiveState", "OnIcon" })
                {
                    var childT = FindChild(xform, childName);
                    if (childT != null)
                        return IsActive(GetGO(childT));
                }
            }
            catch { }
            return null;
        }

        // ── Notification text reader ──────────────────────────────────────────

        private static string? ReadNotificationText(object instance)
        {
            var t = GetTransform(instance);
            string? mainText = ReadText(GetGO(FindChild(t, "TextBody")));

            var baseCatT = FindChild(t, "BaseCategory");
            if (baseCatT != null && IsActive(GetGO(baseCatT)))
            {
                string? status = ReadText(GetGO(ChildAt(baseCatT, 0)));
                if (!string.IsNullOrEmpty(status))
                    mainText = (mainText ?? "") + Loc.Get("notification_status", status);
            }
            return mainText;
        }

        // ── Unity hierarchy helpers (reflection) ──────────────────────────────

        private static object? GetTransform(object instance) =>
            instance.GetType().GetProperty("transform", Pub)?.GetValue(instance);

        private static object? GetParent(object? t) =>
            t?.GetType().GetProperty("parent", Pub)?.GetValue(t);

        private static object? GetGO(object? t) =>
            t?.GetType().GetProperty("gameObject", Pub)?.GetValue(t);

        private static string? GetName(object? obj) =>
            obj?.GetType().GetProperty("name", Pub)?.GetValue(obj)?.ToString();

        private static object? ChildAt(object? t, int idx)
        {
            if (t == null) return null;
            var m = t.GetType().GetMethod("GetChild", Pub, null, new[] { typeof(int) }, null);
            return m?.Invoke(t, new object[] { idx });
        }

        private static object? FindChild(object? xform, string name)
        {
            if (xform == null) return null;
            var m = xform.GetType().GetMethod(
                "Find", Pub, null, new[] { typeof(string) }, null);
            return m?.Invoke(xform, new object[] { name });
        }

        private static bool IsActive(object? go) =>
            go?.GetType().GetProperty("activeInHierarchy", Pub)?.GetValue(go) is true;

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
                    if (!string.IsNullOrWhiteSpace(text))
                        return Regex.Replace(text, "<[^>]+>", "").Trim();
                }
            }
            return null;
        }

        // ── CollectAllTexts — deep text harvest for complex menus ─────────────

        private static List<(string, string)> CollectAllTexts(object? go)
        {
            var results = new List<(string, string)>();
            CollectTextsImpl(go, results);
            return results;
        }

        private static void CollectTextsImpl(object? go, List<(string, string)> results)
        {
            if (go == null) return;
            string goName = GetName(go) ?? "";
            var t = go.GetType().GetProperty("transform", Pub)?.GetValue(go);
            if (t == null) return;
            string parentName = GetName(GetParent(t)) ?? "";

            foreach (var typeName in new[] { "RubyTextGX", "ExtendedTextMeshProUGUI" })
            {
                var compType = AccessToolsHelper.FindType(typeName);
                if (compType == null) continue;
                var getComp = go.GetType().GetMethod(
                    "GetComponent", Pub, null, new[] { typeof(Type) }, null);
                var comp = getComp?.Invoke(go, new object[] { compType });
                if (comp == null) continue;
                var text = compType.GetProperty("text", Pub)?.GetValue(comp)?.ToString();
                if (!string.IsNullOrWhiteSpace(text))
                {
                    results.Add(($"{parentName}/{goName}", text));
                    break;
                }
            }

            int childCount = (int)(t.GetType().GetProperty("childCount", Pub)?.GetValue(t) ?? 0);
            for (int i = 0; i < childCount; i++)
                CollectTextsImpl(GetGO(ChildAt(t, i)), results);
        }

        private static string? FindByKey(List<(string, string)> texts, string keyword)
        {
            foreach (var (key, value) in texts)
                if (key.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    return value;
            return null;
        }

        private static object? FindGameObjectByPath(string path)
        {
            var goType = AccessToolsHelper.FindType("UnityEngine.GameObject");
            if (goType == null) return null;
            var findM = goType.GetMethod("Find",
                BindingFlags.Public | BindingFlags.Static, null,
                new[] { typeof(string) }, null);
            return findM?.Invoke(null, new object[] { path });
        }

        private static string GetRarityLabel(object? go)
        {
            if (go == null) return "";
            try
            {
                var imageType = AccessToolsHelper.FindType("UnityEngine.UI.Image");
                if (imageType == null) return "";
                var getComp = go.GetType().GetMethod(
                    "GetComponent", Pub, null, new[] { typeof(Type) }, null);
                var image = getComp?.Invoke(go, new object[] { imageType });
                if (image == null) return "";
                var sprite = imageType.GetProperty("sprite", Pub)?.GetValue(image);
                if (sprite == null) return "";
                var spriteName = sprite.GetType().GetProperty("name", Pub)
                    ?.GetValue(sprite)?.ToString();
                return ParseRarity(spriteName);
            }
            catch { return ""; }
        }

        private static string ParseRarity(string? spriteName)
        {
            if (string.IsNullOrEmpty(spriteName)) return "";
            char last = spriteName![spriteName.Length - 1];
            if (!char.IsDigit(last)) return "";
            return (last - '0') switch
            {
                0 => Loc.Get("rarity_normal"),
                1 => Loc.Get("rarity_rare"),
                2 => Loc.Get("rarity_super"),
                3 => Loc.Get("rarity_ultra"),
                _ => last.ToString(),
            };
        }
    }
}
