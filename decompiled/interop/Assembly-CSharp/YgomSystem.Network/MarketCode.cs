using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000277")]
public enum MarketCode
{
	[Token(Token = "0x4000E06")]
	NONE = 0,
	[Token(Token = "0x4000E07")]
	ERROR = 1,
	[Token(Token = "0x4000E08")]
	FATAL = 2,
	[Token(Token = "0x4000E09")]
	CRITICAL = 3,
	[Token(Token = "0x4000E0A")]
	INVALID_PARAM = 5700,
	[Token(Token = "0x4000E0B")]
	ERR_OUT_OF_TERM = 5701,
	[Token(Token = "0x4000E0C")]
	ERR_PROCESSING_FAILED = 5702
}
