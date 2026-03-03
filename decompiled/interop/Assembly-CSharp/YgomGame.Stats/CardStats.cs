using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Stats;

[Token(Token = "0x200087B")]
public class CardStats
{
	[Token(Token = "0x6003364")]
	[Address(RVA = "0x768160", Offset = "0x767360", VA = "0x180768160")]
	public static bool IsAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x6003365")]
	[Address(RVA = "0x7678E0", Offset = "0x766AE0", VA = "0x1807678E0")]
	public static string GetItemString(int Item)
	{
		return null;
	}

	[Token(Token = "0x6003366")]
	[Address(RVA = "0x767AD0", Offset = "0x766CD0", VA = "0x180767AD0")]
	public static string GetItemUnitString(int Item, double fValue)
	{
		return null;
	}

	[Token(Token = "0x6003367")]
	[Address(RVA = "0x7677F0", Offset = "0x7669F0", VA = "0x1807677F0")]
	public static string GetItemSortType(int Item)
	{
		return null;
	}

	[Token(Token = "0x6003368")]
	[Address(RVA = "0x767E50", Offset = "0x767050", VA = "0x180767E50")]
	public static List<double> GetItemUnitThreshold(int Item)
	{
		return null;
	}

	[Token(Token = "0x6003369")]
	[Address(RVA = "0x767310", Offset = "0x766510", VA = "0x180767310")]
	public static List<CardStatsData> GetCardStatsData(int mrk)
	{
		return null;
	}

	[Token(Token = "0x600336A")]
	[Address(RVA = "0x766F10", Offset = "0x766110", VA = "0x180766F10")]
	public static void DebugString(int mrk)
	{
	}

	[Token(Token = "0x600336B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardStats()
	{
	}
}
