using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using YgomGame.Duel;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomDebug;

[Token(Token = "0x2000126")]
[RequireComponent(typeof(ElementObjectManager))]
public class DuelLogScrollViewForAnalysis : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	[Token(Token = "0x2000127")]
	public class OnItemUpdate : UnityEvent<GameObject, int>
	{
		[Token(Token = "0x6000786")]
		[Address(RVA = "0x9E3290", Offset = "0x9E2490", VA = "0x1809E3290")]
		public OnItemUpdate()
		{
		}
	}

	[Token(Token = "0x40006FF")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Dictionary<string, GetInt> m_DataNumDict;

	[Token(Token = "0x4000700")]
	[FieldOffset(Offset = "0x28")]
	public OnItemUpdate onItemUpdate;

	[Token(Token = "0x4000701")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onReady;

	[Token(Token = "0x4000702")]
	[FieldOffset(Offset = "0x38")]
	public bool autoScroll;

	[Token(Token = "0x4000703")]
	[FieldOffset(Offset = "0x40")]
	protected Dictionary<string, Stack<Transform>> m_ItemStackDict;

	[Token(Token = "0x4000704")]
	[FieldOffset(Offset = "0x48")]
	protected Dictionary<string, GameObject> m_PrehabDict;

	[Token(Token = "0x4000705")]
	[FieldOffset(Offset = "0x50")]
	protected List<string> m_TemplateLabelList;

	[Token(Token = "0x4000706")]
	[FieldOffset(Offset = "0x58")]
	protected List<string> m_DataLabelList;

	[Token(Token = "0x4000707")]
	[FieldOffset(Offset = "0x60")]
	protected List<float> m_ItemBiaslList;

	[Token(Token = "0x4000708")]
	[FieldOffset(Offset = "0x68")]
	protected List<GameObject> m_UsedItemQueue;

	[Token(Token = "0x4000709")]
	[FieldOffset(Offset = "0x70")]
	protected ElementObjectManager m_EOManager;

	[Token(Token = "0x400070A")]
	[FieldOffset(Offset = "0x78")]
	protected RectTransform m_ContentRT;

	[Token(Token = "0x400070B")]
	[FieldOffset(Offset = "0x80")]
	protected RectTransform m_ViewportRT;

	[Token(Token = "0x400070C")]
	[FieldOffset(Offset = "0x88")]
	protected RectTransform m_ScrollViewRT;

	[Token(Token = "0x400070D")]
	[FieldOffset(Offset = "0x90")]
	protected Selector m_Selector;

	[Token(Token = "0x400070E")]
	[FieldOffset(Offset = "0x98")]
	protected ExtendedScrollRect m_ScrollRect;

	[Token(Token = "0x400070F")]
	private const string LABEL_EO_CONTENT = "content";

	[Token(Token = "0x4000710")]
	private const string LABEL_EO_VIEWPORT = "viewport";

	[Token(Token = "0x4000711")]
	private const string LABEL_EO_HIDDENPORT = "hiddenport";

	[Token(Token = "0x4000712")]
	private const string LABEL_EO_PANEL = "AutoScrollPanel";

	[Token(Token = "0x4000713")]
	private const string LABEL_EO_STATUE = "AutoScrollStatue";

	[Token(Token = "0x4000714")]
	private const string LABEL_EO_SCROLLBAR = "ScrollBar";

	[Token(Token = "0x4000715")]
	[FieldOffset(Offset = "0xA0")]
	private int m_InitialTopPadding;

	[Token(Token = "0x4000716")]
	[FieldOffset(Offset = "0xA4")]
	private int m_TopitemDataindex;

	[Token(Token = "0x170000AD")]
	public int topitemDataindex
	{
		[Token(Token = "0x6000757")]
		[Address(RVA = "0x80F760", Offset = "0x80E960", VA = "0x18080F760")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000AE")]
	public int bottomitemDataindex
	{
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x9D4F50", Offset = "0x9D4150", VA = "0x1809D4F50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000AF")]
	public Selector selector
	{
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B0")]
	public ExtendedScrollRect scrollrect
	{
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B1")]
	protected float m_Spacing
	{
		[Token(Token = "0x600075B")]
		[Address(RVA = "0x9D50C0", Offset = "0x9D42C0", VA = "0x1809D50C0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000B2")]
	private int m_BottomitemDataindex
	{
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x9D4F50", Offset = "0x9D4150", VA = "0x1809D4F50")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170000B3")]
	private SelectionItem[] m_TopSelectionItems
	{
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x9D5110", Offset = "0x9D4310", VA = "0x1809D5110")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000B4")]
	private SelectionItem[] m_BottomSelectionItems
	{
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x9D4FA0", Offset = "0x9D41A0", VA = "0x1809D4FA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600075F")]
	[Address(RVA = "0x9D2A70", Offset = "0x9D1C70", VA = "0x1809D2A70")]
	public void Initialzize(ref List<string> templateLabelList)
	{
	}

	[Token(Token = "0x6000760")]
	[Address(RVA = "0x9D31F0", Offset = "0x9D23F0", VA = "0x1809D31F0")]
	public bool IsTopItem(SelectionItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000761")]
	[Address(RVA = "0x9D3120", Offset = "0x9D2320", VA = "0x1809D3120")]
	public bool IsBottomItem(SelectionItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000762")]
	[Address(RVA = "0x81BD60", Offset = "0x81AF60", VA = "0x18081BD60")]
	public void UpdateDataLabelList(List<string> datalabellist)
	{
	}

	[Token(Token = "0x6000763")]
	[Address(RVA = "0x9D1BF0", Offset = "0x9D0DF0", VA = "0x1809D1BF0")]
	public void AddDataLabel(string label)
	{
	}

	[Token(Token = "0x6000764")]
	[Address(RVA = "0x9D28D0", Offset = "0x9D1AD0", VA = "0x1809D28D0")]
	public RectTransform GetTopItemRT()
	{
		return null;
	}

	[Token(Token = "0x6000765")]
	[Address(RVA = "0x9D2430", Offset = "0x9D1630", VA = "0x1809D2430")]
	public RectTransform GetBottomItemRT()
	{
		return null;
	}

	[Token(Token = "0x6000766")]
	[Address(RVA = "0x9D24C0", Offset = "0x9D16C0", VA = "0x1809D24C0")]
	public SelectionItem GetBottomSItem()
	{
		return null;
	}

	[Token(Token = "0x6000767")]
	[Address(RVA = "0x9D2960", Offset = "0x9D1B60", VA = "0x1809D2960")]
	public SelectionItem GetTopSItem()
	{
		return null;
	}

	[Token(Token = "0x6000768")]
	[Address(RVA = "0x9D4560", Offset = "0x9D3760", VA = "0x1809D4560")]
	public void UpdateContent()
	{
	}

	[Token(Token = "0x6000769")]
	[Address(RVA = "0x9D3FC0", Offset = "0x9D31C0", VA = "0x1809D3FC0")]
	protected void SetSbtnPairRightTransition(SelectionItemPair sbtnpair)
	{
	}

	[Token(Token = "0x600076A")]
	[Address(RVA = "0x9D3F20", Offset = "0x9D3120", VA = "0x1809D3F20")]
	protected void SetSbtnPairLeftTransition(SelectionItemPair sbtnpair)
	{
	}

	[Token(Token = "0x600076B")]
	[Address(RVA = "0x9D4060", Offset = "0x9D3260", VA = "0x1809D4060")]
	protected void SetSbtnPairVerticalTransition(SelectionItemPair sbtnpair0, SelectionItemPair sbtnpair1)
	{
	}

	[Token(Token = "0x600076C")]
	[Address(RVA = "0x9D2600", Offset = "0x9D1800", VA = "0x1809D2600")]
	protected (int, int, float) GetDataIndexRange()
	{
		return default((int, int, float));
	}

	[Token(Token = "0x600076D")]
	[Address(RVA = "0x9D2510", Offset = "0x9D1710", VA = "0x1809D2510")]
	protected int GetDataIndexByPos(float pos)
	{
		return default(int);
	}

	[Token(Token = "0x600076E")]
	[Address(RVA = "0x9D29B0", Offset = "0x9D1BB0", VA = "0x1809D29B0")]
	private void HideItem(GameObject obj)
	{
	}

	[Token(Token = "0x600076F")]
	[Address(RVA = "0x9D4190", Offset = "0x9D3390", VA = "0x1809D4190")]
	private void ShowItem(GameObject obj, bool istop)
	{
	}

	[Token(Token = "0x6000770")]
	[Address(RVA = "0x9D2730", Offset = "0x9D1930", VA = "0x1809D2730")]
	private Transform GetFreeItemByLabel(string label)
	{
		return null;
	}

	[Token(Token = "0x6000771")]
	[Address(RVA = "0x9D1E50", Offset = "0x9D1050", VA = "0x1809D1E50")]
	private bool AddItem(int index, bool top)
	{
		return default(bool);
	}

	[Token(Token = "0x6000772")]
	[Address(RVA = "0x9D3CD0", Offset = "0x9D2ED0", VA = "0x1809D3CD0")]
	private bool RemoveItem(bool top)
	{
		return default(bool);
	}

	[Token(Token = "0x6000773")]
	[Address(RVA = "0x9D3AF0", Offset = "0x9D2CF0", VA = "0x1809D3AF0")]
	private void RemoveAllItem()
	{
	}

	[Token(Token = "0x6000774")]
	[Address(RVA = "0x9D2110", Offset = "0x9D1310", VA = "0x1809D2110")]
	private void ChangeContentSize()
	{
	}

	[Token(Token = "0x6000775")]
	[Address(RVA = "0x9D4BB0", Offset = "0x9D3DB0", VA = "0x1809D4BB0")]
	private void Update()
	{
	}

	[Token(Token = "0x6000776")]
	[Address(RVA = "0x9D20D0", Offset = "0x9D12D0", VA = "0x1809D20D0")]
	private bool AddTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6000777")]
	[Address(RVA = "0x9D1BA0", Offset = "0x9D0DA0", VA = "0x1809D1BA0")]
	private bool AddBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6000778")]
	[Address(RVA = "0x9D3E40", Offset = "0x9D3040", VA = "0x1809D3E40")]
	private bool RemoveTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6000779")]
	[Address(RVA = "0x9D3C70", Offset = "0x9D2E70", VA = "0x1809D3C70")]
	private bool RemoveBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x600077A")]
	[Address(RVA = "0x9D3940", Offset = "0x9D2B40", VA = "0x1809D3940")]
	public void MoveUp()
	{
	}

	[Token(Token = "0x600077B")]
	[Address(RVA = "0x9D32C0", Offset = "0x9D24C0", VA = "0x1809D32C0")]
	public void MoveDown()
	{
	}

	[Token(Token = "0x600077C")]
	[Address(RVA = "0x9D3500", Offset = "0x9D2700", VA = "0x1809D3500")]
	public void MoveToLastLabel(string targetlabel)
	{
	}

	[Token(Token = "0x600077D")]
	[Address(RVA = "0x9D35B0", Offset = "0x9D27B0", VA = "0x1809D35B0")]
	public void MoveToNextLabel(string targetlabel)
	{
	}

	[Token(Token = "0x600077E")]
	[Address(RVA = "0x9D3AE0", Offset = "0x9D2CE0", VA = "0x1809D3AE0", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x600077F")]
	[Address(RVA = "0x9D3770", Offset = "0x9D2970", VA = "0x1809D3770")]
	private void MoveToTargetData(int dataindex, bool ontop = true)
	{
	}

	[Token(Token = "0x6000780")]
	[Address(RVA = "0x9D3690", Offset = "0x9D2890", VA = "0x1809D3690")]
	private void MoveToPosition(Vector3 targetpos)
	{
	}

	[Token(Token = "0x6000781")]
	[Address(RVA = "0x9D4CE0", Offset = "0x9D3EE0", VA = "0x1809D4CE0")]
	public DuelLogScrollViewForAnalysis()
	{
	}
}
