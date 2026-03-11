using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour ScenarioViewController — lecture de scénario Solo (texte narratif).
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — scénario ouvert
    ///    → "Scénario : [nom]." ou "Scénario Solo." si nom indisponible
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   ScenarioViewController (namespace YgomGame.Scenario)
    ///     m_ScenarioName (string 0xD8) — nom du scénario
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class ScenarioPatch
    {
        private static bool _applied = false;
        private static FieldInfo? _fScenarioName;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Scenario.ScenarioViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[ScenarioPatch] ScenarioViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[ScenarioPatch] NotificationStackEntry introuvable.");
                return;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(ScenarioPatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[ScenarioPatch] ✓ ScenarioViewController.NotificationStackEntry");
        }

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                if (_fScenarioName == null)
                {
                    var t = __instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField("m_ScenarioName",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fScenarioName = f; break; }
                        t = t.BaseType;
                    }
                }

                string? name = _fScenarioName?.GetValue(__instance)?.ToString();

                string msg = !string.IsNullOrWhiteSpace(name)
                    ? Loc.Get("scenario_open_name", name!)
                    : Loc.Get("scenario_open");

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ScenarioPatch] {ex.Message}");
            }
        }
    }
}
