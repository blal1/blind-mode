using System;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomGame.Shop;

[Serializable]
[Token(Token = "0x200092D")]
public class ShopSubCategorySectionData : ShopProductGroupData
{
	[Token(Token = "0x4008A1C")]
	[FieldOffset(Offset = "0x48")]
	public ItemUtil.Category itemCategory;

	[Token(Token = "0x17000723")]
	public override string labelText
	{
		[Token(Token = "0x60037A9")]
		[Address(RVA = "0x7DF3C0", Offset = "0x7DE5C0", VA = "0x1807DF3C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037AA")]
	[Address(RVA = "0x7DF390", Offset = "0x7DE590", VA = "0x1807DF390", Slot = "15")]
	public override bool IsMatchProduct(ProductContext product)
	{
		return default(bool);
	}

	[Token(Token = "0x60037AB")]
	[Address(RVA = "0x7DCF70", Offset = "0x7DC170", VA = "0x1807DCF70")]
	public ShopSubCategorySectionData()
	{
	}
}
