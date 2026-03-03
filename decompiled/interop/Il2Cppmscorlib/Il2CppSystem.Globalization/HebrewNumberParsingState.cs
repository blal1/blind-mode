using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization;

[OriginalName("mscorlib.dll", "System.Globalization", "HebrewNumberParsingState")]
public enum HebrewNumberParsingState
{
	InvalidHebrewNumber,
	NotHebrewDigit,
	FoundEndOfHebrewNumber,
	ContinueParsing
}
