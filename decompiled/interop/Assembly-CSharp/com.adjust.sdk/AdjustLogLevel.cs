using System;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Serializable]
[Token(Token = "0x2001DE0")]
public enum AdjustLogLevel
{
	[Token(Token = "0x40105F8")]
	Verbose = 1,
	[Token(Token = "0x40105F9")]
	Debug,
	[Token(Token = "0x40105FA")]
	Info,
	[Token(Token = "0x40105FB")]
	Warn,
	[Token(Token = "0x40105FC")]
	Error,
	[Token(Token = "0x40105FD")]
	Assert,
	[Token(Token = "0x40105FE")]
	Suppress
}
