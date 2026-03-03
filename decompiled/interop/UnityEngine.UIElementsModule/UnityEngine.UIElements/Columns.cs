using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x200010E")]
[UxmlObject]
public class Columns : ICollection<Column>, IEnumerable<Column>, IEnumerable, INotifyBindablePropertyChanged
{
	[Token(Token = "0x200010F")]
	public enum StretchMode
	{
		[Token(Token = "0x400056A")]
		Grow,
		[Token(Token = "0x400056B")]
		GrowAndFill
	}

	[Token(Token = "0x2000110")]
	[Obsolete("UxmlObjectFactory<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory<T> : UxmlObjectFactory<T, UxmlObjectTraits<T>> where T : Columns, new()
	{
		[Token(Token = "0x60008A4")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000111")]
	[Obsolete("UxmlObjectFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectFactory : UxmlObjectFactory<Columns>
	{
		[Token(Token = "0x60008A5")]
		[Address(RVA = "0x2AD8C90", Offset = "0x2AD7E90", VA = "0x182AD8C90")]
		public UxmlObjectFactory()
		{
		}
	}

	[Token(Token = "0x2000112")]
	[Obsolete("UxmlObjectTraits<T> is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	internal class UxmlObjectTraits<T> : UnityEngine.UIElements.UxmlObjectTraits<T> where T : Columns
	{
		[Token(Token = "0x400056C")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlStringAttributeDescription m_PrimaryColumnName;

		[Token(Token = "0x400056D")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlEnumAttributeDescription<StretchMode> m_StretchMode;

		[Token(Token = "0x400056E")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlBoolAttributeDescription m_Reorderable;

		[Token(Token = "0x400056F")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlBoolAttributeDescription m_Resizable;

		[Token(Token = "0x4000570")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlBoolAttributeDescription m_ResizePreview;

		[Token(Token = "0x4000571")]
		[FieldOffset(Offset = "0x0")]
		private readonly UxmlObjectListAttributeDescription<Column> m_Columns;

		[Token(Token = "0x60008A6")]
		public override void Init(ref T obj, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60008A7")]
		public UxmlObjectTraits()
		{
		}
	}

	[Token(Token = "0x4000554")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BindingId primaryColumnNameProperty;

	[Token(Token = "0x4000555")]
	[FieldOffset(Offset = "0x98")]
	private static readonly BindingId reorderableProperty;

	[Token(Token = "0x4000556")]
	[FieldOffset(Offset = "0x130")]
	private static readonly BindingId resizableProperty;

	[Token(Token = "0x4000557")]
	[FieldOffset(Offset = "0x1C8")]
	private static readonly BindingId resizePreviewProperty;

	[Token(Token = "0x4000558")]
	[FieldOffset(Offset = "0x260")]
	private static readonly BindingId stretchModeProperty;

	[Token(Token = "0x4000559")]
	[FieldOffset(Offset = "0x10")]
	private IList<Column> m_Columns;

	[Token(Token = "0x400055A")]
	[FieldOffset(Offset = "0x18")]
	private List<Column> m_DisplayColumns;

	[Token(Token = "0x400055B")]
	[FieldOffset(Offset = "0x20")]
	private List<Column> m_VisibleColumns;

	[Token(Token = "0x400055C")]
	[FieldOffset(Offset = "0x28")]
	private bool m_VisibleColumnsDirty;

	[Token(Token = "0x400055D")]
	[FieldOffset(Offset = "0x2C")]
	private StretchMode m_StretchMode;

	[Token(Token = "0x400055E")]
	[FieldOffset(Offset = "0x30")]
	private bool m_Reorderable;

	[Token(Token = "0x400055F")]
	[FieldOffset(Offset = "0x31")]
	private bool m_Resizable;

	[Token(Token = "0x4000560")]
	[FieldOffset(Offset = "0x32")]
	private bool m_ResizePreview;

	[Token(Token = "0x4000561")]
	[FieldOffset(Offset = "0x38")]
	private string m_PrimaryColumnName;

	[Token(Token = "0x1700016D")]
	[CreateProperty]
	public string primaryColumnName
	{
		[Token(Token = "0x6000872")]
		[Address(RVA = "0x404860", Offset = "0x403A60", VA = "0x180404860")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000873")]
		[Address(RVA = "0x2AC6AA0", Offset = "0x2AC5CA0", VA = "0x182AC6AA0")]
		set
		{
		}
	}

	[Token(Token = "0x1700016E")]
	[CreateProperty]
	public bool reorderable
	{
		[Token(Token = "0x6000874")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000875")]
		[Address(RVA = "0x2AC6B50", Offset = "0x2AC5D50", VA = "0x182AC6B50")]
		set
		{
		}
	}

	[Token(Token = "0x1700016F")]
	[CreateProperty]
	public bool resizable
	{
		[Token(Token = "0x6000876")]
		[Address(RVA = "0x5F07F0", Offset = "0x5EF9F0", VA = "0x1805F07F0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000877")]
		[Address(RVA = "0x2AC6BF0", Offset = "0x2AC5DF0", VA = "0x182AC6BF0")]
		set
		{
		}
	}

	[Token(Token = "0x17000170")]
	[CreateProperty]
	public bool resizePreview
	{
		[Token(Token = "0x6000878")]
		[Address(RVA = "0x5F0800", Offset = "0x5EFA00", VA = "0x1805F0800")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6000879")]
		[Address(RVA = "0x2AC6C90", Offset = "0x2AC5E90", VA = "0x182AC6C90")]
		set
		{
		}
	}

	[Token(Token = "0x17000171")]
	internal IEnumerable<Column> displayList
	{
		[Token(Token = "0x600087A")]
		[Address(RVA = "0x2AC6590", Offset = "0x2AC5790", VA = "0x182AC6590")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000172")]
	internal IEnumerable<Column> visibleList
	{
		[Token(Token = "0x600087B")]
		[Address(RVA = "0x2AC65B0", Offset = "0x2AC57B0", VA = "0x182AC65B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000173")]
	[CreateProperty]
	public StretchMode stretchMode
	{
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x6333B0", Offset = "0x6325B0", VA = "0x1806333B0")]
		get
		{
			return default(StretchMode);
		}
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x2AC6D30", Offset = "0x2AC5F30", VA = "0x182AC6D30")]
		set
		{
		}
	}

	[Token(Token = "0x17000174")]
	public int Count
	{
		[Token(Token = "0x6000896")]
		[Address(RVA = "0x2AC6310", Offset = "0x2AC5510", VA = "0x182AC6310", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000175")]
	public bool IsReadOnly
	{
		[Token(Token = "0x6000897")]
		[Address(RVA = "0x2AC6360", Offset = "0x2AC5560", VA = "0x182AC6360", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000176")]
	public Column this[int index]
	{
		[Token(Token = "0x600089A")]
		[Address(RVA = "0x2AC63B0", Offset = "0x2AC55B0", VA = "0x182AC63B0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000177")]
	public Column this[string name]
	{
		[Token(Token = "0x600089B")]
		[Address(RVA = "0x2AC6410", Offset = "0x2AC5610", VA = "0x182AC6410")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x14000018")]
	public event EventHandler<BindablePropertyChangedEventArgs> propertyChanged
	{
		[Token(Token = "0x6000870")]
		[Address(RVA = "0x2AC6260", Offset = "0x2AC5460", VA = "0x182AC6260", Slot = "13")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000871")]
		[Address(RVA = "0x2AC69F0", Offset = "0x2AC5BF0", VA = "0x182AC69F0", Slot = "14")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000019")]
	internal event Action<ColumnsDataType> changed
	{
		[Token(Token = "0x600087C")]
		[Address(RVA = "0x2AC5E40", Offset = "0x2AC5040", VA = "0x182AC5E40")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x2AC65D0", Offset = "0x2AC57D0", VA = "0x182AC65D0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001A")]
	internal event Action<Column, int> columnAdded
	{
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x2AC5EF0", Offset = "0x2AC50F0", VA = "0x182AC5EF0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x2AC6680", Offset = "0x2AC5880", VA = "0x182AC6680")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001B")]
	internal event Action<Column> columnRemoved
	{
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x2AC6050", Offset = "0x2AC5250", VA = "0x182AC6050")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000883")]
		[Address(RVA = "0x2AC67E0", Offset = "0x2AC59E0", VA = "0x182AC67E0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001C")]
	internal event Action<Column, ColumnDataType> columnChanged
	{
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x2AC5FA0", Offset = "0x2AC51A0", VA = "0x182AC5FA0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x2AC6730", Offset = "0x2AC5930", VA = "0x182AC6730")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001D")]
	internal event Action<Column> columnResized
	{
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x2AC61B0", Offset = "0x2AC53B0", VA = "0x182AC61B0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x2AC6940", Offset = "0x2AC5B40", VA = "0x182AC6940")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x1400001E")]
	internal event Action<Column, int, int> columnReordered
	{
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x2AC6100", Offset = "0x2AC5300", VA = "0x182AC6100")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x2AC6890", Offset = "0x2AC5A90", VA = "0x182AC6890")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600088A")]
	[Address(RVA = "0x2AC4F00", Offset = "0x2AC4100", VA = "0x182AC4F00")]
	public bool IsPrimary(Column column)
	{
		return default(bool);
	}

	[Token(Token = "0x600088B")]
	[Address(RVA = "0x2AC4A50", Offset = "0x2AC3C50", VA = "0x182AC4A50", Slot = "11")]
	public IEnumerator<Column> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600088C")]
	[Address(RVA = "0x2AC4A50", Offset = "0x2AC3C50", VA = "0x182AC4A50", Slot = "12")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600088D")]
	[Address(RVA = "0x2AC44B0", Offset = "0x2AC36B0", VA = "0x182AC44B0", Slot = "6")]
	public void Add(Column item)
	{
	}

	[Token(Token = "0x600088E")]
	[Address(RVA = "0x2AC4520", Offset = "0x2AC3720", VA = "0x182AC4520", Slot = "7")]
	public void Clear()
	{
	}

	[Token(Token = "0x600088F")]
	[Address(RVA = "0x2AC48C0", Offset = "0x2AC3AC0", VA = "0x182AC48C0", Slot = "8")]
	public bool Contains(Column item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000890")]
	[Address(RVA = "0x2AC4740", Offset = "0x2AC3940", VA = "0x182AC4740")]
	public bool Contains(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6000891")]
	[Address(RVA = "0x2AC4920", Offset = "0x2AC3B20", VA = "0x182AC4920", Slot = "9")]
	public void CopyTo(Column[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000892")]
	[Address(RVA = "0x2AC53A0", Offset = "0x2AC45A0", VA = "0x182AC53A0", Slot = "10")]
	public bool Remove(Column column)
	{
		return default(bool);
	}

	[Token(Token = "0x6000893")]
	[Address(RVA = "0x2AC5150", Offset = "0x2AC4350", VA = "0x182AC5150")]
	private void OnColumnsPropertyChanged(object sender, BindablePropertyChangedEventArgs args)
	{
	}

	[Token(Token = "0x6000894")]
	[Address(RVA = "0x2AC5090", Offset = "0x2AC4290", VA = "0x182AC5090")]
	private void OnColumnChanged(Column column, ColumnDataType type)
	{
	}

	[Token(Token = "0x6000895")]
	[Address(RVA = "0x2AC5130", Offset = "0x2AC4330", VA = "0x182AC5130")]
	private void OnColumnResized(Column column)
	{
	}

	[Token(Token = "0x6000898")]
	[Address(RVA = "0x2AC4AA0", Offset = "0x2AC3CA0", VA = "0x182AC4AA0")]
	public int IndexOf(Column column)
	{
		return default(int);
	}

	[Token(Token = "0x6000899")]
	[Address(RVA = "0x2AC4B80", Offset = "0x2AC3D80", VA = "0x182AC4B80")]
	public void Insert(int index, Column column)
	{
	}

	[Token(Token = "0x600089C")]
	[Address(RVA = "0x2AC5650", Offset = "0x2AC4850", VA = "0x182AC5650")]
	public void ReorderDisplay(int from, int to)
	{
	}

	[Token(Token = "0x600089D")]
	[Address(RVA = "0x2AC4B00", Offset = "0x2AC3D00", VA = "0x182AC4B00")]
	private void InitOrderColumns()
	{
	}

	[Token(Token = "0x600089E")]
	[Address(RVA = "0x2AC49F0", Offset = "0x2AC3BF0", VA = "0x182AC49F0")]
	private void DirtyVisibleColumns()
	{
	}

	[Token(Token = "0x600089F")]
	[Address(RVA = "0x2AC5790", Offset = "0x2AC4990", VA = "0x182AC5790")]
	private void UpdateVisibleColumns()
	{
	}

	[Token(Token = "0x60008A0")]
	[Address(RVA = "0x2AC4F80", Offset = "0x2AC4180", VA = "0x182AC4F80")]
	private void NotifyChange(ColumnsDataType type)
	{
	}

	[Token(Token = "0x60008A1")]
	[Address(RVA = "0x2AC4FA0", Offset = "0x2AC41A0", VA = "0x182AC4FA0")]
	private void NotifyPropertyChanged(in BindingId property)
	{
	}

	[Token(Token = "0x60008A2")]
	[Address(RVA = "0x2AC5DB0", Offset = "0x2AC4FB0", VA = "0x182AC5DB0")]
	public Columns()
	{
	}
}
