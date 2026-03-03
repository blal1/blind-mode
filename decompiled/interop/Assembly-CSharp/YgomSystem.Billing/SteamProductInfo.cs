using Il2CppDummyDll;
using KonamiCommonIAB;

namespace YgomSystem.Billing;

[Token(Token = "0x200034F")]
public class SteamProductInfo : ProductInfo
{
	[Token(Token = "0x40011C6")]
	[FieldOffset(Offset = "0x10")]
	private string m_productId;

	[Token(Token = "0x40011C7")]
	[FieldOffset(Offset = "0x18")]
	private float m_price;

	[Token(Token = "0x40011C8")]
	[FieldOffset(Offset = "0x20")]
	private string m_currency;

	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x28")]
	private string m_displayedPrice;

	[Token(Token = "0x1700021F")]
	public override string productId
	{
		[Token(Token = "0x60014AC")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000220")]
	public override string title
	{
		[Token(Token = "0x60014AD")]
		[Address(RVA = "0x52B4A0", Offset = "0x52A6A0", VA = "0x18052B4A0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000221")]
	public override string description
	{
		[Token(Token = "0x60014AE")]
		[Address(RVA = "0x52B460", Offset = "0x52A660", VA = "0x18052B460", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000222")]
	public override string displayedPrice
	{
		[Token(Token = "0x60014AF")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000223")]
	public override string currency
	{
		[Token(Token = "0x60014B0")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000224")]
	public override float price
	{
		[Token(Token = "0x60014B1")]
		[Address(RVA = "0x52B490", Offset = "0x52A690", VA = "0x18052B490", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x60014B2")]
	[Address(RVA = "0x52B3E0", Offset = "0x52A5E0", VA = "0x18052B3E0")]
	public SteamProductInfo(string _productId, float _price = 0f, string _displayedPrice = "", string _currency = "")
	{
	}
}
