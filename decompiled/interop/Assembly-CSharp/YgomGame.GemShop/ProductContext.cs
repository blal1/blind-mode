using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.GemShop;

[Token(Token = "0x2000DA2")]
public class ProductContext : IComparable<ProductContext>
{
	[Token(Token = "0x4009FA5")]
	[FieldOffset(Offset = "0x10")]
	private Dictionary<int, int> m_ItemNumMap;

	[Token(Token = "0x4009FA6")]
	[FieldOffset(Offset = "0x18")]
	public ProductStyle style;

	[Token(Token = "0x4009FA7")]
	[FieldOffset(Offset = "0x20")]
	public string productName;

	[Token(Token = "0x4009FA8")]
	[FieldOffset(Offset = "0x28")]
	public long endDateTs;

	[Token(Token = "0x4009FA9")]
	[FieldOffset(Offset = "0x30")]
	public string limitdate;

	[Token(Token = "0x4009FAA")]
	[FieldOffset(Offset = "0x38")]
	public long shopPaidId;

	[Token(Token = "0x4009FAB")]
	[FieldOffset(Offset = "0x40")]
	public int thumbId;

	[Token(Token = "0x4009FAC")]
	[FieldOffset(Offset = "0x48")]
	public string priceLabel;

	[Token(Token = "0x4009FAD")]
	[FieldOffset(Offset = "0x50")]
	public string doubleNotationPriceLabel;

	[Token(Token = "0x4009FAE")]
	[FieldOffset(Offset = "0x58")]
	public string limitBuyLabel;

	[Token(Token = "0x4009FAF")]
	[FieldOffset(Offset = "0x60")]
	public int order;

	[Token(Token = "0x4009FB0")]
	[FieldOffset(Offset = "0x64")]
	public bool soldout;

	[Token(Token = "0x4009FB1")]
	[FieldOffset(Offset = "0x68")]
	public string popIconLabel;

	[Token(Token = "0x17000BDC")]
	public bool isLimitedDate
	{
		[Token(Token = "0x60051EA")]
		[Address(RVA = "0x994E80", Offset = "0x994080", VA = "0x180994E80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000BDD")]
	public bool isInTermDate
	{
		[Token(Token = "0x60051EB")]
		[Address(RVA = "0x994E20", Offset = "0x994020", VA = "0x180994E20")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60051EC")]
	[Address(RVA = "0x994D20", Offset = "0x993F20", VA = "0x180994D20")]
	public void SetItemNum(int itemId, int num)
	{
	}

	[Token(Token = "0x60051ED")]
	[Address(RVA = "0x994C90", Offset = "0x993E90", VA = "0x180994C90")]
	public int GetItemNum(int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x60051EE")]
	[Address(RVA = "0x994C00", Offset = "0x993E00", VA = "0x180994C00")]
	public int Compare(ProductContext a, ProductContext b)
	{
		return default(int);
	}

	[Token(Token = "0x60051EF")]
	[Address(RVA = "0x994B70", Offset = "0x993D70", VA = "0x180994B70", Slot = "4")]
	public int CompareTo(ProductContext other)
	{
		return default(int);
	}

	[Token(Token = "0x60051F0")]
	[Address(RVA = "0x994D90", Offset = "0x993F90", VA = "0x180994D90")]
	public ProductContext()
	{
	}
}
