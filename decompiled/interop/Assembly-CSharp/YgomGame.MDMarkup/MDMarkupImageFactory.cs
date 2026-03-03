using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CC7")]
public class MDMarkupImageFactory : MDMarkupWidgetFactoryBase
{
	[Token(Token = "0x4009C25")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_Template;

	[Token(Token = "0x6004D68")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public MDMarkupImageFactory(ElementObjectManager template)
	{
	}

	[Token(Token = "0x6004D69")]
	[Address(RVA = "0x955160", Offset = "0x954360", VA = "0x180955160", Slot = "5")]
	public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
	{
		return null;
	}
}
