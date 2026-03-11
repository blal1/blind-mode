using HarmonyLib;
using System;
using System.Collections;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour ActionSheetViewController — feuille d'action contextuelle.
    ///
    /// ## Ce qui est annoncé :
    ///
    /// A) NotificationStackEntry() — feuille ouverte
    ///    → "[Titre]. Options : A, B, C."
    ///    ou → "Menu contextuel. Options : A, B, C." si le titre n'est pas lu.
    ///
    /// ## Chaîne de données (dump-confirmé) :
    ///
    ///   ActionSheetViewController (namespace YgomGame.ActionSheet)
    ///     Hérite : SelectDialogViewControllerBase&lt;string, EntryData[], int&gt;
    ///              → InformDialogViewControllerBase&lt;string, EntryData[], Action&lt;int&gt;&gt;
    ///     Champs :
    ///       m_DisplayEntryButtonDatas (List&lt;EntryData&gt; 0x160) — entrées affichées
    ///     EntryData (inner class) :
    ///       text         (string 0x10) — libellé du bouton
    ///       explainText  (string 0x18) — description complémentaire
    ///       interactable (bool   0x25) — bouton cliquable
    ///
    /// Appliqué dans Plugin.ApplyPatches() — patch statique, disponible partout.
    /// </summary>
    internal static class ActionSheetPatch
    {
        private static bool _applied = false;

        // Caches de réflexion
        private static FieldInfo?  _fDisplayEntries;
        private static FieldInfo?  _fText;
        private static FieldInfo?  _fInteractable;
        private static MethodInfo? _mGetArg1;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;

            var vcType = AccessToolsHelper.FindType("YgomGame.ActionSheet.ActionSheetViewController");
            if (vcType == null)
            {
                // Essai sans namespace
                vcType = AccessToolsHelper.FindType("ActionSheetViewController");
            }

            if (vcType == null)
            {
                Plugin.Instance?.LogWarn("[ActionSheetPatch] ActionSheetViewController introuvable.");
                return;
            }

            var mStack = vcType.GetMethod("NotificationStackEntry",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
            if (mStack == null)
            {
                Plugin.Instance?.LogWarn("[ActionSheetPatch] NotificationStackEntry introuvable.");
                return;
            }

            // Cacher get_arg1 (title) depuis la hiérarchie de types
            var t = vcType;
            while (t != null && t != typeof(object))
            {
                var mi = t.GetMethod("get_arg1",
                    BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly);
                if (mi != null) { _mGetArg1 = mi; break; }
                t = t.BaseType;
            }

            harmony.Patch(mStack, postfix: new HarmonyMethod(
                typeof(ActionSheetPatch), nameof(StackEntry_Postfix)));

            _applied = true;
            Plugin.Instance?.LogMsg("[ActionSheetPatch] ✓ ActionSheetViewController.NotificationStackEntry");
        }

        // ── Postfix ───────────────────────────────────────────────────────────

        public static void StackEntry_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                // Lire le titre (arg1 = string title)
                string? title = null;
                try { title = _mGetArg1?.Invoke(__instance, null)?.ToString(); }
                catch { }

                // Lire m_DisplayEntryButtonDatas
                if (_fDisplayEntries == null)
                    _fDisplayEntries = __instance.GetType().GetField("m_DisplayEntryButtonDatas",
                        BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance);

                var entries = _fDisplayEntries?.GetValue(__instance) as IList;
                if (entries == null || entries.Count == 0)
                {
                    tts.Speak(title ?? Loc.Get("action_sheet_open"), interrupt: false);
                    return;
                }

                // Lire les textes de chaque EntryData
                var options = new System.Collections.Generic.List<string>(entries.Count);
                foreach (var entry in entries)
                {
                    if (entry == null) continue;

                    // Vérifier interactable
                    if (_fInteractable == null)
                        _fInteractable = entry.GetType().GetField("interactable",
                            BindingFlags.Public | BindingFlags.Instance);

                    bool interactable = (bool?)_fInteractable?.GetValue(entry) ?? true;
                    if (!interactable) continue;

                    if (_fText == null)
                        _fText = entry.GetType().GetField("text",
                            BindingFlags.Public | BindingFlags.Instance);

                    string? text = _fText?.GetValue(entry)?.ToString();
                    if (!string.IsNullOrWhiteSpace(text))
                        options.Add(text!);
                }

                string optionsList = string.Join(", ", options);
                string msg = !string.IsNullOrWhiteSpace(title)
                    ? Loc.Get("action_sheet_with_title", title!, optionsList)
                    : Loc.Get("action_sheet_options", optionsList);

                tts.Speak(msg, interrupt: false);
            }
            catch (Exception ex)
            {
                Plugin.Instance?.LogWarn($"[ActionSheetPatch] {ex.Message}");
            }
        }
    }
}
