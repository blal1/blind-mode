using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FD9")]
public class CommonDialogTextWidget : ContentWidgetBase<CommonDialogTextWidget, EntryTextData>
{
	[Token(Token = "0x400AB37")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_Base;

	[Token(Token = "0x400AB38")]
	[FieldOffset(Offset = "0x38")]
	private TMP_Text m_Text;

	[Token(Token = "0x600600B")]
	[Address(RVA = "0xA57E10", Offset = "0xA57010", VA = "0x180A57E10")]
	public static CommonDialogTextWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x600600C")]
	[Address(RVA = "0xA57D40", Offset = "0xA56F40", VA = "0x180A57D40", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x600600D")]
	[Address(RVA = "0xA57E50", Offset = "0xA57050", VA = "0x180A57E50", Slot = "24")]
	protected override void InnerBinding(EntryTextData entryData)
	{
	}

	[Token(Token = "0x600600E")]
	[Address(RVA = "0xA57F70", Offset = "0xA57170", VA = "0x180A57F70")]
	public CommonDialogTextWidget()
	{
	}
}
