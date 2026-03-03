using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization;

[OriginalName("mscorlib.dll", "System.Globalization", "FORMATFLAGS")]
public enum FORMATFLAGS
{
	None = 0,
	UseGenitiveMonth = 1,
	UseLeapYearMonth = 2,
	UseSpacesInMonthNames = 4,
	UseHebrewParsing = 8,
	UseSpacesInDayNames = 0x10,
	UseDigitPrefixInTokens = 0x20
}
