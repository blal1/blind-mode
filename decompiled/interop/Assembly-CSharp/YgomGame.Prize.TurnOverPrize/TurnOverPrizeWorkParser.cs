using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Prize.TurnOverPrize;

[Token(Token = "0x2000BAD")]
public static class TurnOverPrizeWorkParser
{
	[Token(Token = "0x6004714")]
	[Address(RVA = "0x912D00", Offset = "0x911F00", VA = "0x180912D00")]
	public static int ParseShopId(this Dictionary<string, object> prizeData)
	{
		return default(int);
	}

	[Token(Token = "0x6004715")]
	[Address(RVA = "0x912970", Offset = "0x911B70", VA = "0x180912970")]
	public static string ParseCoverPath(this Dictionary<string, object> prizeData)
	{
		return null;
	}

	[Token(Token = "0x6004716")]
	[Address(RVA = "0x912CC0", Offset = "0x911EC0", VA = "0x180912CC0")]
	public static List<object> ParsePrizes(this Dictionary<string, object> prizeData)
	{
		return null;
	}

	[Token(Token = "0x6004717")]
	[Address(RVA = "0x912BC0", Offset = "0x911DC0", VA = "0x180912BC0")]
	public static int ParsePrizePackId(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x6004718")]
	[Address(RVA = "0x912B10", Offset = "0x911D10", VA = "0x180912B10")]
	public static string ParsePrizeNameTextId(this Dictionary<string, object> prizeRow)
	{
		return null;
	}

	[Token(Token = "0x6004719")]
	[Address(RVA = "0x912B80", Offset = "0x911D80", VA = "0x180912B80")]
	public static int ParsePrizeNormalCardListId(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x600471A")]
	[Address(RVA = "0x912C40", Offset = "0x911E40", VA = "0x180912C40")]
	public static int ParsePrizePickupCardListId(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x600471B")]
	[Address(RVA = "0x912C00", Offset = "0x911E00", VA = "0x180912C00")]
	public static string ParsePrizePackImageName(this Dictionary<string, object> prizeRow)
	{
		return null;
	}

	[Token(Token = "0x600471C")]
	[Address(RVA = "0x9129F0", Offset = "0x911BF0", VA = "0x1809129F0")]
	public static int ParsePrizeIconType(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x600471D")]
	[Address(RVA = "0x9129B0", Offset = "0x911BB0", VA = "0x1809129B0")]
	public static string ParsePrizeIconData(this Dictionary<string, object> prizeRow)
	{
		return null;
	}

	[Token(Token = "0x600471E")]
	[Address(RVA = "0x912A30", Offset = "0x911C30", VA = "0x180912A30")]
	public static bool ParsePrizeIsUnlockData(this Dictionary<string, object> prizeRow)
	{
		return default(bool);
	}

	[Token(Token = "0x600471F")]
	[Address(RVA = "0x912C80", Offset = "0x911E80", VA = "0x180912C80")]
	public static Dictionary<string, object> ParsePrizeUnlockData(this Dictionary<string, object> prizeRow)
	{
		return null;
	}

	[Token(Token = "0x6004720")]
	[Address(RVA = "0x912D80", Offset = "0x911F80", VA = "0x180912D80")]
	public static int ParseUnlockPos(this Dictionary<string, object> unlockData)
	{
		return default(int);
	}

	[Token(Token = "0x6004721")]
	[Address(RVA = "0x912D40", Offset = "0x911F40", VA = "0x180912D40")]
	public static int ParseUnlockObtainUR(this Dictionary<string, object> unlockData)
	{
		return default(int);
	}
}
