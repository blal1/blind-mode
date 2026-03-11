using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Reads header info (gems, CP, notifications) from HeaderViewController.
    ///
    /// HeaderViewController is a persistent singleton bar at the top of menu screens.
    /// Contains: gem count, craft points, notification badges, friend requests.
    ///
    /// ## Usage:
    /// Called by KeyboardShortcuts when user presses H (outside duel).
    /// No Harmony patches needed — reads directly from the singleton instance.
    ///
    /// ## Data sources:
    /// - HeaderViewController.instance (static property) — the singleton
    /// - gemText (ExtendedTextMeshProUGUI) — displays gem count
    /// - gemButtonText (ExtendedTextMeshProUGUI) — alternative gem display
    /// - btnNotice, btnPresent, btnFriend — SelectionButton references
    /// </summary>
    internal static class HeaderPatch
    {
        /// <summary>
        /// Reads the gem count from HeaderViewController and announces it.
        /// Called from KeyboardShortcuts.
        /// </summary>
        internal static string? ReadHeaderInfo()
        {
            try
            {
                var headerType = AccessToolsHelper.FindType("YgomGame.Menu.HeaderViewController");
                if (headerType == null) return null;

                // Get singleton instance
                var instanceProp = headerType.GetProperty("instance",
                    BindingFlags.Public | BindingFlags.Static);
                var instance = instanceProp?.GetValue(null);
                if (instance == null) return null;

                var parts = new System.Collections.Generic.List<string>();

                // Read gem count from gemText or gemButtonText
                string? gems = ReadTextComponent(instance, "gemText")
                    ?? ReadTextComponent(instance, "gemButtonText");
                if (!string.IsNullOrWhiteSpace(gems))
                    parts.Add(Loc.Get("header_gems", gems!));

                // If no gem text, the header might not be visible
                if (parts.Count == 0)
                    return null;

                return string.Join(", ", parts);
            }
            catch { return null; }
        }

        /// <summary>
        /// Reads the text property from a TMP_Text / ExtendedTextMeshProUGUI field.
        /// </summary>
        private static string? ReadTextComponent(object instance, string fieldName)
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
    }
}
