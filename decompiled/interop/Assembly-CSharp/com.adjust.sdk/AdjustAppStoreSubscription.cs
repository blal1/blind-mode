using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DD8")]
public class AdjustAppStoreSubscription
{
	[Token(Token = "0x4010594")]
	[FieldOffset(Offset = "0x10")]
	internal string price;

	[Token(Token = "0x4010595")]
	[FieldOffset(Offset = "0x18")]
	internal string currency;

	[Token(Token = "0x4010596")]
	[FieldOffset(Offset = "0x20")]
	internal string transactionId;

	[Token(Token = "0x4010597")]
	[FieldOffset(Offset = "0x28")]
	internal string receipt;

	[Token(Token = "0x4010598")]
	[FieldOffset(Offset = "0x30")]
	internal string billingStore;

	[Token(Token = "0x4010599")]
	[FieldOffset(Offset = "0x38")]
	internal string transactionDate;

	[Token(Token = "0x401059A")]
	[FieldOffset(Offset = "0x40")]
	internal string salesRegion;

	[Token(Token = "0x401059B")]
	[FieldOffset(Offset = "0x48")]
	internal List<string> partnerList;

	[Token(Token = "0x401059C")]
	[FieldOffset(Offset = "0x50")]
	internal List<string> callbackList;

	[Token(Token = "0x600BF2F")]
	[Address(RVA = "0x5955C0", Offset = "0x5947C0", VA = "0x1805955C0")]
	public AdjustAppStoreSubscription(string price, string currency, string transactionId, string receipt)
	{
	}

	[Token(Token = "0x600BF30")]
	[Address(RVA = "0x595520", Offset = "0x594720", VA = "0x180595520")]
	public void setTransactionDate(string transactionDate)
	{
	}

	[Token(Token = "0x600BF31")]
	[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
	public void setSalesRegion(string salesRegion)
	{
	}

	[Token(Token = "0x600BF32")]
	[Address(RVA = "0x595640", Offset = "0x594840", VA = "0x180595640")]
	public void addCallbackParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BF33")]
	[Address(RVA = "0x5957C0", Offset = "0x5949C0", VA = "0x1805957C0")]
	public void addPartnerParameter(string key, string value)
	{
	}
}
