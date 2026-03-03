using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000276")]
public enum GeneralPoolCode
{
	[Token(Token = "0x4000DFF")]
	NONE = 0,
	[Token(Token = "0x4000E00")]
	ERROR = 1,
	[Token(Token = "0x4000E01")]
	FATAL = 2,
	[Token(Token = "0x4000E02")]
	CRITICAL = 3,
	[Token(Token = "0x4000E03")]
	INVALID_PARAM = 5600,
	[Token(Token = "0x4000E04")]
	ERROR_INVALID_TERM = 5601
}
