using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using KonamiCommonIAB;

namespace YgomSystem.Billing;

[Token(Token = "0x2000336")]
public class BillingSystem
{
	[Token(Token = "0x4001181")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static IBilling m_billing;

	[Token(Token = "0x17000218")]
	public static bool restoreOnLogin
	{
		[Token(Token = "0x6001419")]
		[Address(RVA = "0x51C460", Offset = "0x51B660", VA = "0x18051C460")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000219")]
	public static bool isVoid
	{
		[Token(Token = "0x600141A")]
		[Address(RVA = "0x51C3D0", Offset = "0x51B5D0", VA = "0x18051C3D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700021A")]
	public static bool initialized
	{
		[Token(Token = "0x600141B")]
		[Address(RVA = "0x51C370", Offset = "0x51B570", VA = "0x18051C370")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600141C")]
	[Address(RVA = "0x51C050", Offset = "0x51B250", VA = "0x18051C050")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x600141D")]
	[Address(RVA = "0x51C310", Offset = "0x51B510", VA = "0x18051C310")]
	public static bool canMakePayment()
	{
		return default(bool);
	}

	[Token(Token = "0x600141E")]
	[Address(RVA = "0x51C220", Offset = "0x51B420", VA = "0x18051C220")]
	public static void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback)
	{
	}

	[Token(Token = "0x600141F")]
	[Address(RVA = "0x51BF70", Offset = "0x51B170", VA = "0x18051BF70")]
	public static ProductInfo GetItem(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001420")]
	[Address(RVA = "0x51BE10", Offset = "0x51B010", VA = "0x18051BE10")]
	public static string GetDisplayedPrice(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001421")]
	[Address(RVA = "0x51BF40", Offset = "0x51B140", VA = "0x18051BF40")]
	public static string GetDoubleNotationDisplayPrice(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001422")]
	[Address(RVA = "0x51BB50", Offset = "0x51AD50", VA = "0x18051BB50")]
	public static void BuyItem(int shopId, string productId, [Optional] Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001423")]
	[Address(RVA = "0x51BC50", Offset = "0x51AE50", VA = "0x18051BC50")]
	public static void DoRestore(Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001424")]
	[Address(RVA = "0x51BD30", Offset = "0x51AF30", VA = "0x18051BD30")]
	public static void DoRestore(Action<ResultCode, List<Purchase>> callback)
	{
	}

	[Token(Token = "0x6001425")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BillingSystem()
	{
	}
}
