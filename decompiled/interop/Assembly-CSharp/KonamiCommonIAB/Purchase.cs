using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x2000117")]
public abstract class Purchase
{
	[Token(Token = "0x1700008D")]
	public abstract string productId
	{
		[Token(Token = "0x60006F0")]
		get;
	}

	[Token(Token = "0x1700008E")]
	public string receipt
	{
		[Token(Token = "0x60006F1")]
		[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60006F2")]
	public abstract string getReceipt();

	[Token(Token = "0x60006F3")]
	public abstract ProductInfo getProductInfo();

	[Token(Token = "0x60006F4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	protected Purchase()
	{
	}
}
