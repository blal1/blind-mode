using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomSystem.UI.MultiVCTab;

[Token(Token = "0x20005F3")]
public class MultiVCTabWidget : ElementWidgetBase
{
	[Token(Token = "0x4001C8B")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x4001C8C")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelOn;

	[Token(Token = "0x4001C8D")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOff;

	[Token(Token = "0x4001C8E")]
	private const string k_ELabelOnText = "OnText";

	[Token(Token = "0x4001C8F")]
	private const string k_ELabelOffText = "OffText";

	[Token(Token = "0x4001C90")]
	private const string k_ELabelBadge = "Badge";

	[Token(Token = "0x4001C91")]
	private const string k_ELabelExIconRoot = "EXIconRoot";

	[Token(Token = "0x4001C92")]
	private const string k_TLabelToOn = "ToOn";

	[Token(Token = "0x4001C93")]
	[FieldOffset(Offset = "0x38")]
	private bool m_ToOnDirty;

	[Token(Token = "0x4001C94")]
	[FieldOffset(Offset = "0x40")]
	public readonly SelectionButton button;

	[Token(Token = "0x4001C95")]
	[FieldOffset(Offset = "0x48")]
	public readonly GameObject onImage;

	[Token(Token = "0x4001C96")]
	[FieldOffset(Offset = "0x50")]
	public readonly GameObject offImage;

	[Token(Token = "0x4001C97")]
	[FieldOffset(Offset = "0x58")]
	public readonly GameObject badge;

	[Token(Token = "0x4001C98")]
	[FieldOffset(Offset = "0x60")]
	public readonly GameObject ExIconRoot;

	[Token(Token = "0x4001C99")]
	[FieldOffset(Offset = "0x68")]
	private List<Tween> m_TCache_ToOn;

	[Token(Token = "0x6002700")]
	[Address(RVA = "0x698EE0", Offset = "0x6980E0", VA = "0x180698EE0")]
	public MultiVCTabWidget(ElementObjectManager eom, bool isOn = false)
	{
	}

	[Token(Token = "0x6002701")]
	[Address(RVA = "0x698E10", Offset = "0x698010", VA = "0x180698E10")]
	public void SetLabel(string label)
	{
	}

	[Token(Token = "0x6002702")]
	[Address(RVA = "0x698C30", Offset = "0x697E30", VA = "0x180698C30")]
	public void SetIsOn(bool isOn)
	{
	}
}
