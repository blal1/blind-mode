using System;
using System.Collections.Generic;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch de secours pour InformDialogViewControllerBase (abstract, pas de NSE propre).
    ///
    /// Stratégie : à l'application des patches tardifs, on parcourt tous les types .NET
    /// chargés (assemblies BepInEx interop), on cherche les sous-classes concrètes de
    /// InformDialogViewControllerBase qui ne sont PAS dans l'ensemble KnownHandled (déjà
    /// couvertes par un patch dédié), puis on leur applique un postfix NSE générique qui
    /// annonce le nom du dialog dérivé du nom de la classe.
    ///
    /// Utilise bypassOriginal=true pour éviter la récursion vtable IL2CPP sur les stubs
    /// vides (RVA 0x3E4080). Tous les types à NSE réelle connus sont dans KnownHandled.
    ///
    /// Appliqué dans LatePatches.ApplyMenuScenePatches().
    /// </summary>
    internal static class InformDialogFallbackPatch
    {
        private static bool _applied = false;

        /// <summary>
        /// Noms simples (Type.Name) des sous-classes InformDialogViewControllerBase
        /// déjà couvertes par un patch dédié. Ces types sont ignorés ici pour
        /// éviter les doubles annonces.
        /// </summary>
        private static readonly HashSet<string> KnownHandled = new HashSet<string>(
            StringComparer.Ordinal)
        {
            // Direct InformDialogViewControllerBase subclasses
            "CardCraftResultDialog",
            "EventNotifyViewController",
            "StructureDeckObtainViewController",

            // SelectDialogViewControllerBase subclasses (concrete)
            "DuelLiveWCSFilterDialog",
            "AutoBuildDialog",
            "BatchDismantleDialog",
            "CardCraftDialog",
            "DeckNameEditDialog",
            "FilterDialog",
            "SearchBoxDialog",
            "SetAccessoryDialog",
            "ActionSheetViewController",
            "FilterSelectViewController",

            // SortDialogBase concrete subclasses
            "SortDialogViewController_Card",
            "SortDialogViewController_CardFile",
            "SortDialogViewController_Solo",
        };

        internal static void Reset() => _applied = false;

        internal static void Apply(HarmonyLib.Harmony harmony)
        {
            if (_applied) return;
            _applied = true;

            int patched = 0;
            int skipped = 0;

            foreach (var assembly in AppDomain.CurrentDomain.GetAssemblies())
            {
                IEnumerable<Type> types;
                try { types = assembly.GetTypes(); }
                catch { continue; }

                foreach (var t in types)
                {
                    if (t.IsAbstract) continue;
                    if (KnownHandled.Contains(t.Name)) { skipped++; continue; }
                    if (!IsInformDialogSubclass(t)) continue;

                    // Only patch if this type declares its own NotificationStackEntry override.
                    // DeclaredOnly ensures we don't accidentally patch base-class methods.
                    var nse = t.GetMethod("NotificationStackEntry",
                        BindingFlags.Public | BindingFlags.NonPublic |
                        BindingFlags.Instance | BindingFlags.DeclaredOnly);
                    if (nse == null) continue;

                    try
                    {
                        // bypassOriginal=true → prefix retourne false → évite la récursion
                        // vtable IL2CPP sur les stubs vides. Postfix s'exécute quand même.
                        harmony.Patch(nse,
                            prefix: new HarmonyLib.HarmonyMethod(
                                typeof(InformDialogFallbackPatch), nameof(NseBypass_Prefix)),
                            postfix: new HarmonyLib.HarmonyMethod(
                                typeof(InformDialogFallbackPatch), nameof(Generic_Postfix)));
                        Plugin.Instance?.LogMsg(
                            $"[InformDialogFallback] ✓ {t.Name}.NotificationStackEntry [fallback]");
                        patched++;
                    }
                    catch (Exception ex)
                    {
                        Plugin.Instance?.LogWarn(
                            $"[InformDialogFallback] {t.Name}: {ex.Message}");
                    }
                }
            }

            Plugin.Instance?.LogMsg(
                $"[InformDialogFallback] {patched} type(s) découvert(s), {skipped} ignoré(s).");
        }

        // ── Prefix : bypasse l'original pour éviter la récursion vtable IL2CPP ──

        public static bool NseBypass_Prefix() => false;

        // ── Postfix générique : annonce le nom du dialog ──────────────────────

        public static void Generic_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || __instance == null) return;
            try
            {
                string typeName = __instance.GetType().Name;

                // Strip numeric suffix (e.g. "SomeDialog2" → "SomeDialog")
                while (typeName.Length > 0 && char.IsDigit(typeName[typeName.Length - 1]))
                    typeName = typeName.Substring(0, typeName.Length - 1);

                // Strip common dialog suffixes (order matters)
                foreach (var s in new[] { "ViewController2", "ViewController", "Dialog", "Widget" })
                {
                    if (typeName.EndsWith(s, StringComparison.Ordinal))
                    {
                        typeName = typeName.Substring(0, typeName.Length - s.Length);
                        break;
                    }
                }

                if (string.IsNullOrEmpty(typeName)) return;
                tts.Speak(Loc.Get("inform_dialog_generic", typeName), interrupt: false);
            }
            catch { /* silent */ }
        }

        // ── Helpers ──────────────────────────────────────────────────────────

        /// <summary>
        /// Walks the base type chain to detect if a type inherits (directly or indirectly)
        /// from InformDialogViewControllerBase or any of its generic variants.
        /// Uses name matching to handle IL2CPP generic instantiation proxy types.
        /// </summary>
        private static bool IsInformDialogSubclass(Type t)
        {
            var cur = t.BaseType;
            while (cur != null && cur != typeof(object))
            {
                if (cur.Name == "InformDialogViewControllerBase" ||
                    cur.Name.StartsWith("InformDialogViewControllerBase`",
                        StringComparison.Ordinal))
                    return true;
                cur = cur.BaseType;
            }
            return false;
        }
    }
}
