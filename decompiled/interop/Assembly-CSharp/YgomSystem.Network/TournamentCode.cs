using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200024A")]
public enum TournamentCode
{
	[Token(Token = "0x4000BDE")]
	NONE = 0,
	[Token(Token = "0x4000BDF")]
	ERROR = 1,
	[Token(Token = "0x4000BE0")]
	FATAL = 2,
	[Token(Token = "0x4000BE1")]
	CRITICAL = 3,
	[Token(Token = "0x4000BE2")]
	INVALID_PARAM = 1500,
	[Token(Token = "0x4000BE3")]
	ERR_DECK_CONFIG = 1501,
	[Token(Token = "0x4000BE4")]
	ERR_DECK_SAME_CARD = 1502,
	[Token(Token = "0x4000BE5")]
	ERR_DECK_REGULATION = 1503,
	[Token(Token = "0x4000BE6")]
	ERR_OUT_OF_TERM = 1504,
	[Token(Token = "0x4000BE7")]
	ERROR_DECK_LIMIT = 1505,
	[Token(Token = "0x4000BE8")]
	ERROR_FIXED_ACCESSORY = 1506
}
