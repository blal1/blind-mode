using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DE2")]
public class AdjustPlayStoreSubscription
{
	[Token(Token = "0x40105FF")]
	[FieldOffset(Offset = "0x10")]
	internal string price;

	[Token(Token = "0x4010600")]
	[FieldOffset(Offset = "0x18")]
	internal string currency;

	[Token(Token = "0x4010601")]
	[FieldOffset(Offset = "0x20")]
	internal string sku;

	[Token(Token = "0x4010602")]
	[FieldOffset(Offset = "0x28")]
	internal string orderId;

	[Token(Token = "0x4010603")]
	[FieldOffset(Offset = "0x30")]
	internal string signature;

	[Token(Token = "0x4010604")]
	[FieldOffset(Offset = "0x38")]
	internal string purchaseToken;

	[Token(Token = "0x4010605")]
	[FieldOffset(Offset = "0x40")]
	internal string billingStore;

	[Token(Token = "0x4010606")]
	[FieldOffset(Offset = "0x48")]
	internal string purchaseTime;

	[Token(Token = "0x4010607")]
	[FieldOffset(Offset = "0x50")]
	internal List<string> partnerList;

	[Token(Token = "0x4010608")]
	[FieldOffset(Offset = "0x58")]
	internal List<string> callbackList;

	[Token(Token = "0x600BFA7")]
	[Address(RVA = "0x597D70", Offset = "0x596F70", VA = "0x180597D70")]
	public AdjustPlayStoreSubscription(string price, string currency, string sku, string orderId, string signature, string purchaseToken)
	{
	}

	[Token(Token = "0x600BFA8")]
	[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
	public void setPurchaseTime(string purchaseTime)
	{
	}

	[Token(Token = "0x600BFA9")]
	[Address(RVA = "0x597E20", Offset = "0x597020", VA = "0x180597E20")]
	public void addCallbackParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BFAA")]
	[Address(RVA = "0x597FA0", Offset = "0x5971A0", VA = "0x180597FA0")]
	public void addPartnerParameter(string key, string value)
	{
	}
}
