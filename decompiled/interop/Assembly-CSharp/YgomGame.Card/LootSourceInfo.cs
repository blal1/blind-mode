using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.TextIDs;

namespace YgomGame.Card;

[Token(Token = "0x2001637")]
public class LootSourceInfo
{
	[Token(Token = "0x2001638")]
	public enum LootCategory
	{
		[Token(Token = "0x400D550")]
		Pack = 1,
		[Token(Token = "0x400D551")]
		Solo = 2,
		[Token(Token = "0x400D552")]
		Tournament = 3,
		[Token(Token = "0x400D553")]
		Exhibition = 4,
		[Token(Token = "0x400D554")]
		FreeStruct = 5,
		[Token(Token = "0x400D555")]
		PaidStruct = 6,
		[Token(Token = "0x400D556")]
		Mission = 7,
		[Token(Token = "0x400D557")]
		DuelReward = 8,
		[Token(Token = "0x400D558")]
		Set = 9,
		[Token(Token = "0x400D559")]
		PackSelection = 10,
		[Token(Token = "0x400D55A")]
		PackSecret = 11,
		[Token(Token = "0x400D55B")]
		PackBonus = 12,
		[Token(Token = "0x400D55C")]
		Etc = 99
	}

	[Token(Token = "0x400D547")]
	[FieldOffset(Offset = "0x0")]
	public static Dictionary<LootCategory, IDS_DECKEDIT> CategoryTextTbl;

	[Token(Token = "0x400D548")]
	private const string CLIENTWORK_PATH_ROUTE = "$.Route";

	[Token(Token = "0x400D549")]
	private const string KEY_CATEGORY = "route_category";

	[Token(Token = "0x400D54A")]
	private const string KEY_PARAM = "route_param";

	[Token(Token = "0x400D54B")]
	private const string KEY_OPEN = "route_open";

	[Token(Token = "0x400D54C")]
	private const string KEY_NAMEID = "route_name_id";

	[Token(Token = "0x400D54D")]
	private const string KEY_ICONTYPE = "route_icon_type";

	[Token(Token = "0x400D54E")]
	private const string KEY_ICONDATA = "route_icon_data";

	[Token(Token = "0x6008A36")]
	[Address(RVA = "0xD56E70", Offset = "0xD56070", VA = "0x180D56E70")]
	public static List<object> GetLootSource()
	{
		return null;
	}

	[Token(Token = "0x6008A37")]
	[Address(RVA = "0xD56B30", Offset = "0xD55D30", VA = "0x180D56B30")]
	public static int GetLootCategoryID(Dictionary<string, object> dic)
	{
		return default(int);
	}

	[Token(Token = "0x6008A38")]
	[Address(RVA = "0xD56ED0", Offset = "0xD560D0", VA = "0x180D56ED0")]
	public static int GetLootSubCategoryID(Dictionary<string, object> dic)
	{
		return default(int);
	}

	[Token(Token = "0x6008A39")]
	[Address(RVA = "0xD56D30", Offset = "0xD55F30", VA = "0x180D56D30")]
	public static int GetLootParam(Dictionary<string, object> dic)
	{
		return default(int);
	}

	[Token(Token = "0x6008A3A")]
	[Address(RVA = "0xD56C80", Offset = "0xD55E80", VA = "0x180D56C80")]
	public static int GetLootIconType(Dictionary<string, object> dic)
	{
		return default(int);
	}

	[Token(Token = "0x6008A3B")]
	[Address(RVA = "0xD56BF0", Offset = "0xD55DF0", VA = "0x180D56BF0")]
	public static string GetLootIconData(Dictionary<string, object> dic)
	{
		return null;
	}

	[Token(Token = "0x6008A3C")]
	[Address(RVA = "0xD56F80", Offset = "0xD56180", VA = "0x180D56F80")]
	public static bool IsLootAvailable(Dictionary<string, object> dic)
	{
		return default(bool);
	}

	[Token(Token = "0x6008A3D")]
	[Address(RVA = "0xD56DE0", Offset = "0xD55FE0", VA = "0x180D56DE0")]
	public static string GetLootSourceString(Dictionary<string, object> dic)
	{
		return null;
	}

	[Token(Token = "0x6008A3E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public LootSourceInfo()
	{
	}
}
