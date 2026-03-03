using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using YgomGame.Bg;
using YgomSystem.ElementSystem;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20018BC")]
[RequireComponent(typeof(ElementObjectManager))]
public class DuelLogScrollView : MonoBehaviour, IBeginDragHandler, IEventSystemHandler
{
	[Token(Token = "0x20018BD")]
	public class OnItemUpdate : UnityEvent<GameObject, int>
	{
		[Token(Token = "0x6009F59")]
		[Address(RVA = "0xEE4D10", Offset = "0xEE3F10", VA = "0x180EE4D10")]
		public OnItemUpdate()
		{
		}
	}

	[Token(Token = "0x400E7FB")]
	[FieldOffset(Offset = "0x20")]
	[HideInInspector]
	public Dictionary<string, GetInt> m_DataNumDict;

	[Token(Token = "0x400E7FC")]
	[FieldOffset(Offset = "0x28")]
	public OnItemUpdate onItemUpdate;

	[Token(Token = "0x400E7FD")]
	[FieldOffset(Offset = "0x30")]
	public UnityEvent onReady;

	[Token(Token = "0x400E7FE")]
	[FieldOffset(Offset = "0x38")]
	public bool autoScroll;

	[Token(Token = "0x400E800")]
	[FieldOffset(Offset = "0x48")]
	protected Dictionary<string, Stack<Transform>> m_ItemStackDict;

	[Token(Token = "0x400E801")]
	[FieldOffset(Offset = "0x50")]
	protected Dictionary<string, GameObject> m_PrehabDict;

	[Token(Token = "0x400E802")]
	[FieldOffset(Offset = "0x58")]
	protected List<string> m_TemplateLabelList;

	[Token(Token = "0x400E803")]
	[FieldOffset(Offset = "0x60")]
	protected List<float> m_ItemBiaslList;

	[Token(Token = "0x400E804")]
	[FieldOffset(Offset = "0x68")]
	protected List<GameObject> m_UsedItemQueue;

	[Token(Token = "0x400E805")]
	[FieldOffset(Offset = "0x70")]
	protected List<SelectionItemGroup> m_SbtnGroupList;

	[Token(Token = "0x400E806")]
	[FieldOffset(Offset = "0x78")]
	protected ElementObjectManager m_EOManager;

	[Token(Token = "0x400E807")]
	[FieldOffset(Offset = "0x80")]
	protected RectTransform m_ContentRT;

	[Token(Token = "0x400E808")]
	[FieldOffset(Offset = "0x88")]
	protected RectTransform m_ViewportRT;

	[Token(Token = "0x400E809")]
	[FieldOffset(Offset = "0x90")]
	protected RectTransform m_ScrollViewRT;

	[Token(Token = "0x400E80A")]
	[FieldOffset(Offset = "0x98")]
	protected Selector m_Selector;

	[Token(Token = "0x400E80B")]
	[FieldOffset(Offset = "0xA0")]
	protected ExtendedScrollRect m_ScrollRect;

	[Token(Token = "0x400E80C")]
	[FieldOffset(Offset = "0xA8")]
	protected DuelClient m_Host;

	[Token(Token = "0x400E80D")]
	[FieldOffset(Offset = "0xB0")]
	protected ScreenPositionUV_Controller m_UvController;

	[Token(Token = "0x400E80E")]
	private const string LABEL_EO_CONTENT = "content";

	[Token(Token = "0x400E80F")]
	private const string LABEL_EO_VIEWPORT = "viewport";

	[Token(Token = "0x400E810")]
	private const string LABEL_EO_HIDDENPORT = "hiddenport";

	[Token(Token = "0x400E811")]
	private const string LABEL_EO_PANEL = "AutoScrollPanel";

	[Token(Token = "0x400E812")]
	private const string LABEL_EO_STATUE = "AutoScrollStatue";

	[Token(Token = "0x400E813")]
	private const string LABEL_EO_SCROLLBAR = "ScrollBar";

	[Token(Token = "0x400E814")]
	[FieldOffset(Offset = "0xB8")]
	private int m_InitialTopPadding;

	[Token(Token = "0x400E815")]
	[FieldOffset(Offset = "0xBC")]
	private int m_TopitemDataindex;

	[Token(Token = "0x400E816")]
	private const float moveBias = 10f;

	[Token(Token = "0x1700182D")]
	public int topitemDataindex
	{
		[Token(Token = "0x6009F27")]
		[Address(RVA = "0x667F00", Offset = "0x667100", VA = "0x180667F00")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700182E")]
	public int bottomitemDataindex
	{
		[Token(Token = "0x6009F28")]
		[Address(RVA = "0xEC9720", Offset = "0xEC8920", VA = "0x180EC9720")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700182F")]
	public Selector selector
	{
		[Token(Token = "0x6009F29")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001830")]
	public ExtendedScrollRect scrollrect
	{
		[Token(Token = "0x6009F2A")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001831")]
	public List<string> m_DataLabelList
	{
		[Token(Token = "0x6009F2C")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6009F2B")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x17001832")]
	protected float m_Spacing
	{
		[Token(Token = "0x6009F2D")]
		[Address(RVA = "0xEC9890", Offset = "0xEC8A90", VA = "0x180EC9890")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001833")]
	private int m_BottomitemDataindex
	{
		[Token(Token = "0x6009F2E")]
		[Address(RVA = "0xEC9720", Offset = "0xEC8920", VA = "0x180EC9720")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001834")]
	private SelectionItem[] m_TopSelectionItems
	{
		[Token(Token = "0x6009F2F")]
		[Address(RVA = "0xEC98F0", Offset = "0xEC8AF0", VA = "0x180EC98F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001835")]
	private SelectionItem[] m_BottomSelectionItems
	{
		[Token(Token = "0x6009F30")]
		[Address(RVA = "0xEC9770", Offset = "0xEC8970", VA = "0x180EC9770")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6009F31")]
	[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
	public void InitHost(DuelClient host)
	{
	}

	[Token(Token = "0x6009F32")]
	[Address(RVA = "0xEC7200", Offset = "0xEC6400", VA = "0x180EC7200")]
	public void Initialzize(ref List<string> templateLabelList, DuelClient host)
	{
	}

	[Token(Token = "0x6009F33")]
	[Address(RVA = "0xEC6A80", Offset = "0xEC5C80", VA = "0x180EC6A80")]
	public void ClearAll()
	{
	}

	[Token(Token = "0x6009F34")]
	[Address(RVA = "0xEC7950", Offset = "0xEC6B50", VA = "0x180EC7950")]
	public bool IsTopItem(SelectionItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F35")]
	[Address(RVA = "0xEC7880", Offset = "0xEC6A80", VA = "0x180EC7880")]
	public bool IsBottomItem(SelectionItem item)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F36")]
	[Address(RVA = "0xEC5B20", Offset = "0xEC4D20", VA = "0x180EC5B20")]
	public void AddDataLabel(string label)
	{
	}

	[Token(Token = "0x6009F37")]
	[Address(RVA = "0xEC7030", Offset = "0xEC6230", VA = "0x180EC7030")]
	public RectTransform GetTopItemRT()
	{
		return null;
	}

	[Token(Token = "0x6009F38")]
	[Address(RVA = "0xEC6B40", Offset = "0xEC5D40", VA = "0x180EC6B40")]
	public RectTransform GetBottomItemRT()
	{
		return null;
	}

	[Token(Token = "0x6009F39")]
	[Address(RVA = "0xEC6BD0", Offset = "0xEC5DD0", VA = "0x180EC6BD0")]
	public SelectionItem GetBottomSItem()
	{
		return null;
	}

	[Token(Token = "0x6009F3A")]
	[Address(RVA = "0xEC70C0", Offset = "0xEC62C0", VA = "0x180EC70C0")]
	public SelectionItem GetTopSItem()
	{
		return null;
	}

	[Token(Token = "0x6009F3B")]
	[Address(RVA = "0xEC8E00", Offset = "0xEC8000", VA = "0x180EC8E00")]
	public void UpdateContent()
	{
	}

	[Token(Token = "0x6009F3C")]
	[Address(RVA = "0xEC89C0", Offset = "0xEC7BC0", VA = "0x180EC89C0")]
	protected void SetSbtnGroupRightTransition(SelectionItemGroup sbtnGroup)
	{
	}

	[Token(Token = "0x6009F3D")]
	[Address(RVA = "0xEC8920", Offset = "0xEC7B20", VA = "0x180EC8920")]
	protected void SetSbtnGroupLeftTransition(SelectionItemPair sbtnpair)
	{
	}

	[Token(Token = "0x6009F3E")]
	[Address(RVA = "0xEC8AA0", Offset = "0xEC7CA0", VA = "0x180EC8AA0")]
	protected void SetSbtnGroupVerticalTransition(SelectionItemGroup sbtnGroup0, SelectionItemGroup sbtnGroup1)
	{
	}

	[Token(Token = "0x6009F3F")]
	[Address(RVA = "0xEC6D10", Offset = "0xEC5F10", VA = "0x180EC6D10")]
	protected (int, int, float) GetDataIndexRange()
	{
		return default((int, int, float));
	}

	[Token(Token = "0x6009F40")]
	[Address(RVA = "0xEC6C20", Offset = "0xEC5E20", VA = "0x180EC6C20")]
	protected int GetDataIndexByPos(float pos)
	{
		return default(int);
	}

	[Token(Token = "0x6009F41")]
	[Address(RVA = "0xEC7110", Offset = "0xEC6310", VA = "0x180EC7110")]
	private void HideItem(GameObject obj)
	{
	}

	[Token(Token = "0x6009F42")]
	[Address(RVA = "0xEC8B40", Offset = "0xEC7D40", VA = "0x180EC8B40")]
	private void ShowItem(GameObject obj, bool istop)
	{
	}

	[Token(Token = "0x6009F43")]
	[Address(RVA = "0xEC6E40", Offset = "0xEC6040", VA = "0x180EC6E40")]
	private Transform GetFreeItemByLabel(string label)
	{
		return null;
	}

	[Token(Token = "0x6009F44")]
	[Address(RVA = "0xEC5D80", Offset = "0xEC4F80", VA = "0x180EC5D80")]
	private bool AddItem(int index, bool top)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F45")]
	[Address(RVA = "0xEC84A0", Offset = "0xEC76A0", VA = "0x180EC84A0")]
	private bool RemoveItem(bool top)
	{
		return default(bool);
	}

	[Token(Token = "0x6009F46")]
	[Address(RVA = "0xEC8290", Offset = "0xEC7490", VA = "0x180EC8290")]
	private void RemoveAllItem()
	{
	}

	[Token(Token = "0x6009F47")]
	[Address(RVA = "0xEC6750", Offset = "0xEC5950", VA = "0x180EC6750")]
	private void ChangeContentSize()
	{
	}

	[Token(Token = "0x6009F48")]
	[Address(RVA = "0xEC9360", Offset = "0xEC8560", VA = "0x180EC9360")]
	private void Update()
	{
	}

	[Token(Token = "0x6009F49")]
	[Address(RVA = "0xEC6710", Offset = "0xEC5910", VA = "0x180EC6710")]
	private bool AddTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F4A")]
	[Address(RVA = "0xEC5AD0", Offset = "0xEC4CD0", VA = "0x180EC5AD0")]
	private bool AddBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F4B")]
	[Address(RVA = "0xEC8840", Offset = "0xEC7A40", VA = "0x180EC8840")]
	private bool RemoveTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F4C")]
	[Address(RVA = "0xEC8440", Offset = "0xEC7640", VA = "0x180EC8440")]
	private bool RemoveBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6009F4D")]
	[Address(RVA = "0xEC80F0", Offset = "0xEC72F0", VA = "0x180EC80F0")]
	public void MoveUp()
	{
	}

	[Token(Token = "0x6009F4E")]
	[Address(RVA = "0xEC7A20", Offset = "0xEC6C20", VA = "0x180EC7A20")]
	public void MoveDown()
	{
	}

	[Token(Token = "0x6009F4F")]
	[Address(RVA = "0xEC7C60", Offset = "0xEC6E60", VA = "0x180EC7C60")]
	public void MoveToLastLabel(string targetlabel)
	{
	}

	[Token(Token = "0x6009F50")]
	[Address(RVA = "0xEC7D10", Offset = "0xEC6F10", VA = "0x180EC7D10")]
	public void MoveToNextLabel(string targetlabel)
	{
	}

	[Token(Token = "0x6009F51")]
	[Address(RVA = "0x9D3AE0", Offset = "0x9D2CE0", VA = "0x1809D3AE0", Slot = "4")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6009F52")]
	[Address(RVA = "0xEC7ED0", Offset = "0xEC70D0", VA = "0x180EC7ED0")]
	private void MoveToTargetData(int dataindex, bool fromTop = true)
	{
	}

	[Token(Token = "0x6009F53")]
	[Address(RVA = "0xEC7DF0", Offset = "0xEC6FF0", VA = "0x180EC7DF0")]
	private void MoveToPosition(Vector3 targetpos)
	{
	}

	[Token(Token = "0x6009F54")]
	[Address(RVA = "0xEC9490", Offset = "0xEC8690", VA = "0x180EC9490")]
	public DuelLogScrollView()
	{
	}
}
