using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CCE")]
public class MarkupTextFactory : MDMarkupWidgetFactoryBase
{
	[Token(Token = "0x4009C39")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_Template;

	[Token(Token = "0x6004D80")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public MarkupTextFactory(ElementObjectManager template)
	{
	}

	[Token(Token = "0x6004D81")]
	[Address(RVA = "0x95D540", Offset = "0x95C740", VA = "0x18095D540", Slot = "5")]
	public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
	{
		return null;
	}
}
