using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000262")]
public enum CasualCode
{
	[Token(Token = "0x4000D0D")]
	NONE = 0,
	[Token(Token = "0x4000D0E")]
	ERROR = 1,
	[Token(Token = "0x4000D0F")]
	FATAL = 2,
	[Token(Token = "0x4000D10")]
	CRITICAL = 3,
	[Token(Token = "0x4000D11")]
	INVALID_PARAM = 3500,
	[Token(Token = "0x4000D12")]
	ERR_OUT_OF_TERM = 3501
}
