using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000256")]
public enum PresentBoxCode
{
	[Token(Token = "0x4000C88")]
	NONE = 0,
	[Token(Token = "0x4000C89")]
	ERROR = 1,
	[Token(Token = "0x4000C8A")]
	FATAL = 2,
	[Token(Token = "0x4000C8B")]
	CRITICAL = 3,
	[Token(Token = "0x4000C8C")]
	ERR_INVALID_PARAM = 2500
}
