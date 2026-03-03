using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F37")]
public class DuelLiveTabWidget : ElementWidgetBase
{
	[Token(Token = "0x400A6B3")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x400A6B4")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelOn;

	[Token(Token = "0x400A6B5")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOff;

	[Token(Token = "0x400A6B6")]
	private const string k_ELabelOnText = "OnText";

	[Token(Token = "0x400A6B7")]
	private const string k_ELabelOffText = "OffText";

	[Token(Token = "0x400A6B8")]
	private const string k_ELabelBadge = "Badge";

	[Token(Token = "0x400A6B9")]
	private const string k_ELabelExIconRoot = "EXIconRoot";

	[Token(Token = "0x400A6BA")]
	[FieldOffset(Offset = "0x38")]
	public readonly SelectionButton button;

	[Token(Token = "0x400A6BB")]
	[FieldOffset(Offset = "0x40")]
	public readonly GameObject onImage;

	[Token(Token = "0x400A6BC")]
	[FieldOffset(Offset = "0x48")]
	public readonly GameObject offImage;

	[Token(Token = "0x400A6BD")]
	[FieldOffset(Offset = "0x50")]
	public readonly GameObject badge;

	[Token(Token = "0x400A6BE")]
	[FieldOffset(Offset = "0x58")]
	public readonly GameObject ExIconRoot;

	[Token(Token = "0x6005C4A")]
	[Address(RVA = "0xA1DAA0", Offset = "0xA1CCA0", VA = "0x180A1DAA0")]
	public DuelLiveTabWidget(ElementObjectManager eom, bool isOn = false)
	{
	}

	[Token(Token = "0x6005C4B")]
	[Address(RVA = "0xA1D9D0", Offset = "0xA1CBD0", VA = "0x180A1D9D0")]
	public void SetLabel(string label)
	{
	}

	[Token(Token = "0x6005C4C")]
	[Address(RVA = "0xA1D980", Offset = "0xA1CB80", VA = "0x180A1D980")]
	public void SetIsOn(bool isOn)
	{
	}
}
