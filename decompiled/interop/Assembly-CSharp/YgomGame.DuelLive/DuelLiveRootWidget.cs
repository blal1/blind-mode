using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F33")]
public class DuelLiveRootWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F34")]
	public class Context
	{
		[Token(Token = "0x400A6AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly DuelLiveSettings duelLiveSettings;

		[Token(Token = "0x400A6B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<ProductContextCollection<DuelLiveProductContext>> productCollections;

		[Token(Token = "0x6005C43")]
		[Address(RVA = "0xA19C70", Offset = "0xA18E70", VA = "0x180A19C70")]
		public Context(DuelLiveSettings duelLiveSettings)
		{
		}

		[Token(Token = "0x6005C44")]
		[Address(RVA = "0xA19A50", Offset = "0xA18C50", VA = "0x180A19A50")]
		public void ImportAll()
		{
		}
	}

	[Token(Token = "0x400A6A9")]
	private const string k_ELabelMonsterImage = "MonsterImage";

	[Token(Token = "0x400A6AA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly ProductShowcaseWidget productShowcase;

	[Token(Token = "0x400A6AB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	public Dictionary<(int, int, int), bool> badgetMap;

	[Token(Token = "0x400A6AC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Context m_Context;

	[Token(Token = "0x400A6AD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	public bool isPopWallPaper;

	[Token(Token = "0x400A6AE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private List<List<IProductContext>> m_SubProductsTmpList;

	[Token(Token = "0x17000E68")]
	public Context context
	{
		[Token(Token = "0x6005C1F")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E69")]
	public int currentMainTabIdx
	{
		[Token(Token = "0x6005C20")]
		[Address(RVA = "0xA1D5A0", Offset = "0xA1C7A0", VA = "0x180A1D5A0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E6A")]
	public int currentSubTabIdx
	{
		[Token(Token = "0x6005C21")]
		[Address(RVA = "0xA1D670", Offset = "0xA1C870", VA = "0x180A1D670")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E6B")]
	public int currentSubTabSectionIdx
	{
		[Token(Token = "0x6005C22")]
		[Address(RVA = "0xA1D820", Offset = "0xA1CA20", VA = "0x180A1D820")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E6C")]
	public ProductShowcaseWidget currentShowcase
	{
		[Token(Token = "0x6005C23")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6D")]
	public MainTabWidget currentMainTab
	{
		[Token(Token = "0x6005C24")]
		[Address(RVA = "0x571A60", Offset = "0x570C60", VA = "0x180571A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6E")]
	public SubTabListWidget currentSubTabListWidget
	{
		[Token(Token = "0x6005C25")]
		[Address(RVA = "0x697FB0", Offset = "0x6971B0", VA = "0x180697FB0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E6F")]
	public AccordionTabGroupWidget currentAccordionTabWidget
	{
		[Token(Token = "0x6005C26")]
		[Address(RVA = "0xA1D4C0", Offset = "0xA1C6C0", VA = "0x180A1D4C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E70")]
	public ProductListWidget currentProductList
	{
		[Token(Token = "0x6005C27")]
		[Address(RVA = "0xA1D630", Offset = "0xA1C830", VA = "0x180A1D630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E71")]
	public ProductShowcaseWidget.Context currentShowcaseCtx
	{
		[Token(Token = "0x6005C28")]
		[Address(RVA = "0xA1D650", Offset = "0xA1C850", VA = "0x180A1D650")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E72")]
	public ProductListWidget.Context currentProductListCtx
	{
		[Token(Token = "0x6005C29")]
		[Address(RVA = "0xA1D600", Offset = "0xA1C800", VA = "0x180A1D600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E73")]
	public List<MainTabWidget.TabContext> currentMainTabListCtx
	{
		[Token(Token = "0x6005C2A")]
		[Address(RVA = "0xA1D5D0", Offset = "0xA1C7D0", VA = "0x180A1D5D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E74")]
	public MainTabWidget.TabContext currentMainTabCtx
	{
		[Token(Token = "0x6005C2B")]
		[Address(RVA = "0xA1D4F0", Offset = "0xA1C6F0", VA = "0x180A1D4F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E75")]
	public List<SubTabListWidget.TabContext> currentSubTabListCtxs
	{
		[Token(Token = "0x6005C2C")]
		[Address(RVA = "0xA1D750", Offset = "0xA1C950", VA = "0x180A1D750")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E76")]
	public SubTabListWidget.TabContext currentSubTabListCtx
	{
		[Token(Token = "0x6005C2D")]
		[Address(RVA = "0xA1D6A0", Offset = "0xA1C8A0", VA = "0x180A1D6A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E77")]
	public int currentSubTabSectionLength
	{
		[Token(Token = "0x6005C2E")]
		[Address(RVA = "0xA1D850", Offset = "0xA1CA50", VA = "0x180A1D850")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E78")]
	public DuelLiveWCSData wcsData
	{
		[Token(Token = "0x6005C2F")]
		[Address(RVA = "0xA1D930", Offset = "0xA1CB30", VA = "0x180A1D930")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E79")]
	public List<DuelLiveCardPackData> cardPackDataList
	{
		[Token(Token = "0x6005C30")]
		[Address(RVA = "0xA1D470", Offset = "0xA1C670", VA = "0x180A1D470")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E7A")]
	public DuelLiveShopData shopData
	{
		[Token(Token = "0x6005C31")]
		[Address(RVA = "0xA1D8E0", Offset = "0xA1CAE0", VA = "0x180A1D8E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005C32")]
	[Address(RVA = "0xA1AF50", Offset = "0xA1A150", VA = "0x180A1AF50")]
	public int GetSectionIdxByProduct(IProductContext product)
	{
		return default(int);
	}

	[Token(Token = "0x6005C33")]
	[Address(RVA = "0xA1D390", Offset = "0xA1C590", VA = "0x180A1D390")]
	public DuelLiveRootWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6005C34")]
	[Address(RVA = "0x4130D0", Offset = "0x4122D0", VA = "0x1804130D0")]
	public void InitContext(Context context)
	{
	}

	[Token(Token = "0x6005C35")]
	[Address(RVA = "0xA1B210", Offset = "0xA1A410", VA = "0x180A1B210")]
	public void InitData()
	{
	}

	[Token(Token = "0x6005C36")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6005C37")]
	[Address(RVA = "0xA1B320", Offset = "0xA1A520", VA = "0x180A1B320")]
	private void InitProductGruopData()
	{
	}

	[Token(Token = "0x6005C38")]
	[Address(RVA = "0xA1B140", Offset = "0xA1A340", VA = "0x180A1B140")]
	private void InitBGImage()
	{
	}

	[Token(Token = "0x6005C39")]
	[Address(RVA = "0xA1B2F0", Offset = "0xA1A4F0", VA = "0x180A1B2F0")]
	public void InitMainCategoryTab()
	{
	}

	[Token(Token = "0x6005C3A")]
	[Address(RVA = "0xA1BC10", Offset = "0xA1AE10", VA = "0x180A1BC10")]
	public void InitSubCategoryTab()
	{
	}

	[Token(Token = "0x6005C3B")]
	[Address(RVA = "0xA1BA50", Offset = "0xA1AC50", VA = "0x180A1BA50")]
	public void InitProduct(Action onComplete)
	{
	}

	[Token(Token = "0x6005C3C")]
	[Address(RVA = "0xA1BF50", Offset = "0xA1B150", VA = "0x180A1BF50")]
	public void UpdateProductContexts()
	{
	}

	[Token(Token = "0x6005C3D")]
	[Address(RVA = "0xA1D150", Offset = "0xA1C350", VA = "0x180A1D150")]
	public void UpdateShowcase(int asyncCnt = 0, bool resetPos = true, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6005C3E")]
	[Address(RVA = "0xA1D060", Offset = "0xA1C260", VA = "0x180A1D060")]
	public void UpdateProductList(int asyncCnt = 0, bool resetPos = true, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6005C3F")]
	[Address(RVA = "0xA1D2D0", Offset = "0xA1C4D0", VA = "0x180A1D2D0")]
	public void UpdateSubTabList()
	{
	}

	[Token(Token = "0x6005C40")]
	[Address(RVA = "0xA1BEE0", Offset = "0xA1B0E0", VA = "0x180A1BEE0")]
	public void UpdateBadge()
	{
	}

	[Token(Token = "0x6005C41")]
	[Address(RVA = "0xA1D030", Offset = "0xA1C230", VA = "0x180A1D030")]
	public void UpdateProductListPadding()
	{
	}

	[Token(Token = "0x6005C42")]
	[Address(RVA = "0xA1BC80", Offset = "0xA1AE80", VA = "0x180A1BC80")]
	public void SetVisitTab(int mainIdx = -1, int subIdx = -1, int secIdx = -1)
	{
	}
}
