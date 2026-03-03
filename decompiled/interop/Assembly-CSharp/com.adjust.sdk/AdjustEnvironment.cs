using System;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Serializable]
[Token(Token = "0x2001DDB")]
public enum AdjustEnvironment
{
	[Token(Token = "0x40105DF")]
	Sandbox,
	[Token(Token = "0x40105E0")]
	Production
}
