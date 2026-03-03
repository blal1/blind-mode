using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FCA")]
public class CommonDialogContentContainerWidget : ElementWidgetBehaviourBase<CommonDialogContentContainerWidget>
{
	[Token(Token = "0x400AACA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelTitleGrp;

	[Token(Token = "0x400AACB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400AACC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly string k_ElabelTextReplay;

	[Token(Token = "0x400AACD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelScrollText;

	[Token(Token = "0x400AACE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelImage;

	[Token(Token = "0x400AACF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly string k_ELabelMaintenance;

	[Token(Token = "0x400AAD0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly string k_ELabelIconText;

	[Token(Token = "0x400AAD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly string k_ELabelItemContent;

	[Token(Token = "0x400AAD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly string k_ELabelCheckBoxGroup;

	[Token(Token = "0x400AAD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly string k_ELabelButtonGroup;

	[Token(Token = "0x400AAD4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly string k_ELabelButtonGroupVertical;

	[Token(Token = "0x400AAD5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private CommonDialogTitleWidget m_TitleWidget;

	[Token(Token = "0x400AAD6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private CommonDialogTextWidget m_TextWidget;

	[Token(Token = "0x400AAD7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private CommonDialogTextReplayWidget m_TextReplayWidget;

	[Token(Token = "0x400AAD8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private CommonDialogScrollTextWidget m_ScrollTextWidget;

	[Token(Token = "0x400AAD9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private CommonDialogImageWidget m_ImageWidget;

	[Token(Token = "0x400AADA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private CommonDialogMaintenanceImageWidget m_MaintenanceWidget;

	[Token(Token = "0x400AADB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private CommonDialogIconTextWidget m_IconTextWidget;

	[Token(Token = "0x400AADC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private CommonDialogItemContentWidget m_ItemContentWidget;

	[Token(Token = "0x400AADD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private CommonDialogCheckBoxGroupWidget m_CheckBoxGroupWidget;

	[Token(Token = "0x400AADE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private CommonDialogButtonGroupWidget m_ButtonGroupWidget;

	[Token(Token = "0x400AADF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private CommonDialogButtonWidget m_CancelButtonWidget;

	[Token(Token = "0x400AAE0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private ElementObjectManager m_ItemListWidgetPref;

	[Token(Token = "0x400AAE1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private CommonDialogItemListWidget m_ItemListWidget;

	[Token(Token = "0x400AAE2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private bool m_RebuildLayoutOnPostAllInserted;

	[Token(Token = "0x400AAE3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private List<IContentPostAllInsertedHandler> m_PostAllInsertedHandlers;

	[Token(Token = "0x400AAE4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private List<IContentWidgetDirectionalInputListener> m_DirectionalInputListeners;

	[Token(Token = "0x400AAE5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private List<IContentLifecycleHandler> m_LifecycleHandlers;

	[Token(Token = "0x400AAE6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private List<SelectionButton> m_Buttons;

	[Token(Token = "0x400AAE7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x400AAE8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	public Action onSendCloseCallback;

	[Token(Token = "0x400AAE9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private CommonDialogButtonWidget defaultButton;

	[Token(Token = "0x400AAEA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private Action m_CompleteCallback;

	[Token(Token = "0x400AAEB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private int m_LoadingCnt;

	[Token(Token = "0x17000F14")]
	public CommonDialogButtonWidget cancelButtonWidget
	{
		[Token(Token = "0x6005FA5")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F15")]
	public CommonDialogCheckBoxGroupWidget checkBoxGroupWidget
	{
		[Token(Token = "0x6005FA6")]
		[Address(RVA = "0x49BB10", Offset = "0x49AD10", VA = "0x18049BB10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F16")]
	public CommonDialogButtonGroupWidget buttonGroupWidget
	{
		[Token(Token = "0x6005FA7")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F17")]
	public TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x6005FA8")]
		[Address(RVA = "0x3DA790", Offset = "0x3D9990", VA = "0x1803DA790")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F18")]
	public ElementObjectManager itemListWidgetPref
	{
		[Token(Token = "0x6005FA9")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6005FAA")]
		[Address(RVA = "0x662500", Offset = "0x661700", VA = "0x180662500")]
		set
		{
		}
	}

	[Token(Token = "0x17000F19")]
	public bool directionalInputListenerExist
	{
		[Token(Token = "0x6005FAB")]
		[Address(RVA = "0xA53DC0", Offset = "0xA52FC0", VA = "0x180A53DC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6005FAC")]
	[Address(RVA = "0xA51720", Offset = "0xA50920", VA = "0x180A51720")]
	public static CommonDialogContentContainerWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FAD")]
	[Address(RVA = "0xA51030", Offset = "0xA50230", VA = "0x180A51030", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FAE")]
	[Address(RVA = "0xA526E0", Offset = "0xA518E0", VA = "0x180A526E0")]
	public void InsertEntries(IReadOnlyList<IEntryData> entryDatas, [Optional] Action onComplete, [Optional] TextGroupLoadHolder textGroupLoadHolder)
	{
	}

	[Token(Token = "0x6005FAF")]
	[Address(RVA = "0xA51B20", Offset = "0xA50D20", VA = "0x180A51B20")]
	private void InsertContentWidget(IEntryData entryData)
	{
	}

	[Token(Token = "0x6005FB0")]
	[Address(RVA = "0xA52F70", Offset = "0xA52170", VA = "0x180A52F70")]
	private void OnLoadingCompleteCheck()
	{
	}

	[Token(Token = "0x6005FB1")]
	[Address(RVA = "0xA51760", Offset = "0xA50960", VA = "0x180A51760")]
	public IContentWidget GetContentWidget(IEntryData entryData)
	{
		return null;
	}

	[Token(Token = "0x6005FB2")]
	[Address(RVA = "0xA53330", Offset = "0xA52530", VA = "0x180A53330")]
	public void SendMainAnalogInputToListeneres(Vector2 dir)
	{
	}

	[Token(Token = "0x6005FB3")]
	[Address(RVA = "0xA53690", Offset = "0xA52890", VA = "0x180A53690")]
	public void SendSubAnalogInputToListeneres(Vector2 dir)
	{
	}

	[Token(Token = "0x6005FB4")]
	[Address(RVA = "0xA53180", Offset = "0xA52380", VA = "0x180A53180")]
	public void SendLeftInputToListeneres()
	{
	}

	[Token(Token = "0x6005FB5")]
	[Address(RVA = "0xA534E0", Offset = "0xA526E0", VA = "0x180A534E0")]
	public void SendRightInputToListeneres()
	{
	}

	[Token(Token = "0x6005FB6")]
	[Address(RVA = "0xA53850", Offset = "0xA52A50", VA = "0x180A53850")]
	public void SendUpInputToListeneres()
	{
	}

	[Token(Token = "0x6005FB7")]
	[Address(RVA = "0xA52FD0", Offset = "0xA521D0", VA = "0x180A52FD0")]
	public void SendDownInputToListeneres()
	{
	}

	[Token(Token = "0x6005FB8")]
	[Address(RVA = "0x5867E0", Offset = "0x5859E0", VA = "0x1805867E0")]
	private void OnSendClose()
	{
	}

	[Token(Token = "0x6005FB9")]
	[Address(RVA = "0xA52DC0", Offset = "0xA51FC0", VA = "0x180A52DC0")]
	public bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6005FBA")]
	[Address(RVA = "0xA53A90", Offset = "0xA52C90", VA = "0x180A53A90")]
	public CommonDialogContentContainerWidget()
	{
	}
}
