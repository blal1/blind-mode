using System;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Serializable]
[Token(Token = "0x2001DE6")]
public enum AdjustUrlStrategy
{
	[Token(Token = "0x4010616")]
	Default,
	[Token(Token = "0x4010617")]
	DataResidencyEU,
	[Token(Token = "0x4010618")]
	DataResidencyTK,
	[Token(Token = "0x4010619")]
	DataResidencyUS,
	[Token(Token = "0x401061A")]
	India,
	[Token(Token = "0x401061B")]
	China
}
