using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour MissionViewController — écran des missions.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — écran ouvert
    ///    → "Missions. Onglet : [Mission/Mission de panel]."
    ///    → "Missions." si le type ne peut pas être lu.
    ///
    /// B) TabInitialEntry(bool) — onglet initial sélectionné
    ///    → annonce le type d'onglet actif à l'entrée de l'écran.
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   MissionViewController (namespace YgomGame.Mission)
    ///     ├─ m_ContentType (MissionContentType enum, privé 0x180)
    ///     │    Mission = 0, PanelMission = 1
    ///     └─ mainTabs (List&lt;Tab&gt; privé 0x1A8) — onglets principaux
    ///
    /// Note : la navigation individuelle (noms de missions, récompenses) est
    /// déjà couverte par SelectionButtonPatch.ProcessMissionsMenu.
    ///
    /// Appliqué via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class MissionViewControllerPatch
    {
        private static bool _applied = false;

        // Cache de réflexion
        private static FieldInfo? _fContentType;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Mission.MissionViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[MissionViewControllerPatch] MissionViewController introuvable.");
                return;
            }

            // Patch NotificationStackEntry
            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack != null)
            {
                harmony.Patch(mStack, postfix: new HarmonyMethod(
                    typeof(MissionViewControllerPatch), nameof(StackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[MissionViewControllerPatch] ✓ MissionViewController.NotificationStackEntry");
            }
            else
            {
                Plugin.Instance?.LogWarn("[MissionViewControllerPatch] NotificationStackEntry introuvable.");
            }

            // Patch TabInitialEntry(bool) — tab sélectionné à l'entrée
            var mTab = vcType.GetMethod("TabInitialEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mTab != null)
            {
                harmony.Patch(mTab, postfix: new HarmonyMethod(
                    typeof(MissionViewControllerPatch), nameof(TabInitialEntry_Postfix)));
                Plugin.Instance?.LogMsg("[MissionViewControllerPatch] ✓ MissionViewController.TabInitialEntry");
            }
            else
            {
                Plugin.Instance?.LogWarn("[MissionViewControllerPatch] TabInitialEntry introuvable.");
            }

            _applied = true;
        }

        internal static void Reset()
        {
            _applied      = false;
            _fContentType = null;
        }

        // ── Postfix : NotificationStackEntry ────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string tabLabel = GetTabLabel(__instance);
                string msg = string.IsNullOrWhiteSpace(tabLabel)
                    ? Loc.Get("screen_missions")
                    : Loc.Get("mission_screen_with_tab", tabLabel);
                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[MissionViewControllerPatch] StackEntry: {ex.Message}");
            }
        }

        // ── Postfix : TabInitialEntry ────────────────────────────────────────

        public static void TabInitialEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string tabLabel = GetTabLabel(__instance);
                if (!string.IsNullOrWhiteSpace(tabLabel))
                    tts.Speak(Loc.Get("mission_tab_selected", tabLabel), interrupt: false);
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static string GetTabLabel(object vc)
        {
            if (_fContentType == null)
                _fContentType = vc.GetType().GetField("m_ContentType",
                    BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

            int contentType = Convert.ToInt32(_fContentType?.GetValue(vc) ?? 0);

            // MissionContentType: Mission=0, PanelMission=1
            return contentType switch
            {
                0 => Loc.Get("mission_tab_mission"),
                1 => Loc.Get("mission_tab_panel"),
                _ => string.Empty,
            };
        }
    }
}
