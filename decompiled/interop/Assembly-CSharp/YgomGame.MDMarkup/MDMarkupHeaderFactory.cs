using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CC6")]
public class MDMarkupHeaderFactory : MDMarkupWidgetFactoryBase
{
	[Token(Token = "0x4009C24")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_Template;

	[Token(Token = "0x6004D66")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public MDMarkupHeaderFactory(ElementObjectManager template)
	{
	}

	[Token(Token = "0x6004D67")]
	[Address(RVA = "0x954FB0", Offset = "0x9541B0", VA = "0x180954FB0", Slot = "5")]
	public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
	{
		return null;
	}
}
