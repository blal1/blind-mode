using Il2CppDummyDll;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000D01")]
public class MDMarkupPrefabWidget : MDMarkupWidgetBase
{
	[Token(Token = "0x4009D27")]
	[FieldOffset(Offset = "0x28")]
	private readonly MDMarkupPrefabsFactory m_PrefabsFactory;

	[Token(Token = "0x6004E7B")]
	[Address(RVA = "0x9585B0", Offset = "0x9577B0", VA = "0x1809585B0")]
	public MDMarkupPrefabWidget(MDMarkupIndentWidget indentWidget, MDMarkupPrefabsFactory prefabsFactory)
	{
	}

	[Token(Token = "0x6004E7C")]
	[Address(RVA = "0x958430", Offset = "0x957630", VA = "0x180958430", Slot = "17")]
	public override void BindContentData(IMDMarkupContent contentData)
	{
	}
}
