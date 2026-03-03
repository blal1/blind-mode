using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Prize.TurnOverPrizeItem;

[Token(Token = "0x2000B95")]
public static class TurnOverPrizeWorkParser
{
	[Token(Token = "0x600468B")]
	[Address(RVA = "0x8F5CA0", Offset = "0x8F4EA0", VA = "0x1808F5CA0")]
	public static int ParseShopId(this Dictionary<string, object> prizeData)
	{
		return default(int);
	}

	[Token(Token = "0x600468C")]
	[Address(RVA = "0x8F5990", Offset = "0x8F4B90", VA = "0x1808F5990")]
	public static string ParseCoverPath(this Dictionary<string, object> prizeData)
	{
		return null;
	}

	[Token(Token = "0x600468D")]
	[Address(RVA = "0x8F5C60", Offset = "0x8F4E60", VA = "0x1808F5C60")]
	public static List<object> ParsePrizes(this Dictionary<string, object> prizeData)
	{
		return null;
	}

	[Token(Token = "0x600468E")]
	[Address(RVA = "0x8F5AA0", Offset = "0x8F4CA0", VA = "0x1808F5AA0")]
	public static int ParsePrizeItemId(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x600468F")]
	[Address(RVA = "0x8F59D0", Offset = "0x8F4BD0", VA = "0x1808F59D0")]
	public static bool ParsePrizeIsPeriod(this Dictionary<string, object> prizeRow)
	{
		return default(bool);
	}

	[Token(Token = "0x6004690")]
	[Address(RVA = "0x8F5A60", Offset = "0x8F4C60", VA = "0x1808F5A60")]
	public static int ParsePrizeItemCategory(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x6004691")]
	[Address(RVA = "0x8F5AE0", Offset = "0x8F4CE0", VA = "0x1808F5AE0")]
	public static string ParsePrizeItemLabel(this Dictionary<string, object> prizeRow, Dictionary<int, string> categorySetting, Dictionary<int, string> idSetting)
	{
		return null;
	}

	[Token(Token = "0x6004692")]
	[Address(RVA = "0x8F5C10", Offset = "0x8F4E10", VA = "0x1808F5C10")]
	public static int ParsePrizeItemNum(this Dictionary<string, object> prizeRow)
	{
		return default(int);
	}

	[Token(Token = "0x6004693")]
	[Address(RVA = "0x8F5A10", Offset = "0x8F4C10", VA = "0x1808F5A10")]
	public static bool ParsePrizeIsUnlockData(this Dictionary<string, object> prizeRow)
	{
		return default(bool);
	}

	[Token(Token = "0x6004694")]
	[Address(RVA = "0x8F5D20", Offset = "0x8F4F20", VA = "0x1808F5D20")]
	public static int ParseUnlockPos(this Dictionary<string, object> unlockData)
	{
		return default(int);
	}

	[Token(Token = "0x6004695")]
	[Address(RVA = "0x8F5CE0", Offset = "0x8F4EE0", VA = "0x1808F5CE0")]
	public static int ParseUnlockObtainUR(this Dictionary<string, object> unlockData)
	{
		return default(int);
	}
}
