using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x200060A")]
internal class MultiColumnHeaderColumn : VisualElement
{
	[Token(Token = "0x4001645")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ussClassName;

	[Token(Token = "0x4001646")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string sortableUssClassName;

	[Token(Token = "0x4001647")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string sortedAscendingUssClassName;

	[Token(Token = "0x4001648")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string sortedDescendingUssClassName;

	[Token(Token = "0x4001649")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string movingUssClassName;

	[Token(Token = "0x400164A")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string contentContainerUssClassName;

	[Token(Token = "0x400164B")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string contentUssClassName;

	[Token(Token = "0x400164C")]
	[FieldOffset(Offset = "0x38")]
	public static readonly string defaultContentUssClassName;

	[Token(Token = "0x400164D")]
	[FieldOffset(Offset = "0x40")]
	public static readonly string hasIconUssClassName;

	[Token(Token = "0x400164E")]
	[FieldOffset(Offset = "0x48")]
	public static readonly string hasTitleUssClassName;

	[Token(Token = "0x400164F")]
	[FieldOffset(Offset = "0x50")]
	public static readonly string titleUssClassName;

	[Token(Token = "0x4001650")]
	[FieldOffset(Offset = "0x58")]
	public static readonly string iconElementName;

	[Token(Token = "0x4001651")]
	[FieldOffset(Offset = "0x60")]
	public static readonly string titleElementName;

	[Token(Token = "0x4001652")]
	[FieldOffset(Offset = "0x68")]
	private static readonly string s_BoundVEPropertyName;

	[Token(Token = "0x4001653")]
	[FieldOffset(Offset = "0x70")]
	private static readonly string s_BindingCallbackVEPropertyName;

	[Token(Token = "0x4001654")]
	[FieldOffset(Offset = "0x78")]
	private static readonly string s_UnbindingCallbackVEPropertyName;

	[Token(Token = "0x4001655")]
	[FieldOffset(Offset = "0x80")]
	private static readonly string s_DestroyCallbackVEPropertyName;

	[Token(Token = "0x4001656")]
	[FieldOffset(Offset = "0x4A8")]
	private VisualElement m_ContentContainer;

	[Token(Token = "0x4001657")]
	[FieldOffset(Offset = "0x4B0")]
	private VisualElement m_Content;

	[Token(Token = "0x4001658")]
	[FieldOffset(Offset = "0x4B8")]
	private MultiColumnHeaderColumnSortIndicator m_SortIndicatorContainer;

	[Token(Token = "0x4001659")]
	[FieldOffset(Offset = "0x4C0")]
	private IVisualElementScheduledItem m_ScheduledHeaderTemplateUpdate;

	[Token(Token = "0x17000AD6")]
	public Clickable clickable
	{
		[Token(Token = "0x6002A26")]
		[Address(RVA = "0x29FCCD0", Offset = "0x29FBED0", VA = "0x1829FCCD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A27")]
		[Address(RVA = "0x29FCD00", Offset = "0x29FBF00", VA = "0x1829FCD00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000AD7")]
	public ColumnMover mover
	{
		[Token(Token = "0x6002A28")]
		[Address(RVA = "0x2A9D200", Offset = "0x2A9C400", VA = "0x182A9D200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A29")]
		[Address(RVA = "0x2A9D590", Offset = "0x2A9C790", VA = "0x182A9D590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000AD8")]
	public string sortOrderLabel
	{
		[Token(Token = "0x6002A2A")]
		[Address(RVA = "0x2A9D5B0", Offset = "0x2A9C7B0", VA = "0x182A9D5B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000AD9")]
	public Column column
	{
		[Token(Token = "0x6002A2B")]
		[Address(RVA = "0x2A9D120", Offset = "0x2A9C320", VA = "0x182A9D120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A2C")]
		[Address(RVA = "0x2A9D210", Offset = "0x2A9C410", VA = "0x182A9D210")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000ADA")]
	public VisualElement content
	{
		[Token(Token = "0x6002A2D")]
		[Address(RVA = "0x2A999A0", Offset = "0x2A98BA0", VA = "0x182A999A0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002A2E")]
		[Address(RVA = "0x2A9D230", Offset = "0x2A9C430", VA = "0x182A9D230")]
		set
		{
		}
	}

	[Token(Token = "0x17000ADB")]
	private bool isContentBound
	{
		[Token(Token = "0x6002A2F")]
		[Address(RVA = "0x2A9D130", Offset = "0x2A9C330", VA = "0x182A9D130")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002A30")]
		[Address(RVA = "0x2A9D4E0", Offset = "0x2A9C6E0", VA = "0x182A9D4E0")]
		set
		{
		}
	}

	[Token(Token = "0x6002A31")]
	[Address(RVA = "0x2A9C710", Offset = "0x2A9B910", VA = "0x182A9C710")]
	public MultiColumnHeaderColumn(Column column)
	{
	}

	[Token(Token = "0x6002A32")]
	[Address(RVA = "0x2A9BA40", Offset = "0x2A9AC40", VA = "0x182A9BA40")]
	private void OnColumnChanged(Column c, ColumnDataType role)
	{
	}

	[Token(Token = "0x6002A33")]
	[Address(RVA = "0x2A9BB60", Offset = "0x2A9AD60", VA = "0x182A9BB60")]
	private void OnColumnResized(Column c)
	{
	}

	[Token(Token = "0x6002A34")]
	[Address(RVA = "0x2A9B630", Offset = "0x2A9A830", VA = "0x182A9B630")]
	private void InitManipulators()
	{
	}

	[Token(Token = "0x6002A35")]
	[Address(RVA = "0x2A9BB70", Offset = "0x2A9AD70", VA = "0x182A9BB70")]
	private void OnMoverChanged(ColumnMover mv)
	{
	}

	[Token(Token = "0x6002A36")]
	[Address(RVA = "0x2A9BD00", Offset = "0x2A9AF00", VA = "0x182A9BD00")]
	private void UpdateDataFromColumn()
	{
	}

	[Token(Token = "0x6002A37")]
	[Address(RVA = "0x2A9AB30", Offset = "0x2A99D30", VA = "0x182A9AB30")]
	private void BindHeaderContent()
	{
	}

	[Token(Token = "0x6002A38")]
	[Address(RVA = "0x2A9BC20", Offset = "0x2A9AE20", VA = "0x182A9BC20")]
	private void UnbindHeaderContent()
	{
	}

	[Token(Token = "0x6002A39")]
	[Address(RVA = "0x2A9B240", Offset = "0x2A9A440", VA = "0x182A9B240")]
	private void DestroyHeaderContent()
	{
	}

	[Token(Token = "0x6002A3A")]
	[Address(RVA = "0x2A9AC10", Offset = "0x2A99E10", VA = "0x182A9AC10")]
	private VisualElement CreateDefaultHeaderContent()
	{
		return null;
	}

	[Token(Token = "0x6002A3B")]
	[Address(RVA = "0x2A9AE90", Offset = "0x2A9A090", VA = "0x182A9AE90")]
	private void DefaultBindHeaderContent(VisualElement ve)
	{
	}

	[Token(Token = "0x6002A3C")]
	[Address(RVA = "0x2A9BF40", Offset = "0x2A9B140", VA = "0x182A9BF40")]
	private void UpdateHeaderTemplate()
	{
	}

	[Token(Token = "0x6002A3D")]
	[Address(RVA = "0x2A9BE10", Offset = "0x2A9B010", VA = "0x182A9BE10")]
	private void UpdateGeometryFromColumn()
	{
	}

	[Token(Token = "0x6002A3E")]
	[Address(RVA = "0x2A9B3F0", Offset = "0x2A9A5F0", VA = "0x182A9B3F0")]
	public void Dispose()
	{
	}
}
