using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000260")]
public enum DuelLiveCode
{
	[Token(Token = "0x4000CFD")]
	NONE = 0,
	[Token(Token = "0x4000CFE")]
	ERROR = 1,
	[Token(Token = "0x4000CFF")]
	FATAL = 2,
	[Token(Token = "0x4000D00")]
	CRITICAL = 3,
	[Token(Token = "0x4000D01")]
	PLAYBACK_FAIL = 3301,
	[Token(Token = "0x4000D02")]
	IN_PREPARATION = 3302,
	[Token(Token = "0x4000D03")]
	DISP_DECK_FAIL = 3303,
	[Token(Token = "0x4000D04")]
	ADJUST_MENU_FAIL = 3304
}
