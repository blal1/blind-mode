using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x20009AD")]
public static class ShopExchangeUtil
{
	[Token(Token = "0x6003B15")]
	[Address(RVA = "0x819F50", Offset = "0x819150", VA = "0x180819F50")]
	public static string MakeExchangeCardName(ProductContext productContext, bool withNum = false)
	{
		return null;
	}

	[Token(Token = "0x6003B16")]
	[Address(RVA = "0x819F90", Offset = "0x819190", VA = "0x180819F90")]
	private static string MakeExchangeItemName(Dictionary<string, object> itemInfo, bool withNum = false)
	{
		return null;
	}

	[Token(Token = "0x6003B17")]
	[Address(RVA = "0x81A0F0", Offset = "0x8192F0", VA = "0x18081A0F0")]
	public static string MakeExchangeProductName(ProductContext productContext, PriceContext priceContext, bool withNum = false)
	{
		return null;
	}

	[Token(Token = "0x6003B18")]
	[Address(RVA = "0x8197F0", Offset = "0x8189F0", VA = "0x1808197F0")]
	public static bool HandleExchangeUrlScheme(string[] paths, Dictionary<string, object> args, object context)
	{
		return default(bool);
	}

	[Token(Token = "0x6003B19")]
	[Address(RVA = "0x81A340", Offset = "0x819540", VA = "0x18081A340")]
	private static void OpenExchangeResultDialog([Optional] Action onFinished)
	{
	}
}
