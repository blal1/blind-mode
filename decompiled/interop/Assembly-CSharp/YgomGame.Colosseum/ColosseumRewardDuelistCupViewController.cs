using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CB7")]
public class ColosseumRewardDuelistCupViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001CB8")]
	internal abstract class ModeBehaviour
	{
		[Token(Token = "0x401007E")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x401007F")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string BTN_ICON_LABEL;

		[Token(Token = "0x4010080")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string IMG_LINE_LABEL;

		[Token(Token = "0x4010081")]
		[FieldOffset(Offset = "0x28")]
		protected readonly string TXT_ORDER_LABEL;

		[Token(Token = "0x4010082")]
		[FieldOffset(Offset = "0x30")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x4010083")]
		[FieldOffset(Offset = "0x38")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x4010084")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string TXT_DATE_LABEL;

		[Token(Token = "0x4010085")]
		[FieldOffset(Offset = "0x48")]
		protected readonly string TXT_EXPLAIN_LABEL;

		[Token(Token = "0x4010086")]
		[FieldOffset(Offset = "0x50")]
		protected readonly string IMG_RECEIVED_LABEL;

		[Token(Token = "0x4010087")]
		[FieldOffset(Offset = "0x58")]
		protected readonly ColosseumRewardDuelistCupViewController vc;

		[Token(Token = "0x4010088")]
		[FieldOffset(Offset = "0x60")]
		protected readonly InfinityScrollView isv;

		[Token(Token = "0x4010089")]
		[FieldOffset(Offset = "0x68")]
		protected readonly ElementObjectManager eom;

		[Token(Token = "0x401008A")]
		[FieldOffset(Offset = "0x70")]
		protected readonly int id;

		[Token(Token = "0x401008B")]
		[FieldOffset(Offset = "0x74")]
		protected ColosseumUtil.PlayMode mode;

		[Token(Token = "0x401008C")]
		[FieldOffset(Offset = "0x78")]
		private int m_CurrentTabIndex;

		[Token(Token = "0x401008D")]
		[FieldOffset(Offset = "0x7C")]
		private int m_TabTotalNum;

		[Token(Token = "0x17001BEC")]
		public int CurrentTabIndex
		{
			[Token(Token = "0x600B9F8")]
			[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600B9F9")]
			[Address(RVA = "0x55E600", Offset = "0x55D800", VA = "0x18055E600")]
			protected set
			{
			}
		}

		[Token(Token = "0x17001BED")]
		public int TabTotalNum
		{
			[Token(Token = "0x600B9FA")]
			[Address(RVA = "0x55E5F0", Offset = "0x55D7F0", VA = "0x18055E5F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600B9FB")]
			[Address(RVA = "0x55E610", Offset = "0x55D810", VA = "0x18055E610")]
			set
			{
			}
		}

		[Token(Token = "0x600B9FC")]
		[Address(RVA = "0x55E3E0", Offset = "0x55D5E0", VA = "0x18055E3E0")]
		protected ModeBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, int defaultTabIndex, ColosseumUtil.PlayMode mode)
		{
		}

		[Token(Token = "0x600B9FD")]
		internal abstract void CallAPI();

		[Token(Token = "0x600B9FE")]
		internal abstract void UpdateView();

		[Token(Token = "0x600B9FF")]
		internal abstract void SetTabIndex(int tabIndex);

		[Token(Token = "0x600BA00")]
		internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

		[Token(Token = "0x600BA01")]
		internal abstract void InitializeScroll();

		[Token(Token = "0x600BA02")]
		internal abstract int GetFocusIndex();

		[Token(Token = "0x600BA03")]
		[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
		internal ColosseumUtil.PlayMode GetMode()
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x2001CB9")]
	internal class DuelistCupBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001CBA")]
		private class Data
		{
			[Token(Token = "0x4010093")]
			[FieldOffset(Offset = "0x10")]
			internal List<ItemDataDC> itemDatas;

			[Token(Token = "0x4010094")]
			[FieldOffset(Offset = "0x18")]
			internal int indexNum;

			[Token(Token = "0x4010095")]
			[FieldOffset(Offset = "0x1C")]
			internal int indexNextNum;

			[Token(Token = "0x600BA12")]
			[Address(RVA = "0x558130", Offset = "0x557330", VA = "0x180558130")]
			public Data(int indexNum)
			{
			}
		}

		[Token(Token = "0x2001CBB")]
		private class ItemData
		{
			[Token(Token = "0x4010096")]
			[FieldOffset(Offset = "0x10")]
			internal int itemID;

			[Token(Token = "0x4010097")]
			[FieldOffset(Offset = "0x14")]
			internal int quantity;

			[Token(Token = "0x600BA13")]
			[Address(RVA = "0x55DEE0", Offset = "0x55D0E0", VA = "0x18055DEE0")]
			public ItemData(int itemID, int quantity)
			{
			}
		}

		[Token(Token = "0x2001CBC")]
		private class ItemDataDC
		{
			[Token(Token = "0x4010098")]
			[FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x4010099")]
			[FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x401009A")]
			[FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x401009B")]
			[FieldOffset(Offset = "0x1C")]
			public int needDlv;

			[Token(Token = "0x401009C")]
			[FieldOffset(Offset = "0x20")]
			public bool isPeriod;

			[Token(Token = "0x401009D")]
			[FieldOffset(Offset = "0x21")]
			public bool focus;

			[Token(Token = "0x401009E")]
			[FieldOffset(Offset = "0x22")]
			public bool received;

			[Token(Token = "0x600BA14")]
			[Address(RVA = "0x558010", Offset = "0x557210", VA = "0x180558010")]
			public ItemDataDC(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x401008E")]
		[FieldOffset(Offset = "0x80")]
		private List<Data> dataList;

		[Token(Token = "0x401008F")]
		[FieldOffset(Offset = "0x88")]
		private int rewardDlv;

		[Token(Token = "0x4010090")]
		[FieldOffset(Offset = "0x8C")]
		private int maxDLv;

		[Token(Token = "0x4010091")]
		[FieldOffset(Offset = "0x90")]
		private string txtEndDate;

		[Token(Token = "0x4010092")]
		[FieldOffset(Offset = "0x98")]
		private string txtEndDateResult;

		[Token(Token = "0x600BA04")]
		[Address(RVA = "0x55CDF0", Offset = "0x55BFF0", VA = "0x18055CDF0")]
		public DuelistCupBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, int defaultTabIndex, ColosseumUtil.PlayMode mode)
		{
		}

		[Token(Token = "0x600BA05")]
		[Address(RVA = "0x55BD00", Offset = "0x55AF00", VA = "0x18055BD00", Slot = "10")]
		protected virtual void SetTabLabel(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x600BA06")]
		[Address(RVA = "0x55B380", Offset = "0x55A580", VA = "0x18055B380", Slot = "11")]
		protected virtual string GetIdsRewardsInfoSecond()
		{
			return null;
		}

		[Token(Token = "0x600BA07")]
		[Address(RVA = "0x558260", Offset = "0x557460", VA = "0x180558260", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600BA08")]
		[Address(RVA = "0x55B3E0", Offset = "0x55A5E0", VA = "0x18055B3E0", Slot = "8")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600BA09")]
		[Address(RVA = "0x55D280", Offset = "0x55C480", VA = "0x18055D280")]
		private string orderTextConvert(Data data, bool isSingleRank = false, int nextIndexNum = -1)
		{
			return null;
		}

		[Token(Token = "0x600BA0A")]
		[Address(RVA = "0x55B4D0", Offset = "0x55A6D0", VA = "0x18055B4D0", Slot = "7")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600BA0B")]
		[Address(RVA = "0x55BBE0", Offset = "0x55ADE0", VA = "0x18055BBE0", Slot = "6")]
		internal override void SetTabIndex(int tabIndex)
		{
		}

		[Token(Token = "0x600BA0C")]
		[Address(RVA = "0x55BF20", Offset = "0x55B120", VA = "0x18055BF20", Slot = "12")]
		internal virtual void UpdateRewardInfo(int tabIndex)
		{
		}

		[Token(Token = "0x600BA0D")]
		[Address(RVA = "0x55BE20", Offset = "0x55B020", VA = "0x18055BE20")]
		internal void UpdateDateTxt(int tabIndex)
		{
		}

		[Token(Token = "0x600BA0E")]
		[Address(RVA = "0x55C010", Offset = "0x55B210", VA = "0x18055C010", Slot = "5")]
		internal override void UpdateView()
		{
		}

		[Token(Token = "0x600BA0F")]
		[Address(RVA = "0x55B080", Offset = "0x55A280", VA = "0x18055B080")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
		{
			return null;
		}

		[Token(Token = "0x600BA10")]
		[Address(RVA = "0x55B280", Offset = "0x55A480", VA = "0x18055B280", Slot = "9")]
		internal override int GetFocusIndex()
		{
			return default(int);
		}
	}

	[Token(Token = "0x2001CBF")]
	internal class WCSBehaviour : DuelistCupBehaviour
	{
		[Token(Token = "0x600BA1B")]
		[Address(RVA = "0x55E730", Offset = "0x55D930", VA = "0x18055E730")]
		public WCSBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, int defaultTabIndex, ColosseumUtil.PlayMode mode)
		{
		}

		[Token(Token = "0x600BA1C")]
		[Address(RVA = "0x5628D0", Offset = "0x561AD0", VA = "0x1805628D0", Slot = "10")]
		protected override void SetTabLabel(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x600BA1D")]
		[Address(RVA = "0x562870", Offset = "0x561A70", VA = "0x180562870", Slot = "11")]
		protected override string GetIdsRewardsInfoSecond()
		{
			return null;
		}

		[Token(Token = "0x600BA1E")]
		[Address(RVA = "0x5629F0", Offset = "0x561BF0", VA = "0x1805629F0", Slot = "12")]
		internal override void UpdateRewardInfo(int tabIndex)
		{
		}
	}

	[Token(Token = "0x2001CC0")]
	internal class RDCBehaviour : DuelistCupBehaviour
	{
		[Token(Token = "0x600BA1F")]
		[Address(RVA = "0x55E730", Offset = "0x55D930", VA = "0x18055E730")]
		public RDCBehaviour(ColosseumRewardDuelistCupViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, int defaultTabIndex, ColosseumUtil.PlayMode mode)
		{
		}

		[Token(Token = "0x600BA20")]
		[Address(RVA = "0x55E620", Offset = "0x55D820", VA = "0x18055E620", Slot = "12")]
		internal override void UpdateRewardInfo(int tabIndex)
		{
		}
	}

	[Token(Token = "0x4010077")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x4010078")]
	[FieldOffset(Offset = "0xD8")]
	private ModeBehaviour modeBehaviour;

	[Token(Token = "0x4010079")]
	[FieldOffset(Offset = "0xE0")]
	private InfinityScrollView isv;

	[Token(Token = "0x401007A")]
	[FieldOffset(Offset = "0xE8")]
	private List<SelectionItem> isvEdgeSelectSearchList;

	[Token(Token = "0x401007B")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelchangeRewardsTabs;

	[Token(Token = "0x401007C")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelchangeRewardsTabs_SeasonPtTab;

	[Token(Token = "0x401007D")]
	[FieldOffset(Offset = "0x100")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x17001BEB")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B9F0")]
		[Address(RVA = "0x54F860", Offset = "0x54EA60", VA = "0x18054F860", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B9F1")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B9F2")]
	[Address(RVA = "0x54E6D0", Offset = "0x54D8D0", VA = "0x18054E6D0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B9F3")]
	[Address(RVA = "0x54F1E0", Offset = "0x54E3E0", VA = "0x18054F1E0")]
	private void Start()
	{
	}

	[Token(Token = "0x600B9F4")]
	[Address(RVA = "0x54F480", Offset = "0x54E680", VA = "0x18054F480", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B9F5")]
	[Address(RVA = "0x54ED50", Offset = "0x54DF50", VA = "0x18054ED50")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600B9F6")]
	[Address(RVA = "0x54F780", Offset = "0x54E980", VA = "0x18054F780")]
	public ColosseumRewardDuelistCupViewController()
	{
	}
}
