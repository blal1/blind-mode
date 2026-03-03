using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using KonamiCommonIAB;

namespace YgomSystem.Billing;

[Token(Token = "0x2000349")]
public class Billing_None : IBilling
{
	[Token(Token = "0x40011BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected Dictionary<string, ProductInfo> m_productDic;

	[Token(Token = "0x1700021D")]
	public bool initialized
	{
		[Token(Token = "0x600147D")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600147E")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "5")]
	public bool canMakePayment()
	{
		return default(bool);
	}

	[Token(Token = "0x600147F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "6")]
	public void Initialize()
	{
	}

	[Token(Token = "0x6001480")]
	[Address(RVA = "0x51E290", Offset = "0x51D490", VA = "0x18051E290", Slot = "7")]
	public void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback)
	{
	}

	[Token(Token = "0x6001481")]
	[Address(RVA = "0x51E200", Offset = "0x51D400", VA = "0x18051E200", Slot = "8")]
	public ProductInfo GetItem(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001482")]
	[Address(RVA = "0x51E110", Offset = "0x51D310", VA = "0x18051E110", Slot = "9")]
	public void DoRestore([Optional] Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001483")]
	[Address(RVA = "0x51E0D0", Offset = "0x51D2D0", VA = "0x18051E0D0", Slot = "11")]
	public void BuyItem(int shopId, string productId, [Optional] Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001484")]
	[Address(RVA = "0x51E0F0", Offset = "0x51D2F0", VA = "0x18051E0F0", Slot = "10")]
	public void DoRestore(Action<ResultCode, List<Purchase>> callback)
	{
	}

	[Token(Token = "0x6001485")]
	[Address(RVA = "0x51E130", Offset = "0x51D330", VA = "0x18051E130")]
	public string GetDoubleNotationDisplayPrice(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001486")]
	[Address(RVA = "0x51E1D0", Offset = "0x51D3D0", VA = "0x18051E1D0", Slot = "12")]
	public virtual string GetDoubleNotationDisplayPrice(ProductInfo productInfo)
	{
		return null;
	}

	[Token(Token = "0x6001487")]
	[Address(RVA = "0x51E340", Offset = "0x51D540", VA = "0x18051E340")]
	public Billing_None()
	{
	}
}
