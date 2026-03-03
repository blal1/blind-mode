using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000251")]
public enum PvPCode
{
	[Token(Token = "0x4000C44")]
	NONE = 0,
	[Token(Token = "0x4000C45")]
	ERROR = 1,
	[Token(Token = "0x4000C46")]
	FATAL = 2,
	[Token(Token = "0x4000C47")]
	CRITICAL = 3,
	[Token(Token = "0x4000C48")]
	INVALID_PARAM = 2100,
	[Token(Token = "0x4000C49")]
	ALREADY_SAVE_REPLAY = 2101,
	[Token(Token = "0x4000C4A")]
	NO_SAVE_REPLAY = 2102,
	[Token(Token = "0x4000C4B")]
	ERR_DISABLE_WATCH = 2103,
	[Token(Token = "0x4000C4C")]
	ERR_NO_DECK_DATA = 2105,
	[Token(Token = "0x4000C4D")]
	ERR_BLOCK_USER_REPLAY = 2106,
	[Token(Token = "0x4000C4E")]
	ERR_BLOCK_USER_WATCH = 2107,
	[Token(Token = "0x4000C4F")]
	SAVE_REPLAY_MAX = 2108,
	[Token(Token = "0x4000C50")]
	NO_REPLAY_DATA = 2109,
	[Token(Token = "0x4000C51")]
	TIMEOUT = 2110,
	[Token(Token = "0x4000C52")]
	NOT_FIND_FRIEND = 2111,
	[Token(Token = "0x4000C53")]
	REFUSED_FRIEND = 2112,
	[Token(Token = "0x4000C54")]
	INVALID_DECK = 2113,
	[Token(Token = "0x4000C55")]
	INVALID_PERIOD = 2114,
	[Token(Token = "0x4000C56")]
	NOT_FIND_OPPONENT = 2115,
	[Token(Token = "0x4000C57")]
	NOT_EXIST_ROOM = 2116,
	[Token(Token = "0x4000C58")]
	NOT_EXIST_ROOM_OPP = 2117,
	[Token(Token = "0x4000C59")]
	AUDIENCE_LIMIT_MAX = 2118,
	[Token(Token = "0x4000C5A")]
	NOT_EXIST_TEAM = 2119,
	[Token(Token = "0x4000C5B")]
	INVALID_TEAM_INFO = 2120,
	[Token(Token = "0x4000C5C")]
	VS_TEAM_DECIDED = 2121,
	[Token(Token = "0x4000C5D")]
	TEAM_MATCHING_CANCELED = 2122,
	[Token(Token = "0x4000C5E")]
	VS_TEAM_WAITING = 2123,
	[Token(Token = "0x4000C5F")]
	ERR_REPLAY_LOCK_MAX = 2150,
	[Token(Token = "0x4000C60")]
	ERR_REPLAY_LOCK = 2151,
	[Token(Token = "0x4000C61")]
	ERR_CROSS_PLAY_WATCH = 2152
}
