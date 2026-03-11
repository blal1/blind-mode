using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour le panneau de notifications : NotificationViewController.
    ///
    /// NotificationViewController affiche les annonces officielles de Konami
    /// (mises à jour, maintenances, bugs) dans un InfinityScrollView.
    ///
    /// ## Ce qui est announcé :
    ///
    /// A) NotificationStackEntry() — l'utilisateur ouvre le panneau notifications
    ///    → Annonce "Notifications" + nombre d'éléments non lus (si accessible)
    ///
    /// B) UpdateEntityCallback(GameObject go, int index)
    ///    → Appelé à chaque affichage d'un élément dans l'ISV (scroll)
    ///    → Capture le titre (head) et la catégorie (category) de chaque item
    ///
    /// C) UpdateNotification(Type type)
    ///    → Appelé quand l'onglet change (Notifications / Maintenance / Bugs)
    ///    → Annonce le nom de l'onglet et le nombre d'éléments
    ///
    /// ## Stratégie de lecture des données
    ///
    /// NotificationViewController.Data :
    ///   - head : string — titre de la notification
    ///   - body : string — corps (potentiellement long, on ne le lit pas)
    ///   - category : string — catégorie ("NOTICE", "MAINTENANCE", etc.)
    ///   - isAlreadyRead : bool
    ///
    /// On lit les listes notificationDatas / maintenanceDatas / bugDatas via réflexion.
    /// Pour l'ISV, on utilise l'index pour lire l'item correspondant dans la liste active.
    /// </summary>
    internal static class NotificationPatch
    {
        // Type interne Data (inner class de NotificationViewController)
        private static Type? _dataType;
        private static FieldInfo? _headField;
        private static FieldInfo? _categoryField;
        private static FieldInfo? _isReadField;

        // Onglet actif courant (0=Notification, 1=Maintenance, 2=Bug)
        private static int _currentTabType = 0;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.NotificationViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[NotificationPatch] NotificationViewController introuvable.");
                return;
            }

            // Trouve le type interne Data
            foreach (var nested in vcType.GetNestedTypes(BindingFlags.NonPublic | BindingFlags.Public))
            {
                if (nested.Name == "Data")
                {
                    _dataType = nested;
                    _headField     = nested.GetField("head",           BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    _categoryField = nested.GetField("category",       BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    _isReadField   = nested.GetField("isAlreadyRead",  BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                    break;
                }
            }

            PatchStackEntry(harmony, vcType);
            PatchUpdateNotification(harmony, vcType);
            PatchUpdateEntity(harmony, vcType);
        }

        private static void PatchStackEntry(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[NotificationPatch] NotificationStackEntry introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(NotificationPatch), nameof(StackEntry_Postfix)));
            Plugin.Instance?.LogMsg("[NotificationPatch] ✓ NotificationViewController.NotificationStackEntry");
        }

        private static void PatchUpdateNotification(HarmonyLib.Harmony h, Type t)
        {
            // UpdateNotification(Type type) — Type est un enum interne
            var m = t.GetMethod("UpdateNotification",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[NotificationPatch] UpdateNotification introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(NotificationPatch), nameof(UpdateNotification_Postfix)));
            Plugin.Instance?.LogMsg("[NotificationPatch] ✓ NotificationViewController.UpdateNotification");
        }

        private static void PatchUpdateEntity(HarmonyLib.Harmony h, Type t)
        {
            // UpdateEntityCallback(GameObject go, int index)
            var m = t.GetMethod("UpdateEntityCallback",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null) { Plugin.Instance?.LogWarn("[NotificationPatch] UpdateEntityCallback introuvable."); return; }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(NotificationPatch), nameof(UpdateEntity_Postfix)));
            Plugin.Instance?.LogMsg("[NotificationPatch] ✓ NotificationViewController.UpdateEntityCallback");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        private static void StackEntry_Postfix(object __instance)
        {
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

        /// <summary>
        /// UpdateNotification(Type type) postfix.
        /// __0 = type (int enum : 0=Notification, 1=Maintenance, 2=Bug)
        /// </summary>
        private static void UpdateNotification_Postfix(object __instance, int __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                _currentTabType = __0;
                string tabLabel = __0 switch {
                    0 => Loc.Get("notif_tab_news"),
                    1 => Loc.Get("notif_tab_maintenance"),
                    2 => Loc.Get("notif_tab_bugs"),
                    _ => Loc.Get("notif_tab_news"),
                };

                int count = CountTabItems(__instance, __0);
                tts.Speak(Loc.Get("notif_tab_changed", tabLabel, count), interrupt: false, addToHistory: false);
            }
            catch { }
        }

        /// <summary>
        /// UpdateEntityCallback(GameObject go, int index) postfix.
        /// __1 = index dans la liste ISV.
        /// Annonce le titre de la notification quand on navigue dans l'ISV.
        /// </summary>
        private static void UpdateEntity_Postfix(object __instance, int __1)
        {
            // Cet hook est appelé pour chaque item visible dans l'ISV (pas seulement celui focalisé).
            // On n'annonce rien ici — la navigation sera couverte par SelectionButtonPatch.
            // On stocke le mapping index → titre pour que SelectionButtonPatch puisse l'utiliser.
            // (Implémentation future si nécessaire)
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static int CountUnread(object instance)
        {
            int total = 0;
            foreach (var listName in new[] { "notificationDatas", "maintenanceDatas", "bugDatas" })
            {
                var list = ReadList(instance, listName);
                if (list == null) continue;
                foreach (var item in list)
                {
                    bool isRead = (bool?)_isReadField?.GetValue(item) ?? true;
                    if (!isRead) total++;
                }
            }
            return total;
        }

        private static int CountTabItems(object instance, int tabType)
        {
            string listName = tabType switch {
                0 => "notificationDatas",
                1 => "maintenanceDatas",
                2 => "bugDatas",
                _ => "notificationDatas",
            };
            var list = ReadList(instance, listName);
            if (list == null) return 0;
            int count = 0;
            foreach (var _ in list) count++;
            return count;
        }

        private static IEnumerable? ReadList(object instance, string fieldName)
        {
            var field = instance.GetType().GetField(fieldName,
                BindingFlags.NonPublic | BindingFlags.Instance);
            return field?.GetValue(instance) as IEnumerable;
        }
    }
}
