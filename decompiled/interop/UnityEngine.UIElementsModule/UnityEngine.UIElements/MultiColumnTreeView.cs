using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000119")]
public class MultiColumnTreeView : BaseTreeView
{
	[Token(Token = "0x200011A")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<MultiColumnTreeView, UxmlTraits>
	{
		[Token(Token = "0x60008F4")]
		[Address(RVA = "0x2AEF770", Offset = "0x2AEE970", VA = "0x182AEF770")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x200011B")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseTreeView.UxmlTraits
	{
		[Token(Token = "0x400059E")]
		[FieldOffset(Offset = "0xD0")]
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode;

		[Token(Token = "0x400059F")]
		[FieldOffset(Offset = "0xD8")]
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns;

		[Token(Token = "0x40005A0")]
		[FieldOffset(Offset = "0xE0")]
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions;

		[Token(Token = "0x60008F5")]
		[Address(RVA = "0x2AF1620", Offset = "0x2AF0820", VA = "0x182AF1620", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60008F6")]
		[Address(RVA = "0x2AF2890", Offset = "0x2AF1A90", VA = "0x182AF2890")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000595")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BindingId columnsProperty;

	[Token(Token = "0x4000596")]
	[FieldOffset(Offset = "0x98")]
	private static readonly BindingId sortColumnDescriptionsProperty;

	[Token(Token = "0x4000597")]
	[FieldOffset(Offset = "0x130")]
	private static readonly BindingId sortingModeProperty;

	[Token(Token = "0x4000598")]
	[FieldOffset(Offset = "0x5C0")]
	private Columns m_Columns;

	[Token(Token = "0x4000599")]
	[FieldOffset(Offset = "0x5C8")]
	private ColumnSortingMode m_SortingMode;

	[Token(Token = "0x400059A")]
	[FieldOffset(Offset = "0x5D0")]
	private SortColumnDescriptions m_SortColumnDescriptions;

	[Token(Token = "0x400059B")]
	[FieldOffset(Offset = "0x5D8")]
	private List<SortColumnDescription> m_SortedColumns;

	[Token(Token = "0x400059C")]
	[FieldOffset(Offset = "0x5E0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action columnSortingChanged;

	[Token(Token = "0x400059D")]
	[FieldOffset(Offset = "0x5E8")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent;

	[Token(Token = "0x1700017E")]
	public new MultiColumnTreeViewController viewController
	{
		[Token(Token = "0x60008E4")]
		[Address(RVA = "0x2ADC910", Offset = "0x2ADBB10", VA = "0x182ADC910")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700017F")]
	[CreateProperty]
	public Columns columns
	{
		[Token(Token = "0x60008E5")]
		[Address(RVA = "0x2ADC8E0", Offset = "0x2ADBAE0", VA = "0x182ADC8E0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008E6")]
		[Address(RVA = "0x2ADC990", Offset = "0x2ADBB90", VA = "0x182ADC990")]
		private set
		{
		}
	}

	[Token(Token = "0x17000180")]
	[CreateProperty]
	public SortColumnDescriptions sortColumnDescriptions
	{
		[Token(Token = "0x60008E7")]
		[Address(RVA = "0x2ADC8F0", Offset = "0x2ADBAF0", VA = "0x182ADC8F0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008E8")]
		[Address(RVA = "0x2ADCB10", Offset = "0x2ADBD10", VA = "0x182ADCB10")]
		private set
		{
		}
	}

	[Token(Token = "0x17000181")]
	[CreateProperty]
	public ColumnSortingMode sortingMode
	{
		[Token(Token = "0x60008E9")]
		[Address(RVA = "0x2ADC900", Offset = "0x2ADBB00", VA = "0x182ADC900")]
		get
		{
			return default(ColumnSortingMode);
		}
		[Token(Token = "0x60008EA")]
		[Address(RVA = "0x2ADCC30", Offset = "0x2ADBE30", VA = "0x182ADCC30")]
		set
		{
		}
	}

	[Token(Token = "0x60008EB")]
	[Address(RVA = "0x2ADC760", Offset = "0x2ADB960", VA = "0x182ADC760")]
	public MultiColumnTreeView()
	{
	}

	[Token(Token = "0x60008EC")]
	[Address(RVA = "0x2ADC610", Offset = "0x2ADB810", VA = "0x182ADC610")]
	public MultiColumnTreeView(Columns columns)
	{
	}

	[Token(Token = "0x60008ED")]
	[Address(RVA = "0x2ADC020", Offset = "0x2ADB220", VA = "0x182ADC020", Slot = "142")]
	protected override CollectionViewController CreateViewController()
	{
		return null;
	}

	[Token(Token = "0x60008EE")]
	[Address(RVA = "0x2ADC140", Offset = "0x2ADB340", VA = "0x182ADC140", Slot = "143")]
	public override void SetViewController(CollectionViewController controller)
	{
	}

	[Token(Token = "0x60008EF")]
	[Address(RVA = "0x2ADC0C0", Offset = "0x2ADB2C0", VA = "0x182ADC0C0", Slot = "141")]
	private protected override void CreateVirtualizationController()
	{
	}

	[Token(Token = "0x60008F0")]
	[Address(RVA = "0x2ADC100", Offset = "0x2ADB300", VA = "0x182ADC100")]
	private void RaiseColumnSortingChanged()
	{
	}

	[Token(Token = "0x60008F1")]
	[Address(RVA = "0x2ADB2F0", Offset = "0x2ADA4F0", VA = "0x182ADB2F0")]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args)
	{
	}

	[Token(Token = "0x60008F2")]
	[Address(RVA = "0x2ADC120", Offset = "0x2ADB320", VA = "0x182ADC120")]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column)
	{
	}
}
