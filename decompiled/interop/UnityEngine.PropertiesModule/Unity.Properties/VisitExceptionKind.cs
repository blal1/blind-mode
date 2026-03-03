using System;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000002")]
[Flags]
public enum VisitExceptionKind
{
	[Token(Token = "0x4000002")]
	None = 0,
	[Token(Token = "0x4000003")]
	Internal = 1,
	[Token(Token = "0x4000004")]
	Visitor = 2,
	[Token(Token = "0x4000005")]
	All = 3
}
