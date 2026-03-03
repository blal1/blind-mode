using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomGame.Menu;
using YgomSystem.Network;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.Utility;

namespace YgomGame.Shop;

[Token(Token = "0x2000943")]
public class ShopViewController : BaseMenuViewController, IMainTabListWidgetListener, IProductListWidgetListener, ISubTabListWidgetListener, IBackButtonWithoutSCSupported, IBackButtonSupported, IHeaderBorderSupported, IGemSupported, IShopProductContainVC
{
	[Token(Token = "0x2000944")]
	private class MainTabListWidgetHandler : IMainTabListWidgetHandler
	{
		[Token(Token = "0x4008AC2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ShowcaseData m_ShowcaseData;

		[Token(Token = "0x17000757")]
		public int currentIdx
		{
			[Token(Token = "0x600386B")]
			[Address(RVA = "0x7CF0E0", Offset = "0x7CE2E0", VA = "0x1807CF0E0", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x600386C")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public MainTabListWidgetHandler(ShowcaseData showcaseData)
		{
		}

		[Token(Token = "0x600386D")]
		[Address(RVA = "0x7CED80", Offset = "0x7CDF80", VA = "0x1807CED80")]
		private string CategoryIdToTemplateLabel(int categoryId)
		{
			return null;
		}

		[Token(Token = "0x600386E")]
		[Address(RVA = "0x7CEE20", Offset = "0x7CE020", VA = "0x1807CEE20", Slot = "4")]
		public void OnUpdateMainTabDataCount(List<string> tabTemplateLabels)
		{
		}

		[Token(Token = "0x600386F")]
		[Address(RVA = "0x7CEF30", Offset = "0x7CE130", VA = "0x1807CEF30", Slot = "5")]
		public void OnUpdateMainTabData(ShopTabWidget tabWidget, int dataIndex, string label)
		{
		}
	}

	[Token(Token = "0x2000945")]
	private class ProductListWidgetHandler : IProductListWidgetHandler, IProductContainerWidgetHandler
	{
		[Token(Token = "0x4008AC3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ProductListWidget m_ProductList;

		[Token(Token = "0x4008AC4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly ProductWidgetController m_ProductWidgetController;

		[Token(Token = "0x4008AC5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly ShowcaseData m_ShowcaseData;

		[Token(Token = "0x4008AC7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, Dictionary<int, List<ProductContext>>> m_SubProductsTmpList;

		[Token(Token = "0x4008AC8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private List<Vector2> m_SizeListCache;

		[Token(Token = "0x17000758")]
		public ProductWidgetController productWidgetController
		{
			[Token(Token = "0x6003870")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000759")]
		public int showcaseUnloadUnusedCnt
		{
			[Token(Token = "0x6003871")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "7")]
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[Token(Token = "0x6003872")]
			[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x6003873")]
		[Address(RVA = "0x7DA310", Offset = "0x7D9510", VA = "0x1807DA310")]
		public ProductListWidgetHandler(ProductListWidget productList, ProductWidgetController productWidgetController, ShowcaseData showcaseData)
		{
		}

		[Token(Token = "0x6003874")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		public void SetShowcaseUnloadUnusedCnt(int cnt)
		{
		}

		[Token(Token = "0x6003875")]
		[Address(RVA = "0x7D67D0", Offset = "0x7D59D0", VA = "0x1807D67D0", Slot = "4")]
		public bool EqualCurrentCategoryId(int chkCategoryId, int chkSubCategoryId, int chkSectionId)
		{
			return default(bool);
		}

		[Token(Token = "0x6003876")]
		[Address(RVA = "0x7D78E0", Offset = "0x7D6AE0", VA = "0x1807D78E0", Slot = "5")]
		public void OnUpdateDataCount(List<int> templateIdxList, List<ProductGroupHeaderWidget.Context> headerCtxs, Dictionary<int, Dictionary<int, Dictionary<int, int>>> headerDataIdxMap, List<ProductContainerWidget.Context> productContainerCtxs)
		{
		}

		[Token(Token = "0x6003877")]
		[Address(RVA = "0x7D69C0", Offset = "0x7D5BC0", VA = "0x1807D69C0")]
		private void InsertListLabel(string label, int categoryId, int subCategoryId, int sectionId, List<ProductContext> firstProducts, List<int> templateIdxList, List<ProductGroupHeaderWidget.Context> headerCtxs, Dictionary<int, Dictionary<int, Dictionary<int, int>>> headerDataIdxMap, List<ProductContainerWidget.Context> productContainerCtxs)
		{
		}

		[Token(Token = "0x6003878")]
		[Address(RVA = "0x7D6810", Offset = "0x7D5A10", VA = "0x1807D6810")]
		private void InsertListEmpty(List<int> templateIdxList, List<ProductGroupHeaderWidget.Context> headerCtxs, List<ProductContainerWidget.Context> productContainerCtxs)
		{
		}

		[Token(Token = "0x6003879")]
		[Address(RVA = "0x7D7260", Offset = "0x7D6460", VA = "0x1807D7260")]
		private void InsertProducts(List<ProductContext> products, List<int> templateIdxList, List<ProductGroupHeaderWidget.Context> headerCtxs, List<ProductContainerWidget.Context> productContainerCtxs, bool wrapAround = false)
		{
		}

		[Token(Token = "0x600387A")]
		[Address(RVA = "0x7D6E70", Offset = "0x7D6070", VA = "0x1807D6E70")]
		private void InsertProducts_Market(ProductContext marketProduct, List<int> templateIdxList, List<ProductGroupHeaderWidget.Context> headerCtxs, List<ProductContainerWidget.Context> productContainerCtxs)
		{
		}

		[Token(Token = "0x600387B")]
		[Address(RVA = "0x7D7800", Offset = "0x7D6A00", VA = "0x1807D7800", Slot = "8")]
		public void OnClickContentRootButton(ProductContext rootContext)
		{
		}

		[Token(Token = "0x600387C")]
		[Address(RVA = "0x7D8A20", Offset = "0x7D7C20", VA = "0x1807D8A20", Slot = "9")]
		public void UpdateProductWidget(ProductWidget productWidget, ProductContext productCtx)
		{
		}
	}

	[Token(Token = "0x2000947")]
	public class ShowcaseData
	{
		[Token(Token = "0x2000948")]
		public enum IdType
		{
			[Token(Token = "0x4008ADD")]
			None,
			[Token(Token = "0x4008ADE")]
			CategoryId,
			[Token(Token = "0x4008ADF")]
			SubCategoryId,
			[Token(Token = "0x4008AE0")]
			SectionId
		}

		[Token(Token = "0x2000949")]
		public enum IdFlag
		{
			[Token(Token = "0x4008AE2")]
			None = 0,
			[Token(Token = "0x4008AE3")]
			CategoryId = 2,
			[Token(Token = "0x4008AE4")]
			SubCategoryId = 4,
			[Token(Token = "0x4008AE5")]
			SectionId = 8
		}

		[Token(Token = "0x4008ACB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly Dictionary<ShopDef.ShowcaseCategory, ProductContextCollection> m_ProductCollectionMap;

		[Token(Token = "0x4008ACC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private readonly Dictionary<int, ProductContext> m_ProductContextMap;

		[Token(Token = "0x4008ACD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private readonly List<int> m_CategoryIds;

		[Token(Token = "0x4008ACE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private readonly Dictionary<int, IShopProductGruopData> m_CategoryDatas;

		[Token(Token = "0x4008ACF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private readonly Dictionary<int, List<int>> m_SubCategoryIds;

		[Token(Token = "0x4008AD0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private readonly Dictionary<int, Dictionary<int, IShopProductGruopData>> m_SubCategoryDatas;

		[Token(Token = "0x4008AD1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private readonly Dictionary<int, Dictionary<int, List<int>>> m_SectionIds;

		[Token(Token = "0x4008AD2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private readonly Dictionary<int, Dictionary<int, Dictionary<int, IShopProductGruopData>>> m_SectionDatas;

		[Token(Token = "0x4008AD3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private ShopSettings m_ShopSettings;

		[Token(Token = "0x4008AD4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private CardCategoryData m_CardCategoryData;

		[Token(Token = "0x4008AD5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private Dictionary<int, bool> m_TurnoffBadgeMap;

		[Token(Token = "0x4008AD6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private int m_CurrentCategoryId;

		[Token(Token = "0x4008AD7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C")]
		private int m_CurrentSubCategoryId;

		[Token(Token = "0x4008AD8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private int m_CurrentSectionId;

		[Token(Token = "0x4008AD9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private int m_CurrentCategoryIdx;

		[Token(Token = "0x4008ADA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_CurrentSubCategoryIdx;

		[Token(Token = "0x4008ADB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C")]
		private int m_CurrentSectionIdx;

		[Token(Token = "0x1700075A")]
		public ShopSettings shopSettings
		{
			[Token(Token = "0x600387F")]
			[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075B")]
		public CardCategoryData cardCategoryData
		{
			[Token(Token = "0x6003880")]
			[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075C")]
		public List<int> categoryIds
		{
			[Token(Token = "0x6003881")]
			[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700075D")]
		public int currentCategoryId
		{
			[Token(Token = "0x6003882")]
			[Address(RVA = "0x6A9360", Offset = "0x6A8560", VA = "0x1806A9360")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700075E")]
		public int currentSubCategoryId
		{
			[Token(Token = "0x6003883")]
			[Address(RVA = "0x803CD0", Offset = "0x802ED0", VA = "0x180803CD0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700075F")]
		public int currentSectionId
		{
			[Token(Token = "0x6003884")]
			[Address(RVA = "0x803CC0", Offset = "0x802EC0", VA = "0x180803CC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000760")]
		public int currentCategoryIdx
		{
			[Token(Token = "0x6003885")]
			[Address(RVA = "0x3EC970", Offset = "0x3EBB70", VA = "0x1803EC970")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000761")]
		public int currentSubCategoryIdx
		{
			[Token(Token = "0x6003886")]
			[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000762")]
		public int currentSectionIdx
		{
			[Token(Token = "0x6003887")]
			[Address(RVA = "0x55E5F0", Offset = "0x55D7F0", VA = "0x18055E5F0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x6003888")]
		[Address(RVA = "0x8018B0", Offset = "0x800AB0", VA = "0x1808018B0")]
		public ProductContext GetProductContext(int shopId, int slotNo = -1)
		{
			return null;
		}

		[Token(Token = "0x6003889")]
		[Address(RVA = "0x801840", Offset = "0x800A40", VA = "0x180801840")]
		public ProductContextCollection GetProductCollection(int categoryId)
		{
			return null;
		}

		[Token(Token = "0x600388A")]
		[Address(RVA = "0x801840", Offset = "0x800A40", VA = "0x180801840")]
		public ProductContextCollection GetProductCollection(ShopDef.ShowcaseCategory productCategory)
		{
			return null;
		}

		[Token(Token = "0x600388B")]
		[Address(RVA = "0x801340", Offset = "0x800540", VA = "0x180801340")]
		public IdFlag DiffCurrentIds(int categoryId, int subCategoryId, int sectionId)
		{
			return default(IdFlag);
		}

		[Token(Token = "0x600388C")]
		[Address(RVA = "0x8017D0", Offset = "0x8009D0", VA = "0x1808017D0")]
		public (int, int, int) GetCurrentIds()
		{
			return default((int, int, int));
		}

		[Token(Token = "0x600388D")]
		[Address(RVA = "0x8016F0", Offset = "0x8008F0", VA = "0x1808016F0")]
		public int GetCategoriesLength()
		{
			return default(int);
		}

		[Token(Token = "0x600388E")]
		[Address(RVA = "0x801740", Offset = "0x800940", VA = "0x180801740")]
		public IShopProductGruopData GetCategoryData(int categoryId)
		{
			return null;
		}

		[Token(Token = "0x600388F")]
		[Address(RVA = "0x802110", Offset = "0x801310", VA = "0x180802110")]
		public List<int> GetSubcategories(int categoryId)
		{
			return null;
		}

		[Token(Token = "0x6003890")]
		[Address(RVA = "0x8020B0", Offset = "0x8012B0", VA = "0x1808020B0")]
		public int GetSubcategoriesLength(int categoryId)
		{
			return default(int);
		}

		[Token(Token = "0x6003891")]
		[Address(RVA = "0x801EB0", Offset = "0x8010B0", VA = "0x180801EB0")]
		public List<int> GetSections(int categoryId, int subCategoryId)
		{
			return null;
		}

		[Token(Token = "0x6003892")]
		[Address(RVA = "0x801E40", Offset = "0x801040", VA = "0x180801E40")]
		public int GetSectionsLength(int categoryId, int subCategoryId)
		{
			return default(int);
		}

		[Token(Token = "0x6003893")]
		[Address(RVA = "0x801FB0", Offset = "0x8011B0", VA = "0x180801FB0")]
		public IShopProductGruopData GetSubCategoryData(int categoryId, int subCategoryId)
		{
			return null;
		}

		[Token(Token = "0x6003894")]
		[Address(RVA = "0x801CB0", Offset = "0x800EB0", VA = "0x180801CB0")]
		public IShopProductGruopData GetSectionData(int categoryId, int subCategoryId, int sectionId)
		{
			return null;
		}

		[Token(Token = "0x6003895")]
		[Address(RVA = "0x801370", Offset = "0x800570", VA = "0x180801370")]
		public bool ExistsCategories(int categoryId, int subCategoryId = 0, int sectionId = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x6003896")]
		[Address(RVA = "0x801640", Offset = "0x800840", VA = "0x180801640")]
		public bool ExistsCategory(int categoryId)
		{
			return default(bool);
		}

		[Token(Token = "0x6003897")]
		[Address(RVA = "0x802B40", Offset = "0x801D40", VA = "0x180802B40")]
		public int IndexOfCategory(int categoryId)
		{
			return default(int);
		}

		[Token(Token = "0x6003898")]
		[Address(RVA = "0x800D20", Offset = "0x7FFF20", VA = "0x180800D20")]
		public int CategoryOfIndex(int categoryIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6003899")]
		[Address(RVA = "0x8016D0", Offset = "0x8008D0", VA = "0x1808016D0")]
		public bool ExistsSubCategory(int categoryId, int subCategoryId)
		{
			return default(bool);
		}

		[Token(Token = "0x600389A")]
		[Address(RVA = "0x802CD0", Offset = "0x801ED0", VA = "0x180802CD0")]
		public int IndexOfSubCategory(int categoryId, int subCategoryId)
		{
			return default(int);
		}

		[Token(Token = "0x600389B")]
		[Address(RVA = "0x803120", Offset = "0x802320", VA = "0x180803120")]
		public int SubCategoryOfIndex(int categoryIdx, int subCategoryIdx)
		{
			return default(int);
		}

		[Token(Token = "0x600389C")]
		[Address(RVA = "0x8016A0", Offset = "0x8008A0", VA = "0x1808016A0")]
		public bool ExistsSection(int categoryId, int subCategoryId, int sectionId)
		{
			return default(bool);
		}

		[Token(Token = "0x600389D")]
		[Address(RVA = "0x802BA0", Offset = "0x801DA0", VA = "0x180802BA0")]
		public int IndexOfSection(int categoryId, int subCategoryId, int sectionId)
		{
			return default(int);
		}

		[Token(Token = "0x600389E")]
		[Address(RVA = "0x802E70", Offset = "0x802070", VA = "0x180802E70")]
		public int SectionOfIndex(int categoryIdx, int subCategoryIdx, int sectionIdx)
		{
			return default(int);
		}

		[Token(Token = "0x600389F")]
		[Address(RVA = "0x8021A0", Offset = "0x8013A0", VA = "0x1808021A0")]
		public bool HasSection(int categoryId, int subCategoryId)
		{
			return default(bool);
		}

		[Token(Token = "0x60038A0")]
		[Address(RVA = "0x801420", Offset = "0x800620", VA = "0x180801420")]
		public bool ExistsCategoryBadge(int categoryId, int subCategoryId = 0, int sectionId = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60038A1")]
		[Address(RVA = "0x802D90", Offset = "0x801F90", VA = "0x180802D90")]
		public bool IsBadgeProduct(ProductContext productContext)
		{
			return default(bool);
		}

		[Token(Token = "0x60038A2")]
		[Address(RVA = "0x802DE0", Offset = "0x801FE0", VA = "0x180802DE0")]
		private bool IsTrunoff(int shopId)
		{
			return default(bool);
		}

		[Token(Token = "0x60038A3")]
		[Address(RVA = "0x801110", Offset = "0x800310", VA = "0x180801110")]
		public List<int> CreateVisitBadgeList()
		{
			return null;
		}

		[Token(Token = "0x60038A4")]
		[Address(RVA = "0x8034D0", Offset = "0x8026D0", VA = "0x1808034D0")]
		public string TryGetTabIconPath(int categoryId)
		{
			return null;
		}

		[Token(Token = "0x60038A5")]
		[Address(RVA = "0x803220", Offset = "0x802420", VA = "0x180803220")]
		private int TryGetMarketSlotCount()
		{
			return default(int);
		}

		[Token(Token = "0x60038A6")]
		[Address(RVA = "0x803020", Offset = "0x802220", VA = "0x180803020")]
		public void SetCurrentId(int categoryId, int subCategoryId, int sectionId)
		{
		}

		[Token(Token = "0x60038A7")]
		[Address(RVA = "0x8022C0", Offset = "0x8014C0", VA = "0x1808022C0")]
		public void ImportAll(ShopSettings shopSettings, CardCategoryData cardCategoryData)
		{
		}

		[Token(Token = "0x60038A8")]
		[Address(RVA = "0x802A90", Offset = "0x801C90", VA = "0x180802A90")]
		public bool ImportAt(int shopId, int slotNo = -1)
		{
			return default(bool);
		}

		[Token(Token = "0x60038A9")]
		[Address(RVA = "0x800DA0", Offset = "0x7FFFA0", VA = "0x180800DA0")]
		private void ClearCategory()
		{
		}

		[Token(Token = "0x60038AA")]
		[Address(RVA = "0x800510", Offset = "0x7FF710", VA = "0x180800510")]
		private void AddCategory(IShopProductGruopData categoryData)
		{
		}

		[Token(Token = "0x60038AB")]
		[Address(RVA = "0x801000", Offset = "0x800200", VA = "0x180801000")]
		private void ClearSubCategory(int categoryId)
		{
		}

		[Token(Token = "0x60038AC")]
		[Address(RVA = "0x800A90", Offset = "0x7FFC90", VA = "0x180800A90")]
		private void AddSubCategory(int categoryId, IShopProductGruopData subCategoryData)
		{
		}

		[Token(Token = "0x60038AD")]
		[Address(RVA = "0x800E10", Offset = "0x800010", VA = "0x180800E10")]
		private void ClearSection(int categoryId, int subCategoryId)
		{
		}

		[Token(Token = "0x60038AE")]
		[Address(RVA = "0x800630", Offset = "0x7FF830", VA = "0x180800630")]
		private void AddSection(int categoryId, int subCategoryId, IShopProductGruopData sectionData)
		{
		}

		[Token(Token = "0x60038AF")]
		[Address(RVA = "0x8036F0", Offset = "0x8028F0", VA = "0x1808036F0")]
		public bool TurnoffCategoryBadges(ShopSettings shopSettings, int categoryId, int subCategoryId = 0, int sectionId = 0)
		{
			return default(bool);
		}

		[Token(Token = "0x60038B0")]
		[Address(RVA = "0x803A50", Offset = "0x802C50", VA = "0x180803A50")]
		public ShowcaseData()
		{
		}
	}

	[Token(Token = "0x200094A")]
	private class SubTabListWidgetHandler : ISubTabListWidgetHandler
	{
		[Token(Token = "0x4008AE6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private readonly ShowcaseData m_ShowcaseData;

		[Token(Token = "0x17000763")]
		public int currentIdx
		{
			[Token(Token = "0x60038B1")]
			[Address(RVA = "0x804CA0", Offset = "0x803EA0", VA = "0x180804CA0", Slot = "9")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000764")]
		public int currentSectionIdx
		{
			[Token(Token = "0x60038B2")]
			[Address(RVA = "0x804CC0", Offset = "0x803EC0", VA = "0x180804CC0", Slot = "10")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60038B3")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public SubTabListWidgetHandler(ShowcaseData showcaseData)
		{
		}

		[Token(Token = "0x60038B4")]
		[Address(RVA = "0x804660", Offset = "0x803860", VA = "0x180804660", Slot = "4")]
		public (int, int) CategoryIdOfIndex(int dataIdx)
		{
			return default((int, int));
		}

		[Token(Token = "0x60038B5")]
		[Address(RVA = "0x804A10", Offset = "0x803C10", VA = "0x180804A10", Slot = "5")]
		public void OnUpdateSubTabWidget(List<int> templateIds)
		{
		}

		[Token(Token = "0x60038B6")]
		[Address(RVA = "0x804B30", Offset = "0x803D30", VA = "0x180804B30", Slot = "6")]
		public void OnUpdateTabWidget(ShopTabWidget widget, int dataIdx)
		{
		}

		[Token(Token = "0x60038B7")]
		[Address(RVA = "0x804730", Offset = "0x803930", VA = "0x180804730", Slot = "7")]
		public void OnUpdateSectionFactory(ElementEntityFactory entityFactory, int dataIdx)
		{
		}

		[Token(Token = "0x60038B8")]
		[Address(RVA = "0x804820", Offset = "0x803A20", VA = "0x180804820", Slot = "8")]
		public void OnUpdateSectionTabWidget(ShopTabWidget widget, int dataIdx, int sectionIdx)
		{
		}
	}

	[Token(Token = "0x200094C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass102_0
	{
		[Token(Token = "0x4008AEC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool doneDialogMessage;

		[Token(Token = "0x60038BF")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass102_0()
		{
		}

		[Token(Token = "0x60038C0")]
		[Address(RVA = "0x807C40", Offset = "0x806E40", VA = "0x180807C40")]
		internal void _003CyPlayRefreshProducts_003Eb__0()
		{
		}
	}

	[Token(Token = "0x200094E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass87_0
	{
		[Token(Token = "0x4008AEF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public bool doneWebApi;

		[Token(Token = "0x4008AF0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public ShopViewController _003C_003E4__this;

		[Token(Token = "0x4008AF1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public bool doneInitShowcase;

		[Token(Token = "0x4008AF2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x21")]
		public bool doneApplyList;

		[Token(Token = "0x60038C3")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass87_0()
		{
		}

		[Token(Token = "0x60038C4")]
		[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890")]
		internal void _003CyInitialize_003Eb__0(Handle h)
		{
		}

		[Token(Token = "0x60038C5")]
		[Address(RVA = "0x8086A0", Offset = "0x8078A0", VA = "0x1808086A0")]
		internal void _003CyInitialize_003Eb__1(CardCategoryData res)
		{
		}

		[Token(Token = "0x60038C6")]
		[Address(RVA = "0x8086F0", Offset = "0x8078F0", VA = "0x1808086F0")]
		internal void _003CyInitialize_003Eb__2(ShopSettings shopSettings)
		{
		}

		[Token(Token = "0x60038C7")]
		[Address(RVA = "0x69EDD0", Offset = "0x69DFD0", VA = "0x18069EDD0")]
		internal void _003CyInitialize_003Eb__3()
		{
		}

		[Token(Token = "0x60038C8")]
		[Address(RVA = "0x69EDE0", Offset = "0x69DFE0", VA = "0x18069EDE0")]
		internal void _003CyInitialize_003Eb__4()
		{
		}
	}

	[Token(Token = "0x2000951")]
	[CompilerGenerated]
	private sealed class _003CyInitialize_003Ed__87 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008AFA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008AFB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008AFC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShopViewController _003C_003E4__this;

		[Token(Token = "0x4008AFD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass87_0 _003C_003E8__1;

		[Token(Token = "0x4008AFE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Action onComplete;

		[Token(Token = "0x4008AFF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ProductListWidgetHandler _003CproductListWidgetHandler_003E5__2;

		[Token(Token = "0x17000765")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60038D3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000766")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60038D5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60038D0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInitialize_003Ed__87(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60038D1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60038D2")]
		[Address(RVA = "0x808D80", Offset = "0x807F80", VA = "0x180808D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60038D4")]
		[Address(RVA = "0x809DE0", Offset = "0x808FE0", VA = "0x180809DE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000952")]
	[CompilerGenerated]
	private sealed class _003CyPlayRefreshProducts_003Ed__102 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4008B00")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4008B01")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4008B02")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ShopViewController _003C_003E4__this;

		[Token(Token = "0x4008B03")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass102_0 _003C_003E8__1;

		[Token(Token = "0x17000767")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60038D9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000768")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60038DB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60038D6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPlayRefreshProducts_003Ed__102(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60038D7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60038D8")]
		[Address(RVA = "0x809E20", Offset = "0x809020", VA = "0x180809E20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60038DA")]
		[Address(RVA = "0x80A350", Offset = "0x809550", VA = "0x18080A350", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4008A97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private bool m_IsStarted;

	[Token(Token = "0x4008A98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD1")]
	private bool m_ReimportDirty;

	[Token(Token = "0x4008A99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Selector m_ResumeSelector;

	[Token(Token = "0x4008A9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private int m_ResumeCategoryId;

	[Token(Token = "0x4008A9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private int m_ResumeSubcategoryId;

	[Token(Token = "0x4008A9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private int m_ResumeSectionId;

	[Token(Token = "0x4008A9D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xEC")]
	private int m_ResumeProductId;

	[Token(Token = "0x4008A9E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private string m_ResumeDialogTitle;

	[Token(Token = "0x4008A9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private string m_ResumeDialogMessage;

	[Token(Token = "0x4008AA0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool m_ResumeHandleRequireGetListReq;

	[Token(Token = "0x4008AA1")]
	private const string k_PrefPath = "Shop/Shop";

	[Token(Token = "0x4008AA2")]
	private const string k_ArgsSkipRequest = "skipRequest";

	[Token(Token = "0x4008AA3")]
	public const string k_ArgsLaunchCategory = "category";

	[Token(Token = "0x4008AA4")]
	public const string k_ArgsLaunchSubCategory = "subcategory";

	[Token(Token = "0x4008AA5")]
	public const string k_ArgsLaunchSection = "section";

	[Token(Token = "0x4008AA6")]
	internal const string K_ResultKey_HandleRequireGetListReq = "Shop_HandleRequireGetListReq";

	[Token(Token = "0x4008AA7")]
	internal const string K_ResultKey_RequireGetListDialog_Title = "Shop_RequireGetListDialog_Title";

	[Token(Token = "0x4008AA8")]
	internal const string K_ResultKey_RequireGetListDialog_Message = "Shop_RequireGetListDialog_Message";

	[Token(Token = "0x4008AA9")]
	private const string k_ALinkerLabel_BuyView = "BuyView";

	[Token(Token = "0x4008AAA")]
	private const string k_ALabelProductWidgetMap = "ProductWidgetMap";

	[Token(Token = "0x4008AAB")]
	private const string k_ELabelHeaderTicket = "HeaderTicket";

	[Token(Token = "0x4008AAC")]
	private const string k_ELabelMainTabs = "CategoryTabs";

	[Token(Token = "0x4008AAD")]
	private const string k_ELabelSubTabs = "ShowcaseWidget/SubTabs";

	[Token(Token = "0x4008AAE")]
	private const string k_ELabelProductList = "ShowcaseWidget";

	[Token(Token = "0x4008AAF")]
	private const string k_ELabelShortcutButtonBack = "ShortcutButtonBack";

	[Token(Token = "0x4008AB0")]
	private const string k_ELabelShortcutButtonCancel = "ShortcutButtonCancel";

	[Token(Token = "0x4008AB1")]
	private const string k_ELabelShortcutButtonL1 = "ShortcutButtonL1";

	[Token(Token = "0x4008AB2")]
	private const string k_ELabelShortcutButtonR1 = "ShortcutButtonR1";

	[Token(Token = "0x4008AB3")]
	private const string k_TLabel_OnRefreshProducts_Hide = "OnRefreshProducts_Hide";

	[Token(Token = "0x4008AB4")]
	private const string k_TLabel_OnRefreshProducts_Show = "OnRefreshProducts_Show";

	[Token(Token = "0x4008AB5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private ResourceCacheHolderContainer.Holder m_ResourceCacheHolder;

	[Token(Token = "0x4008AB6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private ShopSettings m_ShopSettings;

	[Token(Token = "0x4008AB7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private ShopHeaderTicketWidget m_HeaderTicket;

	[Token(Token = "0x4008AB8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private ProductWidgetController m_ProductWidgetController;

	[Token(Token = "0x4008AB9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private ShowcaseWidgetsController m_ShowcaseWidgetsController;

	[Token(Token = "0x4008ABA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private MainTabListWidget m_MainTabList;

	[Token(Token = "0x4008ABB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private SubTabListWidget m_SubTabList;

	[Token(Token = "0x4008ABC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
	private ProductListWidget m_ProductList;

	[Token(Token = "0x4008ABD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	private CardCategoryData m_CardCategoryData;

	[Token(Token = "0x4008ABE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private ShowcaseData m_ShowcaseData;

	[Token(Token = "0x4008ABF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private IEnumerator m_InitRoutine;

	[Token(Token = "0x4008AC0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
	private bool m_IsHighEnd;

	[Token(Token = "0x4008AC1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
	private List<ProductContext> m_BuyProductContexts;

	[Token(Token = "0x17000754")]
	protected override bool setProgressOnInitialize
	{
		[Token(Token = "0x600384A")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "18")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000755")]
	protected override bool setSurfaceActiveOnInitialize
	{
		[Token(Token = "0x600384B")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000756")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600384C")]
		[Address(RVA = "0x7E3930", Offset = "0x7E2B30", VA = "0x1807E3930", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600382E")]
	[Address(RVA = "0x7E11C0", Offset = "0x7E03C0", VA = "0x1807E11C0", Slot = "30")]
	public void OnInputUpMainTab()
	{
	}

	[Token(Token = "0x600382F")]
	[Address(RVA = "0x7E1060", Offset = "0x7E0260", VA = "0x1807E1060", Slot = "28")]
	public void OnInputLeftMainTab()
	{
	}

	[Token(Token = "0x6003830")]
	[Address(RVA = "0x7E10C0", Offset = "0x7E02C0", VA = "0x1807E10C0", Slot = "29")]
	public void OnInputRightMainTab()
	{
	}

	[Token(Token = "0x6003831")]
	[Address(RVA = "0x7E1010", Offset = "0x7E0210", VA = "0x1807E1010", Slot = "31")]
	public void OnInputDownMainTab()
	{
	}

	[Token(Token = "0x6003832")]
	[Address(RVA = "0x7E08B0", Offset = "0x7DFAB0", VA = "0x1807E08B0", Slot = "32")]
	public void OnClickMainTab(int idx)
	{
	}

	[Token(Token = "0x6003833")]
	[Address(RVA = "0x7E0680", Offset = "0x7DF880", VA = "0x1807E0680")]
	private void OnActivate()
	{
	}

	[Token(Token = "0x6003834")]
	[Address(RVA = "0x7E0080", Offset = "0x7DF280", VA = "0x1807E0080")]
	private void OnActivateInit()
	{
	}

	[Token(Token = "0x6003835")]
	[Address(RVA = "0x7E0240", Offset = "0x7DF440", VA = "0x1807E0240")]
	private void OnActivateResume()
	{
	}

	[Token(Token = "0x6003836")]
	[Address(RVA = "0x7E1F40", Offset = "0x7E1140", VA = "0x1807E1F40")]
	private void ResumeShowcase(bool focus = false)
	{
	}

	[Token(Token = "0x6003837")]
	[Address(RVA = "0x7E29B0", Offset = "0x7E1BB0", VA = "0x1807E29B0")]
	private bool TryResumeFocusProduct(bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003838")]
	[Address(RVA = "0x7E2770", Offset = "0x7E1970", VA = "0x1807E2770")]
	private bool TryResumeFocusHeadProduct(bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003839")]
	[Address(RVA = "0x7E2890", Offset = "0x7E1A90", VA = "0x1807E2890")]
	private bool TryResumeFocusHeader(bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600383A")]
	[Address(RVA = "0x7E2B10", Offset = "0x7E1D10", VA = "0x1807E2B10")]
	private bool TryResumeFocusSubTab(bool focus = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600383B")]
	[Address(RVA = "0x7E1DD0", Offset = "0x7E0FD0", VA = "0x1807E1DD0")]
	private void ResumeFocusMainTab(bool focus = false)
	{
	}

	[Token(Token = "0x600383C")]
	[Address(RVA = "0x7E1210", Offset = "0x7E0410", VA = "0x1807E1210")]
	private void OnPreDeactivate()
	{
	}

	[Token(Token = "0x600383D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnDeactivate()
	{
	}

	[Token(Token = "0x600383E")]
	[Address(RVA = "0x7E1470", Offset = "0x7E0670", VA = "0x1807E1470", Slot = "33")]
	public void OnProductListScrolled(Vector2 value)
	{
	}

	[Token(Token = "0x600383F")]
	[Address(RVA = "0x7E0EA0", Offset = "0x7E00A0", VA = "0x1807E0EA0", Slot = "34")]
	public void OnFocusProductLine(int categoryId, int subCategoryId, int sectionId)
	{
	}

	[Token(Token = "0x6003840")]
	[Address(RVA = "0x7E0A50", Offset = "0x7DFC50", VA = "0x1807E0A50", Slot = "35")]
	public void OnClickProduct(ProductWidget productWidget)
	{
	}

	[Token(Token = "0x6003841")]
	[Address(RVA = "0x7E1DA0", Offset = "0x7E0FA0", VA = "0x1807E1DA0")]
	public void ReleaseResourcesProductList()
	{
	}

	[Token(Token = "0x6003842")]
	[Address(RVA = "0x7E0EF0", Offset = "0x7E00F0", VA = "0x1807E0EF0", Slot = "36")]
	public bool OnInputDirectionSubCategory(PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x6003843")]
	[Address(RVA = "0x7DF3D0", Offset = "0x7DE5D0", VA = "0x1807DF3D0")]
	private bool CheckAcordionExpand()
	{
		return default(bool);
	}

	[Token(Token = "0x6003844")]
	[Address(RVA = "0x7E2D30", Offset = "0x7E1F30", VA = "0x1807E2D30")]
	private bool TrySelectProductList(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003845")]
	[Address(RVA = "0x7E2DC0", Offset = "0x7E1FC0", VA = "0x1807E2DC0")]
	private bool TryTransitionSection(int dir, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003846")]
	[Address(RVA = "0x7E2E20", Offset = "0x7E2020", VA = "0x1807E2E20")]
	private bool TryTransitionSubCategory(int dir, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003847")]
	[Address(RVA = "0x7E0D40", Offset = "0x7DFF40", VA = "0x1807E0D40", Slot = "37")]
	public void OnClickSubCategory(int dataIdx)
	{
	}

	[Token(Token = "0x6003848")]
	[Address(RVA = "0x7E0AC0", Offset = "0x7DFCC0", VA = "0x1807E0AC0", Slot = "38")]
	public void OnClickSubCategoryGroup(int dataIdx)
	{
	}

	[Token(Token = "0x6003849")]
	[Address(RVA = "0x7E0BD0", Offset = "0x7DFDD0", VA = "0x1807E0BD0", Slot = "39")]
	public void OnClickSubCategorySection(int dataIdx, int sectionIdx)
	{
	}

	[Token(Token = "0x600384D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "26")]
	protected override void OnTransitionSetBg(TransitionType type)
	{
	}

	[Token(Token = "0x600384E")]
	[Address(RVA = "0x7E1990", Offset = "0x7E0B90", VA = "0x1807E1990")]
	public static void OpenOnHome([Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x600384F")]
	[Address(RVA = "0x7E19D0", Offset = "0x7E0BD0", VA = "0x1807E19D0")]
	public static void OpenPush(bool onHome, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003850")]
	[Address(RVA = "0x7DF990", Offset = "0x7DEB90", VA = "0x1807DF990")]
	private static void InnerOpen(bool onHome, [Optional] Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003851")]
	[Address(RVA = "0x7DFA40", Offset = "0x7DEC40", VA = "0x1807DFA40", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6003852")]
	[Address(RVA = "0x7E1C40", Offset = "0x7E0E40", VA = "0x1807E1C40", Slot = "9")]
	public override float Progress()
	{
		return default(float);
	}

	[Token(Token = "0x6003853")]
	[Address(RVA = "0x7E1BE0", Offset = "0x7E0DE0", VA = "0x1807E1BE0", Slot = "10")]
	public override void ProgressUpdate()
	{
	}

	[Token(Token = "0x6003854")]
	[Address(RVA = "0x7E3BA0", Offset = "0x7E2DA0", VA = "0x1807E3BA0")]
	[IteratorStateMachine(typeof(_003CyInitialize_003Ed__87))]
	private IEnumerator yInitialize(Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6003855")]
	[Address(RVA = "0x7DF870", Offset = "0x7DEA70", VA = "0x1807DF870")]
	private void InitializeData()
	{
	}

	[Token(Token = "0x6003856")]
	[Address(RVA = "0x7E1900", Offset = "0x7E0B00", VA = "0x1807E1900", Slot = "24")]
	protected override void OnTransitionStart(TransitionType type)
	{
	}

	[Token(Token = "0x6003857")]
	[Address(RVA = "0x7E1880", Offset = "0x7E0A80", VA = "0x1807E1880", Slot = "25")]
	protected override void OnTransitionEnd(TransitionType type)
	{
	}

	[Token(Token = "0x6003858")]
	[Address(RVA = "0x7DF4F0", Offset = "0x7DE6F0", VA = "0x1807DF4F0")]
	private void CheckTutorialOpen(int step = 0)
	{
	}

	[Token(Token = "0x6003859")]
	[Address(RVA = "0x7E15C0", Offset = "0x7E07C0", VA = "0x1807E15C0", Slot = "14")]
	public override bool OnResult(ViewController from, object value)
	{
		return default(bool);
	}

	[Token(Token = "0x600385A")]
	[Address(RVA = "0x7E1DA0", Offset = "0x7E0FA0", VA = "0x1807E1DA0")]
	private void ReleaseResources()
	{
	}

	[Token(Token = "0x600385B")]
	[Address(RVA = "0x7E0E90", Offset = "0x7E0090", VA = "0x1807E0E90", Slot = "15")]
	public override void OnFocusChanged(bool setfocus)
	{
	}

	[Token(Token = "0x600385C")]
	[Address(RVA = "0x7DFD10", Offset = "0x7DEF10", VA = "0x1807DFD10", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600385D")]
	[Address(RVA = "0x7DF6F0", Offset = "0x7DE8F0", VA = "0x1807DF6F0", Slot = "40")]
	public bool ContainsProduct(int shopId, bool chkBuyAble = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600385E")]
	[Address(RVA = "0x7E32B0", Offset = "0x7E24B0", VA = "0x1807E32B0")]
	private void UpdateHeader()
	{
	}

	[Token(Token = "0x600385F")]
	[Address(RVA = "0x7E30F0", Offset = "0x7E22F0", VA = "0x1807E30F0")]
	private void UnlockMarket(ProductContext productContext)
	{
	}

	[Token(Token = "0x6003860")]
	[Address(RVA = "0x7E23B0", Offset = "0x7E15B0", VA = "0x1807E23B0")]
	private bool TryOpenShopBuy(ProductContext productContext)
	{
		return default(bool);
	}

	[Token(Token = "0x6003861")]
	[Address(RVA = "0x7DF7A0", Offset = "0x7DE9A0", VA = "0x1807DF7A0")]
	private bool HandleRequireGetList()
	{
		return default(bool);
	}

	[Token(Token = "0x6003862")]
	[Address(RVA = "0x7E3C30", Offset = "0x7E2E30", VA = "0x1807E3C30")]
	[IteratorStateMachine(typeof(_003CyPlayRefreshProducts_003Ed__102))]
	private IEnumerator yPlayRefreshProducts()
	{
		return null;
	}

	[Token(Token = "0x6003863")]
	[Address(RVA = "0x7E0E80", Offset = "0x7E0080", VA = "0x1807E0E80")]
	private void OnClickTicketHeader()
	{
	}

	[Token(Token = "0x6003864")]
	[Address(RVA = "0x7E1C60", Offset = "0x7E0E60", VA = "0x1807E1C60")]
	public void RefreshShortcuts()
	{
	}

	[Token(Token = "0x6003865")]
	[Address(RVA = "0x7E1120", Offset = "0x7E0320", VA = "0x1807E1120")]
	private void OnInputShortcutL1()
	{
	}

	[Token(Token = "0x6003866")]
	[Address(RVA = "0x7E1170", Offset = "0x7E0370", VA = "0x1807E1170")]
	private void OnInputShortcutR1()
	{
	}

	[Token(Token = "0x6003867")]
	[Address(RVA = "0x7E3870", Offset = "0x7E2A70", VA = "0x1807E3870")]
	public ShopViewController()
	{
	}
}
