using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Deck;

[Token(Token = "0x2001090")]
public static class CardData
{
	[Token(Token = "0x2001091")]
	public enum INFOKIND
	{
		[Token(Token = "0x400B043")]
		Monster,
		[Token(Token = "0x400B044")]
		Spell,
		[Token(Token = "0x400B045")]
		Trap,
		[Token(Token = "0x400B046")]
		ExMon,
		[Token(Token = "0x400B047")]
		Error
	}

	[Token(Token = "0x400B03E")]
	[FieldOffset(Offset = "0x0")]
	private static int refCount;

	[Token(Token = "0x400B03F")]
	[FieldOffset(Offset = "0x4")]
	private static bool created;

	[Token(Token = "0x400B040")]
	[FieldOffset(Offset = "0x8")]
	private static List<int> allCardList;

	[Token(Token = "0x400B041")]
	[FieldOffset(Offset = "0x10")]
	private static bool allCardListReq;

	[Token(Token = "0x17001018")]
	public static bool IsValid
	{
		[Token(Token = "0x600659B")]
		[Address(RVA = "0xAB50A0", Offset = "0xAB42A0", VA = "0x180AB50A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001019")]
	public static bool IsReady
	{
		[Token(Token = "0x600659E")]
		[Address(RVA = "0xAB5060", Offset = "0xAB4260", VA = "0x180AB5060")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600659C")]
	[Address(RVA = "0xAB4190", Offset = "0xAB3390", VA = "0x180AB4190")]
	public static void AddRef()
	{
	}

	[Token(Token = "0x600659D")]
	[Address(RVA = "0xAB4FC0", Offset = "0xAB41C0", VA = "0x180AB4FC0")]
	public static void Release()
	{
	}

	[Token(Token = "0x600659F")]
	[Address(RVA = "0xAB4450", Offset = "0xAB3650", VA = "0x180AB4450")]
	public static Content.Frame GetFrame(int mrk)
	{
		return default(Content.Frame);
	}

	[Token(Token = "0x60065A0")]
	[Address(RVA = "0xAB4370", Offset = "0xAB3570", VA = "0x180AB4370")]
	public static Content.Attribute GetAttr(int mrk)
	{
		return default(Content.Attribute);
	}

	[Token(Token = "0x60065A1")]
	[Address(RVA = "0xAB4990", Offset = "0xAB3B90", VA = "0x180AB4990")]
	public static Content.Type GetType(int mrk)
	{
		return default(Content.Type);
	}

	[Token(Token = "0x60065A2")]
	[Address(RVA = "0xAB48B0", Offset = "0xAB3AB0", VA = "0x180AB48B0")]
	public static int GetStar(int mrk)
	{
		return default(int);
	}

	[Token(Token = "0x60065A3")]
	[Address(RVA = "0xAB4530", Offset = "0xAB3730", VA = "0x180AB4530")]
	public static Content.Icon GetIcon(int mrk)
	{
		return default(Content.Icon);
	}

	[Token(Token = "0x60065A4")]
	[Address(RVA = "0xAB47D0", Offset = "0xAB39D0", VA = "0x180AB47D0")]
	public static int GetOriginalID2(int mrk)
	{
		return default(int);
	}

	[Token(Token = "0x60065A5")]
	[Address(RVA = "0xAB4BE0", Offset = "0xAB3DE0", VA = "0x180AB4BE0")]
	public static bool IsMainDeck(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60065A6")]
	[Address(RVA = "0xAB4CA0", Offset = "0xAB3EA0", VA = "0x180AB4CA0")]
	public static bool IsMainDeck(Content.Frame f, int mrk = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x60065A7")]
	[Address(RVA = "0xAB4D50", Offset = "0xAB3F50", VA = "0x180AB4D50")]
	public static bool IsMonster(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60065A8")]
	[Address(RVA = "0xAB4E10", Offset = "0xAB4010", VA = "0x180AB4E10")]
	public static bool IsMonster(Content.Frame f, int mrk = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x60065A9")]
	[Address(RVA = "0xAB4B20", Offset = "0xAB3D20", VA = "0x180AB4B20")]
	public static bool HasLevel(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60065AA")]
	[Address(RVA = "0xAB4A70", Offset = "0xAB3C70", VA = "0x180AB4A70")]
	public static bool HasLevel(Content.Frame f, int mrk = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x60065AB")]
	[Address(RVA = "0xAB4EC0", Offset = "0xAB40C0", VA = "0x180AB4EC0")]
	public static bool IsValidCard(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x60065AC")]
	[Address(RVA = "0xAB46F0", Offset = "0xAB38F0", VA = "0x180AB46F0")]
	public static INFOKIND GetInfoKind(int mrk)
	{
		return default(INFOKIND);
	}

	[Token(Token = "0x60065AD")]
	[Address(RVA = "0xAB4610", Offset = "0xAB3810", VA = "0x180AB4610")]
	public static INFOKIND GetInfoKind(Content.Frame f, int mrk = -1)
	{
		return default(INFOKIND);
	}

	[Token(Token = "0x60065AE")]
	[Address(RVA = "0xAB4270", Offset = "0xAB3470", VA = "0x180AB4270")]
	public static List<int> GetAllCardList()
	{
		return null;
	}
}
