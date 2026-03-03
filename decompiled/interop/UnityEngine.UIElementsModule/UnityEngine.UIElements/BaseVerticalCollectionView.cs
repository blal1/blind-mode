using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using Unity.Properties;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000087")]
public abstract class BaseVerticalCollectionView : BindableElement, ISerializationCallbackReceiver
{
	[Token(Token = "0x2000088")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BindableElement.UxmlTraits
	{
		[Token(Token = "0x4000325")]
		[FieldOffset(Offset = "0x90")]
		private readonly UxmlEnumAttributeDescription<CollectionVirtualizationMethod> m_VirtualizationMethod;

		[Token(Token = "0x4000326")]
		[FieldOffset(Offset = "0x98")]
		private readonly UxmlIntAttributeDescription m_FixedItemHeight;

		[Token(Token = "0x4000327")]
		[FieldOffset(Offset = "0xA0")]
		private readonly UxmlBoolAttributeDescription m_ShowBorder;

		[Token(Token = "0x4000328")]
		[FieldOffset(Offset = "0xA8")]
		private readonly UxmlEnumAttributeDescription<SelectionType> m_SelectionType;

		[Token(Token = "0x4000329")]
		[FieldOffset(Offset = "0xB0")]
		private readonly UxmlEnumAttributeDescription<AlternatingRowBackground> m_ShowAlternatingRowBackgrounds;

		[Token(Token = "0x400032A")]
		[FieldOffset(Offset = "0xB8")]
		private readonly UxmlBoolAttributeDescription m_Reorderable;

		[Token(Token = "0x400032B")]
		[FieldOffset(Offset = "0xC0")]
		private readonly UxmlBoolAttributeDescription m_HorizontalScrollingEnabled;

		[Token(Token = "0x6000551")]
		[Address(RVA = "0x2AB8F20", Offset = "0x2AB8120", VA = "0x182AB8F20")]
		public UxmlTraits()
		{
		}

		[Token(Token = "0x6000552")]
		[Address(RVA = "0x2AB7950", Offset = "0x2AB6B50", VA = "0x182AB7950", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}
	}

	[Token(Token = "0x2000089")]
	private class Selection
	{
		[Token(Token = "0x400032C")]
		[FieldOffset(Offset = "0x10")]
		private readonly HashSet<int> m_IndexLookup;

		[Token(Token = "0x400032D")]
		[FieldOffset(Offset = "0x18")]
		private readonly HashSet<int> m_IdLookup;

		[Token(Token = "0x400032E")]
		[FieldOffset(Offset = "0x20")]
		private int m_MinIndex;

		[Token(Token = "0x400032F")]
		[FieldOffset(Offset = "0x24")]
		private int m_MaxIndex;

		[Token(Token = "0x4000331")]
		[FieldOffset(Offset = "0x30")]
		public readonly List<int> indices;

		[Token(Token = "0x4000332")]
		[FieldOffset(Offset = "0x38")]
		public readonly Dictionary<int, object> items;

		[Token(Token = "0x170000D4")]
		public List<int> selectedIds
		{
			[Token(Token = "0x6000553")]
			[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000554")]
			[Address(RVA = "0x402FB0", Offset = "0x4021B0", VA = "0x180402FB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x170000D5")]
		public int indexCount
		{
			[Token(Token = "0x6000555")]
			[Address(RVA = "0x2AB4D00", Offset = "0x2AB3F00", VA = "0x182AB4D00")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D6")]
		public int idCount
		{
			[Token(Token = "0x6000556")]
			[Address(RVA = "0x2AB4CC0", Offset = "0x2AB3EC0", VA = "0x182AB4CC0")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D7")]
		public int minIndex
		{
			[Token(Token = "0x6000557")]
			[Address(RVA = "0x2AB4D70", Offset = "0x2AB3F70", VA = "0x182AB4D70")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D8")]
		public int maxIndex
		{
			[Token(Token = "0x6000558")]
			[Address(RVA = "0x2AB4D40", Offset = "0x2AB3F40", VA = "0x182AB4D40")]
			get
			{
				return default(int);
			}
		}

		[Token(Token = "0x170000D9")]
		public int capacity
		{
			[Token(Token = "0x6000559")]
			[Address(RVA = "0x2AB4C70", Offset = "0x2AB3E70", VA = "0x182AB4C70")]
			get
			{
				return default(int);
			}
			[Token(Token = "0x600055A")]
			[Address(RVA = "0x2AB4DA0", Offset = "0x2AB3FA0", VA = "0x182AB4DA0")]
			set
			{
			}
		}

		[Token(Token = "0x600055B")]
		[Address(RVA = "0x2AB4880", Offset = "0x2AB3A80", VA = "0x182AB4880")]
		public int FirstIndex()
		{
			return default(int);
		}

		[Token(Token = "0x600055C")]
		[Address(RVA = "0x2AB48F0", Offset = "0x2AB3AF0", VA = "0x182AB48F0")]
		public object FirstObject()
		{
			return null;
		}

		[Token(Token = "0x600055D")]
		[Address(RVA = "0x2AB4820", Offset = "0x2AB3A20", VA = "0x182AB4820")]
		public bool ContainsIndex(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x600055E")]
		[Address(RVA = "0x2AB47C0", Offset = "0x2AB39C0", VA = "0x182AB47C0")]
		public bool ContainsId(int id)
		{
			return default(bool);
		}

		[Token(Token = "0x600055F")]
		[Address(RVA = "0x2AB43D0", Offset = "0x2AB35D0", VA = "0x182AB43D0")]
		public void AddId(int id)
		{
		}

		[Token(Token = "0x6000560")]
		[Address(RVA = "0x2AB4490", Offset = "0x2AB3690", VA = "0x182AB4490")]
		public void AddIndex(int index, object obj)
		{
		}

		[Token(Token = "0x6000561")]
		[Address(RVA = "0x2AB4A40", Offset = "0x2AB3C40", VA = "0x182AB4A40")]
		public bool TryRemove(int index)
		{
			return default(bool);
		}

		[Token(Token = "0x6000562")]
		[Address(RVA = "0x2AB49C0", Offset = "0x2AB3BC0", VA = "0x182AB49C0")]
		public void RemoveId(int id)
		{
		}

		[Token(Token = "0x6000563")]
		[Address(RVA = "0x2AB4670", Offset = "0x2AB3870", VA = "0x182AB4670")]
		public void ClearItems()
		{
		}

		[Token(Token = "0x6000564")]
		[Address(RVA = "0x2AB4590", Offset = "0x2AB3790", VA = "0x182AB4590")]
		public void ClearIds()
		{
		}

		[Token(Token = "0x6000565")]
		[Address(RVA = "0x2AB4600", Offset = "0x2AB3800", VA = "0x182AB4600")]
		public void ClearIndices()
		{
		}

		[Token(Token = "0x6000566")]
		[Address(RVA = "0x2AB46C0", Offset = "0x2AB38C0", VA = "0x182AB46C0")]
		public void Clear()
		{
		}

		[Token(Token = "0x6000567")]
		[Address(RVA = "0x2AB4B30", Offset = "0x2AB3D30", VA = "0x182AB4B30")]
		public Selection()
		{
		}
	}

	[Token(Token = "0x200008E")]
	[CompilerGenerated]
	private sealed class _003Cget_selectedItems_003Ed__88 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400033B")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400033C")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400033D")]
		[FieldOffset(Offset = "0x20")]
		private int _003C_003El__initialThreadId;

		[Token(Token = "0x400033E")]
		[FieldOffset(Offset = "0x28")]
		public BaseVerticalCollectionView _003C_003E4__this;

		[Token(Token = "0x400033F")]
		[FieldOffset(Offset = "0x30")]
		private List<int>.Enumerator _003C_003Es__1;

		[Token(Token = "0x4000340")]
		[FieldOffset(Offset = "0x48")]
		private int _003Cindex_003E5__2;

		[Token(Token = "0x4000341")]
		[FieldOffset(Offset = "0x50")]
		private object _003Citem_003E5__3;

		[Token(Token = "0x170000DA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000571")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170000DB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000573")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600056D")]
		[Address(RVA = "0x59ED60", Offset = "0x59DF60", VA = "0x18059ED60")]
		[DebuggerHidden]
		public _003Cget_selectedItems_003Ed__88(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600056E")]
		[Address(RVA = "0x2AB5640", Offset = "0x2AB4840", VA = "0x182AB5640", Slot = "7")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600056F")]
		[Address(RVA = "0x2AB52E0", Offset = "0x2AB44E0", VA = "0x182AB52E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000570")]
		[Address(RVA = "0x2AB56D0", Offset = "0x2AB48D0", VA = "0x182AB56D0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000572")]
		[Address(RVA = "0x2AB5600", Offset = "0x2AB4800", VA = "0x182AB5600", Slot = "10")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}

		[Token(Token = "0x6000574")]
		[Address(RVA = "0x2AB5560", Offset = "0x2AB4760", VA = "0x182AB5560", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<object> System_002ECollections_002EGeneric_002EIEnumerable_003CSystem_002EObject_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000575")]
		[Address(RVA = "0x2AB5560", Offset = "0x2AB4760", VA = "0x182AB5560", Slot = "5")]
		[DebuggerHidden]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x40002E8")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId itemsSourceProperty;

	[Token(Token = "0x40002E9")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId selectionTypeProperty;

	[Token(Token = "0x40002EA")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId selectedItemProperty;

	[Token(Token = "0x40002EB")]
	[FieldOffset(Offset = "0x1C8")]
	internal static readonly BindingId selectedItemsProperty;

	[Token(Token = "0x40002EC")]
	[FieldOffset(Offset = "0x260")]
	internal static readonly BindingId selectedIndexProperty;

	[Token(Token = "0x40002ED")]
	[FieldOffset(Offset = "0x2F8")]
	internal static readonly BindingId selectedIndicesProperty;

	[Token(Token = "0x40002EE")]
	[FieldOffset(Offset = "0x390")]
	internal static readonly BindingId showBorderProperty;

	[Token(Token = "0x40002EF")]
	[FieldOffset(Offset = "0x428")]
	internal static readonly BindingId reorderableProperty;

	[Token(Token = "0x40002F0")]
	[FieldOffset(Offset = "0x4C0")]
	internal static readonly BindingId horizontalScrollingEnabledProperty;

	[Token(Token = "0x40002F1")]
	[FieldOffset(Offset = "0x558")]
	internal static readonly BindingId showAlternatingRowBackgroundsProperty;

	[Token(Token = "0x40002F2")]
	[FieldOffset(Offset = "0x5F0")]
	internal static readonly BindingId virtualizationMethodProperty;

	[Token(Token = "0x40002F3")]
	[FieldOffset(Offset = "0x688")]
	internal static readonly BindingId fixedItemHeightProperty;

	[Token(Token = "0x40002F4")]
	[FieldOffset(Offset = "0x720")]
	private static readonly ProfilerMarker k_RefreshMarker;

	[Token(Token = "0x40002F5")]
	[FieldOffset(Offset = "0x728")]
	private static readonly ProfilerMarker k_RebuildMarker;

	[Token(Token = "0x40002F6")]
	[FieldOffset(Offset = "0x4B8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<object>> itemsChosen;

	[Token(Token = "0x40002F7")]
	[FieldOffset(Offset = "0x4C0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<IEnumerable<object>> selectionChanged;

	[Token(Token = "0x40002F8")]
	[FieldOffset(Offset = "0x4C8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<int>> selectedIndicesChanged;

	[Token(Token = "0x40002F9")]
	[FieldOffset(Offset = "0x4D0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<int, int> itemIndexChanged;

	[Token(Token = "0x40002FA")]
	[FieldOffset(Offset = "0x4D8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action itemsSourceChanged;

	[Token(Token = "0x40002FB")]
	[FieldOffset(Offset = "0x4E0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action m_SelectionNotChanged;

	[Token(Token = "0x40002FC")]
	[FieldOffset(Offset = "0x4E8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<CanStartDragArgs, bool> canStartDrag;

	[Token(Token = "0x40002FD")]
	[FieldOffset(Offset = "0x4F0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Func<SetupDragAndDropArgs, StartDragArgs> setupDragAndDrop;

	[Token(Token = "0x40002FE")]
	[FieldOffset(Offset = "0x4F8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<HandleDragAndDropArgs, DragVisualMode> dragAndDropUpdate;

	[Token(Token = "0x40002FF")]
	[FieldOffset(Offset = "0x500")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<HandleDragAndDropArgs, DragVisualMode> handleDrop;

	[Token(Token = "0x4000300")]
	[FieldOffset(Offset = "0x508")]
	private SelectionType m_SelectionType;

	[Token(Token = "0x4000301")]
	[FieldOffset(Offset = "0x730")]
	private static readonly List<ReusableCollectionItem> k_EmptyItems;

	[Token(Token = "0x4000302")]
	[FieldOffset(Offset = "0x50C")]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	internal bool allowSingleClickChoice;

	[Token(Token = "0x4000303")]
	[FieldOffset(Offset = "0x50D")]
	private bool m_HorizontalScrollingEnabled;

	[Token(Token = "0x4000304")]
	[FieldOffset(Offset = "0x510")]
	[SerializeField]
	[DontCreateProperty]
	private AlternatingRowBackground m_ShowAlternatingRowBackgrounds;

	[Token(Token = "0x4000305")]
	[FieldOffset(Offset = "0x738")]
	internal static readonly string k_InvalidTemplateError;

	[Token(Token = "0x4000306")]
	[FieldOffset(Offset = "0x514")]
	internal float m_FixedItemHeight;

	[Token(Token = "0x4000307")]
	[FieldOffset(Offset = "0x518")]
	internal bool m_ItemHeightIsInline;

	[Token(Token = "0x4000308")]
	[FieldOffset(Offset = "0x51C")]
	private CollectionVirtualizationMethod m_VirtualizationMethod;

	[Token(Token = "0x4000309")]
	[FieldOffset(Offset = "0x520")]
	private readonly ScrollView m_ScrollView;

	[Token(Token = "0x400030A")]
	[FieldOffset(Offset = "0x528")]
	private CollectionViewController m_ViewController;

	[Token(Token = "0x400030B")]
	[FieldOffset(Offset = "0x530")]
	private CollectionVirtualizationController m_VirtualizationController;

	[Token(Token = "0x400030C")]
	[FieldOffset(Offset = "0x538")]
	private KeyboardNavigationManipulator m_NavigationManipulator;

	[Token(Token = "0x400030D")]
	[FieldOffset(Offset = "0x540")]
	[DontCreateProperty]
	[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
	[SerializeField]
	internal SerializedVirtualizationData serializedVirtualizationData;

	[Token(Token = "0x400030E")]
	[FieldOffset(Offset = "0x548")]
	[DontCreateProperty]
	[SerializeField]
	private List<int> m_SelectedIds;

	[Token(Token = "0x400030F")]
	[FieldOffset(Offset = "0x550")]
	private readonly Selection m_Selection;

	[Token(Token = "0x4000310")]
	[FieldOffset(Offset = "0x558")]
	private float m_LastHeight;

	[Token(Token = "0x4000311")]
	[FieldOffset(Offset = "0x55C")]
	private bool m_IsRangeSelectionDirectionUp;

	[Token(Token = "0x4000312")]
	[FieldOffset(Offset = "0x560")]
	private ListViewDragger m_Dragger;

	[Token(Token = "0x4000313")]
	[FieldOffset(Offset = "0x740")]
	internal static CustomStyleProperty<int> s_ItemHeightProperty;

	[Token(Token = "0x4000314")]
	[FieldOffset(Offset = "0x568")]
	private Action<int, int> m_ItemIndexChangedCallback;

	[Token(Token = "0x4000315")]
	[FieldOffset(Offset = "0x570")]
	private Action m_ItemsSourceChangedCallback;

	[Token(Token = "0x4000316")]
	[FieldOffset(Offset = "0x578")]
	private IVisualElementScheduledItem m_RebuildScheduled;

	[Token(Token = "0x4000317")]
	[FieldOffset(Offset = "0x748")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000318")]
	[FieldOffset(Offset = "0x750")]
	public static readonly string borderUssClassName;

	[Token(Token = "0x4000319")]
	[FieldOffset(Offset = "0x758")]
	public static readonly string itemUssClassName;

	[Token(Token = "0x400031A")]
	[FieldOffset(Offset = "0x760")]
	public static readonly string dragHoverBarUssClassName;

	[Token(Token = "0x400031B")]
	[FieldOffset(Offset = "0x768")]
	public static readonly string dragHoverMarkerUssClassName;

	[Token(Token = "0x400031C")]
	[FieldOffset(Offset = "0x770")]
	public static readonly string itemDragHoverUssClassName;

	[Token(Token = "0x400031D")]
	[FieldOffset(Offset = "0x778")]
	public static readonly string itemSelectedVariantUssClassName;

	[Token(Token = "0x400031E")]
	[FieldOffset(Offset = "0x780")]
	public static readonly string itemAlternativeBackgroundUssClassName;

	[Token(Token = "0x400031F")]
	[FieldOffset(Offset = "0x788")]
	public static readonly string listScrollViewUssClassName;

	[Token(Token = "0x4000320")]
	[FieldOffset(Offset = "0x790")]
	internal static readonly string backgroundFillUssClassName;

	[Token(Token = "0x4000321")]
	[FieldOffset(Offset = "0x580")]
	internal int m_PreviousRefreshedCount;

	[Token(Token = "0x4000322")]
	[FieldOffset(Offset = "0x584")]
	private Vector3 m_TouchDownPosition;

	[Token(Token = "0x4000323")]
	[FieldOffset(Offset = "0x590")]
	private long m_LastPointerDownTimeStamp;

	[Token(Token = "0x4000324")]
	[FieldOffset(Offset = "0x598")]
	private int m_PointerDownCount;

	[Token(Token = "0x170000BF")]
	[CreateProperty]
	public IList itemsSource
	{
		[Token(Token = "0x60004F3")]
		[Address(RVA = "0x2AA6EF0", Offset = "0x2AA60F0", VA = "0x182AA6EF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60004F4")]
		[Address(RVA = "0x2AA74C0", Offset = "0x2AA66C0", VA = "0x182AA74C0")]
		set
		{
		}
	}

	[Token(Token = "0x170000C0")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x60004F5")]
		[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C1")]
	[CreateProperty]
	public SelectionType selectionType
	{
		[Token(Token = "0x60004F6")]
		[Address(RVA = "0x2AA7220", Offset = "0x2AA6420", VA = "0x182AA7220")]
		get
		{
			return default(SelectionType);
		}
		[Token(Token = "0x60004F7")]
		[Address(RVA = "0x2AA7710", Offset = "0x2AA6910", VA = "0x182AA7710")]
		set
		{
		}
	}

	[Token(Token = "0x170000C2")]
	[CreateProperty(ReadOnly = true)]
	public object selectedItem
	{
		[Token(Token = "0x60004F8")]
		[Address(RVA = "0x2AA70C0", Offset = "0x2AA62C0", VA = "0x182AA70C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C3")]
	[CreateProperty(ReadOnly = true)]
	public IEnumerable<object> selectedItems
	{
		[Token(Token = "0x60004F9")]
		[Address(RVA = "0x2AA71A0", Offset = "0x2AA63A0", VA = "0x182AA71A0")]
		[IteratorStateMachine(typeof(_003Cget_selectedItems_003Ed__88))]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C4")]
	[CreateProperty]
	public int selectedIndex
	{
		[Token(Token = "0x60004FA")]
		[Address(RVA = "0x2AA6FE0", Offset = "0x2AA61E0", VA = "0x182AA6FE0")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60004FB")]
		[Address(RVA = "0x2AA34B0", Offset = "0x2AA26B0", VA = "0x182AA34B0")]
		set
		{
		}
	}

	[Token(Token = "0x170000C5")]
	[CreateProperty(ReadOnly = true)]
	public IEnumerable<int> selectedIndices
	{
		[Token(Token = "0x60004FC")]
		[Address(RVA = "0x2AA70A0", Offset = "0x2AA62A0", VA = "0x182AA70A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C6")]
	public IEnumerable<int> selectedIds
	{
		[Token(Token = "0x60004FD")]
		[Address(RVA = "0x2AA6FC0", Offset = "0x2AA61C0", VA = "0x182AA6FC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C7")]
	internal IEnumerable<ReusableCollectionItem> activeItems
	{
		[Token(Token = "0x60004FE")]
		[Address(RVA = "0x2AA6E00", Offset = "0x2AA6000", VA = "0x182AA6E00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C8")]
	internal ScrollView scrollView
	{
		[Token(Token = "0x60004FF")]
		[Address(RVA = "0x2A0DE60", Offset = "0x2A0D060", VA = "0x182A0DE60")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000C9")]
	internal ListViewDragger dragger
	{
		[Token(Token = "0x6000500")]
		[Address(RVA = "0x14CA1E0", Offset = "0x14C93E0", VA = "0x1814CA1E0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CA")]
	internal CollectionVirtualizationController virtualizationController
	{
		[Token(Token = "0x6000501")]
		[Address(RVA = "0x2AA1820", Offset = "0x2AA0A20", VA = "0x182AA1820")]
		[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CB")]
	public CollectionViewController viewController
	{
		[Token(Token = "0x6000502")]
		[Address(RVA = "0x1376BC0", Offset = "0x1375DC0", VA = "0x181376BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170000CC")]
	[CreateProperty]
	public bool showBorder
	{
		[Token(Token = "0x6000504")]
		[Address(RVA = "0x2AA7240", Offset = "0x2AA6440", VA = "0x182AA7240")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000505")]
		[Address(RVA = "0x2AA78B0", Offset = "0x2AA6AB0", VA = "0x182AA78B0")]
		set
		{
		}
	}

	[Token(Token = "0x170000CD")]
	[CreateProperty]
	public bool reorderable
	{
		[Token(Token = "0x6000506")]
		[Address(RVA = "0x2AA6F30", Offset = "0x2AA6130", VA = "0x182AA6F30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000507")]
		[Address(RVA = "0x2AA7600", Offset = "0x2AA6800", VA = "0x182AA7600")]
		set
		{
		}
	}

	[Token(Token = "0x170000CE")]
	[CreateProperty]
	public bool horizontalScrollingEnabled
	{
		[Token(Token = "0x6000508")]
		[Address(RVA = "0x2AA6E90", Offset = "0x2AA6090", VA = "0x182AA6E90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000509")]
		[Address(RVA = "0x2AA7400", Offset = "0x2AA6600", VA = "0x182AA7400")]
		set
		{
		}
	}

	[Token(Token = "0x170000CF")]
	[CreateProperty]
	public AlternatingRowBackground showAlternatingRowBackgrounds
	{
		[Token(Token = "0x600050A")]
		[Address(RVA = "0x2AA7230", Offset = "0x2AA6430", VA = "0x182AA7230")]
		get
		{
			return default(AlternatingRowBackground);
		}
		[Token(Token = "0x600050B")]
		[Address(RVA = "0x2AA7820", Offset = "0x2AA6A20", VA = "0x182AA7820")]
		set
		{
		}
	}

	[Token(Token = "0x170000D0")]
	[CreateProperty]
	public CollectionVirtualizationMethod virtualizationMethod
	{
		[Token(Token = "0x600050C")]
		[Address(RVA = "0x1036740", Offset = "0x1035940", VA = "0x181036740")]
		get
		{
			return default(CollectionVirtualizationMethod);
		}
		[Token(Token = "0x600050D")]
		[Address(RVA = "0x2AA79A0", Offset = "0x2AA6BA0", VA = "0x182AA79A0")]
		set
		{
		}
	}

	[Token(Token = "0x170000D1")]
	[CreateProperty]
	public float fixedItemHeight
	{
		[Token(Token = "0x600050E")]
		[Address(RVA = "0x2AA6E80", Offset = "0x2AA6080", VA = "0x182AA6E80")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600050F")]
		[Address(RVA = "0x2AA72C0", Offset = "0x2AA64C0", VA = "0x182AA72C0")]
		set
		{
		}
	}

	[Token(Token = "0x170000D2")]
	internal float lastHeight
	{
		[Token(Token = "0x6000510")]
		[Address(RVA = "0x2AA6F20", Offset = "0x2AA6120", VA = "0x182AA6F20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170000D3")]
	internal bool isRebuildScheduled
	{
		[Token(Token = "0x6000511")]
		[Address(RVA = "0x2AA6EA0", Offset = "0x2AA60A0", VA = "0x182AA6EA0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60004EE")]
	[Address(RVA = "0x2AA1CE0", Offset = "0x2AA0EE0", VA = "0x182AA1CE0")]
	internal bool HasCanStartDrag()
	{
		return default(bool);
	}

	[Token(Token = "0x60004EF")]
	[Address(RVA = "0x2AA34C0", Offset = "0x2AA26C0", VA = "0x182AA34C0")]
	internal bool RaiseCanStartDrag(ReusableCollectionItem item, IEnumerable<int> ids)
	{
		return default(bool);
	}

	[Token(Token = "0x60004F0")]
	[Address(RVA = "0x2AA3710", Offset = "0x2AA2910", VA = "0x182AA3710")]
	internal StartDragArgs RaiseSetupDragAndDrop(ReusableCollectionItem item, IEnumerable<int> ids, StartDragArgs args)
	{
		return default(StartDragArgs);
	}

	[Token(Token = "0x60004F1")]
	[Address(RVA = "0x2AA3670", Offset = "0x2AA2870", VA = "0x182AA3670")]
	internal DragVisualMode RaiseHandleDragAndDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
	{
		return default(DragVisualMode);
	}

	[Token(Token = "0x60004F2")]
	[Address(RVA = "0x2AA35D0", Offset = "0x2AA27D0", VA = "0x182AA35D0")]
	internal DragVisualMode RaiseDrop(Vector2 pointerPosition, DragAndDropArgs dragAndDropArgs)
	{
		return default(DragVisualMode);
	}

	[Token(Token = "0x6000503")]
	[Address(RVA = "0x2AA46C0", Offset = "0x2AA38C0", VA = "0x182AA46C0")]
	internal float ResolveItemHeight(float height = -1f)
	{
		return default(float);
	}

	[Token(Token = "0x6000512")]
	[Address(RVA = "0x2AA1050", Offset = "0x2AA0250", VA = "0x182AA1050", Slot = "141")]
	private protected virtual void CreateVirtualizationController()
	{
	}

	[Token(Token = "0x6000513")]
	[Address(RVA = "0x2AA1820", Offset = "0x2AA0A20", VA = "0x182AA1820")]
	internal CollectionVirtualizationController GetOrCreateVirtualizationController()
	{
		return null;
	}

	[Token(Token = "0x6000514")]
	internal void CreateVirtualizationController<T>() where T : ReusableCollectionItem, new()
	{
	}

	[Token(Token = "0x6000515")]
	[Address(RVA = "0x2AA17C0", Offset = "0x2AA09C0", VA = "0x182AA17C0")]
	internal CollectionViewController GetOrCreateViewController()
	{
		return null;
	}

	[Token(Token = "0x6000516")]
	protected abstract CollectionViewController CreateViewController();

	[Token(Token = "0x6000517")]
	[Address(RVA = "0x2AA50C0", Offset = "0x2AA42C0", VA = "0x182AA50C0", Slot = "143")]
	public virtual void SetViewController(CollectionViewController controller)
	{
	}

	[Token(Token = "0x6000518")]
	[Address(RVA = "0x2AA0FF0", Offset = "0x2AA01F0", VA = "0x182AA0FF0", Slot = "144")]
	internal virtual ListViewDragger CreateDragger()
	{
		return null;
	}

	[Token(Token = "0x6000519")]
	[Address(RVA = "0x2AA1D30", Offset = "0x2AA0F30", VA = "0x182AA1D30")]
	internal void InitializeDragAndDropController(bool enableReordering)
	{
	}

	[Token(Token = "0x600051A")]
	internal abstract ICollectionDragAndDropController CreateDragAndDropController();

	[Token(Token = "0x600051B")]
	[Address(RVA = "0x2AA6320", Offset = "0x2AA5520", VA = "0x182AA6320")]
	public BaseVerticalCollectionView()
	{
	}

	[Token(Token = "0x600051C")]
	[Address(RVA = "0x2AA6C50", Offset = "0x2AA5E50", VA = "0x182AA6C50")]
	public BaseVerticalCollectionView(IList itemsSource, float itemHeight = -1f)
	{
	}

	[Token(Token = "0x600051D")]
	[Address(RVA = "0x2AA1860", Offset = "0x2AA0A60", VA = "0x182AA1860")]
	public VisualElement GetRootElementForId(int id)
	{
		return null;
	}

	[Token(Token = "0x600051E")]
	[Address(RVA = "0x2AA1CF0", Offset = "0x2AA0EF0", VA = "0x182AA1CF0", Slot = "146")]
	internal virtual bool HasValidDataAndBindings()
	{
		return default(bool);
	}

	[Token(Token = "0x600051F")]
	[Address(RVA = "0x2AA2970", Offset = "0x2AA1B70", VA = "0x182AA2970")]
	private void OnItemIndexChanged(int srcIndex, int dstIndex)
	{
	}

	[Token(Token = "0x6000520")]
	[Address(RVA = "0x2AA29B0", Offset = "0x2AA1BB0", VA = "0x182AA29B0")]
	private void OnItemsSourceChanged()
	{
	}

	[Token(Token = "0x6000521")]
	[Address(RVA = "0x2AA39F0", Offset = "0x2AA2BF0", VA = "0x182AA39F0")]
	public void RefreshItems()
	{
	}

	[Token(Token = "0x6000522")]
	[Address(RVA = "0x2AA3860", Offset = "0x2AA2A60", VA = "0x182AA3860")]
	public void Rebuild()
	{
	}

	[Token(Token = "0x6000523")]
	[Address(RVA = "0x2AA46E0", Offset = "0x2AA38E0", VA = "0x182AA46E0")]
	internal void ScheduleRebuild()
	{
	}

	[Token(Token = "0x6000524")]
	[Address(RVA = "0x2AA3BB0", Offset = "0x2AA2DB0", VA = "0x182AA3BB0")]
	private void RefreshSelection()
	{
	}

	[Token(Token = "0x6000525")]
	[Address(RVA = "0x2AA2D80", Offset = "0x2AA1F80", VA = "0x182AA2D80", Slot = "147")]
	private protected virtual void PostRefresh()
	{
	}

	[Token(Token = "0x6000526")]
	[Address(RVA = "0x2AA48A0", Offset = "0x2AA3AA0", VA = "0x182AA48A0")]
	public void ScrollToItem(int index)
	{
	}

	[Token(Token = "0x6000527")]
	[Address(RVA = "0x2AA4800", Offset = "0x2AA3A00", VA = "0x182AA4800")]
	public void ScrollToItemById(int id)
	{
	}

	[Token(Token = "0x6000528")]
	[Address(RVA = "0x2AA2C10", Offset = "0x2AA1E10", VA = "0x182AA2C10")]
	private void OnScroll(Vector2 offset)
	{
	}

	[Token(Token = "0x6000529")]
	[Address(RVA = "0x2AA4600", Offset = "0x2AA3800", VA = "0x182AA4600")]
	private void Resize(Vector2 size)
	{
	}

	[Token(Token = "0x600052A")]
	[Address(RVA = "0x2AA21C0", Offset = "0x2AA13C0", VA = "0x182AA21C0")]
	private void OnAttachToPanel(AttachToPanelEvent evt)
	{
	}

	[Token(Token = "0x600052B")]
	[Address(RVA = "0x2AA26B0", Offset = "0x2AA18B0", VA = "0x182AA26B0")]
	private void OnDetachFromPanel(DetachFromPanelEvent evt)
	{
	}

	[Token(Token = "0x600052C")]
	[Address(RVA = "0x2AA0600", Offset = "0x2A9F800", VA = "0x182AA0600")]
	private bool Apply(KeyboardNavigationOperation op, bool shiftKey, bool altKey)
	{
		return default(bool);
	}

	[Token(Token = "0x600052D")]
	[Address(RVA = "0x2AA0AE0", Offset = "0x2A9FCE0", VA = "0x182AA0AE0")]
	private void Apply(KeyboardNavigationOperation op, EventBase sourceEvent)
	{
	}

	[Token(Token = "0x600052E")]
	[Address(RVA = "0xA2E980", Offset = "0xA2DB80", VA = "0x180A2E980", Slot = "148")]
	private protected virtual bool HandleItemNavigation(bool moveIn, bool altKey)
	{
		return default(bool);
	}

	[Token(Token = "0x600052F")]
	[Address(RVA = "0x2AA2B80", Offset = "0x2AA1D80", VA = "0x182AA2B80")]
	private void OnPointerMove(PointerMoveEvent evt)
	{
	}

	[Token(Token = "0x6000530")]
	[Address(RVA = "0x2AA2B70", Offset = "0x2AA1D70", VA = "0x182AA2B70")]
	private void OnPointerDown(PointerDownEvent evt)
	{
	}

	[Token(Token = "0x6000531")]
	[Address(RVA = "0x2AA2B00", Offset = "0x2AA1D00", VA = "0x182AA2B00")]
	private void OnPointerCancel(PointerCancelEvent evt)
	{
	}

	[Token(Token = "0x6000532")]
	[Address(RVA = "0x2AA2C00", Offset = "0x2AA1E00", VA = "0x182AA2C00")]
	private void OnPointerUp(PointerUpEvent evt)
	{
	}

	[Token(Token = "0x6000533")]
	[Address(RVA = "0x2AA2E50", Offset = "0x2AA2050", VA = "0x182AA2E50")]
	private void ProcessPointerDown(IPointerEvent evt)
	{
	}

	[Token(Token = "0x6000534")]
	[Address(RVA = "0x2AA30E0", Offset = "0x2AA22E0", VA = "0x182AA30E0")]
	private void ProcessPointerUp(IPointerEvent evt)
	{
	}

	[Token(Token = "0x6000535")]
	[Address(RVA = "0x2AA1250", Offset = "0x2AA0450", VA = "0x182AA1250")]
	private void DoSelect(Vector2 localPosition, int mouseButton, int clickCount, bool actionKey, bool shiftKey)
	{
	}

	[Token(Token = "0x6000536")]
	[Address(RVA = "0x2AA1090", Offset = "0x2AA0290", VA = "0x182AA1090")]
	internal void DoRangeSelection(int rangeSelectionFinalIndex)
	{
	}

	[Token(Token = "0x6000537")]
	[Address(RVA = "0x2AA34B0", Offset = "0x2AA26B0", VA = "0x182AA34B0")]
	private void ProcessSingleClick(int clickedIndex)
	{
	}

	[Token(Token = "0x6000538")]
	[Address(RVA = "0x2AA4920", Offset = "0x2AA3B20", VA = "0x182AA4920")]
	internal void SelectAll()
	{
	}

	[Token(Token = "0x6000539")]
	[Address(RVA = "0x2AA0370", Offset = "0x2A9F570", VA = "0x182AA0370")]
	public void AddToSelection(int index)
	{
	}

	[Token(Token = "0x600053A")]
	[Address(RVA = "0x2AA03E0", Offset = "0x2A9F5E0", VA = "0x182AA03E0")]
	internal void AddToSelection(IList<int> indexes)
	{
	}

	[Token(Token = "0x600053B")]
	[Address(RVA = "0x2AA0080", Offset = "0x2A9F280", VA = "0x182AA0080")]
	private void AddToSelectionWithoutValidation(int index)
	{
	}

	[Token(Token = "0x600053C")]
	[Address(RVA = "0x2AA45A0", Offset = "0x2AA37A0", VA = "0x182AA45A0")]
	public void RemoveFromSelection(int index)
	{
	}

	[Token(Token = "0x600053D")]
	[Address(RVA = "0x2AA4230", Offset = "0x2AA3430", VA = "0x182AA4230")]
	private void RemoveFromSelectionWithoutValidation(int index)
	{
	}

	[Token(Token = "0x600053E")]
	[Address(RVA = "0x2AA5030", Offset = "0x2AA4230", VA = "0x182AA5030")]
	public void SetSelection(int index)
	{
	}

	[Token(Token = "0x600053F")]
	[Address(RVA = "0x2AA5020", Offset = "0x2AA4220", VA = "0x182AA5020")]
	public void SetSelection(IEnumerable<int> indices)
	{
	}

	[Token(Token = "0x6000540")]
	[Address(RVA = "0x2AA5010", Offset = "0x2AA4210", VA = "0x182AA5010")]
	public void SetSelectionWithoutNotify(IEnumerable<int> indices)
	{
	}

	[Token(Token = "0x6000541")]
	[Address(RVA = "0x2AA4C10", Offset = "0x2AA3E10", VA = "0x182AA4C10")]
	internal void SetSelectionInternal(IEnumerable<int> indices, bool sendNotification)
	{
	}

	[Token(Token = "0x6000542")]
	[Address(RVA = "0x2AA1E60", Offset = "0x2AA1060", VA = "0x182AA1E60")]
	private bool MatchesExistingSelection(IEnumerable<int> indices)
	{
		return default(bool);
	}

	[Token(Token = "0x6000543")]
	[Address(RVA = "0x2AA2130", Offset = "0x2AA1330", VA = "0x182AA2130")]
	private void NotifyOfSelectionChange()
	{
	}

	[Token(Token = "0x6000544")]
	[Address(RVA = "0x2AA0F60", Offset = "0x2AA0160", VA = "0x182AA0F60")]
	public void ClearSelection()
	{
	}

	[Token(Token = "0x6000545")]
	[Address(RVA = "0x2AA0CA0", Offset = "0x2A9FEA0", VA = "0x182AA0CA0")]
	private void ClearSelectionWithoutValidation()
	{
	}

	[Token(Token = "0x6000546")]
	[Address(RVA = "0x2AA2D30", Offset = "0x2AA1F30", VA = "0x182AA2D30", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6000547")]
	[Address(RVA = "0x2AA1960", Offset = "0x2AA0B60", VA = "0x182AA1960", Slot = "8")]
	[EventInterest(new Type[]
	{
		typeof(PointerUpEvent),
		typeof(FocusInEvent),
		typeof(FocusOutEvent),
		typeof(NavigationSubmitEvent)
	})]
	protected override void HandleEventBubbleUp(EventBase evt)
	{
	}

	[Token(Token = "0x6000548")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "12")]
	[EventInterest(EventInterestOptions.Inherit)]
	[Obsolete("ExecuteDefaultAction override has been removed because default event handling was migrated to HandleEventBubbleUp. Please use HandleEventBubbleUp.", false)]
	protected override void ExecuteDefaultAction(EventBase evt)
	{
	}

	[Token(Token = "0x6000549")]
	[Address(RVA = "0x2AA2C90", Offset = "0x2AA1E90", VA = "0x182AA2C90")]
	private void OnSizeChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x600054A")]
	[Address(RVA = "0x2AA2500", Offset = "0x2AA1700", VA = "0x182AA2500")]
	private void OnCustomStyleResolved(CustomStyleResolvedEvent e)
	{
	}

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "139")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x2AA53F0", Offset = "0x2AA45F0", VA = "0x182AA53F0", Slot = "140")]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}
}
