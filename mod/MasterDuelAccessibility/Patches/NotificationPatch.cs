using HarmonyLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour le panneau de notifications : NotificationViewController.
    ///
    /// NotificationViewController (YgomGame.Menu) affiche les annonces officielles
    /// de Konami (mises à jour, maintenances, bugs) dans un InfinityScrollView.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — ouverture du panneau
    ///    → "Notifications — N non lue(s)." ou "Notifications."
    ///
    /// B) UpdateNotification(Type type) — changement d'onglet
    ///    → "[Onglet] — N élément(s)."
    ///
    /// C) UpdateEntityCallback(GameObject go, int index)
    ///    → Appelé lors du rendu de chaque item dans l'ISV.
    ///    → Stocke le mapping index → (titre, catégorie, date, lu) dans _itemData.
    ///
    /// D) b__39_3(int index, int preIndex) — focus ISV (navigation clavier)
    ///    → Annonce le titre de la notification focalisée : "[Titre]. [Catégorie]. [Date]."
    ///    → Ajoute "(non lue)" si isAlreadyRead=false.
    ///
    /// ## Structure de NotificationViewController.Data (dump confirmé) :
    ///   type (NotificationViewController.Type 0x10)
    ///   id (int 0x14)
    ///   category (string 0x18)
    ///   date (string 0x30)
    ///   head (string 0x38)
    ///   body (string 0x40)
    ///   sort (int 0x48)
    ///   isAlreadyRead (bool 0x58)
    ///
    /// ## Exposition publique :
    /// CountUnread() — utilisé par HeaderPatch pour le badge H.
    /// GetItemTitle(index) — utilisé par SelectionButtonPatch.ReadNotificationText si besoin.
    /// </summary>
    internal static class NotificationPatch
    {
        // ── Type / reflection cache ───────────────────────────────────────────

        private static Type? _dataType;
        private static FieldInfo? _headField;
        private static FieldInfo? _categoryField;
        private static FieldInfo? _dateField;
        private static FieldInfo? _isReadField;

        // ── Runtime state ─────────────────────────────────────────────────────

        // Current active VC instance (set on StackEntry, cleared on Remove)
        private static object? _activeInstance;

        // Index → notification data snapshot (rebuilt on each UpdateEntityCallback call)
        private static readonly Dictionary<int, NotifItem> _itemData =
            new Dictionary<int, NotifItem>();

        // Current tab type (0=News, 1=Maintenance, 2=Bugs)
        private static int _currentTabType = 0;

        // 200ms dedup to avoid double-announce when ISV scrolls multiple items at once
        private static DateTime _lastFocusAnnounce = DateTime.MinValue;
        private static int _lastAnnouncedIndex = -1;

        // ── Apply ─────────────────────────────────────────────────────────────

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.NotificationViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[NotificationPatch] NotificationViewController introuvable.");
                return;
            }

            // Find and cache the nested Data type
            CacheDataType(vcType);

            PatchStackEntry(harmony, vcType);
            PatchUpdateNotification(harmony, vcType);
            PatchUpdateEntity(harmony, vcType);
            PatchIsvFocusCallback(harmony, vcType);
        }

        // ── Type caching ──────────────────────────────────────────────────────

        private static void CacheDataType(Type vcType)
        {
            foreach (var nested in vcType.GetNestedTypes(
                BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (nested.Name != "Data") continue;

                _dataType = nested;
                _headField     = nested.GetField("head",          BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                _categoryField = nested.GetField("category",      BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                _dateField     = nested.GetField("date",          BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                _isReadField   = nested.GetField("isAlreadyRead", BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                break;
            }
        }

        // ── Patch registrations ───────────────────────────────────────────────

        private static void PatchStackEntry(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[NotificationPatch] NotificationStackEntry introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(NotificationPatch), nameof(StackEntry_Postfix)));
            Plugin.Instance?.LogMsg("[NotificationPatch] ✓ NotificationStackEntry");
        }

        private static void PatchUpdateNotification(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("UpdateNotification",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[NotificationPatch] UpdateNotification introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(NotificationPatch), nameof(UpdateNotification_Postfix)));
            Plugin.Instance?.LogMsg("[NotificationPatch] ✓ UpdateNotification");
        }

        private static void PatchUpdateEntity(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("UpdateEntityCallback",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[NotificationPatch] UpdateEntityCallback introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(NotificationPatch), nameof(UpdateEntity_Postfix)));
            Plugin.Instance?.LogMsg("[NotificationPatch] ✓ UpdateEntityCallback");
        }

        /// <summary>
        /// Patches the ISV focus callback b__39_3(int index, int preIndex).
        /// This compiler-generated method fires when the user moves focus in the
        /// InfinityScrollView (keyboard navigation).
        ///
        /// Strategy: find a method on NotificationViewController with 2 int parameters
        /// whose name contains "b__" (compiler-generated anonymous method pattern).
        /// Applied via the DisplayClass that holds the lambda context.
        /// </summary>
        private static void PatchIsvFocusCallback(HarmonyLib.Harmony h, Type vcType)
        {
            // The callback is a compiler-generated method directly on vcType,
            // named something like <yInitialize>b__39_3 with signature (int, int) → void.
            foreach (var m in vcType.GetMethods(
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                if (!m.Name.Contains("b__")) continue;
                var prms = m.GetParameters();
                if (prms.Length == 2
                    && prms[0].ParameterType == typeof(int)
                    && prms[1].ParameterType == typeof(int)
                    && m.ReturnType == typeof(void))
                {
                    h.Patch(m, postfix: new HarmonyMethod(
                        typeof(NotificationPatch), nameof(IsvFocus_Postfix)));
                    Plugin.Instance?.LogMsg($"[NotificationPatch] ✓ ISV focus callback: {m.Name}");
                    return;
                }
            }
            Plugin.Instance?.LogWarn("[NotificationPatch] ISV focus callback introuvable — navigation non patchée.");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        private static void StackEntry_Postfix(object __instance)
        {
            _activeInstance = __instance;
            _itemData.Clear();
            _lastAnnouncedIndex = -1;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int unreadCount = CountUnread(__instance);
                string msg = unreadCount > 0
                    ? Loc.Get("notifications_open_unread", unreadCount)
                    : Loc.Get("notifications_open");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        private static void UpdateNotification_Postfix(object __instance, int __0)
        {
            _currentTabType = __0;
            _itemData.Clear();
            _lastAnnouncedIndex = -1;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string tabLabel = __0 switch {
                    0 => Loc.Get("notif_tab_news"),
                    1 => Loc.Get("notif_tab_maintenance"),
                    2 => Loc.Get("notif_tab_bugs"),
                    _ => Loc.Get("notif_tab_news"),
                };
                int count = CountTabItems(__instance, __0);
                tts.Speak(Loc.Get("notif_tab_changed", tabLabel, count),
                    interrupt: false, addToHistory: false);
            }
            catch { }
        }

        /// <summary>
        /// UpdateEntityCallback(GameObject go, int index) postfix.
        /// __1 = index of the item being rendered in the ISV.
        /// Captures head/category/date/isRead into _itemData for later announcement.
        /// </summary>
        private static void UpdateEntity_Postfix(object __instance, int __1)
        {
            if (_dataType == null) return;
            try
            {
                // Get the list for the current tab
                var list = GetCurrentTabList(__instance);
                if (list == null) return;

                // Walk to index __1
                int i = 0;
                foreach (var item in list)
                {
                    if (i == __1)
                    {
                        var head     = _headField?.GetValue(item)?.ToString() ?? "";
                        var category = _categoryField?.GetValue(item)?.ToString() ?? "";
                        var date     = _dateField?.GetValue(item)?.ToString() ?? "";
                        bool isRead  = (bool?)_isReadField?.GetValue(item) ?? true;

                        _itemData[__1] = new NotifItem(head, category, date, isRead);
                        return;
                    }
                    i++;
                }
            }
            catch { }
        }

        /// <summary>
        /// ISV focus callback postfix: fires when user moves keyboard focus in the list.
        /// __0 = newly focused index, __1 = previous index.
        /// </summary>
        private static void IsvFocus_Postfix(object __instance, int __0, int __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            if (__0 == _lastAnnouncedIndex) return;

            // 200ms dedup
            var now = DateTime.UtcNow;
            if ((now - _lastFocusAnnounce).TotalMilliseconds < 200) return;
            _lastFocusAnnounce = now;
            _lastAnnouncedIndex = __0;

            try
            {
                string msg = BuildItemAnnouncement(__0);
                if (!string.IsNullOrEmpty(msg))
                    tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        // ── Public helpers ────────────────────────────────────────────────────

        /// <summary>
        /// Counts all unread notifications across all three tabs.
        /// Called by HeaderPatch when user presses H.
        /// </summary>
        internal static int CountUnread(object? instance = null)
        {
            var inst = instance ?? _activeInstance;
            if (inst == null) return 0;
            int total = 0;
            foreach (var listName in new[] { "notificationDatas", "maintenanceDatas", "bugDatas" })
            {
                var list = ReadListField(inst, listName);
                if (list == null) continue;
                foreach (var item in list)
                {
                    bool isRead = (bool?)_isReadField?.GetValue(item) ?? true;
                    if (!isRead) total++;
                }
            }
            return total;
        }

        /// <summary>
        /// Returns the formatted announcement for the item at index in _itemData.
        /// Returns null if not cached yet.
        /// </summary>
        internal static string? GetItemTitle(int index)
        {
            return _itemData.TryGetValue(index, out var item) ? item.Head : null;
        }

        // ── Private helpers ───────────────────────────────────────────────────

        private static string BuildItemAnnouncement(int index)
        {
            if (!_itemData.TryGetValue(index, out var item))
                return string.Empty;

            var parts = new List<string>();

            if (!string.IsNullOrWhiteSpace(item.Head))
                parts.Add(item.Head.Trim());

            if (!string.IsNullOrWhiteSpace(item.Category))
                parts.Add(item.Category.Trim());

            if (!string.IsNullOrWhiteSpace(item.Date))
                parts.Add(item.Date.Trim());

            if (!item.IsRead)
                parts.Add(Loc.Get("notif_unread_marker"));

            return parts.Count > 0 ? string.Join(". ", parts) + "." : string.Empty;
        }

        private static int CountTabItems(object instance, int tabType)
        {
            string listName = tabType switch {
                0 => "notificationDatas",
                1 => "maintenanceDatas",
                2 => "bugDatas",
                _ => "notificationDatas",
            };
            var list = ReadListField(instance, listName);
            if (list == null) return 0;
            int count = 0;
            foreach (var _ in list) count++;
            return count;
        }

        private static IEnumerable? GetCurrentTabList(object instance)
        {
            string listName = _currentTabType switch {
                0 => "notificationDatas",
                1 => "maintenanceDatas",
                2 => "bugDatas",
                _ => "notificationDatas",
            };
            return ReadListField(instance, listName);
        }

        private static IEnumerable? ReadListField(object instance, string fieldName)
        {
            var field = instance.GetType().GetField(fieldName,
                BindingFlags.NonPublic | BindingFlags.Instance);
            return field?.GetValue(instance) as IEnumerable;
        }

        // ── Inner types ───────────────────────────────────────────────────────

        private readonly struct NotifItem
        {
            internal readonly string Head;
            internal readonly string Category;
            internal readonly string Date;
            internal readonly bool IsRead;

            internal NotifItem(string head, string category, string date, bool isRead)
            {
                Head = head;
                Category = category;
                Date = date;
                IsRead = isRead;
            }
        }
    }
}
