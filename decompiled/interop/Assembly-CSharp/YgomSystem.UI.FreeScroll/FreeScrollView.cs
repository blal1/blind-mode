using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI.FreeScroll;

[Token(Token = "0x2000598")]
[RequireComponent(typeof(ScrollRect))]
public class FreeScrollView : MonoBehaviour, ISupportedSelectionTransitionCustom
{
	[Token(Token = "0x200059A")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001B95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001B96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001B97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public FreeScrollView _003C_003E4__this;

		[Token(Token = "0x17000453")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600255F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000454")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002561")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600255C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600255D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600255E")]
		[Address(RVA = "0x69E2A0", Offset = "0x69D4A0", VA = "0x18069E2A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002560")]
		[Address(RVA = "0x69E770", Offset = "0x69D970", VA = "0x18069E770", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001B79")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	[SerializeField]
	private bool trySelectFirstItem;

	[Token(Token = "0x4001B7A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	[SerializeField]
	private float edgeSnapTopRange;

	[Token(Token = "0x4001B7B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	[SerializeField]
	private float edgeSnapBottomRange;

	[Token(Token = "0x4001B7C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x2C")]
	[SerializeField]
	private bool isFocusScroll;

	[Token(Token = "0x4001B7D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	[SerializeField]
	[DirectionLinePropertyDraw]
	private SelectionDirectionalTransitionSetting m_EdgeTransition;

	[Token(Token = "0x4001B7E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	[SerializeField]
	private bool m_AllowAnalogSelectOnOuter;

	[Token(Token = "0x4001B7F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Canvas m_ScrollRectCanvas;

	[Token(Token = "0x4001B80")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private ScrollRect m_ScrollRect;

	[Token(Token = "0x4001B81")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private List<SelectionItem> m_ContainSelections;

	[Token(Token = "0x4001B82")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private Dictionary<SelectionItem, int> m_SelectionPosXMap;

	[Token(Token = "0x4001B83")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Dictionary<SelectionItem, int> m_SelectionPosYMap;

	[Token(Token = "0x4001B84")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private List<SelectionItem> m_InnerViewPortSelections;

	[Token(Token = "0x4001B85")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private List<SelectionItem> m_SortTargetSelections;

	[Token(Token = "0x4001B86")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private List<Selector> m_RegistedSelectors;

	[Token(Token = "0x4001B87")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Dictionary<SelectionItem, float> m_SortAmounts;

	[Token(Token = "0x4001B88")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private bool m_DirtyViewPort;

	[Token(Token = "0x4001B89")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8C")]
	private Vector2 m_LastInputAnalogMain;

	[Token(Token = "0x4001B8A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private Vector2 m_LastInputAnalogSub;

	[Token(Token = "0x4001B8B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private float m_LastSelectByAnalogTime;

	[Token(Token = "0x4001B8C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private float m_RepeatSelectByAnalogCnt;

	[Token(Token = "0x4001B8D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private SelectionItem m_ScrollRectSelectionItemCache;

	[Token(Token = "0x4001B8E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private Func<PadInputDirection, bool, bool> m_customEdgeTransitionFunc;

	[Token(Token = "0x4001B8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Func<SelectionItem, PadInputDirection, Vector2, bool, bool> customTransitionFunc;

	[Token(Token = "0x4001B90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private bool m_BlockOnSelectedScrollRect;

	[Token(Token = "0x1700044E")]
	public List<Selector> RegistedSelectors
	{
		[Token(Token = "0x6002533")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700044F")]
	public List<SelectionItem> button
	{
		[Token(Token = "0x6002534")]
		[Address(RVA = "0x580700", Offset = "0x57F900", VA = "0x180580700")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000450")]
	private SelectionItem scrollRectSelectionItem
	{
		[Token(Token = "0x6002535")]
		[Address(RVA = "0x68C7C0", Offset = "0x68B9C0", VA = "0x18068C7C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000451")]
	private bool IsSelected
	{
		[Token(Token = "0x6002541")]
		[Address(RVA = "0x68C6D0", Offset = "0x68B8D0", VA = "0x18068C6D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000452")]
	public Func<PadInputDirection, bool, bool> customEdgeTransitionFunc
	{
		[Token(Token = "0x6002543")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		set
		{
		}
	}

	[Token(Token = "0x6002536")]
	[Address(RVA = "0x689990", Offset = "0x688B90", VA = "0x180689990")]
	public void AddSelection(SelectionItem selection)
	{
	}

	[Token(Token = "0x6002537")]
	[Address(RVA = "0x689A50", Offset = "0x688C50", VA = "0x180689A50")]
	public void AddSelections(IReadOnlyList<SelectionItem> selections)
	{
	}

	[Token(Token = "0x6002538")]
	[Address(RVA = "0x68A680", Offset = "0x689880", VA = "0x18068A680")]
	public void RegistSelector(Selector selector, [Optional] List<SelectionItem> items)
	{
	}

	[Token(Token = "0x6002539")]
	[Address(RVA = "0x68BB60", Offset = "0x68AD60", VA = "0x18068BB60")]
	private void SetupSelector(Selector selector)
	{
	}

	[Token(Token = "0x600253A")]
	[Address(RVA = "0x68A560", Offset = "0x689760", VA = "0x18068A560")]
	public void RegistSelectionItemPos(SelectionItem selection, int posX, int posY = 0)
	{
	}

	[Token(Token = "0x600253B")]
	[Address(RVA = "0x68A700", Offset = "0x689900", VA = "0x18068A700")]
	public void RemoveAllSelections()
	{
	}

	[Token(Token = "0x600253C")]
	[Address(RVA = "0x68BB00", Offset = "0x68AD00", VA = "0x18068BB00")]
	public void SetSurfaceActive(bool value)
	{
	}

	[Token(Token = "0x600253D")]
	[Address(RVA = "0x68BDF0", Offset = "0x68AFF0", VA = "0x18068BDF0")]
	private SelectionItem TryGetInnerViewPortSelectedItem()
	{
		return null;
	}

	[Token(Token = "0x600253E")]
	[Address(RVA = "0x68BD80", Offset = "0x68AF80", VA = "0x18068BD80")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__35))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x600253F")]
	[Address(RVA = "0x68C300", Offset = "0x68B500", VA = "0x18068C300")]
	private void Update()
	{
	}

	[Token(Token = "0x6002540")]
	[Address(RVA = "0x68A7B0", Offset = "0x6899B0", VA = "0x18068A7B0")]
	private void ResetAnalogSelectTime()
	{
	}

	[Token(Token = "0x6002542")]
	[Address(RVA = "0x68BFF0", Offset = "0x68B1F0", VA = "0x18068BFF0")]
	public bool TrySelectDefault(bool initializeSelection)
	{
		return default(bool);
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0x68A7C0", Offset = "0x6899C0", VA = "0x18068A7C0")]
	private void ScrollMovement(Vector2 dir, bool byAnalog = false, bool initializeSelection = false, bool trySelectOnly = false)
	{
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0x689BD0", Offset = "0x688DD0", VA = "0x180689BD0")]
	private void InnerScroll(Vector2 dir, bool byAnalog)
	{
	}

	[Token(Token = "0x6002546")]
	[Address(RVA = "0x689BF0", Offset = "0x688DF0", VA = "0x180689BF0")]
	private void InnerVerticalScroll(float value)
	{
	}

	[Token(Token = "0x6002547")]
	[Address(RVA = "0x689F60", Offset = "0x689160", VA = "0x180689F60")]
	private bool IsEnableEdgeSnap()
	{
		return default(bool);
	}

	[Token(Token = "0x6002548")]
	[Address(RVA = "0x689CB0", Offset = "0x688EB0", VA = "0x180689CB0")]
	private bool IsEdgeSelectionItem(SelectionItem targetItem, bool isTop)
	{
		return default(bool);
	}

	[Token(Token = "0x6002549")]
	[Address(RVA = "0x68BF20", Offset = "0x68B120", VA = "0x18068BF20")]
	public bool TryScrollRemainSpace(Vector3 dir, bool byAnalog = false)
	{
		return default(bool);
	}

	[Token(Token = "0x600254A")]
	[Address(RVA = "0x68C430", Offset = "0x68B630", VA = "0x18068C430")]
	private PadInputDirection VecToDirection(Vector2 vec)
	{
		return default(PadInputDirection);
	}

	[Token(Token = "0x600254B")]
	[Address(RVA = "0x68A160", Offset = "0x689360", VA = "0x18068A160")]
	private void OnScroll(Vector2 vec)
	{
	}

	[Token(Token = "0x600254C")]
	[Address(RVA = "0x689F80", Offset = "0x689180", VA = "0x180689F80")]
	private void OnInputAnalog(Vector2 vec, bool isMain)
	{
	}

	[Token(Token = "0x600254D")]
	[Address(RVA = "0x68A0F0", Offset = "0x6892F0", VA = "0x18068A0F0")]
	private void OnInputUp()
	{
	}

	[Token(Token = "0x600254E")]
	[Address(RVA = "0x689FA0", Offset = "0x6891A0", VA = "0x180689FA0")]
	private void OnInputDown()
	{
	}

	[Token(Token = "0x600254F")]
	[Address(RVA = "0x68A010", Offset = "0x689210", VA = "0x18068A010")]
	private void OnInputLeft()
	{
	}

	[Token(Token = "0x6002550")]
	[Address(RVA = "0x68A080", Offset = "0x689280", VA = "0x18068A080")]
	private void OnInputRight()
	{
	}

	[Token(Token = "0x6002551")]
	[Address(RVA = "0x68A340", Offset = "0x689540", VA = "0x18068A340")]
	private void OnSelectedScrollRect()
	{
	}

	[Token(Token = "0x6002552")]
	[Address(RVA = "0x68C860", Offset = "0x68BA60", VA = "0x18068C860")]
	private bool isEnabledSelection()
	{
		return default(bool);
	}

	[Token(Token = "0x6002553")]
	[Address(RVA = "0x68A3F0", Offset = "0x6895F0", VA = "0x18068A3F0")]
	private bool OnSelectedSelector(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002554")]
	[Address(RVA = "0x68C070", Offset = "0x68B270", VA = "0x18068C070", Slot = "4")]
	public bool TrySelectionTransitionCustom(PadInputDirection direction, SelectionItem target, bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002555")]
	[Address(RVA = "0x689AB0", Offset = "0x688CB0", VA = "0x180689AB0")]
	private int GetSelectionItemPosX(SelectionItem selection)
	{
		return default(int);
	}

	[Token(Token = "0x6002556")]
	[Address(RVA = "0x689B40", Offset = "0x688D40", VA = "0x180689B40")]
	private int GetSelectionItemPosY(SelectionItem selection)
	{
		return default(int);
	}

	[Token(Token = "0x6002557")]
	[Address(RVA = "0x68C4A0", Offset = "0x68B6A0", VA = "0x18068C4A0")]
	public FreeScrollView()
	{
	}
}
