using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.CardFile;

[Token(Token = "0x20015B7")]
public class CardFileUtil
{
	[Token(Token = "0x600868B")]
	[Address(RVA = "0xCF3400", Offset = "0xCF2600", VA = "0x180CF3400")]
	public static CardFileInfo GenerateMyCardFileInfo(int cardFileItemID)
	{
		return null;
	}

	[Token(Token = "0x600868C")]
	[Address(RVA = "0xCF3160", Offset = "0xCF2360", VA = "0x180CF3160")]
	public static CardFileInfo GenerateFriendCardFileInfo(int cardFileItemID)
	{
		return null;
	}

	[Token(Token = "0x600868D")]
	[Address(RVA = "0xCF3650", Offset = "0xCF2850", VA = "0x180CF3650")]
	public static CardFileInfo GenerateShopCardFileInfo(int cardFileItemID)
	{
		return null;
	}

	[Token(Token = "0x600868E")]
	[Address(RVA = "0xCF3310", Offset = "0xCF2510", VA = "0x180CF3310")]
	public static CardFileInfo GenerateMasterCardFileInfo(int cardFileItemID)
	{
		return null;
	}

	[Token(Token = "0x600868F")]
	[Address(RVA = "0xCF2E80", Offset = "0xCF2080", VA = "0x180CF2E80")]
	private static CardFileInfo GenerateCardFileInfo(Dictionary<string, object> cardListDir)
	{
		return null;
	}

	[Token(Token = "0x6008690")]
	[Address(RVA = "0xCF2A50", Offset = "0xCF1C50", VA = "0x180CF2A50")]
	private static CardFileInfo GenerateCardFileInfo(Dictionary<string, object> masterCardListDir, Dictionary<string, object> userCardListDir)
	{
		return null;
	}

	[Token(Token = "0x6008691")]
	[Address(RVA = "0xCF2630", Offset = "0xCF1830", VA = "0x180CF2630")]
	private static CardFileInfo GenerateCardFileInfoFromShop(Dictionary<string, object> masterCardListDir)
	{
		return null;
	}

	[Token(Token = "0x6008692")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardFileUtil()
	{
	}
}
