using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x2000116")]
public abstract class ProductInfo
{
	[Token(Token = "0x17000086")]
	public string json
	{
		[Token(Token = "0x60006E8")]
		[Address(RVA = "0x9E4590", Offset = "0x9E3790", VA = "0x1809E4590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000087")]
	public abstract string productId
	{
		[Token(Token = "0x60006E9")]
		get;
	}

	[Token(Token = "0x17000088")]
	public abstract string title
	{
		[Token(Token = "0x60006EA")]
		get;
	}

	[Token(Token = "0x17000089")]
	public abstract string description
	{
		[Token(Token = "0x60006EB")]
		get;
	}

	[Token(Token = "0x1700008A")]
	public abstract string displayedPrice
	{
		[Token(Token = "0x60006EC")]
		get;
	}

	[Token(Token = "0x1700008B")]
	public abstract string currency
	{
		[Token(Token = "0x60006ED")]
		get;
	}

	[Token(Token = "0x1700008C")]
	public abstract float price
	{
		[Token(Token = "0x60006EE")]
		get;
	}

	[Token(Token = "0x60006EF")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected ProductInfo()
	{
	}
}
