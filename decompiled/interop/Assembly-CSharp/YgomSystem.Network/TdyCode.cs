using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200026D")]
public enum TdyCode
{
	[Token(Token = "0x4000DA8")]
	NONE = 0,
	[Token(Token = "0x4000DA9")]
	ERROR = 1,
	[Token(Token = "0x4000DAA")]
	FATAL = 2,
	[Token(Token = "0x4000DAB")]
	CRITICAL = 3,
	[Token(Token = "0x4000DAC")]
	INVALID_PARAM = 4600,
	[Token(Token = "0x4000DAD")]
	ERR_OUT_OF_TERM = 4601
}
