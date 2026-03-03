using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using KonamiCommonIAB;
using YgomSystem.Network;

namespace YgomSystem.Billing;

[Token(Token = "0x2000338")]
public abstract class Billing_Base : IBilling
{
	[Token(Token = "0x4001182")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected InAppBilling m_inAppBilling;

	[Token(Token = "0x4001183")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	protected Dictionary<string, ProductInfo> m_productDic;

	[Token(Token = "0x4001185")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Action<ResultCode> OnBuyCallback;

	[Token(Token = "0x1700021B")]
	public int NetworkErrorCode
	{
		[Token(Token = "0x6001430")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6001431")]
		[Address(RVA = "0x51E0C0", Offset = "0x51D2C0", VA = "0x18051E0C0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x1700021C")]
	public virtual bool initialized
	{
		[Token(Token = "0x6001434")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "21")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001426")]
	public abstract bool canMakePayment();

	[Token(Token = "0x6001427")]
	protected abstract void GetItemList(string[] productIds, Action<List<ProductInfo>> callback);

	[Token(Token = "0x6001428")]
	protected abstract void checkUnfinishedPurchase(ProductInfo product, Action<ResultCode, Purchase> callback);

	[Token(Token = "0x6001429")]
	protected abstract void checkUnfinishedPurchase(Action<ResultCode, List<Purchase>> callback);

	[Token(Token = "0x600142A")]
	protected abstract bool BuyItemFromPlatform(ProductInfo product, IabDelegate.OnBuyFinishedDelegate cb);

	[Token(Token = "0x600142B")]
	protected abstract void OnPurchaseFinished(Purchase purchase);

	[Token(Token = "0x600142C")]
	[Address(RVA = "0x51C5B0", Offset = "0x51B7B0", VA = "0x18051C5B0", Slot = "18")]
	protected virtual Handle API_Billing_reservation(int shopID, int merchId, ProductInfo product)
	{
		return null;
	}

	[Token(Token = "0x600142D")]
	[Address(RVA = "0x51C500", Offset = "0x51B700", VA = "0x18051C500", Slot = "19")]
	protected virtual Handle API_Billing_purchase(Purchase purchase)
	{
		return null;
	}

	[Token(Token = "0x600142E")]
	[Address(RVA = "0x51C570", Offset = "0x51B770", VA = "0x18051C570", Slot = "20")]
	protected virtual Handle API_Billing_re_store(Purchase purchase)
	{
		return null;
	}

	[Token(Token = "0x600142F")]
	[Address(RVA = "0x51C840", Offset = "0x51BA40", VA = "0x18051C840")]
	protected bool CheckMaintenance(Handle handle, out ResultCode res)
	{
		return default(bool);
	}

	[Token(Token = "0x6001432")]
	[Address(RVA = "0x51D0F0", Offset = "0x51C2F0", VA = "0x18051D0F0")]
	protected void LockUI()
	{
	}

	[Token(Token = "0x6001433")]
	[Address(RVA = "0x51E010", Offset = "0x51D210", VA = "0x18051E010")]
	protected void UnLockUI()
	{
	}

	[Token(Token = "0x6001435")]
	[Address(RVA = "0x51CDF0", Offset = "0x51BFF0", VA = "0x18051CDF0", Slot = "22")]
	public virtual void Initialize()
	{
	}

	[Token(Token = "0x6001436")]
	[Address(RVA = "0x51CF70", Offset = "0x51C170", VA = "0x18051CF70", Slot = "7")]
	public void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback)
	{
	}

	[Token(Token = "0x6001437")]
	[Address(RVA = "0x51CD60", Offset = "0x51BF60", VA = "0x18051CD60", Slot = "8")]
	public ProductInfo GetItem(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001438")]
	[Address(RVA = "0x51CB80", Offset = "0x51BD80", VA = "0x18051CB80", Slot = "9")]
	public void DoRestore([Optional] Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001439")]
	[Address(RVA = "0x51CA10", Offset = "0x51BC10", VA = "0x18051CA10", Slot = "10")]
	public void DoRestore(Action<ResultCode, List<Purchase>> callback)
	{
	}

	[Token(Token = "0x600143A")]
	[Address(RVA = "0x51C650", Offset = "0x51B850", VA = "0x18051C650", Slot = "11")]
	public void BuyItem(int shopId, string productId, [Optional] Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x600143B")]
	[Address(RVA = "0x51DEB0", Offset = "0x51D0B0", VA = "0x18051DEB0", Slot = "23")]
	protected virtual void RequestRevervation(int shopId, ProductInfo product)
	{
	}

	[Token(Token = "0x600143C")]
	[Address(RVA = "0x51C890", Offset = "0x51BA90", VA = "0x18051C890")]
	private void CheckUserAge(int shopId, ProductInfo product)
	{
	}

	[Token(Token = "0x600143D")]
	[Address(RVA = "0x51D3D0", Offset = "0x51C5D0", VA = "0x18051D3D0")]
	public void OpenUserAgeSelectSheet(Action<int> selectedCallback, Action canceledCallback)
	{
	}

	[Token(Token = "0x600143E")]
	[Address(RVA = "0x51D2A0", Offset = "0x51C4A0", VA = "0x18051D2A0")]
	private void OpenUserAgeConfirm(string selectedLabel, Action decidedCallback, Action canceledCallback)
	{
	}

	[Token(Token = "0x600143F")]
	[Address(RVA = "0x51D190", Offset = "0x51C390", VA = "0x18051D190", Slot = "24")]
	protected virtual void OnBuyPlatformFinish(Result result, Purchase purchase)
	{
	}

	[Token(Token = "0x6001440")]
	[Address(RVA = "0x51D8D0", Offset = "0x51CAD0", VA = "0x18051D8D0", Slot = "25")]
	protected virtual void RequestPurchase(Purchase purchase, Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001441")]
	[Address(RVA = "0x51D660", Offset = "0x51C860", VA = "0x18051D660")]
	protected void RequestAddItem(Purchase purchase, Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001442")]
	[Address(RVA = "0x51D7A0", Offset = "0x51C9A0", VA = "0x18051D7A0")]
	protected void RequestCancel([Optional] Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001443")]
	[Address(RVA = "0x51DBD0", Offset = "0x51CDD0", VA = "0x18051DBD0", Slot = "26")]
	protected virtual void RequestRestore(List<Purchase> purchases, Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001444")]
	[Address(RVA = "0x51DA30", Offset = "0x51CC30", VA = "0x18051DA30", Slot = "27")]
	protected virtual void RequestRestore(List<Purchase> purchases, List<Purchase> compPurchases, Action<ResultCode, List<Purchase>> callback)
	{
	}

	[Token(Token = "0x6001445")]
	[Address(RVA = "0x51DD30", Offset = "0x51CF30", VA = "0x18051DD30", Slot = "28")]
	protected virtual void RequestRestore(Purchase purchase, Action<ResultCode> callback)
	{
	}

	[Token(Token = "0x6001446")]
	[Address(RVA = "0x51D150", Offset = "0x51C350", VA = "0x18051D150")]
	protected void OnBuyFinish(ResultCode code)
	{
	}

	[Token(Token = "0x6001447")]
	[Address(RVA = "0x51D640", Offset = "0x51C840", VA = "0x18051D640", Slot = "29")]
	protected virtual void PurchaseFinishTransaction(Purchase purchase)
	{
	}

	[Token(Token = "0x6001448")]
	[Address(RVA = "0x51CD30", Offset = "0x51BF30", VA = "0x18051CD30")]
	public string GetDoubleNotationDisplayPrice(string productId)
	{
		return null;
	}

	[Token(Token = "0x6001449")]
	[Address(RVA = "0x51CD00", Offset = "0x51BF00", VA = "0x18051CD00", Slot = "30")]
	public virtual string GetDoubleNotationDisplayPrice(ProductInfo productInfo)
	{
		return null;
	}

	[Token(Token = "0x600144A")]
	[Address(RVA = "0x51E000", Offset = "0x51D200", VA = "0x18051E000")]
	[Conditional("YGO_DEBUG")]
	protected void SetErrorMsg(string msg)
	{
	}

	[Token(Token = "0x600144B")]
	[Address(RVA = "0x51E040", Offset = "0x51D240", VA = "0x18051E040")]
	protected Billing_Base()
	{
	}
}
