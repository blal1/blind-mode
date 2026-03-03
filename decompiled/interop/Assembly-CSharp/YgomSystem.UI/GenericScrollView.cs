using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.ElementSystem;

namespace YgomSystem.UI;

[Token(Token = "0x2000453")]
[RequireComponent(typeof(Selector))]
public class GenericScrollView : MonoBehaviour
{
	[Token(Token = "0x2000454")]
	protected enum Alignment
	{
		[Token(Token = "0x4001531")]
		Begin,
		[Token(Token = "0x4001532")]
		Center,
		[Token(Token = "0x4001533")]
		End
	}

	[Token(Token = "0x2000455")]
	[CompilerGenerated]
	private sealed class _003CInstantiateImpl_003Ed__113 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001534")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001535")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001536")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GenericScrollView _003C_003E4__this;

		[Token(Token = "0x4001537")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action onFinished;

		[Token(Token = "0x4001538")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public int itemcount;

		[Token(Token = "0x4001539")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		private int _003Ci_003E5__2;

		[Token(Token = "0x170002B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C09")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C0B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C06")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CInstantiateImpl_003Ed__113(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C07")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C08")]
		[Address(RVA = "0x6121B0", Offset = "0x6113B0", VA = "0x1806121B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C0A")]
		[Address(RVA = "0x612650", Offset = "0x611850", VA = "0x180612650", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000456")]
	[CompilerGenerated]
	private sealed class _003CReadRectSize_003Ed__110 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400153A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400153B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400153C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public GenericScrollView _003C_003E4__this;

		[Token(Token = "0x400153D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public string templateLabelName;

		[Token(Token = "0x170002B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C0F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C11")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C0C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CReadRectSize_003Ed__110(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C0D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C0E")]
		[Address(RVA = "0x612690", Offset = "0x611890", VA = "0x180612690", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C10")]
		[Address(RVA = "0x6129F0", Offset = "0x611BF0", VA = "0x1806129F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001517")]
	private const string LABEL_EO_TEMPLATE = "template";

	[Token(Token = "0x4001518")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	protected GridLayoutGroup.Axis m_ScrollMode;

	[Token(Token = "0x4001519")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	protected Vector2 m_Spacing;

	[Token(Token = "0x400151A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	protected RectOffset m_Padding;

	[Token(Token = "0x400151B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	protected Alignment m_Alignment;

	[Token(Token = "0x400151C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x3C")]
	[SerializeField]
	protected int m_ConstraintCount;

	[Token(Token = "0x400151D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	protected IGenericScrollViewSupport m_IGsvHelper;

	[Token(Token = "0x400151E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	protected Selector m_Selector;

	[Token(Token = "0x400151F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	protected ElementObjectManager m_EOManager;

	[Token(Token = "0x4001520")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	protected RectTransform m_ContentRT;

	[Token(Token = "0x4001521")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	protected Vector2 m_ViewportSize;

	[Token(Token = "0x4001522")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	protected ExtendedScrollRect m_ScrollRect;

	[Token(Token = "0x4001523")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	protected GridLayoutGroup m_LayoutGroup;

	[Token(Token = "0x4001524")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	protected Dictionary<SelectionItem, int> m_ItemDataIndexTable;

	[Token(Token = "0x4001525")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	protected Dictionary<SelectionItem, GameObject> m_SIGOTable;

	[Token(Token = "0x4001526")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	protected Stack<SelectionItem> m_FreeItemStack;

	[Token(Token = "0x4001527")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	protected List<SelectionItem> m_ActiveItemList;

	[Token(Token = "0x4001528")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	protected int m_DataCount;

	[Token(Token = "0x4001529")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	protected List<GameObject> m_GobList;

	[Token(Token = "0x400152A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	protected Vector2 m_UnitSize;

	[Token(Token = "0x400152B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	protected int m_WaitForSelectDataIndex;

	[Token(Token = "0x400152C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB4")]
	protected bool m_IsStandby;

	[Token(Token = "0x400152D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	protected IEnumerator m_yMoveContentImpl;

	[Token(Token = "0x400152E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	protected GameObject m_Template;

	[Token(Token = "0x400152F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	private int m_WaitCount;

	[Token(Token = "0x17000291")]
	public int ConstraintCount
	{
		[Token(Token = "0x6001BA5")]
		[Address(RVA = "0x5EA1B0", Offset = "0x5E93B0", VA = "0x1805EA1B0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000292")]
	public int DataIndexOfItemBegin
	{
		[Token(Token = "0x6001BA6")]
		[Address(RVA = "0x5EA3C0", Offset = "0x5E95C0", VA = "0x1805EA3C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000293")]
	public int DataIndexOfItemEnd
	{
		[Token(Token = "0x6001BA7")]
		[Address(RVA = "0x5EA460", Offset = "0x5E9660", VA = "0x1805EA460")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000294")]
	public int CurrentItemIndex
	{
		[Token(Token = "0x6001BA8")]
		[Address(RVA = "0x5EA300", Offset = "0x5E9500", VA = "0x1805EA300")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000295")]
	public int CurrentDataIndex
	{
		[Token(Token = "0x6001BA9")]
		[Address(RVA = "0x5EA230", Offset = "0x5E9430", VA = "0x1805EA230")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000296")]
	public int ItemCount
	{
		[Token(Token = "0x6001BAA")]
		[Address(RVA = "0x5EA540", Offset = "0x5E9740", VA = "0x1805EA540")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000297")]
	public Vector2 UnitSize
	{
		[Token(Token = "0x6001BAB")]
		[Address(RVA = "0x5EA580", Offset = "0x5E9780", VA = "0x1805EA580")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000298")]
	public float ContentHeight
	{
		[Token(Token = "0x6001BAC")]
		[Address(RVA = "0x5EA1C0", Offset = "0x5E93C0", VA = "0x1805EA1C0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000299")]
	public float ContentWidth
	{
		[Token(Token = "0x6001BAD")]
		[Address(RVA = "0x5EA1F0", Offset = "0x5E93F0", VA = "0x1805EA1F0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700029A")]
	public GridLayoutGroup gridLayout
	{
		[Token(Token = "0x6001BAE")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029B")]
	public RectTransform Content
	{
		[Token(Token = "0x6001BAF")]
		[Address(RVA = "0x5EA220", Offset = "0x5E9420", VA = "0x1805EA220")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029C")]
	public Selector selector
	{
		[Token(Token = "0x6001BB0")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029D")]
	public ScrollRect scrollrect
	{
		[Token(Token = "0x6001BB1")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700029E")]
	public bool isMoving
	{
		[Token(Token = "0x6001BB2")]
		[Address(RVA = "0x5EA5A0", Offset = "0x5E97A0", VA = "0x1805EA5A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700029F")]
	protected int m_LastLineItemCount
	{
		[Token(Token = "0x6001BB3")]
		[Address(RVA = "0x5EA880", Offset = "0x5E9A80", VA = "0x1805EA880")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002A0")]
	protected int m_LastLineItemCountInView
	{
		[Token(Token = "0x6001BB4")]
		[Address(RVA = "0x5EA830", Offset = "0x5E9A30", VA = "0x1805EA830")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002A1")]
	protected bool m_IsHorizontalScroll
	{
		[Token(Token = "0x6001BB5")]
		[Address(RVA = "0x5EA820", Offset = "0x5E9A20", VA = "0x1805EA820")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002A2")]
	protected float m_CurrentContentPos
	{
		[Token(Token = "0x6001BB6")]
		[Address(RVA = "0x5EA5E0", Offset = "0x5E97E0", VA = "0x1805EA5E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A3")]
	protected float m_ViewSizeAlongScrollDirection
	{
		[Token(Token = "0x6001BB7")]
		[Address(RVA = "0x5EAA40", Offset = "0x5E9C40", VA = "0x1805EAA40")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A4")]
	protected float m_UnitSizeAlongScrollDirection
	{
		[Token(Token = "0x6001BB8")]
		[Address(RVA = "0x5EAA10", Offset = "0x5E9C10", VA = "0x1805EAA10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A5")]
	protected float m_SpacingAlongScrollDirection
	{
		[Token(Token = "0x6001BB9")]
		[Address(RVA = "0x5EA9F0", Offset = "0x5E9BF0", VA = "0x1805EA9F0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170002A6")]
	protected SelectionItem m_CurrentItem
	{
		[Token(Token = "0x6001BBA")]
		[Address(RVA = "0x5EA710", Offset = "0x5E9910", VA = "0x1805EA710")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A7")]
	protected RectTransform m_CurrentItemRT
	{
		[Token(Token = "0x6001BBB")]
		[Address(RVA = "0x5EA630", Offset = "0x5E9830", VA = "0x1805EA630")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002A8")]
	protected int m_DataIndexOfListBegin
	{
		[Token(Token = "0x6001BBC")]
		[Address(RVA = "0x5EA730", Offset = "0x5E9930", VA = "0x1805EA730")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002A9")]
	protected int m_VerticalOffset
	{
		[Token(Token = "0x6001BBD")]
		[Address(RVA = "0x5EAA30", Offset = "0x5E9C30", VA = "0x1805EAA30")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AA")]
	protected int m_HorizontalOffset
	{
		[Token(Token = "0x6001BBE")]
		[Address(RVA = "0x5EA810", Offset = "0x5E9A10", VA = "0x1805EA810")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AB")]
	protected int m_DataIndexOfListEnd
	{
		[Token(Token = "0x6001BBF")]
		[Address(RVA = "0x5EA790", Offset = "0x5E9990", VA = "0x1805EA790")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AC")]
	protected int m_PaddingBias
	{
		[Token(Token = "0x6001BC0")]
		[Address(RVA = "0x5EA8F0", Offset = "0x5E9AF0", VA = "0x1805EA8F0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AD")]
	protected int m_PaddingBegin
	{
		[Token(Token = "0x6001BC1")]
		[Address(RVA = "0x5EA8C0", Offset = "0x5E9AC0", VA = "0x1805EA8C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AE")]
	protected int m_PaddingEnd
	{
		[Token(Token = "0x6001BC2")]
		[Address(RVA = "0x5EA9C0", Offset = "0x5E9BC0", VA = "0x1805EA9C0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170002AF")]
	protected bool m_IsMoving
	{
		[Token(Token = "0x6001BC3")]
		[Address(RVA = "0x5EA5A0", Offset = "0x5E97A0", VA = "0x1805EA5A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170002B0")]
	public bool isStandby
	{
		[Token(Token = "0x6001BC4")]
		[Address(RVA = "0x5EA5D0", Offset = "0x5E97D0", VA = "0x1805EA5D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001BC5")]
	[Address(RVA = "0x5E7B80", Offset = "0x5E6D80", VA = "0x1805E7B80")]
	public void Initialzize(IGenericScrollViewSupport igsvsupport, [Optional] string templateLabelName)
	{
	}

	[Token(Token = "0x6001BC6")]
	[Address(RVA = "0x5E9E30", Offset = "0x5E9030", VA = "0x1805E9E30", Slot = "4")]
	public virtual void UpdateDataCount(int dataCount)
	{
	}

	[Token(Token = "0x6001BC7")]
	[Address(RVA = "0x5E9FE0", Offset = "0x5E91E0", VA = "0x1805E9FE0")]
	public void UpdateData()
	{
	}

	[Token(Token = "0x6001BC8")]
	[Address(RVA = "0x5E7060", Offset = "0x5E6260", VA = "0x1805E7060")]
	public SelectionItem GetItemByListPos(int x, int y)
	{
		return null;
	}

	[Token(Token = "0x6001BC9")]
	[Address(RVA = "0x5E74D0", Offset = "0x5E66D0", VA = "0x1805E74D0")]
	public (int, int) GetListPosByItemIndex(int itemIndex)
	{
		return default((int, int));
	}

	[Token(Token = "0x6001BCA")]
	[Address(RVA = "0x5E71A0", Offset = "0x5E63A0", VA = "0x1805E71A0")]
	public int GetItemIndexByListPos(int x, int y)
	{
		return default(int);
	}

	[Token(Token = "0x6001BCB")]
	[Address(RVA = "0x5E6EA0", Offset = "0x5E60A0", VA = "0x1805E6EA0")]
	public int GetDataIndexByItemIndex(int itemIndex)
	{
		return default(int);
	}

	[Token(Token = "0x6001BCC")]
	[Address(RVA = "0x5E6F20", Offset = "0x5E6120", VA = "0x1805E6F20")]
	public int GetDataIndexByListPos(int x, int y)
	{
		return default(int);
	}

	[Token(Token = "0x6001BCD")]
	[Address(RVA = "0x5E70E0", Offset = "0x5E62E0", VA = "0x1805E70E0")]
	public int GetItemIndexByDataIndex(int dataindex)
	{
		return default(int);
	}

	[Token(Token = "0x6001BCE")]
	[Address(RVA = "0x5E6FD0", Offset = "0x5E61D0", VA = "0x1805E6FD0")]
	public SelectionItem GetItemByDataIndex(int dataindex)
	{
		return null;
	}

	[Token(Token = "0x6001BCF")]
	public T GetItemByDataIndex<T>(int dataindex)
	{
		return (T)null;
	}

	[Token(Token = "0x6001BD0")]
	[Address(RVA = "0x5E9380", Offset = "0x5E8580", VA = "0x1805E9380")]
	public bool SelectItemByDataIndex(int dataindex, bool forcemovetofirst = false, bool forceInitializeSelect = false, bool immediateApply = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BD1")]
	[Address(RVA = "0x5E96E0", Offset = "0x5E88E0", VA = "0x1805E96E0")]
	public void SetUpSelectionItemDirections()
	{
	}

	[Token(Token = "0x6001BD2")]
	[Address(RVA = "0x5E6E20", Offset = "0x5E6020", VA = "0x1805E6E20")]
	public void FocusItemByDataIndex(int dataindex, bool forcemovetofirst = false, bool immediateApply = false)
	{
	}

	[Token(Token = "0x6001BD3")]
	[Address(RVA = "0x5E92E0", Offset = "0x5E84E0", VA = "0x1805E92E0")]
	public void ResetContentPosition()
	{
	}

	[Token(Token = "0x6001BD4")]
	[Address(RVA = "0x5E6E30", Offset = "0x5E6030", VA = "0x1805E6E30")]
	public float GetContentPosByDataLine(int index)
	{
		return default(float);
	}

	[Token(Token = "0x6001BD5")]
	[Address(RVA = "0x5E7220", Offset = "0x5E6420", VA = "0x1805E7220")]
	public float GetItemPosByDataLine(int index)
	{
		return default(float);
	}

	[Token(Token = "0x6001BD6")]
	[Address(RVA = "0x5E72F0", Offset = "0x5E64F0", VA = "0x1805E72F0")]
	public Vector2 GetItemPosByItemIndex(int index)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001BD7")]
	[Address(RVA = "0x5E6DD0", Offset = "0x5E5FD0", VA = "0x1805E6DD0")]
	public void DeltaMove(float deltamove)
	{
	}

	[Token(Token = "0x6001BD8")]
	[Address(RVA = "0x5E7690", Offset = "0x5E6890", VA = "0x1805E7690")]
	protected void InitContentRT()
	{
	}

	[Token(Token = "0x6001BD9")]
	[Address(RVA = "0x5E8B50", Offset = "0x5E7D50", VA = "0x1805E8B50")]
	[IteratorStateMachine(typeof(_003CReadRectSize_003Ed__110))]
	protected IEnumerator ReadRectSize(string templateLabelName = "template")
	{
		return null;
	}

	[Token(Token = "0x6001BDA")]
	[Address(RVA = "0x5E8220", Offset = "0x5E7420", VA = "0x1805E8220")]
	protected void InstantiateTemplate()
	{
	}

	[Token(Token = "0x6001BDB")]
	[Address(RVA = "0x5E7EA0", Offset = "0x5E70A0", VA = "0x1805E7EA0")]
	public void InstantiateAdditionalInstance([Optional] Action onFinished)
	{
	}

	[Token(Token = "0x6001BDC")]
	[Address(RVA = "0x5E8180", Offset = "0x5E7380", VA = "0x1805E8180")]
	[IteratorStateMachine(typeof(_003CInstantiateImpl_003Ed__113))]
	private IEnumerator InstantiateImpl(int itemcount, [Optional] Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x6001BDD")]
	[Address(RVA = "0x5E7880", Offset = "0x5E6A80", VA = "0x1805E7880")]
	public void InitLayout(int count = 0)
	{
	}

	[Token(Token = "0x6001BDE")]
	[Address(RVA = "0x5E6A20", Offset = "0x5E5C20", VA = "0x1805E6A20")]
	protected bool AddTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001BDF")]
	[Address(RVA = "0x5E66F0", Offset = "0x5E58F0", VA = "0x1805E66F0")]
	protected bool AddBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001BE0")]
	[Address(RVA = "0x5E91F0", Offset = "0x5E83F0", VA = "0x1805E91F0")]
	protected bool RemoveTopItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001BE1")]
	[Address(RVA = "0x5E8DB0", Offset = "0x5E7FB0", VA = "0x1805E8DB0")]
	protected bool RemoveBottomItem()
	{
		return default(bool);
	}

	[Token(Token = "0x6001BE2")]
	[Address(RVA = "0x5E9900", Offset = "0x5E8B00", VA = "0x1805E9900")]
	protected void UpdateContentPos()
	{
	}

	[Token(Token = "0x6001BE3")]
	[Address(RVA = "0x5E6D10", Offset = "0x5E5F10", VA = "0x1805E6D10")]
	protected void CheckWaitForSelectData()
	{
	}

	[Token(Token = "0x6001BE4")]
	[Address(RVA = "0x5E6F50", Offset = "0x5E6150", VA = "0x1805E6F50")]
	protected int GetDataLineByContentPos(float pos)
	{
		return default(int);
	}

	[Token(Token = "0x6001BE5")]
	[Address(RVA = "0x5E6790", Offset = "0x5E5990", VA = "0x1805E6790")]
	protected bool AddItem(int dataindex, int posInHierachy)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BE6")]
	[Address(RVA = "0x5E8F40", Offset = "0x5E8140", VA = "0x1805E8F40")]
	protected bool RemoveItem(int itemindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BE7")]
	[Address(RVA = "0x5E8BE0", Offset = "0x5E7DE0", VA = "0x1805E8BE0")]
	protected void RemoveAllItem()
	{
	}

	[Token(Token = "0x6001BE8")]
	[Address(RVA = "0x5E6A80", Offset = "0x5E5C80", VA = "0x1805E6A80")]
	protected void ChangeContentSize()
	{
	}

	[Token(Token = "0x6001BE9")]
	[Address(RVA = "0x5E8A70", Offset = "0x5E7C70", VA = "0x1805E8A70", Slot = "5")]
	protected virtual void PadInputCallBack(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001BEA")]
	[Address(RVA = "0x5E8A50", Offset = "0x5E7C50", VA = "0x1805E8A50")]
	protected void PadInputCallBackUp()
	{
	}

	[Token(Token = "0x6001BEB")]
	[Address(RVA = "0x5E89F0", Offset = "0x5E7BF0", VA = "0x1805E89F0")]
	protected void PadInputCallBackDown()
	{
	}

	[Token(Token = "0x6001BEC")]
	[Address(RVA = "0x5E8A10", Offset = "0x5E7C10", VA = "0x1805E8A10")]
	protected void PadInputCallBackLeft()
	{
	}

	[Token(Token = "0x6001BED")]
	[Address(RVA = "0x5E8A30", Offset = "0x5E7C30", VA = "0x1805E8A30")]
	protected void PadInputCallBackRight()
	{
	}

	[Token(Token = "0x6001BEE")]
	[Address(RVA = "0x5E7550", Offset = "0x5E6750", VA = "0x1805E7550")]
	protected int GetNextDataIndexByPadInput(PadInputDirection direction)
	{
		return default(int);
	}

	[Token(Token = "0x6001BEF")]
	[Address(RVA = "0x5E86B0", Offset = "0x5E78B0", VA = "0x1805E86B0")]
	protected bool IsIndexInSameLine(int index0, int index1)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF0")]
	[Address(RVA = "0x5E6CB0", Offset = "0x5E5EB0", VA = "0x1805E6CB0")]
	protected bool CheckItemIndexCorrect(int itemindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF1")]
	[Address(RVA = "0x5E6BA0", Offset = "0x5E5DA0", VA = "0x1805E6BA0")]
	protected bool CheckDataIndexCorrect(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF2")]
	[Address(RVA = "0x5E6BC0", Offset = "0x5E5DC0", VA = "0x1805E6BC0")]
	protected bool CheckItemInViewByDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF3")]
	[Address(RVA = "0x5E8900", Offset = "0x5E7B00", VA = "0x1805E8900")]
	protected void MoveContent(float targetpos, bool immediateApply = false)
	{
	}

	[Token(Token = "0x6001BF4")]
	[Address(RVA = "0x5E86E0", Offset = "0x5E78E0", VA = "0x1805E86E0")]
	protected bool MoveContentToFitDataPos(int dataindex, bool forcemovetofirst, bool immediateApply = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BF5")]
	[Address(RVA = "0x5E95E0", Offset = "0x5E87E0", VA = "0x1805E95E0", Slot = "6")]
	protected virtual void SetItemTransitionMode(ref SelectionItem item, int dataindex)
	{
	}

	[Token(Token = "0x6001BF6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "7")]
	protected virtual void InnerItemInitialize(int itemindex, SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x6001BF7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	protected virtual void InnerItemActivate(SelectionItem selitem)
	{
	}

	[Token(Token = "0x6001BF8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "9")]
	protected virtual void InnerItemDeactivate(SelectionItem selitem)
	{
	}

	[Token(Token = "0x6001BF9")]
	[Address(RVA = "0x5E8490", Offset = "0x5E7690", VA = "0x1805E8490")]
	public bool IsEdgeByDataIndex(int dataindex, PadInputDirection checkDirection)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFA")]
	[Address(RVA = "0x5E85D0", Offset = "0x5E77D0", VA = "0x1805E85D0")]
	public bool IsEdgeLeftDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFB")]
	[Address(RVA = "0x5E85F0", Offset = "0x5E77F0", VA = "0x1805E85F0")]
	public bool IsEdgeRightDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFC")]
	[Address(RVA = "0x5E8650", Offset = "0x5E7850", VA = "0x1805E8650")]
	public bool IsEdgeUpDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFD")]
	[Address(RVA = "0x5E8550", Offset = "0x5E7750", VA = "0x1805E8550")]
	public bool IsEdgeDownDataIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFE")]
	[Address(RVA = "0x5E85C0", Offset = "0x5E77C0", VA = "0x1805E85C0")]
	public bool IsEdgeHeadItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001BFF")]
	[Address(RVA = "0x5E8640", Offset = "0x5E7840", VA = "0x1805E8640")]
	public bool IsEdgeTailItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C00")]
	[Address(RVA = "0x5E8630", Offset = "0x5E7830", VA = "0x1805E8630")]
	public bool IsEdgeStartSideItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C01")]
	[Address(RVA = "0x5E8590", Offset = "0x5E7790", VA = "0x1805E8590")]
	public bool IsEdgeEndSideItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C02")]
	[Address(RVA = "0x5E8670", Offset = "0x5E7870", VA = "0x1805E8670")]
	public bool IsFractionItemIndex(int dataindex)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C03")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public GenericScrollView()
	{
	}
}
