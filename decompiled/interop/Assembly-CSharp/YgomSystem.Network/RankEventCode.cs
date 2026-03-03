using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000263")]
public enum RankEventCode
{
	[Token(Token = "0x4000D14")]
	NONE = 0,
	[Token(Token = "0x4000D15")]
	ERROR = 1,
	[Token(Token = "0x4000D16")]
	FATAL = 2,
	[Token(Token = "0x4000D17")]
	CRITICAL = 3,
	[Token(Token = "0x4000D18")]
	INVALID_PARAM = 3600,
	[Token(Token = "0x4000D19")]
	ERR_OUT_OF_TERM = 3601,
	[Token(Token = "0x4000D1A")]
	ERROR_FIXED_ACCESSORY = 3602
}
