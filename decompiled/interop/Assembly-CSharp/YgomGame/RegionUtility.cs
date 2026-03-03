using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x2000702")]
public static class RegionUtility
{
	[Token(Token = "0x170005BB")]
	public static int OtherCountryCode
	{
		[Token(Token = "0x6002E6B")]
		[Address(RVA = "0x721250", Offset = "0x720450", VA = "0x180721250")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005BC")]
	public static int JapanCountryCode
	{
		[Token(Token = "0x6002E6C")]
		[Address(RVA = "0x721240", Offset = "0x720440", VA = "0x180721240")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170005BD")]
	public static int USACountryCode
	{
		[Token(Token = "0x6002E6D")]
		[Address(RVA = "0x721260", Offset = "0x720460", VA = "0x180721260")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002E6E")]
	[Address(RVA = "0x721280", Offset = "0x720480", VA = "0x180721280")]
	public static bool isOther(int code)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E6F")]
	[Address(RVA = "0x721270", Offset = "0x720470", VA = "0x180721270")]
	public static bool isJapan(int code)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E70")]
	[Address(RVA = "0x721290", Offset = "0x720490", VA = "0x180721290")]
	public static bool isUSA(int code)
	{
		return default(bool);
	}
}
