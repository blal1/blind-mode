using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch for SystemDialog — fatal errors, maintenance, and network issues.
    ///
    /// SystemDialog is a MonoBehaviour (singleton) that blocks the game when
    /// network errors, maintenance, or fatal issues occur. Without TTS, a blind
    /// user has no idea why the game is frozen.
    ///
    /// ## What is announced:
    ///
    /// A) OpenFatalErrorDialog(string message, ...)
    ///    → Announces the error message so the user knows what happened
    ///
    /// B) OpenMaintenanceDialog(Dictionary args)
    ///    → Reads title + upper/lower messages from the args dictionary
    ///    → Announces "Maintenance: [title]. [message]"
    ///
    /// ## Application
    /// Applied at startup (Plugin.ApplyPatches) since SystemDialog can appear at any time.
    /// </summary>
    internal static class SystemDialogPatch
    {
        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            var type = AccessToolsHelper.FindType("YgomSystem.UI.SystemDialog");
            if (type == null)
            {
                Plugin.Instance?.LogWarn("[SystemDialogPatch] SystemDialog introuvable.");
                return;
            }

            PatchFatalError(harmony, type);
            PatchMaintenance(harmony, type);
            PatchOpenCore(harmony, type);
        }

        private static void PatchFatalError(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OpenFatalErrorDialog",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[SystemDialogPatch] OpenFatalErrorDialog introuvable.");
                return;
            }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(SystemDialogPatch), nameof(FatalError_Postfix)));
            Plugin.Instance?.LogMsg("[SystemDialogPatch] ✓ SystemDialog.OpenFatalErrorDialog");
        }

        private static void PatchMaintenance(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OpenMaintenanceDialog",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                Plugin.Instance?.LogWarn("[SystemDialogPatch] OpenMaintenanceDialog introuvable.");
                return;
            }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(SystemDialogPatch), nameof(Maintenance_Postfix)));
            Plugin.Instance?.LogMsg("[SystemDialogPatch] ✓ SystemDialog.OpenMaintenanceDialog");
        }

        /// <summary>
        /// OpenSystemDialogCore — fallback for any system dialog that's not a fatal error
        /// or maintenance. Reads title and messages from the args dictionary.
        /// </summary>
        private static void PatchOpenCore(HarmonyLib.Harmony h, Type t)
        {
            var m = t.GetMethod("OpenSystemDialogCore",
                BindingFlags.NonPublic | BindingFlags.Instance);
            if (m == null)
            {
                // Not critical — OpenFatalError and OpenMaintenance cover the important cases
                Plugin.Instance?.LogMsg("[SystemDialogPatch] OpenSystemDialogCore non trouvé (optionnel).");
                return;
            }

            h.Patch(m, postfix: new HarmonyMethod(
                typeof(SystemDialogPatch), nameof(DialogCore_Postfix)));
            Plugin.Instance?.LogMsg("[SystemDialogPatch] ✓ SystemDialog.OpenSystemDialogCore");
        }

        // ── Postfix handlers ──────────────────────────────────────────────────

        /// <summary>
        /// OpenFatalErrorDialog(string message, string label1, Action action1, string label2, Action action2, Dictionary args)
        /// __0 = message (string)
        /// </summary>
        public static void FatalError_Postfix(string __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string msg = string.IsNullOrWhiteSpace(__0)
                    ? Loc.Get("system_error_generic")
                    : Loc.Get("system_error", __0);
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// OpenMaintenanceDialog(Dictionary&lt;string, object&gt; args)
        /// Reads k_ArgKeyTitle, k_ArgKeyUpperMessage, k_ArgKeyLowerMessage from args.
        /// </summary>
        public static void Maintenance_Postfix(object __instance, object __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? title = ReadDictString(__0, "title");
                string? upper = ReadDictString(__0, "upper_message");
                string? lower = ReadDictString(__0, "lower_message");

                string message = "";
                if (!string.IsNullOrWhiteSpace(title)) message = title!;
                if (!string.IsNullOrWhiteSpace(upper))
                    message += (message.Length > 0 ? ". " : "") + upper;
                if (!string.IsNullOrWhiteSpace(lower))
                    message += (message.Length > 0 ? ". " : "") + lower;

                if (string.IsNullOrWhiteSpace(message))
                    message = Loc.Get("system_maintenance_generic");

                tts.Speak(Loc.Get("system_maintenance", message), interrupt: false);
            }
            catch { }
        }

        /// <summary>
        /// OpenSystemDialogCore fallback — reads args dict for title/messages.
        /// __1 = Dictionary&lt;string, object&gt; args (optional, may be null)
        /// </summary>
        public static void DialogCore_Postfix(object __instance, object __0, object __1)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (__1 == null) return;

                string? title = ReadDictString(__1, "title");
                string? upper = ReadDictString(__1, "upper_message");

                string message = "";
                if (!string.IsNullOrWhiteSpace(title)) message = title!;
                if (!string.IsNullOrWhiteSpace(upper))
                    message += (message.Length > 0 ? ". " : "") + upper;

                if (!string.IsNullOrWhiteSpace(message))
                    tts.Speak(message, interrupt: false);
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        /// <summary>
        /// Reads a string value from a Dictionary&lt;string, object&gt; via reflection.
        /// The k_ArgKey constants use short names: "title", "upper_message", "lower_message".
        /// </summary>
        private static string? ReadDictString(object? dict, string key)
        {
            if (dict == null) return null;
            try
            {
                // Try direct indexer via reflection
                var dictType = dict.GetType();
                var itemProp = dictType.GetProperty("Item",
                    BindingFlags.Public | BindingFlags.Instance);
                if (itemProp == null) return null;

                var value = itemProp.GetValue(dict, new object[] { key });
                return value?.ToString();
            }
            catch { return null; }
        }
    }
}
