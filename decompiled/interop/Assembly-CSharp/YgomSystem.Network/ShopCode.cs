using Il2CppDummyDll;

namespace YgomSystem.Network;

[Token(Token = "0x2000253")]
public enum ShopCode
{
	[Token(Token = "0x4000C6A")]
	NONE = 0,
	[Token(Token = "0x4000C6B")]
	ERROR = 1,
	[Token(Token = "0x4000C6C")]
	FATAL = 2,
	[Token(Token = "0x4000C6D")]
	CRITICAL = 3,
	[Token(Token = "0x4000C6E")]
	INVALID_PARAM = 2700,
	[Token(Token = "0x4000C6F")]
	OUT_OF_TERM = 2701,
	[Token(Token = "0x4000C70")]
	ITEMS_SHORTAGE = 2702,
	[Token(Token = "0x4000C71")]
	LIMIT_MAX = 2703,
	[Token(Token = "0x4000C72")]
	PROCESSING_FAILED = 2704,
	[Token(Token = "0x4000C73")]
	EXPIRED_COST_ITEM = 2705,
	[Token(Token = "0x4000C74")]
	UPDATE_PRODUCTS = 2706
}
