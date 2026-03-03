using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000271")]
public enum RdcCode
{
	[Token(Token = "0x4000DD2")]
	NONE = 0,
	[Token(Token = "0x4000DD3")]
	ERROR = 1,
	[Token(Token = "0x4000DD4")]
	FATAL = 2,
	[Token(Token = "0x4000DD5")]
	CRITICAL = 3,
	[Token(Token = "0x4000DD6")]
	INVALID_PARAM = 5000,
	[Token(Token = "0x4000DD7")]
	ERR_OUT_OF_TERM = 5001,
	[Token(Token = "0x4000DD8")]
	ERR_INVALID_MISSION_POOL = 5003
}
