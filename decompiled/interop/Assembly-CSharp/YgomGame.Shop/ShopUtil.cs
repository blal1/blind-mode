using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Utility;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Shop;

[Token(Token = "0x20009DA")]
public static class ShopUtil
{
	[Token(Token = "0x4008DF9")]
	private const string k_CardListPoolConfig = "Definition/CardListBrowser/ShopCardPoolConfig";

	[Token(Token = "0x4008DFA")]
	private const string k_CardListPickupConfig = "Definition/CardListBrowser/ShopCardPickupConfig";

	[Token(Token = "0x4008DFB")]
	internal const string k_ResultKey_OnAbortBySectionMainte = "OnAbortBySectionMainte";

	[Token(Token = "0x4008DFC")]
	internal const string k_ResultKey_OnRequestedReleaseResources = "ShopUtil.k_ResultKey_OnRequestedReleaseResources";

	[Token(Token = "0x6003BFC")]
	[Address(RVA = "0x83E0B0", Offset = "0x83D2B0", VA = "0x18083E0B0")]
	public static bool ValidateWork(object productWork)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BFD")]
	[Address(RVA = "0x83DCB0", Offset = "0x83CEB0", VA = "0x18083DCB0")]
	public static bool TryGetHeaderDescButtonInfo(int categoryId, int subCategoryId, int sectionId, List<ProductContext> firstProducts, out string buttonLabel, out Action buttonAction)
	{
		return default(bool);
	}

	[Token(Token = "0x6003BFE")]
	[Address(RVA = "0x83D5C0", Offset = "0x83C7C0", VA = "0x18083D5C0")]
	public static void OpenMarketAgreement(int marketId, int shopId)
	{
	}

	[Token(Token = "0x6003BFF")]
	[Address(RVA = "0x83CD70", Offset = "0x83BF70", VA = "0x18083CD70")]
	public static bool HasPriceLimitedTicket()
	{
		return default(bool);
	}

	[Token(Token = "0x6003C00")]
	[Address(RVA = "0x83BD40", Offset = "0x83AF40", VA = "0x18083BD40")]
	public static (PriceContext, PriceContext) CollectTicketPriceInfo(ProductContext productCtx)
	{
		return default((PriceContext, PriceContext));
	}

	[Token(Token = "0x6003C01")]
	[Address(RVA = "0x83D120", Offset = "0x83C320", VA = "0x18083D120")]
	public static bool IsLimitedIconVisiblePrice(PriceContext priceCtx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C02")]
	[Address(RVA = "0x83D110", Offset = "0x83C310", VA = "0x18083D110")]
	public static bool IsLimitedIconVisiblePrice(long priceLimitTs, int payItemHave)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C03")]
	[Address(RVA = "0x83C790", Offset = "0x83B990", VA = "0x18083C790")]
	public static object GetProductParamValue(string paramKey, ProductContext productContext, PriceContext priceContext)
	{
		return null;
	}

	[Token(Token = "0x6003C04")]
	[Address(RVA = "0x83CBE0", Offset = "0x83BDE0", VA = "0x18083CBE0")]
	public static string GetShopConvertText(string text, ProductContext productContext, PriceContext priceContext)
	{
		return null;
	}

	[Token(Token = "0x6003C05")]
	[Address(RVA = "0x83D200", Offset = "0x83C400", VA = "0x18083D200")]
	public static string MakeShopProductFormatedText(this string text, TextGroupLoadHolder textGroupLoadHolder, List<object> args, ProductContext productContext, PriceContext priceContext)
	{
		return null;
	}

	[Token(Token = "0x6003C06")]
	[Address(RVA = "0x83D8A0", Offset = "0x83CAA0", VA = "0x18083D8A0")]
	private static string ShopTextConvert(string text, ProductContext productContext, PriceContext priceContext)
	{
		return null;
	}

	[Token(Token = "0x6003C07")]
	[Address(RVA = "0x83D170", Offset = "0x83C370", VA = "0x18083D170")]
	public static bool IsPayItemSpecial(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C08")]
	[Address(RVA = "0x83C5B0", Offset = "0x83B7B0", VA = "0x18083C5B0")]
	public static int GetPayItemHave(bool isPeriod, int itemCategory, int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x6003C09")]
	[Address(RVA = "0x83C700", Offset = "0x83B900", VA = "0x18083C700")]
	public static long GetPayItemLimitDateTs(bool isPeriod, int itemCategory, int itemId)
	{
		return default(long);
	}

	[Token(Token = "0x6003C0A")]
	[Address(RVA = "0x83C660", Offset = "0x83B860", VA = "0x18083C660")]
	public static string GetPayItemLimitDateStr(bool isPeriod, int itemCategory, int itemId)
	{
		return null;
	}

	[Token(Token = "0x6003C0B")]
	[Address(RVA = "0x83BD00", Offset = "0x83AF00", VA = "0x18083BD00")]
	public static bool CheckHandlingShopSectionMainte(Handle h, bool skipHandling = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C0C")]
	[Address(RVA = "0x83BCE0", Offset = "0x83AEE0", VA = "0x18083BCE0")]
	public static void CheckFocusBGM()
	{
	}

	[Token(Token = "0x6003C0D")]
	[Address(RVA = "0x83D770", Offset = "0x83C970", VA = "0x18083D770")]
	public static void SendRequestReleaseResources()
	{
	}

	[Token(Token = "0x6003C0E")]
	[Address(RVA = "0x83DC00", Offset = "0x83CE00", VA = "0x18083DC00")]
	public static int TryGetCurrentShopId()
	{
		return default(int);
	}

	[Token(Token = "0x6003C0F")]
	[Address(RVA = "0x83DE70", Offset = "0x83D070", VA = "0x18083DE70")]
	public static bool TryPopClosedShopVC(int shopId, bool chkBuyAble = false, [Optional] Type keepVcType)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C10")]
	[Address(RVA = "0x83DF30", Offset = "0x83D130", VA = "0x18083DF30")]
	public static bool TryPopClosedShopVC(ViewControllerManager manager, int shopId, bool chkBuyAble = false, [Optional] Type keepVcType)
	{
		return default(bool);
	}

	[Token(Token = "0x6003C11")]
	[Address(RVA = "0x83BA50", Offset = "0x83AC50", VA = "0x18083BA50")]
	public static void AbortShop()
	{
	}

	[Token(Token = "0x6003C12")]
	[Address(RVA = "0x83D720", Offset = "0x83C920", VA = "0x18083D720")]
	public static void OpenPoolCardListBrowser(int normalCardPoolId, [Optional] string overrideTitle)
	{
	}

	[Token(Token = "0x6003C13")]
	[Address(RVA = "0x83D6D0", Offset = "0x83C8D0", VA = "0x18083D6D0")]
	public static void OpenPickupCardListBrowser(int pickupCardPoolId, [Optional] string overrideTitle)
	{
	}

	[Token(Token = "0x6003C14")]
	[Address(RVA = "0x83BFF0", Offset = "0x83B1F0", VA = "0x18083BFF0")]
	public static void CreateReceiveItemDialog(bool isPeriod, int itemCategory, int itemId, int itemNum, bool isSendPresent, bool hideNum, bool hasStructure = false, [Optional] Dictionary<string, object> itemArgs, [Optional] Action onFinished)
	{
	}

	[Token(Token = "0x6003C15")]
	[Address(RVA = "0x83D230", Offset = "0x83C430", VA = "0x18083D230")]
	private static void OpenCardListBrowser(int cardPoolId, string configPath, [Optional] string overrideTitle)
	{
	}
}
