using System.Collections.Generic;
using Il2CppDummyDll;

namespace KonamiCommonIAB;

[Token(Token = "0x200010F")]
public class IabDelegate
{
	[Token(Token = "0x2000110")]
	public delegate void OnInitializationFinishedDelegate(bool result);

	[Token(Token = "0x2000111")]
	public delegate void OnGetItemDetailsFinished(Result result, List<ProductInfo> details);

	[Token(Token = "0x2000112")]
	public delegate void OnGetItemProductDetailsFinished(Result result, List<ProductInfo> details);

	[Token(Token = "0x2000113")]
	public delegate void OnBuyFinishedDelegate(Result result, Purchase purchase);

	[Token(Token = "0x2000114")]
	public delegate void OnAcknowledgeFinishedDelegate(Result result);

	[Token(Token = "0x2000115")]
	public delegate void OnGetBillingConfigFinishedDelegate(Result result, BillingConfig billingConfig);

	[Token(Token = "0x60006CF")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public IabDelegate()
	{
	}
}
