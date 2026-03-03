using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000552")]
[AddComponentMenu("Ygom/UI/uGUI/Scroll Rect Page Snap")]
[RequireComponent(typeof(ScrollRect))]
public class ScrollRectPageSnap : MonoBehaviour, IInitializePotentialDragHandler, IEventSystemHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
	[Token(Token = "0x40019D0")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	public int m_HorizontalPages;

	[Token(Token = "0x40019D1")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	public int m_VerticalPages;

	[Token(Token = "0x40019D2")]
	[FieldOffset(Offset = "0x28")]
	public bool wheelScrollEnable;

	[Token(Token = "0x40019D3")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public Tween.Easing easing;

	[Token(Token = "0x40019D4")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[SecField]
	public float duration;

	[Token(Token = "0x40019D5")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	public float sensitivity;

	[Token(Token = "0x40019D6")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public float backlash;

	[Token(Token = "0x40019D7")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public UnityEvent onPageChanged;

	[Token(Token = "0x40019D8")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public UnityEvent onPageTotalChanged;

	[Token(Token = "0x40019D9")]
	[FieldOffset(Offset = "0x50")]
	public Action<int> onReleaseDragCallback;

	[Token(Token = "0x40019DA")]
	[FieldOffset(Offset = "0x58")]
	private int draggingId;

	[Token(Token = "0x40019DB")]
	[FieldOffset(Offset = "0x60")]
	private ScrollRect scrollrect;

	[Token(Token = "0x40019DC")]
	[FieldOffset(Offset = "0x68")]
	private float tweenTime;

	[Token(Token = "0x40019DD")]
	[FieldOffset(Offset = "0x6C")]
	private float tweenMaxTime;

	[Token(Token = "0x40019DE")]
	[FieldOffset(Offset = "0x70")]
	private Vector2 startNormalized;

	[Token(Token = "0x40019DF")]
	[FieldOffset(Offset = "0x78")]
	private Vector2 endNormalized;

	[Token(Token = "0x40019E0")]
	[FieldOffset(Offset = "0x80")]
	private int vpage;

	[Token(Token = "0x40019E1")]
	[FieldOffset(Offset = "0x84")]
	private int hpage;

	[Token(Token = "0x40019E2")]
	[FieldOffset(Offset = "0x88")]
	private int vspage;

	[Token(Token = "0x40019E3")]
	[FieldOffset(Offset = "0x8C")]
	private int hspage;

	[Token(Token = "0x40019E4")]
	[FieldOffset(Offset = "0x90")]
	private List<bool> hpageEnableList;

	[Token(Token = "0x40019E5")]
	[FieldOffset(Offset = "0x98")]
	private List<bool> vpageEnableList;

	[Token(Token = "0x40019E6")]
	[FieldOffset(Offset = "0xA0")]
	private bool isBarDragging;

	[Token(Token = "0x40019E7")]
	[FieldOffset(Offset = "0xA1")]
	public bool dragScrollEnabled;

	[Token(Token = "0x40019E8")]
	[FieldOffset(Offset = "0xA8")]
	private SelectionItem m_BodySelectionItemCache;

	[Token(Token = "0x40019E9")]
	[FieldOffset(Offset = "0xB0")]
	private List<SelectionItem> m_SelectionItemSearch;

	[Token(Token = "0x170003AB")]
	public int horizontalPages
	{
		[Token(Token = "0x6002285")]
		[Address(RVA = "0x4BDC30", Offset = "0x4BCE30", VA = "0x1804BDC30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002286")]
		[Address(RVA = "0x6522D0", Offset = "0x6514D0", VA = "0x1806522D0")]
		set
		{
		}
	}

	[Token(Token = "0x170003AC")]
	public int verticalPages
	{
		[Token(Token = "0x6002287")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6002288")]
		[Address(RVA = "0x6524D0", Offset = "0x6516D0", VA = "0x1806524D0")]
		set
		{
		}
	}

	[Token(Token = "0x170003AD")]
	public int hPage
	{
		[Token(Token = "0x6002289")]
		[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600228A")]
		[Address(RVA = "0x652080", Offset = "0x651280", VA = "0x180652080")]
		set
		{
		}
	}

	[Token(Token = "0x170003AE")]
	public int vPage
	{
		[Token(Token = "0x600228B")]
		[Address(RVA = "0x5889C0", Offset = "0x587BC0", VA = "0x1805889C0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600228C")]
		[Address(RVA = "0x6522F0", Offset = "0x6514F0", VA = "0x1806522F0")]
		set
		{
		}
	}

	[Token(Token = "0x170003AF")]
	public bool isDragging
	{
		[Token(Token = "0x600228D")]
		[Address(RVA = "0x652060", Offset = "0x651260", VA = "0x180652060")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003B0")]
	public bool isTweening
	{
		[Token(Token = "0x600228E")]
		[Address(RVA = "0x652070", Offset = "0x651270", VA = "0x180652070")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170003B1")]
	public ScrollRect target
	{
		[Token(Token = "0x600228F")]
		[Address(RVA = "0x589E50", Offset = "0x589050", VA = "0x180589E50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B2")]
	private SelectionItem bodySelectionItem
	{
		[Token(Token = "0x6002290")]
		[Address(RVA = "0x651FF0", Offset = "0x6511F0", VA = "0x180651FF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6002291")]
	[Address(RVA = "0x651A40", Offset = "0x650C40", VA = "0x180651A40")]
	private void SetupBodySelectionItem()
	{
	}

	[Token(Token = "0x6002292")]
	[Address(RVA = "0x651B70", Offset = "0x650D70", VA = "0x180651B70")]
	private void Start()
	{
	}

	[Token(Token = "0x6002293")]
	[Address(RVA = "0x650F10", Offset = "0x650110", VA = "0x180650F10")]
	public bool OnScroll(Vector2 vec)
	{
		return default(bool);
	}

	[Token(Token = "0x6002294")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002295")]
	[Address(RVA = "0x650CF0", Offset = "0x64FEF0", VA = "0x180650CF0", Slot = "7")]
	public void OnDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002296")]
	[Address(RVA = "0x650C80", Offset = "0x64FE80", VA = "0x180650C80", Slot = "5")]
	public void OnBeginDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002297")]
	[Address(RVA = "0x651F70", Offset = "0x651170", VA = "0x180651F70")]
	public int calcPageIndex(float norm, int pages, int startpage)
	{
		return default(int);
	}

	[Token(Token = "0x6002298")]
	[Address(RVA = "0x650E90", Offset = "0x650090", VA = "0x180650E90", Slot = "6")]
	public void OnEndDrag(PointerEventData eventData)
	{
	}

	[Token(Token = "0x6002299")]
	[Address(RVA = "0x6515D0", Offset = "0x6507D0", VA = "0x1806515D0")]
	public void ReleaseDrag(Vector2 delta)
	{
	}

	[Token(Token = "0x600229A")]
	[Address(RVA = "0x650460", Offset = "0x64F660", VA = "0x180650460")]
	private void Awake()
	{
	}

	[Token(Token = "0x600229B")]
	[Address(RVA = "0x6514B0", Offset = "0x6506B0", VA = "0x1806514B0")]
	private void OnStartBarDrag()
	{
	}

	[Token(Token = "0x600229C")]
	[Address(RVA = "0x650C70", Offset = "0x64FE70", VA = "0x180650C70")]
	private void OnBarDragging()
	{
	}

	[Token(Token = "0x600229D")]
	[Address(RVA = "0x650E80", Offset = "0x650080", VA = "0x180650E80")]
	private void OnEndBarDrag()
	{
	}

	[Token(Token = "0x600229E")]
	[Address(RVA = "0x6508F0", Offset = "0x64FAF0", VA = "0x1806508F0")]
	private void CalcPositionToPage()
	{
	}

	[Token(Token = "0x600229F")]
	[Address(RVA = "0x651BD0", Offset = "0x650DD0", VA = "0x180651BD0")]
	private void Update()
	{
	}

	[Token(Token = "0x60022A0")]
	[Address(RVA = "0x6509F0", Offset = "0x64FBF0", VA = "0x1806509F0")]
	private void ChangeNormalized(float ex, float ey)
	{
	}

	[Token(Token = "0x60022A1")]
	[Address(RVA = "0x6518D0", Offset = "0x650AD0", VA = "0x1806518D0")]
	public void SetVPageEnable(bool enable, int page = -1)
	{
	}

	[Token(Token = "0x60022A2")]
	[Address(RVA = "0x651760", Offset = "0x650960", VA = "0x180651760")]
	public void SetHPageEnable(bool enable, int page = -1)
	{
	}

	[Token(Token = "0x60022A3")]
	[Address(RVA = "0x650A70", Offset = "0x64FC70", VA = "0x180650A70")]
	public void ForceSnap()
	{
	}

	[Token(Token = "0x60022A4")]
	[Address(RVA = "0x650B60", Offset = "0x64FD60", VA = "0x180650B60")]
	public void LoopHorizontal()
	{
	}

	[Token(Token = "0x60022A5")]
	[Address(RVA = "0x6514C0", Offset = "0x6506C0", VA = "0x1806514C0")]
	public void PseudoLoopHorizontalView()
	{
	}

	[Token(Token = "0x60022A6")]
	[Address(RVA = "0x651F20", Offset = "0x651120", VA = "0x180651F20")]
	public ScrollRectPageSnap()
	{
	}
}
