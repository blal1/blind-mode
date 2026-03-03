using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Dialog.CommonDialog;
using YgomGame.Menu;
using YgomSystem.UI;

namespace YgomSample.VC;

[Token(Token = "0x2001DC1")]
public class SelectorSampleViewController : BaseMenuViewController
{
	[Token(Token = "0x4010512")]
	[FieldOffset(Offset = "0xD0")]
	private readonly string mainButtonLabel;

	[Token(Token = "0x4010513")]
	[FieldOffset(Offset = "0xD8")]
	private readonly string subButtonLabel;

	[Token(Token = "0x4010514")]
	[FieldOffset(Offset = "0xE0")]
	private readonly string buttonLabel;

	[Token(Token = "0x4010515")]
	[FieldOffset(Offset = "0xE8")]
	private readonly string buttonTextLabel;

	[Token(Token = "0x4010516")]
	[FieldOffset(Offset = "0xF0")]
	private readonly string mainButtonText;

	[Token(Token = "0x4010517")]
	private const int buttonNum = 3;

	[Token(Token = "0x4010518")]
	private const float holdTime = 1f;

	[Token(Token = "0x4010519")]
	[FieldOffset(Offset = "0xF8")]
	private readonly string[] subButtonsText;

	[Token(Token = "0x401051A")]
	[FieldOffset(Offset = "0x100")]
	private string nextButtonText;

	[Token(Token = "0x401051B")]
	[FieldOffset(Offset = "0x108")]
	private List<EntryCheckBoxListData.EntryCheckBoxData> checkBoxDatas;

	[Token(Token = "0x401051C")]
	[FieldOffset(Offset = "0x110")]
	private List<EntryCheckBoxListData.EntryCheckBoxData> secondKeyDatas;

	[Token(Token = "0x401051D")]
	[FieldOffset(Offset = "0x118")]
	[SerializeField]
	private ViewController viewControllerPref;

	[Token(Token = "0x600BE37")]
	[Address(RVA = "0x3E4080", Offset = "0x3E3280", VA = "0x1803E4080", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600BE38")]
	[Address(RVA = "0x58E430", Offset = "0x58D630", VA = "0x18058E430", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600BE39")]
	[Address(RVA = "0x58F110", Offset = "0x58E310", VA = "0x18058F110")]
	public SelectorSampleViewController()
	{
	}
}
