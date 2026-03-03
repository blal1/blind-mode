using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200025F")]
public enum DuelpassCode
{
	[Token(Token = "0x4000CF5")]
	NONE = 0,
	[Token(Token = "0x4000CF6")]
	ERROR = 1,
	[Token(Token = "0x4000CF7")]
	FATAL = 2,
	[Token(Token = "0x4000CF8")]
	CRITICAL = 3,
	[Token(Token = "0x4000CF9")]
	ERROR_INVALID_MASTER = 3201,
	[Token(Token = "0x4000CFA")]
	ERROR_INVALID_TERM = 3202,
	[Token(Token = "0x4000CFB")]
	ERROR_INVALID_PARAM = 3203
}
