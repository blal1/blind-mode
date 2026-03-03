using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Utility;

namespace YgomGame.Shop;

[Token(Token = "0x200093F")]
public class ProductWidgetController
{
	[Token(Token = "0x4008A6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private readonly AssetContainer m_ProductWidgetContainer;

	[Token(Token = "0x4008A6F")]
	internal const string k_MapLabel_ProductHeader = "Product_Header";

	[Token(Token = "0x4008A70")]
	internal const string k_MapLabel_ProductHeaderButton = "Product_HeaderButton";

	[Token(Token = "0x4008A71")]
	internal const string k_MapLabel_ProductEmpty = "Product_Empty";

	[Token(Token = "0x4008A72")]
	internal const string k_MapLabel_ProductDefault = "Product_M";

	[Token(Token = "0x4008A73")]
	internal const string k_MapLabel_ProductMarketPrefix = "ProductMarket_";

	[Token(Token = "0x4008A74")]
	private const string k_MapLabel_ProductContainer = "Product_Container";

	[Token(Token = "0x4008A75")]
	private const string k_MapLabel_ProductMarketContainer = "Product_ContainerMarket";

	[Token(Token = "0x4008A76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private List<GameObject> m_TemplateList;

	[Token(Token = "0x4008A77")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Dictionary<string, int> m_TemplateIdxMap;

	[Token(Token = "0x4008A78")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Dictionary<float, int> m_ContainerTemplateIdxMap;

	[Token(Token = "0x4008A79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private Dictionary<string, GameObject> m_WidgetPrefMap;

	[Token(Token = "0x4008A7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, Vector2> m_ProductSizeMap;

	[Token(Token = "0x4008A7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<string, Stack<ProductWidget>> m_ProductWidgetReserves;

	[Token(Token = "0x1700074B")]
	public List<GameObject> templateList
	{
		[Token(Token = "0x60037FE")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700074C")]
	public int headerTemplateIdx
	{
		[Token(Token = "0x60037FF")]
		[Address(RVA = "0x49BDB0", Offset = "0x49AFB0", VA = "0x18049BDB0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003800")]
		[Address(RVA = "0x49C4C0", Offset = "0x49B6C0", VA = "0x18049C4C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700074D")]
	public int headerButtonTemplateIdx
	{
		[Token(Token = "0x6003801")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003802")]
		[Address(RVA = "0x49C490", Offset = "0x49B690", VA = "0x18049C490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700074E")]
	public int emptyTemplateIdx
	{
		[Token(Token = "0x6003803")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003804")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700074F")]
	public int marketContainerTemplateIdx
	{
		[Token(Token = "0x6003805")]
		[Address(RVA = "0x49BDA0", Offset = "0x49AFA0", VA = "0x18049BDA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6003806")]
		[Address(RVA = "0x49C4B0", Offset = "0x49B6B0", VA = "0x18049C4B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000750")]
	public float containerWidth
	{
		[Token(Token = "0x6003807")]
		[Address(RVA = "0x7DBBC0", Offset = "0x7DADC0", VA = "0x1807DBBC0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6003808")]
		[Address(RVA = "0x7DBBE0", Offset = "0x7DADE0", VA = "0x1807DBBE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000751")]
	public RectOffset containerPadding
	{
		[Token(Token = "0x6003809")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600380A")]
		[Address(RVA = "0x589E60", Offset = "0x589060", VA = "0x180589E60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000752")]
	public float containerSpacing
	{
		[Token(Token = "0x600380B")]
		[Address(RVA = "0x7DBBB0", Offset = "0x7DADB0", VA = "0x1807DBBB0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600380C")]
		[Address(RVA = "0x7DBBD0", Offset = "0x7DADD0", VA = "0x1807DBBD0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600380D")]
	[Address(RVA = "0x7DAE20", Offset = "0x7DA020", VA = "0x1807DAE20")]
	public bool ExistsMarketProductWidget(int slotLength)
	{
		return default(bool);
	}

	[Token(Token = "0x600380E")]
	[Address(RVA = "0x7DB1C0", Offset = "0x7DA3C0", VA = "0x1807DB1C0")]
	public bool IsSelectableTemplateIdx(int templateIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x600380F")]
	[Address(RVA = "0x7DB0F0", Offset = "0x7DA2F0", VA = "0x1807DB0F0")]
	public bool IsHeaderTemplateIdx(int templateIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003810")]
	[Address(RVA = "0x7DB040", Offset = "0x7DA240", VA = "0x1807DB040")]
	public bool IsContainerTemplateIdx(int templateIdx)
	{
		return default(bool);
	}

	[Token(Token = "0x6003811")]
	[Address(RVA = "0x7DAEC0", Offset = "0x7DA0C0", VA = "0x1807DAEC0")]
	public int GetContainerTemplateIdx(float productHeight)
	{
		return default(int);
	}

	[Token(Token = "0x6003812")]
	[Address(RVA = "0x7DAFA0", Offset = "0x7DA1A0", VA = "0x1807DAFA0")]
	public Vector2 GetProductSize(string productWidgetLabel)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6003813")]
	[Address(RVA = "0x7DB100", Offset = "0x7DA300", VA = "0x1807DB100")]
	public bool IsReservedProductWidget(ProductWidget productWidget)
	{
		return default(bool);
	}

	[Token(Token = "0x6003814")]
	[Address(RVA = "0x7DB9B0", Offset = "0x7DABB0", VA = "0x1807DB9B0")]
	public ProductWidgetController(AssetContainer productWidgetMap)
	{
	}

	[Token(Token = "0x6003815")]
	[Address(RVA = "0x7DAA90", Offset = "0x7D9C90", VA = "0x1807DAA90")]
	public void CreateTemplates(Transform parent)
	{
	}

	[Token(Token = "0x6003816")]
	[Address(RVA = "0x7DA790", Offset = "0x7D9990", VA = "0x1807DA790")]
	private void AssignTemplate(GameObject pref, [Optional] string label)
	{
	}

	[Token(Token = "0x6003817")]
	[Address(RVA = "0x7DA430", Offset = "0x7D9630", VA = "0x1807DA430")]
	private void AssignProductTemplate(string label, Transform parent, GameObject pref)
	{
	}

	[Token(Token = "0x6003818")]
	[Address(RVA = "0x7DA8C0", Offset = "0x7D9AC0", VA = "0x1807DA8C0")]
	private GameObject CreateContainerTemplate(Transform parent, float height)
	{
		return null;
	}

	[Token(Token = "0x6003819")]
	[Address(RVA = "0x7DB510", Offset = "0x7DA710", VA = "0x1807DB510")]
	public ProductWidget RentProductWidget(string label, Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600381A")]
	[Address(RVA = "0x7DB820", Offset = "0x7DAA20", VA = "0x1807DB820")]
	public void ReturnProductWidget(ProductWidget widget)
	{
	}

	[Token(Token = "0x600381B")]
	[Address(RVA = "0x7DB260", Offset = "0x7DA460", VA = "0x1807DB260")]
	public void ReleaseResources()
	{
	}
}
