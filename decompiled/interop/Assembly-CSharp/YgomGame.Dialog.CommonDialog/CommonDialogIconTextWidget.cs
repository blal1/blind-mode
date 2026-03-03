using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FCB")]
public class CommonDialogIconTextWidget : ContentWidgetBase<CommonDialogIconTextWidget, EntryIconTextData>
{
	[Token(Token = "0x2000FCC")]
	public enum IconType
	{
		[Token(Token = "0x400AAF6")]
		None,
		[Token(Token = "0x400AAF7")]
		Path,
		[Token(Token = "0x400AAF8")]
		Gem,
		[Token(Token = "0x400AAF9")]
		Item
	}

	[Token(Token = "0x400AAEC")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelIcon;

	[Token(Token = "0x400AAED")]
	[FieldOffset(Offset = "0x38")]
	private readonly string k_ELabelText;

	[Token(Token = "0x400AAEE")]
	[FieldOffset(Offset = "0x40")]
	private readonly string k_ELabelNumText;

	[Token(Token = "0x400AAEF")]
	[FieldOffset(Offset = "0x48")]
	private readonly string k_ELabelBase;

	[Token(Token = "0x400AAF0")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private Sprite m_GemIcon;

	[Token(Token = "0x400AAF1")]
	[FieldOffset(Offset = "0x58")]
	private Image m_IconImage;

	[Token(Token = "0x400AAF2")]
	[FieldOffset(Offset = "0x60")]
	private TMP_Text m_Text;

	[Token(Token = "0x400AAF3")]
	[FieldOffset(Offset = "0x68")]
	private TMP_Text m_NumText;

	[Token(Token = "0x400AAF4")]
	[FieldOffset(Offset = "0x70")]
	private GameObject m_Base;

	[Token(Token = "0x6005FBC")]
	[Address(RVA = "0xA53F40", Offset = "0xA53140", VA = "0x180A53F40")]
	public static CommonDialogIconTextWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FBD")]
	[Address(RVA = "0xA53E10", Offset = "0xA53010", VA = "0x180A53E10", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FBE")]
	[Address(RVA = "0xA53FB0", Offset = "0xA531B0", VA = "0x180A53FB0", Slot = "24")]
	protected override void InnerBinding(EntryIconTextData entryData)
	{
	}

	[Token(Token = "0x6005FBF")]
	[Address(RVA = "0xA54230", Offset = "0xA53430", VA = "0x180A54230")]
	public CommonDialogIconTextWidget()
	{
	}
}
