using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200025E")]
public enum ExhibitionCode
{
	[Token(Token = "0x4000CE8")]
	NONE = 0,
	[Token(Token = "0x4000CE9")]
	ERROR = 1,
	[Token(Token = "0x4000CEA")]
	FATAL = 2,
	[Token(Token = "0x4000CEB")]
	CRITICAL = 3,
	[Token(Token = "0x4000CEC")]
	INVALID_PARAM = 3000,
	[Token(Token = "0x4000CED")]
	ERR_DECK_CONFIG = 3001,
	[Token(Token = "0x4000CEE")]
	ERR_DECK_SAME_CARD = 3002,
	[Token(Token = "0x4000CEF")]
	ERR_DECK_REGULATION = 3003,
	[Token(Token = "0x4000CF0")]
	ERR_OUT_OF_TERM = 3004,
	[Token(Token = "0x4000CF1")]
	ERR_DECK_LIMIT = 3005,
	[Token(Token = "0x4000CF2")]
	ERROR_FIXED_ACCESSORY = 3006,
	[Token(Token = "0x4000CF3")]
	ERR_INVALID_MISSION_POOL = 3007
}
