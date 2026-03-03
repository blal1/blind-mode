using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Deck;
using YgomGame.TextIDs;

namespace YgomGame.Card;

[Token(Token = "0x20015E7")]
public class CardCollectionInfo
{
	[Token(Token = "0x20015E8")]
	public enum Rarity
	{
		[Token(Token = "0x400D047")]
		Normal = 1,
		[Token(Token = "0x400D048")]
		Rare,
		[Token(Token = "0x400D049")]
		SuperRare,
		[Token(Token = "0x400D04A")]
		UltraRare
	}

	[Token(Token = "0x20015E9")]
	public enum Regulation
	{
		[Token(Token = "0x400D04C")]
		Forbidden,
		[Token(Token = "0x400D04D")]
		Limited,
		[Token(Token = "0x400D04E")]
		SemiLimited,
		[Token(Token = "0x400D04F")]
		None
	}

	[Token(Token = "0x20015EA")]
	public enum Premium
	{
		[Token(Token = "0x400D051")]
		Normal = 1,
		[Token(Token = "0x400D052")]
		Premium1,
		[Token(Token = "0x400D053")]
		Premium2
	}

	[Token(Token = "0x20015EB")]
	public struct SecretPackInfo
	{
		[Token(Token = "0x400D054")]
		[FieldOffset(Offset = "0x0")]
		public string nameTextId;

		[Token(Token = "0x400D055")]
		[FieldOffset(Offset = "0x8")]
		public bool isExtend;

		[Token(Token = "0x400D056")]
		[FieldOffset(Offset = "0xC")]
		public int shopID;

		[Token(Token = "0x400D057")]
		[FieldOffset(Offset = "0x10")]
		public int freeNum;

		[Token(Token = "0x400D058")]
		[FieldOffset(Offset = "0x14")]
		public int iconType;

		[Token(Token = "0x400D059")]
		[FieldOffset(Offset = "0x18")]
		public string iconData;

		[Token(Token = "0x6008837")]
		[Address(RVA = "0xD17960", Offset = "0xD16B60", VA = "0x180D17960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}

	[Token(Token = "0x400D013")]
	public const int REGULATIONID_UNLIMITED = 8;

	[Token(Token = "0x400D014")]
	public const int REGULATIONID_UNDEFINED = -1;

	[Token(Token = "0x400D015")]
	public const int CARDINVENTORYTHRESHOLD = 3;

	[Token(Token = "0x400D016")]
	public const int MASSDISMANTLECAP = 1000;

	[Token(Token = "0x400D017")]
	[FieldOffset(Offset = "0x0")]
	private static Content m_cci;

	[Token(Token = "0x400D018")]
	public const string CLIENTWORK_PATH_CARDS_COLLECTION = "$.Cards.have";

	[Token(Token = "0x400D019")]
	private const string CLIENTWORK_PATH_CARD_RARITY = "$.Master.CardRare";

	[Token(Token = "0x400D01A")]
	private const string CLIENTWORK_PATH_CARD_CRAFT = "$.Master.CardCr";

	[Token(Token = "0x400D01B")]
	private const string CLIENTWORK_PATH_CARDS_LOCK = "$.Cards.lock";

	[Token(Token = "0x400D01C")]
	private const string CLIENTWORK_PATH_CREATECOST = "$.Craft.generate_rate_list";

	[Token(Token = "0x400D01D")]
	private const string CLIENTWORK_PATH_DISMANTLECOST = "$.Craft.exchange_rate_list";

	[Token(Token = "0x400D01E")]
	private const string CLIENTWORK_PATH_CARDS_RENTAL = "$.Master.RentalCard";

	[Token(Token = "0x400D01F")]
	private const string CLIENTWORK_PATH_CARDFILE_NOTCOLLECTLIST = "$.CardFile.NotCollectList";

	[Token(Token = "0x400D020")]
	private const string KEY_RARITY = "r";

	[Token(Token = "0x400D021")]
	private const string KEY_SUM = "tn";

	[Token(Token = "0x400D022")]
	private const string KEY_PREM0 = "n";

	[Token(Token = "0x400D023")]
	private const string KEY_PREM1 = "p1n";

	[Token(Token = "0x400D024")]
	private const string KEY_PREM2 = "p2n";

	[Token(Token = "0x400D025")]
	private const string KEY_PRIZE = "p_";

	[Token(Token = "0x400D026")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Premium> premTbl;

	[Token(Token = "0x400D027")]
	private const string CLIENTWORK_PATH_TOURNAMENT_REGULATION = "$.Master.Regulation";

	[Token(Token = "0x400D028")]
	private const string CLIENTWORK_PATH_COMMON_FORBIDDEN = "$.Master.Regulation.common.available.a0";

	[Token(Token = "0x400D029")]
	private const string CLIENTWORK_PATH_COMMON_LIMITED = "$.Master.Regulation.common.available.a1";

	[Token(Token = "0x400D02A")]
	private const string CLIENTWORK_PATH_COMMON_SEMILIMITED = "$.Master.Regulation.common.available.a2";

	[Token(Token = "0x400D02B")]
	private const string KEY_COMMON = "common";

	[Token(Token = "0x400D02C")]
	private const string KEY_AVAILABLE = "available";

	[Token(Token = "0x400D02D")]
	private const string KEY_A0 = "a0";

	[Token(Token = "0x400D02E")]
	private const string KEY_A1 = "a1";

	[Token(Token = "0x400D02F")]
	private const string KEY_A2 = "a2";

	[Token(Token = "0x400D030")]
	private const string KEY_CARDPOOL = "card_pool";

	[Token(Token = "0x400D031")]
	private const string KEY_MAIN = "main";

	[Token(Token = "0x400D032")]
	private const string KEY_EXTRA = "extra";

	[Token(Token = "0x400D033")]
	private const string KEY_REQUIRE = "require";

	[Token(Token = "0x400D034")]
	private const string KEY_R1 = "r1";

	[Token(Token = "0x400D035")]
	private const string KEY_R2 = "r2";

	[Token(Token = "0x400D036")]
	private const string KEY_R3 = "r3";

	[Token(Token = "0x400D037")]
	private const string KEY_TIMESTAMP = "st";

	[Token(Token = "0x400D038")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, object> m_cardsCollection;

	[Token(Token = "0x400D039")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<string, object> m_cardRarity;

	[Token(Token = "0x400D03A")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<string, object> m_regulation;

	[Token(Token = "0x400D03B")]
	[FieldOffset(Offset = "0x28")]
	private static List<string> m_lockcards;

	[Token(Token = "0x400D03C")]
	[FieldOffset(Offset = "0x30")]
	private static List<int> m_cardCraft;

	[Token(Token = "0x400D03D")]
	[FieldOffset(Offset = "0x38")]
	private static Dictionary<string, int> m_available;

	[Token(Token = "0x400D03E")]
	[FieldOffset(Offset = "0x40")]
	private static Dictionary<string, int> m_cardpool;

	[Token(Token = "0x400D03F")]
	[FieldOffset(Offset = "0x48")]
	private static Dictionary<string, int> m_useavailable;

	[Token(Token = "0x400D040")]
	[FieldOffset(Offset = "0x50")]
	private static Dictionary<string, int> m_rental;

	[Token(Token = "0x400D041")]
	[FieldOffset(Offset = "0x58")]
	private static bool m_isCardFileAddCardAvailabled;

	[Token(Token = "0x400D042")]
	[FieldOffset(Offset = "0x59")]
	private static bool m_isIllusionerAvailabled;

	[Token(Token = "0x400D043")]
	[FieldOffset(Offset = "0x5C")]
	private static Color m_rentalColor;

	[Token(Token = "0x400D044")]
	private const string CLIENTWORK_PATH_CRAFTPOINT = "$.Item.have.";

	[Token(Token = "0x400D045")]
	private const string CLIENTWORK_PATH_CRAFTSECRETPACK = "$.Craft.secret_pack_list";

	[Token(Token = "0x170014E7")]
	public static int REGULATIONID_STANDARD
	{
		[Token(Token = "0x60087EF")]
		[Address(RVA = "0xD07710", Offset = "0xD06910", VA = "0x180D07710")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170014E8")]
	public static int HAVE_CARD_MAX
	{
		[Token(Token = "0x60087F0")]
		[Address(RVA = "0xD076B0", Offset = "0xD068B0", VA = "0x180D076B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60087F1")]
	[Address(RVA = "0xD04480", Offset = "0xD03680", VA = "0x180D04480")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x60087F2")]
	[Address(RVA = "0xCFD920", Offset = "0xCFCB20", VA = "0x180CFD920")]
	public static void CardsCollectionNotificator(object value)
	{
	}

	[Token(Token = "0x60087F3")]
	[Address(RVA = "0xCFD440", Offset = "0xCFC640", VA = "0x180CFD440")]
	public static void CardRarityNotificator(object value)
	{
	}

	[Token(Token = "0x60087F4")]
	[Address(RVA = "0xCFD030", Offset = "0xCFC230", VA = "0x180CFD030")]
	public static void CardCraftNotificator(object value)
	{
	}

	[Token(Token = "0x60087F5")]
	[Address(RVA = "0xCFD2D0", Offset = "0xCFC4D0", VA = "0x180CFD2D0")]
	public static void CardFileNotCollectNotificator(object value)
	{
	}

	[Token(Token = "0x60087F6")]
	[Address(RVA = "0xD05990", Offset = "0xD04B90", VA = "0x180D05990")]
	public static void RegulationNotificator(object value)
	{
	}

	[Token(Token = "0x60087F7")]
	[Address(RVA = "0xD05670", Offset = "0xD04870", VA = "0x180D05670")]
	public static void LockCardsNotificator(object value)
	{
	}

	[Token(Token = "0x60087F8")]
	[Address(RVA = "0xD06900", Offset = "0xD05B00", VA = "0x180D06900")]
	public static void RentalCardNotificator(object value)
	{
	}

	[Token(Token = "0x60087F9")]
	[Address(RVA = "0xCFD770", Offset = "0xCFC970", VA = "0x180CFD770")]
	private static int CardsCollectionGetValue(int id, string val)
	{
		return default(int);
	}

	[Token(Token = "0x60087FA")]
	[Address(RVA = "0xCFD5C0", Offset = "0xCFC7C0", VA = "0x180CFD5C0")]
	private static long CardsCollectionGetValueLong(int id, string val)
	{
		return default(long);
	}

	[Token(Token = "0x60087FB")]
	[Address(RVA = "0xCFD320", Offset = "0xCFC520", VA = "0x180CFD320")]
	public static int CardRarityGetValue(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60087FC")]
	[Address(RVA = "0xD04350", Offset = "0xD03550", VA = "0x180D04350")]
	public static int GetSumOfCardInCollection(int id)
	{
		return default(int);
	}

	[Token(Token = "0x60087FD")]
	[Address(RVA = "0xD00180", Offset = "0xCFF380", VA = "0x180D00180")]
	public static List<int> GetCardsInCollection(bool noDupes)
	{
		return null;
	}

	[Token(Token = "0x60087FE")]
	[Address(RVA = "0xD02740", Offset = "0xD01940", VA = "0x180D02740")]
	public static List<CardBaseData> GetPremiumCardsInCollection(bool nonPrizeOnly = false)
	{
		return null;
	}

	[Token(Token = "0x60087FF")]
	[Address(RVA = "0xD02630", Offset = "0xD01830", VA = "0x180D02630")]
	public static int GetPremiumCardTotal(int id, Premium prem, bool nonPrizeOnly = false)
	{
		return default(int);
	}

	[Token(Token = "0x6008800")]
	[Address(RVA = "0xD02500", Offset = "0xD01700", VA = "0x180D02500")]
	public static (Premium, bool) GetOwnedHighPremium(int cardID, Premium maxPremium, int numCardInDeckNormal, int numCardInDeckPremium1, int numCardInDeckPremium2)
	{
		return default((Premium, bool));
	}

	[Token(Token = "0x6008801")]
	[Address(RVA = "0xCFFA00", Offset = "0xCFEC00", VA = "0x180CFFA00")]
	public static int GetCardLimitByID(int id, int regulation)
	{
		return default(int);
	}

	[Token(Token = "0x6008802")]
	[Address(RVA = "0xCFFA60", Offset = "0xCFEC60", VA = "0x180CFFA60")]
	public static int GetCardRarityID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6008803")]
	[Address(RVA = "0xCFFC70", Offset = "0xCFEE70", VA = "0x180CFFC70")]
	public static Rarity GetCardRarity(int id)
	{
		return default(Rarity);
	}

	[Token(Token = "0x6008804")]
	[Address(RVA = "0xCFFAE0", Offset = "0xCFECE0", VA = "0x180CFFAE0")]
	public static string GetCardRarityText(int rarityId)
	{
		return null;
	}

	[Token(Token = "0x6008805")]
	[Address(RVA = "0xCFFBC0", Offset = "0xCFEDC0", VA = "0x180CFFBC0")]
	public static string GetCardRarityText(Rarity rarity)
	{
		return null;
	}

	[Token(Token = "0x6008806")]
	[Address(RVA = "0xCFFAB0", Offset = "0xCFECB0", VA = "0x180CFFAB0")]
	public static IDS_CARD GetCardRarityTextId(Rarity rarity)
	{
		return default(IDS_CARD);
	}

	[Token(Token = "0x6008807")]
	[Address(RVA = "0xCFFEA0", Offset = "0xCFF0A0", VA = "0x180CFFEA0")]
	public static string GetCardStyleText(int styleId)
	{
		return null;
	}

	[Token(Token = "0x6008808")]
	[Address(RVA = "0xCFFE00", Offset = "0xCFF000", VA = "0x180CFFE00")]
	public static string GetCardStyleText(Premium style)
	{
		return null;
	}

	[Token(Token = "0x6008809")]
	[Address(RVA = "0xCFFDD0", Offset = "0xCFEFD0", VA = "0x180CFFDD0")]
	public static IDS_CARD GetCardStyleTextId(Premium style)
	{
		return default(IDS_CARD);
	}

	[Token(Token = "0x600880A")]
	[Address(RVA = "0xD00420", Offset = "0xCFF620", VA = "0x180D00420")]
	public static int GetCraftPoints(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600880B")]
	[Address(RVA = "0xCFF890", Offset = "0xCFEA90", VA = "0x180CFF890")]
	public static int GetCardCreateCost(Premium prem, Rarity rarity)
	{
		return default(int);
	}

	[Token(Token = "0x600880C")]
	[Address(RVA = "0xCFF940", Offset = "0xCFEB40", VA = "0x180CFF940")]
	public static int GetCardDismantleCost(Premium prem, Rarity rarity)
	{
		return default(int);
	}

	[Token(Token = "0x600880D")]
	[Address(RVA = "0xD05210", Offset = "0xD04410", VA = "0x180D05210")]
	public static bool IsCreatable(CardBaseData data, int num = 1)
	{
		return default(bool);
	}

	[Token(Token = "0x600880E")]
	[Address(RVA = "0xD05450", Offset = "0xD04650", VA = "0x180D05450")]
	public static bool IsDismantleable(CardBaseData data, int num = 1)
	{
		return default(bool);
	}

	[Token(Token = "0x600880F")]
	[Address(RVA = "0xD05610", Offset = "0xD04810", VA = "0x180D05610")]
	public static bool IsOverCraftPoint()
	{
		return default(bool);
	}

	[Token(Token = "0x6008810")]
	[Address(RVA = "0xCFEE70", Offset = "0xCFE070", VA = "0x180CFEE70")]
	public static List<CardBaseData> GetAllPremiumCards(bool fullStyle)
	{
		return null;
	}

	[Token(Token = "0x6008811")]
	[Address(RVA = "0xCFEBB0", Offset = "0xCFDDB0", VA = "0x180CFEBB0")]
	public static List<CardBaseData> GetAllCards()
	{
		return null;
	}

	[Token(Token = "0x6008812")]
	[Address(RVA = "0xD035D0", Offset = "0xD027D0", VA = "0x180D035D0")]
	public static Regulation GetRegulationStatus(int cardID, int regulationID)
	{
		return default(Regulation);
	}

	[Token(Token = "0x6008813")]
	[Address(RVA = "0xD03320", Offset = "0xD02520", VA = "0x180D03320")]
	public static string GetRegulationName(int regId)
	{
		return null;
	}

	[Token(Token = "0x6008814")]
	[Address(RVA = "0xD043B0", Offset = "0xD035B0", VA = "0x180D043B0")]
	private static bool GetTextGroup(string fullTextId, out string groupId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008815")]
	[Address(RVA = "0xD042F0", Offset = "0xD034F0", VA = "0x180D042F0")]
	public static Dictionary<string, object> GetRules()
	{
		return null;
	}

	[Token(Token = "0x6008816")]
	[Address(RVA = "0xD040E0", Offset = "0xD032E0", VA = "0x180D040E0")]
	public static List<int> GetRuleIds()
	{
		return null;
	}

	[Token(Token = "0x6008817")]
	[Address(RVA = "0xD00EC0", Offset = "0xD000C0", VA = "0x180D00EC0")]
	public static int GetLatestRagulationID(int regulationID)
	{
		return default(int);
	}

	[Token(Token = "0x6008818")]
	[Address(RVA = "0xD00FC0", Offset = "0xD001C0", VA = "0x180D00FC0")]
	public static List<int> GetLimitedCardMrks(int regulationID, Regulation limit)
	{
		return null;
	}

	[Token(Token = "0x6008819")]
	[Address(RVA = "0xCFFF70", Offset = "0xCFF170", VA = "0x180CFFF70")]
	public static int GetCardTimeObtained(int cardID)
	{
		return default(int);
	}

	[Token(Token = "0x600881A")]
	[Address(RVA = "0xD05150", Offset = "0xD04350", VA = "0x180D05150")]
	public static bool IsCraftableCard(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600881B")]
	[Address(RVA = "0xD05520", Offset = "0xD04720", VA = "0x180D05520")]
	public static bool IsLockCard(int cardID, int premID)
	{
		return default(bool);
	}

	[Token(Token = "0x600881C")]
	[Address(RVA = "0xD04D90", Offset = "0xD03F90", VA = "0x180D04D90")]
	public static bool IsCardInCardFile(int cardID, int premID, int num)
	{
		return default(bool);
	}

	[Token(Token = "0x600881D")]
	[Address(RVA = "0xD07770", Offset = "0xD06970", VA = "0x180D07770")]
	public static bool isCardInCardFile(Dictionary<string, object> formatedCards)
	{
		return default(bool);
	}

	[Token(Token = "0x600881E")]
	[Address(RVA = "0xD046A0", Offset = "0xD038A0", VA = "0x180D046A0")]
	public static bool IsAllCardFileNotCollect()
	{
		return default(bool);
	}

	[Token(Token = "0x600881F")]
	[Address(RVA = "0xD04850", Offset = "0xD03A50", VA = "0x180D04850")]
	public static bool IsCardFileNotCollect(string itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6008820")]
	[Address(RVA = "0xCFEA60", Offset = "0xCFDC60", VA = "0x180CFEA60")]
	public static Dictionary<string, object> FormatForMultiDismantle(int cardID, int n_num, int p1_num, int p2_num)
	{
		return null;
	}

	[Token(Token = "0x6008821")]
	[Address(RVA = "0xCFDFE0", Offset = "0xCFD1E0", VA = "0x180CFDFE0")]
	public static Dictionary<string, object> DismantleSingleCard(int cardID, int n_num, int p1_num, int p2_num)
	{
		return null;
	}

	[Token(Token = "0x6008822")]
	[Address(RVA = "0xCFCDF0", Offset = "0xCFBFF0", VA = "0x180CFCDF0")]
	public static Dictionary<CardBaseData, int> CardBaseDataListToCardBaseDataNumPairs(List<CardBaseData> cards)
	{
		return null;
	}

	[Token(Token = "0x6008823")]
	[Address(RVA = "0xCFDB30", Offset = "0xCFCD30", VA = "0x180CFDB30")]
	public static Dictionary<string, object> DismantleMultiCards(List<CardBaseData> cards)
	{
		return null;
	}

	[Token(Token = "0x6008824")]
	[Address(RVA = "0xCFE0E0", Offset = "0xCFD2E0", VA = "0x180CFE0E0")]
	public static Dictionary<string, object> FormatForMassDismantle(Dictionary<int, CraftCompensation> compDic)
	{
		return null;
	}

	[Token(Token = "0x6008825")]
	[Address(RVA = "0xCFE640", Offset = "0xCFD840", VA = "0x180CFE640")]
	public static Dictionary<string, object> FormatForMultiCreate(int cardID, int n_num, int p1_num, int p2_num)
	{
		return null;
	}

	[Token(Token = "0x6008826")]
	[Address(RVA = "0xCFE7C0", Offset = "0xCFD9C0", VA = "0x180CFE7C0")]
	public static Dictionary<string, object> FormatForMultiCreate(Dictionary<int, int> lackCards)
	{
		return null;
	}

	[Token(Token = "0x6008827")]
	[Address(RVA = "0xCFDA60", Offset = "0xCFCC60", VA = "0x180CFDA60")]
	public static Dictionary<string, object> CreateSingleCard(int cardID, Premium prem)
	{
		return null;
	}

	[Token(Token = "0x6008828")]
	[Address(RVA = "0xD03020", Offset = "0xD02220", VA = "0x180D03020")]
	public static int GetRedundantCards(int cardID, Premium prem, Dictionary<int, CraftCompensation> compDic)
	{
		return default(int);
	}

	[Token(Token = "0x6008829")]
	[Address(RVA = "0xCFF420", Offset = "0xCFE620", VA = "0x180CFF420")]
	public static Dictionary<KeyValuePair<Rarity, Premium>, int> GetAllRedundantCards()
	{
		return null;
	}

	[Token(Token = "0x600882A")]
	[Address(RVA = "0xD009B0", Offset = "0xCFFBB0", VA = "0x180D009B0")]
	public static Dictionary<Rarity, int> GetEarnedPoints()
	{
		return null;
	}

	[Token(Token = "0x600882B")]
	[Address(RVA = "0xD004A0", Offset = "0xCFF6A0", VA = "0x180D004A0")]
	public static Dictionary<Rarity, int> GetEarnedPoints(List<CardBaseData> cards)
	{
		return null;
	}

	[Token(Token = "0x600882C")]
	[Address(RVA = "0xD01780", Offset = "0xD00980", VA = "0x180D01780")]
	public static Dictionary<Rarity, int> GetNeedPoints(List<CardBaseData> cards)
	{
		return null;
	}

	[Token(Token = "0x600882D")]
	[Address(RVA = "0xD02BC0", Offset = "0xD01DC0", VA = "0x180D02BC0")]
	public static Dictionary<KeyValuePair<Rarity, Premium>, int> GetRarityNumPairs(List<CardBaseData> cards)
	{
		return null;
	}

	[Token(Token = "0x600882E")]
	[Address(RVA = "0xD01C90", Offset = "0xD00E90", VA = "0x180D01C90")]
	public static List<SecretPackInfo> GetOpenedSecretPackInfo()
	{
		return null;
	}

	[Token(Token = "0x600882F")]
	[Address(RVA = "0xD020C0", Offset = "0xD012C0", VA = "0x180D020C0")]
	public static Dictionary<int, SecretPackInfo> GetOpenedSecretPacks()
	{
		return null;
	}

	[Token(Token = "0x6008830")]
	[Address(RVA = "0xD054D0", Offset = "0xD046D0", VA = "0x180D054D0")]
	public static bool IsIllusionerAvailabled()
	{
		return default(bool);
	}

	[Token(Token = "0x6008831")]
	[Address(RVA = "0xD03990", Offset = "0xD02B90", VA = "0x180D03990")]
	public static List<int> GetRentalCardIDs(int rentalID)
	{
		return null;
	}

	[Token(Token = "0x6008832")]
	[Address(RVA = "0xD03E20", Offset = "0xD03020", VA = "0x180D03E20")]
	public static int GetRentalCardTotal(int rentalID)
	{
		return default(int);
	}

	[Token(Token = "0x6008833")]
	[Address(RVA = "0xD03CB0", Offset = "0xD02EB0", VA = "0x180D03CB0")]
	public static int GetRentalCardNum(int rentalID, int cardID)
	{
		return default(int);
	}

	[Token(Token = "0x6008834")]
	[Address(RVA = "0xD04080", Offset = "0xD03280", VA = "0x180D04080")]
	public static Color GetRentalColor()
	{
		return default(Color);
	}

	[Token(Token = "0x6008835")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardCollectionInfo()
	{
	}
}
