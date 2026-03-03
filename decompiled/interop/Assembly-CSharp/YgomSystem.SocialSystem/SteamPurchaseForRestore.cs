using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using KonamiCommonIAB;

namespace YgomSystem.SocialSystem;

[Token(Token = "0x200032E")]
public class SteamPurchaseForRestore : Purchase
{
	[Token(Token = "0x17000206")]
	public override string productId
	{
		[Token(Token = "0x60013E0")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000207")]
	public long OrderID
	{
		[Token(Token = "0x60013E1")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x17000208")]
	public long TransationID
	{
		[Token(Token = "0x60013E2")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x60013DF")]
	[Address(RVA = "0x52B4D0", Offset = "0x52A6D0", VA = "0x18052B4D0")]
	public SteamPurchaseForRestore(long order_id, long transaction_id, string product_id)
	{
	}

	[Token(Token = "0x60013E3")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "6")]
	public override ProductInfo getProductInfo()
	{
		return null;
	}

	[Token(Token = "0x60013E4")]
	[Address(RVA = "0x52B530", Offset = "0x52A730", VA = "0x18052B530", Slot = "5")]
	public override string getReceipt()
	{
		return null;
	}
}
