using System;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Shop;

[Serializable]
[Token(Token = "0x200092E")]
public class ShopSubCategoryData : ShopProductGroupTreeData<ShopSubCategorySectionData>
{
	[Token(Token = "0x4008A1D")]
	[FieldOffset(Offset = "0x58")]
	public ItemUtil.Category itemCategory;

	[Token(Token = "0x17000724")]
	public override string labelText
	{
		[Token(Token = "0x60037AC")]
		[Address(RVA = "0x7DF2B0", Offset = "0x7DE4B0", VA = "0x1807DF2B0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037AD")]
	[Address(RVA = "0x7DF160", Offset = "0x7DE360", VA = "0x1807DF160")]
	public string GetProductLabel(ProductContext product)
	{
		return null;
	}

	[Token(Token = "0x60037AE")]
	[Address(RVA = "0x7DF210", Offset = "0x7DE410", VA = "0x1807DF210", Slot = "15")]
	public override bool IsMatchProduct(ProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x60037AF")]
	[Address(RVA = "0x7DF270", Offset = "0x7DE470", VA = "0x1807DF270")]
	public ShopSubCategoryData()
	{
	}
}
