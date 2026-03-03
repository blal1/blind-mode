using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000255")]
public enum SoloCode
{
	[Token(Token = "0x4000C7E")]
	NONE = 0,
	[Token(Token = "0x4000C7F")]
	ERROR = 1,
	[Token(Token = "0x4000C80")]
	FATAL = 2,
	[Token(Token = "0x4000C81")]
	CRITICAL = 3,
	[Token(Token = "0x4000C82")]
	INVALID_CHAPTER = 2400,
	[Token(Token = "0x4000C83")]
	LOCKED_CHAPTER = 2401,
	[Token(Token = "0x4000C84")]
	NPC_NOT_EXIST = 2402,
	[Token(Token = "0x4000C85")]
	STORY_DECK_NOT_EXIST = 2403,
	[Token(Token = "0x4000C86")]
	INVALID_GATE = 2405
}
