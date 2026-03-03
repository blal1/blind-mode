using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Menu;

namespace YgomGame.CardFile;

[Token(Token = "0x20015B2")]
public class CardFileInfo
{
	[Token(Token = "0x400CE72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public int cardFileID;

	[Token(Token = "0x400CE73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
	public int cardFileItemID;

	[Token(Token = "0x400CE74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public int possessingCardNum;

	[Token(Token = "0x400CE75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
	public int completeStatus;

	[Token(Token = "0x400CE76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public int playCompleteEffect;

	[Token(Token = "0x400CE77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	public int exchangeFlag;

	[Token(Token = "0x400CE78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public int updateContent;

	[Token(Token = "0x400CE79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	public int sortType;

	[Token(Token = "0x170014A8")]
	public Dictionary<int, PageInfo> pages
	{
		[Token(Token = "0x6008672")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008673")]
		[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x170014A9")]
	public int totalCardNum
	{
		[Token(Token = "0x6008675")]
		[Address(RVA = "0xCED670", Offset = "0xCEC870", VA = "0x180CED670")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008674")]
	[Address(RVA = "0xCED680", Offset = "0xCEC880", VA = "0x180CED680")]
	public int totalPageNum()
	{
		return default(int);
	}

	[Token(Token = "0x6008676")]
	[Address(RVA = "0xCEBAD0", Offset = "0xCEACD0", VA = "0x180CEBAD0")]
	public CardInfo GetCardInfo(int page, int index)
	{
		return null;
	}

	[Token(Token = "0x6008677")]
	[Address(RVA = "0xCEBB00", Offset = "0xCEAD00", VA = "0x180CEBB00")]
	public PageInfo GetPageInfo(int page)
	{
		return null;
	}

	[Token(Token = "0x6008678")]
	[Address(RVA = "0xCEC080", Offset = "0xCEB280", VA = "0x180CEC080")]
	public bool GotNewCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6008679")]
	[Address(RVA = "0xCEBE70", Offset = "0xCEB070", VA = "0x180CEBE70")]
	public int GotNewCardPage()
	{
		return default(int);
	}

	[Token(Token = "0x600867A")]
	[Address(RVA = "0xCEB9A0", Offset = "0xCEABA0", VA = "0x180CEB9A0")]
	public void FlushNewFlags()
	{
	}

	[Token(Token = "0x600867B")]
	[Address(RVA = "0xCEB4D0", Offset = "0xCEA6D0", VA = "0x180CEB4D0")]
	public void AddCardInfo(int page, int cardPos, CardInfo cardInfo)
	{
	}

	[Token(Token = "0x600867C")]
	[Address(RVA = "0xCEBCE0", Offset = "0xCEAEE0", VA = "0x180CEBCE0")]
	private int GetTotalCardNum()
	{
		return default(int);
	}

	[Token(Token = "0x600867D")]
	[Address(RVA = "0xCEBB90", Offset = "0xCEAD90", VA = "0x180CEBB90")]
	private int GetRequiredPremiumType(CardFileDefinition.PremiumType requiredPremium, Dictionary<int, int> premiums)
	{
		return default(int);
	}

	[Token(Token = "0x600867E")]
	[Address(RVA = "0xCEB6C0", Offset = "0xCEA8C0", VA = "0x180CEB6C0")]
	public void CraftedCardInfo(int mrk, Dictionary<int, int> premiums)
	{
	}

	[Token(Token = "0x600867F")]
	[Address(RVA = "0xCEC300", Offset = "0xCEB500", VA = "0x180CEC300")]
	public void Sort(SortComparer.Sorter? targetSorter, [Optional] Action<List<(int, int, CardInfo)>, Dictionary<string, object>> onFinish)
	{
	}

	[Token(Token = "0x6008680")]
	[Address(RVA = "0xCED5F0", Offset = "0xCEC7F0", VA = "0x180CED5F0")]
	public CardFileInfo()
	{
	}
}
