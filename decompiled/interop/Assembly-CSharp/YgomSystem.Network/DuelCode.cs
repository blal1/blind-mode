using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000249")]
public enum DuelCode
{
	[Token(Token = "0x4000BD5")]
	NONE = 0,
	[Token(Token = "0x4000BD6")]
	ERROR = 1,
	[Token(Token = "0x4000BD7")]
	FATAL = 2,
	[Token(Token = "0x4000BD8")]
	CRITICAL = 3,
	[Token(Token = "0x4000BD9")]
	TIMEOUT = 1400,
	[Token(Token = "0x4000BDA")]
	NOT_FIND_FRIEND = 1401,
	[Token(Token = "0x4000BDB")]
	REFUSED_FRIEND = 1402,
	[Token(Token = "0x4000BDC")]
	INVALID_DECK = 1403
}
