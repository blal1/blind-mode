using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Token(Token = "0x20014A9")]
public class ResourceBindingPathSetting : ScriptableObject
{
	[Serializable]
	[Token(Token = "0x20014AA")]
	public class ItemPathData
	{
		[Token(Token = "0x400C765")]
		[FieldOffset(Offset = "0x10")]
		public bool divideResourceType;

		[Token(Token = "0x400C766")]
		[FieldOffset(Offset = "0x18")]
		public string SD;

		[Token(Token = "0x400C767")]
		[FieldOffset(Offset = "0x20")]
		public string SD_L;

		[Token(Token = "0x400C768")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[EnabledIf("divideResourceType", true)]
		public string HighEndHD;

		[Token(Token = "0x400C769")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[EnabledIf("divideResourceType", true)]
		public string HighEndHD_L;

		[Token(Token = "0x600802E")]
		[Address(RVA = "0xC762C0", Offset = "0xC754C0", VA = "0x180C762C0")]
		public string GetPath(bool isLarge)
		{
			return null;
		}

		[Token(Token = "0x600802F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ItemPathData()
		{
		}
	}

	[Token(Token = "0x20014AB")]
	public class EnabledIfAttribute : PropertyAttribute
	{
		[Token(Token = "0x400C76A")]
		[FieldOffset(Offset = "0x18")]
		public string switcherFieldName;

		[Token(Token = "0x400C76B")]
		[FieldOffset(Offset = "0x20")]
		public bool enable;

		[Token(Token = "0x6008030")]
		[Address(RVA = "0xC75090", Offset = "0xC74290", VA = "0x180C75090")]
		public EnabledIfAttribute(string switcherFieldName, bool enable)
		{
		}
	}

	[Token(Token = "0x400C748")]
	internal const string k_SettingPath = "Definition/UISystem/ResourceBindingPathSetting";

	[Token(Token = "0x400C749")]
	internal const string k_RarityIcon_RaritySpriteContainerPath = "Images/Card/RaritySpriteContainer";

	[Token(Token = "0x400C74A")]
	internal const string k_CraftIcon_CP0Path = "Images/Menu/GUI_alpha_Icon_CP0";

	[Token(Token = "0x400C74B")]
	internal const string k_CraftIcon_CP1Path = "Images/Menu/GUI_alpha_Icon_CP1";

	[Token(Token = "0x400C74C")]
	internal const string k_CraftIcon_CP2Path = "Images/Menu/GUI_alpha_Icon_CP2";

	[Token(Token = "0x400C74D")]
	internal const string k_CraftIcon_CP3Path = "Images/Menu/GUI_alpha_Icon_CP3";

	[Token(Token = "0x400C74E")]
	internal const string k_RegulationSpriteContainerPath = "Images/Card/RegulationSpriteContainer";

	[Token(Token = "0x400C74F")]
	internal const string k_Shop_CardThumbSettingPath = "Definition/Shop/CardThumbSettings";

	[Token(Token = "0x400C750")]
	internal const string k_Shop_HighlightThumbImagePath = "Images/Shop/HighlightThumbs/<_CARD_ILLUST_>/{0}";

	[Token(Token = "0x400C751")]
	internal const string k_Shop_HighlightThumbPrefPath = "Prefabs/Shop/HighlightThumbs/{0}";

	[Token(Token = "0x400C752")]
	internal const string k_OutGameBG_FrontBGPath = "WallPaper/WallPaper{0:D4}/<_CARD_ILLUST_>/Front{0:D4}";

	[Token(Token = "0x400C753")]
	internal const string k_OutGameBG_BackBGPath = "Prefabs/OutGameBg/Back/Back{0:D4}";

	[Token(Token = "0x400C754")]
	internal const string k_OutGameBG_DuelMenuDefaultPath = "WallPaper/WallPaper0001/<_CARD_ILLUST_>/WallPaper0001_1";

	[Token(Token = "0x400C755")]
	internal const string k_CardPack_PackTicketPath = "Images/PackTicket/<_RESOURCE_TYPE_>/PackTicket";

	[Token(Token = "0x400C756")]
	internal const string k_CardPack_PackTexPath = "Images/CardPack/<_RESOURCE_TYPE_>/<_CARD_ILLUST_>/{0}";

	[Token(Token = "0x400C757")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ConsumeItemBinder.ConsumeItemPathData m_ConsumeItemPathData;

	[Token(Token = "0x400C758")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private DeckResourceBinder.DeckPathData m_DeckPathData;

	[Token(Token = "0x400C759")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ReplayLimitBinder.ReplayPathData m_ReplayPathData;

	[Token(Token = "0x400C75A")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private BookmarkLimitBinder.BookmarkPathData m_BookmarkPathData;

	[Token(Token = "0x400C75B")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private PlayerIconResourceBinder.PlayerIconPathData m_PlayerIconPathData;

	[Token(Token = "0x400C75C")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private FieldResourceBinder.FieldPathData m_FieldPathData;

	[Token(Token = "0x400C75D")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private EventLogoResourceBinder.EventLogoPathData m_EventLogoPathData;

	[Token(Token = "0x400C75E")]
	[FieldOffset(Offset = "0x50")]
	[SerializeField]
	private RegulationLogoResourceBinder.RegulationLogoPathData m_RegulationLogoPathData;

	[Token(Token = "0x400C75F")]
	[FieldOffset(Offset = "0x58")]
	[SerializeField]
	private AvatarResourceBinder.AvatarResourcePathData m_AvatarResourcePathData;

	[Token(Token = "0x400C760")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private WallPaperResourceBinder.WallPaperResourcePathData m_WallPaperResourcePathData;

	[Token(Token = "0x400C761")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private ProfileResourceBinder.ProfileResource m_ProfileResource;

	[Token(Token = "0x400C762")]
	[FieldOffset(Offset = "0x70")]
	[SerializeField]
	private CardFileBinder.CardFilePathData m_CardFilePathData;

	[Token(Token = "0x400C763")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private CoinBinder.CoinPathData m_CoinPathData;

	[Token(Token = "0x400C764")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private SoloResourceBinder.SoloPathData m_SoloPathData;

	[Token(Token = "0x1700139E")]
	public ConsumeItemBinder.ConsumeItemPathData consumeItemPathData
	{
		[Token(Token = "0x600801F")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700139F")]
	public DeckResourceBinder.DeckPathData deckPathData
	{
		[Token(Token = "0x6008020")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A0")]
	public ReplayLimitBinder.ReplayPathData replayPathData
	{
		[Token(Token = "0x6008021")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A1")]
	public BookmarkLimitBinder.BookmarkPathData bookmarkPathData
	{
		[Token(Token = "0x6008022")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A2")]
	public PlayerIconResourceBinder.PlayerIconPathData playerIconPathData
	{
		[Token(Token = "0x6008023")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A3")]
	public FieldResourceBinder.FieldPathData fieldPathData
	{
		[Token(Token = "0x6008024")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A4")]
	public EventLogoResourceBinder.EventLogoPathData eventLogoPathData
	{
		[Token(Token = "0x6008025")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A5")]
	public RegulationLogoResourceBinder.RegulationLogoPathData regulationLogoPathData
	{
		[Token(Token = "0x6008026")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A6")]
	public AvatarResourceBinder.AvatarResourcePathData avatarResourcePathData
	{
		[Token(Token = "0x6008027")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A7")]
	public WallPaperResourceBinder.WallPaperResourcePathData wallPaperResourcePathData
	{
		[Token(Token = "0x6008028")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A8")]
	public ProfileResourceBinder.ProfileResource profileResourcePathData
	{
		[Token(Token = "0x6008029")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013A9")]
	public CardFileBinder.CardFilePathData cardFilePathData
	{
		[Token(Token = "0x600802A")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AA")]
	public CoinBinder.CoinPathData coinPathData
	{
		[Token(Token = "0x600802B")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170013AB")]
	public SoloResourceBinder.SoloPathData soloPathData
	{
		[Token(Token = "0x600802C")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600802D")]
	[Address(RVA = "0xC7CE70", Offset = "0xC7C070", VA = "0x180C7CE70")]
	public ResourceBindingPathSetting()
	{
	}
}
