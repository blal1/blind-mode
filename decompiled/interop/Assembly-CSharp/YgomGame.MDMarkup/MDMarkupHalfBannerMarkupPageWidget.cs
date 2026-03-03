using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CF4")]
public class MDMarkupHalfBannerMarkupPageWidget : MDMarkupPageWidgetBase
{
	[Token(Token = "0x6004E35")]
	[Address(RVA = "0x952F70", Offset = "0x952170", VA = "0x180952F70")]
	public MDMarkupHalfBannerMarkupPageWidget(ElementObjectManager eom, MDMarkupIndentWidget indentWidget)
	{
	}

	[Token(Token = "0x6004E36")]
	[Address(RVA = "0x954A30", Offset = "0x953C30", VA = "0x180954A30", Slot = "25")]
	protected override MDMarkupBannerContext GetBannerContext(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E37")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "23")]
	protected override GlobalTextData GetCaptionText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E38")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "24")]
	protected override GlobalTextData GetText(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E39")]
	[Address(RVA = "0x954AA0", Offset = "0x953CA0", VA = "0x180954AA0", Slot = "27")]
	protected override List<URLSchemeButton> GetButtons(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}

	[Token(Token = "0x6004E3A")]
	[Address(RVA = "0x954B30", Offset = "0x953D30", VA = "0x180954B30", Slot = "28")]
	protected override List<IMDMarkupContent> GetMarkupContents(IMDMarkupContent mdMarkupContent)
	{
		return null;
	}
}
