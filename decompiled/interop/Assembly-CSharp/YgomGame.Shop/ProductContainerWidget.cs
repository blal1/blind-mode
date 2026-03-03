using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.Shop;

[Token(Token = "0x2000958")]
public class ProductContainerWidget : ElementWidgetBase
{
	[Token(Token = "0x2000959")]
	public class Context
	{
		[Token(Token = "0x4008B14")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public readonly List<ProductContext> productCtxs;

		[Token(Token = "0x4008B15")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object[] m_ProductWidgetLabelArgs;

		[Token(Token = "0x1700076C")]
		public int Count
		{
			[Token(Token = "0x60038F5")]
			[Address(RVA = "0x7EB120", Offset = "0x7EA320", VA = "0x1807EB120")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700076D")]
		public object[] productWidgetLabelArgs
		{
			[Token(Token = "0x60038F6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60038F7")]
		[Address(RVA = "0x7EAFF0", Offset = "0x7EA1F0", VA = "0x1807EAFF0")]
		public Context(int capacity, params object[] productWidgetLabelArgs)
		{
		}

		[Token(Token = "0x60038F8")]
		[Address(RVA = "0x7EAF90", Offset = "0x7EA190", VA = "0x1807EAF90")]
		public void Clear()
		{
		}

		[Token(Token = "0x60038F9")]
		[Address(RVA = "0x7EAEE0", Offset = "0x7EA0E0", VA = "0x1807EAEE0")]
		public void Add(ProductContext productCtx)
		{
		}
	}

	[Token(Token = "0x200095A")]
	public class MarketContext : Context, IShowcaseGruopContext, IHasShopIdContent
	{
		[Token(Token = "0x4008B16")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly ProductContext productContext;

		[Token(Token = "0x4008B17")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public int shopId;

		[Token(Token = "0x4008B18")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public long limitdateTs;

		[Token(Token = "0x1700076E")]
		private int YgomGame_002EShop_002EIHasShopIdContent_002EshopId
		{
			[Token(Token = "0x60038FA")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "7")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x1700076F")]
		public bool agree
		{
			[Token(Token = "0x60038FB")]
			[Address(RVA = "0x7EC170", Offset = "0x7EB370", VA = "0x1807EC170")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000770")]
		public int categoryId
		{
			[Token(Token = "0x60038FD")]
			[Address(RVA = "0x452710", Offset = "0x451910", VA = "0x180452710", Slot = "4")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000771")]
		public int subCategoryId
		{
			[Token(Token = "0x60038FE")]
			[Address(RVA = "0x573650", Offset = "0x572850", VA = "0x180573650", Slot = "5")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x17000772")]
		public int sectionId
		{
			[Token(Token = "0x60038FF")]
			[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "6")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x60038FC")]
		[Address(RVA = "0x7EC0A0", Offset = "0x7EB2A0", VA = "0x1807EC0A0")]
		public MarketContext(ProductContext productContext, int capacity, params object[] productWidgetLabelArgs)
		{
		}

		[Token(Token = "0x6003900")]
		[Address(RVA = "0x7EC010", Offset = "0x7EB210", VA = "0x1807EC010")]
		public void AssignProducts(ShopSettings shopSettings, CardCategoryData cardCategoryData, int shopId, IReadOnlyList<ProductContext> slotProducts)
		{
		}
	}

	[Token(Token = "0x4008B0F")]
	private const string k_ELabel_ProductsRoot = "ProductsRoot";

	[Token(Token = "0x4008B10")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Transform m_ProductsRootTran;

	[Token(Token = "0x4008B11")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private SelectionButton m_RootButton;

	[Token(Token = "0x4008B12")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private List<ProductWidget> m_ActiveWidgets;

	[Token(Token = "0x4008B13")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private Dictionary<string, List<ProductWidget>> m_HoldWidgetsMap;

	[Token(Token = "0x1700076A")]
	public List<ProductWidget> productWidgets
	{
		[Token(Token = "0x60038F0")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700076B")]
	public SelectionButton rootButton
	{
		[Token(Token = "0x60038F1")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x60038F2")]
	[Address(RVA = "0x7ED000", Offset = "0x7EC200", VA = "0x1807ED000")]
	public ProductContainerWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x60038F3")]
	[Address(RVA = "0x7EC1B0", Offset = "0x7EB3B0", VA = "0x1807EC1B0")]
	public void ApplyContents(ProductWidgetController widgetController, Context ctx, IProductContainerWidgetHandler handler, [Optional] Action<ProductWidget> onReturnWidget)
	{
	}

	[Token(Token = "0x60038F4")]
	[Address(RVA = "0x7ECD50", Offset = "0x7EBF50", VA = "0x1807ECD50")]
	public void ReleaseResources()
	{
	}
}
