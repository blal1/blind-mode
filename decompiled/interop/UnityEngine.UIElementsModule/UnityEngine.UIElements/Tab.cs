using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200014B")]
public class Tab : VisualElement
{
	[Token(Token = "0x200014C")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<Tab, UxmlTraits>
	{
		[Token(Token = "0x6000A2C")]
		[Address(RVA = "0x2AEF7B0", Offset = "0x2AEE9B0", VA = "0x182AEF7B0")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200014D")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : VisualElement.UxmlTraits
	{
		[Token(Token = "0x40006A3")]
		[FieldOffset(Offset = "0x88")]
		private readonly UxmlStringAttributeDescription m_Label;

		[Token(Token = "0x40006A4")]
		[FieldOffset(Offset = "0x90")]
		private readonly UxmlImageAttributeDescription m_IconImage;

		[Token(Token = "0x40006A5")]
		[FieldOffset(Offset = "0x98")]
		private readonly UxmlBoolAttributeDescription m_Closeable;

		[Token(Token = "0x6000A2D")]
		[Address(RVA = "0x2AEFE20", Offset = "0x2AEF020", VA = "0x182AEFE20", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x6000A2E")]
		[Address(RVA = "0x2AF24B0", Offset = "0x2AF16B0", VA = "0x182AF24B0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000683")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly BindingId labelProperty;

	[Token(Token = "0x4000684")]
	[FieldOffset(Offset = "0x98")]
	internal static readonly BindingId iconImageProperty;

	[Token(Token = "0x4000685")]
	[FieldOffset(Offset = "0x130")]
	internal static readonly BindingId closeableProperty;

	[Token(Token = "0x4000686")]
	[FieldOffset(Offset = "0x1C8")]
	public static readonly string ussClassName;

	[Token(Token = "0x4000687")]
	[FieldOffset(Offset = "0x1D0")]
	public static readonly string tabHeaderUssClassName;

	[Token(Token = "0x4000688")]
	[FieldOffset(Offset = "0x1D8")]
	public static readonly string tabHeaderImageUssClassName;

	[Token(Token = "0x4000689")]
	[FieldOffset(Offset = "0x1E0")]
	public static readonly string tabHeaderEmptyImageUssClassName;

	[Token(Token = "0x400068A")]
	[FieldOffset(Offset = "0x1E8")]
	public static readonly string tabHeaderStandaloneImageUssClassName;

	[Token(Token = "0x400068B")]
	[FieldOffset(Offset = "0x1F0")]
	public static readonly string tabHeaderLabelUssClassName;

	[Token(Token = "0x400068C")]
	[FieldOffset(Offset = "0x1F8")]
	public static readonly string tabHeaderEmptyLabeUssClassName;

	[Token(Token = "0x400068D")]
	[FieldOffset(Offset = "0x200")]
	public static readonly string tabHeaderUnderlineUssClassName;

	[Token(Token = "0x400068E")]
	[FieldOffset(Offset = "0x208")]
	public static readonly string contentUssClassName;

	[Token(Token = "0x400068F")]
	[FieldOffset(Offset = "0x210")]
	public static readonly string draggingUssClassName;

	[Token(Token = "0x4000690")]
	[FieldOffset(Offset = "0x218")]
	public static readonly string reorderableUssClassName;

	[Token(Token = "0x4000691")]
	[FieldOffset(Offset = "0x220")]
	public static readonly string reorderableItemHandleUssClassName;

	[Token(Token = "0x4000692")]
	[FieldOffset(Offset = "0x228")]
	public static readonly string reorderableItemHandleBarUssClassName;

	[Token(Token = "0x4000693")]
	[FieldOffset(Offset = "0x230")]
	public static readonly string closeableUssClassName;

	[Token(Token = "0x4000694")]
	[FieldOffset(Offset = "0x238")]
	public static readonly string closeButtonUssClassName;

	[Token(Token = "0x4000696")]
	[FieldOffset(Offset = "0x4B0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Func<bool> closing;

	[Token(Token = "0x4000698")]
	[FieldOffset(Offset = "0x4C0")]
	private string m_Label;

	[Token(Token = "0x4000699")]
	[FieldOffset(Offset = "0x4C8")]
	private Background m_IconImage;

	[Token(Token = "0x400069A")]
	[FieldOffset(Offset = "0x4E8")]
	private bool m_Closeable;

	[Token(Token = "0x400069B")]
	[FieldOffset(Offset = "0x4F0")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x400069C")]
	[FieldOffset(Offset = "0x4F8")]
	private VisualElement m_DragHandle;

	[Token(Token = "0x400069D")]
	[FieldOffset(Offset = "0x500")]
	private VisualElement m_CloseButton;

	[Token(Token = "0x400069E")]
	[FieldOffset(Offset = "0x508")]
	private VisualElement m_TabHeader;

	[Token(Token = "0x400069F")]
	[FieldOffset(Offset = "0x510")]
	private Image m_TabHeaderImage;

	[Token(Token = "0x40006A0")]
	[FieldOffset(Offset = "0x518")]
	private Label m_TabHeaderLabel;

	[Token(Token = "0x170001B7")]
	public VisualElement tabHeader
	{
		[Token(Token = "0x6000A14")]
		[Address(RVA = "0x137AB50", Offset = "0x1379D50", VA = "0x18137AB50")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170001B8")]
	internal int index
	{
		[Token(Token = "0x6000A15")]
		[Address(RVA = "0x2AEE780", Offset = "0x2AED980", VA = "0x182AEE780")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000A16")]
		[Address(RVA = "0x2AEED80", Offset = "0x2AEDF80", VA = "0x182AEED80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x170001B9")]
	[CreateProperty]
	public string label
	{
		[Token(Token = "0x6000A17")]
		[Address(RVA = "0x2AAE730", Offset = "0x2AAD930", VA = "0x182AAE730")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000A18")]
		[Address(RVA = "0x2AEED90", Offset = "0x2AEDF90", VA = "0x182AEED90")]
		set
		{
		}
	}

	[Token(Token = "0x170001BA")]
	[CreateProperty]
	public Background iconImage
	{
		[Token(Token = "0x6000A19")]
		[Address(RVA = "0x2AEE760", Offset = "0x2AED960", VA = "0x182AEE760")]
		get
		{
			return default(Background);
		}
		[Token(Token = "0x6000A1A")]
		[Address(RVA = "0x2AEEA20", Offset = "0x2AEDC20", VA = "0x182AEEA20")]
		set
		{
		}
	}

	[Token(Token = "0x170001BB")]
	[CreateProperty]
	public bool closeable
	{
		[Token(Token = "0x6000A1B")]
		[Address(RVA = "0x23D0D80", Offset = "0x23CFF80", VA = "0x1823D0D80")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000A1C")]
		[Address(RVA = "0x2AEE910", Offset = "0x2AEDB10", VA = "0x182AEE910")]
		set
		{
		}
	}

	[Token(Token = "0x170001BC")]
	public override VisualElement contentContainer
	{
		[Token(Token = "0x6000A1D")]
		[Address(RVA = "0x23D0AC0", Offset = "0x23CFCC0", VA = "0x1823D0AC0", Slot = "136")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000025")]
	public event Action<Tab> selected
	{
		[Token(Token = "0x6000A10")]
		[Address(RVA = "0x2AEE6A0", Offset = "0x2AED8A0", VA = "0x182AEE6A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000A11")]
		[Address(RVA = "0x2AEE850", Offset = "0x2AEDA50", VA = "0x182AEE850")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000026")]
	public event Action<Tab> closed
	{
		[Token(Token = "0x6000A12")]
		[Address(RVA = "0x2AEE5E0", Offset = "0x2AED7E0", VA = "0x182AEE5E0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000A13")]
		[Address(RVA = "0x2AEE790", Offset = "0x2AED990", VA = "0x182AEE790")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000A1E")]
	[Address(RVA = "0x2AEE590", Offset = "0x2AED790", VA = "0x182AEE590")]
	public Tab()
	{
	}

	[Token(Token = "0x6000A1F")]
	[Address(RVA = "0x2AED830", Offset = "0x2AECA30", VA = "0x182AED830")]
	public Tab(string label, Background iconImage)
	{
	}

	[Token(Token = "0x6000A20")]
	[Address(RVA = "0x2AECEE0", Offset = "0x2AEC0E0", VA = "0x182AECEE0")]
	private void UpdateTooltip(TooltipEvent evt)
	{
	}

	[Token(Token = "0x6000A21")]
	[Address(RVA = "0x2AECBB0", Offset = "0x2AEBDB0", VA = "0x182AECBB0")]
	private void AddDragHandles()
	{
	}

	[Token(Token = "0x6000A22")]
	[Address(RVA = "0x2AECDC0", Offset = "0x2AEBFC0", VA = "0x182AECDC0")]
	private void RemoveDragHandles()
	{
	}

	[Token(Token = "0x6000A23")]
	[Address(RVA = "0x2AECC50", Offset = "0x2AEBE50", VA = "0x182AECC50")]
	internal void EnableTabDragHandles(bool enable)
	{
	}

	[Token(Token = "0x6000A24")]
	[Address(RVA = "0x2AECB80", Offset = "0x2AEBD80", VA = "0x182AECB80")]
	private void AddCloseButton()
	{
	}

	[Token(Token = "0x6000A25")]
	[Address(RVA = "0x2AECD60", Offset = "0x2AEBF60", VA = "0x182AECD60")]
	private void RemoveCloseButton()
	{
	}

	[Token(Token = "0x6000A26")]
	[Address(RVA = "0x2AECBE0", Offset = "0x2AEBDE0", VA = "0x182AECBE0")]
	internal void EnableTabCloseButton(bool enable)
	{
	}

	[Token(Token = "0x6000A27")]
	[Address(RVA = "0x2AECE20", Offset = "0x2AEC020", VA = "0x182AECE20")]
	internal void SetActive()
	{
	}

	[Token(Token = "0x6000A28")]
	[Address(RVA = "0x2AECE80", Offset = "0x2AEC080", VA = "0x182AECE80")]
	internal void SetInactive()
	{
	}

	[Token(Token = "0x6000A29")]
	[Address(RVA = "0x2AECD40", Offset = "0x2AEBF40", VA = "0x182AECD40")]
	private void OnTabClicked(PointerDownEvent _)
	{
	}

	[Token(Token = "0x6000A2A")]
	[Address(RVA = "0x2AECCC0", Offset = "0x2AEBEC0", VA = "0x182AECCC0")]
	private void OnCloseButtonClicked(PointerDownEvent evt)
	{
	}
}
