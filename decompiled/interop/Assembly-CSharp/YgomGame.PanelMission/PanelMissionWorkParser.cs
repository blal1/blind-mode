using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.PanelMission;

[Token(Token = "0x2000C29")]
public static class PanelMissionWorkParser
{
	[Token(Token = "0x6004A35")]
	[Address(RVA = "0x944980", Offset = "0x943B80", VA = "0x180944980")]
	public static Dictionary<string, object> ParseAllMaster_At(this Dictionary<string, object> data, int missionId)
	{
		return null;
	}

	[Token(Token = "0x6004A36")]
	[Address(RVA = "0x9449B0", Offset = "0x943BB0", VA = "0x1809449B0")]
	public static Dictionary<string, object> ParseAllMaster_At(this Dictionary<string, object> data, string missionIdKey)
	{
		return null;
	}

	[Token(Token = "0x6004A37")]
	[Address(RVA = "0x944E40", Offset = "0x944040", VA = "0x180944E40")]
	public static string ParseMaster_Label(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A38")]
	[Address(RVA = "0x944F80", Offset = "0x944180", VA = "0x180944F80")]
	public static long ParseMaster_Root_EndTs(this Dictionary<string, object> data)
	{
		return default(long);
	}

	[Token(Token = "0x6004A39")]
	[Address(RVA = "0x944FC0", Offset = "0x9441C0", VA = "0x180944FC0")]
	public static long ParseMaster_Root_ResultEndTs(this Dictionary<string, object> data)
	{
		return default(long);
	}

	[Token(Token = "0x6004A3A")]
	[Address(RVA = "0x944F00", Offset = "0x944100", VA = "0x180944F00")]
	public static Dictionary<string, object> ParseMaster_Missions(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A3B")]
	[Address(RVA = "0x944CC0", Offset = "0x943EC0", VA = "0x180944CC0")]
	public static int ParseMaster_Category(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A3C")]
	[Address(RVA = "0x944E80", Offset = "0x944080", VA = "0x180944E80")]
	public static int ParseMaster_LogicId(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A3D")]
	[Address(RVA = "0x944EC0", Offset = "0x9440C0", VA = "0x180944EC0")]
	public static List<object> ParseMaster_LogicParams(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A3E")]
	[Address(RVA = "0x944E00", Offset = "0x944000", VA = "0x180944E00")]
	public static string ParseMaster_HintSfx(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A3F")]
	[Address(RVA = "0x944D00", Offset = "0x943F00", VA = "0x180944D00")]
	public static long ParseMaster_EndTs(this Dictionary<string, object> data)
	{
		return default(long);
	}

	[Token(Token = "0x6004A40")]
	[Address(RVA = "0x944F40", Offset = "0x944140", VA = "0x180944F40")]
	public static long ParseMaster_ResultEndTs(this Dictionary<string, object> data)
	{
		return default(long);
	}

	[Token(Token = "0x6004A41")]
	[Address(RVA = "0x944D40", Offset = "0x943F40", VA = "0x180944D40")]
	public static Dictionary<string, object> ParseMaster_Goal(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A42")]
	[Address(RVA = "0x944C80", Offset = "0x943E80", VA = "0x180944C80")]
	public static int ParseGoals_Requirement(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A43")]
	[Address(RVA = "0x944B80", Offset = "0x943D80", VA = "0x180944B80")]
	public static bool ParseGoals_IsPeriod(this Dictionary<string, object> data)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A44")]
	[Address(RVA = "0x944BC0", Offset = "0x943DC0", VA = "0x180944BC0")]
	public static int ParseGoals_ItemCategory(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A45")]
	[Address(RVA = "0x944C40", Offset = "0x943E40", VA = "0x180944C40")]
	public static int ParseGoals_ItemId(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A46")]
	[Address(RVA = "0x944C00", Offset = "0x943E00", VA = "0x180944C00")]
	public static int ParseGoals_ItemCount(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A47")]
	[Address(RVA = "0x944980", Offset = "0x943B80", VA = "0x180944980")]
	public static Dictionary<string, object> ParseAllData_At(this Dictionary<string, object> data, int missionId)
	{
		return null;
	}

	[Token(Token = "0x6004A48")]
	[Address(RVA = "0x944B00", Offset = "0x943D00", VA = "0x180944B00")]
	public static int ParseData_PoolId(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A49")]
	[Address(RVA = "0x944AC0", Offset = "0x943CC0", VA = "0x180944AC0")]
	public static int ParseData_MissionId(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A4A")]
	[Address(RVA = "0x944B40", Offset = "0x943D40", VA = "0x180944B40")]
	public static int ParseData_Progress(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A4B")]
	[Address(RVA = "0x9449C0", Offset = "0x943BC0", VA = "0x1809449C0")]
	public static Dictionary<string, object> ParseData_Goal(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A4C")]
	[Address(RVA = "0x944A80", Offset = "0x943C80", VA = "0x180944A80")]
	public static bool ParseData_Goals_Receivable(this Dictionary<string, object> data)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A4D")]
	[Address(RVA = "0x945140", Offset = "0x944340", VA = "0x180945140")]
	public static List<object> ParseReceive_TotalItems(this Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6004A4E")]
	[Address(RVA = "0x945040", Offset = "0x944240", VA = "0x180945040")]
	public static bool ParseReceive_TotalItems_IsPeriod(this Dictionary<string, object> data)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A4F")]
	[Address(RVA = "0x945080", Offset = "0x944280", VA = "0x180945080")]
	public static int ParseReceive_TotalItems_ItemCategory(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A50")]
	[Address(RVA = "0x9450C0", Offset = "0x9442C0", VA = "0x1809450C0")]
	public static int ParseReceive_TotalItems_ItemId(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A51")]
	[Address(RVA = "0x945100", Offset = "0x944300", VA = "0x180945100")]
	public static int ParseReceive_TotalItems_Num(this Dictionary<string, object> data)
	{
		return default(int);
	}

	[Token(Token = "0x6004A52")]
	[Address(RVA = "0x945000", Offset = "0x944200", VA = "0x180945000")]
	public static bool ParseReceive_IsPresentSend(this Dictionary<string, object> data)
	{
		return default(bool);
	}
}
