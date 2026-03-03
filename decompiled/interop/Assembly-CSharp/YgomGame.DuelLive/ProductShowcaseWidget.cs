using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F5F")]
public class ProductShowcaseWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F60")]
	public class Context
	{
		[Token(Token = "0x400A7A5")]
		[FieldOffset(Offset = "0x10")]
		public List<MainTabWidget.TabContext> mainTabListCtx;

		[Token(Token = "0x400A7A6")]
		[FieldOffset(Offset = "0x18")]
		public List<List<SubTabListWidget.TabContext>> subTabListCtx;

		[Token(Token = "0x400A7A7")]
		[FieldOffset(Offset = "0x20")]
		public readonly ProductListWidget.Context productListCtx;

		[Token(Token = "0x17000EB0")]
		public bool existsSubTab
		{
			[Token(Token = "0x6005D53")]
			[Address(RVA = "0xA1A4B0", Offset = "0xA196B0", VA = "0x180A1A4B0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005D54")]
		[Address(RVA = "0xA19D00", Offset = "0xA18F00", VA = "0x180A19D00")]
		public Context()
		{
		}
	}

	[Token(Token = "0x400A79E")]
	private const string k_ELabelSubTabs = "SubTabs";

	[Token(Token = "0x400A79F")]
	[FieldOffset(Offset = "0x20")]
	private readonly MainTabWidget m_MainTabWidget;

	[Token(Token = "0x400A7A0")]
	[FieldOffset(Offset = "0x28")]
	private readonly SubTabListWidget m_SubTabListWidget;

	[Token(Token = "0x400A7A1")]
	[FieldOffset(Offset = "0x30")]
	private readonly ProductListWidget m_ProductListWidget;

	[Token(Token = "0x400A7A2")]
	[FieldOffset(Offset = "0x38")]
	private readonly Selector[] m_Selectors;

	[Token(Token = "0x400A7A3")]
	[FieldOffset(Offset = "0x40")]
	public readonly Selector mainSelector;

	[Token(Token = "0x400A7A4")]
	[FieldOffset(Offset = "0x48")]
	public readonly Context ctx;

	[Token(Token = "0x17000EAD")]
	public MainTabWidget mainTabWidget
	{
		[Token(Token = "0x6005D4D")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAE")]
	public SubTabListWidget subTabListWidget
	{
		[Token(Token = "0x6005D4E")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EAF")]
	public ProductListWidget productListWidget
	{
		[Token(Token = "0x6005D4F")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6005D50")]
	[Address(RVA = "0xA2A6A0", Offset = "0xA298A0", VA = "0x180A2A6A0")]
	public ProductShowcaseWidget(ElementObjectManager eom, DuelLiveRootWidget owner, bool frag = false)
	{
	}

	[Token(Token = "0x6005D51")]
	[Address(RVA = "0xA2A570", Offset = "0xA29770", VA = "0x180A2A570")]
	public void SetActive(bool isActive)
	{
	}

	[Token(Token = "0x6005D52")]
	[Address(RVA = "0xA2A600", Offset = "0xA29800", VA = "0x180A2A600")]
	public bool TrySelectDefault(bool isInitializeSelect = false)
	{
		return default(bool);
	}
}
