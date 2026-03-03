using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000076")]
public abstract class BaseListView : BaseVerticalCollectionView
{
	[Token(Token = "0x2000077")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseVerticalCollectionView.UxmlTraits
	{
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0xC8")]
		private readonly UxmlBoolAttributeDescription m_ShowFoldoutHeader;

		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0xD0")]
		private readonly UxmlStringAttributeDescription m_HeaderTitle;

		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0xD8")]
		private readonly UxmlBoolAttributeDescription m_ShowAddRemoveFooter;

		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0xE0")]
		private readonly UxmlBoolAttributeDescription m_AllowAdd;

		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0xE8")]
		private readonly UxmlBoolAttributeDescription m_AllowRemove;

		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0xF0")]
		private readonly UxmlEnumAttributeDescription<ListViewReorderMode> m_ReorderMode;

		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0xF8")]
		private readonly UxmlBoolAttributeDescription m_ShowBoundCollectionSize;

		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x100")]
		private readonly UxmlEnumAttributeDescription<BindingSourceSelectionMode> m_BindingSourceSelectionMode;

		[Token(Token = "0x600045D")]
		[Address(RVA = "0x2AB5E10", Offset = "0x2AB5010", VA = "0x182AB5E10", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600045E")]
		[Address(RVA = "0x2AB89E0", Offset = "0x2AB7BE0", VA = "0x182AB89E0")]
		protected UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000233")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string k_SizeFieldLabel;

	[Token(Token = "0x4000234")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly BindingId showBoundCollectionSizeProperty;

	[Token(Token = "0x4000235")]
	[FieldOffset(Offset = "0xA0")]
	internal static readonly BindingId showFoldoutHeaderProperty;

	[Token(Token = "0x4000236")]
	[FieldOffset(Offset = "0x138")]
	internal static readonly BindingId headerTitleProperty;

	[Token(Token = "0x4000237")]
	[FieldOffset(Offset = "0x1D0")]
	internal static readonly BindingId makeHeaderProperty;

	[Token(Token = "0x4000238")]
	[FieldOffset(Offset = "0x268")]
	internal static readonly BindingId makeFooterProperty;

	[Token(Token = "0x4000239")]
	[FieldOffset(Offset = "0x300")]
	internal static readonly BindingId showAddRemoveFooterProperty;

	[Token(Token = "0x400023A")]
	[FieldOffset(Offset = "0x398")]
	internal static readonly BindingId bindingSourceSelectionModeProperty;

	[Token(Token = "0x400023B")]
	[FieldOffset(Offset = "0x430")]
	internal static readonly BindingId reorderModeProperty;

	[Token(Token = "0x400023C")]
	[FieldOffset(Offset = "0x4C8")]
	internal static readonly BindingId makeNoneElementProperty;

	[Token(Token = "0x400023D")]
	[FieldOffset(Offset = "0x560")]
	internal static readonly BindingId allowAddProperty;

	[Token(Token = "0x400023E")]
	[FieldOffset(Offset = "0x5F8")]
	internal static readonly BindingId overridingAddButtonBehaviorProperty;

	[Token(Token = "0x400023F")]
	[FieldOffset(Offset = "0x690")]
	internal static readonly BindingId onAddProperty;

	[Token(Token = "0x4000240")]
	[FieldOffset(Offset = "0x728")]
	internal static readonly BindingId allowRemoveProperty;

	[Token(Token = "0x4000241")]
	[FieldOffset(Offset = "0x7C0")]
	internal static readonly BindingId onRemoveProperty;

	[Token(Token = "0x4000242")]
	[FieldOffset(Offset = "0x5A0")]
	private bool m_ShowBoundCollectionSize;

	[Token(Token = "0x4000243")]
	[FieldOffset(Offset = "0x5A1")]
	private bool m_ShowFoldoutHeader;

	[Token(Token = "0x4000244")]
	[FieldOffset(Offset = "0x5A8")]
	private string m_HeaderTitle;

	[Token(Token = "0x4000245")]
	[FieldOffset(Offset = "0x5B0")]
	private VisualElement drawnHeader;

	[Token(Token = "0x4000246")]
	[FieldOffset(Offset = "0x5B8")]
	private Func<VisualElement> m_MakeHeader;

	[Token(Token = "0x4000247")]
	[FieldOffset(Offset = "0x5C0")]
	private VisualElement drawnFooter;

	[Token(Token = "0x4000248")]
	[FieldOffset(Offset = "0x5C8")]
	private Func<VisualElement> m_MakeFooter;

	[Token(Token = "0x4000249")]
	[FieldOffset(Offset = "0x5D0")]
	private bool m_ShowAddRemoveFooter;

	[Token(Token = "0x400024A")]
	[FieldOffset(Offset = "0x5D8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<int>> itemsAdded;

	[Token(Token = "0x400024B")]
	[FieldOffset(Offset = "0x5E0")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<IEnumerable<int>> itemsRemoved;

	[Token(Token = "0x400024C")]
	[FieldOffset(Offset = "0x5E8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action itemsSourceSizeChanged;

	[Token(Token = "0x400024D")]
	[FieldOffset(Offset = "0x5F0")]
	private IVisualElementScheduledItem m_TrackedItem;

	[Token(Token = "0x400024E")]
	[FieldOffset(Offset = "0x5F8")]
	private Action m_TrackCount;

	[Token(Token = "0x400024F")]
	[FieldOffset(Offset = "0x600")]
	private Func<bool> m_WhileAutoAssign;

	[Token(Token = "0x4000250")]
	[FieldOffset(Offset = "0x608")]
	private BindingSourceSelectionMode m_BindingSourceSelectionMode;

	[Token(Token = "0x4000251")]
	[FieldOffset(Offset = "0x610")]
	private Label m_ListViewLabel;

	[Token(Token = "0x4000252")]
	[FieldOffset(Offset = "0x618")]
	private Foldout m_Foldout;

	[Token(Token = "0x4000253")]
	[FieldOffset(Offset = "0x620")]
	private TextField m_ArraySizeField;

	[Token(Token = "0x4000254")]
	[FieldOffset(Offset = "0x628")]
	private bool m_IsOverMultiEditLimit;

	[Token(Token = "0x4000255")]
	[FieldOffset(Offset = "0x630")]
	private VisualElement m_Footer;

	[Token(Token = "0x4000256")]
	[FieldOffset(Offset = "0x638")]
	private Button m_AddButton;

	[Token(Token = "0x4000257")]
	[FieldOffset(Offset = "0x640")]
	private Button m_RemoveButton;

	[Token(Token = "0x4000258")]
	[FieldOffset(Offset = "0x648")]
	private Action<IEnumerable<int>> m_ItemAddedCallback;

	[Token(Token = "0x4000259")]
	[FieldOffset(Offset = "0x650")]
	private Action<IEnumerable<int>> m_ItemRemovedCallback;

	[Token(Token = "0x400025A")]
	[FieldOffset(Offset = "0x658")]
	private Action m_ItemsSourceSizeChangedCallback;

	[Token(Token = "0x400025B")]
	[FieldOffset(Offset = "0x660")]
	private ListViewReorderMode m_ReorderMode;

	[Token(Token = "0x400025D")]
	[FieldOffset(Offset = "0x670")]
	private VisualElement m_NoneElement;

	[Token(Token = "0x400025E")]
	[FieldOffset(Offset = "0x678")]
	private Func<VisualElement> m_MakeNoneElement;

	[Token(Token = "0x400025F")]
	[FieldOffset(Offset = "0x680")]
	private bool m_AllowAdd;

	[Token(Token = "0x4000260")]
	[FieldOffset(Offset = "0x688")]
	private Action<BaseListView, Button> m_OverridingAddButtonBehavior;

	[Token(Token = "0x4000261")]
	[FieldOffset(Offset = "0x690")]
	private Action<BaseListView> m_OnAdd;

	[Token(Token = "0x4000262")]
	[FieldOffset(Offset = "0x698")]
	private bool m_AllowRemove;

	[Token(Token = "0x4000263")]
	[FieldOffset(Offset = "0x6A0")]
	private Action<BaseListView> m_OnRemove;

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0x858")]
	public new static readonly string ussClassName;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0x860")]
	public new static readonly string itemUssClassName;

	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0x868")]
	public static readonly string emptyLabelUssClassName;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0x870")]
	public static readonly string overMaxMultiEditLimitClassName;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0x878")]
	public static readonly string reorderableUssClassName;

	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0x880")]
	public static readonly string reorderableItemUssClassName;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0x888")]
	public static readonly string reorderableItemContainerUssClassName;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0x890")]
	public static readonly string reorderableItemHandleUssClassName;

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0x898")]
	public static readonly string reorderableItemHandleBarUssClassName;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x8A0")]
	public static readonly string footerUssClassName;

	[Token(Token = "0x400026E")]
	[FieldOffset(Offset = "0x8A8")]
	public static readonly string foldoutHeaderUssClassName;

	[Token(Token = "0x400026F")]
	[FieldOffset(Offset = "0x8B0")]
	public static readonly string arraySizeFieldUssClassName;

	[Token(Token = "0x4000270")]
	[FieldOffset(Offset = "0x8B8")]
	public static readonly string arraySizeFieldWithHeaderUssClassName;

	[Token(Token = "0x4000271")]
	[FieldOffset(Offset = "0x8C0")]
	public static readonly string arraySizeFieldWithFooterUssClassName;

	[Token(Token = "0x4000272")]
	[FieldOffset(Offset = "0x8C8")]
	public static readonly string listViewWithHeaderUssClassName;

	[Token(Token = "0x4000273")]
	[FieldOffset(Offset = "0x8D0")]
	public static readonly string listViewWithFooterUssClassName;

	[Token(Token = "0x4000274")]
	[FieldOffset(Offset = "0x8D8")]
	public static readonly string scrollViewWithFooterUssClassName;

	[Token(Token = "0x4000275")]
	[FieldOffset(Offset = "0x8E0")]
	public static readonly string footerAddButtonName;

	[Token(Token = "0x4000276")]
	[FieldOffset(Offset = "0x8E8")]
	public static readonly string footerRemoveButtonName;

	[Token(Token = "0x4000277")]
	[FieldOffset(Offset = "0x6A8")]
	private string m_MaxMultiEditStr;

	[Token(Token = "0x4000278")]
	[FieldOffset(Offset = "0x8F0")]
	private static readonly string k_EmptyListStr;

	[Token(Token = "0x1700008E")]
	[CreateProperty]
	public bool showBoundCollectionSize
	{
		[Token(Token = "0x6000420")]
		[Address(RVA = "0x29A0C40", Offset = "0x299FE40", VA = "0x1829A0C40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000421")]
		[Address(RVA = "0x29A1D70", Offset = "0x29A0F70", VA = "0x1829A1D70")]
		set
		{
		}
	}

	[Token(Token = "0x1700008F")]
	[CreateProperty]
	public bool showFoldoutHeader
	{
		[Token(Token = "0x6000422")]
		[Address(RVA = "0x29A0C50", Offset = "0x299FE50", VA = "0x1829A0C50")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000423")]
		[Address(RVA = "0x29A1E00", Offset = "0x29A1000", VA = "0x1829A1E00")]
		set
		{
		}
	}

	[Token(Token = "0x17000090")]
	[CreateProperty]
	public string headerTitle
	{
		[Token(Token = "0x6000427")]
		[Address(RVA = "0x29A0BB0", Offset = "0x299FDB0", VA = "0x1829A0BB0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000428")]
		[Address(RVA = "0x29A12D0", Offset = "0x29A04D0", VA = "0x1829A12D0")]
		set
		{
		}
	}

	[Token(Token = "0x17000091")]
	[CreateProperty]
	public Func<VisualElement> makeHeader
	{
		[Token(Token = "0x6000429")]
		[Address(RVA = "0x29A0BD0", Offset = "0x299FDD0", VA = "0x1829A0BD0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600042A")]
		[Address(RVA = "0x29A15F0", Offset = "0x29A07F0", VA = "0x1829A15F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000092")]
	[CreateProperty]
	public Func<VisualElement> makeFooter
	{
		[Token(Token = "0x600042B")]
		[Address(RVA = "0x29A0BC0", Offset = "0x299FDC0", VA = "0x1829A0BC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600042C")]
		[Address(RVA = "0x29A13A0", Offset = "0x29A05A0", VA = "0x1829A13A0")]
		set
		{
		}
	}

	[Token(Token = "0x17000093")]
	[CreateProperty]
	public bool showAddRemoveFooter
	{
		[Token(Token = "0x600042D")]
		[Address(RVA = "0x29A0C30", Offset = "0x299FE30", VA = "0x1829A0C30")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600042E")]
		[Address(RVA = "0x29A1C60", Offset = "0x29A0E60", VA = "0x1829A1C60")]
		set
		{
		}
	}

	[Token(Token = "0x17000094")]
	private IVisualElementScheduledItem trackItemCount
	{
		[Token(Token = "0x6000430")]
		[Address(RVA = "0x29A0CF0", Offset = "0x299FEF0", VA = "0x1829A0CF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000095")]
	private Action trackCount
	{
		[Token(Token = "0x6000431")]
		[Address(RVA = "0x29A0C60", Offset = "0x299FE60", VA = "0x1829A0C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000096")]
	private Func<bool> untilManualBindingSourceSelectionMode
	{
		[Token(Token = "0x6000432")]
		[Address(RVA = "0x29A0F00", Offset = "0x29A0100", VA = "0x1829A0F00")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000097")]
	[CreateProperty]
	public BindingSourceSelectionMode bindingSourceSelectionMode
	{
		[Token(Token = "0x6000433")]
		[Address(RVA = "0x29A0B90", Offset = "0x299FD90", VA = "0x1829A0B90")]
		get
		{
			return default(BindingSourceSelectionMode);
		}
		[Token(Token = "0x6000434")]
		[Address(RVA = "0x29A1200", Offset = "0x29A0400", VA = "0x1829A1200")]
		set
		{
		}
	}

	[Token(Token = "0x17000098")]
	internal bool autoAssignSource
	{
		[Token(Token = "0x6000435")]
		[Address(RVA = "0x29A0B80", Offset = "0x299FD80", VA = "0x1829A0B80")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000099")]
	internal VisualElement footer
	{
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x29A0BA0", Offset = "0x299FDA0", VA = "0x1829A0BA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009A")]
	public new BaseListViewController viewController
	{
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x29A0F90", Offset = "0x29A0190", VA = "0x1829A0F90")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700009B")]
	[CreateProperty]
	public ListViewReorderMode reorderMode
	{
		[Token(Token = "0x6000446")]
		[Address(RVA = "0x29A0C20", Offset = "0x299FE20", VA = "0x1829A0C20")]
		get
		{
			return default(ListViewReorderMode);
		}
		[Token(Token = "0x6000447")]
		[Address(RVA = "0x29A1BA0", Offset = "0x29A0DA0", VA = "0x1829A1BA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700009C")]
	[CreateProperty]
	public Func<VisualElement> makeNoneElement
	{
		[Token(Token = "0x6000448")]
		[Address(RVA = "0x29A0BE0", Offset = "0x299FDE0", VA = "0x1829A0BE0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000449")]
		[Address(RVA = "0x29A18B0", Offset = "0x29A0AB0", VA = "0x1829A18B0")]
		set
		{
		}
	}

	[Token(Token = "0x1700009D")]
	[CreateProperty]
	public bool allowAdd
	{
		[Token(Token = "0x600044A")]
		[Address(RVA = "0x29A0B60", Offset = "0x299FD60", VA = "0x1829A0B60")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600044B")]
		[Address(RVA = "0x29A10C0", Offset = "0x29A02C0", VA = "0x1829A10C0")]
		set
		{
		}
	}

	[Token(Token = "0x1700009E")]
	[CreateProperty]
	public Action<BaseListView, Button> overridingAddButtonBehavior
	{
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x29A0C10", Offset = "0x299FE10", VA = "0x1829A0C10")]
		get
		{
			return null;
		}
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x29A1AF0", Offset = "0x29A0CF0", VA = "0x1829A1AF0")]
		set
		{
		}
	}

	[Token(Token = "0x1700009F")]
	[CreateProperty]
	public Action<BaseListView> onAdd
	{
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x29A0BF0", Offset = "0x299FDF0", VA = "0x1829A0BF0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600044F")]
		[Address(RVA = "0x29A1990", Offset = "0x29A0B90", VA = "0x1829A1990")]
		set
		{
		}
	}

	[Token(Token = "0x170000A0")]
	[CreateProperty]
	public bool allowRemove
	{
		[Token(Token = "0x6000450")]
		[Address(RVA = "0x29A0B70", Offset = "0x299FD70", VA = "0x1829A0B70")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000451")]
		[Address(RVA = "0x29A1160", Offset = "0x29A0360", VA = "0x1829A1160")]
		set
		{
		}
	}

	[Token(Token = "0x170000A1")]
	[CreateProperty]
	public Action<BaseListView> onRemove
	{
		[Token(Token = "0x6000452")]
		[Address(RVA = "0x29A0C00", Offset = "0x299FE00", VA = "0x1829A0C00")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000453")]
		[Address(RVA = "0x29A1A40", Offset = "0x29A0C40", VA = "0x1829A1A40")]
		set
		{
		}
	}

	[Token(Token = "0x14000010")]
	internal event Action reorderModeChanged
	{
		[Token(Token = "0x6000444")]
		[Address(RVA = "0x29A0AB0", Offset = "0x299FCB0", VA = "0x1829A0AB0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000445")]
		[Address(RVA = "0x29A1010", Offset = "0x29A0210", VA = "0x1829A1010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000424")]
	[Address(RVA = "0x299D0D0", Offset = "0x299C2D0", VA = "0x18299D0D0")]
	private void AddFoldout()
	{
	}

	[Token(Token = "0x6000425")]
	[Address(RVA = "0x299E600", Offset = "0x299D800", VA = "0x18299E600")]
	private void RemoveFoldout()
	{
	}

	[Token(Token = "0x6000426")]
	[Address(RVA = "0x299EB30", Offset = "0x299DD30", VA = "0x18299EB30")]
	internal void SetupArraySizeField()
	{
	}

	[Token(Token = "0x600042F")]
	[Address(RVA = "0x299D490", Offset = "0x299C690", VA = "0x18299D490")]
	private void EnableFooter(bool enabled)
	{
	}

	[Token(Token = "0x6000436")]
	[Address(RVA = "0x299D2C0", Offset = "0x299C4C0", VA = "0x18299D2C0")]
	private void AddItems(int itemCount)
	{
	}

	[Token(Token = "0x6000437")]
	[Address(RVA = "0x299E100", Offset = "0x299D300", VA = "0x18299E100")]
	private void OnArraySizeFieldChanged(ChangeEvent<string> evt)
	{
	}

	[Token(Token = "0x6000438")]
	[Address(RVA = "0x299EF90", Offset = "0x299E190", VA = "0x18299EF90")]
	internal void UpdateArraySizeField()
	{
	}

	[Token(Token = "0x6000439")]
	[Address(RVA = "0x299F080", Offset = "0x299E280", VA = "0x18299F080")]
	internal void UpdateListViewLabel()
	{
	}

	[Token(Token = "0x600043A")]
	[Address(RVA = "0x299DC30", Offset = "0x299CE30", VA = "0x18299DC30")]
	private void OnAddClicked()
	{
	}

	[Token(Token = "0x600043B")]
	[Address(RVA = "0x299DFE0", Offset = "0x299D1E0", VA = "0x18299DFE0")]
	private void OnAfterAddClicked(int itemsCountPreCallback)
	{
	}

	[Token(Token = "0x600043C")]
	[Address(RVA = "0x299E410", Offset = "0x299D610", VA = "0x18299E410")]
	private void OnRemoveClicked()
	{
	}

	[Token(Token = "0x600043F")]
	[Address(RVA = "0x299D450", Offset = "0x299C650", VA = "0x18299D450", Slot = "141")]
	private protected override void CreateVirtualizationController()
	{
	}

	[Token(Token = "0x6000440")]
	[Address(RVA = "0x299E660", Offset = "0x299D860", VA = "0x18299E660", Slot = "143")]
	public override void SetViewController(CollectionViewController controller)
	{
	}

	[Token(Token = "0x6000441")]
	[Address(RVA = "0x299E350", Offset = "0x299D550", VA = "0x18299E350")]
	private void OnItemAdded(IEnumerable<int> indices)
	{
	}

	[Token(Token = "0x6000442")]
	[Address(RVA = "0x299E370", Offset = "0x299D570", VA = "0x18299E370")]
	private void OnItemsRemoved(IEnumerable<int> indices)
	{
	}

	[Token(Token = "0x6000443")]
	[Address(RVA = "0x299E390", Offset = "0x299D590", VA = "0x18299E390")]
	private void OnItemsSourceSizeChanged()
	{
	}

	[Token(Token = "0x6000454")]
	[Address(RVA = "0x299D3B0", Offset = "0x299C5B0", VA = "0x18299D3B0", Slot = "144")]
	internal override ListViewDragger CreateDragger()
	{
		return null;
	}

	[Token(Token = "0x6000455")]
	[Address(RVA = "0x299D350", Offset = "0x299C550", VA = "0x18299D350", Slot = "145")]
	internal override ICollectionDragAndDropController CreateDragAndDropController()
	{
		return null;
	}

	[Token(Token = "0x6000456")]
	[Address(RVA = "0x29A0700", Offset = "0x299F900", VA = "0x1829A0700")]
	public BaseListView()
	{
	}

	[Token(Token = "0x6000457")]
	[Address(RVA = "0x29A08D0", Offset = "0x299FAD0", VA = "0x1829A08D0")]
	public BaseListView(IList itemsSource, float itemHeight = -1f)
	{
	}

	[Token(Token = "0x6000458")]
	[Address(RVA = "0x299E5D0", Offset = "0x299D7D0", VA = "0x18299E5D0", Slot = "147")]
	private protected override void PostRefresh()
	{
	}

	[Token(Token = "0x6000459")]
	[Address(RVA = "0x299D900", Offset = "0x299CB00", VA = "0x18299D900", Slot = "148")]
	private protected override bool HandleItemNavigation(bool moveIn, bool altPressed)
	{
		return default(bool);
	}
}
