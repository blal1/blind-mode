using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000250")]
public enum MissionCode
{
	[Token(Token = "0x4000C35")]
	NONE = 0,
	[Token(Token = "0x4000C36")]
	ERROR = 1,
	[Token(Token = "0x4000C37")]
	FATAL = 2,
	[Token(Token = "0x4000C38")]
	CRITICAL = 3,
	[Token(Token = "0x4000C39")]
	ERROR_INVALID_POOL = 2601,
	[Token(Token = "0x4000C3A")]
	ERROR_INVALID_MISSION = 2602,
	[Token(Token = "0x4000C3B")]
	ERROR_OUT_OF_TERM_POOL = 2603,
	[Token(Token = "0x4000C3C")]
	ERROR_OUT_OF_TERM_MISSION = 2604,
	[Token(Token = "0x4000C3D")]
	ERROR_GET_REWARD_MASTER = 2611,
	[Token(Token = "0x4000C3E")]
	ERROR_GET_PROGRESS = 2612,
	[Token(Token = "0x4000C3F")]
	ERROR_ALREADY_RECEIVE = 2613,
	[Token(Token = "0x4000C40")]
	ERROR_ILLEGAL_RECEIVE = 2614,
	[Token(Token = "0x4000C41")]
	ERROR_ILLEGAL_PROGRESS = 2615,
	[Token(Token = "0x4000C42")]
	ERROR_NON_APPLY_REWARD = 2616
}
