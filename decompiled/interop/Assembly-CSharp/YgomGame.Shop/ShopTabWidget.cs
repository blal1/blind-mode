using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000967")]
public class ShopTabWidget : ElementWidgetBase
{
	[Token(Token = "0x4008B7D")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelButton;

	[Token(Token = "0x4008B7E")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelOn;

	[Token(Token = "0x4008B7F")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelOff;

	[Token(Token = "0x4008B80")]
	private const string k_ELabelOnText = "OnText";

	[Token(Token = "0x4008B81")]
	private const string k_ELabelOffText = "OffText";

	[Token(Token = "0x4008B82")]
	private const string k_ELabelBadge = "Badge";

	[Token(Token = "0x4008B83")]
	private const string k_ELabelIcon = "Icon";

	[Token(Token = "0x4008B84")]
	private const string k_TLabelToOn = "ToOn";

	[Token(Token = "0x4008B85")]
	[FieldOffset(Offset = "0x38")]
	public readonly SelectionButton button;

	[Token(Token = "0x4008B86")]
	[FieldOffset(Offset = "0x40")]
	public readonly GameObject onImage;

	[Token(Token = "0x4008B87")]
	[FieldOffset(Offset = "0x48")]
	public readonly GameObject offImage;

	[Token(Token = "0x4008B88")]
	[FieldOffset(Offset = "0x50")]
	public readonly GameObject badge;

	[Token(Token = "0x4008B89")]
	[FieldOffset(Offset = "0x58")]
	public readonly GameObject icon;

	[Token(Token = "0x4008B8A")]
	[FieldOffset(Offset = "0x60")]
	private bool m_ToOnDirty;

	[Token(Token = "0x4008B8B")]
	[FieldOffset(Offset = "0x68")]
	private List<Tween> m_TCache_ToOn;

	[Token(Token = "0x6003957")]
	[Address(RVA = "0x800190", Offset = "0x7FF390", VA = "0x180800190")]
	public ShopTabWidget(ElementObjectManager eom, bool isScrollItem, bool isOn = false)
	{
	}

	[Token(Token = "0x6003958")]
	[Address(RVA = "0x8000C0", Offset = "0x7FF2C0", VA = "0x1808000C0")]
	public void SetLabel(string label)
	{
	}

	[Token(Token = "0x6003959")]
	[Address(RVA = "0x7FFDF0", Offset = "0x7FEFF0", VA = "0x1807FFDF0")]
	public void SetIcon(string iconPath)
	{
	}

	[Token(Token = "0x600395A")]
	[Address(RVA = "0x7FFEE0", Offset = "0x7FF0E0", VA = "0x1807FFEE0")]
	public void SetIsOn(bool isOn)
	{
	}
}
