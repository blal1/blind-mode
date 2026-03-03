using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000006")]
[Flags]
public enum DynamicAtlasFilters
{
	[Token(Token = "0x4000003")]
	None = 0,
	[Token(Token = "0x4000004")]
	Readability = 1,
	[Token(Token = "0x4000005")]
	Size = 2,
	[Token(Token = "0x4000006")]
	Format = 4,
	[Token(Token = "0x4000007")]
	ColorSpace = 8,
	[Token(Token = "0x4000008")]
	FilterMode = 0x10
}
