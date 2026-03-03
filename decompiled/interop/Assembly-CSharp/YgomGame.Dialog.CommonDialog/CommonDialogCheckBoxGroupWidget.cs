using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FC8")]
public class CommonDialogCheckBoxGroupWidget : ContentWidgetBase<CommonDialogCheckBoxGroupWidget, EntryCheckBoxListData>
{
	[Token(Token = "0x400AAB9")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelTemplateCheckBox;

	[Token(Token = "0x400AABA")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsEnableMulti;

	[Token(Token = "0x400AABB")]
	[FieldOffset(Offset = "0x40")]
	private ElementObjectManager m_TemplateCheckBoxEom;

	[Token(Token = "0x400AABC")]
	[FieldOffset(Offset = "0x48")]
	private List<CommonDialogCheckBoxWidget> m_CheckBoxes;

	[Token(Token = "0x400AABD")]
	[FieldOffset(Offset = "0x50")]
	private LayoutElement m_LayoutElement;

	[Token(Token = "0x400AABE")]
	[FieldOffset(Offset = "0x58")]
	private Action<List<bool>> OnCompleteCallback;

	[Token(Token = "0x6005F95")]
	[Address(RVA = "0xA4FCE0", Offset = "0xA4EEE0", VA = "0x180A4FCE0")]
	public static CommonDialogCheckBoxGroupWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005F96")]
	[Address(RVA = "0xA4FC00", Offset = "0xA4EE00", VA = "0x180A4FC00", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005F97")]
	[Address(RVA = "0xA4FD20", Offset = "0xA4EF20", VA = "0x180A4FD20")]
	public CommonDialogCheckBoxWidget GetCheckBoxWidget(int idx)
	{
		return null;
	}

	[Token(Token = "0x6005F98")]
	[Address(RVA = "0xA4FFA0", Offset = "0xA4F1A0", VA = "0x180A4FFA0", Slot = "24")]
	protected override void InnerBinding(EntryCheckBoxListData entryData)
	{
	}

	[Token(Token = "0x6005F99")]
	[Address(RVA = "0xA50610", Offset = "0xA4F810", VA = "0x180A50610")]
	private void UpdateCheckBoxes(int index, bool isOn)
	{
	}

	[Token(Token = "0x6005F9A")]
	[Address(RVA = "0xA503C0", Offset = "0xA4F5C0", VA = "0x180A503C0")]
	public void OnCompleteEvent()
	{
	}

	[Token(Token = "0x6005F9B")]
	[Address(RVA = "0xA4FDA0", Offset = "0xA4EFA0", VA = "0x180A4FDA0")]
	public List<bool> GetCheckValues()
	{
		return null;
	}

	[Token(Token = "0x6005F9C")]
	[Address(RVA = "0xA508C0", Offset = "0xA4FAC0", VA = "0x180A508C0")]
	public CommonDialogCheckBoxGroupWidget()
	{
	}
}
