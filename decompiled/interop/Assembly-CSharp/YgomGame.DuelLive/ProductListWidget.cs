using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.DuelLive;

[Token(Token = "0x2000F46")]
public class ProductListWidget : ElementWidgetBase
{
	[Token(Token = "0x2000F47")]
	public class Context
	{
		[Token(Token = "0x400A74B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public List<int> templateIdxList;

		[Token(Token = "0x400A74C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public readonly List<string> headerLabels;

		[Token(Token = "0x400A74D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public readonly List<string> subHeaderLabels;

		[Token(Token = "0x400A74E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public readonly List<string> emptyBoxTexts;

		[Token(Token = "0x400A74F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public readonly List<ProductGroupUrlButtonWidget.Context> urlButtons;

		[Token(Token = "0x400A750")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public readonly List<IProductContext[]> productContainers;

		[Token(Token = "0x400A751")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		public readonly List<DuelLiveWCSRoomData> wcsRooms;

		[Token(Token = "0x400A752")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		public readonly List<DuelLiveCardPackData> shopData;

		[Token(Token = "0x400A753")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private List<IList> m_contentLists;

		[Token(Token = "0x400A754")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		public readonly List<IProductContext> productCtxs;

		[Token(Token = "0x400A755")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		public string emptyMessageText;

		[Token(Token = "0x400A756")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		public int menuID;

		[Token(Token = "0x17000EA1")]
		public bool hasHeader
		{
			[Token(Token = "0x6005CF1")]
			[Address(RVA = "0xA1A500", Offset = "0xA19700", VA = "0x180A1A500")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000EA2")]
		public bool hasShopAreaHeader
		{
			[Token(Token = "0x6005CF2")]
			[Address(RVA = "0xA1A6A0", Offset = "0xA198A0", VA = "0x180A1A6A0")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x17000EA3")]
		public bool hasProduct
		{
			[Token(Token = "0x6005CF3")]
			[Address(RVA = "0xA1A630", Offset = "0xA19830", VA = "0x180A1A630")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6005CE5")]
		[Address(RVA = "0xA1A7D0", Offset = "0xA199D0", VA = "0x180A1A7D0")]
		private void initContents()
		{
		}

		[Token(Token = "0x6005CE6")]
		[Address(RVA = "0xA1A090", Offset = "0xA19290", VA = "0x180A1A090")]
		private int addContent(string headerLabel = "", string subHeaderLabel = "", string emptyBoxText = "", [Optional] ProductGroupUrlButtonWidget.Context urlButton, [Optional] IProductContext[] container, [Optional] DuelLiveWCSRoomData wcsRoom, [Optional] DuelLiveCardPackData shopData, int templateIdx = 0)
		{
			return default(int);
		}

		[Token(Token = "0x6005CE7")]
		[Address(RVA = "0xA195C0", Offset = "0xA187C0", VA = "0x180A195C0")]
		public int AddHeaderLabel(string label, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CE8")]
		[Address(RVA = "0xA196C0", Offset = "0xA188C0", VA = "0x180A196C0")]
		public int AddSubHeaderLabel(string label, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CE9")]
		[Address(RVA = "0xA19540", Offset = "0xA18740", VA = "0x180A19540")]
		public int AddEmptyBox(string text, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CEA")]
		[Address(RVA = "0xA197B0", Offset = "0xA189B0", VA = "0x180A197B0")]
		public int AddUrlButton(ProductGroupUrlButtonWidget.Context urlButton, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CEB")]
		[Address(RVA = "0xA194C0", Offset = "0xA186C0", VA = "0x180A194C0")]
		public int AddContainer(IProductContext[] container, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CEC")]
		[Address(RVA = "0xA19740", Offset = "0xA18940", VA = "0x180A19740")]
		public int AddTemplateIdx(int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CED")]
		[Address(RVA = "0xA19830", Offset = "0xA18A30", VA = "0x180A19830")]
		public int AddWCSRoom(DuelLiveWCSRoomData wcsRoom, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CEE")]
		[Address(RVA = "0xA19640", Offset = "0xA18840", VA = "0x180A19640")]
		public int AddShopWidgetData(DuelLiveCardPackData duelLiveCardPackData, int templateIdx)
		{
			return default(int);
		}

		[Token(Token = "0x6005CEF")]
		[Address(RVA = "0xA198B0", Offset = "0xA18AB0", VA = "0x180A198B0")]
		public void ClearContents()
		{
		}

		[Token(Token = "0x6005CF0")]
		[Address(RVA = "0xA19E00", Offset = "0xA19000", VA = "0x180A19E00")]
		public Context()
		{
		}
	}

	[Token(Token = "0x2000F4D")]
	[CompilerGenerated]
	private sealed class _003CInitializeCoroutine_003Ed__165 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A76A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public ProductListWidget _003C_003E4__this;

		[Token(Token = "0x400A76B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onComplete;

		[Token(Token = "0x400A76C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int reservePerFrame;

		[Token(Token = "0x17000EA4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005D07")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EA5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005D09")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005D04")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInitializeCoroutine_003Ed__165(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005D05")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005D06")]
		[Address(RVA = "0xA2C160", Offset = "0xA2B360", VA = "0x180A2C160", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005D08")]
		[Address(RVA = "0xA2D040", Offset = "0xA2C240", VA = "0x180A2D040", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A6FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private readonly DuelLiveWidgetMapSettings m_ProductWidgetContainer;

	[Token(Token = "0x400A6FE")]
	private const string k_ALabelWidgetMap = "WidgetMap";

	[Token(Token = "0x400A6FF")]
	private const string k_ALabelGroupHeaderPref = "DuelLiveGroupHeaderWidget";

	[Token(Token = "0x400A700")]
	private const string k_ALabelGroupEmptyPref = "DuelLiveGroupEmptyWidget";

	[Token(Token = "0x400A701")]
	private const string k_ALabelContainerWidget = "DuelLiveContainerWidget";

	[Token(Token = "0x400A702")]
	private const string k_ALabelProductWidgetPref = "DuelLiveProductWidget";

	[Token(Token = "0x400A703")]
	private const string k_ALabelProductRandomWidgetPref = "DuelLiveProductRandomWidget";

	[Token(Token = "0x400A704")]
	private const string k_ALabelProductVSWidgetPref = "DuelLiveProductVSWidget";

	[Token(Token = "0x400A705")]
	private const string k_ALabelProductEventWidgetPref = "DuelLiveProductEventWidget";

	[Token(Token = "0x400A706")]
	private const string k_ALabelProductOfficialAccountWidgetPref = "DuelLiveProductOfficialAccountWidget";

	[Token(Token = "0x400A707")]
	private const string k_ALabelProductCommingSoonWidgetPref = "DuelLiveProductCommingSoonWidget";

	[Token(Token = "0x400A708")]
	private const string k_ALabelProductGroupWCSPref = "DuelLiveProductGroupWCSWidget";

	[Token(Token = "0x400A709")]
	private const string k_ALabelProductGroupWCSHeaderPref = "DuelLiveProductGroupWCSHeaderWidget";

	[Token(Token = "0x400A70A")]
	private const string k_ALabelProductGroupSubHeaderPref = "DuelLiveProductGroupSubHeaderWidget";

	[Token(Token = "0x400A70B")]
	private const string k_ALabelProductGroupTextBlockPref = "DuelLiveProductGroupTextBlockWidget";

	[Token(Token = "0x400A70C")]
	private const string k_ALabelProductGroupUrlButtonPref = "DuelLiveProductGroupUrlButtonWidget";

	[Token(Token = "0x400A70D")]
	private const string k_ALabelProductVSNewWidgetPref = "DuelLiveProductVSNewWidget";

	[Token(Token = "0x400A70E")]
	private const string k_ALabelProductGroupShopAreaHeader = "DuelLiveProductShopAreaHeader";

	[Token(Token = "0x400A70F")]
	private const string k_ALabelProductGroupBanner = "DuelLiveProductBanner";

	[Token(Token = "0x400A710")]
	private const string k_ELabelProductList = "ProductList";

	[Token(Token = "0x400A711")]
	private const string k_ELabelGroupHeaderWidget = "ProductGroupHeader";

	[Token(Token = "0x400A712")]
	private const string k_ELabelGroupEmptyWidget = "ProductGroupEmpty";

	[Token(Token = "0x400A713")]
	private const string k_ELabelProductContainer = "ProductContainer";

	[Token(Token = "0x400A714")]
	private const string k_ELabelProductGroupWCS = "ProductGroupWCS";

	[Token(Token = "0x400A715")]
	private const string k_ELabelProductGroupWCSHeader = "ProductGroupWCSHeader";

	[Token(Token = "0x400A716")]
	private const string k_ELabelProductGroupSubHeader = "ProductGroupSubHeader";

	[Token(Token = "0x400A717")]
	private const string k_ELabelProductGroupText = "ProductGroupText";

	[Token(Token = "0x400A718")]
	private const string k_ELabelProductGroupShopAreaHeader = "ProductGroupShopAreaHeader";

	[Token(Token = "0x400A719")]
	private const string k_ELabelProductBanner = "ProductBanner";

	[Token(Token = "0x400A71A")]
	private const string k_ELabelEmptyMessageText = "EmptyMessageText";

	[Token(Token = "0x400A71B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly DuelLiveRootWidget m_Owner;

	[Token(Token = "0x400A71C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	public readonly Selector selector;

	[Token(Token = "0x400A71D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly InfinityScrollView m_ScrollView;

	[Token(Token = "0x400A71E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private readonly TMP_Text m_EmptyMessageText;

	[Token(Token = "0x400A71F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ExtendedScrollRect m_ScrollRectCache;

	[Token(Token = "0x400A720")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private ElementObjectManager m_ProductWidgetPref;

	[Token(Token = "0x400A721")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private WCSHeaderWidget m_WCSHeader;

	[Token(Token = "0x400A722")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Dictionary<GameObject, ProductGroupHeaderWidget> m_HeaderWidgetMap;

	[Token(Token = "0x400A723")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly Dictionary<GameObject, ProductGroupSubHeaderWidget> m_SubHeaderWidgetMap;

	[Token(Token = "0x400A724")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private readonly Dictionary<GameObject, ProductWCSRoomHeaderWidget> m_WCSRoomHeaderWidgetMap;

	[Token(Token = "0x400A725")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private readonly Dictionary<GameObject, ProductContainerWidget> m_ContainerWidgetMap;

	[Token(Token = "0x400A726")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private readonly Dictionary<GameObject, ProductWidget> m_ProductWidgetMap;

	[Token(Token = "0x400A727")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly Dictionary<GameObject, ProductWCSInfoWidget> m_WCSInfoWidgetMap;

	[Token(Token = "0x400A728")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly Dictionary<GameObject, ProductGroupUrlButtonWidget> m_ProductGroupUrlButtonWidgetMap;

	[Token(Token = "0x400A729")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly Dictionary<GameObject, ProductGroupEmptyBoxWidget> m_EmptyBoxWidgetMap;

	[Token(Token = "0x400A72A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<GameObject, ProductGroupShopAreaHeaderWidget> m_ShopAreaHeaderWidgetMap;

	[Token(Token = "0x400A72B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private readonly Dictionary<GameObject, IProductWidget> m_WidgetMap;

	[Token(Token = "0x400A72C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private RectOffset m_BasePadding;

	[Token(Token = "0x400A72D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private RectOffset m_Padding;

	[Token(Token = "0x400A72E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private float m_Spacing;

	[Token(Token = "0x400A72F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private Context m_Context;

	[Token(Token = "0x400A730")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private int m_PreSelectedDataIdx;

	[Token(Token = "0x400A731")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD4")]
	private int m_PreSelectedSectionDataIdx;

	[Token(Token = "0x400A742")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private TemplateCollection m_templateCollection;

	[Token(Token = "0x400A743")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private FreeTextCollection m_freeTextCollection;

	[Token(Token = "0x400A748")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
	public MenuAssistantBase menuAssistant;

	[Token(Token = "0x400A749")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
	private readonly List<float> m_EntityVirtualPositions;

	[Token(Token = "0x400A74A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
	private bool m_EntityVirtualPositionsDirty;

	[Token(Token = "0x17000E86")]
	public DuelLiveRootWidget rootWidget
	{
		[Token(Token = "0x6005C79")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E87")]
	public Context context
	{
		[Token(Token = "0x6005C7D")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E88")]
	public int preSelectedDataIdx
	{
		[Token(Token = "0x6005C7E")]
		[Address(RVA = "0x6D4620", Offset = "0x6D3820", VA = "0x1806D4620")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E89")]
	public int preSelectedSectionDataIdx
	{
		[Token(Token = "0x6005C7F")]
		[Address(RVA = "0x6D4630", Offset = "0x6D3830", VA = "0x1806D4630")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000E8A")]
	public ExtendedScrollRect scrollRect
	{
		[Token(Token = "0x6005C80")]
		[Address(RVA = "0xA2A130", Offset = "0xA29330", VA = "0x180A2A130")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E8B")]
	public int containerLength
	{
		[Token(Token = "0x6005C81")]
		[Address(RVA = "0x4226F0", Offset = "0x4218F0", VA = "0x1804226F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C82")]
		[Address(RVA = "0x422700", Offset = "0x421900", VA = "0x180422700")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E8C")]
	public int productTemplateIdx
	{
		[Token(Token = "0x6005C83")]
		[Address(RVA = "0xA2A110", Offset = "0xA29310", VA = "0x180A2A110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C84")]
		[Address(RVA = "0xA2A550", Offset = "0xA29750", VA = "0x180A2A550")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E8D")]
	public int containerTemplateIdx
	{
		[Token(Token = "0x6005C85")]
		[Address(RVA = "0x746560", Offset = "0x745760", VA = "0x180746560")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C86")]
		[Address(RVA = "0xA2A4F0", Offset = "0xA296F0", VA = "0x180A2A4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E8E")]
	public int headerTemplateIdx
	{
		[Token(Token = "0x6005C87")]
		[Address(RVA = "0xA2A0E0", Offset = "0xA292E0", VA = "0x180A2A0E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C88")]
		[Address(RVA = "0xA2A530", Offset = "0xA29730", VA = "0x180A2A530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E8F")]
	public int emptyTemplateIdx
	{
		[Token(Token = "0x6005C89")]
		[Address(RVA = "0x62D9C0", Offset = "0x62CBC0", VA = "0x18062D9C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C8A")]
		[Address(RVA = "0x62DFB0", Offset = "0x62D1B0", VA = "0x18062DFB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E90")]
	public int randomTemplateIdx
	{
		[Token(Token = "0x6005C8B")]
		[Address(RVA = "0xA2A120", Offset = "0xA29320", VA = "0x180A2A120")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C8C")]
		[Address(RVA = "0xA2A560", Offset = "0xA29760", VA = "0x180A2A560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E91")]
	public int vsTemplateIdx
	{
		[Token(Token = "0x6005C8D")]
		[Address(RVA = "0x764490", Offset = "0x763690", VA = "0x180764490")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C8E")]
		[Address(RVA = "0x8AF080", Offset = "0x8AE280", VA = "0x1808AF080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E92")]
	public int eventTemplateIdx
	{
		[Token(Token = "0x6005C8F")]
		[Address(RVA = "0xA2A0B0", Offset = "0xA292B0", VA = "0x180A2A0B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C90")]
		[Address(RVA = "0xA2A500", Offset = "0xA29700", VA = "0x180A2A500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E93")]
	public int officialAccountTemplateIdx
	{
		[Token(Token = "0x6005C91")]
		[Address(RVA = "0xA2A100", Offset = "0xA29300", VA = "0x180A2A100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C92")]
		[Address(RVA = "0xA2A540", Offset = "0xA29740", VA = "0x180A2A540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E94")]
	public int commingSoonTemplateIdx
	{
		[Token(Token = "0x6005C93")]
		[Address(RVA = "0xA2A080", Offset = "0xA29280", VA = "0x180A2A080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C94")]
		[Address(RVA = "0xA2A4E0", Offset = "0xA296E0", VA = "0x180A2A4E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E95")]
	public int groupWCSTemplateIdx
	{
		[Token(Token = "0x6005C95")]
		[Address(RVA = "0x3F4B30", Offset = "0x3F3D30", VA = "0x1803F4B30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C96")]
		[Address(RVA = "0x3F4B40", Offset = "0x3F3D40", VA = "0x1803F4B40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E96")]
	public int groupWCSHeaderTemplateIdx
	{
		[Token(Token = "0x6005C97")]
		[Address(RVA = "0x49B800", Offset = "0x49AA00", VA = "0x18049B800")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C98")]
		[Address(RVA = "0x49C080", Offset = "0x49B280", VA = "0x18049C080")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E97")]
	public int groupSubHeaderTemplateIdx
	{
		[Token(Token = "0x6005C99")]
		[Address(RVA = "0xA2A0D0", Offset = "0xA292D0", VA = "0x180A2A0D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C9A")]
		[Address(RVA = "0xA2A520", Offset = "0xA29720", VA = "0x180A2A520")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E98")]
	public int groupUrlButtonTemplateIdx
	{
		[Token(Token = "0x6005C9B")]
		[Address(RVA = "0x49B890", Offset = "0x49AA90", VA = "0x18049B890")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C9C")]
		[Address(RVA = "0x49C110", Offset = "0x49B310", VA = "0x18049C110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E99")]
	public int groupShopAreaHeaderIdx
	{
		[Token(Token = "0x6005C9D")]
		[Address(RVA = "0xA2A0C0", Offset = "0xA292C0", VA = "0x180A2A0C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005C9E")]
		[Address(RVA = "0xA2A510", Offset = "0xA29710", VA = "0x180A2A510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E9A")]
	public int bannerTemplateIdx
	{
		[Token(Token = "0x6005C9F")]
		[Address(RVA = "0x6D4710", Offset = "0x6D3910", VA = "0x1806D4710")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6005CA0")]
		[Address(RVA = "0x6D7720", Offset = "0x6D6920", VA = "0x1806D7720")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000E9B")]
	public RectOffset padding
	{
		[Token(Token = "0x6005CA1")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9C")]
	public float spacing
	{
		[Token(Token = "0x6005CA2")]
		[Address(RVA = "0xA2A1D0", Offset = "0xA293D0", VA = "0x180A2A1D0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000E9D")]
	public bool isContainerList
	{
		[Token(Token = "0x6005CA3")]
		[Address(RVA = "0xA2A0F0", Offset = "0xA292F0", VA = "0x180A2A0F0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000E9E")]
	public FreeTextCollection freeTextCollection
	{
		[Token(Token = "0x6005CA4")]
		[Address(RVA = "0x9538F0", Offset = "0x952AF0", VA = "0x1809538F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000E9F")]
	public InfinityScrollView scrollView
	{
		[Token(Token = "0x6005CA5")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000EA0")]
	private List<float> entityVirtualPositions
	{
		[Token(Token = "0x6005CC2")]
		[Address(RVA = "0xA2A090", Offset = "0xA29290", VA = "0x180A2A090")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1400008D")]
	public event Action<ProductWidget> onClickedProductEvent
	{
		[Token(Token = "0x6005CA6")]
		[Address(RVA = "0xA29E40", Offset = "0xA29040", VA = "0x180A29E40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005CA7")]
		[Address(RVA = "0xA2A2A0", Offset = "0xA294A0", VA = "0x180A2A2A0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400008E")]
	public event Action<ProductWidget> onClickedPlayButtonEvent
	{
		[Token(Token = "0x6005CA8")]
		[Address(RVA = "0xA29D80", Offset = "0xA28F80", VA = "0x180A29D80")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005CA9")]
		[Address(RVA = "0xA2A1E0", Offset = "0xA293E0", VA = "0x180A2A1E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400008F")]
	public event Action<int> onClickedWCSRandomPlayButtonEvent
	{
		[Token(Token = "0x6005CAA")]
		[Address(RVA = "0xA29FC0", Offset = "0xA291C0", VA = "0x180A29FC0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005CAB")]
		[Address(RVA = "0xA2A420", Offset = "0xA29620", VA = "0x180A2A420")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000090")]
	public event Action<string> onClickedUrlButtonEvent
	{
		[Token(Token = "0x6005CAC")]
		[Address(RVA = "0xA29F00", Offset = "0xA29100", VA = "0x180A29F00")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6005CAD")]
		[Address(RVA = "0xA2A360", Offset = "0xA29560", VA = "0x180A2A360")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6005C7A")]
	[Address(RVA = "0xA23D40", Offset = "0xA22F40", VA = "0x180A23D40")]
	public ElementWidgetBase GetWidgetByDataIndex(int dataIndex)
	{
		return null;
	}

	[Token(Token = "0x6005C7B")]
	public T GetWidgetByDataIndex<T>(int dataIndex) where T : ElementWidgetBase, IProductWidget
	{
		return null;
	}

	[Token(Token = "0x6005C7C")]
	public T GetWidgetByEntity<T>(GameObject entity) where T : ElementWidgetBase, IProductWidget
	{
		return null;
	}

	[Token(Token = "0x6005CAE")]
	[Address(RVA = "0xA230A0", Offset = "0xA222A0", VA = "0x180A230A0")]
	public int GetHeaderIndexByCurrentPos()
	{
		return default(int);
	}

	[Token(Token = "0x6005CAF")]
	[Address(RVA = "0xA23480", Offset = "0xA22680", VA = "0x180A23480")]
	public int GetHeaderIndexByDataIdx(int dataIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6005CB0")]
	[Address(RVA = "0xA23B80", Offset = "0xA22D80", VA = "0x180A23B80")]
	public float GetTargetPosByDataIndex(int dataIndex)
	{
		return default(float);
	}

	[Token(Token = "0x6005CB1")]
	[Address(RVA = "0xA23C10", Offset = "0xA22E10", VA = "0x180A23C10")]
	public TemplateCollection.Info GetTemplateInfoByDataIndex(int dataIndex)
	{
		return null;
	}

	[Token(Token = "0x6005CB2")]
	[Address(RVA = "0xA23D20", Offset = "0xA22F20", VA = "0x180A23D20")]
	public IReadOnlyList<int> GetTemplateLayoutList()
	{
		return null;
	}

	[Token(Token = "0x6005CB3")]
	[Address(RVA = "0xA23890", Offset = "0xA22A90", VA = "0x180A23890")]
	public int GetNextSelectableDataIndex(int dataIndex, PadInputDirection dir)
	{
		return default(int);
	}

	[Token(Token = "0x6005CB4")]
	[Address(RVA = "0xA23A10", Offset = "0xA22C10", VA = "0x180A23A10")]
	public List<int> GetSelectableDataIndexList(int dataIndex, PadInputDirection dir)
	{
		return null;
	}

	[Token(Token = "0x6005CB5")]
	[Address(RVA = "0xA296D0", Offset = "0xA288D0", VA = "0x180A296D0")]
	public ProductListWidget(ElementObjectManager eom, DuelLiveRootWidget owner, bool frag = false)
	{
	}

	[Token(Token = "0x6005CB6")]
	[Address(RVA = "0xA241F0", Offset = "0xA233F0", VA = "0x180A241F0")]
	public void Initialize(ElementObjectManager eom, int reservePerFrame = 0, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6005CB7")]
	[Address(RVA = "0xA24150", Offset = "0xA23350", VA = "0x180A24150")]
	[IteratorStateMachine(typeof(_003CInitializeCoroutine_003Ed__165))]
	private IEnumerator InitializeCoroutine(ElementObjectManager eom, int reservePerFrame = 0, [Optional] Action onComplete)
	{
		return null;
	}

	[Token(Token = "0x6005CB8")]
	[Address(RVA = "0xA271B0", Offset = "0xA263B0", VA = "0x180A271B0")]
	public void ResetPreIdx()
	{
	}

	[Token(Token = "0x6005CB9")]
	[Address(RVA = "0xA276C0", Offset = "0xA268C0", VA = "0x180A276C0")]
	public void SetProducts(Context ctx, int asyncCnt = 0, bool resetPos = true, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6005CBA")]
	[Address(RVA = "0xA228E0", Offset = "0xA21AE0", VA = "0x180A228E0")]
	public bool FocusDataIndex(int dataIdx, int contentIdx = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CBB")]
	[Address(RVA = "0xA23960", Offset = "0xA22B60", VA = "0x180A23960")]
	public IProductContext GetProductContextByDataIdx(int dataIdx, int containerIdx)
	{
		return null;
	}

	[Token(Token = "0x6005CBC")]
	[Address(RVA = "0xA24330", Offset = "0xA23530", VA = "0x180A24330")]
	public void JumpScroll(PadInputDirection dir, int jumpLength)
	{
	}

	[Token(Token = "0x6005CBD")]
	[Address(RVA = "0xA245B0", Offset = "0xA237B0", VA = "0x180A245B0")]
	public void JumpToDirection(PadInputDirection dir)
	{
	}

	[Token(Token = "0x6005CBE")]
	[Address(RVA = "0xA28A90", Offset = "0xA27C90", VA = "0x180A28A90")]
	public bool TrySelectInViewportTop(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CBF")]
	[Address(RVA = "0xA26F70", Offset = "0xA26170", VA = "0x180A26F70")]
	public void ResetBasePadding()
	{
	}

	[Token(Token = "0x6005CC0")]
	[Address(RVA = "0xA29290", Offset = "0xA28490", VA = "0x180A29290")]
	private void UpdatePadding()
	{
	}

	[Token(Token = "0x6005CC1")]
	[Address(RVA = "0xA21A70", Offset = "0xA20C70", VA = "0x180A21A70")]
	private GameObject AssginPref(GameObject pref)
	{
		return null;
	}

	[Token(Token = "0x6005CC3")]
	[Address(RVA = "0xA21C40", Offset = "0xA20E40", VA = "0x180A21C40")]
	private void CalcCheckEntityVirtualPositions()
	{
	}

	[Token(Token = "0x6005CC4")]
	[Address(RVA = "0xA27590", Offset = "0xA26790", VA = "0x180A27590")]
	private void SetEntityVirtualPositions(int idx, float value)
	{
	}

	[Token(Token = "0x6005CC5")]
	[Address(RVA = "0xA25200", Offset = "0xA24400", VA = "0x180A25200")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6005CC6")]
	[Address(RVA = "0xA24E90", Offset = "0xA24090", VA = "0x180A24E90")]
	private void OnActivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6005CC7")]
	[Address(RVA = "0xA25AD0", Offset = "0xA24CD0", VA = "0x180A25AD0")]
	private void OnDeactivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6005CC8")]
	[Address(RVA = "0xA21E70", Offset = "0xA21070", VA = "0x180A21E70")]
	private IReadOnlyList<(SelectionItem, int, int)> CollectSelectionItems(GameObject entity)
	{
		return null;
	}

	[Token(Token = "0x6005CC9")]
	[Address(RVA = "0xA25BB0", Offset = "0xA24DB0", VA = "0x180A25BB0")]
	private bool OnFocusSelectEntity(GameObject entity, int dataIndex, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCA")]
	[Address(RVA = "0xA25D90", Offset = "0xA24F90", VA = "0x180A25D90")]
	public bool OnSelectorSelectored(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCB")]
	[Address(RVA = "0xA23600", Offset = "0xA22800", VA = "0x180A23600")]
	public (int, int, int) GetIdByCurrentPos()
	{
		return default((int, int, int));
	}

	[Token(Token = "0x6005CCC")]
	[Address(RVA = "0xA24C40", Offset = "0xA23E40", VA = "0x180A24C40")]
	private (bool, float) MoveContentToFitDataPos(int dataIndex)
	{
		return default((bool, float));
	}

	[Token(Token = "0x6005CCD")]
	[Address(RVA = "0xA24290", Offset = "0xA23490", VA = "0x180A24290")]
	private bool IsSelectableEntityIndex(int dataIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CCE")]
	[Address(RVA = "0xA25EB0", Offset = "0xA250B0", VA = "0x180A25EB0")]
	private void OnUpdateEntity(GameObject entity, int dataIdx)
	{
	}

	[Token(Token = "0x6005CCF")]
	[Address(RVA = "0xA228A0", Offset = "0xA21AA0", VA = "0x180A228A0")]
	private bool CustomInnerTransition(SelectionItem item, PadInputDirection dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD0")]
	[Address(RVA = "0xA24FB0", Offset = "0xA241B0", VA = "0x180A24FB0")]
	private bool OnAnalogInput(Vector2 dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD1")]
	[Address(RVA = "0xA273D0", Offset = "0xA265D0", VA = "0x180A273D0")]
	private int SearchHeaderDataIdx(int headerIdx)
	{
		return default(int);
	}

	[Token(Token = "0x6005CD2")]
	[Address(RVA = "0xA271C0", Offset = "0xA263C0", VA = "0x180A271C0")]
	private (bool, int) SearchHeadProductDataIdx()
	{
		return default((bool, int));
	}

	[Token(Token = "0x6005CD3")]
	[Address(RVA = "0xA28500", Offset = "0xA27700", VA = "0x180A28500")]
	public bool TrySelectHeadProduct(bool isInitializeSelect = false, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD4")]
	[Address(RVA = "0xA27540", Offset = "0xA26740", VA = "0x180A27540")]
	public bool SelectProductInContainer(int dataIndex, bool isInitializeSelect)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD5")]
	[Address(RVA = "0xA29130", Offset = "0xA28330", VA = "0x180A29130")]
	public bool TrySelectWCSInfo(GameObject entity, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD6")]
	[Address(RVA = "0xA28FC0", Offset = "0xA281C0", VA = "0x180A28FC0")]
	public bool TrySelectWCSInfo(int dataIndex, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD7")]
	[Address(RVA = "0xA28F10", Offset = "0xA28110", VA = "0x180A28F10")]
	public bool TrySelectUrlButton(GameObject entity, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD8")]
	[Address(RVA = "0xA282E0", Offset = "0xA274E0", VA = "0x180A282E0")]
	public bool TrySelectContainer(GameObject entity, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CD9")]
	[Address(RVA = "0xA22E30", Offset = "0xA22030", VA = "0x180A22E30")]
	public bool FocusItem(int dataIdx, bool selectItem, bool isInitializeSelect = false, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CDA")]
	[Address(RVA = "0xA22980", Offset = "0xA21B80", VA = "0x180A22980")]
	public void FocusHeader(int headerIdx, bool immediate = false)
	{
	}

	[Token(Token = "0x6005CDB")]
	[Address(RVA = "0xA22FA0", Offset = "0xA221A0", VA = "0x180A22FA0")]
	private void FocusTopOfView(bool immediate = false)
	{
	}

	[Token(Token = "0x6005CDC")]
	[Address(RVA = "0xA22E90", Offset = "0xA22090", VA = "0x180A22E90")]
	private void FocusProduct(int dataIdx, int sectionDataIdx = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
	{
	}

	[Token(Token = "0x6005CDD")]
	[Address(RVA = "0xA27F80", Offset = "0xA27180", VA = "0x180A27F80")]
	public bool TryFocusPreSelectedProduct(bool selectItem = true, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CDE")]
	[Address(RVA = "0xA27DA0", Offset = "0xA26FA0", VA = "0x180A27DA0")]
	private bool TryFocusHeadItem(int sectionIndex, bool selectItem = true, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6005CDF")]
	[Address(RVA = "0xA25150", Offset = "0xA24350", VA = "0x180A25150")]
	private void OnClickContainersWidget(ProductContainerWidget containerWidget, ProductWidget productWidget)
	{
	}

	[Token(Token = "0x6005CE0")]
	[Address(RVA = "0xA251E0", Offset = "0xA243E0", VA = "0x180A251E0")]
	private void OnClickWidget(ProductWidget productWidget)
	{
	}

	[Token(Token = "0x6005CE1")]
	[Address(RVA = "0xA25CE0", Offset = "0xA24EE0", VA = "0x180A25CE0")]
	private void OnSelectedProduct(int dataIdx, int containerIdx)
	{
	}

	[Token(Token = "0x6005CE2")]
	[Address(RVA = "0xA25180", Offset = "0xA24380", VA = "0x180A25180")]
	private void OnClickPlayButton(ProductWidget productWidget)
	{
	}

	[Token(Token = "0x6005CE3")]
	[Address(RVA = "0xA251C0", Offset = "0xA243C0", VA = "0x180A251C0")]
	private void OnClickWCSRandomPlayButton(int menuID)
	{
	}

	[Token(Token = "0x6005CE4")]
	[Address(RVA = "0xA251A0", Offset = "0xA243A0", VA = "0x180A251A0")]
	private void OnClickUrlButton(string scheme)
	{
	}
}
