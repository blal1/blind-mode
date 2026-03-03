using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200024B")]
public enum ItemCode
{
	[Token(Token = "0x4000BEA")]
	NONE = 0,
	[Token(Token = "0x4000BEB")]
	ERROR = 1,
	[Token(Token = "0x4000BEC")]
	FATAL = 2,
	[Token(Token = "0x4000BED")]
	CRITICAL = 3,
	[Token(Token = "0x4000BEE")]
	LIMIT_NUM = 1600,
	[Token(Token = "0x4000BEF")]
	SUB = 1601
}
