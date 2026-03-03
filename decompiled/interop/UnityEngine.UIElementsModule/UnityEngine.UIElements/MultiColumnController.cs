using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.Internal;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000115")]
public class MultiColumnController : IDisposable
{
	[Token(Token = "0x4000578")]
	[FieldOffset(Offset = "0x0")]
	private static readonly PropertyName k_BoundColumnVePropertyName;

	[Token(Token = "0x4000579")]
	[FieldOffset(Offset = "0x4")]
	internal static readonly PropertyName bindableElementPropertyName;

	[Token(Token = "0x400057A")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly string baseUssClassName;

	[Token(Token = "0x400057B")]
	[FieldOffset(Offset = "0x10")]
	private static readonly string k_HeaderContainerViewDataKey;

	[Token(Token = "0x400057C")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string headerContainerUssClassName;

	[Token(Token = "0x400057D")]
	[FieldOffset(Offset = "0x20")]
	public static readonly string rowContainerUssClassName;

	[Token(Token = "0x400057E")]
	[FieldOffset(Offset = "0x28")]
	public static readonly string cellUssClassName;

	[Token(Token = "0x400057F")]
	[FieldOffset(Offset = "0x30")]
	public static readonly string cellLabelUssClassName;

	[Token(Token = "0x4000580")]
	[FieldOffset(Offset = "0x38")]
	private static readonly string k_HeaderViewDataKey;

	[Token(Token = "0x4000583")]
	[FieldOffset(Offset = "0x20")]
	private List<int> m_SortedToSourceIndex;

	[Token(Token = "0x4000584")]
	[FieldOffset(Offset = "0x28")]
	private List<int> m_SourceToSortedIndex;

	[Token(Token = "0x4000585")]
	[FieldOffset(Offset = "0x30")]
	private ColumnSortingMode m_SortingMode;

	[Token(Token = "0x4000586")]
	[FieldOffset(Offset = "0x38")]
	private BaseVerticalCollectionView m_View;

	[Token(Token = "0x4000587")]
	[FieldOffset(Offset = "0x40")]
	private VisualElement m_HeaderContainer;

	[Token(Token = "0x4000588")]
	[FieldOffset(Offset = "0x48")]
	private MultiColumnCollectionHeader m_MultiColumnHeader;

	[Token(Token = "0x17000178")]
	internal MultiColumnCollectionHeader header
	{
		[Token(Token = "0x60008AF")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000179")]
	internal ColumnSortingMode sortingMode
	{
		[Token(Token = "0x60008B0")]
		[Address(RVA = "0x49B840", Offset = "0x49AA40", VA = "0x18049B840")]
		get
		{
			return default(ColumnSortingMode);
		}
		[Token(Token = "0x60008B1")]
		[Address(RVA = "0x2AD6160", Offset = "0x2AD5360", VA = "0x182AD6160")]
		set
		{
		}
	}

	[Token(Token = "0x1400001F")]
	public event Action columnSortingChanged
	{
		[Token(Token = "0x60008AB")]
		[Address(RVA = "0x2AD5EC0", Offset = "0x2AD50C0", VA = "0x182AD5EC0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60008AC")]
		[Address(RVA = "0x2AD6010", Offset = "0x2AD5210", VA = "0x182AD6010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000020")]
	public event Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent
	{
		[Token(Token = "0x60008AD")]
		[Address(RVA = "0x2AD5F60", Offset = "0x2AD5160", VA = "0x182AD5F60")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60008AE")]
		[Address(RVA = "0x2AD60B0", Offset = "0x2AD52B0", VA = "0x182AD60B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60008B2")]
	[Address(RVA = "0x2AD5990", Offset = "0x2AD4B90", VA = "0x182AD5990")]
	public MultiColumnController(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	[Token(Token = "0x60008B3")]
	private static void BindCellItem<T>(VisualElement ve, int rowIndex, Column column, T item)
	{
	}

	[Token(Token = "0x60008B4")]
	[Address(RVA = "0x2AD5080", Offset = "0x2AD4280", VA = "0x182AD5080")]
	private static void UnbindCellItem(VisualElement ve, int rowIndex, Column column)
	{
	}

	[Token(Token = "0x60008B5")]
	[Address(RVA = "0x2AD30D0", Offset = "0x2AD22D0", VA = "0x182AD30D0")]
	private static VisualElement DefaultMakeCellItem()
	{
		return null;
	}

	[Token(Token = "0x60008B6")]
	private static void DefaultBindCellItem<T>(VisualElement ve, T item)
	{
	}

	[Token(Token = "0x60008B7")]
	[Address(RVA = "0x2AD3E20", Offset = "0x2AD3020", VA = "0x182AD3E20")]
	public VisualElement MakeItem()
	{
		return null;
	}

	[Token(Token = "0x60008B8")]
	public void BindItem<T>(VisualElement element, int index, T item)
	{
	}

	[Token(Token = "0x60008B9")]
	[Address(RVA = "0x2AD50C0", Offset = "0x2AD42C0", VA = "0x182AD50C0")]
	public void UnbindItem(VisualElement element, int index)
	{
	}

	[Token(Token = "0x60008BA")]
	[Address(RVA = "0x2AD3180", Offset = "0x2AD2380", VA = "0x182AD3180")]
	public void DestroyItem(VisualElement element)
	{
	}

	[Token(Token = "0x60008BB")]
	[Address(RVA = "0x2AD48C0", Offset = "0x2AD3AC0", VA = "0x182AD48C0")]
	public void PrepareView(BaseVerticalCollectionView collectionView)
	{
	}

	[Token(Token = "0x60008BC")]
	[Address(RVA = "0x2AD34C0", Offset = "0x2AD26C0", VA = "0x182AD34C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60008BD")]
	[Address(RVA = "0x2AD4600", Offset = "0x2AD3800", VA = "0x182AD4600")]
	private void OnHorizontalScrollerValueChanged(float v)
	{
	}

	[Token(Token = "0x60008BE")]
	[Address(RVA = "0x2AD4620", Offset = "0x2AD3820", VA = "0x182AD4620")]
	private void OnViewportGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60008BF")]
	[Address(RVA = "0x2AD41F0", Offset = "0x2AD33F0", VA = "0x182AD41F0")]
	private void OnColumnContainerGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x60008C0")]
	[Address(RVA = "0x2AD5470", Offset = "0x2AD4670", VA = "0x182AD5470")]
	private void UpdateContentContainer(BaseVerticalCollectionView collectionView)
	{
	}

	[Token(Token = "0x60008C1")]
	[Address(RVA = "0x2AD4550", Offset = "0x2AD3750", VA = "0x182AD4550")]
	private void OnColumnSortingChanged()
	{
	}

	[Token(Token = "0x60008C2")]
	[Address(RVA = "0x2AD5630", Offset = "0x2AD4830", VA = "0x182AD5630")]
	internal void UpdateDragger()
	{
	}

	[Token(Token = "0x60008C3")]
	[Address(RVA = "0x2AD4BE0", Offset = "0x2AD3DE0", VA = "0x182AD4BE0")]
	internal void SortIfNeeded()
	{
	}

	[Token(Token = "0x60008C4")]
	[Address(RVA = "0x2AD2BC0", Offset = "0x2AD1DC0", VA = "0x182AD2BC0")]
	private int CombinedComparison(int a, int b)
	{
		return default(int);
	}

	[Token(Token = "0x60008C5")]
	[Address(RVA = "0x2AD3D80", Offset = "0x2AD2F80", VA = "0x182AD3D80")]
	internal int GetSourceIndex(int sortedIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60008C6")]
	[Address(RVA = "0x2AD3CE0", Offset = "0x2AD2EE0", VA = "0x182AD3CE0")]
	internal int GetSortedIndex(int sourceIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60008C7")]
	[Address(RVA = "0x2AD3C70", Offset = "0x2AD2E70", VA = "0x182AD3C70")]
	private static int GetIndexFromList(int index, List<int> indices)
	{
		return default(int);
	}

	[Token(Token = "0x60008C8")]
	[Address(RVA = "0x2AD45E0", Offset = "0x2AD37E0", VA = "0x182AD45E0")]
	private void OnContextMenuPopulateEvent(ContextualMenuPopulateEvent evt, Column column)
	{
	}

	[Token(Token = "0x60008C9")]
	[Address(RVA = "0x2AD4240", Offset = "0x2AD3440", VA = "0x182AD4240")]
	private void OnColumnResized(int index, float width)
	{
	}

	[Token(Token = "0x60008CA")]
	[Address(RVA = "0x2AD4190", Offset = "0x2AD3390", VA = "0x182AD4190")]
	private void OnColumnAdded(Column column, int index)
	{
	}

	[Token(Token = "0x60008CB")]
	[Address(RVA = "0x2AD4190", Offset = "0x2AD3390", VA = "0x182AD4190")]
	private void OnColumnRemoved(Column column)
	{
	}

	[Token(Token = "0x60008CC")]
	[Address(RVA = "0x2AD4200", Offset = "0x2AD3400", VA = "0x182AD4200")]
	private void OnColumnReordered(Column column, int from, int to)
	{
	}

	[Token(Token = "0x60008CD")]
	[Address(RVA = "0x2AD45A0", Offset = "0x2AD37A0", VA = "0x182AD45A0")]
	private void OnColumnsChanged(Column column, ColumnDataType type)
	{
	}

	[Token(Token = "0x60008CE")]
	[Address(RVA = "0x2AD41B0", Offset = "0x2AD33B0", VA = "0x182AD41B0")]
	private void OnColumnChanged(ColumnsDataType type)
	{
	}

	[Token(Token = "0x60008CF")]
	[Address(RVA = "0x2AD4190", Offset = "0x2AD3390", VA = "0x182AD4190")]
	private void OnViewDataRestored()
	{
	}
}
