using System;
using Il2CppDummyDll;

namespace YgomGame.Shop;

[Serializable]
[Token(Token = "0x200092F")]
public class ShopCategoryData : ShopProductGroupTreeData<ShopSubCategoryData>
{
	[Token(Token = "0x17000725")]
	public ShopDef.ShowcaseCategory category
	{
		[Token(Token = "0x60037B0")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(ShopDef.ShowcaseCategory);
		}
	}

	[Token(Token = "0x60037B1")]
	[Address(RVA = "0x7DBBF0", Offset = "0x7DADF0", VA = "0x1807DBBF0", Slot = "15")]
	public override bool IsMatchProduct(ProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x60037B2")]
	[Address(RVA = "0x7DBC50", Offset = "0x7DAE50", VA = "0x1807DBC50")]
	public ShopCategoryData()
	{
	}
}
