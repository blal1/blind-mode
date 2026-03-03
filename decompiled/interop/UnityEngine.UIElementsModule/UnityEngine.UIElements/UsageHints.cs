using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000288")]
[Flags]
public enum UsageHints
{
	[Token(Token = "0x4000A18")]
	None = 0,
	[Token(Token = "0x4000A19")]
	DynamicTransform = 1,
	[Token(Token = "0x4000A1A")]
	GroupTransform = 2,
	[Token(Token = "0x4000A1B")]
	MaskContainer = 4,
	[Token(Token = "0x4000A1C")]
	DynamicColor = 8
}
