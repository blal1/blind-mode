using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200025C")]
public enum CgdbDeckSearchCode
{
	[Token(Token = "0x4000CC0")]
	NONE,
	[Token(Token = "0x4000CC1")]
	ERROR,
	[Token(Token = "0x4000CC2")]
	FATAL,
	[Token(Token = "0x4000CC3")]
	CRITICAL,
	[Token(Token = "0x4000CC4")]
	MAINTE,
	[Token(Token = "0x4000CC5")]
	INVALID_USER_TOKEN,
	[Token(Token = "0x4000CC6")]
	ID_NOT_REGISTERD,
	[Token(Token = "0x4000CC7")]
	DECK_NOT_FOUND
}
