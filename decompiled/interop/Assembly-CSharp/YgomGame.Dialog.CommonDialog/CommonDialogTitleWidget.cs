using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FDA")]
public class CommonDialogTitleWidget : ContentWidgetBase<CommonDialogTitleWidget, EntryTitleData>
{
	[Token(Token = "0x2000FDB")]
	public enum IconType
	{
		[Token(Token = "0x400AB40")]
		None,
		[Token(Token = "0x400AB41")]
		Notice,
		[Token(Token = "0x400AB42")]
		Alert
	}

	[Token(Token = "0x400AB39")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelIcon;

	[Token(Token = "0x400AB3A")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400AB3B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Sprite m_NoticeIcon;

	[Token(Token = "0x400AB3C")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Sprite m_AlertIcon;

	[Token(Token = "0x400AB3D")]
	[FieldOffset(Offset = "0x50")]
	private Image m_IconImage;

	[Token(Token = "0x400AB3E")]
	[FieldOffset(Offset = "0x58")]
	private TMP_Text m_Text;

	[Token(Token = "0x600600F")]
	[Address(RVA = "0xA58070", Offset = "0xA57270", VA = "0x180A58070")]
	public static CommonDialogTitleWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6006010")]
	[Address(RVA = "0xA57FB0", Offset = "0xA571B0", VA = "0x180A57FB0", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6006011")]
	[Address(RVA = "0xA580E0", Offset = "0xA572E0", VA = "0x180A580E0", Slot = "24")]
	protected override void InnerBinding(EntryTitleData entryData)
	{
	}

	[Token(Token = "0x6006012")]
	[Address(RVA = "0xA582A0", Offset = "0xA574A0", VA = "0x180A582A0")]
	public CommonDialogTitleWidget()
	{
	}
}
