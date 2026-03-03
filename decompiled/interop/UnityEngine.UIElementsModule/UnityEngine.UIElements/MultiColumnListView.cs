using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000116")]
public class MultiColumnListView : BaseListView
{
	[Token(Token = "0x2000117")]
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlFactory : UxmlFactory<MultiColumnListView, UxmlTraits>
	{
		[Token(Token = "0x60008E1")]
		[Address(RVA = "0x2AEF630", Offset = "0x2AEE830", VA = "0x182AEF630")]
		public UxmlFactory()
		{
		}
	}

	[Token(Token = "0x2000118")]
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", false)]
	public new class UxmlTraits : BaseListView.UxmlTraits
	{
		[Token(Token = "0x4000592")]
		[FieldOffset(Offset = "0x108")]
		private readonly UxmlEnumAttributeDescription<ColumnSortingMode> m_SortingMode;

		[Token(Token = "0x4000593")]
		[FieldOffset(Offset = "0x110")]
		private readonly UxmlObjectAttributeDescription<Columns> m_Columns;

		[Token(Token = "0x4000594")]
		[FieldOffset(Offset = "0x118")]
		private readonly UxmlObjectAttributeDescription<SortColumnDescriptions> m_SortColumnDescriptions;

		[Token(Token = "0x60008E2")]
		[Address(RVA = "0x2AF0490", Offset = "0x2AEF690", VA = "0x182AF0490", Slot = "4")]
		public override void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc)
		{
		}

		[Token(Token = "0x60008E3")]
		[Address(RVA = "0x2AF26D0", Offset = "0x2AF18D0", VA = "0x182AF26D0")]
		public UxmlTraits()
		{
		}
	}

	[Token(Token = "0x4000589")]
	[FieldOffset(Offset = "0x0")]
	private static readonly BindingId columnsProperty;

	[Token(Token = "0x400058A")]
	[FieldOffset(Offset = "0x98")]
	private static readonly BindingId sortColumnDescriptionsProperty;

	[Token(Token = "0x400058B")]
	[FieldOffset(Offset = "0x130")]
	private static readonly BindingId sortingModeProperty;

	[Token(Token = "0x400058C")]
	[FieldOffset(Offset = "0x6B0")]
	private Columns m_Columns;

	[Token(Token = "0x400058D")]
	[FieldOffset(Offset = "0x6B8")]
	private ColumnSortingMode m_SortingMode;

	[Token(Token = "0x400058E")]
	[FieldOffset(Offset = "0x6C0")]
	private SortColumnDescriptions m_SortColumnDescriptions;

	[Token(Token = "0x400058F")]
	[FieldOffset(Offset = "0x6C8")]
	private List<SortColumnDescription> m_SortedColumns;

	[Token(Token = "0x4000590")]
	[FieldOffset(Offset = "0x6D0")]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	[CompilerGenerated]
	private Action columnSortingChanged;

	[Token(Token = "0x4000591")]
	[FieldOffset(Offset = "0x6D8")]
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private Action<ContextualMenuPopulateEvent, Column> headerContextMenuPopulateEvent;

	[Token(Token = "0x1700017A")]
	public new MultiColumnListViewController viewController
	{
		[Token(Token = "0x60008D1")]
		[Address(RVA = "0x2ADBC40", Offset = "0x2ADAE40", VA = "0x182ADBC40")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700017B")]
	[CreateProperty]
	public Columns columns
	{
		[Token(Token = "0x60008D2")]
		[Address(RVA = "0x2ACE2C0", Offset = "0x2ACD4C0", VA = "0x182ACE2C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008D3")]
		[Address(RVA = "0x2ADBCC0", Offset = "0x2ADAEC0", VA = "0x182ADBCC0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700017C")]
	[CreateProperty]
	public SortColumnDescriptions sortColumnDescriptions
	{
		[Token(Token = "0x60008D4")]
		[Address(RVA = "0x2ACE2B0", Offset = "0x2ACD4B0", VA = "0x182ACE2B0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60008D5")]
		[Address(RVA = "0x2ADBE40", Offset = "0x2ADB040", VA = "0x182ADBE40")]
		private set
		{
		}
	}

	[Token(Token = "0x1700017D")]
	[CreateProperty]
	public ColumnSortingMode sortingMode
	{
		[Token(Token = "0x60008D6")]
		[Address(RVA = "0x2ADBC30", Offset = "0x2ADAE30", VA = "0x182ADBC30")]
		get
		{
			return default(ColumnSortingMode);
		}
		[Token(Token = "0x60008D7")]
		[Address(RVA = "0x2ADBF60", Offset = "0x2ADB160", VA = "0x182ADBF60")]
		set
		{
		}
	}

	[Token(Token = "0x60008D8")]
	[Address(RVA = "0x2ADBAB0", Offset = "0x2ADACB0", VA = "0x182ADBAB0")]
	public MultiColumnListView()
	{
	}

	[Token(Token = "0x60008D9")]
	[Address(RVA = "0x2ADB960", Offset = "0x2ADAB60", VA = "0x182ADB960")]
	public MultiColumnListView(Columns columns)
	{
	}

	[Token(Token = "0x60008DA")]
	[Address(RVA = "0x2ADB380", Offset = "0x2ADA580", VA = "0x182ADB380", Slot = "142")]
	protected override CollectionViewController CreateViewController()
	{
		return null;
	}

	[Token(Token = "0x60008DB")]
	[Address(RVA = "0x2ADB490", Offset = "0x2ADA690", VA = "0x182ADB490", Slot = "143")]
	public override void SetViewController(CollectionViewController controller)
	{
	}

	[Token(Token = "0x60008DC")]
	[Address(RVA = "0x2ADB410", Offset = "0x2ADA610", VA = "0x182ADB410", Slot = "141")]
	private protected override void CreateVirtualizationController()
	{
	}

	[Token(Token = "0x60008DD")]
	[Address(RVA = "0x2ADB450", Offset = "0x2ADA650", VA = "0x182ADB450")]
	private void RaiseColumnSortingChanged()
	{
	}

	[Token(Token = "0x60008DE")]
	[Address(RVA = "0x2ADB2F0", Offset = "0x2ADA4F0", VA = "0x182ADB2F0")]
	private void ColumnsChanged(object sender, BindablePropertyChangedEventArgs args)
	{
	}

	[Token(Token = "0x60008DF")]
	[Address(RVA = "0x2ADB470", Offset = "0x2ADA670", VA = "0x182ADB470")]
	private void RaiseHeaderContextMenuPopulate(ContextualMenuPopulateEvent evt, Column column)
	{
	}
}
