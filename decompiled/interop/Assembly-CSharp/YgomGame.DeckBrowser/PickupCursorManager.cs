using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x2001032")]
public class PickupCursorManager
{
	[Token(Token = "0x400AD59")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, PickupCursorWidget> dictSelectedCursor;

	[Token(Token = "0x400AD5A")]
	[FieldOffset(Offset = "0x18")]
	private readonly string k_ELabelPickupCard0;

	[Token(Token = "0x400AD5B")]
	[FieldOffset(Offset = "0x20")]
	private readonly string k_ELabelPickupCard1;

	[Token(Token = "0x400AD5C")]
	[FieldOffset(Offset = "0x28")]
	private readonly string k_ELabelPickupCard2;

	[Token(Token = "0x400AD5D")]
	private const int numPickups = 3;

	[Token(Token = "0x400AD5E")]
	[FieldOffset(Offset = "0x30")]
	private int[] m_PickCardIds;

	[Token(Token = "0x400AD5F")]
	[FieldOffset(Offset = "0x38")]
	private int[] m_PickPremiumIds;

	[Token(Token = "0x400AD60")]
	[FieldOffset(Offset = "0x40")]
	private int[] m_DeckCardIdx;

	[Token(Token = "0x400AD61")]
	[FieldOffset(Offset = "0x48")]
	private bool[] m_InitFlag;

	[Token(Token = "0x400AD62")]
	[FieldOffset(Offset = "0x50")]
	private int m_SelectedPickIdx;

	[Token(Token = "0x400AD63")]
	[FieldOffset(Offset = "0x54")]
	private bool isIni;

	[Token(Token = "0x400AD64")]
	[FieldOffset(Offset = "0x58")]
	private List<ElementObjectManager> m_PickupCardEoms;

	[Token(Token = "0x400AD65")]
	[FieldOffset(Offset = "0x60")]
	private List<DeckCardWidget> m_PickupCards;

	[Token(Token = "0x17000F59")]
	public int[] pickupCardIds
	{
		[Token(Token = "0x6006228")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F5A")]
	public int[] premiumIds
	{
		[Token(Token = "0x6006229")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F5B")]
	public int[] deckCardIdx
	{
		[Token(Token = "0x600622A")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F5C")]
	private int selectedPickId
	{
		[Token(Token = "0x600622B")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600622C")]
		[Address(RVA = "0xA94590", Offset = "0xA93790", VA = "0x180A94590")]
		set
		{
		}
	}

	[Token(Token = "0x17000F5D")]
	public bool isMobile
	{
		[Token(Token = "0x600622E")]
		[Address(RVA = "0xA95A80", Offset = "0xA94C80", VA = "0x180A95A80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600622D")]
	[Address(RVA = "0xA94590", Offset = "0xA93790", VA = "0x180A94590")]
	private void ChangeSelectedId(int id)
	{
	}

	[Token(Token = "0x600622F")]
	[Address(RVA = "0xA95630", Offset = "0xA94830", VA = "0x180A95630")]
	public PickupCursorManager(ElementObjectManager eom, int[] mrks, int[] premiums, int protectorId)
	{
	}

	[Token(Token = "0x6006230")]
	[Address(RVA = "0xA947A0", Offset = "0xA939A0", VA = "0x180A947A0")]
	private void InitializePickups(int[] mrks, int[] premiums, int protectorId)
	{
	}

	[Token(Token = "0x6006231")]
	[Address(RVA = "0xA951B0", Offset = "0xA943B0", VA = "0x180A951B0")]
	public void SetPickup(PickupCursorWidget pickupCursor, int mrk, int premiumId, int deckIdx)
	{
	}

	[Token(Token = "0x6006232")]
	[Address(RVA = "0xA94F40", Offset = "0xA94140", VA = "0x180A94F40")]
	private void RemovePickup(int pickupId)
	{
	}

	[Token(Token = "0x6006233")]
	[Address(RVA = "0xA95560", Offset = "0xA94760", VA = "0x180A95560")]
	public void UpdateCursor(PickupCursorWidget pickupCursor, int mrk, int premiumId, int pickupId = 0, int deckIdx = -1, bool notRemove = false)
	{
	}

	[Token(Token = "0x6006234")]
	[Address(RVA = "0xA946C0", Offset = "0xA938C0", VA = "0x180A946C0")]
	public int CheckPickup(int mrk, int premiumId, int deckIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6006235")]
	[Address(RVA = "0xA94670", Offset = "0xA93870", VA = "0x180A94670")]
	public int CheckPickupByDeckIdx(int deckIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6006236")]
	[Address(RVA = "0xA94B20", Offset = "0xA93D20", VA = "0x180A94B20")]
	internal void PickupCardsCallBacks(DeckBrowserViewController deckBrowser)
	{
	}
}
