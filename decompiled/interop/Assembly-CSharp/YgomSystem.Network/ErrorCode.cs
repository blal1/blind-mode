using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000246")]
public enum ErrorCode
{
	[Token(Token = "0x4000B85")]
	NONE,
	[Token(Token = "0x4000B86")]
	ERROR,
	[Token(Token = "0x4000B87")]
	FATAL,
	[Token(Token = "0x4000B88")]
	CRITICAL,
	[Token(Token = "0x4000B89")]
	MAINTE,
	[Token(Token = "0x4000B8A")]
	MAINTE_FOR_BACK,
	[Token(Token = "0x4000B8B")]
	GENERAL,
	[Token(Token = "0x4000B8C")]
	GOTO_STORE,
	[Token(Token = "0x4000B8D")]
	SECTION_MAINTE,
	[Token(Token = "0x4000B8E")]
	ADDITIONAL_DL,
	[Token(Token = "0x4000B8F")]
	ACCOUNT_BAN,
	[Token(Token = "0x4000B90")]
	GOTO_STORE_FOR_TITLE,
	[Token(Token = "0x4000B91")]
	SESSION_EXPIRED
}
