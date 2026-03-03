using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000272")]
public enum DicerallyCode
{
	[Token(Token = "0x4000DDA")]
	NONE = 0,
	[Token(Token = "0x4000DDB")]
	ERROR = 1,
	[Token(Token = "0x4000DDC")]
	FATAL = 2,
	[Token(Token = "0x4000DDD")]
	CRITICAL = 3,
	[Token(Token = "0x4000DDE")]
	INVALID_PARAM = 5100,
	[Token(Token = "0x4000DDF")]
	ERR_OUT_OF_TERM = 5101,
	[Token(Token = "0x4000DE0")]
	ERROR_FIXED_ACCESSORY = 5102,
	[Token(Token = "0x4000DE1")]
	ERR_INVALID_MISSION_POOL = 5103,
	[Token(Token = "0x4000DE2")]
	ERROR_PROCESSING_FAILED = 5104
}
