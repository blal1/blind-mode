using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour DownloadViewController — téléchargement initial de données.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — écran de téléchargement affiché
    ///    → "Téléchargement. [texte état]." si disponible
    ///    → "Téléchargement en cours." sinon
    ///
    /// B) OnCreatedView() — vue créée (alternative si NotificationStackEntry est trop tôt)
    ///    → même annonce
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   DownloadViewController (namespace YgomGame.Menu)
    ///     DownloadingText      (TextMeshProUGUI 0x1F0) — texte principal (ex. "Téléchargement")
    ///     DownloadingStateText (TextMeshProUGUI 0x1F8) — état courant  (ex. "XX MB / YY MB")
    ///     isDownloading        (bool 0x248)            — true si téléchargement en cours
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class DownloadViewControllerPatch
    {
        private static bool _applied = false;

        private static FieldInfo? _fDownloadingText;
        private static FieldInfo? _fDownloadingStateText;
        private static FieldInfo? _fIsDownloading;

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.Menu.DownloadViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[DownloadViewControllerPatch] DownloadViewController introuvable.");
                return;
            }

            bool patched = false;

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack != null)
            {
                harmony.Patch(mStack, postfix: new HarmonyMethod(
                    typeof(DownloadViewControllerPatch), nameof(StackEntry_Postfix)));
                Plugin.Instance?.LogMsg("[DownloadViewControllerPatch] ✓ DownloadViewController.NotificationStackEntry");
                patched = true;
            }

            var mCreated = vcType.GetMethod("OnCreatedView",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mCreated != null)
            {
                harmony.Patch(mCreated, postfix: new HarmonyMethod(
                    typeof(DownloadViewControllerPatch), nameof(OnCreatedView_Postfix)));
                Plugin.Instance?.LogMsg("[DownloadViewControllerPatch] ✓ DownloadViewController.OnCreatedView");
                patched = true;
            }

            if (!patched)
            {
                Plugin.Instance?.LogWarn("[DownloadViewControllerPatch] Aucune méthode trouvée.");
                return;
            }

            _applied = true;
        }

        // ── Postfixes ─────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
            => Announce(__instance, interrupt: false);

        public static void OnCreatedView_Postfix(object __instance)
            => Announce(__instance, interrupt: false);

        // ── Shared ───────────────────────────────────────────────────────────

        private static void Announce(object instance, bool interrupt)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string? mainText  = TryReadTmpText(instance, ref _fDownloadingText,      "DownloadingText");
                string? stateText = TryReadTmpText(instance, ref _fDownloadingStateText,  "DownloadingStateText");
                bool   isLoading  = TryReadBool   (instance, ref _fIsDownloading,          "isDownloading");

                // Construire l'annonce
                if (!string.IsNullOrWhiteSpace(mainText) && !string.IsNullOrWhiteSpace(stateText))
                {
                    tts.Speak(Loc.Get("download_open_state", mainText!, stateText!), interrupt: interrupt);
                }
                else if (!string.IsNullOrWhiteSpace(mainText))
                {
                    tts.Speak(Loc.Get("download_open_text", mainText!), interrupt: interrupt);
                }
                else if (isLoading)
                {
                    tts.Speak(Loc.Get("download_in_progress"), interrupt: interrupt);
                }
                else
                {
                    tts.Speak(Loc.Get("download_open"), interrupt: interrupt);
                }
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[DownloadViewControllerPatch] {ex.Message}");
            }
        }

        private static string? TryReadTmpText(object instance, ref FieldInfo? cache, string fieldName)
        {
            try
            {
                if (cache == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField(fieldName,
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { cache = f; break; }
                        t = t.BaseType;
                    }
                }
                if (cache == null) return null;

                object? comp = cache.GetValue(instance);
                if (comp == null) return null;

                var textProp = comp.GetType().GetProperty("text",
                    BindingFlags.Public | BindingFlags.Instance);
                return textProp?.GetValue(comp)?.ToString();
            }
            catch { return null; }
        }

        private static bool TryReadBool(object instance, ref FieldInfo? cache, string fieldName)
        {
            try
            {
                if (cache == null)
                {
                    var t = instance.GetType();
                    while (t != null && t != typeof(object))
                    {
                        var f = t.GetField(fieldName,
                            BindingFlags.Public | BindingFlags.NonPublic |
                            BindingFlags.Instance | BindingFlags.DeclaredOnly);
                        if (f != null) { cache = f; break; }
                        t = t.BaseType;
                    }
                }
                if (cache == null) return false;
                return (bool?)cache.GetValue(instance) ?? false;
            }
            catch { return false; }
        }
    }
}
