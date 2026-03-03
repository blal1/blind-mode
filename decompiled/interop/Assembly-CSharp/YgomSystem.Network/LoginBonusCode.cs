using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000267")]
public enum LoginBonusCode
{
	[Token(Token = "0x4000D5F")]
	NONE = 0,
	[Token(Token = "0x4000D60")]
	ERROR = 1,
	[Token(Token = "0x4000D61")]
	FATAL = 2,
	[Token(Token = "0x4000D62")]
	CRITICAL = 3,
	[Token(Token = "0x4000D63")]
	ERR_INVALID_PARAM = 4000,
	[Token(Token = "0x4000D64")]
	ERR_INVALID_ID = 4001,
	[Token(Token = "0x4000D65")]
	ERR_INVALID_TERM = 4002,
	[Token(Token = "0x4000D66")]
	ERR_ALREADY_RECEIVED = 4003,
	[Token(Token = "0x4000D67")]
	ERR_ALREADY_COMPLETED = 4004,
	[Token(Token = "0x4000D68")]
	ERROR_IN_SHOP_MAINTE = 4005
}
