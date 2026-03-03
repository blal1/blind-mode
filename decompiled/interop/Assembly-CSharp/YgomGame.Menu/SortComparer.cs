using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Card;
using YgomGame.Deck;

namespace YgomGame.Menu;

[Token(Token = "0x200117A")]
public class SortComparer
{
	[Token(Token = "0x200117B")]
	public enum METHOD
	{
		[Token(Token = "0x400B78B")]
		Default,
		[Token(Token = "0x400B78C")]
		Obtained,
		[Token(Token = "0x400B78D")]
		Inventory,
		[Token(Token = "0x400B78E")]
		Rarity,
		[Token(Token = "0x400B78F")]
		StarsAndLink,
		[Token(Token = "0x400B790")]
		Atk,
		[Token(Token = "0x400B791")]
		Def,
		[Token(Token = "0x400B792")]
		Name,
		[Token(Token = "0x400B793")]
		Premium,
		[Token(Token = "0x400B794")]
		Shop,
		[Token(Token = "0x400B795")]
		CardPack,
		[Token(Token = "0x400B796")]
		None
	}

	[Token(Token = "0x200117C")]
	public enum ORDER
	{
		[Token(Token = "0x400B798")]
		Asc,
		[Token(Token = "0x400B799")]
		Desc
	}

	[Token(Token = "0x200117D")]
	public struct Sorter
	{
		[Token(Token = "0x400B79A")]
		[FieldOffset(Offset = "0x0")]
		public METHOD Method;

		[Token(Token = "0x400B79B")]
		[FieldOffset(Offset = "0x4")]
		public ORDER Order;

		[Token(Token = "0x6006DB2")]
		[Address(RVA = "0xB684C0", Offset = "0xB676C0", VA = "0x180B684C0")]
		public Sorter(METHOD m, ORDER o)
		{
		}
	}

	[Token(Token = "0x400B765")]
	private const int MAX_DEF = 9999999;

	[Token(Token = "0x400B766")]
	private const int MAX_ATK = 9999999;

	[Token(Token = "0x400B767")]
	private const int MAX_STAR = 9999999;

	[Token(Token = "0x400B768")]
	[FieldOffset(Offset = "0x10")]
	private Sorter sorter;

	[Token(Token = "0x400B769")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<METHOD, Func<int, int, ORDER, int>> comparers;

	[Token(Token = "0x400B76A")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<METHOD, Func<CardBaseData, CardBaseData, ORDER, int>> comparers2;

	[Token(Token = "0x400B76B")]
	private const int FRAMESORTORDER_RITUAL = 30;

	[Token(Token = "0x400B76C")]
	private const int FRAMESORTORDER_RITUALPEND = 31;

	[Token(Token = "0x400B76D")]
	private const int FRAMESORTORDER_EFFECT = 20;

	[Token(Token = "0x400B76E")]
	private const int FRAMESORTORDER_PENDFX = 21;

	[Token(Token = "0x400B76F")]
	private const int FRAMESORTORDER_NORMAL = 10;

	[Token(Token = "0x400B770")]
	private const int FRAMESORTORDER_PEND = 11;

	[Token(Token = "0x400B771")]
	private const int FRAMESORTORDER_FUSION = 100;

	[Token(Token = "0x400B772")]
	private const int FRAMESORTORDER_FUSIONPEND = 110;

	[Token(Token = "0x400B773")]
	private const int FRAMESORTORDER_SYNC = 120;

	[Token(Token = "0x400B774")]
	private const int FRAMESORTORDER_DSYNC = 130;

	[Token(Token = "0x400B775")]
	private const int FRAMESORTORDER_SYNCPEND = 140;

	[Token(Token = "0x400B776")]
	private const int FRAMESORTORDER_XYZ = 150;

	[Token(Token = "0x400B777")]
	private const int FRAMESORTORDER_XYZPEND = 160;

	[Token(Token = "0x400B778")]
	private const int FRAMESORTORDER_LINK = 170;

	[Token(Token = "0x400B779")]
	private const int FRAMESORTORDER_MAGIC = 200;

	[Token(Token = "0x400B77A")]
	private const int FRAMESORTORDER_TRAP = 210;

	[Token(Token = "0x400B77B")]
	private const int FRAMESORTORDER_TOKEN = 220;

	[Token(Token = "0x400B77C")]
	private const int FRAMESORTORDER_RA = 230;

	[Token(Token = "0x400B77D")]
	private const int FRAMESORTORDER_OSIRIS = 240;

	[Token(Token = "0x400B77E")]
	private const int FRAMESORTORDER_OBERISK = 250;

	[Token(Token = "0x400B77F")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<Content.Frame, int> frameOrder;

	[Token(Token = "0x400B780")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<Content.Frame, int> shopFrameOrder;

	[Token(Token = "0x400B781")]
	private const int ICONSORTORDER_NONE = 1;

	[Token(Token = "0x400B782")]
	private const int ICONSORTORDER_COUNTER = 2;

	[Token(Token = "0x400B783")]
	private const int ICONSORTORDER_FIELD = 4;

	[Token(Token = "0x400B784")]
	private const int ICONSORTORDER_EQUIP = 3;

	[Token(Token = "0x400B785")]
	private const int ICONSORTORDER_CONTINUOUS = 6;

	[Token(Token = "0x400B786")]
	private const int ICONSORTORDER_QUICKPLAY = 7;

	[Token(Token = "0x400B787")]
	private const int ICONSORTORDER_RITUAL = 5;

	[Token(Token = "0x400B788")]
	private const int ICONSORTORDER_RITUAL_R = 8;

	[Token(Token = "0x400B789")]
	[FieldOffset(Offset = "0x20")]
	private static Dictionary<Content.Icon, int> iconOrder;

	[Token(Token = "0x17001149")]
	private static Content m_cci
	{
		[Token(Token = "0x6006D83")]
		[Address(RVA = "0xB561B0", Offset = "0xB553B0", VA = "0x180B561B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006D84")]
	[Address(RVA = "0xB55E00", Offset = "0xB55000", VA = "0x180B55E00")]
	public SortComparer(Sorter s)
	{
	}

	[Token(Token = "0x6006D85")]
	[Address(RVA = "0xB52760", Offset = "0xB51960", VA = "0x180B52760")]
	public int Compare(int a, int b)
	{
		return default(int);
	}

	[Token(Token = "0x6006D86")]
	[Address(RVA = "0xB52870", Offset = "0xB51A70", VA = "0x180B52870")]
	public int Compare(CardBaseData a, CardBaseData b)
	{
		return default(int);
	}

	[Token(Token = "0x6006D87")]
	[Address(RVA = "0xB529D0", Offset = "0xB51BD0", VA = "0x180B529D0")]
	public static int Compare(int a, int b, Sorter sorter)
	{
		return default(int);
	}

	[Token(Token = "0x6006D88")]
	[Address(RVA = "0xB52AA0", Offset = "0xB51CA0", VA = "0x180B52AA0")]
	public static int Compare(CardBaseData a, CardBaseData b, Sorter sorter)
	{
		return default(int);
	}

	[Token(Token = "0x6006D89")]
	[Address(RVA = "0xB56380", Offset = "0xB55580", VA = "0x180B56380")]
	public static bool isDesc(ORDER o)
	{
		return default(bool);
	}

	[Token(Token = "0x6006D8A")]
	[Address(RVA = "0xB53990", Offset = "0xB52B90", VA = "0x180B53990")]
	private static int GetShopFrameOrder(Content.Frame frame)
	{
		return default(int);
	}

	[Token(Token = "0x6006D8B")]
	[Address(RVA = "0xB53680", Offset = "0xB52880", VA = "0x180B53680")]
	private static int DefaultComparer(int a, int b, ORDER o = ORDER.Desc)
	{
		return default(int);
	}

	[Token(Token = "0x6006D8C")]
	[Address(RVA = "0xB53200", Offset = "0xB52400", VA = "0x180B53200")]
	private static int DefaultComparer(CardBaseData a, CardBaseData b, ORDER o = ORDER.Desc)
	{
		return default(int);
	}

	[Token(Token = "0x6006D8D")]
	[Address(RVA = "0xB54070", Offset = "0xB53270", VA = "0x180B54070")]
	private static int ObtainedDateComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D8E")]
	[Address(RVA = "0xB541C0", Offset = "0xB533C0", VA = "0x180B541C0")]
	private static int ObtainedDateComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D8F")]
	[Address(RVA = "0xB53B00", Offset = "0xB52D00", VA = "0x180B53B00")]
	private static int InventoryComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D90")]
	[Address(RVA = "0xB53A60", Offset = "0xB52C60", VA = "0x180B53A60")]
	private static int InventoryComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D91")]
	[Address(RVA = "0xB54420", Offset = "0xB53620", VA = "0x180B54420")]
	private static int RarityComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D92")]
	[Address(RVA = "0xB54580", Offset = "0xB53780", VA = "0x180B54580")]
	private static int RarityComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D93")]
	[Address(RVA = "0xB54F70", Offset = "0xB54170", VA = "0x180B54F70")]
	private static int StarsComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D94")]
	[Address(RVA = "0xB54E60", Offset = "0xB54060", VA = "0x180B54E60")]
	private static int StarsComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D95")]
	[Address(RVA = "0xB523D0", Offset = "0xB515D0", VA = "0x180B523D0")]
	private static int AtkComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D96")]
	[Address(RVA = "0xB51EE0", Offset = "0xB510E0", VA = "0x180B51EE0")]
	private static int AtkComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D97")]
	[Address(RVA = "0xB52BD0", Offset = "0xB51DD0", VA = "0x180B52BD0")]
	private static int DefComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D98")]
	[Address(RVA = "0xB52CA0", Offset = "0xB51EA0", VA = "0x180B52CA0")]
	private static int DefComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D99")]
	[Address(RVA = "0xB53C50", Offset = "0xB52E50", VA = "0x180B53C50")]
	private static int NameComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D9A")]
	[Address(RVA = "0xB53EA0", Offset = "0xB530A0", VA = "0x180B53EA0")]
	private static int NameComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D9B")]
	[Address(RVA = "0xB54300", Offset = "0xB53500", VA = "0x180B54300")]
	private static int PremiumComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D9C")]
	[Address(RVA = "0xB54260", Offset = "0xB53460", VA = "0x180B54260")]
	private static int PremiumComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D9D")]
	[Address(RVA = "0xB524A0", Offset = "0xB516A0", VA = "0x180B524A0")]
	private static int CardPackComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006D9E")]
	[Address(RVA = "0xB52520", Offset = "0xB51720", VA = "0x180B52520")]
	private static int CardPackComparer(int a, int b)
	{
		return default(int);
	}

	[Token(Token = "0x6006D9F")]
	[Address(RVA = "0xB54640", Offset = "0xB53840", VA = "0x180B54640")]
	private static int ShopComparer(CardBaseData a, CardBaseData b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA0")]
	[Address(RVA = "0xB54A50", Offset = "0xB53C50", VA = "0x180B54A50")]
	private static int ShopComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA1")]
	[Address(RVA = "0xB55F10", Offset = "0xB55110", VA = "0x180B55F10")]
	private static int baseComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA2")]
	[Address(RVA = "0xB560E0", Offset = "0xB552E0", VA = "0x180B560E0")]
	private static int frameComparer(Content.Frame fa, Content.Frame fb, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA3")]
	[Address(RVA = "0xB567D0", Offset = "0xB559D0", VA = "0x180B567D0")]
	private static int shopFrameComparer(Content.Frame fa, Content.Frame fb, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA4")]
	[Address(RVA = "0xB56240", Offset = "0xB55440", VA = "0x180B56240")]
	private static int iconComparer(Content.Icon ia, Content.Icon ib, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA5")]
	[Address(RVA = "0xB56580", Offset = "0xB55780", VA = "0x180B56580")]
	private static int obtainedDateComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA6")]
	[Address(RVA = "0xB568A0", Offset = "0xB55AA0", VA = "0x180B568A0")]
	private static int starComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA7")]
	[Address(RVA = "0xB56390", Offset = "0xB55590", VA = "0x180B56390")]
	private static int linkComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA8")]
	[Address(RVA = "0xB56310", Offset = "0xB55510", VA = "0x180B56310")]
	private static int inventoryComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DA9")]
	[Address(RVA = "0xB566E0", Offset = "0xB558E0", VA = "0x180B566E0")]
	private static int rarityComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DAA")]
	[Address(RVA = "0xB55E30", Offset = "0xB55030", VA = "0x180B55E30")]
	private static int atkComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DAB")]
	[Address(RVA = "0xB56430", Offset = "0xB55630", VA = "0x180B56430")]
	private static int nameComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DAC")]
	[Address(RVA = "0xB55F80", Offset = "0xB55180", VA = "0x180B55F80")]
	private static int defComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DAD")]
	[Address(RVA = "0xB56670", Offset = "0xB55870", VA = "0x180B56670")]
	private static int premiumIDComparer(int a, int b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DAE")]
	[Address(RVA = "0xB565F0", Offset = "0xB557F0", VA = "0x180B565F0")]
	private static int ownedComparer(bool a, bool b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DAF")]
	[Address(RVA = "0xB56750", Offset = "0xB55950", VA = "0x180B56750")]
	private static int rentaledComparer(bool a, bool b, ORDER o)
	{
		return default(int);
	}

	[Token(Token = "0x6006DB0")]
	[Address(RVA = "0xB56940", Offset = "0xB55B40", VA = "0x180B56940")]
	private static int starsandlinkConverter(int a, ORDER o)
	{
		return default(int);
	}
}
