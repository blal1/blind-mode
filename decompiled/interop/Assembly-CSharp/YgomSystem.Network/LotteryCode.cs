using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000274")]
public enum LotteryCode
{
	[Token(Token = "0x4000DEC")]
	NONE = 0,
	[Token(Token = "0x4000DED")]
	ERROR = 1,
	[Token(Token = "0x4000DEE")]
	FATAL = 2,
	[Token(Token = "0x4000DEF")]
	CRITICAL = 3,
	[Token(Token = "0x4000DF0")]
	INVALID_PARAM = 5400,
	[Token(Token = "0x4000DF1")]
	ERR_OUT_OF_TERM = 5401,
	[Token(Token = "0x4000DF2")]
	ERR_OUT_OF_TERM_CARD_SELECT = 5402
}
