using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000264")]
public enum CupCode
{
	[Token(Token = "0x4000D1C")]
	NONE = 0,
	[Token(Token = "0x4000D1D")]
	ERROR = 1,
	[Token(Token = "0x4000D1E")]
	FATAL = 2,
	[Token(Token = "0x4000D1F")]
	CRITICAL = 3,
	[Token(Token = "0x4000D20")]
	INVALID_PARAM = 3700,
	[Token(Token = "0x4000D21")]
	ERR_OUT_OF_TERM = 3701,
	[Token(Token = "0x4000D22")]
	ERR_INVALID_MISSION_POOL = 3703
}
