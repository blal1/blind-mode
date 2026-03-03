using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000273")]
public enum CardFileCode
{
	[Token(Token = "0x4000DE4")]
	NONE = 0,
	[Token(Token = "0x4000DE5")]
	ERROR = 1,
	[Token(Token = "0x4000DE6")]
	FATAL = 2,
	[Token(Token = "0x4000DE7")]
	CRITICAL = 3,
	[Token(Token = "0x4000DE8")]
	INVALID_PARAM = 5200,
	[Token(Token = "0x4000DE9")]
	ERR_ACCOUNT_NOT_EXIST = 5201,
	[Token(Token = "0x4000DEA")]
	ERR_UNDEFINED_FILE = 5202
}
