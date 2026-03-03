using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FB5")]
public class EntryButtonData : EntryDataBase
{
	[Token(Token = "0x400AA65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public CommonDialogButtonGroupWidget.ButtonType buttonType;

	[Token(Token = "0x400AA66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public Action onClickCallback;

	[Token(Token = "0x400AA67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Action<CommonDialogButtonWidget> onClickWidgetCallback;

	[Token(Token = "0x400AA68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public string onClickUrlScheme;

	[Token(Token = "0x400AA69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool interactable;

	[Token(Token = "0x400AA6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public string text;

	[Token(Token = "0x400AA6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public bool closeOnClick;

	[Token(Token = "0x400AA6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	public bool isCancel;

	[Token(Token = "0x400AA6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4A")]
	public bool muteClickSe;

	[Token(Token = "0x400AA6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4B")]
	public bool isDefault;

	[Token(Token = "0x400AA6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public string goName;

	[Token(Token = "0x400AA70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public TransitionAlongDirection.DirectionFlag useWideTranFlags;

	[Token(Token = "0x17000EFF")]
	public override CommonDialogDef.ContentType contentType
	{
		[Token(Token = "0x6005F56")]
		[Address(RVA = "0x549EC0", Offset = "0x5490C0", VA = "0x180549EC0", Slot = "7")]
		get
		{
			return default(CommonDialogDef.ContentType);
		}
	}

	[Token(Token = "0x6005F57")]
	[Address(RVA = "0xA6AB00", Offset = "0xA69D00", VA = "0x180A6AB00")]
	public EntryButtonData([Optional] string text, [Optional] Action onClickCallback, [Optional] string onClickUrlScheme, bool closeOnClick = true, bool interactable = true, bool isCancel = false, bool replaceCallback = false, [Optional] Action<CommonDialogButtonWidget> onClickWidgetCallback, CommonDialogButtonGroupWidget.ButtonType buttonType = CommonDialogButtonGroupWidget.ButtonType.Positive, bool muteClickSe = false, bool isDefault = false, [Optional] string goName, TransitionAlongDirection.DirectionFlag useWideTranFlags = (TransitionAlongDirection.DirectionFlag)0)
	{
	}
}
