using HarmonyLib;
using System;
using System.Reflection;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Patch pour YgomGame.Menu.Common.InputDigitViewController :
    ///   - OnCreatedView() → annonce l'ouverture du sélecteur avec valeur/min/max
    ///   - OnValueAdded(int delta) → annonce la nouvelle valeur à chaque clic +/-
    ///
    /// Ce dialog s'ouvre quand le jeu demande au joueur de choisir un nombre.
    /// Exemples : "Payer X PV", "Ajouter X compteurs", "Sélectionner un nombre".
    ///
    /// Structure du type (dump.cs:207916) :
    ///   private int _currentValue; // 0x104
    ///   private int _maxValue;     // 0xF8
    ///   private int _minValue;     // 0xFC
    ///   private int _largeChangeAmount; // 0x100
    ///   private ExtendedTextMeshProUGUI _digitText; // 0xE0  ← affiche la valeur courante
    ///   private void OnValueAdded(int delta)        ← déclenché à chaque clic +/-
    ///   protected override void OnCreatedView()    ← déclenché quand l'UI est prête
    ///
    /// Appliqué dans Plugin.ApplyPatches() — pas besoin de LatePatches car le type
    /// est dans l'assembly principal (YgomGame.Menu.Common).
    /// </summary>
    internal static class InputDigitViewPatch
    {
        // ── Postfix : OnCreatedView ────────────────────────────────────────────

        /// <summary>
        /// Annonce l'ouverture du dialog avec la valeur initiale et la plage autorisée.
        /// </summary>
        public static void OnCreatedView_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int current = ReadInt(__instance, "_currentValue");
                int min     = ReadInt(__instance, "_minValue");
                int max     = ReadInt(__instance, "_maxValue");

                // Essaie de lire un titre depuis un TMP_Text sibling du _digitText
                string? title = ReadTitle(__instance);

                string msg = string.IsNullOrWhiteSpace(title)
                    ? Loc.Get("input_digit_opened", current, min, max)
                    : Loc.Get("input_digit_opened_titled", title, current, min, max);

                tts.Speak(msg, interrupt: true);
            }
            catch { }
        }

        // ── Postfix : OnValueAdded ─────────────────────────────────────────────

        /// <summary>
        /// Annonce la nouvelle valeur après chaque appui sur + ou -.
        /// </summary>
        public static void OnValueAdded_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null) return;
            try
            {
                int current = ReadInt(__instance, "_currentValue");
                tts.Speak(Loc.Get("input_digit_value", current), interrupt: true, addToHistory: false);
            }
            catch { }
        }

        // ── Helpers ───────────────────────────────────────────────────────────

        private static int ReadInt(object instance, string fieldName)
        {
            var field = instance.GetType().GetField(fieldName,
                BindingFlags.NonPublic | BindingFlags.Instance);
            return field?.GetValue(instance) is int v ? v : 0;
        }

        /// <summary>
        /// Tente de lire un texte de titre depuis les composants TMP_Text siblings du
        /// _digitText (le champ de valeur numérique). Retourne null en cas d'échec.
        /// </summary>
        private static string? ReadTitle(object instance)
        {
            try
            {
                // Récupère _digitText (ExtendedTextMeshProUGUI) via réflexion
                var digitField = instance.GetType().GetField("_digitText",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                var digitText = digitField?.GetValue(instance);
                if (digitText == null) return null;

                // Remonte au parent du _digitText pour chercher d'autres TMP_Text
                var xformProp  = digitText.GetType().GetProperty("transform",
                    BindingFlags.Public | BindingFlags.Instance);
                var xform = xformProp?.GetValue(digitText);
                if (xform == null) return null;

                var parentProp = xform.GetType().GetProperty("parent",
                    BindingFlags.Public | BindingFlags.Instance);
                var parent = parentProp?.GetValue(xform);
                if (parent == null) return null;

                // Itère les enfants du parent
                var childCountProp = parent.GetType().GetProperty("childCount",
                    BindingFlags.Public | BindingFlags.Instance);
                int childCount = childCountProp?.GetValue(parent) is int c ? c : 0;

                var getChildMethod = parent.GetType().GetMethod("GetChild",
                    BindingFlags.Public | BindingFlags.Instance,
                    null, new[] { typeof(int) }, null);

                for (int i = 0; i < childCount; i++)
                {
                    var child = getChildMethod?.Invoke(parent, new object[] { i });
                    if (child == null) continue;

                    var goProp = child.GetType().GetProperty("gameObject",
                        BindingFlags.Public | BindingFlags.Instance);
                    var go = goProp?.GetValue(child);
                    if (go == null) continue;

                    // Cherche un TMP_Text sur cet objet
                    var getCompMethod = go.GetType().GetMethod("GetComponent",
                        BindingFlags.Public | BindingFlags.Instance,
                        null, new[] { typeof(Type) }, null);
                    if (getCompMethod == null) continue;

                    var tmp = getCompMethod.Invoke(go, new object[] { typeof(TMPro.TMP_Text) });
                    if (tmp == null) continue;

                    // Ignore le _digitText lui-même
                    if (ReferenceEquals(tmp, digitText)) continue;

                    var textProp = tmp.GetType().GetProperty("text",
                        BindingFlags.Public | BindingFlags.Instance);
                    var text = textProp?.GetValue(tmp) as string;

                    if (!string.IsNullOrWhiteSpace(text))
                        return text.Trim();
                }
            }
            catch { }
            return null;
        }
    }
}
