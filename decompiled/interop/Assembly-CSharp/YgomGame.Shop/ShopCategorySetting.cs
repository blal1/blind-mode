using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Shop;

[Token(Token = "0x2000931")]
public class ShopCategorySetting : ScriptableObject
{
	[Token(Token = "0x4008A1E")]
	[FieldOffset(Offset = "0x18")]
	[SerializeField]
	private ShopCategoryShowcaseData m_ShowcaseData;

	[Token(Token = "0x17000726")]
	public ShopCategoryShowcaseData showcaseData
	{
		[Token(Token = "0x60037B4")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60037B5")]
	[Address(RVA = "0x7DBC90", Offset = "0x7DAE90", VA = "0x1807DBC90")]
	public ShopCategoryData GetCategoryData(int categoryId)
	{
		return null;
	}

	[Token(Token = "0x60037B6")]
	[Address(RVA = "0x3D4F30", Offset = "0x3D4130", VA = "0x1803D4F30")]
	public ShopCategorySetting()
	{
	}
}
