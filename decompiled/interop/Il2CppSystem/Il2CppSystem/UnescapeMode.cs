using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppSystem;

[OriginalName("System.dll", "System", "UnescapeMode")]
[System.Flags]
public enum UnescapeMode
{
	CopyOnly = 0,
	Escape = 1,
	Unescape = 2,
	EscapeUnescape = 3,
	V1ToStringFlag = 4,
	UnescapeAll = 8,
	UnescapeAllOrThrow = 0x18
}
