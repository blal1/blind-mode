using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Globalization;

[OriginalName("mscorlib.dll", "System.Globalization", "DateTimeStyles")]
[System.Flags]
public enum DateTimeStyles
{
	None = 0,
	AllowLeadingWhite = 1,
	AllowTrailingWhite = 2,
	AllowInnerWhite = 4,
	AllowWhiteSpaces = 7,
	NoCurrentDateDefault = 8,
	AdjustToUniversal = 0x10,
	AssumeLocal = 0x20,
	AssumeUniversal = 0x40,
	RoundtripKind = 0x80
}
