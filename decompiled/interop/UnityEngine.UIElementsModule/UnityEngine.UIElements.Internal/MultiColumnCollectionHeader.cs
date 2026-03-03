using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Internal;

[Token(Token = "0x2000601")]
internal class MultiColumnCollectionHeader : VisualElement, IDisposable
{
	[Serializable]
	[Token(Token = "0x2000602")]
	private class ViewState
	{
		[Serializable]
		[Token(Token = "0x2000603")]
		private struct ColumnState
		{
			[Token(Token = "0x4001633")]
			[FieldOffset(Offset = "0x0")]
			public int index;

			[Token(Token = "0x4001634")]
			[FieldOffset(Offset = "0x8")]
			public string name;

			[Token(Token = "0x4001635")]
			[FieldOffset(Offset = "0x10")]
			public float actualWidth;

			[Token(Token = "0x4001636")]
			[FieldOffset(Offset = "0x14")]
			public Length width;

			[Token(Token = "0x4001637")]
			[FieldOffset(Offset = "0x1C")]
			public bool visible;
		}

		[Token(Token = "0x4001630")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private bool m_HasPersistedData;

		[Token(Token = "0x4001631")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private List<SortColumnDescription> m_SortDescriptions;

		[Token(Token = "0x4001632")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<ColumnState> m_OrderedColumnStates;

		[Token(Token = "0x6002A0F")]
		[Address(RVA = "0x2A9DAA0", Offset = "0x2A9CCA0", VA = "0x182A9DAA0")]
		internal void Save(MultiColumnCollectionHeader header)
		{
		}

		[Token(Token = "0x6002A10")]
		[Address(RVA = "0x2A9D740", Offset = "0x2A9C940", VA = "0x182A9D740")]
		internal void Apply(MultiColumnCollectionHeader header)
		{
		}

		[Token(Token = "0x6002A11")]
		[Address(RVA = "0x2A9E0F0", Offset = "0x2A9D2F0", VA = "0x182A9E0F0")]
		public ViewState()
		{
		}
	}

	[Token(Token = "0x2000604")]
	internal class ColumnData
	{
		[Token(Token = "0x17000AD2")]
		public MultiColumnHeaderColumn control
		{
			[Token(Token = "0x6002A12")]
			[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A13")]
			[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x17000AD3")]
		public MultiColumnHeaderColumnResizeHandle resizeHandle
		{
			[Token(Token = "0x6002A14")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002A15")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x6002A16")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ColumnData()
		{
		}
	}

	[Token(Token = "0x2000605")]
	private struct SortedColumnState
	{
		[Token(Token = "0x400163A")]
		[FieldOffset(Offset = "0x0")]
		public SortColumnDescription columnDesc;

		[Token(Token = "0x400163B")]
		[FieldOffset(Offset = "0x8")]
		public SortDirection direction;

		[Token(Token = "0x6002A17")]
		[Address(RVA = "0x14F4B00", Offset = "0x14F3D00", VA = "0x1814F4B00")]
		public SortedColumnState(SortColumnDescription desc, SortDirection dir)
		{
		}
	}

	[Token(Token = "0x400161B")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string ussClassName;

	[Token(Token = "0x400161C")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string columnContainerUssClassName;

	[Token(Token = "0x400161D")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string handleContainerUssClassName;

	[Token(Token = "0x400161E")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string reorderableUssClassName;

	[Token(Token = "0x400161F")]
	[FieldOffset(Offset = "0x4A8")]
	private bool m_SortingEnabled;

	[Token(Token = "0x4001620")]
	[FieldOffset(Offset = "0x4B0")]
	private List<SortColumnDescription> m_SortedColumns;

	[Token(Token = "0x4001621")]
	[FieldOffset(Offset = "0x4B8")]
	private SortColumnDescriptions m_SortDescriptions;

	[Token(Token = "0x4001622")]
	[FieldOffset(Offset = "0x4C0")]
	private List<SortedColumnState> m_OldSortedColumnStates;

	[Token(Token = "0x4001623")]
	[FieldOffset(Offset = "0x4C8")]
	private bool m_SortingUpdatesTemporarilyDisabled;

	[Token(Token = "0x4001624")]
	[FieldOffset(Offset = "0x4D0")]
	private ViewState m_ViewState;

	[Token(Token = "0x4001625")]
	[FieldOffset(Offset = "0x4D8")]
	private bool m_ApplyingViewState;

	[Token(Token = "0x4001626")]
	[FieldOffset(Offset = "0x4D9")]
	private bool m_DoLayoutScheduled;

	[Token(Token = "0x17000AC8")]
	internal bool isApplyingViewState
	{
		[Token(Token = "0x60029DE")]
		[Address(RVA = "0x2A99990", Offset = "0x2A98B90", VA = "0x182A99990")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000AC9")]
	public Dictionary<Column, ColumnData> columnDataMap
	{
		[Token(Token = "0x60029DF")]
		[Address(RVA = "0x159B2E0", Offset = "0x159A4E0", VA = "0x18159B2E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACA")]
	public ColumnLayout columnLayout
	{
		[Token(Token = "0x60029E0")]
		[Address(RVA = "0x2A99980", Offset = "0x2A98B80", VA = "0x182A99980")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACB")]
	public VisualElement columnContainer
	{
		[Token(Token = "0x60029E1")]
		[Address(RVA = "0x23D0AC0", Offset = "0x23CFCC0", VA = "0x1823D0AC0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACC")]
	public VisualElement resizeHandleContainer
	{
		[Token(Token = "0x60029E2")]
		[Address(RVA = "0x137AB60", Offset = "0x1379D60", VA = "0x18137AB60")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACD")]
	public IEnumerable<SortColumnDescription> sortedColumns
	{
		[Token(Token = "0x60029E3")]
		[Address(RVA = "0x2A999A0", Offset = "0x2A98BA0", VA = "0x182A999A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACE")]
	internal IReadOnlyList<SortColumnDescription> sortedColumnReadonly
	{
		[Token(Token = "0x60029E4")]
		[Address(RVA = "0x2A999A0", Offset = "0x2A98BA0", VA = "0x182A999A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000ACF")]
	public SortColumnDescriptions sortDescriptions
	{
		[Token(Token = "0x60029E5")]
		[Address(RVA = "0x29FCCC0", Offset = "0x29FBEC0", VA = "0x1829FCCC0")]
		get
		{
			return null;
		}
		[Token(Token = "0x60029E6")]
		[Address(RVA = "0x2A99CA0", Offset = "0x2A98EA0", VA = "0x182A99CA0")]
		protected internal set
		{
		}
	}

	[Token(Token = "0x17000AD0")]
	public Columns columns
	{
		[Token(Token = "0x60029E7")]
		[Address(RVA = "0x141E0C0", Offset = "0x141D2C0", VA = "0x18141E0C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000AD1")]
	public bool sortingEnabled
	{
		[Token(Token = "0x60029E8")]
		[Address(RVA = "0x2A999B0", Offset = "0x2A98BB0", VA = "0x182A999B0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60029E9")]
		[Address(RVA = "0x2A99D50", Offset = "0x2A98F50", VA = "0x182A99D50")]
		set
		{
		}
	}

	[Token(Token = "0x14000036")]
	public event Action<int, float> columnResized
	{
		[Token(Token = "0x60029EA")]
		[Address(RVA = "0x2A996A0", Offset = "0x2A988A0", VA = "0x182A996A0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60029EB")]
		[Address(RVA = "0x2A999C0", Offset = "0x2A98BC0", VA = "0x182A999C0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000037")]
	public event Action columnSortingChanged
	{
		[Token(Token = "0x60029EC")]
		[Address(RVA = "0x2A99760", Offset = "0x2A98960", VA = "0x182A99760")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60029ED")]
		[Address(RVA = "0x2A99A80", Offset = "0x2A98C80", VA = "0x182A99A80")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000038")]
	public event Action<ContextualMenuPopulateEvent, Column> contextMenuPopulateEvent
	{
		[Token(Token = "0x60029EE")]
		[Address(RVA = "0x2A99810", Offset = "0x2A98A10", VA = "0x182A99810")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60029EF")]
		[Address(RVA = "0x2A99B30", Offset = "0x2A98D30", VA = "0x182A99B30")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x14000039")]
	internal event Action viewDataRestored
	{
		[Token(Token = "0x60029F0")]
		[Address(RVA = "0x2A998D0", Offset = "0x2A98AD0", VA = "0x182A998D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x60029F1")]
		[Address(RVA = "0x2A99BF0", Offset = "0x2A98DF0", VA = "0x182A99BF0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x60029F2")]
	[Address(RVA = "0x2A98EC0", Offset = "0x2A980C0", VA = "0x182A98EC0")]
	public MultiColumnCollectionHeader(Columns columns, SortColumnDescriptions sortDescriptions, List<SortColumnDescription> sortedColumns)
	{
	}

	[Token(Token = "0x60029F3")]
	[Address(RVA = "0x2A97750", Offset = "0x2A96950", VA = "0x182A97750")]
	private void ScheduleDoLayout()
	{
	}

	[Token(Token = "0x60029F4")]
	[Address(RVA = "0x2A97710", Offset = "0x2A96910", VA = "0x182A97710")]
	private void ResizeToFit()
	{
	}

	[Token(Token = "0x60029F5")]
	[Address(RVA = "0x2A98210", Offset = "0x2A97410", VA = "0x182A98210")]
	private void UpdateSortedColumns()
	{
	}

	[Token(Token = "0x60029F6")]
	[Address(RVA = "0x2A97A80", Offset = "0x2A96C80", VA = "0x182A97A80")]
	private void UpdateColumnControls()
	{
	}

	[Token(Token = "0x60029F7")]
	[Address(RVA = "0x2A95A70", Offset = "0x2A94C70", VA = "0x182A95A70")]
	private void OnColumnAdded(Column column, int index)
	{
	}

	[Token(Token = "0x60029F8")]
	[Address(RVA = "0x2A95A80", Offset = "0x2A94C80", VA = "0x182A95A80")]
	private void OnColumnAdded(Column column)
	{
	}

	[Token(Token = "0x60029F9")]
	[Address(RVA = "0x2A965F0", Offset = "0x2A957F0", VA = "0x182A965F0")]
	private void OnColumnRemoved(Column column)
	{
	}

	[Token(Token = "0x60029FA")]
	[Address(RVA = "0x2A96070", Offset = "0x2A95270", VA = "0x182A96070")]
	private void OnColumnChanged(Column column, ColumnDataType type)
	{
	}

	[Token(Token = "0x60029FB")]
	[Address(RVA = "0x2A96910", Offset = "0x2A95B10", VA = "0x182A96910")]
	private void OnColumnReordered(Column column, int from, int to)
	{
	}

	[Token(Token = "0x60029FC")]
	[Address(RVA = "0x2A96AE0", Offset = "0x2A95CE0", VA = "0x182A96AE0")]
	private void OnColumnResized(Column column)
	{
	}

	[Token(Token = "0x60029FD")]
	[Address(RVA = "0x2A96B20", Offset = "0x2A95D20", VA = "0x182A96B20")]
	private void OnContextualMenuManipulator(ContextualMenuPopulateEvent evt)
	{
	}

	[Token(Token = "0x60029FE")]
	[Address(RVA = "0x2A97400", Offset = "0x2A96600", VA = "0x182A97400")]
	private void OnMoveManipulatorActivated(ColumnMover mover)
	{
	}

	[Token(Token = "0x60029FF")]
	[Address(RVA = "0x2A972B0", Offset = "0x2A964B0", VA = "0x182A972B0")]
	private void OnGeometryChanged(GeometryChangedEvent e)
	{
	}

	[Token(Token = "0x6002A00")]
	[Address(RVA = "0x2A95A10", Offset = "0x2A94C10", VA = "0x182A95A10")]
	private void DoLayout()
	{
	}

	[Token(Token = "0x6002A01")]
	[Address(RVA = "0x2A962B0", Offset = "0x2A954B0", VA = "0x182A962B0")]
	private void OnColumnControlGeometryChanged(GeometryChangedEvent evt)
	{
	}

	[Token(Token = "0x6002A02")]
	[Address(RVA = "0x2A96100", Offset = "0x2A95300", VA = "0x182A96100")]
	private void OnColumnClicked(EventBase evt)
	{
	}

	[Token(Token = "0x6002A03")]
	[Address(RVA = "0x2A97FB0", Offset = "0x2A971B0", VA = "0x182A97FB0")]
	private void UpdateSortColumnDescriptionsOnClick(Column column, EventModifiers modifiers)
	{
	}

	[Token(Token = "0x6002A04")]
	[Address(RVA = "0x2A97810", Offset = "0x2A96A10", VA = "0x182A97810")]
	public void ScrollHorizontally(float horizontalOffset)
	{
	}

	[Token(Token = "0x6002A05")]
	[Address(RVA = "0x2A975B0", Offset = "0x2A967B0", VA = "0x182A975B0")]
	private void RaiseColumnResized(int columnIndex)
	{
	}

	[Token(Token = "0x6002A06")]
	[Address(RVA = "0x2A976D0", Offset = "0x2A968D0", VA = "0x182A976D0")]
	private void RaiseColumnSortingChanged()
	{
	}

	[Token(Token = "0x6002A07")]
	[Address(RVA = "0x2A94CE0", Offset = "0x2A93EE0", VA = "0x182A94CE0")]
	private void ApplyColumnSorting()
	{
	}

	[Token(Token = "0x6002A08")]
	[Address(RVA = "0x2A98820", Offset = "0x2A97A20", VA = "0x182A98820")]
	private void UpdateSortingStatus()
	{
	}

	[Token(Token = "0x6002A09")]
	[Address(RVA = "0x2A974A0", Offset = "0x2A966A0", VA = "0x182A974A0", Slot = "133")]
	internal override void OnViewDataReady()
	{
	}

	[Token(Token = "0x6002A0A")]
	[Address(RVA = "0x2A96AE0", Offset = "0x2A95CE0", VA = "0x182A96AE0")]
	private void SaveViewState()
	{
	}

	[Token(Token = "0x6002A0B")]
	[Address(RVA = "0x2A95400", Offset = "0x2A94600", VA = "0x182A95400")]
	private void CleanupColumnData(ColumnData data)
	{
	}

	[Token(Token = "0x6002A0C")]
	[Address(RVA = "0x2A95640", Offset = "0x2A94840", VA = "0x182A95640", Slot = "137")]
	public void Dispose()
	{
	}
}
