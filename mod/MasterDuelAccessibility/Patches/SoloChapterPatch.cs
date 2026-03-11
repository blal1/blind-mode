using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour SoloSelectChapterViewController.ChapterMap.OnClickChapter.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) OnClickChapter(SelectionButton, Chapter) — chapitre focalisé
    ///    → "Chapitre : [nom]. [statut]"
    ///
    ///    Statuts possibles (SoloModeUtil.ChapterStatus) :
    ///      UNOPEN (-1) = Verrouillé
    ///      OPEN   (0)  = Disponible
    ///      RENTAL_CLEAR (1) = Terminé (deck prêté)
    ///      MYDECK_CLEAR (2) = Terminé (ton deck)
    ///      COMPLETE (3)     = Complété
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   SoloSelectChapterViewController.ChapterMap (inner class, no namespace)
    ///     └─ OnClickChapter(SelectionButton sb, Chapter data)
    ///          └─ Chapter (abstract base class) :
    ///               ├─ strChapter (string internal 0x60) — titre du chapitre
    ///               ├─ IsCleared()  (virtual bool method)
    ///               ├─ IsCompleted() (virtual bool method)
    ///               └─ status (SoloModeUtil.ChapterStatus internal 0x74)
    ///
    /// Appliqué via LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class SoloChapterPatch
    {
        private static bool _applied = false;

        // Caches de réflexion — Chapter
        private static FieldInfo?  _fStrChapter;
        private static MethodInfo? _mIsCleared;
        private static MethodInfo? _mIsCompleted;
        private static FieldInfo?  _fStatus;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            // Chercher SoloSelectChapterViewController dans le namespace YgomGame.Solo
            var vcType = AccessToolsHelper.FindType("YgomGame.Solo.SoloSelectChapterViewController");
            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[SoloChapterPatch] SoloSelectChapterViewController introuvable.");
                return;
            }

            // Obtenir la classe interne ChapterMap
            var mapType = vcType.GetNestedType("ChapterMap",
                BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);
            if (mapType == null)
            {
                Plugin.Instance?.LogWarn("[SoloChapterPatch] ChapterMap introuvable.");
                return;
            }

            // Trouver OnClickChapter(SelectionButton, Chapter) par nombre de paramètres
            MethodInfo? onClickChapter = null;
            foreach (var m in mapType.GetMethods(
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
            {
                if (m.Name == "OnClickChapter" && m.GetParameters().Length == 2)
                {
                    onClickChapter = m;
                    break;
                }
            }

            if (onClickChapter == null)
            {
                Plugin.Instance?.LogWarn("[SoloChapterPatch] OnClickChapter introuvable.");
                return;
            }

            harmony.Patch(onClickChapter, postfix: new HarmonyMethod(
                typeof(SoloChapterPatch), nameof(OnClickChapter_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[SoloChapterPatch] ✓ ChapterMap.OnClickChapter");
        }

        internal static void Reset()
        {
            _applied      = false;
            _fStrChapter  = null;
            _mIsCleared   = null;
            _mIsCompleted = null;
            _fStatus      = null;
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        /// <summary>
        /// __0 = SelectionButton sb (ignoré)
        /// __1 = Chapter data
        /// </summary>
        public static void OnClickChapter_Postfix(object __1)
        {
            if (__1 == null) return;

            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                string msg = BuildAnnouncement(__1);
                if (!string.IsNullOrWhiteSpace(msg))
                    tts.Speak(msg, interrupt: true);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[SoloChapterPatch] {ex.Message}");
            }
        }

        // ── Announcement builder ──────────────────────────────────────────────

        private static string BuildAnnouncement(object chapter)
        {
            var t = chapter.GetType();

            // Lire strChapter (nom du chapitre)
            if (_fStrChapter == null)
                _fStrChapter = FindField(t, "strChapter");

            string? name = _fStrChapter?.GetValue(chapter)?.ToString();
            if (string.IsNullOrWhiteSpace(name))
                return Loc.Get("solo_chapter_unknown");

            // Lire le statut via IsCleared / IsCompleted (méthodes virtuelles)
            if (_mIsCleared == null)
                _mIsCleared = FindMethod(t, "IsCleared");
            if (_mIsCompleted == null)
                _mIsCompleted = FindMethod(t, "IsCompleted");

            bool isCompleted = (bool?)_mIsCompleted?.Invoke(chapter, null) ?? false;
            bool isCleared   = (bool?)_mIsCleared?.Invoke(chapter, null)   ?? false;

            // Lire le statut enum pour discriminer UNOPEN
            if (_fStatus == null)
                _fStatus = FindField(t, "status");

            int statusVal = Convert.ToInt32(_fStatus?.GetValue(chapter) ?? 0);

            string statusKey = isCompleted ? "solo_gate_complete"
                             : isCleared   ? "solo_gate_clear"
                             : statusVal == -1 ? "solo_gate_locked"
                             : "solo_gate_unlocked";

            return Loc.Get("solo_chapter_item", name!, Loc.Get(statusKey));
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        private static FieldInfo? FindField(Type t, string name)
        {
            // Chercher dans la hiérarchie (type + types de base)
            var type = t;
            while (type != null && type != typeof(object))
            {
                var fi = type.GetField(name,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (fi != null) return fi;
                type = type.BaseType;
            }
            return null;
        }

        private static MethodInfo? FindMethod(Type t, string name)
        {
            var type = t;
            while (type != null && type != typeof(object))
            {
                var mi = type.GetMethod(name,
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (mi != null) return mi;
                type = type.BaseType;
            }
            return null;
        }
    }
}
