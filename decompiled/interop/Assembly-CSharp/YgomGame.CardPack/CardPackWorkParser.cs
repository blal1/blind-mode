using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.CardPack;

[Token(Token = "0x200152B")]
public static class CardPackWorkParser
{
	[Token(Token = "0x60082D3")]
	[Address(RVA = "0xCBB510", Offset = "0xCBA710", VA = "0x180CBB510")]
	public static List<object> ParseGachaDrawInfo_Packs(this Dictionary<string, object> drawInfo)
	{
		return null;
	}

	[Token(Token = "0x60082D4")]
	[Address(RVA = "0xCBB4D0", Offset = "0xCBA6D0", VA = "0x180CBB4D0")]
	public static List<object> ParseGachaDrawInfo_Packs_PackInfo(this Dictionary<string, object> packs)
	{
		return null;
	}

	[Token(Token = "0x60082D5")]
	[Address(RVA = "0xCBB490", Offset = "0xCBA690", VA = "0x180CBB490")]
	public static Dictionary<string, object> ParseGachaDrawInfo_Packs_PackInfo_Effects(this Dictionary<string, object> packInfo)
	{
		return null;
	}

	[Token(Token = "0x60082D6")]
	[Address(RVA = "0xCBB450", Offset = "0xCBA650", VA = "0x180CBB450")]
	public static List<object> ParseGachaDrawInfo_Packs_PackInfo_CardInfo(this Dictionary<string, object> packInfo)
	{
		return null;
	}

	[Token(Token = "0x60082D7")]
	[Address(RVA = "0xCBB3D0", Offset = "0xCBA5D0", VA = "0x180CBB3D0")]
	public static Dictionary<string, object> ParseGachaDrawInfo_Packs_Effects(this Dictionary<string, object> packs)
	{
		return null;
	}

	[Token(Token = "0x60082D8")]
	[Address(RVA = "0xCBB410", Offset = "0xCBA610", VA = "0x180CBB410")]
	public static Dictionary<string, object> ParseGachaDrawInfo_Packs_Options(this Dictionary<string, object> packs)
	{
		return null;
	}

	[Token(Token = "0x60082D9")]
	[Address(RVA = "0xCBB390", Offset = "0xCBA590", VA = "0x180CBB390")]
	public static string ParseGachaDrawInfo_Packs_Effects_ImageName(this Dictionary<string, object> effects)
	{
		return null;
	}

	[Token(Token = "0x60082DA")]
	[Address(RVA = "0xCBB350", Offset = "0xCBA550", VA = "0x180CBB350")]
	public static Dictionary<string, object> ParseGachaDrawInfo_Options(this Dictionary<string, object> drawInfo)
	{
		return null;
	}

	[Token(Token = "0x60082DB")]
	[Address(RVA = "0xCBB300", Offset = "0xCBA500", VA = "0x180CBB300")]
	public static bool ParseGachaDrawInfo_Options_Skippable(this Dictionary<string, object> options, bool defaultValue = true)
	{
		return default(bool);
	}

	[Token(Token = "0x60082DC")]
	[Address(RVA = "0xCBB7E0", Offset = "0xCBA9E0", VA = "0x180CBB7E0")]
	public static bool ParseGachaResult_IsSendGift(this Dictionary<string, object> packResult)
	{
		return default(bool);
	}

	[Token(Token = "0x60082DD")]
	[Address(RVA = "0xCBB8E0", Offset = "0xCBAAE0", VA = "0x180CBB8E0")]
	public static IReadOnlyList<object> ParseGachaResult_ObtainItems(this Dictionary<string, object> packResult)
	{
		return null;
	}

	[Token(Token = "0x60082DE")]
	[Address(RVA = "0xCBB820", Offset = "0xCBAA20", VA = "0x180CBB820")]
	public static bool ParseGachaResult_IsShowFoundSecret(this Dictionary<string, object> packResult)
	{
		return default(bool);
	}

	[Token(Token = "0x60082DF")]
	[Address(RVA = "0xCBB7A0", Offset = "0xCBA9A0", VA = "0x180CBB7A0")]
	public static bool ParseGachaResult_IsNextFinalizedUR(this Dictionary<string, object> packResult)
	{
		return default(bool);
	}

	[Token(Token = "0x60082E0")]
	[Address(RVA = "0xCBB550", Offset = "0xCBA750", VA = "0x180CBB550")]
	public static int ParseGachaResult_BuyCardFile(this Dictionary<string, object> packResult)
	{
		return default(int);
	}

	[Token(Token = "0x60082E1")]
	[Address(RVA = "0xCBB860", Offset = "0xCBAA60", VA = "0x180CBB860")]
	public static string ParseGachaResult_NextFinalizedURNameTextId(this Dictionary<string, object> packResult)
	{
		return null;
	}

	[Token(Token = "0x60082E2")]
	[Address(RVA = "0xCBB6A0", Offset = "0xCBA8A0", VA = "0x180CBB6A0")]
	public static List<object> ParseGachaResult_ExtraCardGroups(this Dictionary<string, object> packResult)
	{
		return null;
	}

	[Token(Token = "0x60082E3")]
	[Address(RVA = "0xCBB590", Offset = "0xCBA790", VA = "0x180CBB590")]
	public static int ParseGachaResult_ExtraCardGroup_Id(this Dictionary<string, object> extraGroup)
	{
		return default(int);
	}

	[Token(Token = "0x60082E4")]
	[Address(RVA = "0xCBB610", Offset = "0xCBA810", VA = "0x180CBB610")]
	public static string ParseGachaResult_ExtraCardGroup_LabelTextId(this Dictionary<string, object> extraGroup)
	{
		return null;
	}

	[Token(Token = "0x60082E5")]
	[Address(RVA = "0xCBB5D0", Offset = "0xCBA7D0", VA = "0x180CBB5D0")]
	public static List<object> ParseGachaResult_ExtraCardGroup_LabelArgs(this Dictionary<string, object> extraGroup)
	{
		return null;
	}

	[Token(Token = "0x60082E6")]
	[Address(RVA = "0xCBB760", Offset = "0xCBA960", VA = "0x180CBB760")]
	public static List<object> ParseGachaResult_ExtraPackGroups(this Dictionary<string, object> packResult)
	{
		return null;
	}

	[Token(Token = "0x60082E7")]
	[Address(RVA = "0xCBB720", Offset = "0xCBA920", VA = "0x180CBB720")]
	public static List<object> ParseGachaResult_ExtraPackGroups_Packs(this Dictionary<string, object> extraPackGroup)
	{
		return null;
	}

	[Token(Token = "0x60082E8")]
	[Address(RVA = "0xCBB6E0", Offset = "0xCBA8E0", VA = "0x180CBB6E0")]
	public static string ParseGachaResult_ExtraPackGroups_IconPath(this Dictionary<string, object> extraPackGroup)
	{
		return null;
	}
}
