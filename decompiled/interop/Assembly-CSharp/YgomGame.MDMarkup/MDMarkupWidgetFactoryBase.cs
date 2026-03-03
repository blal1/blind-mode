using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CD0")]
public abstract class MDMarkupWidgetFactoryBase : IMDMarkupWidgetFactory
{
	[Token(Token = "0x6004D83")]
	public abstract IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget);

	[Token(Token = "0x6004D84")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected MDMarkupWidgetFactoryBase()
	{
	}
}
