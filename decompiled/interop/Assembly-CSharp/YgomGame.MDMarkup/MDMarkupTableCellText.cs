using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D09")]
public class MDMarkupTableCellText : MDMarkupTableCellBase, IMDMarkupTMPWidget
{
	[Token(Token = "0x4009D5C")]
	[FieldOffset(Offset = "0x30")]
	private readonly string k_ELabelText;

	[Token(Token = "0x4009D5D")]
	[FieldOffset(Offset = "0x38")]
	public readonly TextMeshProUGUI text;

	[Token(Token = "0x6004ECC")]
	[Address(RVA = "0x95C260", Offset = "0x95B460", VA = "0x18095C260")]
	public MDMarkupTableCellText(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6004ECD")]
	[Address(RVA = "0x95C110", Offset = "0x95B310", VA = "0x18095C110", Slot = "16")]
	public override void SetAlignment(TextAlignmentOptions alignment)
	{
	}

	[Token(Token = "0x6004ECE")]
	[Address(RVA = "0x95C230", Offset = "0x95B430", VA = "0x18095C230")]
	public void SetText(string text)
	{
	}

	[Token(Token = "0x6004ECF")]
	[Address(RVA = "0x95C080", Offset = "0x95B280", VA = "0x18095C080", Slot = "17")]
	public void AssignTMPGlyphCreateBuffer(ITextMeshProGlyphCreateBuffer tmpGlyphCreateBuffer)
	{
	}
}
