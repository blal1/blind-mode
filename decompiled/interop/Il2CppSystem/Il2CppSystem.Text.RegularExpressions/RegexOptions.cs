using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem.Text.RegularExpressions;

[OriginalName("System.dll", "System.Text.RegularExpressions", "RegexOptions")]
[System.Flags]
public enum RegexOptions
{
	None = 0,
	IgnoreCase = 1,
	Multiline = 2,
	ExplicitCapture = 4,
	Compiled = 8,
	Singleline = 0x10,
	IgnorePatternWhitespace = 0x20,
	RightToLeft = 0x40,
	ECMAScript = 0x100,
	CultureInvariant = 0x200
}
