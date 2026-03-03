using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CDF")]
public class MDMarkupFullImagePageWidget : MDMarkupPageWidgetBase
{
	[Token(Token = "0x6004DCE")]
	[Address(RVA = "0x952F70", Offset = "0x952170", VA = "0x180952F70")]
	public MDMarkupFullImagePageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004DCF")]
	[Address(RVA = "0x952E50", Offset = "0x952050", VA = "0x180952E50", Slot = "23")]
	protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004DD0")]
	[Address(RVA = "0x952EE0", Offset = "0x9520E0", VA = "0x180952EE0", Slot = "26")]
	protected override string GetResourcePath(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004DD1")]
	[Address(RVA = "0x952DC0", Offset = "0x951FC0", VA = "0x180952DC0", Slot = "27")]
	protected override List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}
}
