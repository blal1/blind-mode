using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000921")]
public class HighlightContext
{
	[Token(Token = "0x40089E4")]
	[FieldOffset(Offset = "0x10")]
	private int m_ItemId;

	[Token(Token = "0x40089E5")]
	[FieldOffset(Offset = "0x18")]
	private Dictionary<string, object> m_HighlightData;

	[Token(Token = "0x40089E6")]
	[FieldOffset(Offset = "0x20")]
	private BindingShopProductThumb.Context m_ProductThumbCtxCache;

	[Token(Token = "0x1700068D")]
	public ShopDef.HighlightType highlightType
	{
		[Token(Token = "0x60036CF")]
		[Address(RVA = "0x7CE8E0", Offset = "0x7CDAE0", VA = "0x1807CE8E0")]
		get
		{
			return default(ShopDef.HighlightType);
		}
	}

	[Token(Token = "0x1700068E")]
	public bool supportedCard
	{
		[Token(Token = "0x60036D0")]
		[Address(RVA = "0x7CEC50", Offset = "0x7CDE50", VA = "0x1807CEC50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700068F")]
	public int mrk
	{
		[Token(Token = "0x60036D1")]
		[Address(RVA = "0x7CE9B0", Offset = "0x7CDBB0", VA = "0x1807CE9B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000690")]
	public int rare
	{
		[Token(Token = "0x60036D2")]
		[Address(RVA = "0x7CEC10", Offset = "0x7CDE10", VA = "0x1807CEC10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000691")]
	public int itemId
	{
		[Token(Token = "0x60036D3")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60036D4")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		set
		{
		}
	}

	[Token(Token = "0x17000692")]
	public string path
	{
		[Token(Token = "0x60036D5")]
		[Address(RVA = "0x7CE9F0", Offset = "0x7CDBF0", VA = "0x1807CE9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000693")]
	public bool isPref
	{
		[Token(Token = "0x60036D6")]
		[Address(RVA = "0x7CE970", Offset = "0x7CDB70", VA = "0x1807CE970")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000694")]
	public bool hidePlay
	{
		[Token(Token = "0x60036D7")]
		[Address(RVA = "0x7CE8A0", Offset = "0x7CDAA0", VA = "0x1807CE8A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000695")]
	public bool isMate
	{
		[Token(Token = "0x60036D8")]
		[Address(RVA = "0x7CE940", Offset = "0x7CDB40", VA = "0x1807CE940")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000696")]
	public bool dxBadgeVisible
	{
		[Token(Token = "0x60036D9")]
		[Address(RVA = "0x7CE830", Offset = "0x7CDA30", VA = "0x1807CE830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000697")]
	public bool dxBadgeFloating
	{
		[Token(Token = "0x60036DA")]
		[Address(RVA = "0x7CE7F0", Offset = "0x7CD9F0", VA = "0x1807CE7F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000698")]
	public BindingShopProductThumb.Context productThumbCtx
	{
		[Token(Token = "0x60036DB")]
		[Address(RVA = "0x7CEA30", Offset = "0x7CDC30", VA = "0x1807CEA30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000699")]
	public BindingShopProductThumb.ThumbType thumbType
	{
		[Token(Token = "0x60036DC")]
		[Address(RVA = "0x7CECA0", Offset = "0x7CDEA0", VA = "0x1807CECA0")]
		get
		{
			return default(BindingShopProductThumb.ThumbType);
		}
	}

	[Token(Token = "0x60036DD")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public HighlightContext()
	{
	}

	[Token(Token = "0x60036DE")]
	[Address(RVA = "0x7CE760", Offset = "0x7CD960", VA = "0x1807CE760")]
	public void Import(Dictionary<string, object> priceData)
	{
	}
}
