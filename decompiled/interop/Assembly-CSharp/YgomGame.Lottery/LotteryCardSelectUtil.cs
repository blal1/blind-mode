using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Card;
using YgomGame.Deck;
using YgomGame.Menu;

namespace YgomGame.Lottery;

[Token(Token = "0x20016F8")]
public static class LotteryCardSelectUtil
{
	[Token(Token = "0x20016F9")]
	public enum SelectorPriority
	{
		[Token(Token = "0x400D9B5")]
		DeckEditor,
		[Token(Token = "0x400D9B6")]
		ActionMenu,
		[Token(Token = "0x400D9B7")]
		CardDetail
	}

	[Token(Token = "0x400D9B1")]
	public const int PickupSlotMax = 3;

	[Token(Token = "0x400D9B3")]
	[FieldOffset(Offset = "0x4")]
	private static SortComparer.Sorter deckSorter;

	[Token(Token = "0x1700162E")]
	public static int selectorPriorityBase
	{
		[Token(Token = "0x6008FE0")]
		[Address(RVA = "0xD9A370", Offset = "0xD99570", VA = "0x180D9A370")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008FE1")]
		[Address(RVA = "0xD9A3C0", Offset = "0xD995C0", VA = "0x180D9A3C0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700162F")]
	public static CardCollectionInfo.Premium defaultPrem
	{
		[Token(Token = "0x6008FE6")]
		[Address(RVA = "0x4B8E10", Offset = "0x4B8010", VA = "0x1804B8E10")]
		get
		{
			return default(CardCollectionInfo.Premium);
		}
	}

	[Token(Token = "0x6008FE2")]
	[Address(RVA = "0xD9A080", Offset = "0xD99280", VA = "0x180D9A080")]
	public static int GetSelectorPriority(int priority)
	{
		return default(int);
	}

	[Token(Token = "0x6008FE3")]
	[Address(RVA = "0xD99FC0", Offset = "0xD991C0", VA = "0x180D99FC0")]
	public static int GetSelectorPriority(SelectorPriority priority)
	{
		return default(int);
	}

	[Token(Token = "0x6008FE4")]
	[Address(RVA = "0xD9A1F0", Offset = "0xD993F0", VA = "0x180D9A1F0")]
	public static void SortCardDataList(List<CardBaseData> list)
	{
	}

	[Token(Token = "0x6008FE5")]
	[Address(RVA = "0xD99F80", Offset = "0xD99180", VA = "0x180D99F80")]
	public static int GetRegulationID()
	{
		return default(int);
	}

	[Token(Token = "0x6008FE7")]
	[Address(RVA = "0xD9A110", Offset = "0xD99310", VA = "0x180D9A110")]
	public static void SetCardDataForPickupCard(DeckCard card, CardBaseData data)
	{
	}
}
