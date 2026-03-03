using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.Shop;

[Token(Token = "0x2000928")]
public class ProductContextCollection : List<ProductContext>
{
	[Token(Token = "0x4008A05")]
	[FieldOffset(Offset = "0x28")]
	public readonly ShopSettings m_ShopSettings;

	[Token(Token = "0x4008A06")]
	[FieldOffset(Offset = "0x30")]
	public readonly CardCategoryData m_CardCategoryData;

	[Token(Token = "0x4008A07")]
	[FieldOffset(Offset = "0x38")]
	public readonly int categoryId;

	[Token(Token = "0x4008A08")]
	[FieldOffset(Offset = "0x3C")]
	public readonly ShopDef.ShowcaseCategory category;

	[Token(Token = "0x4008A09")]
	[FieldOffset(Offset = "0x40")]
	public readonly List<ProductContext> m_ImportedContexts;

	[Token(Token = "0x4008A0A")]
	[FieldOffset(Offset = "0x48")]
	private readonly List<int> m_ImportedSubCategories;

	[Token(Token = "0x17000714")]
	public string filterProductName
	{
		[Token(Token = "0x6003782")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6003783")]
		[Address(RVA = "0x580760", Offset = "0x57F960", VA = "0x180580760")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000715")]
	public List<int> subCategories
	{
		[Token(Token = "0x6003784")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000716")]
	public IReadOnlyList<ProductContext> importedContexts
	{
		[Token(Token = "0x6003785")]
		[Address(RVA = "0x7D1830", Offset = "0x7D0A30", VA = "0x1807D1830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400003A")]
	public event Action onUpdatedEvent
	{
		[Token(Token = "0x6003786")]
		[Address(RVA = "0x7D1790", Offset = "0x7D0990", VA = "0x1807D1790")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6003787")]
		[Address(RVA = "0x7D1960", Offset = "0x7D0B60", VA = "0x1807D1960")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6003788")]
	[Address(RVA = "0x7D0F00", Offset = "0x7D0100", VA = "0x1807D0F00")]
	public bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6003789")]
	[Address(RVA = "0x7D1660", Offset = "0x7D0860", VA = "0x1807D1660")]
	public ProductContextCollection(ShopDef.ShowcaseCategory category, ShopSettings shopSettings, CardCategoryData cardCategoryData)
	{
	}

	[Token(Token = "0x600378A")]
	[Address(RVA = "0x7D0AB0", Offset = "0x7CFCB0", VA = "0x1807D0AB0")]
	public void Import(Dictionary<string, object> productDatas)
	{
	}

	[Token(Token = "0x600378B")]
	[Address(RVA = "0x7D0790", Offset = "0x7CF990", VA = "0x1807D0790")]
	public void Filter()
	{
	}

	[Token(Token = "0x600378C")]
	[Address(RVA = "0x7D1120", Offset = "0x7D0320", VA = "0x1807D1120")]
	private static int SortAsPack(ProductContext a, ProductContext b)
	{
		return default(int);
	}

	[Token(Token = "0x600378D")]
	[Address(RVA = "0x7D0F50", Offset = "0x7D0150", VA = "0x1807D0F50")]
	private static int SortAsStructure(ProductContext a, ProductContext b)
	{
		return default(int);
	}

	[Token(Token = "0x600378E")]
	[Address(RVA = "0x7D0F50", Offset = "0x7D0150", VA = "0x1807D0F50")]
	private static int SortAsAccessory(ProductContext a, ProductContext b)
	{
		return default(int);
	}

	[Token(Token = "0x600378F")]
	[Address(RVA = "0x7D1410", Offset = "0x7D0610", VA = "0x1807D1410")]
	private static int SortAsSpecial(ProductContext a, ProductContext b)
	{
		return default(int);
	}
}
