using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x200093E")]
public class ShopSettings : ScriptableObject
{
	[Token(Token = "0x4008A67")]
	internal const string k_Path = "Definition/Shop/ShopSettings";

	[Token(Token = "0x4008A68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ShopCategorySetting m_CategorySetting;

	[Token(Token = "0x4008A69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private ShopProductTypeSetting m_ProductTypeSetting;

	[Token(Token = "0x4008A6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private ShopProductWorkSetting m_ProductWorkSetting;

	[Token(Token = "0x4008A6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private ShopInformButtonSettings m_ShopInformButtonSettings;

	[Token(Token = "0x4008A6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private int m_ShowcaseUnloadUnusedCnt;

	[Token(Token = "0x4008A6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	[SerializeField]
	private string m_BuyRouteSchemeOpenSelectSE;

	[Token(Token = "0x17000747")]
	public ShopProductTypeSetting productTypeSetting
	{
		[Token(Token = "0x60037ED")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000748")]
	public ShopProductWorkSetting productWorkSetting
	{
		[Token(Token = "0x60037EE")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000749")]
	public int showcaseUnloadUnusedCnt
	{
		[Token(Token = "0x60037EF")]
		[Address(RVA = "0x40C450", Offset = "0x40B650", VA = "0x18040C450")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700074A")]
	public string buyRouteSchemeOpenSelectSE
	{
		[Token(Token = "0x60037F0")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037F1")]
	[Address(RVA = "0x7DEEB0", Offset = "0x7DE0B0", VA = "0x1807DEEB0")]
	public ShopCategoryShowcaseData GetShowcaseData()
	{
		return null;
	}

	[Token(Token = "0x60037F2")]
	[Address(RVA = "0x7DEDE0", Offset = "0x7DDFE0", VA = "0x1807DEDE0")]
	public ShopCategoryData GetCategoryData(int categoryId)
	{
		return null;
	}

	[Token(Token = "0x60037F3")]
	[Address(RVA = "0x7DEED0", Offset = "0x7DE0D0", VA = "0x1807DEED0")]
	public ShopSubCategoryData GetSubCategoryData(int categoryId, int subCategoryId)
	{
		return null;
	}

	[Token(Token = "0x60037F4")]
	[Address(RVA = "0x7DF020", Offset = "0x7DE220", VA = "0x1807DF020")]
	public ShopSubCategorySectionData GetSubCategorySectionData(int categoryId, int subCategoryId, ProductContext product)
	{
		return null;
	}

	[Token(Token = "0x60037F5")]
	[Address(RVA = "0x7DEF70", Offset = "0x7DE170", VA = "0x1807DEF70")]
	public ShopSubCategorySectionData GetSubCategorySectionData(int categoryId, int subCategoryId, int sectionId)
	{
		return null;
	}

	[Token(Token = "0x60037F6")]
	[Address(RVA = "0x7DE8D0", Offset = "0x7DDAD0", VA = "0x1807DE8D0")]
	public bool FindBoolSetting(int categoryId, int subCategoryId, ProductContext product, string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60037F7")]
	[Address(RVA = "0x7DE7D0", Offset = "0x7DD9D0", VA = "0x1807DE7D0")]
	public bool FindBoolSetting(int categoryId, int subCategoryId, int sectionId, string key, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60037F8")]
	[Address(RVA = "0x7DE9F0", Offset = "0x7DDBF0", VA = "0x1807DE9F0")]
	public int FindIntSetting(int categoryId, int subCategoryId, ProductContext product, string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60037F9")]
	[Address(RVA = "0x7DEA60", Offset = "0x7DDC60", VA = "0x1807DEA60")]
	public int FindIntSetting(int categoryId, int subCategoryId, int sectionId, string key, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60037FA")]
	[Address(RVA = "0x7DEBC0", Offset = "0x7DDDC0", VA = "0x1807DEBC0")]
	public string FindStringSetting(int categoryId, int subCategoryId, ProductContext product, string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60037FB")]
	[Address(RVA = "0x7DEC30", Offset = "0x7DDE30", VA = "0x1807DEC30")]
	public string FindStringSetting(int categoryId, int subCategoryId, int sectionId, string key, [Optional] string defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60037FC")]
	[Address(RVA = "0x7DEE40", Offset = "0x7DE040", VA = "0x1807DEE40")]
	public ShopInformButtonData[] GetProductInfoButtonDatas(ProductContext product)
	{
		return null;
	}

	[Token(Token = "0x60037FD")]
	[Address(RVA = "0x7DF100", Offset = "0x7DE300", VA = "0x1807DF100")]
	public ShopSettings()
	{
	}
}
