using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B7B")]
public class RewardRecordWidget : WidgetBase<RewardRecordWidget.Source>, IScrollEntityButtonWidget, IItemButtonWidget
{
	[Token(Token = "0x2000B7C")]
	public class Source : IWidgetSourceSelectable, IWidgetSource, IWidgetSourceItemButton
	{
		[Token(Token = "0x4009719")]
		[FieldOffset(Offset = "0x10")]
		public bool isPeriod;

		[Token(Token = "0x400971A")]
		[FieldOffset(Offset = "0x14")]
		public int itemCategory;

		[Token(Token = "0x400971B")]
		[FieldOffset(Offset = "0x18")]
		public int itemId;

		[Token(Token = "0x400971C")]
		[FieldOffset(Offset = "0x1C")]
		public int itemNum;

		[Token(Token = "0x400971D")]
		[FieldOffset(Offset = "0x20")]
		public string descText;

		[Token(Token = "0x400971E")]
		[FieldOffset(Offset = "0x28")]
		public bool isReceived;

		[Token(Token = "0x17000969")]
		public bool isSelectable
		{
			[Token(Token = "0x6004641")]
			[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700096A")]
		private bool YgomGame_002EPromoCodes_002EIWidgetSourceItemButton_002EisPeriod
		{
			[Token(Token = "0x6004642")]
			[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700096B")]
		private int YgomGame_002EPromoCodes_002EIWidgetSourceItemButton_002EitemCategory
		{
			[Token(Token = "0x6004643")]
			[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700096C")]
		private int YgomGame_002EPromoCodes_002EIWidgetSourceItemButton_002EitemId
		{
			[Token(Token = "0x6004644")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700096D")]
		private int YgomGame_002EPromoCodes_002EIWidgetSourceItemButton_002EitemNum
		{
			[Token(Token = "0x6004645")]
			[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220", Slot = "8")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6004646")]
		[Address(RVA = "0x8F38B0", Offset = "0x8F2AB0", VA = "0x1808F38B0")]
		public Source(bool isPeriod, int itemCategory, int itemId, int itemNum, string descText, bool isReceived)
		{
		}
	}

	[Token(Token = "0x2000B7D")]
	[CompilerGenerated]
	private sealed class _003COnProgressInitialize_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400971F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009720")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009721")]
		[FieldOffset(Offset = "0x20")]
		public RewardRecordWidget _003C_003E4__this;

		[Token(Token = "0x1700096E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600464A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700096F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600464C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6004647")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003COnProgressInitialize_003Ed__12(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6004648")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6004649")]
		[Address(RVA = "0x8F5E40", Offset = "0x8F5040", VA = "0x1808F5E40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600464B")]
		[Address(RVA = "0x8F6180", Offset = "0x8F5380", VA = "0x1808F6180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4009712")]
	private const string k_ELabel_Button = "Button";

	[Token(Token = "0x4009713")]
	private const string k_ELabel_ItemIcon = "ItemIcon";

	[Token(Token = "0x4009714")]
	private const string k_ELabel_ItemInfoText = "ItemInfoText";

	[Token(Token = "0x4009715")]
	private const string k_ELabel_DescText = "DescText";

	[Token(Token = "0x4009716")]
	private const string k_ELabel_ReceivedIcon = "ReceivedIcon";

	[Token(Token = "0x4009717")]
	[FieldOffset(Offset = "0x38")]
	private SelectionButton m_Button;

	[Token(Token = "0x1400005E")]
	public event Action<IWidgetSourceItemButton> onClickItemButton
	{
		[Token(Token = "0x600463A")]
		[Address(RVA = "0x8F2640", Offset = "0x8F1840", VA = "0x1808F2640", Slot = "17")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600463B")]
		[Address(RVA = "0x8F26F0", Offset = "0x8F18F0", VA = "0x1808F26F0", Slot = "18")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600463C")]
	[Address(RVA = "0x8F2540", Offset = "0x8F1740", VA = "0x1808F2540")]
	public RewardRecordWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x600463D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "14")]
	protected override void OnBeginInitialize()
	{
	}

	[Token(Token = "0x600463E")]
	[Address(RVA = "0x8F24D0", Offset = "0x8F16D0", VA = "0x1808F24D0", Slot = "15")]
	[IteratorStateMachine(typeof(_003COnProgressInitialize_003Ed__12))]
	protected override IEnumerator OnProgressInitialize()
	{
		return null;
	}

	[Token(Token = "0x600463F")]
	[Address(RVA = "0x8F23F0", Offset = "0x8F15F0", VA = "0x1808F23F0", Slot = "16")]
	public IReadOnlyList<(SelectionItem, int, int)> CollectionSelectionItems()
	{
		return null;
	}

	[Token(Token = "0x6004640")]
	[Address(RVA = "0x8F24A0", Offset = "0x8F16A0", VA = "0x1808F24A0")]
	private void OnClick()
	{
	}
}
