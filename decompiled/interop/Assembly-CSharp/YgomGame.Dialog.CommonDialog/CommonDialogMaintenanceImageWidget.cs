using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomGame.Dialog.CommonDialog;

[Token(Token = "0x2000FD5")]
public class CommonDialogMaintenanceImageWidget : ContentWidgetBase<CommonDialogMaintenanceImageWidget, EntryMaintenanceImageData>
{
	[Token(Token = "0x400AB29")]
	[FieldOffset(Offset = "0x30")]
	private TMP_Text m_TextTitle;

	[Token(Token = "0x400AB2A")]
	[FieldOffset(Offset = "0x38")]
	private TMP_Text m_TextDate;

	[Token(Token = "0x400AB2B")]
	[FieldOffset(Offset = "0x40")]
	private Image m_Image;

	[Token(Token = "0x400AB2C")]
	[FieldOffset(Offset = "0x48")]
	private Action m_OnCompleteCallback;

	[Token(Token = "0x6005FF6")]
	[Address(RVA = "0xA57150", Offset = "0xA56350", VA = "0x180A57150")]
	public static CommonDialogMaintenanceImageWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6005FF7")]
	[Address(RVA = "0xA57030", Offset = "0xA56230", VA = "0x180A57030", Slot = "17")]
	protected override void CollectComponents()
	{
	}

	[Token(Token = "0x6005FF8")]
	[Address(RVA = "0xA57190", Offset = "0xA56390", VA = "0x180A57190", Slot = "24")]
	protected override void InnerBinding(EntryMaintenanceImageData entryData)
	{
	}

	[Token(Token = "0x6005FF9")]
	[Address(RVA = "0xA56FC0", Offset = "0xA561C0", VA = "0x180A56FC0")]
	public void AsyncBinding(IEntryData entryData, Action onComplete)
	{
	}

	[Token(Token = "0x6005FFA")]
	[Address(RVA = "0xA57610", Offset = "0xA56810", VA = "0x180A57610")]
	public CommonDialogMaintenanceImageWidget()
	{
	}
}
