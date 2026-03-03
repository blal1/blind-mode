using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.GemShop;

[Token(Token = "0x2000DA0")]
public class JsonGemShopAnalyzer
{
	[Token(Token = "0x2000DA1")]
	public class ProductAnalyzer
	{
		[Token(Token = "0x60051D9")]
		[Address(RVA = "0x994920", Offset = "0x993B20", VA = "0x180994920")]
		public string GetProductNameId(object productData)
		{
			return null;
		}

		[Token(Token = "0x60051DA")]
		[Address(RVA = "0x9943E0", Offset = "0x9935E0", VA = "0x1809943E0")]
		public string CreateProductName(object productData, int gemCount)
		{
			return null;
		}

		[Token(Token = "0x60051DB")]
		[Address(RVA = "0x994AA0", Offset = "0x993CA0", VA = "0x180994AA0")]
		public long GetShopPaidId(object productData)
		{
			return default(long);
		}

		[Token(Token = "0x60051DC")]
		[Address(RVA = "0x9948B0", Offset = "0x993AB0", VA = "0x1809948B0")]
		public string GetProductId(object productData)
		{
			return null;
		}

		[Token(Token = "0x60051DD")]
		[Address(RVA = "0x994590", Offset = "0x993790", VA = "0x180994590")]
		public int GetConfirmRegId(object productData)
		{
			return default(int);
		}

		[Token(Token = "0x60051DE")]
		[Address(RVA = "0x9945F0", Offset = "0x9937F0", VA = "0x1809945F0")]
		public bool GetEnabled(object productData)
		{
			return default(bool);
		}

		[Token(Token = "0x60051DF")]
		[Address(RVA = "0x9946B0", Offset = "0x9938B0", VA = "0x1809946B0")]
		public IReadOnlyDictionary<string, object> GetItems(object productData)
		{
			return null;
		}

		[Token(Token = "0x60051E0")]
		[Address(RVA = "0x994840", Offset = "0x993A40", VA = "0x180994840")]
		public string GetPriceLabel(object productData)
		{
			return null;
		}

		[Token(Token = "0x60051E1")]
		[Address(RVA = "0x9947E0", Offset = "0x9939E0", VA = "0x1809947E0")]
		public int GetOrder(object productData)
		{
			return default(int);
		}

		[Token(Token = "0x60051E2")]
		[Address(RVA = "0x994710", Offset = "0x993910", VA = "0x180994710")]
		public int GetLimitBuyCount(object productData)
		{
			return default(int);
		}

		[Token(Token = "0x60051E3")]
		[Address(RVA = "0x994650", Offset = "0x993850", VA = "0x180994650")]
		public long GetEndDateTs(object productData)
		{
			return default(long);
		}

		[Token(Token = "0x60051E4")]
		[Address(RVA = "0x994770", Offset = "0x993970", VA = "0x180994770")]
		public string GetLimitdate(object productData)
		{
			return null;
		}

		[Token(Token = "0x60051E5")]
		[Address(RVA = "0x994530", Offset = "0x993730", VA = "0x180994530")]
		public int GetBuyCount(object productData)
		{
			return default(int);
		}

		[Token(Token = "0x60051E6")]
		[Address(RVA = "0x994B00", Offset = "0x993D00", VA = "0x180994B00")]
		public int GetThumbId(object productData)
		{
			return default(int);
		}

		[Token(Token = "0x60051E7")]
		[Address(RVA = "0x994990", Offset = "0x993B90", VA = "0x180994990")]
		public ProductStyle GetProductStyle(object productData)
		{
			return default(ProductStyle);
		}

		[Token(Token = "0x60051E8")]
		[Address(RVA = "0x9949F0", Offset = "0x993BF0", VA = "0x1809949F0")]
		public string GetSaleText(object productData)
		{
			return null;
		}

		[Token(Token = "0x60051E9")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ProductAnalyzer()
		{
		}
	}

	[Token(Token = "0x4009FA4")]
	[FieldOffset(Offset = "0x10")]
	public ProductAnalyzer product;

	[Token(Token = "0x60051D8")]
	[Address(RVA = "0x993160", Offset = "0x992360", VA = "0x180993160")]
	public JsonGemShopAnalyzer()
	{
	}
}
