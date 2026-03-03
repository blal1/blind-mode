using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CAF")]
public class ColosseumRewardDiceRallyViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x2001CB0")]
	internal abstract class ModeBehaviour
	{
		[Token(Token = "0x4010051")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x4010052")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string BTN_ICON_LABEL;

		[Token(Token = "0x4010053")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string IMG_LINE_LABEL;

		[Token(Token = "0x4010054")]
		[FieldOffset(Offset = "0x28")]
		protected readonly string TXT_ORDER_LABEL;

		[Token(Token = "0x4010055")]
		[FieldOffset(Offset = "0x30")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x4010056")]
		[FieldOffset(Offset = "0x38")]
		protected readonly string TXT_TITLE_LABEL;

		[Token(Token = "0x4010057")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string TXT_DATE_LABEL;

		[Token(Token = "0x4010058")]
		[FieldOffset(Offset = "0x48")]
		protected readonly string TXT_EXPLAIN_LABEL;

		[Token(Token = "0x4010059")]
		[FieldOffset(Offset = "0x50")]
		protected readonly string IMG_RECEIVED_LABEL;

		[Token(Token = "0x401005A")]
		[FieldOffset(Offset = "0x58")]
		protected readonly ColosseumRewardDiceRallyViewController vc;

		[Token(Token = "0x401005B")]
		[FieldOffset(Offset = "0x60")]
		protected readonly InfinityScrollView isv;

		[Token(Token = "0x401005C")]
		[FieldOffset(Offset = "0x68")]
		protected readonly ElementObjectManager eom;

		[Token(Token = "0x401005D")]
		[FieldOffset(Offset = "0x70")]
		protected readonly int id;

		[Token(Token = "0x401005E")]
		[FieldOffset(Offset = "0x74")]
		protected ColosseumUtil.PlayMode mode;

		[Token(Token = "0x401005F")]
		[FieldOffset(Offset = "0x78")]
		private int m_CurrentTabIndex;

		[Token(Token = "0x4010060")]
		[FieldOffset(Offset = "0x7C")]
		private int m_TabTotalNum;

		[Token(Token = "0x17001BE9")]
		public int CurrentTabIndex
		{
			[Token(Token = "0x600B9CA")]
			[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600B9CB")]
			[Address(RVA = "0x55E600", Offset = "0x55D800", VA = "0x18055E600")]
			protected set
			{
			}
		}

		[Token(Token = "0x17001BEA")]
		public int TabTotalNum
		{
			[Token(Token = "0x600B9CC")]
			[Address(RVA = "0x55E5F0", Offset = "0x55D7F0", VA = "0x18055E5F0")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600B9CD")]
			[Address(RVA = "0x55E610", Offset = "0x55D810", VA = "0x18055E610")]
			set
			{
			}
		}

		[Token(Token = "0x600B9CE")]
		[Address(RVA = "0x55E1E0", Offset = "0x55D3E0", VA = "0x18055E1E0")]
		protected ModeBehaviour(ColosseumRewardDiceRallyViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, int defaultTabIndex, ColosseumUtil.PlayMode mode)
		{
		}

		[Token(Token = "0x600B9CF")]
		internal abstract void CallAPI();

		[Token(Token = "0x600B9D0")]
		internal abstract void UpdateView();

		[Token(Token = "0x600B9D1")]
		internal abstract void SetTabIndex(int tabIndex);

		[Token(Token = "0x600B9D2")]
		internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

		[Token(Token = "0x600B9D3")]
		internal abstract void InitializeScroll();

		[Token(Token = "0x600B9D4")]
		internal abstract int GetFocusIndex();

		[Token(Token = "0x600B9D5")]
		[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
		internal ColosseumUtil.PlayMode GetMode()
		{
			return default(ColosseumUtil.PlayMode);
		}
	}

	[Token(Token = "0x2001CB1")]
	internal class DiceRallyBehaviour : ModeBehaviour
	{
		[Token(Token = "0x2001CB2")]
		private class Data
		{
			[Token(Token = "0x4010067")]
			[FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x4010068")]
			[FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x4010069")]
			[FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x401006A")]
			[FieldOffset(Offset = "0x1C")]
			public int needCount;

			[Token(Token = "0x401006B")]
			[FieldOffset(Offset = "0x20")]
			public bool isPeriod;

			[Token(Token = "0x401006C")]
			[FieldOffset(Offset = "0x21")]
			public bool focus;

			[Token(Token = "0x401006D")]
			[FieldOffset(Offset = "0x22")]
			public bool received;

			[Token(Token = "0x600B9E4")]
			[Address(RVA = "0x558010", Offset = "0x557210", VA = "0x180558010")]
			public Data(int itemCategory, int itemId, int num, bool isPeriod, int needCount, bool focus, bool received)
			{
			}
		}

		[Token(Token = "0x4010061")]
		[FieldOffset(Offset = "0x80")]
		private List<Data> diceDataList;

		[Token(Token = "0x4010062")]
		[FieldOffset(Offset = "0x88")]
		private List<Data> lapDataList;

		[Token(Token = "0x4010063")]
		[FieldOffset(Offset = "0x90")]
		private int diceCount;

		[Token(Token = "0x4010064")]
		[FieldOffset(Offset = "0x94")]
		private int lapCount;

		[Token(Token = "0x4010065")]
		[FieldOffset(Offset = "0x98")]
		private string txtEndDate;

		[Token(Token = "0x4010066")]
		[FieldOffset(Offset = "0xA0")]
		private string txtEndDateResult;

		[Token(Token = "0x600B9D6")]
		[Address(RVA = "0x559B60", Offset = "0x558D60", VA = "0x180559B60")]
		public DiceRallyBehaviour(ColosseumRewardDiceRallyViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, int defaultTabIndex, ColosseumUtil.PlayMode mode)
		{
		}

		[Token(Token = "0x600B9D7")]
		[Address(RVA = "0x558B20", Offset = "0x557D20", VA = "0x180558B20", Slot = "10")]
		protected virtual void SetTabLabel(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x600B9D8")]
		[Address(RVA = "0x558260", Offset = "0x557460", VA = "0x180558260", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x600B9D9")]
		[Address(RVA = "0x558610", Offset = "0x557810", VA = "0x180558610", Slot = "8")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x600B9DA")]
		[Address(RVA = "0x5586B0", Offset = "0x5578B0", VA = "0x1805586B0", Slot = "7")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x600B9DB")]
		[Address(RVA = "0x558A40", Offset = "0x557C40", VA = "0x180558A40", Slot = "6")]
		internal override void SetTabIndex(int tabIndex)
		{
		}

		[Token(Token = "0x600B9DC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
		internal virtual void UpdateRewardInfo(int tabIndex)
		{
		}

		[Token(Token = "0x600B9DD")]
		[Address(RVA = "0x558D50", Offset = "0x557F50", VA = "0x180558D50")]
		internal void UpdateDateTxt(int tabIndex)
		{
		}

		[Token(Token = "0x600B9DE")]
		[Address(RVA = "0x558E20", Offset = "0x558020", VA = "0x180558E20", Slot = "5")]
		internal override void UpdateView()
		{
		}

		[Token(Token = "0x600B9DF")]
		[Address(RVA = "0x558280", Offset = "0x557480", VA = "0x180558280")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
		{
			return null;
		}

		[Token(Token = "0x600B9E0")]
		[Address(RVA = "0x558520", Offset = "0x557720", VA = "0x180558520", Slot = "9")]
		internal override int GetFocusIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600B9E1")]
		[Address(RVA = "0x5584A0", Offset = "0x5576A0", VA = "0x1805584A0")]
		private List<Data> GetCurrentDataList()
		{
			return null;
		}

		[Token(Token = "0x600B9E2")]
		[Address(RVA = "0x558480", Offset = "0x557680", VA = "0x180558480")]
		public int GetCurrentCount()
		{
			return default(int);
		}
	}

	[Token(Token = "0x401004B")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x401004C")]
	[FieldOffset(Offset = "0xD8")]
	private ModeBehaviour modeBehaviour;

	[Token(Token = "0x401004D")]
	[FieldOffset(Offset = "0xE0")]
	private InfinityScrollView isv;

	[Token(Token = "0x401004E")]
	[FieldOffset(Offset = "0xE8")]
	private List<SelectionItem> isvEdgeSelectSearchList;

	[Token(Token = "0x401004F")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelchangeRewardsTabs;

	[Token(Token = "0x4010050")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x17001BE8")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600B9C2")]
		[Address(RVA = "0x54E600", Offset = "0x54D800", VA = "0x18054E600", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600B9C3")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600B9C4")]
	[Address(RVA = "0x54D9E0", Offset = "0x54CBE0", VA = "0x18054D9E0", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x600B9C5")]
	[Address(RVA = "0x54D670", Offset = "0x54C870", VA = "0x18054D670", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600B9C6")]
	[Address(RVA = "0x54DF40", Offset = "0x54D140", VA = "0x18054DF40")]
	private void Start()
	{
	}

	[Token(Token = "0x600B9C7")]
	[Address(RVA = "0x54E480", Offset = "0x54D680", VA = "0x18054E480", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x600B9C8")]
	[Address(RVA = "0x54DAB0", Offset = "0x54CCB0", VA = "0x18054DAB0")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x600B9C9")]
	[Address(RVA = "0x54E550", Offset = "0x54D750", VA = "0x18054E550")]
	public ColosseumRewardDiceRallyViewController()
	{
	}
}
