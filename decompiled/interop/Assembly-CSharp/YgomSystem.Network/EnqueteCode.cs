using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000261")]
public enum EnqueteCode
{
	[Token(Token = "0x4000D06")]
	NONE = 0,
	[Token(Token = "0x4000D07")]
	ERROR = 1,
	[Token(Token = "0x4000D08")]
	FATAL = 2,
	[Token(Token = "0x4000D09")]
	CRITICAL = 3,
	[Token(Token = "0x4000D0A")]
	ERROR_INVALID_TERM = 3401,
	[Token(Token = "0x4000D0B")]
	ERROR_INVALID_PARAM = 3402
}
