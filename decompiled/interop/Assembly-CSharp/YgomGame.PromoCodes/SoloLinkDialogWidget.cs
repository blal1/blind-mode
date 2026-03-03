using Il2CppDummyDll;
using YgomGame.Dialog.CommonDialog;
using YgomSystem.ElementSystem;

namespace YgomGame.PromoCodes;

[Token(Token = "0x2000B7E")]
public class SoloLinkDialogWidget : ContentWidgetBase<SoloLinkDialogWidget, EntryInsertWidgetData>
{
	[Token(Token = "0x4009722")]
	private const string k_ELabel_TitleText = "TitleText";

	[Token(Token = "0x4009723")]
	private const string k_ELabel_ThumbHolder = "ThumbHolder";

	[Token(Token = "0x4009724")]
	[FieldOffset(Offset = "0x30")]
	private string m_Title;

	[Token(Token = "0x4009725")]
	[FieldOffset(Offset = "0x38")]
	private int m_GateId;

	[Token(Token = "0x600464D")]
	[Address(RVA = "0x8F33F0", Offset = "0x8F25F0", VA = "0x1808F33F0")]
	public static SoloLinkDialogWidget Create(ElementObjectManager eom, string title, int gateId)
	{
		return null;
	}

	[Token(Token = "0x600464E")]
	[Address(RVA = "0x8F34C0", Offset = "0x8F26C0", VA = "0x1808F34C0", Slot = "24")]
	protected override void InnerBinding(EntryInsertWidgetData entryData)
	{
	}

	[Token(Token = "0x600464F")]
	[Address(RVA = "0x8F37C0", Offset = "0x8F29C0", VA = "0x1808F37C0")]
	public SoloLinkDialogWidget()
	{
	}
}
