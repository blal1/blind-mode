using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Deck;

[Token(Token = "0x20010AF")]
public class DeckInfo
{
	[Token(Token = "0x20010B0")]
	public enum DeckType
	{
		[Token(Token = "0x400B185")]
		M,
		[Token(Token = "0x400B186")]
		E,
		[Token(Token = "0x400B187")]
		S,
		[Token(Token = "0x400B188")]
		T
	}

	[Token(Token = "0x20010B1")]
	public abstract class BaseDeckInfo
	{
		[Token(Token = "0x400B189")]
		protected const string KEY_M = "m";

		[Token(Token = "0x400B18A")]
		protected const string KEY_E = "e";

		[Token(Token = "0x400B18B")]
		protected const string KEY_S = "s";

		[Token(Token = "0x400B18C")]
		protected const string KEY_T = "t";

		[Token(Token = "0x400B18D")]
		protected const string KEY_IDS = "ids";

		[Token(Token = "0x400B18E")]
		protected const string KEY_R = "r";

		[Token(Token = "0x400B18F")]
		protected const string KEY_DECKID = "deck_id";

		[Token(Token = "0x400B190")]
		protected const string KEY_NAME = "name";

		[Token(Token = "0x400B191")]
		protected const string KEY_ACCESSORY = "accessory";

		[Token(Token = "0x400B192")]
		protected const string KEY_PICKCARDS = "pick_cards";

		[Token(Token = "0x400B193")]
		protected const string KEY_EDITTIME = "et";

		[Token(Token = "0x400B194")]
		protected const string KEY_CREATETIME = "ct";

		[Token(Token = "0x400B195")]
		protected const string KEY_REG = "regulation_id";

		[Token(Token = "0x400B196")]
		protected const string KEY_NAME_REG_ID = "name_reg_id";

		[Token(Token = "0x400B197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		protected string deckPath;

		[Token(Token = "0x400B198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		protected string listPath;

		[Token(Token = "0x60067DB")]
		[Address(RVA = "0xAD6630", Offset = "0xAD5830", VA = "0x180AD6630")]
		protected string GetStrDeckType(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067DC")]
		[Address(RVA = "0xAD4F70", Offset = "0xAD4170", VA = "0x180AD4F70", Slot = "4")]
		public virtual Dictionary<int, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x60067DD")]
		[Address(RVA = "0xAD56B0", Offset = "0xAD48B0", VA = "0x180AD56B0", Slot = "5")]
		public virtual string GetDeckNameByID(int id)
		{
			return null;
		}

		[Token(Token = "0x60067DE")]
		[Address(RVA = "0xAD52B0", Offset = "0xAD44B0", VA = "0x180AD52B0", Slot = "6")]
		public virtual List<int> GetDeckListByID(int id, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067DF")]
		[Address(RVA = "0xAD4760", Offset = "0xAD3960", VA = "0x180AD4760", Slot = "7")]
		public virtual List<int> GetCardPremiumByID(int id, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067E0")]
		[Address(RVA = "0xAD4C10", Offset = "0xAD3E10", VA = "0x180AD4C10", Slot = "8")]
		public virtual Dictionary<string, object> GetDeckDictByID(int deckID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067E1")]
		[Address(RVA = "0xAD4CD0", Offset = "0xAD3ED0", VA = "0x180AD4CD0", Slot = "9")]
		public virtual Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067E2")]
		[Address(RVA = "0xAD4550", Offset = "0xAD3750", VA = "0x180AD4550", Slot = "10")]
		public virtual List<CardBaseData> GetCardBaseListByID(int id, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067E3")]
		[Address(RVA = "0xAD44A0", Offset = "0xAD36A0", VA = "0x180AD44A0", Slot = "11")]
		public virtual Dictionary<string, object> GetAccessory(int id)
		{
			return null;
		}

		[Token(Token = "0x60067E4")]
		[Address(RVA = "0xAD5A50", Offset = "0xAD4C50", VA = "0x180AD5A50", Slot = "12")]
		public virtual int[] GetPickUpCardIDs(int id)
		{
			return null;
		}

		[Token(Token = "0x60067E5")]
		[Address(RVA = "0xAD60A0", Offset = "0xAD52A0", VA = "0x180AD60A0", Slot = "13")]
		public virtual int[] GetPickUpCardPremiums(int id)
		{
			return null;
		}

		[Token(Token = "0x60067E6")]
		[Address(RVA = "0xAD5820", Offset = "0xAD4A20", VA = "0x180AD5820", Slot = "14")]
		public virtual Dictionary<string, object> GetPickUpCardIDs2(int id)
		{
			return null;
		}

		[Token(Token = "0x60067E7")]
		[Address(RVA = "0xAD5E70", Offset = "0xAD5070", VA = "0x180AD5E70", Slot = "15")]
		public virtual Dictionary<string, object> GetPickUpCardPremiums2(int id)
		{
			return null;
		}

		[Token(Token = "0x60067E8")]
		[Address(RVA = "0xAD6500", Offset = "0xAD5700", VA = "0x180AD6500", Slot = "16")]
		public virtual Dictionary<string, object> GetPickUps(int id)
		{
			return null;
		}

		[Token(Token = "0x60067E9")]
		[Address(RVA = "0xAD5770", Offset = "0xAD4970", VA = "0x180AD5770", Slot = "17")]
		public virtual long GetEditTime(int id)
		{
			return default(long);
		}

		[Token(Token = "0x60067EA")]
		[Address(RVA = "0xAD4B60", Offset = "0xAD3D60", VA = "0x180AD4B60", Slot = "18")]
		public virtual long GetDeckCreateTime(int id)
		{
			return default(long);
		}

		[Token(Token = "0x60067EB")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		protected BaseDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010B2")]
	public class MyDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x60067EC")]
		[Address(RVA = "0xAEB2C0", Offset = "0xAEA4C0", VA = "0x180AEB2C0")]
		public MyDeckInfo()
		{
		}

		[Token(Token = "0x60067ED")]
		[Address(RVA = "0xAEB210", Offset = "0xAEA410", VA = "0x180AEB210")]
		public int GetDeckRegByID(int id)
		{
			return default(int);
		}
	}

	[Token(Token = "0x20010B3")]
	public class ExhibitionDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x60067EE")]
		[Address(RVA = "0xAEA6C0", Offset = "0xAE98C0", VA = "0x180AEA6C0")]
		public ExhibitionDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010B4")]
	public class DuelistCupDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x60067EF")]
		[Address(RVA = "0xAEA640", Offset = "0xAE9840", VA = "0x180AEA640")]
		public DuelistCupDeckInfo()
		{
		}

		[Token(Token = "0x60067F0")]
		[Address(RVA = "0xAEA5D0", Offset = "0xAE97D0", VA = "0x180AEA5D0")]
		public void SetQualifierCupPath()
		{
		}

		[Token(Token = "0x60067F1")]
		[Address(RVA = "0xAE9E90", Offset = "0xAE9090", VA = "0x180AE9E90")]
		public new Dictionary<int, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x60067F2")]
		[Address(RVA = "0xAEA240", Offset = "0xAE9440", VA = "0x180AEA240")]
		public string GetDeckName()
		{
			return null;
		}

		[Token(Token = "0x60067F3")]
		[Address(RVA = "0xAE9E00", Offset = "0xAE9000", VA = "0x180AE9E00", Slot = "19")]
		public virtual Dictionary<string, object> GetDeckDict(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067F4")]
		[Address(RVA = "0xAE9FD0", Offset = "0xAE91D0", VA = "0x180AE9FD0")]
		public List<int> GetDeckListByID(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067F5")]
		[Address(RVA = "0xAE9B30", Offset = "0xAE8D30", VA = "0x180AE9B30")]
		public List<int> GetCardPremiumByID(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067F6")]
		[Address(RVA = "0xAE9940", Offset = "0xAE8B40", VA = "0x180AE9940")]
		public List<CardBaseData> GetCardBaseListByID(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x60067F7")]
		[Address(RVA = "0xAE98D0", Offset = "0xAE8AD0", VA = "0x180AE98D0")]
		public Dictionary<string, object> GetAccessory()
		{
			return null;
		}

		[Token(Token = "0x60067F8")]
		[Address(RVA = "0xAE9DA0", Offset = "0xAE8FA0", VA = "0x180AE9DA0", Slot = "20")]
		public virtual int GetDeckBoxID()
		{
			return default(int);
		}

		[Token(Token = "0x60067F9")]
		[Address(RVA = "0xAEA2C0", Offset = "0xAE94C0", VA = "0x180AEA2C0")]
		public Dictionary<string, object> GetPickUpCardIDs()
		{
			return null;
		}

		[Token(Token = "0x60067FA")]
		[Address(RVA = "0xAEA330", Offset = "0xAE9530", VA = "0x180AEA330")]
		public Dictionary<string, object> GetPickUpCardPremiums()
		{
			return null;
		}

		[Token(Token = "0x60067FB")]
		[Address(RVA = "0xAEA3A0", Offset = "0xAE95A0", VA = "0x180AEA3A0")]
		public Dictionary<string, object> GetPickUps()
		{
			return null;
		}

		[Token(Token = "0x60067FC")]
		[Address(RVA = "0xAEA560", Offset = "0xAE9760", VA = "0x180AEA560")]
		public int GetStage()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20010B5")]
	public class WCSDeckInfo : DuelistCupDeckInfo
	{
		[Token(Token = "0x60067FD")]
		[Address(RVA = "0xAF0910", Offset = "0xAEFB10", VA = "0x180AF0910")]
		public WCSDeckInfo()
		{
		}

		[Token(Token = "0x60067FE")]
		[Address(RVA = "0xAF07D0", Offset = "0xAEF9D0", VA = "0x180AF07D0")]
		public new Dictionary<int, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x60067FF")]
		[Address(RVA = "0xAF0770", Offset = "0xAEF970", VA = "0x180AF0770", Slot = "20")]
		public override int GetDeckBoxID()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20010B6")]
	public class WCSFinalDeckInfo : WCSDeckInfo
	{
		[Token(Token = "0x6006800")]
		[Address(RVA = "0xAF17D0", Offset = "0xAF09D0", VA = "0x180AF17D0")]
		public WCSFinalDeckInfo()
		{
		}

		[Token(Token = "0x6006801")]
		[Address(RVA = "0xAF1290", Offset = "0xAF0490", VA = "0x180AF1290")]
		public new Dictionary<int, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x6006802")]
		[Address(RVA = "0xAF1060", Offset = "0xAF0260", VA = "0x180AF1060")]
		public Dictionary<string, object> GetDeckDict(DeckType type, int index, int slot)
		{
			return null;
		}

		[Token(Token = "0x6006803")]
		[Address(RVA = "0xAF09F0", Offset = "0xAEFBF0", VA = "0x180AF09F0")]
		public List<CardBaseData> GetCardBaseListByID(int index, int slot, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006804")]
		[Address(RVA = "0xAF1370", Offset = "0xAF0570", VA = "0x180AF1370")]
		public List<int> GetDeckListByID(int index, int slot, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006805")]
		[Address(RVA = "0xAF0C00", Offset = "0xAEFE00", VA = "0x180AF0C00")]
		public List<int> GetCardPremiumByID(int index, int slot, DeckType type)
		{
			return null;
		}
	}

	[Token(Token = "0x20010B7")]
	public class RankEventDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006806")]
		[Address(RVA = "0xAEB340", Offset = "0xAEA540", VA = "0x180AEB340")]
		public RankEventDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010B8")]
	public class DuelTrialDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006807")]
		[Address(RVA = "0xAE8D80", Offset = "0xAE7F80", VA = "0x180AE8D80")]
		public DuelTrialDeckInfo()
		{
		}

		[Token(Token = "0x6006808")]
		[Address(RVA = "0xAE8840", Offset = "0xAE7A40", VA = "0x180AE8840")]
		public string GetDeckNameByID(int trialID, int deckID = 1)
		{
			return null;
		}

		[Token(Token = "0x6006809")]
		[Address(RVA = "0xAE7030", Offset = "0xAE6230", VA = "0x180AE7030")]
		public Dictionary<string, object> GetAccessory(int trialID, int deckID = 1)
		{
			return null;
		}

		[Token(Token = "0x600680A")]
		[Address(RVA = "0xAE8BA0", Offset = "0xAE7DA0", VA = "0x180AE8BA0")]
		public Dictionary<string, object> GetPickUpCardIDs(int trialID, int deckID = 1)
		{
			return null;
		}

		[Token(Token = "0x600680B")]
		[Address(RVA = "0xAE8920", Offset = "0xAE7B20", VA = "0x180AE8920")]
		public Dictionary<string, object> GetPickUpCardDecorations(int trialID, int deckID = 1)
		{
			return null;
		}

		[Token(Token = "0x600680C")]
		[Address(RVA = "0xAE8C70", Offset = "0xAE7E70", VA = "0x180AE8C70")]
		public Dictionary<string, object> GetPickUps(int trialID, int deckID = 1)
		{
			return null;
		}

		[Token(Token = "0x600680D")]
		[Address(RVA = "0xAE7CE0", Offset = "0xAE6EE0", VA = "0x180AE7CE0")]
		public new Dictionary<KeyValuePair<int, int>, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x600680E")]
		[Address(RVA = "0xAE7990", Offset = "0xAE6B90", VA = "0x180AE7990")]
		public Dictionary<int, string> GetDeckIDAndNameByTrialID(int trialID)
		{
			return null;
		}

		[Token(Token = "0x600680F")]
		[Address(RVA = "0xAE8220", Offset = "0xAE7420", VA = "0x180AE8220")]
		public List<int> GetDeckListByID(int trialID, int deckID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006810")]
		[Address(RVA = "0xAE7370", Offset = "0xAE6570", VA = "0x180AE7370")]
		public List<int> GetCardPremiumByID(int trialID, int deckID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006811")]
		[Address(RVA = "0xAE7160", Offset = "0xAE6360", VA = "0x180AE7160")]
		public List<CardBaseData> GetCardBaseListByID(int trialID, int deckID, DeckType type)
		{
			return null;
		}
	}

	[Token(Token = "0x20010B9")]
	public class VersusDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006812")]
		[Address(RVA = "0xAEFD30", Offset = "0xAEEF30", VA = "0x180AEFD30")]
		public VersusDeckInfo()
		{
		}

		[Token(Token = "0x6006813")]
		[Address(RVA = "0xAEEDA0", Offset = "0xAEDFA0", VA = "0x180AEEDA0")]
		public new Dictionary<KeyValuePair<int, int>, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x6006814")]
		[Address(RVA = "0xAEE570", Offset = "0xAED770", VA = "0x180AEE570")]
		public List<CardBaseData> GetCardBaseListByID(int versusId, int groupId, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006815")]
		[Address(RVA = "0xAEF2E0", Offset = "0xAEE4E0", VA = "0x180AEF2E0")]
		public List<int> GetDeckListByID(int versusId, int groupId, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006816")]
		[Address(RVA = "0xAEE780", Offset = "0xAED980", VA = "0x180AEE780")]
		public List<int> GetCardPremiumByID(int versusId, int groupId, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006817")]
		[Address(RVA = "0xAEE4A0", Offset = "0xAED6A0", VA = "0x180AEE4A0")]
		public Dictionary<string, object> GetAccessory(int versusId, int versusGroupId)
		{
			return null;
		}

		[Token(Token = "0x6006818")]
		[Address(RVA = "0xAEFB80", Offset = "0xAEED80", VA = "0x180AEFB80")]
		public Dictionary<string, object> GetPickUps(int versusId, int versusGroupId)
		{
			return null;
		}

		[Token(Token = "0x6006819")]
		[Address(RVA = "0xAEF9E0", Offset = "0xAEEBE0", VA = "0x180AEF9E0")]
		public Dictionary<string, object> GetPickUpCardIDs(int versusId, int versusGroupId)
		{
			return null;
		}

		[Token(Token = "0x600681A")]
		[Address(RVA = "0xAEFAB0", Offset = "0xAEECB0", VA = "0x180AEFAB0")]
		public Dictionary<string, object> GetPickUpCardPremiums(int versusId, int versusGroupId)
		{
			return null;
		}

		[Token(Token = "0x600681B")]
		[Address(RVA = "0xAEF900", Offset = "0xAEEB00", VA = "0x180AEF900")]
		public string GetDeckNameByID(int versusID, int groupID = 1)
		{
			return null;
		}
	}

	[Token(Token = "0x20010BA")]
	public class StandardRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x600681C")]
		[Address(RVA = "0xAEE0B0", Offset = "0xAED2B0", VA = "0x180AEE0B0")]
		public StandardRentalDeckInfo()
		{
		}

		[Token(Token = "0x600681D")]
		[Address(RVA = "0xAEDDC0", Offset = "0xAECFC0", VA = "0x180AEDDC0")]
		public static List<int> GetRentalDeckIDs()
		{
			return null;
		}

		[Token(Token = "0x600681E")]
		[Address(RVA = "0xAED8B0", Offset = "0xAECAB0", VA = "0x180AED8B0", Slot = "5")]
		public override string GetDeckNameByID(int deckID)
		{
			return null;
		}

		[Token(Token = "0x600681F")]
		[Address(RVA = "0xAED6F0", Offset = "0xAEC8F0", VA = "0x180AED6F0")]
		public static string GetDeckDesc(int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006820")]
		[Address(RVA = "0xAED800", Offset = "0xAECA00", VA = "0x180AED800")]
		public new Dictionary<string, object> GetDeckDictByID(int deckID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006821")]
		[Address(RVA = "0xAED660", Offset = "0xAEC860", VA = "0x180AED660", Slot = "11")]
		public override Dictionary<string, object> GetAccessory(int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006822")]
		[Address(RVA = "0xAEDC20", Offset = "0xAECE20", VA = "0x180AEDC20")]
		public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006823")]
		[Address(RVA = "0xAED9C0", Offset = "0xAECBC0", VA = "0x180AED9C0")]
		public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006824")]
		[Address(RVA = "0xAEDCB0", Offset = "0xAECEB0", VA = "0x180AEDCB0")]
		public Dictionary<string, object> GetPickUps(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006825")]
		[Address(RVA = "0xAEE020", Offset = "0xAED220", VA = "0x180AEE020")]
		public bool GetRentalPickMark(int deckID)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x20010BB")]
	public class RateRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006826")]
		[Address(RVA = "0xAEBBE0", Offset = "0xAEADE0", VA = "0x180AEBBE0")]
		public static List<int> GetRentalDeckIDs(int seasonID)
		{
			return null;
		}

		[Token(Token = "0x6006827")]
		[Address(RVA = "0xAEB660", Offset = "0xAEA860", VA = "0x180AEB660")]
		public string GetDeckNameByID(int deckID, int seasonID)
		{
			return null;
		}

		[Token(Token = "0x6006828")]
		[Address(RVA = "0xAEB470", Offset = "0xAEA670", VA = "0x180AEB470")]
		public static string GetDeckDesc(int deckID, int seasonID)
		{
			return null;
		}

		[Token(Token = "0x6006829")]
		[Address(RVA = "0xAEB5B0", Offset = "0xAEA7B0", VA = "0x180AEB5B0")]
		public new Dictionary<string, object> GetDeckDictByID(int deckID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x600682A")]
		[Address(RVA = "0xAEB3C0", Offset = "0xAEA5C0", VA = "0x180AEB3C0")]
		public Dictionary<string, object> GetAccessory(int deckID, int seasonID)
		{
			return null;
		}

		[Token(Token = "0x600682B")]
		[Address(RVA = "0xAEBA20", Offset = "0xAEAC20", VA = "0x180AEBA20")]
		public Dictionary<string, object> GetPickUpCardIDs(int deckID, int seasonID)
		{
			return null;
		}

		[Token(Token = "0x600682C")]
		[Address(RVA = "0xAEB7A0", Offset = "0xAEA9A0", VA = "0x180AEB7A0")]
		public Dictionary<string, object> GetPickUpCardDecorations(int deckID, int seasonID)
		{
			return null;
		}

		[Token(Token = "0x600682D")]
		[Address(RVA = "0xAEBAD0", Offset = "0xAEACD0", VA = "0x180AEBAD0")]
		public Dictionary<string, object> GetPickUps(int deckID, int seasonID)
		{
			return null;
		}

		[Token(Token = "0x600682E")]
		[Address(RVA = "0xAEBE70", Offset = "0xAEB070", VA = "0x180AEBE70")]
		public bool GetRentalPickMark(int deckID, int seasonID)
		{
			return default(bool);
		}

		[Token(Token = "0x600682F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RateRentalDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010BC")]
	public class ExhibitionRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006830")]
		[Address(RVA = "0xAEAF80", Offset = "0xAEA180", VA = "0x180AEAF80")]
		public static List<int> GetRentalDeckIDs(int exhid)
		{
			return null;
		}

		[Token(Token = "0x6006831")]
		[Address(RVA = "0xAEAA00", Offset = "0xAE9C00", VA = "0x180AEAA00")]
		public string GetDeckNameByID(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006832")]
		[Address(RVA = "0xAEA7F0", Offset = "0xAE99F0", VA = "0x180AEA7F0")]
		public static string GetDeckDesc(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006833")]
		[Address(RVA = "0xAEA930", Offset = "0xAE9B30", VA = "0x180AEA930")]
		public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006834")]
		[Address(RVA = "0xAEA740", Offset = "0xAE9940", VA = "0x180AEA740")]
		public Dictionary<string, object> GetAccessory(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006835")]
		[Address(RVA = "0xAEADC0", Offset = "0xAE9FC0", VA = "0x180AEADC0")]
		public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006836")]
		[Address(RVA = "0xAEAB40", Offset = "0xAE9D40", VA = "0x180AEAB40")]
		public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006837")]
		[Address(RVA = "0xAEAE70", Offset = "0xAEA070", VA = "0x180AEAE70")]
		public Dictionary<string, object> GetPickUps(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006838")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ExhibitionRentalDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010BD")]
	public class DuelTrialRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006839")]
		[Address(RVA = "0xAE9640", Offset = "0xAE8840", VA = "0x180AE9640")]
		public static List<int> GetRentalDeckIDs(int exhid)
		{
			return null;
		}

		[Token(Token = "0x600683A")]
		[Address(RVA = "0xAE90C0", Offset = "0xAE82C0", VA = "0x180AE90C0")]
		public string GetDeckNameByID(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600683B")]
		[Address(RVA = "0xAE8EB0", Offset = "0xAE80B0", VA = "0x180AE8EB0")]
		public static string GetDeckDesc(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600683C")]
		[Address(RVA = "0xAE8FF0", Offset = "0xAE81F0", VA = "0x180AE8FF0")]
		public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x600683D")]
		[Address(RVA = "0xAE8E00", Offset = "0xAE8000", VA = "0x180AE8E00")]
		public Dictionary<string, object> GetAccessory(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600683E")]
		[Address(RVA = "0xAE9480", Offset = "0xAE8680", VA = "0x180AE9480")]
		public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600683F")]
		[Address(RVA = "0xAE9200", Offset = "0xAE8400", VA = "0x180AE9200")]
		public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006840")]
		[Address(RVA = "0xAE9530", Offset = "0xAE8730", VA = "0x180AE9530")]
		public Dictionary<string, object> GetPickUps(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006841")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DuelTrialRentalDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010BE")]
	public class VersusRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006842")]
		[Address(RVA = "0xAF04B0", Offset = "0xAEF6B0", VA = "0x180AF04B0")]
		public static List<int> GetRentalDeckIDs(int vid, int groupId)
		{
			return null;
		}

		[Token(Token = "0x6006843")]
		[Address(RVA = "0xAEFF30", Offset = "0xAEF130", VA = "0x180AEFF30")]
		public string GetDeckNameByID(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006844")]
		[Address(RVA = "0xAEFE60", Offset = "0xAEF060", VA = "0x180AEFE60")]
		public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006845")]
		[Address(RVA = "0xAEFDB0", Offset = "0xAEEFB0", VA = "0x180AEFDB0")]
		public Dictionary<string, object> GetAccessory(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006846")]
		[Address(RVA = "0xAF02F0", Offset = "0xAEF4F0", VA = "0x180AF02F0")]
		public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006847")]
		[Address(RVA = "0xAF0070", Offset = "0xAEF270", VA = "0x180AF0070")]
		public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006848")]
		[Address(RVA = "0xAF03A0", Offset = "0xAEF5A0", VA = "0x180AF03A0")]
		public Dictionary<string, object> GetPickUps(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006849")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public VersusRentalDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010BF")]
	public class RdcDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x600684A")]
		[Address(RVA = "0xAECC20", Offset = "0xAEBE20", VA = "0x180AECC20")]
		public RdcDeckInfo()
		{
		}

		[Token(Token = "0x600684B")]
		[Address(RVA = "0xAEC4E0", Offset = "0xAEB6E0", VA = "0x180AEC4E0")]
		public new Dictionary<int, string> GetDeckIDAndName()
		{
			return null;
		}

		[Token(Token = "0x600684C")]
		[Address(RVA = "0xAEC890", Offset = "0xAEBA90", VA = "0x180AEC890")]
		public string GetDeckName()
		{
			return null;
		}

		[Token(Token = "0x600684D")]
		[Address(RVA = "0xAEC450", Offset = "0xAEB650", VA = "0x180AEC450", Slot = "19")]
		public virtual Dictionary<string, object> GetDeckDict(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x600684E")]
		[Address(RVA = "0xAEC620", Offset = "0xAEB820", VA = "0x180AEC620")]
		public List<int> GetDeckListByID(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x600684F")]
		[Address(RVA = "0xAEC180", Offset = "0xAEB380", VA = "0x180AEC180")]
		public List<int> GetCardPremiumByID(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006850")]
		[Address(RVA = "0xAEBF90", Offset = "0xAEB190", VA = "0x180AEBF90")]
		public List<CardBaseData> GetCardBaseListByID(DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006851")]
		[Address(RVA = "0xAEBF20", Offset = "0xAEB120", VA = "0x180AEBF20")]
		public Dictionary<string, object> GetAccessory()
		{
			return null;
		}

		[Token(Token = "0x6006852")]
		[Address(RVA = "0xAEC910", Offset = "0xAEBB10", VA = "0x180AEC910")]
		public Dictionary<string, object> GetPickUpCardIDs()
		{
			return null;
		}

		[Token(Token = "0x6006853")]
		[Address(RVA = "0xAEC980", Offset = "0xAEBB80", VA = "0x180AEC980")]
		public Dictionary<string, object> GetPickUpCardPremiums()
		{
			return null;
		}

		[Token(Token = "0x6006854")]
		[Address(RVA = "0xAEC9F0", Offset = "0xAEBBF0", VA = "0x180AEC9F0")]
		public Dictionary<string, object> GetPickUps()
		{
			return null;
		}

		[Token(Token = "0x6006855")]
		[Address(RVA = "0xAECBB0", Offset = "0xAEBDB0", VA = "0x180AECBB0")]
		public int GetStage()
		{
			return default(int);
		}

		[Token(Token = "0x6006856")]
		[Address(RVA = "0xAEC3F0", Offset = "0xAEB5F0", VA = "0x180AEC3F0")]
		public int GetDeckBoxID()
		{
			return default(int);
		}
	}

	[Token(Token = "0x20010C0")]
	public class RdcRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006857")]
		[Address(RVA = "0xAED400", Offset = "0xAEC600", VA = "0x180AED400")]
		public List<int> GetRentalDeckIDs()
		{
			return null;
		}

		[Token(Token = "0x6006858")]
		[Address(RVA = "0xAECD30", Offset = "0xAEBF30", VA = "0x180AECD30")]
		public string GetDeckDesc(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006859")]
		[Address(RVA = "0xAECEF0", Offset = "0xAEC0F0", VA = "0x180AECEF0")]
		public string GetDeckNameByID(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600685A")]
		[Address(RVA = "0xAECE40", Offset = "0xAEC040", VA = "0x180AECE40", Slot = "9")]
		public override Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x600685B")]
		[Address(RVA = "0xAECCA0", Offset = "0xAEBEA0", VA = "0x180AECCA0")]
		public Dictionary<string, object> GetAccessory(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600685C")]
		[Address(RVA = "0xAED260", Offset = "0xAEC460", VA = "0x180AED260")]
		public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600685D")]
		[Address(RVA = "0xAED000", Offset = "0xAEC200", VA = "0x180AED000")]
		public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600685E")]
		[Address(RVA = "0xAED2F0", Offset = "0xAEC4F0", VA = "0x180AED2F0")]
		public Dictionary<string, object> GetPickUps(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600685F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public RdcRentalDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010C1")]
	public class DicerallyDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006860")]
		[Address(RVA = "0xAE6770", Offset = "0xAE5970", VA = "0x180AE6770")]
		public DicerallyDeckInfo()
		{
		}

		[Token(Token = "0x6006861")]
		[Address(RVA = "0xAE5500", Offset = "0xAE4700", VA = "0x180AE5500")]
		public new Dictionary<string, object> GetAccessory(int tid)
		{
			return null;
		}

		[Token(Token = "0x6006862")]
		[Address(RVA = "0xAE65C0", Offset = "0xAE57C0", VA = "0x180AE65C0")]
		public new Dictionary<string, object> GetPickUpCardIDs(int tid)
		{
			return null;
		}

		[Token(Token = "0x6006863")]
		[Address(RVA = "0xAE6360", Offset = "0xAE5560", VA = "0x180AE6360")]
		public Dictionary<string, object> GetPickUpCardDecorations(int tid)
		{
			return null;
		}

		[Token(Token = "0x6006864")]
		[Address(RVA = "0xAE6660", Offset = "0xAE5860", VA = "0x180AE6660")]
		public new Dictionary<string, object> GetPickUps(int tid)
		{
			return null;
		}

		[Token(Token = "0x6006865")]
		[Address(RVA = "0xAE5DB0", Offset = "0xAE4FB0", VA = "0x180AE5DB0")]
		public new List<int> GetDeckListByID(int tid, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006866")]
		[Address(RVA = "0xAE5800", Offset = "0xAE4A00", VA = "0x180AE5800")]
		public new List<int> GetCardPremiumByID(int tid, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x6006867")]
		[Address(RVA = "0xAE5600", Offset = "0xAE4800", VA = "0x180AE5600")]
		public new List<CardBaseData> GetCardBaseListByID(int tid, DeckType type)
		{
			return null;
		}
	}

	[Token(Token = "0x20010C2")]
	public class DicerallyRentalDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006868")]
		[Address(RVA = "0xAE6AB0", Offset = "0xAE5CB0", VA = "0x180AE6AB0")]
		public string GetDeckNameByID(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x6006869")]
		[Address(RVA = "0xAE68A0", Offset = "0xAE5AA0", VA = "0x180AE68A0")]
		public static string GetDeckDesc(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600686A")]
		[Address(RVA = "0xAE69E0", Offset = "0xAE5BE0", VA = "0x180AE69E0")]
		public new Dictionary<string, object> GetDeckDictByID(int deckID, int eventID, DeckType type)
		{
			return null;
		}

		[Token(Token = "0x600686B")]
		[Address(RVA = "0xAE67F0", Offset = "0xAE59F0", VA = "0x180AE67F0")]
		public Dictionary<string, object> GetAccessory(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600686C")]
		[Address(RVA = "0xAE6E70", Offset = "0xAE6070", VA = "0x180AE6E70")]
		public Dictionary<string, object> GetPickUpCardIDs(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600686D")]
		[Address(RVA = "0xAE6BF0", Offset = "0xAE5DF0", VA = "0x180AE6BF0")]
		public Dictionary<string, object> GetPickUpCardDecorations(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600686E")]
		[Address(RVA = "0xAE6F20", Offset = "0xAE6120", VA = "0x180AE6F20")]
		public Dictionary<string, object> GetPickUps(int eventID, int deckID)
		{
			return null;
		}

		[Token(Token = "0x600686F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public DicerallyRentalDeckInfo()
		{
		}
	}

	[Token(Token = "0x20010C3")]
	public class ReplayDeckInfo : BaseDeckInfo
	{
		[Token(Token = "0x6006870")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ReplayDeckInfo()
		{
		}
	}

	[Token(Token = "0x400B144")]
	private const string CLIENTWORK_PATH_DECK_LISTS = "$.Deck.list";

	[Token(Token = "0x400B145")]
	private const string CLIENTWORK_PATH_DECKLIST = "$.DeckList";

	[Token(Token = "0x400B146")]
	private const string CLIENTWORK_PATH_TOURNAMENT = "$.TDeckList";

	[Token(Token = "0x400B147")]
	private const string CLIENTWORK_PATH_TOURNAMENT_DECK_LIST = "$.TDeck.list";

	[Token(Token = "0x400B148")]
	private const string CLIENTWORK_PATH_EXHIBITION = "$.EXHDeckList";

	[Token(Token = "0x400B149")]
	private const string CLIENTWORK_PATH_EXHIBITION_DECK_LIST = "$.EXHDeck.list";

	[Token(Token = "0x400B14A")]
	private const string CLIENTWORK_PATH_CUP = "$.CUPDeckList";

	[Token(Token = "0x400B14B")]
	private const string CLIENTWORK_PATH_CUP_DECK_LIST = "$.CUPDeck";

	[Token(Token = "0x400B14C")]
	private const string CLIENTWORK_PATH_RANKEVENT = "$.REDeckList";

	[Token(Token = "0x400B14D")]
	private const string CLIENTWORK_PATH_RANKEVENT_DECK_LIST = "$.REDeck.list";

	[Token(Token = "0x400B14E")]
	private const string CLIENTWORK_PATH_DUELTRIAL = "$.DTDeckList";

	[Token(Token = "0x400B14F")]
	private const string CLIENTWORK_PATH_DUELTRIAL_DECK_LIST = "$.DTDeck.list";

	[Token(Token = "0x400B150")]
	private const string CLIENTWORK_PATH_VERSUS = "$.VDeckList";

	[Token(Token = "0x400B151")]
	private const string CLIENTWORK_PATH_VERSUS_DECK_LIST = "$.VDeck.list";

	[Token(Token = "0x400B152")]
	private const string CLIENTWORK_PATH_DICERALLY = "$.RDDeckList";

	[Token(Token = "0x400B153")]
	private const string CLIENTWORK_PATH_DICERALLY_DECK_LIST = "$.RDDeck.list";

	[Token(Token = "0x400B154")]
	private const string CLIENTWORK_PATH_CARD_FAVORITE = "$.Cards.favorite.";

	[Token(Token = "0x400B155")]
	private const string CLIENTWORK_PATH_CARD_LOCK = "$.Cards.lock.";

	[Token(Token = "0x400B156")]
	private const string KEY_DECK_COUNT = "num";

	[Token(Token = "0x400B157")]
	private const string KEY_DECK_MAX = "empty";

	[Token(Token = "0x400B158")]
	private const string KEY_DECK_ID = "deck_id";

	[Token(Token = "0x400B159")]
	private const string KEY_DECK_NAME = "name";

	[Token(Token = "0x400B15A")]
	private const string KEY_DECK_REG = "regulation_id";

	[Token(Token = "0x400B15B")]
	private const string KEY_DECKLIST_MAIN = "m";

	[Token(Token = "0x400B15C")]
	private const string KEY_DECKLIST_EXTRA = "e";

	[Token(Token = "0x400B15D")]
	private const string KEY_DECKLIST_SIDE = "s";

	[Token(Token = "0x400B15E")]
	private const string KEY_DECKLIST_TRAY = "t";

	[Token(Token = "0x400B15F")]
	private const string KEY_DECKLIST_CARDIDS = "ids";

	[Token(Token = "0x400B160")]
	private const string KEY_DECKLIST_PREMIUMIDS = "r";

	[Token(Token = "0x400B161")]
	private const string KEY_TOURNAMENT_DECKLIST = "DeckList.1";

	[Token(Token = "0x400B162")]
	private const string KEY_CARD_CARDIDS = "ids";

	[Token(Token = "0x400B163")]
	private const string KEY_CARD_PREMIUMIDS = "r";

	[Token(Token = "0x400B164")]
	private const string KEY_CARD_FAVOTITE_CARDLIST = "card_list";

	[Token(Token = "0x400B165")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public static readonly int PICKUPCARDS_NUM;

	[Token(Token = "0x400B166")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static MyDeckInfo myDeckInfo;

	[Token(Token = "0x400B167")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static StandardRentalDeckInfo standardRentalDeckInfo;

	[Token(Token = "0x400B168")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static RateRentalDeckInfo rateRentalDeckInfo;

	[Token(Token = "0x400B169")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public static ExhibitionDeckInfo exhibitionDeckInfo;

	[Token(Token = "0x400B16A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public static DuelistCupDeckInfo duelistCupDeckInfo;

	[Token(Token = "0x400B16B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public static WCSDeckInfo wcsCupDeckInfo;

	[Token(Token = "0x400B16C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public static WCSFinalDeckInfo wcsFinalDeckInfo;

	[Token(Token = "0x400B16D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	public static RankEventDeckInfo rankEventDeckInfo;

	[Token(Token = "0x400B16E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public static DuelTrialDeckInfo duelTrialDeckInfo;

	[Token(Token = "0x400B16F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static VersusDeckInfo versusDeckInfo;

	[Token(Token = "0x400B170")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public static ExhibitionRentalDeckInfo exhibitionRentalDeckInfo;

	[Token(Token = "0x400B171")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public static DuelTrialRentalDeckInfo duelTrialRentalDeckInfo;

	[Token(Token = "0x400B172")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public static VersusRentalDeckInfo versusRentalDeckInfo;

	[Token(Token = "0x400B173")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public static RdcDeckInfo rdcDeckInfo;

	[Token(Token = "0x400B174")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public static RdcRentalDeckInfo rdcRentalDeckInfo;

	[Token(Token = "0x400B175")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public static DicerallyDeckInfo dicerallyDeckInfo;

	[Token(Token = "0x400B176")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public static DicerallyRentalDeckInfo dicerallyRentalDeckInfo;

	[Token(Token = "0x400B177")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public static ReplayDeckInfo replayDeckInfo;

	[Token(Token = "0x400B178")]
	public const string k_ArgsKeyDeckCase = "box";

	[Token(Token = "0x400B179")]
	public const string k_ArgsKeyProtector = "sleeve";

	[Token(Token = "0x400B17A")]
	public const string k_ArgsKeyField = "field";

	[Token(Token = "0x400B17B")]
	public const string k_ArgsKeyObject = "object";

	[Token(Token = "0x400B17C")]
	public const string k_ArgsKeyMateBase = "av_base";

	[Token(Token = "0x400B17D")]
	public const string k_ArgsKeyPickIds = "pickIds";

	[Token(Token = "0x400B17E")]
	public const string k_ArgsKeyPickDecos = "pickDecos";

	[Token(Token = "0x400B17F")]
	public const string k_ArgsKeyRegulation = "regulation";

	[Token(Token = "0x400B180")]
	public const string k_ArgsKeyEvent = "event";

	[Token(Token = "0x400B181")]
	public const string k_ArgsKeyLogo = "logo";

	[Token(Token = "0x400B182")]
	public const string k_ArgsKeyStage = "stage";

	[Token(Token = "0x400B183")]
	public const string k_ArgsKeyName = "name";

	[Token(Token = "0x170010B2")]
	public static bool isReachDeckNumLimit
	{
		[Token(Token = "0x600674E")]
		[Address(RVA = "0xAD0FD0", Offset = "0xAD01D0", VA = "0x180AD0FD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600674F")]
	[Address(RVA = "0xAC3170", Offset = "0xAC2370", VA = "0x180AC3170")]
	public static int GetDeckNum()
	{
		return default(int);
	}

	[Token(Token = "0x6006750")]
	[Address(RVA = "0xAC2D70", Offset = "0xAC1F70", VA = "0x180AC2D70")]
	public static int GetDeckLimit()
	{
		return default(int);
	}

	[Token(Token = "0x6006751")]
	[Address(RVA = "0xAC1820", Offset = "0xAC0A20", VA = "0x180AC1820")]
	public static Dictionary<string, object> DeckSaveFormatParser(List<CardBaseData> main, List<CardBaseData> extra, List<CardBaseData> side, bool exceptRental = true)
	{
		return null;
	}

	[Token(Token = "0x6006752")]
	[Address(RVA = "0xACA440", Offset = "0xAC9640", VA = "0x180ACA440")]
	public static bool GetProfileEditTypeFromDeckEventType(DeckSelectViewController2.DeckEventType deckEventType, out ProfileEditViewController.EditType editType)
	{
		return default(bool);
	}

	[Token(Token = "0x6006753")]
	[Address(RVA = "0xAC9560", Offset = "0xAC8760", VA = "0x180AC9560")]
	public static List<CardBaseData> GetFavoriteCardBaseData()
	{
		return null;
	}

	[Token(Token = "0x6006754")]
	[Address(RVA = "0xAC9850", Offset = "0xAC8A50", VA = "0x180AC9850")]
	private static List<int> GetFavoriteCardIDList()
	{
		return null;
	}

	[Token(Token = "0x6006755")]
	[Address(RVA = "0xAC9A90", Offset = "0xAC8C90", VA = "0x180AC9A90")]
	private static List<int> GetFavoriteCardPremiumList()
	{
		return null;
	}

	[Token(Token = "0x6006756")]
	[Address(RVA = "0xAC1FC0", Offset = "0xAC11C0", VA = "0x180AC1FC0")]
	public static Dictionary<string, object> FavoriteSaveFormatParser(List<CardBaseData> bookmark)
	{
		return null;
	}

	[Token(Token = "0x6006757")]
	[Address(RVA = "0xAC9CD0", Offset = "0xAC8ED0", VA = "0x180AC9CD0")]
	public static List<CardBaseData> GetLockListCardBaseData()
	{
		return null;
	}

	[Token(Token = "0x6006758")]
	[Address(RVA = "0xAC9FC0", Offset = "0xAC91C0", VA = "0x180AC9FC0")]
	private static List<int> GetLockListCardIDList()
	{
		return null;
	}

	[Token(Token = "0x6006759")]
	[Address(RVA = "0xACA200", Offset = "0xAC9400", VA = "0x180ACA200")]
	private static List<int> GetLockListCardPremiumList()
	{
		return null;
	}

	[Token(Token = "0x600675A")]
	[Address(RVA = "0xAD02C0", Offset = "0xACF4C0", VA = "0x180AD02C0")]
	public static Dictionary<string, object> LockListSaveFormatParser(List<CardBaseData> lockList)
	{
		return null;
	}

	[Token(Token = "0x600675B")]
	[Address(RVA = "0xAC0CC0", Offset = "0xABFEC0", VA = "0x180AC0CC0")]
	public static GameObject CreateEmbedObj(Dictionary<string, object> args, ElementObjectManager eom, Transform transform)
	{
		return null;
	}

	[Token(Token = "0x600675C")]
	[Address(RVA = "0xAD05F0", Offset = "0xACF7F0", VA = "0x180AD05F0")]
	public static void SetEmbedObjectCallback(GameObject deckOverviewGo, Dictionary<string, object> profileEditArgs, [Optional] Action additionalOnClick)
	{
	}

	[Token(Token = "0x600675D")]
	[Address(RVA = "0xAD08B0", Offset = "0xACFAB0", VA = "0x180AD08B0")]
	private static void SetOpenProfileEditCallback(Dictionary<string, object> profileEditArgs, SelectionButton btn, ProfileEditViewController.SideMenuType sideMenuType, [Optional] Action additionalOnClick)
	{
	}

	[Token(Token = "0x600675E")]
	[Address(RVA = "0xACAAA0", Offset = "0xAC9CA0", VA = "0x180ACAAA0")]
	public static Dictionary<int, string> GetRankEventDeckIDAndName()
	{
		return null;
	}

	[Token(Token = "0x600675F")]
	[Address(RVA = "0xACADD0", Offset = "0xAC9FD0", VA = "0x180ACADD0")]
	public static List<int> GetRankEventDeckList(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006760")]
	[Address(RVA = "0xACA710", Offset = "0xAC9910", VA = "0x180ACA710")]
	public static List<int> GetRankEventCardPremium(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006761")]
	[Address(RVA = "0xACA500", Offset = "0xAC9700", VA = "0x180ACA500")]
	public static List<CardBaseData> GetRankEventCardBaseData(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006762")]
	[Address(RVA = "0xACAA10", Offset = "0xAC9C10", VA = "0x180ACAA10")]
	public static Dictionary<string, object> GetRankEventDeckAccessory(int id)
	{
		return null;
	}

	[Token(Token = "0x6006763")]
	[Address(RVA = "0xAC2800", Offset = "0xAC1A00", VA = "0x180AC2800")]
	public static string GetCupDeckName()
	{
		return null;
	}

	[Token(Token = "0x6006764")]
	[Address(RVA = "0xAD0250", Offset = "0xACF450", VA = "0x180AD0250")]
	public static string GetWcsDeckName()
	{
		return null;
	}

	[Token(Token = "0x6006765")]
	[Address(RVA = "0xACB0C0", Offset = "0xACA2C0", VA = "0x180ACB0C0")]
	public static string GetRankEventDeckNameByID(int id)
	{
		return null;
	}

	[Token(Token = "0x6006766")]
	[Address(RVA = "0xACB1F0", Offset = "0xACA3F0", VA = "0x180ACB1F0")]
	public static Dictionary<string, object> GetRankEventPickUpCardIDs(int id)
	{
		return null;
	}

	[Token(Token = "0x6006767")]
	[Address(RVA = "0xACB160", Offset = "0xACA360", VA = "0x180ACB160")]
	public static Dictionary<string, object> GetRankEventPickUpCardDecorations(int id)
	{
		return null;
	}

	[Token(Token = "0x6006768")]
	[Address(RVA = "0xACB280", Offset = "0xACA480", VA = "0x180ACB280")]
	public static Dictionary<string, object> GetRankEventPickUps(int tid)
	{
		return null;
	}

	[Token(Token = "0x6006769")]
	[Address(RVA = "0xAC2A20", Offset = "0xAC1C20", VA = "0x180AC2A20")]
	public static Dictionary<int, string> GetDeckIDAndName()
	{
		return null;
	}

	[Token(Token = "0x600676A")]
	[Address(RVA = "0xAC30D0", Offset = "0xAC22D0", VA = "0x180AC30D0")]
	public static string GetDeckNameByID(int id)
	{
		return null;
	}

	[Token(Token = "0x600676B")]
	[Address(RVA = "0xAC2DD0", Offset = "0xAC1FD0", VA = "0x180AC2DD0")]
	public static List<int> GetDeckListByID(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x600676C")]
	[Address(RVA = "0xAC2500", Offset = "0xAC1700", VA = "0x180AC2500")]
	public static List<int> GetCardPremiumByID(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x600676D")]
	[Address(RVA = "0xAC22F0", Offset = "0xAC14F0", VA = "0x180AC22F0")]
	public static List<CardBaseData> GetCardBaseDataByID(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x600676E")]
	[Address(RVA = "0xAC35C0", Offset = "0xAC27C0", VA = "0x180AC35C0")]
	public static int[] GetDeckPickUpCardIDs(int id)
	{
		return null;
	}

	[Token(Token = "0x600676F")]
	[Address(RVA = "0xAC3260", Offset = "0xAC2460", VA = "0x180AC3260")]
	public static int[] GetDeckPickUpCardDecorations(int id)
	{
		return null;
	}

	[Token(Token = "0x6006770")]
	[Address(RVA = "0xAC3530", Offset = "0xAC2730", VA = "0x180AC3530")]
	public static Dictionary<string, object> GetDeckPickUpCardIDs2(int id)
	{
		return null;
	}

	[Token(Token = "0x6006771")]
	[Address(RVA = "0xAC31D0", Offset = "0xAC23D0", VA = "0x180AC31D0")]
	public static Dictionary<string, object> GetDeckPickUpCardDecorations2(int id)
	{
		return null;
	}

	[Token(Token = "0x6006772")]
	[Address(RVA = "0xAC3840", Offset = "0xAC2A40", VA = "0x180AC3840")]
	public static Dictionary<string, object> GetDeckPickUps(int id)
	{
		return null;
	}

	[Token(Token = "0x6006773")]
	[Address(RVA = "0xAC2990", Offset = "0xAC1B90", VA = "0x180AC2990")]
	public static long GetDeckEditTime(int id)
	{
		return default(long);
	}

	[Token(Token = "0x6006774")]
	[Address(RVA = "0xAC2900", Offset = "0xAC1B00", VA = "0x180AC2900")]
	public static long GetDeckCreateTime(int id)
	{
		return default(long);
	}

	[Token(Token = "0x6006775")]
	[Address(RVA = "0xAC2870", Offset = "0xAC1A70", VA = "0x180AC2870")]
	public static Dictionary<string, object> GetDeckAccessory(int id)
	{
		return null;
	}

	[Token(Token = "0x6006776")]
	[Address(RVA = "0xACCF50", Offset = "0xACC150", VA = "0x180ACCF50")]
	public static List<int> GetRentalDeckIDs()
	{
		return null;
	}

	[Token(Token = "0x6006777")]
	[Address(RVA = "0xACD1B0", Offset = "0xACC3B0", VA = "0x180ACD1B0")]
	private static List<int> GetRentalDeckList(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006778")]
	[Address(RVA = "0xACCAD0", Offset = "0xACBCD0", VA = "0x180ACCAD0")]
	private static List<int> GetRentalCardPremium(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006779")]
	[Address(RVA = "0xACC8B0", Offset = "0xACBAB0", VA = "0x180ACC8B0")]
	public static List<CardBaseData> GetRentalCardBaseData(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x600677A")]
	[Address(RVA = "0xACCDB0", Offset = "0xACBFB0", VA = "0x180ACCDB0")]
	public static Dictionary<string, object> GetRentalDeckAccessory(int id)
	{
		return null;
	}

	[Token(Token = "0x600677B")]
	[Address(RVA = "0xACD950", Offset = "0xACCB50", VA = "0x180ACD950")]
	private static Dictionary<string, object> GetRentalPickUpCardIDs(int id)
	{
		return null;
	}

	[Token(Token = "0x600677C")]
	[Address(RVA = "0xACD7C0", Offset = "0xACC9C0", VA = "0x180ACD7C0")]
	public static int[] GetRentalPickUpCardIDArray(int id)
	{
		return null;
	}

	[Token(Token = "0x600677D")]
	[Address(RVA = "0xACD730", Offset = "0xACC930", VA = "0x180ACD730")]
	private static Dictionary<string, object> GetRentalPickUpCardDecorations(int id)
	{
		return null;
	}

	[Token(Token = "0x600677E")]
	[Address(RVA = "0xACD5A0", Offset = "0xACC7A0", VA = "0x180ACD5A0")]
	public static int[] GetRentalPickUpCardDecorationArray(int id)
	{
		return null;
	}

	[Token(Token = "0x600677F")]
	[Address(RVA = "0xACD9E0", Offset = "0xACCBE0", VA = "0x180ACD9E0")]
	public static Dictionary<string, object> GetRentalPickUps(int id)
	{
		return null;
	}

	[Token(Token = "0x6006780")]
	[Address(RVA = "0xACD490", Offset = "0xACC690", VA = "0x180ACD490")]
	public static string GetRentalDeckName(int id)
	{
		return null;
	}

	[Token(Token = "0x6006781")]
	[Address(RVA = "0xACCE40", Offset = "0xACC040", VA = "0x180ACCE40")]
	public static string GetRentalDeckDesc(int id)
	{
		return null;
	}

	[Token(Token = "0x6006782")]
	[Address(RVA = "0xACBB40", Offset = "0xACAD40", VA = "0x180ACBB40")]
	public static List<int> GetRateRentalDeckIDs(int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006783")]
	[Address(RVA = "0xACBDD0", Offset = "0xACAFD0", VA = "0x180ACBDD0")]
	private static List<int> GetRateRentalDeckList(int id, DeckType type, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006784")]
	[Address(RVA = "0xACB640", Offset = "0xACA840", VA = "0x180ACB640")]
	private static List<int> GetRateRentalCardPremium(int id, DeckType type, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006785")]
	[Address(RVA = "0xACB420", Offset = "0xACA620", VA = "0x180ACB420")]
	public static List<CardBaseData> GetRateRentalCardBaseData(int id, DeckType type, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006786")]
	[Address(RVA = "0xACB950", Offset = "0xACAB50", VA = "0x180ACB950")]
	public static Dictionary<string, object> GetRateRentalDeckAccessory(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006787")]
	[Address(RVA = "0xACC5F0", Offset = "0xACB7F0", VA = "0x180ACC5F0")]
	private static Dictionary<string, object> GetRateRentalPickUpCardIDs(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006788")]
	[Address(RVA = "0xACC460", Offset = "0xACB660", VA = "0x180ACC460")]
	public static int[] GetRateRentalPickUpCardIDArray(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x6006789")]
	[Address(RVA = "0xACC3B0", Offset = "0xACB5B0", VA = "0x180ACC3B0")]
	private static Dictionary<string, object> GetRateRentalPickUpCardDecorations(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x600678A")]
	[Address(RVA = "0xACC220", Offset = "0xACB420", VA = "0x180ACC220")]
	public static int[] GetRateRentalPickUpCardDecorationArray(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x600678B")]
	[Address(RVA = "0xACC6A0", Offset = "0xACB8A0", VA = "0x180ACC6A0")]
	public static Dictionary<string, object> GetRateRentalPickUps(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x600678C")]
	[Address(RVA = "0xACC0E0", Offset = "0xACB2E0", VA = "0x180ACC0E0")]
	public static string GetRateRentalDeckName(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x600678D")]
	[Address(RVA = "0xACBA00", Offset = "0xACAC00", VA = "0x180ACBA00")]
	public static string GetRateRentalDeckDesc(int id, int seasonID)
	{
		return null;
	}

	[Token(Token = "0x600678E")]
	[Address(RVA = "0xAC7D70", Offset = "0xAC6F70", VA = "0x180AC7D70")]
	public static string GetExhibitionNameByID(int id)
	{
		return null;
	}

	[Token(Token = "0x600678F")]
	[Address(RVA = "0xAC7A80", Offset = "0xAC6C80", VA = "0x180AC7A80")]
	public static List<int> GetExhibitionDeckList(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006790")]
	[Address(RVA = "0xAC73C0", Offset = "0xAC65C0", VA = "0x180AC73C0")]
	public static List<int> GetExhibitionCardPremium(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006791")]
	[Address(RVA = "0xAC71B0", Offset = "0xAC63B0", VA = "0x180AC71B0")]
	public static List<CardBaseData> GetExhibitionCardBaseData(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006792")]
	[Address(RVA = "0xAC76C0", Offset = "0xAC68C0", VA = "0x180AC76C0")]
	public static Dictionary<string, object> GetExhibitionDeckAccessory(int id)
	{
		return null;
	}

	[Token(Token = "0x6006793")]
	[Address(RVA = "0xAC7EA0", Offset = "0xAC70A0", VA = "0x180AC7EA0")]
	public static Dictionary<string, object> GetExhibitionPickUpCardIDs(int id)
	{
		return null;
	}

	[Token(Token = "0x6006794")]
	[Address(RVA = "0xAC7E10", Offset = "0xAC7010", VA = "0x180AC7E10")]
	public static Dictionary<string, object> GetExhibitionPickUpCardDecorations(int id)
	{
		return null;
	}

	[Token(Token = "0x6006795")]
	[Address(RVA = "0xAC7F30", Offset = "0xAC7130", VA = "0x180AC7F30")]
	public static Dictionary<string, object> GetExhibitionPickUps(int exhid)
	{
		return null;
	}

	[Token(Token = "0x6006796")]
	[Address(RVA = "0xAC7750", Offset = "0xAC6950", VA = "0x180AC7750")]
	public static Dictionary<int, string> GetExhibitionDeckIDAndName()
	{
		return null;
	}

	[Token(Token = "0x6006797")]
	[Address(RVA = "0xAC87F0", Offset = "0xAC79F0", VA = "0x180AC87F0")]
	public static List<int> GetExhibitionRentalDeckIDs(int exhid)
	{
		return null;
	}

	[Token(Token = "0x6006798")]
	[Address(RVA = "0xAC8A80", Offset = "0xAC7C80", VA = "0x180AC8A80")]
	private static List<int> GetExhibitionRentalDeckList(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x6006799")]
	[Address(RVA = "0xAC82F0", Offset = "0xAC74F0", VA = "0x180AC82F0")]
	private static List<int> GetExhibitionRentalCardPremium(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x600679A")]
	[Address(RVA = "0xAC80D0", Offset = "0xAC72D0", VA = "0x180AC80D0")]
	public static List<CardBaseData> GetExhibitionRentalCardBaseData(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x600679B")]
	[Address(RVA = "0xAC8600", Offset = "0xAC7800", VA = "0x180AC8600")]
	public static Dictionary<string, object> GetExhibitionRentalDeckAccessory(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x600679C")]
	[Address(RVA = "0xAC92A0", Offset = "0xAC84A0", VA = "0x180AC92A0")]
	private static Dictionary<string, object> GetExhibitionRentalPickUpCardIDs(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x600679D")]
	[Address(RVA = "0xAC9110", Offset = "0xAC8310", VA = "0x180AC9110")]
	public static int[] GetExhibitionRentalPickUpCardIDArray(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x600679E")]
	[Address(RVA = "0xAC9060", Offset = "0xAC8260", VA = "0x180AC9060")]
	private static Dictionary<string, object> GetExhibitionRentalPickUpCardDecorations(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x600679F")]
	[Address(RVA = "0xAC8ED0", Offset = "0xAC80D0", VA = "0x180AC8ED0")]
	public static int[] GetExhibitionRentalPickUpCardDecorationArray(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067A0")]
	[Address(RVA = "0xAC9350", Offset = "0xAC8550", VA = "0x180AC9350")]
	public static Dictionary<string, object> GetExhibitionRentalPickUps(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067A1")]
	[Address(RVA = "0xAC8D90", Offset = "0xAC7F90", VA = "0x180AC8D90")]
	public static string GetExhibitionRentalDeckName(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067A2")]
	[Address(RVA = "0xAC86B0", Offset = "0xAC78B0", VA = "0x180AC86B0")]
	public static string GetExhibitionRentalDeckDesc(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067A3")]
	[Address(RVA = "0xAC6440", Offset = "0xAC5640", VA = "0x180AC6440")]
	public static List<int> GetDuelTrialDeckIDs(int dtid)
	{
		return null;
	}

	[Token(Token = "0x60067A4")]
	[Address(RVA = "0xAC66D0", Offset = "0xAC58D0", VA = "0x180AC66D0")]
	private static List<int> GetDuelTrialDeckList(int dtid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067A5")]
	[Address(RVA = "0xAC5F40", Offset = "0xAC5140", VA = "0x180AC5F40")]
	private static List<int> GetDuelTrialCardPremium(int dtid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067A6")]
	[Address(RVA = "0xAC5D20", Offset = "0xAC4F20", VA = "0x180AC5D20")]
	public static List<CardBaseData> GetDuelTrialCardBaseData(int dtid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067A7")]
	[Address(RVA = "0xAC6250", Offset = "0xAC5450", VA = "0x180AC6250")]
	public static Dictionary<string, object> GetDuelTrialDeckAccessory(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067A8")]
	[Address(RVA = "0xAC6EF0", Offset = "0xAC60F0", VA = "0x180AC6EF0")]
	private static Dictionary<string, object> GetDuelTrialPickUpCardIDs(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067A9")]
	[Address(RVA = "0xAC6D60", Offset = "0xAC5F60", VA = "0x180AC6D60")]
	public static int[] GetDuelTrialPickUpCardIDArray(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067AA")]
	[Address(RVA = "0xAC6CB0", Offset = "0xAC5EB0", VA = "0x180AC6CB0")]
	private static Dictionary<string, object> GetDuelTrialPickUpCardDecorations(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067AB")]
	[Address(RVA = "0xAC6B20", Offset = "0xAC5D20", VA = "0x180AC6B20")]
	public static int[] GetDuelTrialPickUpCardDecorationArray(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067AC")]
	[Address(RVA = "0xAC6FA0", Offset = "0xAC61A0", VA = "0x180AC6FA0")]
	public static Dictionary<string, object> GetDuelTrialPickUps(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067AD")]
	[Address(RVA = "0xAC69E0", Offset = "0xAC5BE0", VA = "0x180AC69E0")]
	public static string GetDuelTrialDeckName(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067AE")]
	[Address(RVA = "0xAC6300", Offset = "0xAC5500", VA = "0x180AC6300")]
	public static string GetDuelTrialDeckDesc(int dtid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067AF")]
	[Address(RVA = "0xACEEB0", Offset = "0xACE0B0", VA = "0x180ACEEB0")]
	public static string GetVersusNameByID(int id)
	{
		return null;
	}

	[Token(Token = "0x60067B0")]
	[Address(RVA = "0xACEBC0", Offset = "0xACDDC0", VA = "0x180ACEBC0")]
	public static List<int> GetVersusDeckList(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067B1")]
	[Address(RVA = "0xACE830", Offset = "0xACDA30", VA = "0x180ACE830")]
	public static List<int> GetVersusCardPremium(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067B2")]
	[Address(RVA = "0xACE620", Offset = "0xACD820", VA = "0x180ACE620")]
	public static List<CardBaseData> GetVersusCardBaseData(int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067B3")]
	[Address(RVA = "0xACEB30", Offset = "0xACDD30", VA = "0x180ACEB30")]
	public static Dictionary<string, object> GetVersusDeckAccessory(int id)
	{
		return null;
	}

	[Token(Token = "0x60067B4")]
	[Address(RVA = "0xACEFE0", Offset = "0xACE1E0", VA = "0x180ACEFE0")]
	public static Dictionary<string, object> GetVersusPickUpCardIDs(int id)
	{
		return null;
	}

	[Token(Token = "0x60067B5")]
	[Address(RVA = "0xACEF50", Offset = "0xACE150", VA = "0x180ACEF50")]
	public static Dictionary<string, object> GetVersusPickUpCardDecorations(int id)
	{
		return null;
	}

	[Token(Token = "0x60067B6")]
	[Address(RVA = "0xACF070", Offset = "0xACE270", VA = "0x180ACF070")]
	public static Dictionary<string, object> GetVersusPickUps(int exhid)
	{
		return null;
	}

	[Token(Token = "0x60067B7")]
	[Address(RVA = "0xACF710", Offset = "0xACE910", VA = "0x180ACF710")]
	public static List<int> GetVersusRentalDeckIDs(int vid, int groupId)
	{
		return null;
	}

	[Token(Token = "0x60067B8")]
	[Address(RVA = "0xACF980", Offset = "0xACEB80", VA = "0x180ACF980")]
	private static List<int> GetVersusRentalDeckList(int vid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067B9")]
	[Address(RVA = "0xACF210", Offset = "0xACE410", VA = "0x180ACF210")]
	private static List<int> GetVersusRentalCardPremium(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067BA")]
	[Address(RVA = "0xACF520", Offset = "0xACE720", VA = "0x180ACF520")]
	public static Dictionary<string, object> GetVersusRentalDeckAccessory(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067BB")]
	[Address(RVA = "0xAD01A0", Offset = "0xACF3A0", VA = "0x180AD01A0")]
	private static Dictionary<string, object> GetVersusRentalPickUpCardIDs(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067BC")]
	[Address(RVA = "0xAD0010", Offset = "0xACF210", VA = "0x180AD0010")]
	public static int[] GetVersusRentalPickUpCardIDArray(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067BD")]
	[Address(RVA = "0xACFF60", Offset = "0xACF160", VA = "0x180ACFF60")]
	private static Dictionary<string, object> GetVersusRentalPickUpCardDecorations(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067BE")]
	[Address(RVA = "0xACFDD0", Offset = "0xACEFD0", VA = "0x180ACFDD0")]
	public static int[] GetVersusRentalPickUpCardDecorationArray(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067BF")]
	[Address(RVA = "0xACFC90", Offset = "0xACEE90", VA = "0x180ACFC90")]
	public static string GetVersusRentalDeckName(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067C0")]
	[Address(RVA = "0xACF5D0", Offset = "0xACE7D0", VA = "0x180ACF5D0")]
	public static string GetVersusRentalDeckDesc(int vid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067C1")]
	[Address(RVA = "0xAC4100", Offset = "0xAC3300", VA = "0x180AC4100")]
	public static List<int> GetDiceRallyRentalDeckIDs(int eventId)
	{
		return null;
	}

	[Token(Token = "0x60067C2")]
	[Address(RVA = "0xAC4390", Offset = "0xAC3590", VA = "0x180AC4390")]
	private static List<int> GetDiceRallyRentalDeckList(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067C3")]
	[Address(RVA = "0xAC3C00", Offset = "0xAC2E00", VA = "0x180AC3C00")]
	private static List<int> GetDiceRallyRentalCardPremium(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067C4")]
	[Address(RVA = "0xAC39E0", Offset = "0xAC2BE0", VA = "0x180AC39E0")]
	public static List<CardBaseData> GetDiceRallyRentalCardBaseData(int exhid, int id, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067C5")]
	[Address(RVA = "0xAC3F10", Offset = "0xAC3110", VA = "0x180AC3F10")]
	public static Dictionary<string, object> GetDiceRallyRentalDeckAccessory(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067C6")]
	[Address(RVA = "0xAC4BB0", Offset = "0xAC3DB0", VA = "0x180AC4BB0")]
	private static Dictionary<string, object> GetDiceRallyRentalPickUpCardIDs(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067C7")]
	[Address(RVA = "0xAC4A20", Offset = "0xAC3C20", VA = "0x180AC4A20")]
	public static int[] GetDiceRallyRentalPickUpCardIDArray(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067C8")]
	[Address(RVA = "0xAC4970", Offset = "0xAC3B70", VA = "0x180AC4970")]
	private static Dictionary<string, object> GetDiceRallyRentalPickUpCardDecorations(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067C9")]
	[Address(RVA = "0xAC47E0", Offset = "0xAC39E0", VA = "0x180AC47E0")]
	public static int[] GetDiceRallyRentalPickUpCardDecorationArray(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067CA")]
	[Address(RVA = "0xAC4C60", Offset = "0xAC3E60", VA = "0x180AC4C60")]
	public static Dictionary<string, object> GetDiceRallyRentalPickUps(int exhid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067CB")]
	[Address(RVA = "0xAC46A0", Offset = "0xAC38A0", VA = "0x180AC46A0")]
	public static string GetDiceRallyRentalDeckName(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067CC")]
	[Address(RVA = "0xAC3FC0", Offset = "0xAC31C0", VA = "0x180AC3FC0")]
	public static string GetDiceRallyRentalDeckDesc(int drid, int id)
	{
		return null;
	}

	[Token(Token = "0x60067CD")]
	[Address(RVA = "0xACE4B0", Offset = "0xACD6B0", VA = "0x180ACE4B0")]
	public static string GetReplayDeckName(long did)
	{
		return null;
	}

	[Token(Token = "0x60067CE")]
	[Address(RVA = "0xACE140", Offset = "0xACD340", VA = "0x180ACE140")]
	public static int GetReplayDeckCaseID(long did)
	{
		return default(int);
	}

	[Token(Token = "0x60067CF")]
	[Address(RVA = "0xACE1D0", Offset = "0xACD3D0", VA = "0x180ACE1D0")]
	public static List<object> GetReplayDeckList(long did, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067D0")]
	[Address(RVA = "0xACDE60", Offset = "0xACD060", VA = "0x180ACDE60")]
	public static List<object> GetReplayCardPremium(long did, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067D1")]
	[Address(RVA = "0xACDBC0", Offset = "0xACCDC0", VA = "0x180ACDBC0")]
	public static List<CardBaseData> GetReplayCardBaseData(int did, DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067D2")]
	[Address(RVA = "0xAC5740", Offset = "0xAC4940", VA = "0x180AC5740")]
	public static string GetDuelLiveDeckName()
	{
		return null;
	}

	[Token(Token = "0x60067D3")]
	[Address(RVA = "0xAC53F0", Offset = "0xAC45F0", VA = "0x180AC53F0")]
	public static int GetDuelLiveDeckCaseID()
	{
		return default(int);
	}

	[Token(Token = "0x60067D4")]
	[Address(RVA = "0xAC5450", Offset = "0xAC4650", VA = "0x180AC5450")]
	public static List<object> GetDuelLiveDeckList(DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067D5")]
	[Address(RVA = "0xAC5100", Offset = "0xAC4300", VA = "0x180AC5100")]
	public static List<object> GetDuelLiveCardPremium(DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067D6")]
	[Address(RVA = "0xAC4E70", Offset = "0xAC4070", VA = "0x180AC4E70")]
	public static List<CardBaseData> GetDuelLiveCardBaseData(DeckType type)
	{
		return null;
	}

	[Token(Token = "0x60067D7")]
	[Address(RVA = "0xAC5880", Offset = "0xAC4A80", VA = "0x180AC5880")]
	public static List<int> GetDuelLiveShareCardIDs()
	{
		return null;
	}

	[Token(Token = "0x60067D8")]
	[Address(RVA = "0xAC5AD0", Offset = "0xAC4CD0", VA = "0x180AC5AD0")]
	public static List<int> GetDuelLiveSharePremIDs()
	{
		return null;
	}

	[Token(Token = "0x60067D9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DeckInfo()
	{
	}
}
