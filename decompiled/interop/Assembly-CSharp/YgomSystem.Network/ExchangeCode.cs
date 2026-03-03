using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000275")]
public enum ExchangeCode
{
	[Token(Token = "0x4000DF4")]
	NONE = 0,
	[Token(Token = "0x4000DF5")]
	ERROR = 1,
	[Token(Token = "0x4000DF6")]
	FATAL = 2,
	[Token(Token = "0x4000DF7")]
	CRITICAL = 3,
	[Token(Token = "0x4000DF8")]
	INVALID_PARAM = 5500,
	[Token(Token = "0x4000DF9")]
	OUT_OF_TERM = 5501,
	[Token(Token = "0x4000DFA")]
	ITEMS_SHORTAGE = 5502,
	[Token(Token = "0x4000DFB")]
	LIMIT_MAX = 5503,
	[Token(Token = "0x4000DFC")]
	PROCESSING_FAILED = 5504,
	[Token(Token = "0x4000DFD")]
	EXPIRED_COST_ITEM = 5505
}
