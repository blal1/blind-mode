using HarmonyLib;

using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patches for miscellaneous home-screen view controllers (sections 2.4 and 2.5).
    ///
    /// ## Screens covered
    ///
    /// 2.4 — Events and banners:
    ///
    /// A) HomeAnnounceViewController (global namespace)
    ///    → "Annonce en cours." — banner/announcement overlay at top of Home.
    ///    No readable TMP_Text fields (only k_IsPop bool + OpenAnnounce coroutine).
    ///    Generic announcement; content visible via SelectionButtonPatch navigation.
    ///
    /// B) HomeActionViewController (global namespace)
    ///    → "Actions disponibles : N." when actionList count is readable,
    ///       else "Actions disponibles." — contextual event action buttons on Home.
    ///    Fields (dump-confirmed): actionList (List<HomeAction> 0xD0),
    ///    currentActionIndex (int 0xE0). Patched on OnCreatedView().
    ///
    /// 2.5 — Sub-menus:
    ///
    /// C) HomeSubMenuViewController (global namespace, extends SubMenuViewController)
    ///    → "Sous-menu. Utilisez les flèches pour naviguer."
    ///    No extra fields beyond SubMenuViewController base.
    ///    Navigation items announced by SelectionButtonPatch.
    ///
    /// D) PreHomeViewController (global namespace)
    ///    → "Chargement de l'accueil." with 3 s cooldown (same as
    ///       TitleScreenPatch.LoadingViewController pattern).
    ///    Fields: step (PreHomeViewController.Step enum), m_soundLoadFinish,
    ///    m_shouldDownload — loading/transition screen before the Home scene.
    ///
    /// ## Application
    /// Applied via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class HomeMiscPatch
    {
        private static bool _applied = false;

        // Cooldown for PreHomeViewController (same pattern as TitleScreenPatch)
        private static DateTime _lastPreHomeAnnounce = DateTime.MinValue;
        private const double PreHomeCooldownMs = 3000;

        // Reflection cache for HomeActionViewController.actionList
        private static FieldInfo? _fActionList;

        // ── Apply / Reset ─────────────────────────────────────────────────────

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            PatchHomeAnnounce(harmony);
            PatchHomeAction(harmony);
            PatchHomeSubMenu(harmony);
            PatchPreHome(harmony);

            _applied = true;
        }

        internal static void Reset()
        {
            _applied             = false;
            _lastPreHomeAnnounce = DateTime.MinValue;
            _fActionList         = null;
        }

        // ── 2.4 A) HomeAnnounceViewController ────────────────────────────────

        private static void PatchHomeAnnounce(HarmonyLib.Harmony harmony)
        {
            try
            {
                var t = AccessToolsHelper.FindType("HomeAnnounceViewController");
                if (t == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] HomeAnnounceViewController introuvable.");
                    return;
                }

                var m = t.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] HomeAnnounceViewController.NotificationStackEntry introuvable.");
                    return;
                }

                harmony.Patch(m, postfix: new HarmonyMethod(
                    typeof(HomeMiscPatch), nameof(HomeAnnounce_Postfix)));
                Plugin.Instance?.LogMsg("[HomeMiscPatch] ✓ HomeAnnounceViewController.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[HomeMiscPatch] HomeAnnounceViewController: {ex.Message}");
            }
        }

        private static void HomeAnnounce_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("home_announce"), interrupt: false); }
            catch { }
        }

        // ── 2.4 B) HomeActionViewController ──────────────────────────────────

        private static void PatchHomeAction(HarmonyLib.Harmony harmony)
        {
            try
            {
                var t = AccessToolsHelper.FindType("HomeActionViewController");
                if (t == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] HomeActionViewController introuvable.");
                    return;
                }

                var m = t.GetMethod("OnCreatedView",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] HomeActionViewController.OnCreatedView introuvable.");
                    return;
                }

                harmony.Patch(m, postfix: new HarmonyMethod(
                    typeof(HomeMiscPatch), nameof(HomeAction_Postfix)));
                Plugin.Instance?.LogMsg("[HomeMiscPatch] ✓ HomeActionViewController.OnCreatedView");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[HomeMiscPatch] HomeActionViewController: {ex.Message}");
            }
        }

        private static void HomeAction_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int count = CountActionList(__instance);
                string msg = count > 0
                    ? Loc.Get("home_action_n", count)
                    : Loc.Get("home_action");
                tts.Speak(msg, interrupt: false);
            }
            catch { }
        }

        private static int CountActionList(object instance)
        {
            try
            {
                if (_fActionList == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField("actionList",
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { _fActionList = f; break; }
                        t = t.BaseType;
                    }
                }

                if (_fActionList == null) return 0;

                var list = _fActionList.GetValue(instance) as IEnumerable;
                if (list == null) return 0;

                int count = 0;
                foreach (var _ in list) count++;
                return count;
            }
            catch { return 0; }
        }

        // ── 2.5 C) HomeSubMenuViewController ─────────────────────────────────

        private static void PatchHomeSubMenu(HarmonyLib.Harmony harmony)
        {
            try
            {
                var t = AccessToolsHelper.FindType("HomeSubMenuViewController");
                if (t == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] HomeSubMenuViewController introuvable.");
                    return;
                }

                var m = t.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] HomeSubMenuViewController.NotificationStackEntry introuvable.");
                    return;
                }

                harmony.Patch(m, postfix: new HarmonyMethod(
                    typeof(HomeMiscPatch), nameof(HomeSubMenu_Postfix)));
                Plugin.Instance?.LogMsg("[HomeMiscPatch] ✓ HomeSubMenuViewController.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[HomeMiscPatch] HomeSubMenuViewController: {ex.Message}");
            }
        }

        private static void HomeSubMenu_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try { tts.Speak(Loc.Get("home_submenu"), interrupt: false); }
            catch { }
        }

        // ── 2.5 D) PreHomeViewController ─────────────────────────────────────

        private static void PatchPreHome(HarmonyLib.Harmony harmony)
        {
            try
            {
                var t = AccessToolsHelper.FindType("PreHomeViewController");
                if (t == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] PreHomeViewController introuvable.");
                    return;
                }

                var m = t.GetMethod("NotificationStackEntry",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
                if (m == null)
                {
                    Plugin.Instance?.LogWarn("[HomeMiscPatch] PreHomeViewController.NotificationStackEntry introuvable.");
                    return;
                }

                harmony.Patch(m, postfix: new HarmonyMethod(
                    typeof(HomeMiscPatch), nameof(PreHome_Postfix)));
                Plugin.Instance?.LogMsg("[HomeMiscPatch] ✓ PreHomeViewController.NotificationStackEntry");
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogErr($"[HomeMiscPatch] PreHomeViewController: {ex.Message}");
            }
        }

        private static void PreHome_Postfix()
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                var now = DateTime.UtcNow;
                if ((now - _lastPreHomeAnnounce).TotalMilliseconds < PreHomeCooldownMs) return;
                _lastPreHomeAnnounce = now;
                tts.Speak(Loc.Get("home_loading"), interrupt: false);
            }
            catch { }
        }
    }
}
