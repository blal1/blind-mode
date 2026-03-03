using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.InfinityScroll;

[Token(Token = "0x2000591")]
public class EntitySelectorController
{
	[Token(Token = "0x2000592")]
	public class SelectionItemSearcher
	{
		[Token(Token = "0x4001B55")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private List<SelectionItem> m_SearchItems;

		[Token(Token = "0x4001B56")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private Dictionary<SelectionItem, int> m_SearchItemDataIdxMap;

		[Token(Token = "0x4001B57")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private Dictionary<SelectionItem, (int x, int y)> m_SearchItemDataPosMap;

		[Token(Token = "0x17000426")]
		public List<SelectionItem> searchItems
		{
			[Token(Token = "0x60024BA")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60024BB")]
		[Address(RVA = "0x6681B0", Offset = "0x6673B0", VA = "0x1806681B0")]
		public List<SelectionItem> SearchAsAnalogScroll(InfinityScrollView scrollView, ScrollRect scrollRect, SelectionItem selectedItem, PadInputDirection dir, EntitySelectorSettings settings)
		{
			return null;
		}

		[Token(Token = "0x60024BC")]
		[Address(RVA = "0x668110", Offset = "0x667310", VA = "0x180668110")]
		public static float CalcDistanceAmount(Vector2 fromPos, SelectionItem checkItem, Vector2 dir)
		{
			return default(float);
		}

		[Token(Token = "0x60024BD")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public SelectionItemSearcher()
		{
		}
	}

	[Token(Token = "0x4001B3A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private EntitySelectorSettings m_SelectorSettings;

	[Token(Token = "0x4001B3B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private InfinityScrollView m_Owner;

	[Token(Token = "0x4001B3C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Selector m_Selector;

	[Token(Token = "0x4001B3D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private ScrollRect m_ScrollRectCache;

	[Token(Token = "0x4001B3E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private GridLayoutGroup.Axis m_ScrollAxis;

	[Token(Token = "0x4001B3F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private bool m_UseHoldSelection;

	[Token(Token = "0x4001B40")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private SelectionItem m_HoldSelection;

	[Token(Token = "0x4001B41")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private SelectionItem m_InputAnalogStickItem;

	[Token(Token = "0x4001B42")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private readonly Dictionary<SelectionItem, int> m_SelectionItemXMap;

	[Token(Token = "0x4001B43")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private readonly Dictionary<SelectionItem, int> m_SelectionItemYMap;

	[Token(Token = "0x4001B44")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private readonly Dictionary<GameObject, List<SelectionItem>> m_EntitySelectionItemsMap;

	[Token(Token = "0x4001B45")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private List<SelectionItem> m_TmpSearchSelectionItems;

	[Token(Token = "0x4001B46")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SelectionItem> m_InitializedSelectionItems;

	[Token(Token = "0x4001B47")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	public Func<GameObject, IReadOnlyList<(SelectionItem selectionItem, int xPos, int yPos)>> customCollectSelectionItemsFunc;

	[Token(Token = "0x4001B48")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	public Func<int, bool> isSelectableDataIndexFunc;

	[Token(Token = "0x4001B49")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	public Func<SelectionItem, PadInputDirection, bool> customEdgeTransitionFunc;

	[Token(Token = "0x4001B4A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	public Func<SelectionItem, PadInputDirection, bool> customInnerTransitionFunc;

	[Token(Token = "0x4001B4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	public Func<GameObject, int, bool, bool> customOnFocusSelectFunc;

	[Token(Token = "0x4001B4C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	public Func<Vector2, bool> customAnalogInputFunc;

	[Token(Token = "0x4001B4D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	public Func<Vector2, Vector2, bool> m_DragStarterFunc;

	[Token(Token = "0x4001B4E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	public Func<bool, bool> m_OnSelectorSelectedFunc;

	[Token(Token = "0x4001B53")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool m_AnalogInputScrollActivated;

	[Token(Token = "0x4001B54")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private SelectionItemSearcher m_SelectionItemSearcher;

	[Token(Token = "0x17000418")]
	private ScrollRect scrollRect
	{
		[Token(Token = "0x6002480")]
		[Address(RVA = "0x667F10", Offset = "0x667110", VA = "0x180667F10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000419")]
	public Dictionary<SelectionItem, int> SelectionItemXMap
	{
		[Token(Token = "0x6002481")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041A")]
	public Dictionary<SelectionItem, int> SelectionItemYMap
	{
		[Token(Token = "0x6002482")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041B")]
	public bool isReady
	{
		[Token(Token = "0x6002483")]
		[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700041C")]
	public bool useHoldSelection
	{
		[Token(Token = "0x6002484")]
		[Address(RVA = "0x4166A0", Offset = "0x4158A0", VA = "0x1804166A0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002485")]
		[Address(RVA = "0x416700", Offset = "0x415900", VA = "0x180416700")]
		set
		{
		}
	}

	[Token(Token = "0x1700041D")]
	public SelectionItem holdSelection
	{
		[Token(Token = "0x6002486")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041E")]
	public GameObject selectedEntity
	{
		[Token(Token = "0x6002487")]
		[Address(RVA = "0x668060", Offset = "0x667260", VA = "0x180668060")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700041F")]
	public int selectedEntityIndex
	{
		[Token(Token = "0x6002488")]
		[Address(RVA = "0x667FB0", Offset = "0x6671B0", VA = "0x180667FB0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000420")]
	public Func<Vector2, Vector2, bool> dragStarterFunc
	{
		[Token(Token = "0x6002489")]
		[Address(RVA = "0x42FF10", Offset = "0x42F110", VA = "0x18042FF10")]
		set
		{
		}
	}

	[Token(Token = "0x17000421")]
	public Func<bool, bool> onSelectorSelectoredFunc
	{
		[Token(Token = "0x600248A")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		set
		{
		}
	}

	[Token(Token = "0x17000422")]
	public int defaultIdx
	{
		[Token(Token = "0x600248B")]
		[Address(RVA = "0x42D5D0", Offset = "0x42C7D0", VA = "0x18042D5D0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600248C")]
		[Address(RVA = "0x42D680", Offset = "0x42C880", VA = "0x18042D680")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17000423")]
	public int currentIdx
	{
		[Token(Token = "0x600248D")]
		[Address(RVA = "0x42D600", Offset = "0x42C800", VA = "0x18042D600")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600248E")]
		[Address(RVA = "0x42D6B0", Offset = "0x42C8B0", VA = "0x18042D6B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000424")]
	public int currentSubIdxX
	{
		[Token(Token = "0x600248F")]
		[Address(RVA = "0x667EF0", Offset = "0x6670F0", VA = "0x180667EF0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002490")]
		[Address(RVA = "0x6680F0", Offset = "0x6672F0", VA = "0x1806680F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000425")]
	public int currentSubIdxY
	{
		[Token(Token = "0x6002491")]
		[Address(RVA = "0x667F00", Offset = "0x667100", VA = "0x180667F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002492")]
		[Address(RVA = "0x668100", Offset = "0x667300", VA = "0x180668100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x6002493")]
	[Address(RVA = "0x666BC0", Offset = "0x665DC0", VA = "0x180666BC0")]
	private SelectionItem SearchSelectedEntityItem()
	{
		return null;
	}

	[Token(Token = "0x6002494")]
	[Address(RVA = "0x663050", Offset = "0x662250", VA = "0x180663050")]
	public void Initialize(EntitySelectorSettings selectorSettings, InfinityScrollView owner, Selector selector, [Optional] Action onComplete, GridLayoutGroup.Axis axis = GridLayoutGroup.Axis.Vertical)
	{
	}

	[Token(Token = "0x6002495")]
	[Address(RVA = "0x662780", Offset = "0x661980", VA = "0x180662780")]
	private Vector2 GetAnalogScrollInput()
	{
		return default(Vector2);
	}

	[Token(Token = "0x6002496")]
	[Address(RVA = "0x664340", Offset = "0x663540", VA = "0x180664340")]
	public void OnCreateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6002497")]
	[Address(RVA = "0x663DE0", Offset = "0x662FE0", VA = "0x180663DE0")]
	public void OnActivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x6002498")]
	[Address(RVA = "0x666540", Offset = "0x665740", VA = "0x180666540")]
	public void OnUpdateEntity(GameObject entity, int dataindex)
	{
	}

	[Token(Token = "0x6002499")]
	[Address(RVA = "0x6658F0", Offset = "0x664AF0", VA = "0x1806658F0")]
	public void OnFocusEntity(GameObject entity, int dataindex, bool selectItem, bool isInitializeSelect = false)
	{
	}

	[Token(Token = "0x600249A")]
	[Address(RVA = "0x664680", Offset = "0x663880", VA = "0x180664680")]
	public void OnDeactivateEntity(GameObject entity)
	{
	}

	[Token(Token = "0x600249B")]
	[Address(RVA = "0x666FF0", Offset = "0x6661F0", VA = "0x180666FF0")]
	private void SetTransitionModeAsEdge(SelectionItem selectionItem, PadInputDirection direction)
	{
	}

	[Token(Token = "0x600249C")]
	[Address(RVA = "0x667040", Offset = "0x666240", VA = "0x180667040")]
	private void SetTransitionModeAsFraction(SelectionItem selectionItem, PadInputDirection direction)
	{
	}

	[Token(Token = "0x600249D")]
	[Address(RVA = "0x667040", Offset = "0x666240", VA = "0x180667040")]
	private void SetTransitionModeAsInner(SelectionItem selectionItem, PadInputDirection direction)
	{
	}

	[Token(Token = "0x600249E")]
	[Address(RVA = "0x666020", Offset = "0x665220", VA = "0x180666020")]
	private void OnSelectedItem(SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x600249F")]
	[Address(RVA = "0x666E60", Offset = "0x666060", VA = "0x180666E60")]
	public bool SelectorSelect(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x6661C0", Offset = "0x6653C0", VA = "0x1806661C0")]
	private bool OnSelectorSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60024A1")]
	[Address(RVA = "0x664AA0", Offset = "0x663CA0", VA = "0x180664AA0")]
	private void OnEntityPadInput(SelectionItem selectionItem, PadInputDirection direction)
	{
	}

	[Token(Token = "0x60024A2")]
	[Address(RVA = "0x665F80", Offset = "0x665180", VA = "0x180665F80")]
	private void OnHoldSelectionPadInput()
	{
	}

	[Token(Token = "0x60024A3")]
	[Address(RVA = "0x666BA0", Offset = "0x665DA0", VA = "0x180666BA0")]
	public void ResetContentPosition()
	{
	}

	[Token(Token = "0x60024A4")]
	[Address(RVA = "0x663820", Offset = "0x662A20", VA = "0x180663820")]
	public bool IsSelectableDataIndex(int dataIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60024A5")]
	[Address(RVA = "0x662B10", Offset = "0x661D10", VA = "0x180662B10")]
	public int GetSelectableSideIndex(int dataIndex, PadInputDirection direction)
	{
		return default(int);
	}

	[Token(Token = "0x60024A6")]
	[Address(RVA = "0x6633E0", Offset = "0x6625E0", VA = "0x1806633E0")]
	public bool IsEdgeSelectableDataIndex(int dataIndex, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60024A7")]
	[Address(RVA = "0x663400", Offset = "0x662600", VA = "0x180663400")]
	public bool IsEdgeSelectionItem(SelectionItem selectionItem, PadInputDirection direction)
	{
		return default(bool);
	}

	[Token(Token = "0x60024A8")]
	[Address(RVA = "0x662980", Offset = "0x661B80", VA = "0x180662980")]
	public GameObject GetEntityBySelectionItem(SelectionItem selectionItem)
	{
		return null;
	}

	[Token(Token = "0x60024A9")]
	[Address(RVA = "0x662BC0", Offset = "0x661DC0", VA = "0x180662BC0")]
	public List<SelectionItem> GetSelectionItemsByEntity(GameObject entity)
	{
		return null;
	}

	[Token(Token = "0x60024AA")]
	[Address(RVA = "0x667070", Offset = "0x666270", VA = "0x180667070")]
	public bool TrySelectIdx(int dataIdx, int xPos = 0, int yPos = 0, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AB")]
	[Address(RVA = "0x666FC0", Offset = "0x6661C0", VA = "0x180666FC0")]
	public void SetSelectorIdx(int dataIdx = -1, int subIdxX = -1, int subIdxY = -1)
	{
	}

	[Token(Token = "0x60024AC")]
	[Address(RVA = "0x6672D0", Offset = "0x6664D0", VA = "0x1806672D0")]
	public bool TrySelectInnerViewport(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AD")]
	[Address(RVA = "0x663890", Offset = "0x662A90", VA = "0x180663890")]
	public bool JumpToDirection(PadInputDirection direction, bool selectItem = true, bool isInitializeSelect = false, int jumpLength = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AE")]
	[Address(RVA = "0x6637C0", Offset = "0x6629C0", VA = "0x1806637C0")]
	public bool IsRegistedSelectionItem(SelectionItem selectionItem)
	{
		return default(bool);
	}

	[Token(Token = "0x60024AF")]
	[Address(RVA = "0x662C50", Offset = "0x661E50", VA = "0x180662C50")]
	private void InitSelectionItems(SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x60024B0")]
	[Address(RVA = "0x6669A0", Offset = "0x665BA0", VA = "0x1806669A0")]
	public void RegistSelectionItem(GameObject entity, SelectionItem selectionItem, int xPos, int yPos, int dataindex = -1)
	{
	}

	[Token(Token = "0x60024B1")]
	[Address(RVA = "0x667790", Offset = "0x666990", VA = "0x180667790")]
	public void UnregistSelectionItem([Optional] GameObject entity, [Optional] SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x60024B2")]
	[Address(RVA = "0x666430", Offset = "0x665630", VA = "0x180666430")]
	private bool OnShortCutAnalogInput(Vector2 mainVec)
	{
		return default(bool);
	}

	[Token(Token = "0x60024B3")]
	[Address(RVA = "0x666F10", Offset = "0x666110", VA = "0x180666F10")]
	public void SetAnalogInputScroll(SelectionItem analogStickSelectionItem, SelectorManager.AnalogType analogType = SelectorManager.AnalogType.Sub)
	{
	}

	[Token(Token = "0x60024B4")]
	[Address(RVA = "0x663F50", Offset = "0x663150", VA = "0x180663F50")]
	public void OnAnalogInput(Vector2 dir)
	{
	}

	[Token(Token = "0x60024B5")]
	[Address(RVA = "0x667D70", Offset = "0x666F70", VA = "0x180667D70")]
	public EntitySelectorController()
	{
	}
}
