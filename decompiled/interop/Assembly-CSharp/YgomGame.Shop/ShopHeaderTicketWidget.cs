using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x20009E2")]
public class ShopHeaderTicketWidget : ElementWidgetBase
{
	[Token(Token = "0x4008E1D")]
	private const string k_ELabel_TicketTemplate = "TicketTemplate";

	[Token(Token = "0x4008E1E")]
	private const string k_ELabel_Ticket_TicketIcon = "TicketIcon";

	[Token(Token = "0x4008E1F")]
	private const string k_ELabel_Ticket_TicketLimitIcon = "TicketLimitIcon";

	[Token(Token = "0x4008E20")]
	private const string k_ELabel_Ticket_TicketNumText = "TicketNumText";

	[Token(Token = "0x4008E21")]
	[FieldOffset(Offset = "0x20")]
	public readonly SelectionButton button;

	[Token(Token = "0x4008E22")]
	[FieldOffset(Offset = "0x28")]
	private readonly UIEntityDuplicator m_TicketInfoDuplicator;

	[Token(Token = "0x4008E23")]
	[FieldOffset(Offset = "0x30")]
	public readonly List<(PriceContext priceCtx, bool limitedIconVisible)> contexts;

	[Token(Token = "0x6003C35")]
	[Address(RVA = "0x83B8E0", Offset = "0x83AAE0", VA = "0x18083B8E0")]
	public ShopHeaderTicketWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003C36")]
	[Address(RVA = "0x83B870", Offset = "0x83AA70", VA = "0x18083B870")]
	public void UpdateDataCount()
	{
	}

	[Token(Token = "0x6003C37")]
	[Address(RVA = "0x83B8C0", Offset = "0x83AAC0", VA = "0x18083B8C0")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6003C38")]
	[Address(RVA = "0x83B690", Offset = "0x83A890", VA = "0x18083B690")]
	private void OnUpdateTicketInfo(GameObject entity, int idx)
	{
	}
}
