using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.MDMarkup;

[Token(Token = "0x2000CCB")]
public class MDMarkupTableCellFactory
{
	[Token(Token = "0x4009C2B")]
	[FieldOffset(Offset = "0x10")]
	private readonly ElementObjectManager m_NormalTextTemplate;

	[Token(Token = "0x4009C2C")]
	[FieldOffset(Offset = "0x18")]
	private readonly ElementObjectManager m_HeaderTextTemplate;

	[Token(Token = "0x4009C2D")]
	[FieldOffset(Offset = "0x20")]
	private readonly ElementObjectManager m_ImageTemplate;

	[Token(Token = "0x4009C2E")]
	[FieldOffset(Offset = "0x28")]
	private readonly ElementObjectManager m_CardTemplate;

	[Token(Token = "0x4009C2F")]
	[FieldOffset(Offset = "0x30")]
	private readonly ElementObjectManager m_ItemTemplate;

	[Token(Token = "0x4009C30")]
	[FieldOffset(Offset = "0x38")]
	private readonly ElementObjectManager m_BannerTemplate;

	[Token(Token = "0x4009C31")]
	[FieldOffset(Offset = "0x40")]
	private readonly ElementObjectManager m_ButtonSTemplate;

	[Token(Token = "0x4009C32")]
	[FieldOffset(Offset = "0x48")]
	private readonly ElementObjectManager m_ButtonMTemplate;

	[Token(Token = "0x4009C33")]
	[FieldOffset(Offset = "0x50")]
	private readonly ElementObjectManager m_ButtonLTemplate;

	[Token(Token = "0x6004D73")]
	[Address(RVA = "0x95B8F0", Offset = "0x95AAF0", VA = "0x18095B8F0")]
	public MDMarkupTableCellFactory(ElementObjectManager normalTemplate, ElementObjectManager headerTemplate, ElementObjectManager imageTemplate, ElementObjectManager cardTemplate, ElementObjectManager itemTemplate, ElementObjectManager bannerTemplate, ElementObjectManager buttonSTemplate, ElementObjectManager buttonMTemplate, ElementObjectManager buttonLTemplate)
	{
	}

	[Token(Token = "0x6004D74")]
	[Address(RVA = "0x95B8D0", Offset = "0x95AAD0", VA = "0x18095B8D0")]
	private ElementObjectManager GetTextCellTemplate(MDMarkupDef.TableRowStyle rowStyle)
	{
		return null;
	}

	[Token(Token = "0x6004D75")]
	[Address(RVA = "0x95B780", Offset = "0x95A980", VA = "0x18095B780")]
	public MDMarkupTableCellText CreateTextCell(MDMarkupTableRow parentRow, MDMarkupDef.TableRowStyle rowStyle)
	{
		return null;
	}

	[Token(Token = "0x6004D76")]
	[Address(RVA = "0x95B590", Offset = "0x95A790", VA = "0x18095B590")]
	public MDMarkupTableCellImage CreateImageCell(MDMarkupTableRow parentRow)
	{
		return null;
	}

	[Token(Token = "0x6004D77")]
	[Address(RVA = "0x95B4D0", Offset = "0x95A6D0", VA = "0x18095B4D0")]
	public MDMarkupTableCellCard CreateCardCell(MDMarkupTableRow parentRow)
	{
		return null;
	}

	[Token(Token = "0x6004D78")]
	[Address(RVA = "0x95B6C0", Offset = "0x95A8C0", VA = "0x18095B6C0")]
	public MDMarkupTableCellItem CreateItemCell(MDMarkupTableRow parentRow)
	{
		return null;
	}

	[Token(Token = "0x6004D79")]
	[Address(RVA = "0x95B280", Offset = "0x95A480", VA = "0x18095B280")]
	public MDMarkupTableCellBanner CreateBannerCell(MDMarkupTableRow parentRow)
	{
		return null;
	}

	[Token(Token = "0x6004D7A")]
	[Address(RVA = "0x95B3F0", Offset = "0x95A5F0", VA = "0x18095B3F0")]
	public MDMarkupTableCellButton CreateButtonCell(MDMarkupTableRow parentRow, MDMarkupDef.ButtonStyle buttonStyle)
	{
		return null;
	}
}
