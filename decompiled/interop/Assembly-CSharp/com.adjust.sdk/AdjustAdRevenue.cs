using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DD7")]
public class AdjustAdRevenue
{
	[Token(Token = "0x401058B")]
	[FieldOffset(Offset = "0x10")]
	internal string source;

	[Token(Token = "0x401058C")]
	[FieldOffset(Offset = "0x18")]
	internal double? revenue;

	[Token(Token = "0x401058D")]
	[FieldOffset(Offset = "0x28")]
	internal string currency;

	[Token(Token = "0x401058E")]
	[FieldOffset(Offset = "0x30")]
	internal int? adImpressionsCount;

	[Token(Token = "0x401058F")]
	[FieldOffset(Offset = "0x38")]
	internal string adRevenueNetwork;

	[Token(Token = "0x4010590")]
	[FieldOffset(Offset = "0x40")]
	internal string adRevenueUnit;

	[Token(Token = "0x4010591")]
	[FieldOffset(Offset = "0x48")]
	internal string adRevenuePlacement;

	[Token(Token = "0x4010592")]
	[FieldOffset(Offset = "0x50")]
	internal List<string> partnerList;

	[Token(Token = "0x4010593")]
	[FieldOffset(Offset = "0x58")]
	internal List<string> callbackList;

	[Token(Token = "0x600BF27")]
	[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
	public AdjustAdRevenue(string source)
	{
	}

	[Token(Token = "0x600BF28")]
	[Address(RVA = "0x595540", Offset = "0x594740", VA = "0x180595540")]
	public void setRevenue(double amount, string currency)
	{
	}

	[Token(Token = "0x600BF29")]
	[Address(RVA = "0x5954C0", Offset = "0x5946C0", VA = "0x1805954C0")]
	public void setAdImpressionsCount(int adImpressionsCount)
	{
	}

	[Token(Token = "0x600BF2A")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
	public void setAdRevenueNetwork(string adRevenueNetwork)
	{
	}

	[Token(Token = "0x600BF2B")]
	[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
	public void setAdRevenueUnit(string adRevenueUnit)
	{
	}

	[Token(Token = "0x600BF2C")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void setAdRevenuePlacement(string adRevenuePlacement)
	{
	}

	[Token(Token = "0x600BF2D")]
	[Address(RVA = "0x5951C0", Offset = "0x5943C0", VA = "0x1805951C0")]
	public void addCallbackParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BF2E")]
	[Address(RVA = "0x595340", Offset = "0x594540", VA = "0x180595340")]
	public void addPartnerParameter(string key, string value)
	{
	}
}
