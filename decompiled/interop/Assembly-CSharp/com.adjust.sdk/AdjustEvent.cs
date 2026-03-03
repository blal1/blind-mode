using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace com.adjust.sdk;

[Token(Token = "0x2001DDD")]
public class AdjustEvent
{
	[Token(Token = "0x40105E1")]
	[FieldOffset(Offset = "0x10")]
	internal string currency;

	[Token(Token = "0x40105E2")]
	[FieldOffset(Offset = "0x18")]
	internal string eventToken;

	[Token(Token = "0x40105E3")]
	[FieldOffset(Offset = "0x20")]
	internal string callbackId;

	[Token(Token = "0x40105E4")]
	[FieldOffset(Offset = "0x28")]
	internal string transactionId;

	[Token(Token = "0x40105E5")]
	[FieldOffset(Offset = "0x30")]
	internal double? revenue;

	[Token(Token = "0x40105E6")]
	[FieldOffset(Offset = "0x40")]
	internal List<string> partnerList;

	[Token(Token = "0x40105E7")]
	[FieldOffset(Offset = "0x48")]
	internal List<string> callbackList;

	[Token(Token = "0x40105E8")]
	[FieldOffset(Offset = "0x50")]
	internal string receipt;

	[Token(Token = "0x40105E9")]
	[FieldOffset(Offset = "0x58")]
	internal bool isReceiptSet;

	[Token(Token = "0x600BF7A")]
	[Address(RVA = "0x597730", Offset = "0x596930", VA = "0x180597730")]
	public AdjustEvent(string eventToken)
	{
	}

	[Token(Token = "0x600BF7B")]
	[Address(RVA = "0x597AB0", Offset = "0x596CB0", VA = "0x180597AB0")]
	public void setRevenue(double amount, string currency)
	{
	}

	[Token(Token = "0x600BF7C")]
	[Address(RVA = "0x597770", Offset = "0x596970", VA = "0x180597770")]
	public void addCallbackParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BF7D")]
	[Address(RVA = "0x5978F0", Offset = "0x596AF0", VA = "0x1805978F0")]
	public void addPartnerParameter(string key, string value)
	{
	}

	[Token(Token = "0x600BF7E")]
	[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
	public void setTransactionId(string transactionId)
	{
	}

	[Token(Token = "0x600BF7F")]
	[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
	public void setCallbackId(string callbackId)
	{
	}

	[Token(Token = "0x600BF80")]
	[Address(RVA = "0x597A70", Offset = "0x596C70", VA = "0x180597A70")]
	[Obsolete("This is an obsolete method. Please use the adjust purchase SDK for purchase verification (https://github.com/adjust/unity_purchase_sdk)")]
	public void setReceipt(string receipt, string transactionId)
	{
	}
}
