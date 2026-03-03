using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CF5")]
public class MDMarkupHalfImageMarkupPageWidget : MDMarkupPageWidgetBase
{
	[Token(Token = "0x6004E3B")]
	[Address(RVA = "0x952F70", Offset = "0x952170", VA = "0x180952F70")]
	public MDMarkupHalfImageMarkupPageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004E3C")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "23")]
	protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E3D")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "24")]
	protected override GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E3E")]
	[Address(RVA = "0x954CE0", Offset = "0x953EE0", VA = "0x180954CE0", Slot = "26")]
	protected override string GetResourcePath(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E3F")]
	[Address(RVA = "0x954BC0", Offset = "0x953DC0", VA = "0x180954BC0", Slot = "27")]
	protected override List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E40")]
	[Address(RVA = "0x954C50", Offset = "0x953E50", VA = "0x180954C50", Slot = "28")]
	protected override List<IMDMarkupContent> GetMarkupContents(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}
}
