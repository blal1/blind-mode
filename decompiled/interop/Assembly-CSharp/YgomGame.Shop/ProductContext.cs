using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Card;
using YgomGame.CardPack;
using YgomGame.Utility;

namespace YgomGame.Shop;

[Token(Token = "0x2000927")]
public class ProductContext : IComparable<ProductContext>, IShowcaseGruopContext, IHasShopIdContent
{
	[Token(Token = "0x40089F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	protected Dictionary<string, object> m_ProductData;

	[Token(Token = "0x40089F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private int m_SectionId;

	[Token(Token = "0x40089F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly ProductContext m_Parent;

	[Token(Token = "0x40089FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private List<ProductContext> m_Children;

	[Token(Token = "0x40089FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private TextGroupLoadHolder m_TextGroupLoadHolder;

	[Token(Token = "0x40089FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private bool m_IsNew;

	[Token(Token = "0x40089FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly BindingShopProductThumb.Context m_ThumbContext;

	[Token(Token = "0x40089FE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly List<PriceContext> m_PriceContexts;

	[Token(Token = "0x40089FF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private PriceContext m_ListButtonPrice;

	[Token(Token = "0x4008A00")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly List<HighlightContext> m_HighlightContexts;

	[Token(Token = "0x4008A01")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<string> m_FilterNames;

	[Token(Token = "0x4008A04")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private Dictionary<string, object> m_Decoration;

	[Token(Token = "0x170006C1")]
	public bool marketUnlocked
	{
		[Token(Token = "0x600371C")]
		[Address(RVA = "0x7D5A10", Offset = "0x7D4C10", VA = "0x1807D5A10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006C2")]
	public int marketId
	{
		[Token(Token = "0x600371D")]
		[Address(RVA = "0x7D5930", Offset = "0x7D4B30", VA = "0x1807D5930")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C3")]
	public int marketSlotNo
	{
		[Token(Token = "0x600371E")]
		[Address(RVA = "0x7D59B0", Offset = "0x7D4BB0", VA = "0x1807D59B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C4")]
	public bool isMarketProduct
	{
		[Token(Token = "0x600371F")]
		[Address(RVA = "0x7D4F70", Offset = "0x7D4170", VA = "0x1807D4F70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006C5")]
	public int shopId
	{
		[Token(Token = "0x6003720")]
		[Address(RVA = "0x7D62A0", Offset = "0x7D54A0", VA = "0x1807D62A0", Slot = "8")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C6")]
	public int productTypeId
	{
		[Token(Token = "0x6003721")]
		[Address(RVA = "0x7D60F0", Offset = "0x7D52F0", VA = "0x1807D60F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C7")]
	public ShopDef.ProductType productType
	{
		[Token(Token = "0x6003722")]
		[Address(RVA = "0x7D60F0", Offset = "0x7D52F0", VA = "0x1807D60F0")]
		get
		{
			return default(ShopDef.ProductType);
		}
	}

	[Token(Token = "0x170006C8")]
	public int targetCategory
	{
		[Token(Token = "0x6003723")]
		[Address(RVA = "0x7D6400", Offset = "0x7D5600", VA = "0x1807D6400")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006C9")]
	public int targetId
	{
		[Token(Token = "0x6003724")]
		[Address(RVA = "0x7D6440", Offset = "0x7D5640", VA = "0x1807D6440")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006CA")]
	public bool targetIsPeriod
	{
		[Token(Token = "0x6003725")]
		[Address(RVA = "0x7D6480", Offset = "0x7D5680", VA = "0x1807D6480")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006CB")]
	public int categoryId
	{
		[Token(Token = "0x6003726")]
		[Address(RVA = "0x7D4450", Offset = "0x7D3650", VA = "0x1807D4450", Slot = "5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006CC")]
	public int sectionId
	{
		[Token(Token = "0x6003727")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60", Slot = "7")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006CD")]
	public ShopDef.ShowcaseCategory category
	{
		[Token(Token = "0x6003728")]
		[Address(RVA = "0x7D4450", Offset = "0x7D3650", VA = "0x1807D4450")]
		get
		{
			return default(ShopDef.ShowcaseCategory);
		}
	}

	[Token(Token = "0x170006CE")]
	public int subCategoryId
	{
		[Token(Token = "0x6003729")]
		[Address(RVA = "0x7D63C0", Offset = "0x7D55C0", VA = "0x1807D63C0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006CF")]
	public bool hasChildren
	{
		[Token(Token = "0x600372A")]
		[Address(RVA = "0x7D49C0", Offset = "0x7D3BC0", VA = "0x1807D49C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006D0")]
	public IReadOnlyList<ProductContext> children
	{
		[Token(Token = "0x600372B")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D1")]
	public TextGroupLoadHolder textGroupLoadHolder
	{
		[Token(Token = "0x600372C")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600372D")]
		[Address(RVA = "0x7D6570", Offset = "0x7D5770", VA = "0x1807D6570")]
		set
		{
		}
	}

	[Token(Token = "0x170006D2")]
	public virtual string productName
	{
		[Token(Token = "0x600372E")]
		[Address(RVA = "0x7D5D10", Offset = "0x7D4F10", VA = "0x1807D5D10", Slot = "9")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D3")]
	public virtual string descTextFull
	{
		[Token(Token = "0x600372F")]
		[Address(RVA = "0x7D45C0", Offset = "0x7D37C0", VA = "0x1807D45C0", Slot = "10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D4")]
	public virtual string descTextShort
	{
		[Token(Token = "0x6003730")]
		[Address(RVA = "0x7D4740", Offset = "0x7D3940", VA = "0x1807D4740", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D5")]
	public string listDescText
	{
		[Token(Token = "0x6003731")]
		[Address(RVA = "0x7D58A0", Offset = "0x7D4AA0", VA = "0x1807D58A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D6")]
	public string detailMMAPath
	{
		[Token(Token = "0x6003732")]
		[Address(RVA = "0x7D47F0", Offset = "0x7D39F0", VA = "0x1807D47F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006D7")]
	public bool isNew
	{
		[Token(Token = "0x6003733")]
		[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6003734")]
		[Address(RVA = "0x406E80", Offset = "0x406080", VA = "0x180406E80")]
		set
		{
		}
	}

	[Token(Token = "0x170006D8")]
	public bool workIsNew
	{
		[Token(Token = "0x6003735")]
		[Address(RVA = "0x7D6500", Offset = "0x7D5700", VA = "0x1807D6500")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006D9")]
	public bool sendNew
	{
		[Token(Token = "0x6003736")]
		[Address(RVA = "0x7D61B0", Offset = "0x7D53B0", VA = "0x1807D61B0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006DA")]
	public bool isLimitedDate
	{
		[Token(Token = "0x6003737")]
		[Address(RVA = "0x7D4F50", Offset = "0x7D4150", VA = "0x1807D4F50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006DB")]
	public long limitTs
	{
		[Token(Token = "0x6003738")]
		[Address(RVA = "0x7D57C0", Offset = "0x7D49C0", VA = "0x1807D57C0")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170006DC")]
	public string limitDate
	{
		[Token(Token = "0x6003739")]
		[Address(RVA = "0x7D5720", Offset = "0x7D4920", VA = "0x1807D5720")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DD")]
	public string limitDateShort
	{
		[Token(Token = "0x600373A")]
		[Address(RVA = "0x7D5680", Offset = "0x7D4880", VA = "0x1807D5680")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006DE")]
	public bool isLimitedBuyCount
	{
		[Token(Token = "0x600373B")]
		[Address(RVA = "0x7D4F00", Offset = "0x7D4100", VA = "0x1807D4F00")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006DF")]
	public int limitBuyCount
	{
		[Token(Token = "0x600373C")]
		[Address(RVA = "0x7D5580", Offset = "0x7D4780", VA = "0x1807D5580")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006E0")]
	public int nowBuyCount
	{
		[Token(Token = "0x600373D")]
		[Address(RVA = "0x7D5A90", Offset = "0x7D4C90", VA = "0x1807D5A90")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006E1")]
	public bool isSoldOut
	{
		[Token(Token = "0x600373E")]
		[Address(RVA = "0x7D5330", Offset = "0x7D4530", VA = "0x1807D5330")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006E2")]
	public List<object> confirmTextIds
	{
		[Token(Token = "0x600373F")]
		[Address(RVA = "0x7D44C0", Offset = "0x7D36C0", VA = "0x1807D44C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E3")]
	public List<object> setItems
	{
		[Token(Token = "0x6003740")]
		[Address(RVA = "0x7D6220", Offset = "0x7D5420", VA = "0x1807D6220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E4")]
	public bool hasSetItems
	{
		[Token(Token = "0x6003741")]
		[Address(RVA = "0x7D4B70", Offset = "0x7D3D70", VA = "0x1807D4B70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006E5")]
	public List<object> setProducts
	{
		[Token(Token = "0x6003742")]
		[Address(RVA = "0x7D6260", Offset = "0x7D5460", VA = "0x1807D6260")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006E6")]
	public bool hasSetProducts
	{
		[Token(Token = "0x6003743")]
		[Address(RVA = "0x7D4BF0", Offset = "0x7D3DF0", VA = "0x1807D4BF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006E7")]
	public long sort
	{
		[Token(Token = "0x6003744")]
		[Address(RVA = "0x7D6300", Offset = "0x7D5500", VA = "0x1807D6300")]
		get
		{
			return default(long);
		}
	}

	[Token(Token = "0x170006E8")]
	public int packId
	{
		[Token(Token = "0x6003745")]
		[Address(RVA = "0x7D5B20", Offset = "0x7D4D20", VA = "0x1807D5B20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006E9")]
	public int packTypeId
	{
		[Token(Token = "0x6003746")]
		[Address(RVA = "0x7D5C20", Offset = "0x7D4E20", VA = "0x1807D5C20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006EA")]
	public CardPackDef.PackType packType
	{
		[Token(Token = "0x6003747")]
		[Address(RVA = "0x7D5CA0", Offset = "0x7D4EA0", VA = "0x1807D5CA0")]
		get
		{
			return default(CardPackDef.PackType);
		}
	}

	[Token(Token = "0x170006EB")]
	public int structureId
	{
		[Token(Token = "0x6003748")]
		[Address(RVA = "0x7D6340", Offset = "0x7D5540", VA = "0x1807D6340")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006EC")]
	public bool isPeriod
	{
		[Token(Token = "0x6003749")]
		[Address(RVA = "0x7D4FE0", Offset = "0x7D41E0", VA = "0x1807D4FE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006ED")]
	public int itemCategory
	{
		[Token(Token = "0x600374A")]
		[Address(RVA = "0x7D5400", Offset = "0x7D4600", VA = "0x1807D5400")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006EE")]
	public int itemId
	{
		[Token(Token = "0x600374B")]
		[Address(RVA = "0x7D54A0", Offset = "0x7D46A0", VA = "0x1807D54A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006EF")]
	public int probGachaId
	{
		[Token(Token = "0x600374C")]
		[Address(RVA = "0x7D5CB0", Offset = "0x7D4EB0", VA = "0x1807D5CB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F0")]
	public int packNormalCardPoolId
	{
		[Token(Token = "0x600374D")]
		[Address(RVA = "0x7D5BA0", Offset = "0x7D4DA0", VA = "0x1807D5BA0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F1")]
	public int packPickupCardPoolId
	{
		[Token(Token = "0x600374E")]
		[Address(RVA = "0x7D5BE0", Offset = "0x7D4DE0", VA = "0x1807D5BE0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F2")]
	public int num
	{
		[Token(Token = "0x600374F")]
		[Address(RVA = "0x7D5AD0", Offset = "0x7D4CD0", VA = "0x1807D5AD0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170006F3")]
	public string duelLiveLink
	{
		[Token(Token = "0x6003750")]
		[Address(RVA = "0x7D4900", Offset = "0x7D3B00", VA = "0x1807D4900")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F4")]
	public Dictionary<string, object> duelpassreward
	{
		[Token(Token = "0x6003751")]
		[Address(RVA = "0x7D4940", Offset = "0x7D3B40", VA = "0x1807D4940")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F5")]
	public BindingShopProductThumb.Context thumbContext
	{
		[Token(Token = "0x6003752")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F6")]
	public ShopDef.ListButtonType listButtonType
	{
		[Token(Token = "0x6003753")]
		[Address(RVA = "0x7D5860", Offset = "0x7D4A60", VA = "0x1807D5860")]
		get
		{
			return default(ShopDef.ListButtonType);
		}
	}

	[Token(Token = "0x170006F7")]
	public List<PriceContext> priceContexts
	{
		[Token(Token = "0x6003754")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F8")]
	public PriceContext listButtonPrice
	{
		[Token(Token = "0x6003755")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006F9")]
	public bool hasPaymentId
	{
		[Token(Token = "0x6003756")]
		[Address(RVA = "0x7D4A10", Offset = "0x7D3C10", VA = "0x1807D4A10")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170006FA")]
	public List<HighlightContext> highlightContexts
	{
		[Token(Token = "0x6003757")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FB")]
	public HighlightContext headHighlightContext
	{
		[Token(Token = "0x6003758")]
		[Address(RVA = "0x7D4C70", Offset = "0x7D3E70", VA = "0x1807D4C70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FC")]
	public BindingShopProductThumb.Context detailThumbContext
	{
		[Token(Token = "0x6003759")]
		[Address(RVA = "0x7D4870", Offset = "0x7D3A70", VA = "0x1807D4870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FD")]
	public object chartData
	{
		[Token(Token = "0x600375A")]
		[Address(RVA = "0x7D4490", Offset = "0x7D3690", VA = "0x1807D4490")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FE")]
	public string deckCaseImagePath
	{
		[Token(Token = "0x600375B")]
		[Address(RVA = "0x7D4500", Offset = "0x7D3700", VA = "0x1807D4500")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170006FF")]
	public List<string> filterNames
	{
		[Token(Token = "0x600375C")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000700")]
	public ShopSettings shopSettings
	{
		[Token(Token = "0x600375D")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600375E")]
		[Address(RVA = "0x49C1F0", Offset = "0x49B3F0", VA = "0x18049C1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000701")]
	public CardCategoryData cardCategoryData
	{
		[Token(Token = "0x600375F")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003760")]
		[Address(RVA = "0x3D77E0", Offset = "0x3D69E0", VA = "0x1803D77E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000702")]
	public int limitAlertSec
	{
		[Token(Token = "0x6003764")]
		[Address(RVA = "0x7D5540", Offset = "0x7D4740", VA = "0x1807D5540")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000703")]
	public int limitConfirmSec
	{
		[Token(Token = "0x6003765")]
		[Address(RVA = "0x7D5600", Offset = "0x7D4800", VA = "0x1807D5600")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000704")]
	public string limitConfirmMessage
	{
		[Token(Token = "0x6003766")]
		[Address(RVA = "0x7D55C0", Offset = "0x7D47C0", VA = "0x1807D55C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000705")]
	public string limitConfirmSoonMessage
	{
		[Token(Token = "0x6003767")]
		[Address(RVA = "0x7D5640", Offset = "0x7D4840", VA = "0x1807D5640")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000706")]
	public int highlightStyleType
	{
		[Token(Token = "0x6003768")]
		[Address(RVA = "0x7D4E00", Offset = "0x7D4000", VA = "0x1807D4E00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000707")]
	public string productWidgetLabel
	{
		[Token(Token = "0x6003769")]
		[Address(RVA = "0x7D6130", Offset = "0x7D5330", VA = "0x1807D6130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000708")]
	public string headLabelText
	{
		[Token(Token = "0x600376A")]
		[Address(RVA = "0x7D4CB0", Offset = "0x7D3EB0", VA = "0x1807D4CB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000709")]
	public string headSpCpIconPath
	{
		[Token(Token = "0x600376B")]
		[Address(RVA = "0x7D4CF0", Offset = "0x7D3EF0", VA = "0x1807D4CF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070A")]
	public bool dxBadge
	{
		[Token(Token = "0x600376C")]
		[Address(RVA = "0x7D4980", Offset = "0x7D3B80", VA = "0x1807D4980")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700070B")]
	public int bgId
	{
		[Token(Token = "0x600376D")]
		[Address(RVA = "0x7D4350", Offset = "0x7D3550", VA = "0x1807D4350")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700070C")]
	public string informButtonLabel
	{
		[Token(Token = "0x600376E")]
		[Address(RVA = "0x7D4EC0", Offset = "0x7D40C0", VA = "0x1807D4EC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070D")]
	public ShopDef.HighlightType highlightType
	{
		[Token(Token = "0x600376F")]
		[Address(RVA = "0x7D4E70", Offset = "0x7D4070", VA = "0x1807D4E70")]
		get
		{
			return default(ShopDef.HighlightType);
		}
	}

	[Token(Token = "0x1700070E")]
	public string productSubLabel
	{
		[Token(Token = "0x6003770")]
		[Address(RVA = "0x7D5E80", Offset = "0x7D5080", VA = "0x1807D5E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700070F")]
	public ShopDef.ViewerLoopType viewerLoopType
	{
		[Token(Token = "0x6003771")]
		[Address(RVA = "0x7D64C0", Offset = "0x7D56C0", VA = "0x1807D64C0")]
		get
		{
			return default(ShopDef.ViewerLoopType);
		}
	}

	[Token(Token = "0x17000710")]
	public bool hideSummonPlay
	{
		[Token(Token = "0x6003772")]
		[Address(RVA = "0x7D4DC0", Offset = "0x7D3FC0", VA = "0x1807D4DC0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000711")]
	public bool hideListPriceLabel
	{
		[Token(Token = "0x6003773")]
		[Address(RVA = "0x7D4D80", Offset = "0x7D3F80", VA = "0x1807D4D80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000712")]
	public bool isSoldOutSort
	{
		[Token(Token = "0x6003774")]
		[Address(RVA = "0x7D52D0", Offset = "0x7D44D0", VA = "0x1807D52D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000713")]
	public bool isShortPayAmountSort
	{
		[Token(Token = "0x6003775")]
		[Address(RVA = "0x7D5070", Offset = "0x7D4270", VA = "0x1807D5070")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6003761")]
	[Address(RVA = "0x7D1EF0", Offset = "0x7D10F0", VA = "0x1807D1EF0")]
	public bool FindBoolSetting(string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003762")]
	[Address(RVA = "0x7D21C0", Offset = "0x7D13C0", VA = "0x1807D21C0")]
	public int FindIntSetting(string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6003763")]
	[Address(RVA = "0x7D2430", Offset = "0x7D1630", VA = "0x1807D2430")]
	private string FindStringSetting(string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x6003776")]
	[Address(RVA = "0x7D3F40", Offset = "0x7D3140", VA = "0x1807D3F40")]
	private string TryMakeText(string textId, [Optional] List<object> args)
	{
		return null;
	}

	[Token(Token = "0x6003777")]
	[Address(RVA = "0x7D4020", Offset = "0x7D3220", VA = "0x1807D4020")]
	public ProductContext()
	{
	}

	[Token(Token = "0x6003778")]
	[Address(RVA = "0x7D41B0", Offset = "0x7D33B0", VA = "0x1807D41B0")]
	public ProductContext(ProductContext parent)
	{
	}

	[Token(Token = "0x6003779")]
	[Address(RVA = "0x7D29D0", Offset = "0x7D1BD0", VA = "0x1807D29D0")]
	public void Import(Dictionary<string, object> productData)
	{
	}

	[Token(Token = "0x600377A")]
	[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
	public void SetSectionId(int sectionId)
	{
	}

	[Token(Token = "0x600377B")]
	[Address(RVA = "0x7D1A10", Offset = "0x7D0C10", VA = "0x1807D1A10")]
	public int Compare(ProductContext a, ProductContext b)
	{
		return default(int);
	}

	[Token(Token = "0x600377C")]
	[Address(RVA = "0x7D1A00", Offset = "0x7D0C00", VA = "0x1807D1A00", Slot = "4")]
	public int CompareTo(ProductContext other)
	{
		return default(int);
	}

	[Token(Token = "0x600377D")]
	[Address(RVA = "0x7D3B10", Offset = "0x7D2D10", VA = "0x1807D3B10")]
	private bool IsItemProduct()
	{
		return default(bool);
	}

	[Token(Token = "0x600377E")]
	[Address(RVA = "0x7D26E0", Offset = "0x7D18E0", VA = "0x1807D26E0")]
	public string GetPushMessage(bool isDetail = false)
	{
		return null;
	}

	[Token(Token = "0x600377F")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "12")]
	public virtual string GetOwnedText()
	{
		return null;
	}

	[Token(Token = "0x6003780")]
	[Address(RVA = "0x7D3B80", Offset = "0x7D2D80", VA = "0x1807D3B80")]
	public int SearchContainItemId(bool isPeriod, int itemCategory)
	{
		return default(int);
	}

	[Token(Token = "0x6003781")]
	[Address(RVA = "0x7D3C60", Offset = "0x7D2E60", VA = "0x1807D3C60")]
	public (int, int, int, int) SearchFieldSetItems()
	{
		return default((int, int, int, int));
	}
}
