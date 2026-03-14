using System;
using System.Reflection;
using UnityEngine;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Reads header info (gems, unread notifications) from HeaderViewController.
    ///
    /// HeaderViewController is a persistent singleton bar at the top of menu screens.
    /// Contains: gem count, notification badge, friend requests, present box badge.
    ///
    /// ## Usage:
    /// Called by KeyboardShortcuts when user presses H (outside duel).
    /// No Harmony patches needed — reads directly from the singleton instance.
    ///
    /// ## Data sources:
    /// - HeaderViewController.instance (static property) — the singleton
    /// - gemText (ExtendedTextMeshProUGUI 0x108) — displays gem count
    /// - gemButtonText (ExtendedTextMeshProUGUI 0x100) — alternative gem display
    /// - btnNotice (SelectionButton 0x150) — notification button; badge child GO contains unread count
    /// - btnPresent (SelectionButton 0x148) — present box button
    /// - btnFriend (SelectionButton 0x140) — friend request button
    ///
    /// ## Gem display logic:
    /// gemText is the primary source. gemButtonText is shown on some screens.
    /// Both are ExtendedTextMeshProUGUI — read via .text property.
    ///
    /// ## Notification badge:
    /// btnNotice has a child GameObject acting as the badge indicator.
    /// The badge contains a TMP_Text with the unread count when active.
    /// If the badge GO is inactive, there are no unread notifications.
    ///
    /// ## CP (craft points):
    /// NOT available in the header bar. CP is only shown in specific screens
    /// (CardBrowserViewController.CardDetailWidget.cpText). Cannot be read from header.
    /// </summary>
    internal static class HeaderPatch
    {
        // ── Cache ─────────────────────────────────────────────────────────────

        private static Type? _headerType;
        private static PropertyInfo? _instanceProp;

        // ── Public API ────────────────────────────────────────────────────────

        /// <summary>
        /// Reads gem count + unread notification badge from HeaderViewController.
        /// Returns a formatted string or null if the header is not visible.
        /// Called from KeyboardShortcuts (H key, outside duel).
        /// </summary>
        internal static string? ReadHeaderInfo()
        {
            try
            {
                var instance = GetHeaderInstance();
                if (instance == null) return null;

                var parts = new System.Collections.Generic.List<string>();

                // Read gem count from gemText or gemButtonText
                string? gems = ReadTextField(instance, "gemText")
                    ?? ReadTextField(instance, "gemButtonText");
                if (!string.IsNullOrWhiteSpace(gems))
                    parts.Add(Loc.Get("header_gems", gems!.Trim()));

                // Read unread notification count from btnNotice badge
                int unread = ReadBadgeCount(instance, "btnNotice");
                if (unread > 0)
                    parts.Add(Loc.Get("header_unread_notif", unread));

                // Read present box badge
                int presents = ReadBadgeCount(instance, "btnPresent");
                if (presents > 0)
                    parts.Add(Loc.Get("header_presents", presents));

                if (parts.Count == 0)
                    return null;

                return string.Join(". ", parts) + ".";
            }
            catch { return null; }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static object? GetHeaderInstance()
        {
            if (_headerType == null)
            {
                _headerType = AccessToolsHelper.FindType("YgomGame.Menu.HeaderViewController");
                if (_headerType == null) return null;
                _instanceProp = _headerType.GetProperty("instance",
                    BindingFlags.Public | BindingFlags.Static);
            }
            return _instanceProp?.GetValue(null);
        }

        /// <summary>
        /// Reads the .text value of a TMP component stored in a field on the header instance.
        /// </summary>
        private static string? ReadTextField(object instance, string fieldName)
        {
            try
            {
                var field = instance.GetType().GetField(fieldName,
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var component = field?.GetValue(instance);
                if (component == null) return null;

                var textProp = component.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                var text = textProp?.GetValue(component)?.ToString();
                return string.IsNullOrWhiteSpace(text) ? null : text;
            }
            catch { return null; }
        }

        /// <summary>
        /// Reads the badge count from a SelectionButton field's child GameObject hierarchy.
        ///
        /// Pattern: btnXxx → children → find first active TMP_Text child with numeric content.
        /// If badge GO is inactive → count = 0 (no badge shown).
        /// </summary>
        private static int ReadBadgeCount(object headerInstance, string btnFieldName)
        {
            try
            {
                // Get the SelectionButton field
                var field = headerInstance.GetType().GetField(btnFieldName,
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
                var btn = field?.GetValue(headerInstance);
                if (btn == null) return 0;

                // Get the GameObject from the button via the gameObject property
                var goProp = btn.GetType().GetProperty("gameObject",
                    BindingFlags.Public | BindingFlags.Instance);
                var go = goProp?.GetValue(btn) as GameObject;
                if (go == null) return 0;

                // Walk children looking for an active TMP_Text with a numeric value
                return FindBadgeInChildren(go.transform);
            }
            catch { return 0; }
        }

        /// <summary>
        /// Recursively walks a Transform tree looking for an active TMP_Text
        /// that contains a positive integer (badge count).
        /// Returns 0 if not found or badge is inactive.
        /// </summary>
        private static int FindBadgeInChildren(Transform parent)
        {
            var tmpType = AccessToolsHelper.FindType("TMPro.TMP_Text");
            if (tmpType == null) return 0;

            return SearchChildren(parent, tmpType);
        }

        private static int SearchChildren(Transform t, Type tmpType)
        {
            var textProp = tmpType.GetProperty("text", BindingFlags.Public | BindingFlags.Instance);

            for (int i = 0; i < t.childCount; i++)
            {
                var child = t.GetChild(i);
                if (!child.gameObject.activeInHierarchy)
                    continue;

                // Check for TMP_Text on this child using IL2CPP-compatible reflection
                var comps = child.GetComponents<UnityEngine.Component>();
                foreach (var comp in comps)
                {
                    if (comp == null) continue;
                    if (!tmpType.IsAssignableFrom(comp.GetType())) continue;

                    var text = textProp?.GetValue(comp)?.ToString()?.Trim();
                    if (!string.IsNullOrEmpty(text) && int.TryParse(text, out int n) && n > 0)
                        return n;
                }

                // Recurse
                int found = SearchChildren(child, tmpType);
                if (found > 0) return found;
            }
            return 0;
        }
    }
}
