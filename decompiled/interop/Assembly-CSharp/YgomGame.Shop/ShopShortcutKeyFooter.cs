using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000974")]
public class ShopShortcutKeyFooter : ElementWidgetBase
{
	[Token(Token = "0x4008BB4")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelPlayButton;

	[Token(Token = "0x4008BB5")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelPlayIcon;

	[Token(Token = "0x4008BB6")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelPlayText;

	[Token(Token = "0x4008BB7")]
	[FieldOffset(Offset = "0x38")]
	public readonly SelectionButton playButton;

	[Token(Token = "0x4008BB8")]
	[FieldOffset(Offset = "0x40")]
	public readonly GameObject playIcon;

	[Token(Token = "0x4008BB9")]
	[FieldOffset(Offset = "0x48")]
	public readonly TMP_Text playText;

	[Token(Token = "0x60039A7")]
	[Address(RVA = "0x7FFC90", Offset = "0x7FEE90", VA = "0x1807FFC90")]
	public ShopShortcutKeyFooter(ElementObjectManager eom)
	{
	}
}
