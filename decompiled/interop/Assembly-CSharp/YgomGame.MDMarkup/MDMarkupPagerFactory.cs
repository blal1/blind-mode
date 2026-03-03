using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CC9")]
public class MDMarkupPagerFactory : MDMarkupWidgetFactoryBase
{
	[Token(Token = "0x4009C28")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_Template;

	[Token(Token = "0x4009C29")]
	[FieldOffset(Offset = "0x18")]
	private readonly MDMarkupDef.MarkupType markupType;

	[Token(Token = "0x6004D6E")]
	[Address(RVA = "0x955B70", Offset = "0x954D70", VA = "0x180955B70")]
	public MDMarkupPagerFactory(ElementObjectManager template, MDMarkupDef.MarkupType markupType)
	{
	}

	[Token(Token = "0x6004D6F")]
	[Address(RVA = "0x9582F0", Offset = "0x9574F0", VA = "0x1809582F0", Slot = "5")]
	public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
	{
		return null;
	}
}
