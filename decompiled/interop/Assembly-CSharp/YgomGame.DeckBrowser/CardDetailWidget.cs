using Il2CppDummyDll;
using YgomGame.Deck;
using YgomSystem.ElementSystem;

namespace YgomGame.DeckBrowser;

[Token(Token = "0x200101F")]
public class CardDetailWidget : CardDetailView
{
	[Token(Token = "0x400ACB9")]
	[FieldOffset(Offset = "0xF0")]
	private ElementObjectManager m_EomCache;

	[Token(Token = "0x400ACBA")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_RagulationVisible;

	[Token(Token = "0x400ACBB")]
	[FieldOffset(Offset = "0xF9")]
	private bool m_IsMobile;

	[Token(Token = "0x17000F39")]
	public ElementObjectManager eom
	{
		[Token(Token = "0x600615E")]
		[Address(RVA = "0xA6FFF0", Offset = "0xA6F1F0", VA = "0x180A6FFF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000F3A")]
	public bool regulationVisible
	{
		[Token(Token = "0x600615F")]
		[Address(RVA = "0x49B790", Offset = "0x49A990", VA = "0x18049B790")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6006160")]
		[Address(RVA = "0xA700C0", Offset = "0xA6F2C0", VA = "0x180A700C0")]
		set
		{
		}
	}

	[Token(Token = "0x6006161")]
	[Address(RVA = "0xA6FB90", Offset = "0xA6ED90", VA = "0x180A6FB90")]
	public static CardDetailWidget Create(ElementObjectManager eom, bool isMobile = false)
	{
		return null;
	}

	[Token(Token = "0x6006162")]
	[Address(RVA = "0xA6FCF0", Offset = "0xA6EEF0", VA = "0x180A6FCF0")]
	public void SetCardByID(int id)
	{
	}

	[Token(Token = "0x6006163")]
	[Address(RVA = "0x4A69B0", Offset = "0x4A5BB0", VA = "0x1804A69B0")]
	public void SetPremiumID(int premiumId)
	{
	}

	[Token(Token = "0x6006164")]
	[Address(RVA = "0xA6FEB0", Offset = "0xA6F0B0", VA = "0x180A6FEB0")]
	public void SetRegulation(int reg)
	{
	}

	[Token(Token = "0x6006165")]
	[Address(RVA = "0xA70090", Offset = "0xA6F290", VA = "0x180A70090")]
	private void setNumPremiums()
	{
	}

	[Token(Token = "0x6006166")]
	[Address(RVA = "0xA6FC80", Offset = "0xA6EE80", VA = "0x180A6FC80")]
	public void SetAsRental(int rentalPoolID, bool isRental, bool dispDismantleableText = false)
	{
	}

	[Token(Token = "0x6006167")]
	[Address(RVA = "0xA6FF00", Offset = "0xA6F100", VA = "0x180A6FF00")]
	private void Start()
	{
	}

	[Token(Token = "0x6006168")]
	[Address(RVA = "0xA6FFE0", Offset = "0xA6F1E0", VA = "0x180A6FFE0")]
	public CardDetailWidget()
	{
	}
}
