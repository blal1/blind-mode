using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using KonamiCommonIAB;
using Steamworks;
using YgomSystem.Network;

namespace YgomSystem.Billing;

[Token(Token = "0x200034A")]
public class Billing_Steam : Billing_Base
{
	[Token(Token = "0x40011BC")]
	[FieldOffset(Offset = "0x30")]
	protected Callback<MicroTxnAuthorizationResponse_t> m_MicroTxnAuthorizationResponse;

	[Token(Token = "0x40011BD")]
	[FieldOffset(Offset = "0x38")]
	protected Callback<SteamServerConnectFailure_t> m_SteamServerConnectFailureCallback;

	[Token(Token = "0x40011BE")]
	[FieldOffset(Offset = "0x40")]
	protected Callback<SteamServersDisconnected_t> m_SteamServerDisconnectedCallback;

	[Token(Token = "0x40011BF")]
	[FieldOffset(Offset = "0x48")]
	protected ProductInfo m_ProductInfo;

	[Token(Token = "0x6001488")]
	[Address(RVA = "0x51F810", Offset = "0x51EA10", VA = "0x18051F810", Slot = "12")]
	public override bool canMakePayment()
	{
		return default(bool);
	}

	[Token(Token = "0x6001489")]
	[Address(RVA = "0x51EF50", Offset = "0x51E150", VA = "0x18051EF50", Slot = "22")]
	public override void Initialize()
	{
	}

	[Token(Token = "0x600148A")]
	[Address(RVA = "0x51E3C0", Offset = "0x51D5C0", VA = "0x18051E3C0", Slot = "20")]
	protected override Handle API_Billing_re_store(Purchase purchase)
	{
		return null;
	}

	[Token(Token = "0x600148B")]
	[Address(RVA = "0x51E440", Offset = "0x51D640", VA = "0x18051E440", Slot = "16")]
	protected override bool BuyItemFromPlatform(ProductInfo product, IabDelegate.OnBuyFinishedDelegate cb)
	{
		return default(bool);
	}

	[Token(Token = "0x600148C")]
	[Address(RVA = "0x51F970", Offset = "0x51EB70", VA = "0x18051F970", Slot = "14")]
	protected override void checkUnfinishedPurchase(ProductInfo product, Action<ResultCode, Purchase> callback)
	{
	}

	[Token(Token = "0x600148D")]
	[Address(RVA = "0x51F840", Offset = "0x51EA40", VA = "0x18051F840", Slot = "15")]
	protected override void checkUnfinishedPurchase(Action<ResultCode, List<Purchase>> callback)
	{
	}

	[Token(Token = "0x600148E")]
	[Address(RVA = "0x51E5E0", Offset = "0x51D7E0", VA = "0x18051E5E0", Slot = "13")]
	protected override void GetItemList(string[] productIds, Action<List<ProductInfo>> callback)
	{
	}

	[Token(Token = "0x600148F")]
	[Address(RVA = "0x51EB50", Offset = "0x51DD50", VA = "0x18051EB50")]
	protected List<Purchase> GetUnfinishedPurchaseItemList()
	{
		return null;
	}

	[Token(Token = "0x6001490")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "17")]
	protected override void OnPurchaseFinished(Purchase purchase)
	{
	}

	[Token(Token = "0x6001491")]
	[Address(RVA = "0x51F100", Offset = "0x51E300", VA = "0x18051F100")]
	private void OnMicroTxnAuthorizationResponse(MicroTxnAuthorizationResponse_t response)
	{
	}

	[Token(Token = "0x6001492")]
	[Address(RVA = "0x51F360", Offset = "0x51E560", VA = "0x18051F360")]
	private void OnSteamServerConnectFailure(SteamServerConnectFailure_t response)
	{
	}

	[Token(Token = "0x6001493")]
	[Address(RVA = "0x51F400", Offset = "0x51E600", VA = "0x18051F400")]
	private void OnSteamServersDisconnected(SteamServersDisconnected_t response)
	{
	}

	[Token(Token = "0x6001494")]
	[Address(RVA = "0x51F600", Offset = "0x51E800", VA = "0x18051F600")]
	protected void RequestPurchase(MicroTxnAuthorizationResponse_t response, Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001495")]
	[Address(RVA = "0x51F4A0", Offset = "0x51E6A0", VA = "0x18051F4A0")]
	private void RegistCallback()
	{
	}

	[Token(Token = "0x6001496")]
	[Address(RVA = "0x51F780", Offset = "0x51E980", VA = "0x18051F780")]
	private void UnregistCallback()
	{
	}

	[Token(Token = "0x6001497")]
	[Address(RVA = "0x51E040", Offset = "0x51D240", VA = "0x18051E040")]
	public Billing_Steam()
	{
	}
}
