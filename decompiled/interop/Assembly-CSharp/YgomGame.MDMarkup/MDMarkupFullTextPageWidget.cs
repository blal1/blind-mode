using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CE0")]
public class MDMarkupFullTextPageWidget : MDMarkupPageWidgetBase
{
	[Token(Token = "0x6004DD2")]
	[Address(RVA = "0x952F70", Offset = "0x952170", VA = "0x180952F70")]
	public MDMarkupFullTextPageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004DD3")]
	[Address(RVA = "0x953010", Offset = "0x952210", VA = "0x180953010", Slot = "23")]
	protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004DD4")]
	[Address(RVA = "0x9530A0", Offset = "0x9522A0", VA = "0x1809530A0", Slot = "24")]
	protected override GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004DD5")]
	[Address(RVA = "0x952F80", Offset = "0x952180", VA = "0x180952F80", Slot = "27")]
	protected override List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}
}
