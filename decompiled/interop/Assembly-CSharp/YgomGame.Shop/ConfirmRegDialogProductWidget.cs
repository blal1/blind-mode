using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomGame.Shop;

[Token(Token = "0x200098C")]
public class ConfirmRegDialogProductWidget : ContentWidgetBase<ConfirmRegDialogProductWidget, EntryInsertWidgetData>
{
	[Token(Token = "0x4008C8F")]
	[FieldOffset(Offset = "0x30")]
	public string headerText;

	[Token(Token = "0x4008C90")]
	[FieldOffset(Offset = "0x38")]
	public string hasText;

	[Token(Token = "0x4008C91")]
	[FieldOffset(Offset = "0x40")]
	public string numText;

	[Token(Token = "0x6003A66")]
	[Address(RVA = "0x810100", Offset = "0x80F300", VA = "0x180810100")]
	public static ConfirmRegDialogProductWidget Create(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6003A67")]
	[Address(RVA = "0x810160", Offset = "0x80F360", VA = "0x180810160", Slot = "24")]
	protected override void InnerBinding(EntryInsertWidgetData entryData)
	{
	}

	[Token(Token = "0x6003A68")]
	[Address(RVA = "0x810350", Offset = "0x80F550", VA = "0x180810350")]
	public ConfirmRegDialogProductWidget()
	{
	}
}
