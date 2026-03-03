using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CF6")]
public class MDMarkupHalfImageTextPageWidget : MDMarkupPageWidgetBase
{
	[Token(Token = "0x6004E41")]
	[Address(RVA = "0x952F70", Offset = "0x952170", VA = "0x180952F70")]
	public MDMarkupHalfImageTextPageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004E42")]
	[Address(RVA = "0x954E00", Offset = "0x954000", VA = "0x180954E00", Slot = "23")]
	protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E43")]
	[Address(RVA = "0x954F20", Offset = "0x954120", VA = "0x180954F20", Slot = "24")]
	protected override GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E44")]
	[Address(RVA = "0x954E90", Offset = "0x954090", VA = "0x180954E90", Slot = "26")]
	protected override string GetResourcePath(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E45")]
	[Address(RVA = "0x954D70", Offset = "0x953F70", VA = "0x180954D70", Slot = "27")]
	protected override List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}
}
