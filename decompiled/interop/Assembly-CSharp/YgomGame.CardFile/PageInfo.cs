using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.CardFile;

[Token(Token = "0x20015B4")]
public class PageInfo
{
	[Token(Token = "0x400CE7C")]
	[FieldOffset(Offset = "0x10")]
	public Dictionary<int, CardInfo> cards;

	[Token(Token = "0x170014AA")]
	public int totalCardNum
	{
		[Token(Token = "0x6008683")]
		[Address(RVA = "0xCFA1C0", Offset = "0xCF93C0", VA = "0x180CFA1C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x6008684")]
	[Address(RVA = "0xCF9F70", Offset = "0xCF9170", VA = "0x180CF9F70")]
	public CardInfo GetCardInfo(int index)
	{
		return null;
	}

	[Token(Token = "0x6008685")]
	[Address(RVA = "0xCFA000", Offset = "0xCF9200", VA = "0x180CFA000")]
	public bool IncludeNewCard()
	{
		return default(bool);
	}

	[Token(Token = "0x6008686")]
	[Address(RVA = "0xCF9E40", Offset = "0xCF9040", VA = "0x180CF9E40")]
	public void FlushFlags()
	{
	}

	[Token(Token = "0x6008687")]
	[Address(RVA = "0xCF9D90", Offset = "0xCF8F90", VA = "0x180CF9D90")]
	public void AddCardInfo(int cardPos, CardInfo cardInfo)
	{
	}

	[Token(Token = "0x6008688")]
	[Address(RVA = "0xCFA140", Offset = "0xCF9340", VA = "0x180CFA140")]
	public PageInfo()
	{
	}
}
