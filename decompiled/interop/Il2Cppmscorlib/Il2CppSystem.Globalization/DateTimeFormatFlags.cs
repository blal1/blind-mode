using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization;

[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeFormatFlags")]
[System.Flags]
public enum DateTimeFormatFlags
{
	None = 0,
	UseGenitiveMonth = 1,
	UseLeapYearMonth = 2,
	UseSpacesInMonthNames = 4,
	UseHebrewRule = 8,
	UseSpacesInDayNames = 0x10,
	UseDigitPrefixInTokens = 0x20,
	NotInitialized = -1
}
