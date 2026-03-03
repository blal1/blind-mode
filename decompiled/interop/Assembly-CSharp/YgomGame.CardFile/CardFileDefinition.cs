using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.Network;

namespace YgomGame.CardFile;

[Token(Token = "0x200159C")]
public class CardFileDefinition
{
	[Token(Token = "0x200159D")]
	public enum OpenType
	{
		[Token(Token = "0x400CDF8")]
		User,
		[Token(Token = "0x400CDF9")]
		Friend,
		[Token(Token = "0x400CDFA")]
		Shop,
		[Token(Token = "0x400CDFB")]
		Return
	}

	[Token(Token = "0x200159E")]
	public enum SortTyp
	{
		[Token(Token = "0x400CDFD")]
		DEFAULT,
		[Token(Token = "0x400CDFE")]
		PREMIUM_ASC,
		[Token(Token = "0x400CDFF")]
		PREMIUM_DESC,
		[Token(Token = "0x400CE00")]
		RARE_ASC,
		[Token(Token = "0x400CE01")]
		RARE_DESC
	}

	[Token(Token = "0x200159F")]
	public enum Location
	{
		[Token(Token = "0x400CE03")]
		Left,
		[Token(Token = "0x400CE04")]
		Right,
		[Token(Token = "0x400CE05")]
		Max
	}

	[Token(Token = "0x20015A0")]
	public enum PremiumType
	{
		[Token(Token = "0x400CE07")]
		None,
		[Token(Token = "0x400CE08")]
		Basic,
		[Token(Token = "0x400CE09")]
		Shine,
		[Token(Token = "0x400CE0A")]
		Royal,
		[Token(Token = "0x400CE0B")]
		ShineMore,
		[Token(Token = "0x400CE0C")]
		Max
	}

	[Token(Token = "0x20015A1")]
	public enum CardPosition
	{
		[Token(Token = "0x400CE0E")]
		Position_0_0,
		[Token(Token = "0x400CE0F")]
		Position_0_1,
		[Token(Token = "0x400CE10")]
		Position_0_2,
		[Token(Token = "0x400CE11")]
		Position_1_0,
		[Token(Token = "0x400CE12")]
		Position_1_1,
		[Token(Token = "0x400CE13")]
		Position_1_2,
		[Token(Token = "0x400CE14")]
		Position_2_0,
		[Token(Token = "0x400CE15")]
		Position_2_1,
		[Token(Token = "0x400CE16")]
		Position_2_2,
		[Token(Token = "0x400CE17")]
		Position_0_3,
		[Token(Token = "0x400CE18")]
		Position_0_4,
		[Token(Token = "0x400CE19")]
		Position_0_5,
		[Token(Token = "0x400CE1A")]
		Position_1_3,
		[Token(Token = "0x400CE1B")]
		Position_1_4,
		[Token(Token = "0x400CE1C")]
		Position_1_5,
		[Token(Token = "0x400CE1D")]
		Position_2_3,
		[Token(Token = "0x400CE1E")]
		Position_2_4,
		[Token(Token = "0x400CE1F")]
		Position_2_5,
		[Token(Token = "0x400CE20")]
		Max
	}

	[Token(Token = "0x400CDE9")]
	public const string CW_CARDFILE_LABEL = "$.Master.CardFile";

	[Token(Token = "0x400CDEA")]
	public const string CARDFILE_3D_GROUP_LABEL = "CardFile3D";

	[Token(Token = "0x400CDEB")]
	public const string CARDFILE_SELECTOR_PATH = "Prefabs/CardFile/CardFileSelector";

	[Token(Token = "0x400CDEC")]
	public const string k_SECategory = "SE_CFILE";

	[Token(Token = "0x400CDED")]
	public const string k_ArgKeyPcode = "pcode";

	[Token(Token = "0x400CDEE")]
	public const string k_ArgKeyOpenType = "openType";

	[Token(Token = "0x400CDEF")]
	public const string k_ArgKeyItemId = "itemId";

	[Token(Token = "0x400CDF0")]
	public const int PageSetCardNum = 9;

	[Token(Token = "0x400CDF1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static int CardFileSelectorPriority;

	[Token(Token = "0x400CDF2")]
	public const int CardFileCoverNum = 2;

	[Token(Token = "0x400CDF3")]
	public const int CardFileTableViewPage = 4;

	[Token(Token = "0x400CDF4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public static Vector2 min;

	[Token(Token = "0x400CDF5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC")]
	public static Vector2 middle;

	[Token(Token = "0x400CDF6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public static Vector2 max;

	[Token(Token = "0x17001493")]
	public static int CardFileModelSelectorPriority
	{
		[Token(Token = "0x60085E7")]
		[Address(RVA = "0xCEB480", Offset = "0xCEA680", VA = "0x180CEB480")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60085E8")]
	[Address(RVA = "0xCEB1B0", Offset = "0xCEA3B0", VA = "0x180CEB1B0")]
	public static void HandleResultCode(Handle handle, [Optional] Action onSuccess, [Optional] Action<CardFileCode> onFailed)
	{
	}

	[Token(Token = "0x60085E9")]
	[Address(RVA = "0xCEB290", Offset = "0xCEA490", VA = "0x180CEB290")]
	public static void OpenFirstVisitMenu()
	{
	}

	[Token(Token = "0x60085EA")]
	[Address(RVA = "0xCEB0E0", Offset = "0xCEA2E0", VA = "0x180CEB0E0")]
	public static SortComparer.Sorter GetSortType(int sortNumber)
	{
		return default(SortComparer.Sorter);
	}

	[Token(Token = "0x60085EB")]
	[Address(RVA = "0xCEB080", Offset = "0xCEA280", VA = "0x180CEB080")]
	public static int GetSortNumber(SortComparer.Sorter sorter)
	{
		return default(int);
	}

	[Token(Token = "0x60085EC")]
	[Address(RVA = "0xCEB000", Offset = "0xCEA200", VA = "0x180CEB000")]
	public static int GetRowNumber(int index)
	{
		return default(int);
	}

	[Token(Token = "0x60085ED")]
	[Address(RVA = "0xCEAF40", Offset = "0xCEA140", VA = "0x180CEAF40")]
	public static int GetRowNumber(CardPosition pos)
	{
		return default(int);
	}

	[Token(Token = "0x60085EE")]
	[Address(RVA = "0xCEAA00", Offset = "0xCE9C00", VA = "0x180CEAA00")]
	public static int GetLineNumber(Location loc, int index)
	{
		return default(int);
	}

	[Token(Token = "0x60085EF")]
	[Address(RVA = "0xCEAA40", Offset = "0xCE9C40", VA = "0x180CEAA40")]
	public static int GetLineNumber(CardPosition pos)
	{
		return default(int);
	}

	[Token(Token = "0x60085F0")]
	[Address(RVA = "0xCEAB00", Offset = "0xCE9D00", VA = "0x180CEAB00")]
	public static CardPosition GetLocToPosition(Location loc, int index)
	{
		return default(CardPosition);
	}

	[Token(Token = "0x60085F1")]
	[Address(RVA = "0xCEACE0", Offset = "0xCE9EE0", VA = "0x180CEACE0")]
	public static Location GetLocation(CardPosition pos)
	{
		return default(Location);
	}

	[Token(Token = "0x60085F2")]
	[Address(RVA = "0xCEADA0", Offset = "0xCE9FA0", VA = "0x180CEADA0")]
	public static CardPosition GetNearLine(CardPosition currentPos, CardPosition pos1, CardPosition pos2)
	{
		return default(CardPosition);
	}

	[Token(Token = "0x60085F3")]
	[Address(RVA = "0xCEAE70", Offset = "0xCEA070", VA = "0x180CEAE70")]
	public static CardPosition GetNearRow(CardPosition currentPos, CardPosition pos1, CardPosition pos2)
	{
		return default(CardPosition);
	}

	[Token(Token = "0x60085F4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardFileDefinition()
	{
	}
}
