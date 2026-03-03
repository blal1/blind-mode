using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200024D")]
public enum CraftCode
{
	[Token(Token = "0x4000C0D")]
	NONE = 0,
	[Token(Token = "0x4000C0E")]
	ERROR = 1,
	[Token(Token = "0x4000C0F")]
	FATAL = 2,
	[Token(Token = "0x4000C10")]
	CRITICAL = 3,
	[Token(Token = "0x4000C11")]
	ERROR_CRAFT_GEN = 1800,
	[Token(Token = "0x4000C12")]
	ERROR_CRAFT_LIMIT = 1801,
	[Token(Token = "0x4000C13")]
	ERROR_UPDATE_FAILED = 1802,
	[Token(Token = "0x4000C14")]
	ERROR_COMPENSATION_TIMELIMIT = 1803,
	[Token(Token = "0x4000C15")]
	ERROR_BOOST_CRAFT_FAILED = 1804,
	[Token(Token = "0x4000C16")]
	ERROR_LOCKED_CARD_CONTAINED = 1805,
	[Token(Token = "0x4000C17")]
	ERROR_INVALID_PARAM = 1806,
	[Token(Token = "0x4000C18")]
	ERROR_COMPENSATION_EXCLUDE_START = 1807
}
