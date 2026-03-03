using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Lottery;

[Token(Token = "0x2001723")]
public class LotteryRewardViewContorller : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported, ILotteryChildViewControllerGroup
{
	[Token(Token = "0x2001726")]
	[CompilerGenerated]
	private sealed class _003CSetMMA_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400DAD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400DAD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400DAD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public LotteryRewardViewContorller _003C_003E4__this;

		[Token(Token = "0x400DAD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private BaseBlurOverlayViewController _003Ctop_003E5__2;

		[Token(Token = "0x17001650")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6009158")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001651")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600915A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6009155")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetMMA_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6009156")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6009157")]
		[Address(RVA = "0xDB9B20", Offset = "0xDB8D20", VA = "0x180DB9B20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6009159")]
		[Address(RVA = "0xDBA110", Offset = "0xDB9310", VA = "0x180DBA110", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400DAB6")]
	private const string k_PrefPath = "Lottery/LotteryReward";

	[Token(Token = "0x400DAB7")]
	private const string KEY_LOTTERY_ID = "KeyLotteryId";

	[Token(Token = "0x400DAB8")]
	private const string KEY_MMA_PATH = "KeyMMAPath";

	[Token(Token = "0x400DAB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private readonly string LABEL_MMAContainer;

	[Token(Token = "0x400DABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private readonly string LABEL_RewardContainer;

	[Token(Token = "0x400DABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string LABEL_InfoButtonTab;

	[Token(Token = "0x400DABC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string LABEL_RewardButtonTab;

	[Token(Token = "0x400DABD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x400DABE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x400DABF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private readonly string BTN_LABEL;

	[Token(Token = "0x400DAC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string BTN_ICON_LABEL;

	[Token(Token = "0x400DAC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private readonly string TXT_ORDER_LABEL;

	[Token(Token = "0x400DAC2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private readonly string TXT_DETAIL_LABEL;

	[Token(Token = "0x400DAC3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private readonly string TXT_NAME_LABEL;

	[Token(Token = "0x400DAC4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private readonly string TXT_DATE_LABEL;

	[Token(Token = "0x400DAC5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private int m_Id;

	[Token(Token = "0x400DAC6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private string m_MMAPath;

	[Token(Token = "0x400DAC7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private GameObject m_MMAContainer;

	[Token(Token = "0x400DAC8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private GameObject m_RewardContainer;

	[Token(Token = "0x400DAC9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private InfinityScrollView m_Isv;

	[Token(Token = "0x400DACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private Selector m_IsvSelector;

	[Token(Token = "0x400DACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private Selector m_TopSelector;

	[Token(Token = "0x400DACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private Selector m_FreeScrollSelector;

	[Token(Token = "0x400DACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
	private DirectionalTabGroup m_TabGroup;

	[Token(Token = "0x400DACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
	private List<SelectionItem> m_IsvEdgeSelectSearchList;

	[Token(Token = "0x400DACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
	private List<int> m_RewardTemplateList;

	[Token(Token = "0x400DAD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
	private List<EntryItemListData> m_RewardItemList;

	[Token(Token = "0x400DAD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
	private List<LotteryUtil.WinningInfo> m_WinningInfoList;

	[Token(Token = "0x1700164E")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6009144")]
		[Address(RVA = "0xDB1480", Offset = "0xDB0680", VA = "0x180DB1480", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700164F")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6009145")]
		[Address(RVA = "0xDA1B00", Offset = "0xDA0D00", VA = "0x180DA1B00", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6009146")]
	[Address(RVA = "0xDB0EB0", Offset = "0xDB00B0", VA = "0x180DB0EB0")]
	public static void Open(int id, string mmaPath, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6009147")]
	[Address(RVA = "0xDAF7A0", Offset = "0xDAE9A0", VA = "0x180DAF7A0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6009148")]
	[Address(RVA = "0xDAF840", Offset = "0xDAEA40", VA = "0x180DAF840", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6009149")]
	[Address(RVA = "0xDB06F0", Offset = "0xDAF8F0", VA = "0x180DB06F0")]
	private void OnUpdateEntity(GameObject go, int dataIndex)
	{
	}

	[Token(Token = "0x600914A")]
	[Address(RVA = "0xDB0FE0", Offset = "0xDB01E0", VA = "0x180DB0FE0")]
	[IteratorStateMachine(typeof(_003CSetMMA_003Ed__36))]
	private IEnumerator SetMMA()
	{
		return null;
	}

	[Token(Token = "0x600914B")]
	[Address(RVA = "0xDB0260", Offset = "0xDAF460", VA = "0x180DB0260")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600914C")]
	[Address(RVA = "0xDAF590", Offset = "0xDAE790", VA = "0x180DAF590")]
	private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
	{
		return null;
	}

	[Token(Token = "0x600914D")]
	[Address(RVA = "0xDB1230", Offset = "0xDB0430", VA = "0x180DB1230")]
	public LotteryRewardViewContorller()
	{
	}
}
