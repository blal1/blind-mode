using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000252")]
public enum StructureCode
{
	[Token(Token = "0x4000C63")]
	NONE = 0,
	[Token(Token = "0x4000C64")]
	ERROR = 1,
	[Token(Token = "0x4000C65")]
	FATAL = 2,
	[Token(Token = "0x4000C66")]
	CRITICAL = 3,
	[Token(Token = "0x4000C67")]
	INVALID_PARAM = 2200,
	[Token(Token = "0x4000C68")]
	ALREADY_FIRST_SET = 2201
}
