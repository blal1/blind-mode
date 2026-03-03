using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x200024F")]
public enum FriendCode
{
	[Token(Token = "0x4000C23")]
	NONE = 0,
	[Token(Token = "0x4000C24")]
	ERROR = 1,
	[Token(Token = "0x4000C25")]
	FATAL = 2,
	[Token(Token = "0x4000C26")]
	CRITICAL = 3,
	[Token(Token = "0x4000C27")]
	INVALID_PARAM = 2000,
	[Token(Token = "0x4000C28")]
	ACCOUNT_NOT_EXIST = 2001,
	[Token(Token = "0x4000C29")]
	ACCOUNT_OWN = 2002,
	[Token(Token = "0x4000C2A")]
	ALREADY_FOLLOWED = 2003,
	[Token(Token = "0x4000C2B")]
	NO_FOLLOW_ACCOUNT = 2004,
	[Token(Token = "0x4000C2C")]
	FOLLOW_MAX = 2005,
	[Token(Token = "0x4000C2D")]
	SAME_VALUE = 2006,
	[Token(Token = "0x4000C2E")]
	ALREADY_BLOCKED = 2007,
	[Token(Token = "0x4000C2F")]
	NO_BLOCK_ACCOUNT = 2008,
	[Token(Token = "0x4000C30")]
	BLOCK_MAX = 2009,
	[Token(Token = "0x4000C31")]
	BLOCK_USER = 2010,
	[Token(Token = "0x4000C32")]
	PS_BLOCK_USER = 2011,
	[Token(Token = "0x4000C33")]
	XBOX_BLOCK_USER = 2012
}
