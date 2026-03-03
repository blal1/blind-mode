using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomGame.Menu;

[Token(Token = "0x2001168")]
public class CommonDialogViewController : DialogViewControllerBase, IBokeSupported
{
	[Token(Token = "0x400B6F0")]
	private const string k_ArgKeyEntryDatas = "entryDatas";

	[Token(Token = "0x400B6F1")]
	public const string k_ArgKeyOpenSe = "opense";

	[Token(Token = "0x400B6F2")]
	public const string k_ArgKeyViewStyleOverride = "viewStyleOverride";

	[Token(Token = "0x400B6F3")]
	public const string k_ArgKeyViewPathOverride = "viewPathOverride";

	[Token(Token = "0x400B6F4")]
	public const string k_ArgKeyAlignmentOptions = "AlignmentOptions";

	[Token(Token = "0x400B6F5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private readonly string k_ELabelContent;

	[Token(Token = "0x400B6F6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private readonly string k_ELabelBackKeyShortcutButton;

	[Token(Token = "0x400B6F7")]
	public const string k_ArgKeySelectorPriorityOverride = "SelectorPriorityOverride";

	[Token(Token = "0x400B6F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	[SerializeField]
	private ElementObjectManager m_ItemListWidgetPref;

	[Token(Token = "0x400B6F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private CommonDialogContentContainerWidget m_ContentWidget;

	[Token(Token = "0x400B6FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool m_DoneSelectorLabelUnique;

	[Token(Token = "0x400B6FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static GameObject prefab;

	[Token(Token = "0x17001143")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x6006D29")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6006D2A")]
	[Address(RVA = "0xB46190", Offset = "0xB45390", VA = "0x180B46190")]
	private static bool LoadPrefab()
	{
		return default(bool);
	}

	[Token(Token = "0x6006D2B")]
	[Address(RVA = "0xB48050", Offset = "0xB47250", VA = "0x180B48050")]
	public static void OpenConfirmationDialog(string title, string message, string buttonLabel, Action action, [Optional] Dictionary<string, object> args, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool isSwap = false)
	{
	}

	[Token(Token = "0x6006D2C")]
	[Address(RVA = "0xB47C70", Offset = "0xB46E70", VA = "0x180B47C70")]
	public static void OpenConfirmationDialogScroll(string title, string message, string buttonLabel, Action action, [Optional] Dictionary<string, object> args, bool allowCancel = true, int height = 120, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
	{
	}

	[Token(Token = "0x6006D2D")]
	[Address(RVA = "0xB48B80", Offset = "0xB47D80", VA = "0x180B48B80")]
	public static void OpenYesNoConfirmationDialogScroll(string title, string message, Action action, [Optional] Action noAction, [Optional] string yesLabel, [Optional] string noLabel, bool allowCancel = true, int height = 120, [Optional] Dictionary<string, object> args, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType yesButtonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool selectedNoButton = false)
	{
	}

	[Token(Token = "0x6006D2E")]
	[Address(RVA = "0xB48560", Offset = "0xB47760", VA = "0x180B48560")]
	public static void OpenErrorDialog(string title, string message, string buttonLabel, Action action, [Optional] Dictionary<string, object> args, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
	{
	}

	[Token(Token = "0x6006D2F")]
	[Address(RVA = "0xB46F40", Offset = "0xB46140", VA = "0x180B46F40")]
	public static void OpenAlertDialog(string title, string message, Action action, [Optional] string buttonLabel, [Optional] Dictionary<string, object> args, bool allowCancel = true, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool isSwap = false)
	{
	}

	[Token(Token = "0x6006D30")]
	[Address(RVA = "0xB46E60", Offset = "0xB46060", VA = "0x180B46E60")]
	public static void OpenAlertDialogScroll(string title, string message, Action action, [Optional] string buttonLabel, [Optional] Dictionary<string, object> args, bool allowCancel = true, int height = 120, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
	{
	}

	[Token(Token = "0x6006D31")]
	[Address(RVA = "0xB48430", Offset = "0xB47630", VA = "0x180B48430")]
	public static void OpenConfirmationPartDialog(string title, string message, string buttonLabel, Action action, [Optional] Dictionary<string, object> args, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive)
	{
	}

	[Token(Token = "0x6006D32")]
	[Address(RVA = "0xB490C0", Offset = "0xB482C0", VA = "0x180B490C0")]
	public static void OpenYesNoConfirmationDialog(string title, string message, Action action, [Optional] Action noAction, [Optional] Dictionary<string, object> args, [Optional] string yesLabel, [Optional] string noLabel, bool allowCancel = true, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, CommonDialogButtonGroupWidget.ButtonType yesButtonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool selectedNoButton = false)
	{
	}

	[Token(Token = "0x6006D33")]
	[Address(RVA = "0xB48B10", Offset = "0xB47D10", VA = "0x180B48B10")]
	public static void OpenNoticeYesNoDialog(string title, string message, Action action, [Optional] Action noAction, [Optional] string yesLabel, [Optional] string noLabel, [Optional] Dictionary<string, object> args, bool allowCancel = true, CommonDialogButtonGroupWidget.ButtonType yesButtonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool selectedNoButton = false)
	{
	}

	[Token(Token = "0x6006D34")]
	[Address(RVA = "0xB485B0", Offset = "0xB477B0", VA = "0x180B485B0")]
	public static void OpenItemConfirmDialog(string title, string message, int itemId, Action action, [Optional] string buttonLabel, [Optional] string itemMessage, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006D35")]
	[Address(RVA = "0xB48640", Offset = "0xB47840", VA = "0x180B48640")]
	public static void OpenItemConfirmDialog(string title, string message, bool isPeriod, int itemCategory, int itemId, Action action, [Optional] string buttonLabel, [Optional] string itemMessage, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006D36")]
	[Address(RVA = "0xB47620", Offset = "0xB46820", VA = "0x180B47620")]
	public static void OpenCheckBoxDialog(string title, string message, List<EntryCheckBoxListData.EntryCheckBoxData> checkBoxList, bool isEnableMulti, [Optional] Action<List<bool>> action, [Optional] Action noAction, [Optional] string buttonLabel, [Optional] string noButtonLabel, bool interactable = false, CommonDialogTitleWidget.IconType iconType = CommonDialogTitleWidget.IconType.None, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006D37")]
	[Address(RVA = "0xB47020", Offset = "0xB46220", VA = "0x180B47020")]
	public static void OpenCheckBoxDialogForReplay(string title, EntryTextReplayData replayData, List<EntryCheckBoxListData.EntryCheckBoxData> checkBoxList, bool isEnableMulti, [Optional] Action<List<bool>> action, [Optional] Action noAction, [Optional] string buttonLabel, [Optional] string noButtonLabel, bool interactable = false, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6006D38")]
	[Address(RVA = "0xB495F0", Offset = "0xB487F0", VA = "0x180B495F0")]
	public static void Open(IReadOnlyList<IEntryData> entryDatas, [Optional] Dictionary<string, object> args, bool isSwap = false)
	{
	}

	[Token(Token = "0x6006D39")]
	[Address(RVA = "0xB462C0", Offset = "0xB454C0", VA = "0x180B462C0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006D3A")]
	[Address(RVA = "0xB464C0", Offset = "0xB456C0", VA = "0x180B464C0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6006D3B")]
	[Address(RVA = "0xB498B0", Offset = "0xB48AB0", VA = "0x180B498B0", Slot = "9")]
	public override float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x6006D3C")]
	[Address(RVA = "0x4B6FD0", Offset = "0x4B61D0", VA = "0x1804B6FD0")]
	private void OnSendCloseByWidgets()
	{
	}

	[Token(Token = "0x6006D3D")]
	[Address(RVA = "0xB46410", Offset = "0xB45610", VA = "0x180B46410", Slot = "13")]
	public override bool OnBack()
	{
		return default(bool);
	}

	[Token(Token = "0x6006D3E")]
	[Address(RVA = "0xB49910", Offset = "0xB48B10", VA = "0x180B49910")]
	public CommonDialogViewController()
	{
	}
}
