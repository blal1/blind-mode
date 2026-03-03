using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200011E")]
internal class WindowsShiftProductInfo : ProductInfo
{
	[Token(Token = "0x40006BA")]
	[FieldOffset(Offset = "0x10")]
	private string _productId;

	[Token(Token = "0x40006BB")]
	[FieldOffset(Offset = "0x18")]
	private string _title;

	[Token(Token = "0x40006BC")]
	[FieldOffset(Offset = "0x20")]
	private long _price;

	[Token(Token = "0x17000099")]
	public override string productId
	{
		[Token(Token = "0x6000710")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009A")]
	public override string title
	{
		[Token(Token = "0x6000711")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	public override string description
	{
		[Token(Token = "0x6000712")]
		[Address(RVA = "0x9E95A0", Offset = "0x9E87A0", VA = "0x1809E95A0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009C")]
	public override string displayedPrice
	{
		[Token(Token = "0x6000713")]
		[Address(RVA = "0x9E95D0", Offset = "0x9E87D0", VA = "0x1809E95D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009D")]
	public override string currency
	{
		[Token(Token = "0x6000714")]
		[Address(RVA = "0x9E9570", Offset = "0x9E8770", VA = "0x1809E9570", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009E")]
	public override float price
	{
		[Token(Token = "0x6000715")]
		[Address(RVA = "0x9E9620", Offset = "0x9E8820", VA = "0x1809E9620", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600070F")]
	[Address(RVA = "0x9E9510", Offset = "0x9E8710", VA = "0x1809E9510")]
	public WindowsShiftProductInfo(string prodId, string title, long price)
	{
	}
}
