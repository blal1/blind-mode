using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace YgomSystem.UI.InfinityScroll;

[Token(Token = "0x2000596")]
public class InfinityScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	[Token(Token = "0x4001B6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private string m_ELabelTemplate;

	[Token(Token = "0x4001B6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private string[] m_ELabelAdditionalTemplates;

	[Token(Token = "0x4001B6D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	private EntityPoolSettings m_EntityPoolSettings;

	[Token(Token = "0x4001B6E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private EntitySelectorSettings m_EntitySelectorSettings;

	[Token(Token = "0x4001B6F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private EntityPoolController m_EntityPool;

	[Token(Token = "0x4001B70")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private EntitySelectorController m_EntitySelector;

	[Token(Token = "0x4001B71")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public Action<GameObject> onCreatedEntityCallback;

	[Token(Token = "0x4001B72")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Action<GameObject> onActivateEntityCallback;

	[Token(Token = "0x4001B73")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	public Action<GameObject, int> onUpdateEntityCallback;

	[Token(Token = "0x4001B74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	public Action<GameObject, int, bool, bool> onFocusEntityCallback;

	[Token(Token = "0x4001B75")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Action<GameObject> onDeactivateEntityCallback;

	[Token(Token = "0x4001B76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Action<GameObject, int, bool> onRemoveEntityCallback;

	[Token(Token = "0x1700042E")]
	public EntityPoolSettings entityPoolSettings
	{
		[Token(Token = "0x60024D5")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700042F")]
	public EntitySelectorSettings entitySelectorSettings
	{
		[Token(Token = "0x60024D6")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000430")]
	public EntityPoolController.WaitFocusData waitFocusData
	{
		[Token(Token = "0x60024D7")]
		[Address(RVA = "0x68DD00", Offset = "0x68CF00", VA = "0x18068DD00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000431")]
	public string eLabelTemplate
	{
		[Token(Token = "0x60024D8")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
		[Token(Token = "0x60024D9")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		set
		{
		}
	}

	[Token(Token = "0x17000432")]
	public string[] eLabelAdditionalTemplates
	{
		[Token(Token = "0x60024DA")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000433")]
	public bool isReady
	{
		[Token(Token = "0x60024DB")]
		[Address(RVA = "0x68DC90", Offset = "0x68CE90", VA = "0x18068DC90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000434")]
	public bool isCompletedReserve
	{
		[Token(Token = "0x60024DC")]
		[Address(RVA = "0x68DC30", Offset = "0x68CE30", VA = "0x18068DC30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000435")]
	public bool isMoving
	{
		[Token(Token = "0x60024DD")]
		[Address(RVA = "0x68DC70", Offset = "0x68CE70", VA = "0x18068DC70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000436")]
	public IReadOnlyList<GameObject> activeEntityList
	{
		[Token(Token = "0x60024DE")]
		[Address(RVA = "0x68DAD0", Offset = "0x68CCD0", VA = "0x18068DAD0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000437")]
	public bool isHorizontal
	{
		[Token(Token = "0x60024DF")]
		[Address(RVA = "0x68DC50", Offset = "0x68CE50", VA = "0x18068DC50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000438")]
	public int dataCount
	{
		[Token(Token = "0x60024E0")]
		[Address(RVA = "0x68DBB0", Offset = "0x68CDB0", VA = "0x18068DBB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000439")]
	public bool useViewportSize
	{
		[Token(Token = "0x60024E1")]
		[Address(RVA = "0x68DCE0", Offset = "0x68CEE0", VA = "0x18068DCE0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024E2")]
		[Address(RVA = "0x68DF10", Offset = "0x68D110", VA = "0x18068DF10")]
		set
		{
		}
	}

	[Token(Token = "0x1700043A")]
	public bool useHoldSelection
	{
		[Token(Token = "0x60024E3")]
		[Address(RVA = "0x68DCC0", Offset = "0x68CEC0", VA = "0x18068DCC0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60024E4")]
		[Address(RVA = "0x68DEF0", Offset = "0x68D0F0", VA = "0x18068DEF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700043B")]
	public SelectionItem holdSelection
	{
		[Token(Token = "0x60024E5")]
		[Address(RVA = "0x68DC10", Offset = "0x68CE10", VA = "0x18068DC10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700043C")]
	public Func<int, (bool customized, float targetPos)> customMoveContentToFitDataFunc
	{
		[Token(Token = "0x60024F4")]
		[Address(RVA = "0x68DDE0", Offset = "0x68CFE0", VA = "0x18068DDE0")]
		set
		{
		}
	}

	[Token(Token = "0x1700043D")]
	public int constraintCount
	{
		[Token(Token = "0x60024F5")]
		[Address(RVA = "0x68DB10", Offset = "0x68CD10", VA = "0x18068DB10")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700043E")]
	public int activeEntityLineCount
	{
		[Token(Token = "0x60024F6")]
		[Address(RVA = "0x68DAB0", Offset = "0x68CCB0", VA = "0x18068DAB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700043F")]
	public Func<Vector2, Vector2, bool> dragStarterFunc
	{
		[Token(Token = "0x6002511")]
		[Address(RVA = "0x68DE60", Offset = "0x68D060", VA = "0x18068DE60")]
		set
		{
		}
	}

	[Token(Token = "0x17000440")]
	public Func<bool, bool> onSelectorSelectoredFunc
	{
		[Token(Token = "0x6002512")]
		[Address(RVA = "0x68DEC0", Offset = "0x68D0C0", VA = "0x18068DEC0")]
		set
		{
		}
	}

	[Token(Token = "0x17000441")]
	public int defaultIdx
	{
		[Token(Token = "0x6002513")]
		[Address(RVA = "0x68DBD0", Offset = "0x68CDD0", VA = "0x18068DBD0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002514")]
		[Address(RVA = "0x68DE40", Offset = "0x68D040", VA = "0x18068DE40")]
		set
		{
		}
	}

	[Token(Token = "0x17000442")]
	public int currentIdx
	{
		[Token(Token = "0x6002515")]
		[Address(RVA = "0x68DB50", Offset = "0x68CD50", VA = "0x18068DB50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000443")]
	public int currentSubIdxX
	{
		[Token(Token = "0x6002516")]
		[Address(RVA = "0x68DB70", Offset = "0x68CD70", VA = "0x18068DB70")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000444")]
	public int currentSubIdxY
	{
		[Token(Token = "0x6002517")]
		[Address(RVA = "0x68DB90", Offset = "0x68CD90", VA = "0x18068DB90")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000445")]
	public int contentCount
	{
		[Token(Token = "0x6002518")]
		[Address(RVA = "0x68DB30", Offset = "0x68CD30", VA = "0x18068DB30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000446")]
	public int beginIdx
	{
		[Token(Token = "0x6002519")]
		[Address(RVA = "0x68DAF0", Offset = "0x68CCF0", VA = "0x18068DAF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000447")]
	public int endIdx
	{
		[Token(Token = "0x600251A")]
		[Address(RVA = "0x68DBF0", Offset = "0x68CDF0", VA = "0x18068DBF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000448")]
	public Func<int, bool> isSelectableDataIndexFunc
	{
		[Token(Token = "0x600251B")]
		[Address(RVA = "0x68DE90", Offset = "0x68D090", VA = "0x18068DE90")]
		set
		{
		}
	}

	[Token(Token = "0x17000449")]
	public Func<GameObject, IReadOnlyList<(SelectionItem selectionItem, int xPos, int yPos)>> customCollectSelectionItemsFunc
	{
		[Token(Token = "0x600251C")]
		[Address(RVA = "0x68DD50", Offset = "0x68CF50", VA = "0x18068DD50")]
		set
		{
		}
	}

	[Token(Token = "0x1700044A")]
	public Func<SelectionItem, PadInputDirection, bool> customEdgeTransitionFunc
	{
		[Token(Token = "0x600251D")]
		[Address(RVA = "0x68DD80", Offset = "0x68CF80", VA = "0x18068DD80")]
		set
		{
		}
	}

	[Token(Token = "0x1700044B")]
	public Func<SelectionItem, PadInputDirection, bool> customInnerTransitionFunc
	{
		[Token(Token = "0x600251E")]
		[Address(RVA = "0x68DDB0", Offset = "0x68CFB0", VA = "0x18068DDB0")]
		set
		{
		}
	}

	[Token(Token = "0x1700044C")]
	public Func<GameObject, int, bool, bool> customOnFocusSelectFunc
	{
		[Token(Token = "0x600251F")]
		[Address(RVA = "0x68DE10", Offset = "0x68D010", VA = "0x18068DE10")]
		set
		{
		}
	}

	[Token(Token = "0x1700044D")]
	public Func<Vector2, bool> customAnalogInputFunc
	{
		[Token(Token = "0x6002520")]
		[Address(RVA = "0x68DD20", Offset = "0x68CF20", VA = "0x18068DD20")]
		set
		{
		}
	}

	[Token(Token = "0x60024D4")]
	[Address(RVA = "0x68D2D0", Offset = "0x68C4D0", VA = "0x18068D2D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x60024E6")]
	[Address(RVA = "0x68D1F0", Offset = "0x68C3F0", VA = "0x18068D1F0")]
	public void Initialize()
	{
	}

	[Token(Token = "0x60024E7")]
	[Address(RVA = "0x68D1C0", Offset = "0x68C3C0", VA = "0x18068D1C0")]
	public void Initialize(Action onCompleteCallback)
	{
	}

	[Token(Token = "0x60024E8")]
	[Address(RVA = "0x68CAF0", Offset = "0x68BCF0", VA = "0x18068CAF0")]
	public void Initialize([Optional] GameObject template, [Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x60024E9")]
	[Address(RVA = "0x68CAC0", Offset = "0x68BCC0", VA = "0x18068CAC0")]
	public void Initialize([Optional] List<GameObject> templates, [Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x60024EA")]
	[Address(RVA = "0x68CC10", Offset = "0x68BE10", VA = "0x18068CC10")]
	public void Initialize([Optional] EntityPoolController entityPool, [Optional] EntitySelectorController entitySelector, [Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x60024EB")]
	[Address(RVA = "0x68CC30", Offset = "0x68BE30", VA = "0x18068CC30")]
	public void Initialize([Optional] EntityPoolController entityPool, [Optional] EntitySelectorController entitySelector, [Optional] List<GameObject> templates, [Optional] Action onCompleteCallback)
	{
	}

	[Token(Token = "0x60024EC")]
	[Address(RVA = "0x68D390", Offset = "0x68C590", VA = "0x18068D390")]
	private void OnCreateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x60024ED")]
	[Address(RVA = "0x68D320", Offset = "0x68C520", VA = "0x18068D320")]
	private void OnActivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x60024EE")]
	[Address(RVA = "0x68D570", Offset = "0x68C770", VA = "0x18068D570")]
	private void OnUpdateEntity(GameObject entity, int dataindex)
	{
	}

	[Token(Token = "0x60024EF")]
	[Address(RVA = "0x68D450", Offset = "0x68C650", VA = "0x18068D450")]
	private void OnFocusEntity(GameObject entity, int dataindex, bool selectItem, bool isInitializeSelect = false)
	{
	}

	[Token(Token = "0x60024F0")]
	[Address(RVA = "0x68D3E0", Offset = "0x68C5E0", VA = "0x18068D3E0")]
	private void OnDeactivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x60024F1")]
	[Address(RVA = "0x68D4F0", Offset = "0x68C6F0", VA = "0x18068D4F0")]
	private void OnRemoveEntity(GameObject entity, int dataindex, bool isTop)
	{
	}

	[Token(Token = "0x60024F2")]
	[Address(RVA = "0x68D430", Offset = "0x68C630", VA = "0x18068D430")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x60024F3")]
	[Address(RVA = "0x68D370", Offset = "0x68C570", VA = "0x18068D370", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x60024F7")]
	[Address(RVA = "0x68D600", Offset = "0x68C800", VA = "0x18068D600")]
	public void ReserveTemplate(int templateIdx = 0, int asyncPerFrame = 0, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x68D700", Offset = "0x68C900", VA = "0x18068D700")]
	public void TerminateReserve()
	{
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x68D810", Offset = "0x68CA10", VA = "0x18068D810")]
	public void UpdateDataCount(int dataCount, [Optional] List<int> templateList)
	{
	}

	[Token(Token = "0x60024FA")]
	[Address(RVA = "0x68D7E0", Offset = "0x68C9E0", VA = "0x18068D7E0")]
	public void UpdateDataCountAsync(int dataCount, [Optional] List<int> templateList, int updatePerFrame = 1, [Optional] Action onComplete)
	{
	}

	[Token(Token = "0x60024FB")]
	[Address(RVA = "0x68D840", Offset = "0x68CA40", VA = "0x18068D840")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x60024FC")]
	[Address(RVA = "0x68D630", Offset = "0x68C830", VA = "0x18068D630")]
	public void ResetContentPosition()
	{
	}

	[Token(Token = "0x60024FD")]
	[Address(RVA = "0x68C8B0", Offset = "0x68BAB0", VA = "0x18068C8B0")]
	public bool FocusItemByDataIndex(int dataindex, bool selectItem = true, bool isInitializeSelect = false, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x60024FE")]
	[Address(RVA = "0x68D720", Offset = "0x68C920", VA = "0x18068D720")]
	public bool TryFocusInnerViewport(bool selectItem, bool isInitializeSelect = false, [Optional] Action onComplete)
	{
		return default(bool);
	}

	[Token(Token = "0x60024FF")]
	[Address(RVA = "0x68D780", Offset = "0x68C980", VA = "0x18068D780")]
	public bool TrySelectInnerViewport(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002500")]
	[Address(RVA = "0x68CA80", Offset = "0x68BC80", VA = "0x18068CA80")]
	public float GetTemplateSizeAlongScrollDirection(int templateIdx)
	{
		return default(float);
	}

	[Token(Token = "0x6002501")]
	[Address(RVA = "0x68C900", Offset = "0x68BB00", VA = "0x18068C900")]
	public GameObject GetEntityByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x6002502")]
	public T GetEntityByDataIndex<T>(int dataindex)
	{
		return (T)null;
	}

	[Token(Token = "0x6002503")]
	[Address(RVA = "0x68C940", Offset = "0x68BB40", VA = "0x18068C940")]
	public int GetLineByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x6002504")]
	[Address(RVA = "0x68C8E0", Offset = "0x68BAE0", VA = "0x18068C8E0")]
	public int GetDataIndexByEntity(GameObject entity)
	{
		return default(int);
	}

	[Token(Token = "0x6002505")]
	[Address(RVA = "0x68C960", Offset = "0x68BB60", VA = "0x18068C960")]
	public (int, int) GetListPosByDataIndex(int dataIdx)
	{
		return default((int, int));
	}

	[Token(Token = "0x6002506")]
	[Address(RVA = "0x68CA00", Offset = "0x68BC00", VA = "0x18068CA00")]
	public int GetTemplateIndexByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x6002507")]
	[Address(RVA = "0x68CA20", Offset = "0x68BC20", VA = "0x18068CA20")]
	public int GetTemplateIndexByEntity(GameObject entity)
	{
		return default(int);
	}

	[Token(Token = "0x6002508")]
	[Address(RVA = "0x68C9E0", Offset = "0x68BBE0", VA = "0x18068C9E0")]
	public int GetSideIndex(int frontIdx, PadInputDirection sideDirection)
	{
		return default(int);
	}

	[Token(Token = "0x6002509")]
	[Address(RVA = "0x68D220", Offset = "0x68C420", VA = "0x18068D220")]
	public bool IsEdgeByDataIndex(int dataindex, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x600250A")]
	[Address(RVA = "0x68CAA0", Offset = "0x68BCA0", VA = "0x18068CAA0")]
	public void ImmediateApplyMovement()
	{
	}

	[Token(Token = "0x600250B")]
	[Address(RVA = "0x68D7C0", Offset = "0x68C9C0", VA = "0x18068D7C0")]
	public void UpdateContentPos(bool withRebuildLayout = false)
	{
	}

	[Token(Token = "0x600250C")]
	[Address(RVA = "0x68D6E0", Offset = "0x68C8E0", VA = "0x18068D6E0")]
	public void StopAutoScroll()
	{
	}

	[Token(Token = "0x600250D")]
	[Address(RVA = "0x68CA40", Offset = "0x68BC40", VA = "0x18068CA40")]
	public string GetTemplateLabelByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x600250E")]
	[Address(RVA = "0x68CA60", Offset = "0x68BC60", VA = "0x18068CA60")]
	public string GetTemplateLabelByTemplateIndex(int templateindex)
	{
		return null;
	}

	[Token(Token = "0x600250F")]
	[Address(RVA = "0x68D870", Offset = "0x68CA70", VA = "0x18068D870")]
	public void UpdatePaddingSize()
	{
	}

	[Token(Token = "0x6002510")]
	[Address(RVA = "0x68D890", Offset = "0x68CA90", VA = "0x18068D890")]
	public void UpdateViewportRectSize()
	{
	}

	[Token(Token = "0x6002521")]
	[Address(RVA = "0x68C920", Offset = "0x68BB20", VA = "0x18068C920")]
	public GameObject GetEntityBySelectionItem(SelectionItem selectionItem)
	{
		return null;
	}

	[Token(Token = "0x6002522")]
	[Address(RVA = "0x68C9C0", Offset = "0x68BBC0", VA = "0x18068C9C0")]
	public List<SelectionItem> GetSelectionItemsByEntity(GameObject entity)
	{
		return null;
	}

	[Token(Token = "0x6002523")]
	[Address(RVA = "0x68D670", Offset = "0x68C870", VA = "0x18068D670")]
	public bool SelectorSelect(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002524")]
	[Address(RVA = "0x68D750", Offset = "0x68C950", VA = "0x18068D750")]
	public bool TrySelectIdx(int dataIdx, int xPos = 0, int yPos = 0, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002525")]
	[Address(RVA = "0x68D6B0", Offset = "0x68C8B0", VA = "0x18068D6B0")]
	public void SetSelectorIdx(int dataIdx = -1, int subIdxX = -1, int subIdxY = -1)
	{
	}

	[Token(Token = "0x6002526")]
	[Address(RVA = "0x68D2A0", Offset = "0x68C4A0", VA = "0x18068D2A0")]
	public bool JumpToDirection(PadInputDirection direction, bool selectItem = true, bool isInitializeSelect = false, int jumpLength = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x6002527")]
	[Address(RVA = "0x68D240", Offset = "0x68C440", VA = "0x18068D240")]
	public bool IsFractionIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6002528")]
	[Address(RVA = "0x68C980", Offset = "0x68BB80", VA = "0x18068C980")]
	public Dictionary<SelectionItem, int> GetSelectionItemXMap()
	{
		return null;
	}

	[Token(Token = "0x6002529")]
	[Address(RVA = "0x68C9A0", Offset = "0x68BBA0", VA = "0x18068C9A0")]
	public Dictionary<SelectionItem, int> GetSelectionItemYMap()
	{
		return null;
	}

	[Token(Token = "0x600252A")]
	[Address(RVA = "0x68D280", Offset = "0x68C480", VA = "0x18068D280")]
	public bool IsSelectableDataIndex(int dataIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x600252B")]
	[Address(RVA = "0x68D260", Offset = "0x68C460", VA = "0x18068D260")]
	public bool IsRegistedSelectionItem(SelectionItem selectionItem)
	{
		return default(bool);
	}

	[Token(Token = "0x600252C")]
	[Address(RVA = "0x68D5D0", Offset = "0x68C7D0", VA = "0x18068D5D0")]
	public void RegistSelectionItem(GameObject entity, SelectionItem selectionItem, int xPos, int yPos, int dataindex = -1)
	{
	}

	[Token(Token = "0x600252D")]
	[Address(RVA = "0x68D7A0", Offset = "0x68C9A0", VA = "0x18068D7A0")]
	public void UnregistSelectionItem([Optional] GameObject entity, [Optional] SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x600252E")]
	[Address(RVA = "0x68D690", Offset = "0x68C890", VA = "0x18068D690")]
	public void SetAnalogInputScroll(SelectionItem analogStickSelectionItem, SelectorManager.AnalogType analogType = SelectorManager.AnalogType.Sub)
	{
	}

	[Token(Token = "0x600252F")]
	[Address(RVA = "0x68D8B0", Offset = "0x68CAB0", VA = "0x18068D8B0")]
	public InfinityScrollView()
	{
	}
}
