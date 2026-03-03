using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.UI;
using YgomSystem.UI.ElementWidget;
using YgomSystem.UI.InfinityScroll;

namespace YgomGame.Shop;

[Token(Token = "0x2000961")]
public class ProductListWidget : ElementWidgetBase
{
	[Token(Token = "0x4008B28")]
	private const string k_ELabelProductList = "ProductList";

	[Token(Token = "0x4008B29")]
	private const string k_ELabelInFilterMessageText = "InFilterMessageText";

	[Token(Token = "0x4008B2A")]
	private const string k_ELabelEmptyMessageText = "EmptyMessageText";

	[Token(Token = "0x4008B2B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	public readonly Selector selector;

	[Token(Token = "0x4008B2C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private readonly InfinityScrollView m_ScrollView;

	[Token(Token = "0x4008B2D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private readonly GameObject m_InFilterMessageText;

	[Token(Token = "0x4008B2E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private readonly TMP_Text m_EmptyMessageText;

	[Token(Token = "0x4008B2F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private ExtendedScrollRect m_ScrollRectCache;

	[Token(Token = "0x4008B30")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private IProductListWidgetHandler m_Handler;

	[Token(Token = "0x4008B31")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private IProductListWidgetListener m_Listener;

	[Token(Token = "0x4008B32")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly Dictionary<GameObject, ProductGroupHeaderWidget> m_HeaderWidgetMap;

	[Token(Token = "0x4008B33")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private readonly Dictionary<GameObject, ProductContainerWidget> m_ContainerWidgetMap;

	[Token(Token = "0x4008B34")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private readonly List<float> m_EntityVirtualPositions;

	[Token(Token = "0x4008B35")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private RectOffset m_BasePadding;

	[Token(Token = "0x4008B36")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private RectOffset m_Padding;

	[Token(Token = "0x4008B37")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private float m_Spacing;

	[Token(Token = "0x4008B38")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x84")]
	private bool m_EntityVirtualPositionsDirty;

	[Token(Token = "0x4008B39")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private readonly List<int> m_TemplateIdxList;

	[Token(Token = "0x4008B3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private readonly List<ProductGroupHeaderWidget.Context> m_HeaderCtxs;

	[Token(Token = "0x4008B3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private readonly List<ProductContainerWidget.Context> m_ProductContainerCtxs;

	[Token(Token = "0x4008B3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private readonly Dictionary<int, Dictionary<int, Dictionary<int, int>>> m_HeaderDataIdxMap;

	[Token(Token = "0x4008B3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public bool filteredVisible;

	[Token(Token = "0x4008B3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	public string emptyMessageText;

	[Token(Token = "0x4008B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private int m_PreSelectedDataIdx;

	[Token(Token = "0x4008B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xBC")]
	private int m_PreSelectedContentIdx;

	[Token(Token = "0x4008B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector2 m_PreSelectedPos;

	[Token(Token = "0x4008B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private List<SelectionItem> m_SearchSelectItems;

	[Token(Token = "0x17000779")]
	private ExtendedScrollRect scrollRect
	{
		[Token(Token = "0x6003916")]
		[Address(RVA = "0x7F2F80", Offset = "0x7F2180", VA = "0x1807F2F80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077A")]
	private List<float> entityVirtualPositions
	{
		[Token(Token = "0x6003917")]
		[Address(RVA = "0x7F2F20", Offset = "0x7F2120", VA = "0x1807F2F20")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700077B")]
	public bool isReady
	{
		[Token(Token = "0x6003918")]
		[Address(RVA = "0x7F2F60", Offset = "0x7F2160", VA = "0x1807F2F60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700077C")]
	public bool isMoving
	{
		[Token(Token = "0x6003919")]
		[Address(RVA = "0x7F2F40", Offset = "0x7F2140", VA = "0x1807F2F40")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700077D")]
	public List<ProductContainerWidget.Context> productContainerCtxs
	{
		[Token(Token = "0x600391A")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600391B")]
	[Address(RVA = "0x7EE030", Offset = "0x7ED230", VA = "0x1807EE030")]
	private int GetHeaderIdx(int categoryId, int subCategoryId, int sectionId)
	{
		return default(int);
	}

	[Token(Token = "0x600391C")]
	[Address(RVA = "0x7EEA00", Offset = "0x7EDC00", VA = "0x1807EEA00")]
	private (int, int) GetProductIdx(int shopId, int slotNo = -1)
	{
		return default((int, int));
	}

	[Token(Token = "0x600391D")]
	[Address(RVA = "0x7EDEF0", Offset = "0x7ED0F0", VA = "0x1807EDEF0")]
	private int GetHeadProductIdx(int categoryId, int subCategoryId = 0, int sectionId = 0)
	{
		return default(int);
	}

	[Token(Token = "0x600391E")]
	[Address(RVA = "0x7F1F40", Offset = "0x7F1140", VA = "0x1807F1F40")]
	public IShowcaseGruopContext TryGetShowcaseGruopContextByDataIdx(int dataIdx, int subDataIdx = 0)
	{
		return null;
	}

	[Token(Token = "0x600391F")]
	[Address(RVA = "0x7EE920", Offset = "0x7EDB20", VA = "0x1807EE920")]
	public ProductContext GetProductContextByDataIdx(int dataIdx, int containerIdx)
	{
		return null;
	}

	[Token(Token = "0x6003920")]
	[Address(RVA = "0x7F1C80", Offset = "0x7F0E80", VA = "0x1807F1C80")]
	public ProductWidget TryGetProductWidgetByShopId(int shopId, out ProductContext ctx, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x6003921")]
	[Address(RVA = "0x7F1B60", Offset = "0x7F0D60", VA = "0x1807F1B60")]
	public ProductWidget TryGetProductWidgetByDataIdx(int dataIdx, int containerIdx)
	{
		return null;
	}

	[Token(Token = "0x6003922")]
	[Address(RVA = "0x7EE1D0", Offset = "0x7ED3D0", VA = "0x1807EE1D0")]
	public (int, int, int) GetIdByCurrentPos()
	{
		return default((int, int, int));
	}

	[Token(Token = "0x6003923")]
	[Address(RVA = "0x7F2BA0", Offset = "0x7F1DA0", VA = "0x1807F2BA0")]
	public ProductListWidget(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003924")]
	[Address(RVA = "0x7EEBA0", Offset = "0x7EDDA0", VA = "0x1807EEBA0")]
	public void Initialize(IProductListWidgetHandler handler, IProductListWidgetListener listener, int reservePerFrame = 0, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6003925")]
	[Address(RVA = "0x7EFB90", Offset = "0x7EED90", VA = "0x1807EFB90")]
	private bool OnAnalogInput(Vector2 dir)
	{
		return default(bool);
	}

	[Token(Token = "0x6003926")]
	[Address(RVA = "0x7F1790", Offset = "0x7F0990", VA = "0x1807F1790")]
	public void ResetPreIdx()
	{
	}

	[Token(Token = "0x6003927")]
	[Address(RVA = "0x7F2470", Offset = "0x7F1670", VA = "0x1807F2470")]
	public void UpdateDataCount(int asyncCnt = 0, bool resetPos = true, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x6003928")]
	[Address(RVA = "0x7F2440", Offset = "0x7F1640", VA = "0x1807F2440")]
	public void UpdateContentPos()
	{
	}

	[Token(Token = "0x6003929")]
	[Address(RVA = "0x7F2780", Offset = "0x7F1980", VA = "0x1807F2780")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x600392A")]
	[Address(RVA = "0x7F27A0", Offset = "0x7F19A0", VA = "0x1807F27A0")]
	private void UpdatePadding()
	{
	}

	[Token(Token = "0x600392B")]
	[Address(RVA = "0x7ED550", Offset = "0x7EC750", VA = "0x1807ED550")]
	private void CalcCheckEntityVirtualPositions()
	{
	}

	[Token(Token = "0x600392C")]
	[Address(RVA = "0x7F1A10", Offset = "0x7F0C10", VA = "0x1807F1A10")]
	private void SetEntityVirtualPositions(int idx, float value)
	{
	}

	[Token(Token = "0x600392D")]
	[Address(RVA = "0x7F1B30", Offset = "0x7F0D30", VA = "0x1807F1B30")]
	public void SetScrollEnable(bool enable)
	{
	}

	[Token(Token = "0x600392E")]
	[Address(RVA = "0x7EDCE0", Offset = "0x7ECEE0", VA = "0x1807EDCE0")]
	public bool FocusProduct(int shopId, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false, int slotNo = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x600392F")]
	[Address(RVA = "0x7ED7F0", Offset = "0x7EC9F0", VA = "0x1807ED7F0")]
	public bool FocusHeadProduct(int categoryId, int subCategoryId = 0, int sectionId = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003930")]
	[Address(RVA = "0x7ED750", Offset = "0x7EC950", VA = "0x1807ED750")]
	public bool FocusDataIndex(int dataIdx, int contentIdx = 0, bool selectItem = true, bool isInitializeSelect = false, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003931")]
	[Address(RVA = "0x7ED960", Offset = "0x7ECB60", VA = "0x1807ED960")]
	public bool FocusHeader(int categoryId, int subCategoryId, int sectionId, bool immediate = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003932")]
	[Address(RVA = "0x7ED9B0", Offset = "0x7ECBB0", VA = "0x1807ED9B0")]
	public bool FocusPreSelectedProduct(bool selectItem = true, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003933")]
	[Address(RVA = "0x7EF500", Offset = "0x7EE700", VA = "0x1807EF500")]
	public void JumpToDirection(PadInputDirection dir)
	{
	}

	[Token(Token = "0x6003934")]
	[Address(RVA = "0x7F20E0", Offset = "0x7F12E0", VA = "0x1807F20E0")]
	public bool TrySelectInViewportTop(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6003935")]
	[Address(RVA = "0x7F1620", Offset = "0x7F0820", VA = "0x1807F1620")]
	public void ReleaseResources()
	{
	}

	[Token(Token = "0x6003936")]
	[Address(RVA = "0x7F14A0", Offset = "0x7F06A0", VA = "0x1807F14A0")]
	public void PlayUnlockMarket(int shopId, int slotNo)
	{
	}

	[Token(Token = "0x6003937")]
	[Address(RVA = "0x7EFC50", Offset = "0x7EEE50", VA = "0x1807EFC50")]
	private void OnCreatedEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6003938")]
	[Address(RVA = "0x7EFA70", Offset = "0x7EEC70", VA = "0x1807EFA70")]
	private void OnActivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6003939")]
	[Address(RVA = "0x7F0060", Offset = "0x7EF260", VA = "0x1807F0060")]
	private void OnDeactivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600393A")]
	[Address(RVA = "0x7F0140", Offset = "0x7EF340", VA = "0x1807F0140")]
	private bool OnFocusSelectEntity(GameObject entity, int dataIndex, bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600393B")]
	[Address(RVA = "0x7F17A0", Offset = "0x7F09A0", VA = "0x1807F17A0")]
	public bool SelectorSelect(bool isInitializeSelect = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600393C")]
	[Address(RVA = "0x7EF900", Offset = "0x7EEB00", VA = "0x1807EF900")]
	private (bool, float) MoveContentToFitDataPos(int dataIndex)
	{
		return default((bool, float));
	}

	[Token(Token = "0x600393D")]
	[Address(RVA = "0x7EF440", Offset = "0x7EE640", VA = "0x1807EF440")]
	private bool IsSelectableEntityIndex(int dataIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600393E")]
	[Address(RVA = "0x7F0CA0", Offset = "0x7EFEA0", VA = "0x1807F0CA0")]
	private void OnUpdateEntity(GameObject entity, int dataIdx)
	{
	}

	[Token(Token = "0x600393F")]
	[Address(RVA = "0x7F0BA0", Offset = "0x7EFDA0", VA = "0x1807F0BA0")]
	private void OnSelectedShowcaseGruop(SelectionButton button, int dataIdx, int contentIdx)
	{
	}
}
