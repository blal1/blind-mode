using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CCC")]
public class MDMarkupTableFactory : MDMarkupWidgetFactoryBase
{
	[Token(Token = "0x4009C34")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_Template;

	[Token(Token = "0x4009C35")]
	[FieldOffset(Offset = "0x18")]
	private readonly ElementObjectManager m_CellTemplate;

	[Token(Token = "0x4009C36")]
	[FieldOffset(Offset = "0x20")]
	private readonly MDMarkupTableRowFactory m_RowFactory;

	[Token(Token = "0x4009C37")]
	[FieldOffset(Offset = "0x28")]
	private readonly MDMarkupTableCellFactory m_CellFactory;

	[Token(Token = "0x6004D7B")]
	[Address(RVA = "0x95C4D0", Offset = "0x95B6D0", VA = "0x18095C4D0")]
	public MDMarkupTableFactory(ElementObjectManager template, ElementObjectManager cellTableTemplate, ElementObjectManager rowTemplate, ElementObjectManager cellHeaderTemplate, ElementObjectManager cellNormalTemplate, ElementObjectManager cellImageTemplate, ElementObjectManager cellCardTemplate, ElementObjectManager cellItemTemplate, ElementObjectManager bannerTemplate, ElementObjectManager buttonSTemplate, ElementObjectManager buttonMTemplate, ElementObjectManager buttonLTemplate)
	{
	}

	[Token(Token = "0x6004D7C")]
	[Address(RVA = "0x95C300", Offset = "0x95B500", VA = "0x18095C300", Slot = "5")]
	public override IMDMarkupWidget CreateChild(MDMarkupIndentWidget indentWidget)
	{
		return null;
	}

	[Token(Token = "0x6004D7D")]
	[Address(RVA = "0x95C3F0", Offset = "0x95B5F0", VA = "0x18095C3F0")]
	public MDMarkupTableWidget CreateTableCell(MDMarkupIndentWidget indentWidget, Transform parent)
	{
		return null;
	}
}
