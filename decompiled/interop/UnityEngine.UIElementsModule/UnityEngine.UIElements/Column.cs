using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000104")]
[UxmlObject]
public class Column : INotifyBindablePropertyChanged
{
	[Token(Token = "0x2000105")]
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : Column, new()
	{
		[Token(Token = "0x6000839")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000106")]
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory : UxmlObjectFactory<Column>
	{
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x2AD8CD0", Offset = "0x2AD7ED0", VA = "0x182AD8CD0")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000107")]
	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Column
	{
		[Token(Token = "0x4000525")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_Name;

		[Token(Token = "0x4000526")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_Text;

		[Token(Token = "0x4000527")]
		[FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_Visible;

		[Token(Token = "0x4000528")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_Width;

		[Token(Token = "0x4000529")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_MinWidth;

		[Token(Token = "0x400052A")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_MaxWidth;

		[Token(Token = "0x400052B")]
		[FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_Stretch;

		[Token(Token = "0x400052C")]
		[FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_Sortable;

		[Token(Token = "0x400052D")]
		[FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_Optional;

		[Token(Token = "0x400052E")]
		[FieldOffset(Offset = "0x0")]
		private UxmlBoolAttributeDescription m_Resizable;

		[Token(Token = "0x400052F")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_HeaderTemplateId;

		[Token(Token = "0x4000530")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_CellTemplateId;

		[Token(Token = "0x4000531")]
		[FieldOffset(Offset = "0x0")]
		private UxmlStringAttributeDescription m_BindingPath;

		[Token(Token = "0x600083B")]
		private static Length ParseLength(string str, Length defaultValue)
		{
			return default(Length);
		}

		[Token(Token = "0x600083C")]
		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x600083D")]
		public UxmlObjectTraits()
		{
		}
	}

	[Token(Token = "0x40004FC")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BindingId nameProperty;

	[Token(Token = "0x40004FD")]
	[FieldOffset(Offset = "0x98")]
	private static readonly BindingId titleProperty;

	[Token(Token = "0x40004FE")]
	[FieldOffset(Offset = "0x130")]
	private static readonly BindingId iconProperty;

	[Token(Token = "0x40004FF")]
	[FieldOffset(Offset = "0x1C8")]
	private static readonly BindingId visibleProperty;

	[Token(Token = "0x4000500")]
	[FieldOffset(Offset = "0x260")]
	private static readonly BindingId widthProperty;

	[Token(Token = "0x4000501")]
	[FieldOffset(Offset = "0x2F8")]
	private static readonly BindingId minWidthProperty;

	[Token(Token = "0x4000502")]
	[FieldOffset(Offset = "0x390")]
	private static readonly BindingId maxWidthProperty;

	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x428")]
	private static readonly BindingId sortableProperty;

	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x4C0")]
	private static readonly BindingId stretchableProperty;

	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x558")]
	private static readonly BindingId optionalProperty;

	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x5F0")]
	private static readonly BindingId resizableProperty;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x688")]
	private static readonly BindingId headerTemplateProperty;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x720")]
	private static readonly BindingId cellTemplateProperty;

	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x10")]
	private string m_Name;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x18")]
	private string m_Title;

	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x20")]
	private Background m_Icon;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x40")]
	private bool m_Visible;

	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x44")]
	private Length m_Width;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x4C")]
	private Length m_MinWidth;

	[Token(Token = "0x400050F")]
	[FieldOffset(Offset = "0x54")]
	private Length m_MaxWidth;

	[Token(Token = "0x4000510")]
	[FieldOffset(Offset = "0x5C")]
	private float m_DesiredWidth;

	[Token(Token = "0x4000511")]
	[FieldOffset(Offset = "0x60")]
	private bool m_Stretchable;

	[Token(Token = "0x4000512")]
	[FieldOffset(Offset = "0x61")]
	private bool m_Sortable;

	[Token(Token = "0x4000513")]
	[FieldOffset(Offset = "0x62")]
	private bool m_Optional;

	[Token(Token = "0x4000514")]
	[FieldOffset(Offset = "0x63")]
	private bool m_Resizable;

	[Token(Token = "0x4000515")]
	[FieldOffset(Offset = "0x68")]
	private VisualTreeAsset m_HeaderTemplate;

	[Token(Token = "0x4000516")]
	[FieldOffset(Offset = "0x70")]
	private VisualTreeAsset m_CellTemplate;

	[Token(Token = "0x4000517")]
	[FieldOffset(Offset = "0x78")]
	private Func<VisualElement> m_MakeHeader;

	[Token(Token = "0x4000518")]
	[FieldOffset(Offset = "0x80")]
	private Action<VisualElement> m_BindHeader;

	[Token(Token = "0x4000519")]
	[FieldOffset(Offset = "0x88")]
	private Action<VisualElement> m_UnbindHeader;

	[Token(Token = "0x400051A")]
	[FieldOffset(Offset = "0x90")]
	private Action<VisualElement> m_DestroyHeader;

	[Token(Token = "0x400051B")]
	[FieldOffset(Offset = "0x98")]
	private Func<VisualElement> m_MakeCell;

	[Token(Token = "0x400051C")]
	[FieldOffset(Offset = "0xA0")]
	private Action<VisualElement, int> m_BindCell;

	[Token(Token = "0x400051D")]
	[FieldOffset(Offset = "0xA8")]
	private Action<VisualElement, int> m_UnbindCellItem;

	[Token(Token = "0x1700014A")]
	[CreateProperty]
	public string name
	{
		[Token(Token = "0x6000801")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000802")]
		[Address(RVA = "0x2AC3F30", Offset = "0x2AC3130", VA = "0x182AC3F30")]
		set
		{
		}
	}

	[Token(Token = "0x1700014B")]
	[CreateProperty]
	public string title
	{
		[Token(Token = "0x6000803")]
		[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000804")]
		[Address(RVA = "0x2AC4260", Offset = "0x2AC3460", VA = "0x182AC4260")]
		set
		{
		}
	}

	[Token(Token = "0x1700014C")]
	[CreateProperty]
	public Background icon
	{
		[Token(Token = "0x6000805")]
		[Address(RVA = "0x2AC3640", Offset = "0x2AC2840", VA = "0x182AC3640")]
		get
		{
			return default(Background);
		}
		[Token(Token = "0x6000806")]
		[Address(RVA = "0x2AC3C10", Offset = "0x2AC2E10", VA = "0x182AC3C10")]
		set
		{
		}
	}

	[Token(Token = "0x1700014D")]
	public Comparison<int> comparison
	{
		[Token(Token = "0x6000807")]
		[Address(RVA = "0x49B7C0", Offset = "0x49A9C0", VA = "0x18049B7C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700014E")]
	internal int index
	{
		[Token(Token = "0x6000808")]
		[Address(RVA = "0x2AC3660", Offset = "0x2AC2860", VA = "0x182AC3660")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700014F")]
	internal int displayIndex
	{
		[Token(Token = "0x6000809")]
		[Address(RVA = "0x2AC3590", Offset = "0x2AC2790", VA = "0x182AC3590")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000150")]
	internal int visibleIndex
	{
		[Token(Token = "0x600080A")]
		[Address(RVA = "0x2AC3700", Offset = "0x2AC2900", VA = "0x182AC3700")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000151")]
	[CreateProperty]
	public bool visible
	{
		[Token(Token = "0x600080B")]
		[Address(RVA = "0x416640", Offset = "0x415840", VA = "0x180416640")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600080C")]
		[Address(RVA = "0x2AC4320", Offset = "0x2AC3520", VA = "0x182AC4320")]
		set
		{
		}
	}

	[Token(Token = "0x17000152")]
	[CreateProperty]
	public Length width
	{
		[Token(Token = "0x600080D")]
		[Address(RVA = "0x2AC37B0", Offset = "0x2AC29B0", VA = "0x182AC37B0")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x600080E")]
		[Address(RVA = "0x2AC43C0", Offset = "0x2AC35C0", VA = "0x182AC43C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000153")]
	[CreateProperty]
	public Length minWidth
	{
		[Token(Token = "0x600080F")]
		[Address(RVA = "0x2AC36F0", Offset = "0x2AC28F0", VA = "0x182AC36F0")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6000810")]
		[Address(RVA = "0x2AC3E80", Offset = "0x2AC3080", VA = "0x182AC3E80")]
		set
		{
		}
	}

	[Token(Token = "0x17000154")]
	[CreateProperty]
	public Length maxWidth
	{
		[Token(Token = "0x6000811")]
		[Address(RVA = "0x2AC36E0", Offset = "0x2AC28E0", VA = "0x182AC36E0")]
		get
		{
			return default(Length);
		}
		[Token(Token = "0x6000812")]
		[Address(RVA = "0x2AC3DD0", Offset = "0x2AC2FD0", VA = "0x182AC3DD0")]
		set
		{
		}
	}

	[Token(Token = "0x17000155")]
	internal float desiredWidth
	{
		[Token(Token = "0x6000813")]
		[Address(RVA = "0x1FEBF60", Offset = "0x1FEB160", VA = "0x181FEBF60")]
		get
		{
			return default(float);
		}
		[Token(Token = "0x6000814")]
		[Address(RVA = "0x2AC3AF0", Offset = "0x2AC2CF0", VA = "0x182AC3AF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000156")]
	[CreateProperty]
	public bool sortable
	{
		[Token(Token = "0x6000815")]
		[Address(RVA = "0xEDB2C0", Offset = "0xEDA4C0", VA = "0x180EDB2C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000816")]
		[Address(RVA = "0x2AC4120", Offset = "0x2AC3320", VA = "0x182AC4120")]
		set
		{
		}
	}

	[Token(Token = "0x17000157")]
	[CreateProperty]
	public bool stretchable
	{
		[Token(Token = "0x6000817")]
		[Address(RVA = "0x91E9C0", Offset = "0x91DBC0", VA = "0x18091E9C0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000818")]
		[Address(RVA = "0x2AC41C0", Offset = "0x2AC33C0", VA = "0x182AC41C0")]
		set
		{
		}
	}

	[Token(Token = "0x17000158")]
	[CreateProperty]
	public bool optional
	{
		[Token(Token = "0x6000819")]
		[Address(RVA = "0x416690", Offset = "0x415890", VA = "0x180416690")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600081A")]
		[Address(RVA = "0x2AC3FE0", Offset = "0x2AC31E0", VA = "0x182AC3FE0")]
		set
		{
		}
	}

	[Token(Token = "0x17000159")]
	[CreateProperty]
	public bool resizable
	{
		[Token(Token = "0x600081B")]
		[Address(RVA = "0x2184EA0", Offset = "0x21840A0", VA = "0x182184EA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600081C")]
		[Address(RVA = "0x2AC4080", Offset = "0x2AC3280", VA = "0x182AC4080")]
		set
		{
		}
	}

	[Token(Token = "0x1700015A")]
	public string bindingPath
	{
		[Token(Token = "0x600081D")]
		[Address(RVA = "0x3DAE90", Offset = "0x3DA090", VA = "0x1803DAE90")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700015B")]
	[CreateProperty]
	public VisualTreeAsset headerTemplate
	{
		[Token(Token = "0x600081E")]
		[Address(RVA = "0x49B9F0", Offset = "0x49ABF0", VA = "0x18049B9F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x600081F")]
		[Address(RVA = "0x2AC3B20", Offset = "0x2AC2D20", VA = "0x182AC3B20")]
		set
		{
		}
	}

	[Token(Token = "0x1700015C")]
	[CreateProperty]
	public VisualTreeAsset cellTemplate
	{
		[Token(Token = "0x6000820")]
		[Address(RVA = "0x449820", Offset = "0x448A20", VA = "0x180449820")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000821")]
		[Address(RVA = "0x2AC3A00", Offset = "0x2AC2C00", VA = "0x182AC3A00")]
		set
		{
		}
	}

	[Token(Token = "0x1700015D")]
	public Func<VisualElement> makeHeader
	{
		[Token(Token = "0x6000822")]
		[Address(RVA = "0x49BD10", Offset = "0x49AF10", VA = "0x18049BD10")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000823")]
		[Address(RVA = "0x2AC3D70", Offset = "0x2AC2F70", VA = "0x182AC3D70")]
		set
		{
		}
	}

	[Token(Token = "0x1700015E")]
	public Action<VisualElement> bindHeader
	{
		[Token(Token = "0x6000824")]
		[Address(RVA = "0x49B7F0", Offset = "0x49A9F0", VA = "0x18049B7F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700015F")]
	public Action<VisualElement> unbindHeader
	{
		[Token(Token = "0x6000825")]
		[Address(RVA = "0x49BEA0", Offset = "0x49B0A0", VA = "0x18049BEA0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000160")]
	public Action<VisualElement> destroyHeader
	{
		[Token(Token = "0x6000826")]
		[Address(RVA = "0x49BDC0", Offset = "0x49AFC0", VA = "0x18049BDC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000161")]
	public Func<VisualElement> makeCell
	{
		[Token(Token = "0x6000827")]
		[Address(RVA = "0x49B870", Offset = "0x49AA70", VA = "0x18049B870")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000828")]
		[Address(RVA = "0x2AC3D00", Offset = "0x2AC2F00", VA = "0x182AC3D00")]
		set
		{
		}
	}

	[Token(Token = "0x17000162")]
	public Action<VisualElement, int> bindCell
	{
		[Token(Token = "0x6000829")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000163")]
	public Action<VisualElement, int> unbindCell
	{
		[Token(Token = "0x600082A")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000164")]
	public Action<VisualElement> destroyCell
	{
		[Token(Token = "0x600082B")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000165")]
	public Columns collection
	{
		[Token(Token = "0x600082C")]
		[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600082D")]
		[Address(RVA = "0x42FFB0", Offset = "0x42F1B0", VA = "0x18042FFB0")]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[Token(Token = "0x14000014")]
	public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Token(Token = "0x60007FF")]
		[Address(RVA = "0x2AC3410", Offset = "0x2AC2610", VA = "0x182AC3410", Slot = "4")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000800")]
		[Address(RVA = "0x2AC3880", Offset = "0x2AC2A80", VA = "0x182AC3880", Slot = "5")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000015")]
	internal event Action<Column, ColumnDataType> changed
	{
		[Token(Token = "0x600082E")]
		[Address(RVA = "0x2AC3350", Offset = "0x2AC2550", VA = "0x182AC3350")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600082F")]
		[Address(RVA = "0x2AC37C0", Offset = "0x2AC29C0", VA = "0x182AC37C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000016")]
	internal event Action<Column> resized
	{
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x2AC34D0", Offset = "0x2AC26D0", VA = "0x182AC34D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x2AC3940", Offset = "0x2AC2B40", VA = "0x182AC3940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x6000832")]
	[Address(RVA = "0x2AC2770", Offset = "0x2AC1970", VA = "0x182AC2770")]
	private void NotifyChange(ColumnDataType type)
	{
	}

	[Token(Token = "0x6000833")]
	[Address(RVA = "0x2AC27A0", Offset = "0x2AC19A0", VA = "0x182AC27A0")]
	private void NotifyPropertyChanged(in BindingId property)
	{
	}

	[Token(Token = "0x6000834")]
	[Address(RVA = "0x2AC2740", Offset = "0x2AC1940", VA = "0x182AC2740")]
	internal float GetWidth(float layoutWidth)
	{
		return default(float);
	}

	[Token(Token = "0x6000835")]
	[Address(RVA = "0x2AC26E0", Offset = "0x2AC18E0", VA = "0x182AC26E0")]
	internal float GetMaxWidth(float layoutWidth)
	{
		return default(float);
	}

	[Token(Token = "0x6000836")]
	[Address(RVA = "0x2AC2710", Offset = "0x2AC1910", VA = "0x182AC2710")]
	internal float GetMinWidth(float layoutWidth)
	{
		return default(float);
	}

	[Token(Token = "0x6000837")]
	[Address(RVA = "0x2AC32E0", Offset = "0x2AC24E0", VA = "0x182AC32E0")]
	public Column()
	{
	}
}
