using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000270")]
public enum RateDuelCode
{
	[Token(Token = "0x4000DCA")]
	NONE = 0,
	[Token(Token = "0x4000DCB")]
	ERROR = 1,
	[Token(Token = "0x4000DCC")]
	FATAL = 2,
	[Token(Token = "0x4000DCD")]
	CRITICAL = 3,
	[Token(Token = "0x4000DCE")]
	INVALID_PARAM = 4900,
	[Token(Token = "0x4000DCF")]
	ERR_OUT_OF_TERM = 4901,
	[Token(Token = "0x4000DD0")]
	ERR_INVALID_MISSION_POOL = 4902
}
