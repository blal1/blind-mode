using System.Reflection;
using System.Text.RegularExpressions;

namespace MasterDuelAccessibility.Patches
{
    /// <summary>
    /// Postfix pour CardInfo.SetDescriptionArea — annonce le nom, les stats et
    /// l'effet de la carte quand le panneau d'information s'ouvre.
    ///
    /// Champs lus depuis CardInfoBase (via réflexion) :
    ///   m_CardName_Property     — RubyTextGX  — nom de la carte
    ///   m_AtkValue_Property     — ExtendedTMP — valeur ATK
    ///   m_DefValue_Property     — ExtendedTMP — valeur DEF
    ///   m_LevelNum_Property     — ExtendedTMP — niveau (monstre normal/effet)
    ///   m_RankNum_Property      — ExtendedTMP — rang (XYZ)
    ///   m_LinkNum_Property      — ExtendedTMP — rating Link
    ///   m_DspTitle_Property     — ExtendedTMP — type de carte (ex. "Effet", "Magie Continue")
    ///   m_DspContent_Property   — ExtendedTMP — texte de l'effet
    /// </summary>
    internal static class CardInfoPatch
    {
        public static void Show_Postfix(object __instance)
        {
            var tts = Plugin.Instance?.Tts;
            if (tts == null || __instance == null) return;

            try
            {
                string announcement = BuildAnnouncement(__instance);
                if (!string.IsNullOrWhiteSpace(announcement))
                    tts.Speak(announcement);
            }
            catch { /* reflection fallback — silent fail */ }
        }

        internal static string BuildAnnouncement(object instance)
        {
            string? name = ReadField(instance, "m_CardName_Property");
            if (string.IsNullOrWhiteSpace(name)) return string.Empty;

            string? attr     = ReadAttribute(instance);
            string? atk      = ReadField(instance, "m_AtkValue_Property");
            string? def      = ReadField(instance, "m_DefValue_Property");
            string? level    = ReadField(instance, "m_LevelNum_Property");
            string? rank     = ReadField(instance, "m_RankNum_Property");
            string? link     = ReadField(instance, "m_LinkNum_Property");
            string? penScale = ReadField(instance, "m_PenScaleNum_Property");
            string? type     = ReadField(instance, "m_DspTitle_Property");
            string? sptrType = ReadField(instance, "m_SpTrType_Property");
            string? desc     = ReadField(instance, "m_DspContent_Property");

            if (desc != null) desc = Regex.Replace(desc, "<[^>]+>", "");

            var parts = new System.Collections.Generic.List<string> { name! };

            if (!string.IsNullOrWhiteSpace(attr))     parts.Add(attr!);
            if (!string.IsNullOrWhiteSpace(type))     parts.Add(type!);
            if (!string.IsNullOrWhiteSpace(sptrType)) parts.Add(sptrType!);
            if (!string.IsNullOrWhiteSpace(level))    parts.Add(Loc.Get("card_level",          level));
            if (!string.IsNullOrWhiteSpace(rank))     parts.Add(Loc.Get("card_rank",           rank));
            if (!string.IsNullOrWhiteSpace(link))     parts.Add(Loc.Get("card_link",           link));
            if (!string.IsNullOrWhiteSpace(penScale)) parts.Add(Loc.Get("card_pendulum_scale", penScale));
            if (!string.IsNullOrWhiteSpace(atk))      parts.Add(Loc.Get("card_atk",            atk));
            if (!string.IsNullOrWhiteSpace(def))      parts.Add(Loc.Get("card_def",            def));
            // Description incluse uniquement en mode verbeux (Loc.Verbose = CfgVerbose BepInEx).
            // Pattern Strings.cs.WithDetail() d'AccessibleArena : description optionnelle.
            if (Loc.Verbose && !string.IsNullOrWhiteSpace(desc)) parts.Add(desc!);

            return string.Join(". ", parts);
        }

        /// <summary>
        /// Reads the text property of a field whose value is a TMP component.
        /// Walks the type hierarchy to support inheritance.
        /// </summary>
        private static string? ReadField(object instance, string fieldName)
        {
            var type = instance.GetType();
            while (type != null)
            {
                var field = type.GetField(
                    fieldName,
                    BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                if (field != null)
                {
                    var component = field.GetValue(instance);
                    if (component == null) return null;

                    var textProp = component.GetType()
                        .GetProperty("text", BindingFlags.Public | BindingFlags.Instance);
                    return textProp?.GetValue(component)?.ToString();
                }
                type = type.BaseType;
            }
            return null;
        }

        /// <summary>
        /// Reads the attribute of the card from the m_AttributeIcon_Property Image field.
        /// The sprite name ends with a digit: 1=Light, 2=Dark, 3=Water, 4=Fire, 5=Earth, 6=Wind, 7=Divine.
        /// </summary>
        private static string? ReadAttribute(object instance)
        {
            try
            {
                var type = instance.GetType();
                while (type != null)
                {
                    var field = type.GetField(
                        "m_AttributeIcon_Property",
                        BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public);

                    if (field != null)
                    {
                        var image = field.GetValue(instance);
                        if (image == null) return null;

                        var sprite = image.GetType()
                            .GetProperty("sprite", BindingFlags.Public | BindingFlags.Instance)
                            ?.GetValue(image);
                        if (sprite == null) return null;

                        var spriteName = sprite.GetType()
                            .GetProperty("name", BindingFlags.Public | BindingFlags.Instance)
                            ?.GetValue(sprite)?.ToString();

                        return ParseAttribute(spriteName);
                    }
                    type = type.BaseType;
                }
                return null;
            }
            catch { return null; }
        }

        private static string? ParseAttribute(string? spriteName)
        {
            if (string.IsNullOrEmpty(spriteName)) return null;
            if (!char.IsDigit(spriteName![spriteName.Length - 1])) return null;

            return (spriteName[spriteName.Length - 1] - '0') switch
            {
                1 => Loc.Get("attr_light"),
                2 => Loc.Get("attr_dark"),
                3 => Loc.Get("attr_water"),
                4 => Loc.Get("attr_fire"),
                5 => Loc.Get("attr_earth"),
                6 => Loc.Get("attr_wind"),
                7 => Loc.Get("attr_divine"),
                _ => null
            };
        }

        /// <summary>Reused by KeyboardShortcuts for the Alt command.</summary>
        internal static string? ReadCardName(object instance) =>
            ReadField(instance, "m_CardName_Property");
    }
}
