using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.WCS;

[Token(Token = "0x2000729")]
public class WinPredictionRewardViewController : BaseMenuViewController, IBackButtonSupported, IHeaderBorderSupported
{
	[Token(Token = "0x200072A")]
	private class ChangeFormWidget : ElementWidgetBase
	{
		[Token(Token = "0x40023EE")]
		[FieldOffset(Offset = "0x20")]
		public readonly DirectionalToggleGroupWidget rewardsToggleWidget;

		[Token(Token = "0x6002F30")]
		[Address(RVA = "0x719020", Offset = "0x718220", VA = "0x180719020")]
		public ChangeFormWidget(ElementObjectManager eom)
		{
		}
	}

	[Token(Token = "0x200072B")]
	internal abstract class ModeBehaviour
	{
		[Token(Token = "0x40023EF")]
		[FieldOffset(Offset = "0x10")]
		protected readonly string BTN_LABEL;

		[Token(Token = "0x40023F0")]
		[FieldOffset(Offset = "0x18")]
		protected readonly string BTN_ICON_LABEL;

		[Token(Token = "0x40023F1")]
		[FieldOffset(Offset = "0x20")]
		protected readonly string IMG_LINE_LABEL;

		[Token(Token = "0x40023F2")]
		[FieldOffset(Offset = "0x28")]
		protected readonly string TXT_ORDER_LABEL;

		[Token(Token = "0x40023F3")]
		[FieldOffset(Offset = "0x30")]
		protected readonly string TXT_NAME_LABEL;

		[Token(Token = "0x40023F4")]
		[FieldOffset(Offset = "0x38")]
		protected readonly string TXT_DATE_LABEL;

		[Token(Token = "0x40023F5")]
		[FieldOffset(Offset = "0x40")]
		protected readonly string TXT_EXPLAIN_LABEL;

		[Token(Token = "0x40023F6")]
		[FieldOffset(Offset = "0x48")]
		protected readonly string IMG_RECEIVED_LABEL;

		[Token(Token = "0x40023F7")]
		[FieldOffset(Offset = "0x50")]
		protected readonly WinPredictionRewardViewController vc;

		[Token(Token = "0x40023F8")]
		[FieldOffset(Offset = "0x58")]
		protected readonly InfinityScrollView isv;

		[Token(Token = "0x40023F9")]
		[FieldOffset(Offset = "0x60")]
		protected readonly ElementObjectManager eom;

		[Token(Token = "0x40023FA")]
		[FieldOffset(Offset = "0x68")]
		protected readonly int id;

		[Token(Token = "0x40023FB")]
		[FieldOffset(Offset = "0x70")]
		protected readonly string endDateReward;

		[Token(Token = "0x40023FC")]
		[FieldOffset(Offset = "0x78")]
		protected readonly bool isTabChange;

		[Token(Token = "0x6002F31")]
		[Address(RVA = "0x71D390", Offset = "0x71C590", VA = "0x18071D390")]
		protected ModeBehaviour(WinPredictionRewardViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, bool isTabChange)
		{
		}

		[Token(Token = "0x6002F32")]
		internal abstract void CallAPI();

		[Token(Token = "0x6002F33")]
		internal abstract void UpdateView();

		[Token(Token = "0x6002F34")]
		internal abstract void OnUpdateEntity(GameObject go, int dataIndex);

		[Token(Token = "0x6002F35")]
		internal abstract void InitializeScroll();

		[Token(Token = "0x6002F36")]
		internal abstract void TrySelectDefaultScroll(bool isInitializeSelect);
	}

	[Token(Token = "0x200072C")]
	internal class WcsWinPredictionBehaviour : ModeBehaviour
	{
		[Token(Token = "0x200072D")]
		private class Data
		{
			[Token(Token = "0x40023FE")]
			[FieldOffset(Offset = "0x10")]
			internal List<ItemDataDC> itemDatas;

			[Token(Token = "0x40023FF")]
			[FieldOffset(Offset = "0x18")]
			internal int indexNum;

			[Token(Token = "0x4002400")]
			[FieldOffset(Offset = "0x20")]
			internal string title;

			[Token(Token = "0x6002F42")]
			[Address(RVA = "0x71CB10", Offset = "0x71BD10", VA = "0x18071CB10")]
			public Data(int indexNum)
			{
			}

			[Token(Token = "0x6002F43")]
			[Address(RVA = "0x71CA70", Offset = "0x71BC70", VA = "0x18071CA70")]
			public Data(string title)
			{
			}
		}

		[Token(Token = "0x200072E")]
		private class ItemData
		{
			[Token(Token = "0x4002401")]
			[FieldOffset(Offset = "0x10")]
			internal int itemID;

			[Token(Token = "0x4002402")]
			[FieldOffset(Offset = "0x14")]
			internal int quantity;

			[Token(Token = "0x6002F44")]
			[Address(RVA = "0x55DEE0", Offset = "0x55D0E0", VA = "0x18055DEE0")]
			public ItemData(int itemID, int quantity)
			{
			}
		}

		[Token(Token = "0x200072F")]
		private class ItemDataDC
		{
			[Token(Token = "0x4002403")]
			[FieldOffset(Offset = "0x10")]
			public int itemCategory;

			[Token(Token = "0x4002404")]
			[FieldOffset(Offset = "0x14")]
			public int itemId;

			[Token(Token = "0x4002405")]
			[FieldOffset(Offset = "0x18")]
			public int num;

			[Token(Token = "0x4002406")]
			[FieldOffset(Offset = "0x1C")]
			public int needDlv;

			[Token(Token = "0x4002407")]
			[FieldOffset(Offset = "0x20")]
			public bool isPeriod;

			[Token(Token = "0x4002408")]
			[FieldOffset(Offset = "0x21")]
			public bool focus;

			[Token(Token = "0x4002409")]
			[FieldOffset(Offset = "0x22")]
			public bool received;

			[Token(Token = "0x400240A")]
			[FieldOffset(Offset = "0x23")]
			public bool isSpecial;

			[Token(Token = "0x6002F45")]
			[Address(RVA = "0x71D320", Offset = "0x71C520", VA = "0x18071D320")]
			public ItemDataDC(int itemCategory, int itemId, int num, bool isPeriod, int needDlv, bool focus, bool received, bool isSpecial = false)
			{
			}
		}

		[Token(Token = "0x2000732")]
		[CompilerGenerated]
		private sealed class _003Cwait_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			[Token(Token = "0x400240F")]
			[FieldOffset(Offset = "0x10")]
			private int _003C_003E1__state;

			[Token(Token = "0x4002410")]
			[FieldOffset(Offset = "0x18")]
			private object _003C_003E2__current;

			[Token(Token = "0x4002411")]
			[FieldOffset(Offset = "0x20")]
			public WcsWinPredictionBehaviour _003C_003E4__this;

			[Token(Token = "0x170005DC")]
			private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
			{
				[Token(Token = "0x6002F4F")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x170005DD")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x6002F51")]
				[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x6002F4C")]
			[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
			[DebuggerHidden]
			public _003Cwait_003Ed__7(int _003C_003E1__state)
			{
			}

			[Token(Token = "0x6002F4D")]
			[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
			[DebuggerHidden]
			private void System_002EIDisposable_002EDispose()
			{
			}

			[Token(Token = "0x6002F4E")]
			[Address(RVA = "0x727570", Offset = "0x726770", VA = "0x180727570", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x6002F50")]
			[Address(RVA = "0x727630", Offset = "0x726830", VA = "0x180727630", Slot = "8")]
			[DebuggerHidden]
			private void System_002ECollections_002EIEnumerator_002EReset()
			{
			}
		}

		[Token(Token = "0x40023FD")]
		[FieldOffset(Offset = "0x80")]
		private List<Data> dataList;

		[Token(Token = "0x6002F37")]
		[Address(RVA = "0x72A830", Offset = "0x729A30", VA = "0x18072A830")]
		public WcsWinPredictionBehaviour(WinPredictionRewardViewController vc, InfinityScrollView isv, ElementObjectManager eom, int id, string endDateReward, bool isTabChange)
		{
		}

		[Token(Token = "0x6002F38")]
		[Address(RVA = "0x7292A0", Offset = "0x7284A0", VA = "0x1807292A0", Slot = "9")]
		protected virtual string GetIdsRewardsInfoSecond()
		{
			return null;
		}

		[Token(Token = "0x6002F39")]
		[Address(RVA = "0x55A020", Offset = "0x559220", VA = "0x18055A020", Slot = "4")]
		internal override void CallAPI()
		{
		}

		[Token(Token = "0x6002F3A")]
		[Address(RVA = "0x72AAF0", Offset = "0x729CF0", VA = "0x18072AAF0")]
		[IteratorStateMachine(typeof(_003Cwait_003Ed__7))]
		private IEnumerator wait()
		{
			return null;
		}

		[Token(Token = "0x6002F3B")]
		[Address(RVA = "0x729300", Offset = "0x728500", VA = "0x180729300", Slot = "7")]
		internal override void InitializeScroll()
		{
		}

		[Token(Token = "0x6002F3C")]
		[Address(RVA = "0x729BF0", Offset = "0x728DF0", VA = "0x180729BF0", Slot = "8")]
		internal override void TrySelectDefaultScroll(bool isInitializeSelect)
		{
		}

		[Token(Token = "0x6002F3D")]
		[Address(RVA = "0x729410", Offset = "0x728610", VA = "0x180729410", Slot = "6")]
		internal override void OnUpdateEntity(GameObject go, int dataIndex)
		{
		}

		[Token(Token = "0x6002F3E")]
		[Address(RVA = "0x729E90", Offset = "0x729090", VA = "0x180729E90", Slot = "5")]
		internal override void UpdateView()
		{
		}

		[Token(Token = "0x6002F3F")]
		[Address(RVA = "0x7298D0", Offset = "0x728AD0", VA = "0x1807298D0")]
		private void SetItemData(List<object> list, int index, bool isSpecial, Data data)
		{
		}

		[Token(Token = "0x6002F40")]
		[Address(RVA = "0x7290A0", Offset = "0x7282A0", VA = "0x1807290A0")]
		private IReadOnlyList<(SelectionItem, int, int)> CustomCollectionSelectionItems(GameObject rewardEntity)
		{
			return null;
		}
	}

	[Token(Token = "0x2000735")]
	[CompilerGenerated]
	private sealed class _003CSetMMA_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002415")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002416")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002417")]
		[FieldOffset(Offset = "0x20")]
		public WinPredictionRewardViewController _003C_003E4__this;

		[Token(Token = "0x4002418")]
		[FieldOffset(Offset = "0x28")]
		private BaseBlurOverlayViewController _003Ctop_003E5__2;

		[Token(Token = "0x170005DE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002F5B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005DF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002F5D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002F58")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetMMA_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002F59")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002F5A")]
		[Address(RVA = "0x724D80", Offset = "0x723F80", VA = "0x180724D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002F5C")]
		[Address(RVA = "0x725370", Offset = "0x724570", VA = "0x180725370", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40023DB")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string SCROLL_LABEL;

	[Token(Token = "0x40023DC")]
	[FieldOffset(Offset = "0xD8")]
	private ModeBehaviour modeBehaviour;

	[Token(Token = "0x40023DD")]
	[FieldOffset(Offset = "0xE0")]
	private InfinityScrollView isv;

	[Token(Token = "0x40023DE")]
	[FieldOffset(Offset = "0xE8")]
	private List<SelectionItem> isvEdgeSelectSearchList;

	[Token(Token = "0x40023DF")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string k_ELabelAnalogDirectionItem;

	[Token(Token = "0x40023E0")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string LABEL_MMAContainer;

	[Token(Token = "0x40023E1")]
	[FieldOffset(Offset = "0x100")]
	private readonly string LABEL_RewardContainer;

	[Token(Token = "0x40023E2")]
	[FieldOffset(Offset = "0x108")]
	private readonly string LABEL_InfoButtonTab;

	[Token(Token = "0x40023E3")]
	[FieldOffset(Offset = "0x110")]
	private readonly string LABEL_RewardButtonTab;

	[Token(Token = "0x40023E4")]
	[FieldOffset(Offset = "0x118")]
	private GameObject MMAContainer;

	[Token(Token = "0x40023E5")]
	[FieldOffset(Offset = "0x120")]
	private GameObject RewardContainer;

	[Token(Token = "0x40023E6")]
	[FieldOffset(Offset = "0x128")]
	private Selector isvSelector;

	[Token(Token = "0x40023E7")]
	[FieldOffset(Offset = "0x130")]
	private Selector topSelector;

	[Token(Token = "0x40023E8")]
	[FieldOffset(Offset = "0x138")]
	private Selector freeSelector;

	[Token(Token = "0x40023E9")]
	[FieldOffset(Offset = "0x140")]
	private DirectionalTabGroup m_TabGroup;

	[Token(Token = "0x40023EA")]
	[FieldOffset(Offset = "0x148")]
	private string endDateReward;

	[Token(Token = "0x40023EB")]
	[FieldOffset(Offset = "0x150")]
	private int id;

	[Token(Token = "0x40023EC")]
	private const int NormalRewardType = 1;

	[Token(Token = "0x40023ED")]
	private const int SpecialRewardType = 2;

	[Token(Token = "0x170005DA")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6002F26")]
		[Address(RVA = "0x730850", Offset = "0x72FA50", VA = "0x180730850", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005DB")]
	protected override int outGameBgId
	{
		[Token(Token = "0x6002F27")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6002F28")]
	[Address(RVA = "0x730660", Offset = "0x72F860", VA = "0x180730660")]
	[IteratorStateMachine(typeof(_003CSetMMA_003Ed__24))]
	private IEnumerator SetMMA()
	{
		return null;
	}

	[Token(Token = "0x6002F29")]
	[Address(RVA = "0x578EC0", Offset = "0x5780C0", VA = "0x180578EC0", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6002F2A")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6002F2B")]
	[Address(RVA = "0x72F910", Offset = "0x72EB10", VA = "0x18072F910", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6002F2C")]
	[Address(RVA = "0x72F850", Offset = "0x72EA50", VA = "0x18072F850")]
	private ModeBehaviour GetModeBehaviour(string txtDate, bool isTabChange)
	{
		return null;
	}

	[Token(Token = "0x6002F2D")]
	[Address(RVA = "0x7306D0", Offset = "0x72F8D0", VA = "0x1807306D0", Slot = "11")]
	public override void TransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6002F2E")]
	[Address(RVA = "0x7301D0", Offset = "0x72F3D0", VA = "0x1807301D0")]
	private void OnInputAnalogDirection(SelectorManager.AnalogType analogType, PadInputDirection dir)
	{
	}

	[Token(Token = "0x6002F2F")]
	[Address(RVA = "0x7306E0", Offset = "0x72F8E0", VA = "0x1807306E0")]
	public WinPredictionRewardViewController()
	{
	}
}
