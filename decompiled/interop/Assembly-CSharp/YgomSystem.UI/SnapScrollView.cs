using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200046A")]
[RequireComponent(typeof(ScrollRect))]
public class SnapScrollView : MonoBehaviour
{
	[Token(Token = "0x200046B")]
	private class SearchNearPtCalculator
	{
		[Token(Token = "0x200046C")]
		private class PointDiffData : IComparable<PointDiffData>
		{
			[Token(Token = "0x400159E")]
			[FieldOffset(Offset = "0x10")]
			public readonly float fromPoint;

			[Token(Token = "0x400159F")]
			[FieldOffset(Offset = "0x14")]
			public readonly float toPoint;

			[Token(Token = "0x170002C1")]
			public float diff
			{
				[Token(Token = "0x6001C91")]
				[Address(RVA = "0x601030", Offset = "0x600230", VA = "0x180601030")]
				get
				{
					return default(float);
				}
			}

			[Token(Token = "0x6001C92")]
			[Address(RVA = "0x600FF0", Offset = "0x6001F0", VA = "0x180600FF0")]
			public PointDiffData(float fromPoint, float toPoint)
			{
			}

			[Token(Token = "0x6001C93")]
			[Address(RVA = "0x600FA0", Offset = "0x6001A0", VA = "0x180600FA0", Slot = "4")]
			public int CompareTo(PointDiffData other)
			{
				return default(int);
			}
		}

		[Token(Token = "0x400159D")]
		[FieldOffset(Offset = "0x10")]
		private List<PointDiffData> m_PointDiffs;

		[Token(Token = "0x6001C8F")]
		[Address(RVA = "0x605480", Offset = "0x604680", VA = "0x180605480")]
		public (Vector2, Vector2) SearchNearPtPair(Bounds fromBounds, Bounds toBounds)
		{
			return default((Vector2, Vector2));
		}

		[Token(Token = "0x6001C90")]
		[Address(RVA = "0x605C90", Offset = "0x604E90", VA = "0x180605C90")]
		public SearchNearPtCalculator()
		{
		}
	}

	[Token(Token = "0x200046D")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40015A0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40015A1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40015A2")]
		[FieldOffset(Offset = "0x20")]
		public SnapScrollView _003C_003E4__this;

		[Token(Token = "0x170002C2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6001C97")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170002C3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6001C99")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6001C94")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6001C95")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6001C96")]
		[Address(RVA = "0x612A30", Offset = "0x611C30", VA = "0x180612A30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6001C98")]
		[Address(RVA = "0x612CB0", Offset = "0x611EB0", VA = "0x180612CB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private SelectionTransitionSetting m_UpEdgeTransition;

	[Token(Token = "0x400158B")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private SelectionTransitionSetting m_DownEdgeTransition;

	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private SelectionTransitionSetting m_RightEdgeTransition;

	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private SelectionTransitionSetting m_LeftEdgeTransition;

	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public bool m_ScrollAnalogMain;

	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x41")]
	[SerializeField]
	public bool m_ScrollAnalogSub;

	[Token(Token = "0x4001590")]
	[FieldOffset(Offset = "0x44")]
	[SerializeField]
	public float m_ThresInput;

	[Token(Token = "0x4001591")]
	[FieldOffset(Offset = "0x48")]
	private Selector m_MainSelectorCache;

	[Token(Token = "0x4001592")]
	[FieldOffset(Offset = "0x50")]
	private List<Selector> m_Selectors;

	[Token(Token = "0x4001593")]
	[FieldOffset(Offset = "0x58")]
	private ExtendedScrollRect m_ScrollRectCache;

	[Token(Token = "0x4001594")]
	[FieldOffset(Offset = "0x60")]
	private RectOffset m_PaddingCache;

	[Token(Token = "0x4001595")]
	[FieldOffset(Offset = "0x68")]
	private List<SelectionItem> m_AssignedItems;

	[Token(Token = "0x4001596")]
	[FieldOffset(Offset = "0x70")]
	private bool m_TransitionBlocker;

	[Token(Token = "0x4001597")]
	[FieldOffset(Offset = "0x78")]
	private List<SelectionItem> m_SortTargetSelections;

	[Token(Token = "0x4001598")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<SelectionItem, float> m_SortAmounts;

	[Token(Token = "0x4001599")]
	[FieldOffset(Offset = "0x88")]
	private SelectionItem m_LastSelectedItem;

	[Token(Token = "0x400159A")]
	[FieldOffset(Offset = "0x90")]
	private SearchNearPtCalculator m_SearchNearPtCalculator;

	[Token(Token = "0x400159B")]
	[FieldOffset(Offset = "0x98")]
	public Func<bool, bool> customSelectorSelectedFunc;

	[Token(Token = "0x400159C")]
	[FieldOffset(Offset = "0xA0")]
	public Func<PadInputDirection, bool> customInputDirectionFunc;

	[Token(Token = "0x170002BC")]
	public SelectionTransitionSetting upEdgeTransition
	{
		[Token(Token = "0x6001C72")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BD")]
	public SelectionTransitionSetting downEdgeTransition
	{
		[Token(Token = "0x6001C73")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BE")]
	public RectOffset padding
	{
		[Token(Token = "0x6001C74")]
		[Address(RVA = "0x612070", Offset = "0x611270", VA = "0x180612070")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002BF")]
	public ExtendedScrollRect scrollRect
	{
		[Token(Token = "0x6001C75")]
		[Address(RVA = "0x612120", Offset = "0x611320", VA = "0x180612120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170002C0")]
	public Selector mainSelector
	{
		[Token(Token = "0x6001C76")]
		[Address(RVA = "0x611F60", Offset = "0x611160", VA = "0x180611F60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001C77")]
	[Address(RVA = "0x60FC00", Offset = "0x60EE00", VA = "0x18060FC00")]
	private bool ContainsItem(SelectionItem selectionItem)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C78")]
	[Address(RVA = "0x60FF30", Offset = "0x60F130", VA = "0x18060FF30")]
	private SelectionTransitionSetting GetDirectionSetting(PadInputDirection direction)
	{
		return null;
	}

	[Token(Token = "0x6001C79")]
	[Address(RVA = "0x611A80", Offset = "0x610C80", VA = "0x180611A80")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__32))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x60F4E0", Offset = "0x60E6E0", VA = "0x18060F4E0")]
	public void AssignSelector(Selector selector)
	{
	}

	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x6116A0", Offset = "0x6108A0", VA = "0x1806116A0")]
	public void RefreshSelectionItems()
	{
	}

	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x6119C0", Offset = "0x610BC0", VA = "0x1806119C0")]
	public void ResetContentPosition()
	{
	}

	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x60FD80", Offset = "0x60EF80", VA = "0x18060FD80")]
	public void FocusBySelectionItem(SelectionItem selectionItem, bool selectItem = true, bool isInitializeSelect = false)
	{
	}

	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x60FF60", Offset = "0x60F160", VA = "0x18060FF60")]
	public void ImmediateApplyMovement()
	{
	}

	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x611AF0", Offset = "0x610CF0", VA = "0x180611AF0")]
	public void StopAutoScroll()
	{
	}

	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x60F6E0", Offset = "0x60E8E0", VA = "0x18060F6E0")]
	public Vector2 CalcFitNormalize(RectTransform target)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x60F910", Offset = "0x60EB10", VA = "0x18060F910")]
	private Vector2 CheckRectToFitDiff(RectTransform target)
	{
		return default(Vector2);
	}

	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x610020", Offset = "0x60F220", VA = "0x180610020")]
	public void InputAnalogDirection(Vector2 analogValue)
	{
	}

	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x610060", Offset = "0x60F260", VA = "0x180610060")]
	public void InputDirection(PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x610C60", Offset = "0x60FE60", VA = "0x180610C60")]
	public void LaunchEdgeTranstion(PadInputDirection direction, SelectionItem selectedItem)
	{
	}

	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnScrollValueChanged(Vector2 bias)
	{
	}

	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x610D80", Offset = "0x60FF80", VA = "0x180610D80")]
	private bool OnMainSelectorSelected(bool initializeSelection = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x611530", Offset = "0x610730", VA = "0x180611530")]
	private void OnSelectedItem()
	{
	}

	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x610D70", Offset = "0x60FF70", VA = "0x180610D70")]
	private void OnInputUp()
	{
	}

	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x610D40", Offset = "0x60FF40", VA = "0x180610D40")]
	private void OnInputDown()
	{
	}

	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x610D50", Offset = "0x60FF50", VA = "0x180610D50")]
	private void OnInputLeft()
	{
	}

	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x610D60", Offset = "0x60FF60", VA = "0x180610D60")]
	private void OnInputRight()
	{
	}

	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x611CD0", Offset = "0x610ED0", VA = "0x180611CD0")]
	public SnapScrollView()
	{
	}
}
