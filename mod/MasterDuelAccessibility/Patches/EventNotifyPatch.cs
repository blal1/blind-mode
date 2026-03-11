using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour EventNotifyViewController — notifications d'événements en jeu.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) Open(string[] messages, Action callback) — notification ouverte
    ///    → Annonce chaque message de la notification d'événement.
    ///
    /// ## Structure (dump-confirmé) :
    ///
    ///   EventNotifyViewController (namespace global)
    ///     └─ static Open(string[] messages, Action callback)
    ///          └─ messages[] = textes localisés par le jeu
    ///
    /// Appliqué dans Plugin.ApplyPatches() (patch statique, pas de scène spécifique).
    /// </summary>
    internal static class EventNotifyPatch
    {
        private static bool _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("EventNotifyViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[EventNotifyPatch] EventNotifyViewController introuvable.");
                return;
            }

            // Trouver la méthode statique Open(string[], Action)
            MethodInfo? openMethod = null;
            foreach (var m in vcType.GetMethods(
                BindingFlags.Public | BindingFlags.Static))
            {
                if (m.Name == "Open" && m.GetParameters().Length == 2)
                {
                    openMethod = m;
                    break;
                }
            }

            if (openMethod == null)
            {
                Plugin.Instance?.LogWarn("[EventNotifyPatch] Open(string[], Action) introuvable.");
                return;
            }

            harmony.Patch(openMethod, postfix: new HarmonyMethod(
                typeof(EventNotifyPatch), nameof(Open_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[EventNotifyPatch] ✓ EventNotifyViewController.Open");
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        /// <summary>
        /// __0 = messages (string[]) — textes de la notification localisés par le jeu.
        /// </summary>
        public static void Open_Postfix(object __0)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (__0 is not System.Collections.IEnumerable enumerable) return;

                var parts = new System.Collections.Generic.List<string>();
                foreach (var item in enumerable)
                {
                    string? s = item?.ToString();
                    if (!string.IsNullOrWhiteSpace(s))
                        parts.Add(s!);
                }

                if (parts.Count == 0) return;

                string msg = string.Join(". ", parts);
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[EventNotifyPatch] {ex.Message}");
            }
        }
    }
}
