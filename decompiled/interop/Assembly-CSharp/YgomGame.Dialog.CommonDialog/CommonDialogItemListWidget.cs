using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;
using YgomSystem.UI.PropertyOverrider;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FD1")]
public class CommonDialogItemListWidget : ContentWidgetBase<CommonDialogItemListWidget, EntryItemListData>, IContentWidgetAsyncLoader, IContentWidgetDirectionalInputListener, IContentLifecycleHandler
{
	[Token(Token = "0x2000FD2")]
	public class ItemLineWidget : ElementWidgetBase
	{
		[Token(Token = "0x400AB1A")]
		[FieldOffset(Offset = "0x20")]
		private readonly string k_ELabelItemButton;

		[Token(Token = "0x400AB1B")]
		[FieldOffset(Offset = "0x28")]
		private readonly string k_ELabelItemIcon;

		[Token(Token = "0x400AB1C")]
		[FieldOffset(Offset = "0x30")]
		private readonly string k_ELabelItemNameText;

		[Token(Token = "0x400AB1D")]
		[FieldOffset(Offset = "0x38")]
		private readonly string k_ELabelItemNumText;

		[Token(Token = "0x400AB1E")]
		[FieldOffset(Offset = "0x40")]
		private readonly string k_OVGroupLabel_Default;

		[Token(Token = "0x400AB1F")]
		[FieldOffset(Offset = "0x48")]
		private readonly string k_OVGroupLabel_Structure;

		[Token(Token = "0x400AB20")]
		[FieldOffset(Offset = "0x50")]
		private readonly PlatformOverriderGroup m_OvGroup;

		[Token(Token = "0x400AB21")]
		[FieldOffset(Offset = "0x58")]
		public readonly SelectionButton button;

		[Token(Token = "0x400AB22")]
		[FieldOffset(Offset = "0x60")]
		public readonly GameObject itemIcon;

		[Token(Token = "0x400AB23")]
		[FieldOffset(Offset = "0x68")]
		public readonly TMP_Text itemNameText;

		[Token(Token = "0x400AB24")]
		[FieldOffset(Offset = "0x70")]
		public readonly TMP_Text itemNumText;

		[Token(Token = "0x6005FEC")]
		[Address(RVA = "0xA6B7D0", Offset = "0xA6A9D0", VA = "0x180A6B7D0")]
		public ItemLineWidget(ElementObjectManager eom)
		{
		}

		[Token(Token = "0x6005FED")]
		[Address(RVA = "0xA6B740", Offset = "0xA6A940", VA = "0x180A6B740")]
		public void ApplySwitchLabel(bool isPeriod, int itemCategory, int itemId)
		{
		}
	}

	[Token(Token = "0x2000FD4")]
	[CompilerGenerated]
	private sealed class _003CyAsyncBinding_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400AB26")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400AB27")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400AB28")]
		[FieldOffset(Offset = "0x20")]
		public CommonDialogItemListWidget _003C_003E4__this;

		[Token(Token = "0x17000F1A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005FF3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000F1B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005FF5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005FF0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyAsyncBinding_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005FF1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005FF2")]
		[Address(RVA = "0xA6C9E0", Offset = "0xA6BBE0", VA = "0x180A6C9E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005FF4")]
		[Address(RVA = "0xA6CAD0", Offset = "0xA6BCD0", VA = "0x180A6CAD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400AB13")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelScrollView;

	[Token(Token = "0x400AB14")]
	[FieldOffset(Offset = "0x38")]
	private InfinityScrollView m_ScrollView;

	[Token(Token = "0x400AB15")]
	[FieldOffset(Offset = "0x40")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x400AB16")]
	[FieldOffset(Offset = "0x48")]
	private Selector m_Selector;

	[Token(Token = "0x400AB17")]
	[FieldOffset(Offset = "0x50")]
	private Dictionary<GameObject, ItemLineWidget> m_EntityMap;

	[Token(Token = "0x400AB18")]
	[FieldOffset(Offset = "0x58")]
	private EntryItemListData m_EntryData;

	[Token(Token = "0x400AB19")]
	[FieldOffset(Offset = "0x60")]
	private Action m_OnCompleteCallback;

	[Token(Token = "0x6005FD6")]
	[Address(RVA = "0xA56140", Offset = "0xA55340", VA = "0x180A56140")]
	public static CommonDialogItemListWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FD7")]
	[Address(RVA = "0xA55F40", Offset = "0xA55140", VA = "0x180A55F40", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FD8")]
	[Address(RVA = "0xA561B0", Offset = "0xA553B0", VA = "0x180A561B0", Slot = "24")]
	protected override void InnerBinding(EntryItemListData entryData)
	{
	}

	[Token(Token = "0x6005FD9")]
	[Address(RVA = "0xA56F50", Offset = "0xA56150", VA = "0x180A56F50")]
	[IteratorStateMachine(typeof(_003CyAsyncBinding_003Ed__10))]
	private IEnumerator yAsyncBinding()
	{
		return null;
	}

	[Token(Token = "0x6005FDA")]
	[Address(RVA = "0xA55CF0", Offset = "0xA54EF0", VA = "0x180A55CF0", Slot = "25")]
	public void AsyncBinding(IEntryData entryData, Action onComplete)
	{
	}

	[Token(Token = "0x6005FDB")]
	[Address(RVA = "0xA565D0", Offset = "0xA557D0", VA = "0x180A565D0")]
	private void OnScrollInitialized()
	{
	}

	[Token(Token = "0x6005FDC")]
	[Address(RVA = "0xA563F0", Offset = "0xA555F0", VA = "0x180A563F0")]
	private void OnCreatedEntityCallback(GameObject entity)
	{
	}

	[Token(Token = "0x6005FDD")]
	[Address(RVA = "0xA56720", Offset = "0xA55920", VA = "0x180A56720")]
	private void OnUpdatedEntityCallback(GameObject entity, int idx)
	{
	}

	[Token(Token = "0x6005FDE")]
	[Address(RVA = "0xA564B0", Offset = "0xA556B0", VA = "0x180A564B0")]
	private bool OnCustomEdgeTransition(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FDF")]
	[Address(RVA = "0xA56AD0", Offset = "0xA55CD0", VA = "0x180A56AD0")]
	private void TrySelectHeadItem()
	{
	}

	[Token(Token = "0x6005FE0")]
	[Address(RVA = "0xA56A10", Offset = "0xA55C10", VA = "0x180A56A10")]
	private void TrySelectBottomItem()
	{
	}

	[Token(Token = "0x6005FE1")]
	[Address(RVA = "0xA56BA0", Offset = "0xA55DA0", VA = "0x180A56BA0")]
	private bool TrySelectItem(int entityIdx, SelectionItem currentItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FE2")]
	[Address(RVA = "0xA56CA0", Offset = "0xA55EA0", VA = "0x180A56CA0")]
	private bool TrySelectItem(GameObject activeEntity, SelectionItem currentItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6005FE3")]
	[Address(RVA = "0xA55D60", Offset = "0xA54F60", VA = "0x180A55D60")]
	private void CheckSelectOnAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6005FE4")]
	[Address(RVA = "0xA56580", Offset = "0xA55780", VA = "0x180A56580", Slot = "26")]
	public void OnMainAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6005FE5")]
	[Address(RVA = "0xA56580", Offset = "0xA55780", VA = "0x180A56580", Slot = "27")]
	public void OnSubAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x6005FE6")]
	[Address(RVA = "0xA56570", Offset = "0xA55770", VA = "0x180A56570", Slot = "28")]
	public void OnLeftInput()
	{
	}

	[Token(Token = "0x6005FE7")]
	[Address(RVA = "0xA565C0", Offset = "0xA557C0", VA = "0x180A565C0", Slot = "29")]
	public void OnRightInput()
	{
	}

	[Token(Token = "0x6005FE8")]
	[Address(RVA = "0xA56650", Offset = "0xA55850", VA = "0x180A56650", Slot = "30")]
	public void OnUpInput()
	{
	}

	[Token(Token = "0x6005FE9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "31")]
	public void OnDownInput()
	{
	}

	[Token(Token = "0x6005FEA")]
	[Address(RVA = "0xA562A0", Offset = "0xA554A0", VA = "0x180A562A0", Slot = "32")]
	public bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6005FEB")]
	[Address(RVA = "0xA56EA0", Offset = "0xA560A0", VA = "0x180A56EA0")]
	public CommonDialogItemListWidget()
	{
	}
}
