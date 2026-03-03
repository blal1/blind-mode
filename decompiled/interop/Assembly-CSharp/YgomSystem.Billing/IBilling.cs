using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using KonamiCommonIAB;

namespace YgomSystem.Billing;

[Token(Token = "0x200034E")]
public interface IBilling
{
	[Token(Token = "0x1700021E")]
	bool initialized
	{
		[Token(Token = "0x60014A4")]
		get;
	}

	[Token(Token = "0x60014A5")]
	bool canMakePayment();

	[Token(Token = "0x60014A6")]
	void Initialize();

	[Token(Token = "0x60014A7")]
	void LoadItemList(IList<string> productIds, Action<List<ProductInfo>> callback);

	[Token(Token = "0x60014A8")]
	ProductInfo GetItem(string productId);

	[Token(Token = "0x60014A9")]
	void DoRestore([Optional] Action<ResultCode> callback);

	[Token(Token = "0x60014AA")]
	void DoRestore(Action<ResultCode, List<Purchase>> callback);

	[Token(Token = "0x60014AB")]
	void BuyItem(int shopId, string productId, [Optional] Action<ResultCode> callback);
}
