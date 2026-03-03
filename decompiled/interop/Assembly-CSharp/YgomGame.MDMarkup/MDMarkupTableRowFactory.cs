using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CCD")]
public class MDMarkupTableRowFactory
{
	[Token(Token = "0x4009C38")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_RowTemplate;

	[Token(Token = "0x6004D7E")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public MDMarkupTableRowFactory(ElementObjectManager rowTemplate)
	{
	}

	[Token(Token = "0x6004D7F")]
	[Address(RVA = "0x95C670", Offset = "0x95B870", VA = "0x18095C670")]
	public MDMarkupTableRow Create(MDMarkupTableWidget parentTable)
	{
		return null;
	}
}
