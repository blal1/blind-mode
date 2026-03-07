using System;
using System.Reflection;
using System.Text;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour FilterSelectViewController.OpenFilterSelect :
    ///   Annonce le titre du dialog de filtres multi-sélection et l'état actuel
    ///   de chaque option (actif / inactif).
    ///
    /// ## Signature de OpenFilterSelect (dump)
    ///   public static void OpenFilterSelect(
    ///     string title,
    ///     FilterSelectViewController.EntryData[] entrys,
    ///     Action<bool[]> callback,
    ///     Action onCancel,
    ///     string message,
    ///     bool isFooterShortCut = true,
    ///     Dictionary<string, object> args)
    ///
    /// ## FilterSelectViewController.EntryData (champs publics — dump)
    ///   public string text;                       // 0x10
    ///   public FilterSelectViewController.ButtonStyle buttonStyle; // 0x18
    ///   public bool interactable;                 // 0x1C
    ///   public string overrideSeClick;            // 0x20
    ///   public bool isOn;                         // 0x28
    ///   public string imagePath;                  // 0x30
    ///   public bool badge;                        // 0x38
    ///
    /// ## Format d'annonce
    ///   "Filtres : Title. Option1 (actif), Option2 (inactif), …"
    ///
    /// ## Enregistrement
    /// Appliqué depuis Plugin.ApplyPatches() via TryPatch("FilterSelectViewController", "OpenFilterSelect").
    /// </summary>
    internal static class FilterSelectViewPatch
    {
        // ── Postfix ────────────────────────────────────────────────────────────

        /// <summary>
        /// Postfix pour FilterSelectViewController.OpenFilterSelect(string, EntryData[], ...).
        ///
        /// Harmony injecte les paramètres positionnels :
        ///   __0 = title (string)
        ///   __1 = entrys (object — array d'EntryData)
        ///   __4 = message (string, optionnel — peut compléter le titre)
        /// </summary>
        public static void OpenFilterSelect_Postfix(object __0, object __1, object __4)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;

            try
            {
                string title   = __0 as string ?? "";
                string message = __4 as string ?? "";

                // Announce title (use message as fallback if title is blank)
                string heading = !string.IsNullOrWhiteSpace(title) ? title
                               : !string.IsNullOrWhiteSpace(message) ? message
                               : Loc.Get("filter_dialog_title");

                var sb = new StringBuilder();
                sb.Append(Loc.Get("filter_dialog_opened", heading));

                // entrys may be a System.Array in IL2CPP wrapper
                if (__1 is System.Collections.IEnumerable entrys)
                {
                    sb.Append(": ");
                    bool first = true;
                    foreach (var entry in entrys)
                    {
                        if (entry == null) continue;
                        string? text = ReadStringField(entry, "text");
                        bool   isOn  = ReadBoolField(entry, "isOn");
                        if (string.IsNullOrWhiteSpace(text)) continue;

                        if (!first) sb.Append(", ");
                        first = false;

                        string stateKey = isOn ? "card_filter_active" : "card_filter_inactive";
                        sb.Append(Loc.Get(stateKey, text));
                    }
                }

                tts.Speak(sb.ToString(), interrupt: false);
            }
            catch { }
        }

        // ── Reflection helpers ────────────────────────────────────────────────

        private static string? ReadStringField(object obj, string name)
        {
            try
            {
                return obj.GetType()
                    .GetField(name, BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(obj) as string;
            }
            catch { return null; }
        }

        private static bool ReadBoolField(object obj, string name)
        {
            try
            {
                var val = obj.GetType()
                    .GetField(name, BindingFlags.Public | BindingFlags.Instance)
                    ?.GetValue(obj);
                return val is bool b && b;
            }
            catch { return false; }
        }
    }
}
