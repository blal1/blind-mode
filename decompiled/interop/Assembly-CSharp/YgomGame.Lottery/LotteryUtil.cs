using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Lottery;

[Token(Token = "0x2001729")]
public static class LotteryUtil
{
	[Token(Token = "0x200172A")]
	public struct WinningInfo
	{
		[Token(Token = "0x400DAF5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public int type;

		[Token(Token = "0x400DAF6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int grade;

		[Token(Token = "0x400DAF7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		public int backType;
	}

	[Token(Token = "0x200172B")]
	public static class API
	{
		[Token(Token = "0x6009171")]
		[Address(RVA = "0xDA80C0", Offset = "0xDA72C0", VA = "0x180DA80C0")]
		public static void HandleResultCodeLottery(Handle handle, [Optional] Action onSuccess, [Optional] Action<LotteryCode> onFailed)
		{
		}

		[Token(Token = "0x6009172")]
		[Address(RVA = "0xDA8030", Offset = "0xDA7230", VA = "0x180DA8030")]
		public static int GetNextPage(int id)
		{
			return default(int);
		}
	}

	[Token(Token = "0x200172D")]
	public static class FirstView
	{
		[Token(Token = "0x6009175")]
		[Address(RVA = "0xDA82B0", Offset = "0xDA74B0", VA = "0x180DA82B0")]
		public static List<int[]> GetCurrentSetCards(int id)
		{
			return null;
		}
	}

	[Token(Token = "0x200172F")]
	public static class History
	{
		[Token(Token = "0x6009179")]
		[Address(RVA = "0xDA8D70", Offset = "0xDA7F70", VA = "0x180DA8D70")]
		public static List<int[]> GetSelectedCards(int id, int set)
		{
			return null;
		}

		[Token(Token = "0x600917A")]
		[Address(RVA = "0xDA9120", Offset = "0xDA8320", VA = "0x180DA9120")]
		public static int[] GetSheetInfo(int id, int set)
		{
			return null;
		}

		[Token(Token = "0x600917B")]
		[Address(RVA = "0xDA8A20", Offset = "0xDA7C20", VA = "0x180DA8A20")]
		public static int[] GetResultCards(int id, int set)
		{
			return null;
		}

		[Token(Token = "0x600917C")]
		[Address(RVA = "0xDA8640", Offset = "0xDA7840", VA = "0x180DA8640")]
		public static (List<int>, List<int>) GetAllCards(int id, int set)
		{
			return default((List<int>, List<int>));
		}

		[Token(Token = "0x600917D")]
		[Address(RVA = "0xDA9620", Offset = "0xDA8820", VA = "0x180DA9620")]
		public static (int, WinningInfo) GetWinningInfo(int id, int set)
		{
			return default((int, WinningInfo));
		}

		[Token(Token = "0x600917E")]
		[Address(RVA = "0xDA93C0", Offset = "0xDA85C0", VA = "0x180DA93C0")]
		public static List<bool> GetTabInfo(int id)
		{
			return null;
		}

		[Token(Token = "0x600917F")]
		[Address(RVA = "0xDA8CC0", Offset = "0xDA7EC0", VA = "0x180DA8CC0")]
		public static int GetResultIn(int id, int set)
		{
			return default(int);
		}
	}

	[Token(Token = "0x2001731")]
	public static class Result
	{
		[Token(Token = "0x6009183")]
		[Address(RVA = "0xDB4200", Offset = "0xDB3400", VA = "0x180DB4200")]
		public static (int, WinningInfo) GetWinningInfo(int id)
		{
			return default((int, WinningInfo));
		}

		[Token(Token = "0x6009184")]
		[Address(RVA = "0xDB3C30", Offset = "0xDB2E30", VA = "0x180DB3C30")]
		public static List<int[]> GetSelectedCards(int id)
		{
			return null;
		}

		[Token(Token = "0x6009185")]
		[Address(RVA = "0xDB34D0", Offset = "0xDB26D0", VA = "0x180DB34D0")]
		public static int[] GetResultCards(int id)
		{
			return null;
		}

		[Token(Token = "0x6009186")]
		[Address(RVA = "0xDB3120", Offset = "0xDB2320", VA = "0x180DB3120")]
		public static List<int[]> GetHitEffects(int id, int index)
		{
			return null;
		}

		[Token(Token = "0x6009187")]
		[Address(RVA = "0xDB3750", Offset = "0xDB2950", VA = "0x180DB3750")]
		public static (EntryItemListData, bool) GetReward(int id)
		{
			return default((EntryItemListData, bool));
		}

		[Token(Token = "0x6009188")]
		[Address(RVA = "0xDB3FC0", Offset = "0xDB31C0", VA = "0x180DB3FC0")]
		public static int[] GetSheetEffect(int id, bool[] cardStatus)
		{
			return null;
		}

		[Token(Token = "0x6009189")]
		[Address(RVA = "0xDB3080", Offset = "0xDB2280", VA = "0x180DB3080")]
		public static string BackType2SELabel(int backType)
		{
			return null;
		}
	}

	[Token(Token = "0x2001733")]
	public static class Reward
	{
		[Token(Token = "0x600918F")]
		[Address(RVA = "0xDB49E0", Offset = "0xDB3BE0", VA = "0x180DB49E0")]
		public static List<int> GetRewardTemplateIdList(int id)
		{
			return null;
		}

		[Token(Token = "0x6009190")]
		[Address(RVA = "0xDB4430", Offset = "0xDB3630", VA = "0x180DB4430")]
		public static EntryItemListData GetItemListData(int id, int index)
		{
			return null;
		}

		[Token(Token = "0x6009191")]
		[Address(RVA = "0xDB4C40", Offset = "0xDB3E40", VA = "0x180DB4C40")]
		public static List<WinningInfo> GetWinningInfoList(int id)
		{
			return null;
		}

		[Token(Token = "0x6009192")]
		[Address(RVA = "0xDB48B0", Offset = "0xDB3AB0", VA = "0x180DB48B0")]
		public static List<EntryItemListData> GetItemListData(int id)
		{
			return null;
		}

		[Token(Token = "0x6009193")]
		[Address(RVA = "0xDB4390", Offset = "0xDB3590", VA = "0x180DB4390")]
		public static string GetDateString(int id)
		{
			return null;
		}
	}

	[Token(Token = "0x400DAF3")]
	private const string KEY_SELECTED_CARDS = "selected_cards";

	[Token(Token = "0x400DAF4")]
	public const string PATH_DETAIL_MMA = "MDMarkupAsset/Lottery/MDMarkupLotteryDetailInfo";

	[Token(Token = "0x600916B")]
	[Address(RVA = "0xDB20A0", Offset = "0xDB12A0", VA = "0x180DB20A0")]
	public static string GetClientWorkPath(int id, [Optional] string append)
	{
		return null;
	}

	[Token(Token = "0x600916C")]
	[Address(RVA = "0xDB21D0", Offset = "0xDB13D0", VA = "0x180DB21D0")]
	public static int GetSetInfo(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600916D")]
	[Address(RVA = "0xDB2140", Offset = "0xDB1340", VA = "0x180DB2140")]
	public static int GetRoundInfo(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600916E")]
	[Address(RVA = "0xDB22E0", Offset = "0xDB14E0", VA = "0x180DB22E0")]
	public static Dictionary<string, object> PackSelectedCards(int[] mrks)
	{
		return null;
	}

	[Token(Token = "0x600916F")]
	[Address(RVA = "0xDB2380", Offset = "0xDB1580", VA = "0x180DB2380")]
	public static int[] UnpackSelectedCards(Dictionary<string, object> data)
	{
		return null;
	}

	[Token(Token = "0x6009170")]
	[Address(RVA = "0xDB2260", Offset = "0xDB1460", VA = "0x180DB2260")]
	public static bool IsRelatedTransitionView(ViewController vc)
	{
		return default(bool);
	}
}
