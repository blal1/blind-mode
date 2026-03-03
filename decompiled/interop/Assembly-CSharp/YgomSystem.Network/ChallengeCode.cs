using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000254")]
public enum ChallengeCode
{
	[Token(Token = "0x4000C76")]
	NONE = 0,
	[Token(Token = "0x4000C77")]
	ERROR = 1,
	[Token(Token = "0x4000C78")]
	FATAL = 2,
	[Token(Token = "0x4000C79")]
	CRITICAL = 3,
	[Token(Token = "0x4000C7A")]
	INVALID_PARAM = 2300,
	[Token(Token = "0x4000C7B")]
	ERR_OUT_OF_TERM = 2301,
	[Token(Token = "0x4000C7C")]
	ERR_INVALID_MISSION_POOL = 2302
}
