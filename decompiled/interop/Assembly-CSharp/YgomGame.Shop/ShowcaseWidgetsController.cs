using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Token(Token = "0x2000940")]
public class ShowcaseWidgetsController
{
	[Token(Token = "0x2000941")]
	public enum SelectBlockOperate
	{
		[Token(Token = "0x4008A8C")]
		None,
		[Token(Token = "0x4008A8D")]
		CurrentBlock,
		[Token(Token = "0x4008A8E")]
		CurrentMainTab,
		[Token(Token = "0x4008A8F")]
		CurrentSubTabList,
		[Token(Token = "0x4008A90")]
		HeadProduct
	}

	[Token(Token = "0x2000942")]
	public enum AcordionOperate
	{
		[Token(Token = "0x4008A92")]
		None,
		[Token(Token = "0x4008A93")]
		Auto,
		[Token(Token = "0x4008A94")]
		Switch,
		[Token(Token = "0x4008A95")]
		Expand,
		[Token(Token = "0x4008A96")]
		Shrink
	}

	[Token(Token = "0x4008A83")]
	[FieldOffset(Offset = "0x10")]
	private readonly ShopViewController m_Owner;

	[Token(Token = "0x4008A84")]
	[FieldOffset(Offset = "0x18")]
	private readonly ShopSettings m_ShopSettings;

	[Token(Token = "0x4008A85")]
	[FieldOffset(Offset = "0x20")]
	private readonly ShopViewController.ShowcaseData m_ShowcaseData;

	[Token(Token = "0x4008A86")]
	[FieldOffset(Offset = "0x28")]
	private readonly MainTabListWidget m_MainTabList;

	[Token(Token = "0x4008A87")]
	[FieldOffset(Offset = "0x30")]
	private readonly SubTabListWidget m_SubTabList;

	[Token(Token = "0x4008A88")]
	[FieldOffset(Offset = "0x38")]
	private readonly ProductListWidget m_ProductList;

	[Token(Token = "0x4008A89")]
	[FieldOffset(Offset = "0x40")]
	private Dictionary<int, Dictionary<int, bool>> m_AutoAcordionShrinkMap;

	[Token(Token = "0x4008A8A")]
	[FieldOffset(Offset = "0x48")]
	private bool m_InProgress;

	[Token(Token = "0x17000753")]
	public bool inProgress
	{
		[Token(Token = "0x600381D")]
		[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600381C")]
	[Address(RVA = "0x597D70", Offset = "0x596F70", VA = "0x180597D70")]
	public ShowcaseWidgetsController(ShopViewController owner, ShopSettings shopSettings, ShopViewController.ShowcaseData showcaseData, MainTabListWidget mainTabList, SubTabListWidget subTabList, ProductListWidget productList)
	{
	}

	[Token(Token = "0x600381E")]
	[Address(RVA = "0x7E4460", Offset = "0x7E3660", VA = "0x1807E4460")]
	private bool IsAutoAcordionShrink(int categoryId, int subCategoryId)
	{
		return default(bool);
	}

	[Token(Token = "0x600381F")]
	[Address(RVA = "0x7E49C0", Offset = "0x7E3BC0", VA = "0x1807E49C0")]
	private void SetAutoAcordionShrink(int categoryId, int subCategoryId, bool value)
	{
	}

	[Token(Token = "0x6003820")]
	[Address(RVA = "0x7E49A0", Offset = "0x7E3BA0", VA = "0x1807E49A0")]
	public void PlayUnlockMarket(int shopId, int slotNo)
	{
	}

	[Token(Token = "0x6003821")]
	[Address(RVA = "0x7E3CA0", Offset = "0x7E2EA0", VA = "0x1807E3CA0")]
	public void ApplyAllImmediate()
	{
	}

	[Token(Token = "0x6003822")]
	[Address(RVA = "0x7E4560", Offset = "0x7E3760", VA = "0x1807E4560")]
	public bool MoveAllCategoryByResume(int categoryId, int subCategoryId, int sectionId)
	{
		return default(bool);
	}

	[Token(Token = "0x6003823")]
	[Address(RVA = "0x7E45A0", Offset = "0x7E37A0", VA = "0x1807E45A0")]
	public bool MoveByProductListScroll(int categoryId, int subCategoryId, int sectionId, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003824")]
	[Address(RVA = "0x7E45E0", Offset = "0x7E37E0", VA = "0x1807E45E0")]
	public bool MoveMainCategoryByTab(int categoryIdx, SelectBlockOperate selectBlock = SelectBlockOperate.HeadProduct, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003825")]
	[Address(RVA = "0x7E46C0", Offset = "0x7E38C0", VA = "0x1807E46C0")]
	public bool MoveSubCategoryByTab(int subCategoryIdx, int sectionIdx, AcordionOperate acordionOperate = AcordionOperate.None, SelectBlockOperate selectBlock = SelectBlockOperate.HeadProduct, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003826")]
	[Address(RVA = "0x7E3D80", Offset = "0x7E2F80", VA = "0x1807E3D80")]
	private bool InnerChangeCategories(int categoryId, int subCategoryId, int sectionId, AcordionOperate acordionOperate, SelectBlockOperate selectBlockOperate, bool focusProductList, bool immediate, bool isInitializeSelect = false, ShopViewController.ShowcaseData.IdFlag forceUpdateDataCountFlags = ShopViewController.ShowcaseData.IdFlag.None)
	{
		return default(bool);
	}

	[Token(Token = "0x6003827")]
	[Address(RVA = "0x7E47A0", Offset = "0x7E39A0", VA = "0x1807E47A0")]
	public void OperateTargetAcordion((int categoryId, int subCategoryId, int sectionId) targetIds, AcordionOperate acordionOperate)
	{
	}

	[Token(Token = "0x6003828")]
	[Address(RVA = "0x7E3CF0", Offset = "0x7E2EF0", VA = "0x1807E3CF0")]
	private void FocusProductListImmediate()
	{
	}

	[Token(Token = "0x6003829")]
	[Address(RVA = "0x7E4E00", Offset = "0x7E4000", VA = "0x1807E4E00")]
	public void UpdateBgView()
	{
	}

	[Token(Token = "0x600382A")]
	[Address(RVA = "0x7E4B50", Offset = "0x7E3D50", VA = "0x1807E4B50")]
	public bool TrySelectBlock(SelectBlockOperate selectBlockOperate, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600382B")]
	[Address(RVA = "0x7E4D90", Offset = "0x7E3F90", VA = "0x1807E4D90")]
	private bool TrySelectHeadProduct(bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600382C")]
	[Address(RVA = "0x7E4D50", Offset = "0x7E3F50", VA = "0x1807E4D50")]
	private bool TrySelectCurrentSubTab(bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600382D")]
	[Address(RVA = "0x7E4DE0", Offset = "0x7E3FE0", VA = "0x1807E4DE0")]
	private bool TrySelectMainTab(bool isInitializeSelect = false)
	{
		return default(bool);
	}
}
