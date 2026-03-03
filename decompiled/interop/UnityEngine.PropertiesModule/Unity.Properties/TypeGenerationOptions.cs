using System;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200000C")]
[Flags]
public enum TypeGenerationOptions
{
	[Token(Token = "0x4000017")]
	None = 0,
	[Token(Token = "0x4000018")]
	ValueType = 2,
	[Token(Token = "0x4000019")]
	ReferenceType = 4,
	[Token(Token = "0x400001A")]
	Default = 6
}
