using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200026E")]
public enum SeasonPtCode
{
	[Token(Token = "0x4000DAF")]
	NONE = 0,
	[Token(Token = "0x4000DB0")]
	ERROR = 1,
	[Token(Token = "0x4000DB1")]
	FATAL = 2,
	[Token(Token = "0x4000DB2")]
	CRITICAL = 3,
	[Token(Token = "0x4000DB3")]
	INVALID_PARAM = 4700,
	[Token(Token = "0x4000DB4")]
	TEAM_UNIQUE_ID = 4701,
	[Token(Token = "0x4000DB5")]
	TEAM_NOT_EXIST = 4702,
	[Token(Token = "0x4000DB6")]
	TEAM_INVALID = 4703,
	[Token(Token = "0x4000DB7")]
	ALREADY_DISBAND = 4704,
	[Token(Token = "0x4000DB8")]
	ALREADY_DISBANDED = 4705,
	[Token(Token = "0x4000DB9")]
	TEAM_OUT_OF_TERM = 4706,
	[Token(Token = "0x4000DBA")]
	TEAM_EXIST = 4707
}
