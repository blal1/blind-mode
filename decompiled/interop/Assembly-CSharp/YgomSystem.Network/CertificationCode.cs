using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200026C")]
public enum CertificationCode
{
	[Token(Token = "0x4000DA0")]
	NONE = 0,
	[Token(Token = "0x4000DA1")]
	ERROR = 1,
	[Token(Token = "0x4000DA2")]
	FATAL = 2,
	[Token(Token = "0x4000DA3")]
	CRITICAL = 3,
	[Token(Token = "0x4000DA4")]
	ERR_INVALID_PARAM = 4500,
	[Token(Token = "0x4000DA5")]
	ERR_NO_MASTER_DATA = 4501,
	[Token(Token = "0x4000DA6")]
	ERR_OVER_GRADE_CHECK = 4502
}
