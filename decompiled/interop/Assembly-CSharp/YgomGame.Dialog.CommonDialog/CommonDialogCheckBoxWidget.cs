using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC9")]
public class CommonDialogCheckBoxWidget : ElementWidgetBehaviourBase<CommonDialogCheckBoxWidget>
{
	[Token(Token = "0x400AABF")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400AAC0")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOnEom;

	[Token(Token = "0x400AAC1")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelOffEom;

	[Token(Token = "0x400AAC2")]
	[FieldOffset(Offset = "0x40")]
	private int index;

	[Token(Token = "0x400AAC3")]
	[FieldOffset(Offset = "0x48")]
	private TMP_Text m_TextOn;

	[Token(Token = "0x400AAC4")]
	[FieldOffset(Offset = "0x50")]
	private TMP_Text m_TextOff;

	[Token(Token = "0x400AAC5")]
	[FieldOffset(Offset = "0x58")]
	private SelectionButton m_Button;

	[Token(Token = "0x400AAC6")]
	[FieldOffset(Offset = "0x60")]
	private ElementObjectManager m_On;

	[Token(Token = "0x400AAC7")]
	[FieldOffset(Offset = "0x68")]
	private ElementObjectManager m_Off;

	[Token(Token = "0x400AAC8")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<bool, string> m_ClickSELabels;

	[Token(Token = "0x400AAC9")]
	[FieldOffset(Offset = "0x78")]
	public Action<int, bool> OnValueChanegedCallBack;

	[Token(Token = "0x17000F13")]
	public bool isOn
	{
		[Token(Token = "0x6005F9E")]
		[Address(RVA = "0xA50F60", Offset = "0xA50160", VA = "0x180A50F60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6005F9F")]
		[Address(RVA = "0xA50F90", Offset = "0xA50190", VA = "0x180A50F90")]
		set
		{
		}
	}

	[Token(Token = "0x6005FA0")]
	[Address(RVA = "0xA50C50", Offset = "0xA4FE50", VA = "0x180A50C50")]
	public static CommonDialogCheckBoxWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FA1")]
	[Address(RVA = "0xA50AC0", Offset = "0xA4FCC0", VA = "0x180A50AC0", Slot = "4")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FA2")]
	[Address(RVA = "0xA50970", Offset = "0xA4FB70", VA = "0x180A50970")]
	public CommonDialogCheckBoxWidget Binding(EntryCheckBoxListData.EntryCheckBoxData entryData, int index)
	{
		return null;
	}

	[Token(Token = "0x6005FA3")]
	[Address(RVA = "0xA50C90", Offset = "0xA4FE90", VA = "0x180A50C90")]
	private void OnClick()
	{
	}

	[Token(Token = "0x6005FA4")]
	[Address(RVA = "0xA50E00", Offset = "0xA50000", VA = "0x180A50E00")]
	public CommonDialogCheckBoxWidget()
	{
	}
}
