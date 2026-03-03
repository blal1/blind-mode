using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200024E")]
public enum GachaCode
{
	[Token(Token = "0x4000C1A")]
	NONE = 0,
	[Token(Token = "0x4000C1B")]
	ERROR = 1,
	[Token(Token = "0x4000C1C")]
	FATAL = 2,
	[Token(Token = "0x4000C1D")]
	CRITICAL = 3,
	[Token(Token = "0x4000C1E")]
	ERR_INVALID_PARAM = 1900,
	[Token(Token = "0x4000C1F")]
	ERR_INVALID_DRAW_NUM = 1901,
	[Token(Token = "0x4000C20")]
	ERR_OUT_OF_TERM = 1902,
	[Token(Token = "0x4000C21")]
	ERR_MISSING_REQUIRED_ITEMS = 1903
}
