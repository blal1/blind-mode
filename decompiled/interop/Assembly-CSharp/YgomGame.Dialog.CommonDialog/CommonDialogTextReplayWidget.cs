using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FD8")]
public class CommonDialogTextReplayWidget : ContentWidgetBase<CommonDialogTextReplayWidget, EntryTextReplayData>
{
	[Token(Token = "0x400AB33")]
	[FieldOffset(Offset = "0x30")]
	private GameObject m_Base;

	[Token(Token = "0x400AB34")]
	[FieldOffset(Offset = "0x38")]
	private TMP_Text m_Text;

	[Token(Token = "0x400AB35")]
	[FieldOffset(Offset = "0x40")]
	private TMP_Text m_TextNum;

	[Token(Token = "0x400AB36")]
	[FieldOffset(Offset = "0x48")]
	private TMP_Text m_TextUnit;

	[Token(Token = "0x6006007")]
	[Address(RVA = "0xA57B50", Offset = "0xA56D50", VA = "0x180A57B50")]
	public static CommonDialogTextReplayWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6006008")]
	[Address(RVA = "0xA579F0", Offset = "0xA56BF0", VA = "0x180A579F0", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6006009")]
	[Address(RVA = "0xA57B90", Offset = "0xA56D90", VA = "0x180A57B90", Slot = "24")]
	protected override void InnerBinding(EntryTextReplayData entryData)
	{
	}

	[Token(Token = "0x600600A")]
	[Address(RVA = "0xA57D00", Offset = "0xA56F00", VA = "0x180A57D00")]
	public CommonDialogTextReplayWidget()
	{
	}
}
