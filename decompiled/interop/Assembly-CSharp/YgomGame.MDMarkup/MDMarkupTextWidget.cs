using Il2CppDummyDll;
using TMPro;
using YgomSystem.ElementSystem;
using YgomSystem.YGomTMPro;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D0F")]
public class MDMarkupTextWidget : MDMarkupWidgetBase, IMDMarkupTMPWidget
{
	[Token(Token = "0x4009D7A")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelText;

	[Token(Token = "0x4009D7B")]
	[FieldOffset(Offset = "0x30")]
	public readonly TextMeshProUGUI text;

	[Token(Token = "0x6004EF7")]
	[Address(RVA = "0x9750B0", Offset = "0x9742B0", VA = "0x1809750B0")]
	public MDMarkupTextWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004EF8")]
	[Address(RVA = "0x974F10", Offset = "0x974110", VA = "0x180974F10", Slot = "17")]
	public override void BindContentData(IMDMarkupContent contentData)
	{
	}

	[Token(Token = "0x6004EF9")]
	[Address(RVA = "0x974E20", Offset = "0x974020", VA = "0x180974E20", Slot = "19")]
	public void AssignTMPGlyphCreateBuffer(ITextMeshProGlyphCreateBuffer tmpGlyphCreateBuffer)
	{
	}
}
