using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200011A")]
internal class iPhoneProductInfo : ProductInfo
{
	[Token(Token = "0x40006AD")]
	[FieldOffset(Offset = "0x10")]
	private SKProduct info;

	[Token(Token = "0x17000092")]
	public override string productId
	{
		[Token(Token = "0x6000701")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0", Slot = "4")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000093")]
	public override string title
	{
		[Token(Token = "0x6000702")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000094")]
	public override string description
	{
		[Token(Token = "0x6000703")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000095")]
	public override string displayedPrice
	{
		[Token(Token = "0x6000704")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000096")]
	public override string currency
	{
		[Token(Token = "0x6000705")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	public override float price
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x64BF80", Offset = "0x64B180", VA = "0x18064BF80", Slot = "9")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x6000700")]
	[Address(RVA = "0x9E9680", Offset = "0x9E8880", VA = "0x1809E9680")]
	public iPhoneProductInfo(SKProduct obj)
	{
	}

	[Token(Token = "0x6000707")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void print(string head)
	{
	}
}
