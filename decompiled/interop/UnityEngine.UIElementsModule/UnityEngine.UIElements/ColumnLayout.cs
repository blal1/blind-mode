using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200010A")]
internal class ColumnLayout
{
	[Token(Token = "0x4000534")]
	[FieldOffset(Offset = "0x10")]
	private List<Column> m_StretchableColumns;

	[Token(Token = "0x4000535")]
	[FieldOffset(Offset = "0x18")]
	private List<Column> m_FixedColumns;

	[Token(Token = "0x4000536")]
	[FieldOffset(Offset = "0x20")]
	private List<Column> m_RelativeWidthColumns;

	[Token(Token = "0x4000537")]
	[FieldOffset(Offset = "0x28")]
	private List<Column> m_MixedWidthColumns;

	[Token(Token = "0x4000538")]
	[FieldOffset(Offset = "0x30")]
	private Columns m_Columns;

	[Token(Token = "0x4000539")]
	[FieldOffset(Offset = "0x38")]
	private float m_ColumnsWidth;

	[Token(Token = "0x400053A")]
	[FieldOffset(Offset = "0x3C")]
	private bool m_ColumnsWidthDirty;

	[Token(Token = "0x400053B")]
	[FieldOffset(Offset = "0x40")]
	private float m_MaxColumnsWidth;

	[Token(Token = "0x400053C")]
	[FieldOffset(Offset = "0x44")]
	private float m_MinColumnsWidth;

	[Token(Token = "0x400053D")]
	[FieldOffset(Offset = "0x48")]
	private bool m_IsDirty;

	[Token(Token = "0x400053E")]
	[FieldOffset(Offset = "0x4C")]
	private float m_PreviousWidth;

	[Token(Token = "0x400053F")]
	[FieldOffset(Offset = "0x50")]
	private float m_LayoutWidth;

	[Token(Token = "0x4000540")]
	[FieldOffset(Offset = "0x54")]
	private bool m_DragResizeInPreviewMode;

	[Token(Token = "0x4000541")]
	[FieldOffset(Offset = "0x55")]
	private bool m_DragResizing;

	[Token(Token = "0x4000542")]
	[FieldOffset(Offset = "0x58")]
	private float m_DragStartPos;

	[Token(Token = "0x4000543")]
	[FieldOffset(Offset = "0x5C")]
	private float m_DragLastPos;

	[Token(Token = "0x4000544")]
	[FieldOffset(Offset = "0x60")]
	private float m_DragInitialColumnWidth;

	[Token(Token = "0x4000545")]
	[FieldOffset(Offset = "0x68")]
	private List<Column> m_DragStretchableColumns;

	[Token(Token = "0x4000546")]
	[FieldOffset(Offset = "0x70")]
	private List<Column> m_DragRelativeColumns;

	[Token(Token = "0x4000547")]
	[FieldOffset(Offset = "0x78")]
	private List<Column> m_DragFixedColumns;

	[Token(Token = "0x4000548")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<Column, float> m_PreviewDesiredWidths;

	[Token(Token = "0x17000166")]
	public Columns columns
	{
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000167")]
	public float columnsWidth
	{
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x2AC2380", Offset = "0x2AC1580", VA = "0x182AC2380")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000168")]
	public float layoutWidth
	{
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x1FEBF70", Offset = "0x1FEB170", VA = "0x181FEBF70")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17000169")]
	public float minColumnsWidth
	{
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x416670", Offset = "0x415870", VA = "0x180416670")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700016A")]
	public float maxColumnsWidth
	{
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x8A9B10", Offset = "0x8A8D10", VA = "0x1808A9B10")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x1700016B")]
	public bool hasStretchableColumns
	{
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x2AC25E0", Offset = "0x2AC17E0", VA = "0x182AC25E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700016C")]
	public bool hasRelativeWidthColumns
	{
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x2AC2580", Offset = "0x2AC1780", VA = "0x182AC2580")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x14000017")]
	public event Action layoutRequested
	{
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x2AC22D0", Offset = "0x2AC14D0", VA = "0x182AC22D0")]
		[CompilerGenerated]
		add
		{
		}
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x2AC2630", Offset = "0x2AC1830", VA = "0x182AC2630")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Token(Token = "0x600084B")]
	[Address(RVA = "0x2AC1E90", Offset = "0x2AC1090", VA = "0x182AC1E90")]
	public ColumnLayout(Columns columns)
	{
	}

	[Token(Token = "0x600084C")]
	[Address(RVA = "0x2ABD5B0", Offset = "0x2ABC7B0", VA = "0x182ABD5B0")]
	public void Dirty()
	{
	}

	[Token(Token = "0x600084D")]
	[Address(RVA = "0x2ABF6B0", Offset = "0x2ABE8B0", VA = "0x182ABF6B0")]
	private void OnColumnAdded(Column column, int index)
	{
	}

	[Token(Token = "0x600084E")]
	[Address(RVA = "0x2ABF820", Offset = "0x2ABEA20", VA = "0x182ABF820")]
	private void OnColumnRemoved(Column column)
	{
	}

	[Token(Token = "0x600084F")]
	[Address(RVA = "0x2ABD5B0", Offset = "0x2ABC7B0", VA = "0x182ABD5B0")]
	private void OnColumnReordered(Column column, int from, int to)
	{
	}

	[Token(Token = "0x6000850")]
	[Address(RVA = "0x2AC0CC0", Offset = "0x2ABFEC0", VA = "0x182AC0CC0")]
	private bool RequiresLayoutUpdate(ColumnDataType type)
	{
		return default(bool);
	}

	[Token(Token = "0x6000851")]
	[Address(RVA = "0x2ABF7C0", Offset = "0x2ABE9C0", VA = "0x182ABF7C0")]
	private void OnColumnChanged(Column column, ColumnDataType type)
	{
	}

	[Token(Token = "0x6000852")]
	[Address(RVA = "0x2ABF930", Offset = "0x2ABEB30", VA = "0x182ABF930")]
	private void OnColumnResized(Column column)
	{
	}

	[Token(Token = "0x6000853")]
	[Address(RVA = "0x2ABF6A0", Offset = "0x2ABE8A0", VA = "0x182ABF6A0")]
	private static bool IsClamped(float value, float min, float max)
	{
		return default(bool);
	}

	[Token(Token = "0x6000854")]
	[Address(RVA = "0x2ABDC90", Offset = "0x2ABCE90", VA = "0x182ABDC90")]
	public void DoLayout(float width)
	{
	}

	[Token(Token = "0x6000855")]
	[Address(RVA = "0x2AC1740", Offset = "0x2AC0940", VA = "0x182AC1740")]
	public void StretchResizeColumns(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
	{
	}

	[Token(Token = "0x6000856")]
	[Address(RVA = "0x2ABD990", Offset = "0x2ABCB90", VA = "0x182ABD990")]
	private void DistributeOverflow(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
	{
	}

	[Token(Token = "0x6000857")]
	[Address(RVA = "0x2ABD5F0", Offset = "0x2ABC7F0", VA = "0x182ABD5F0")]
	private void DistributeExcess(List<Column> stretchableColumns, List<Column> fixedColumns, List<Column> relativeWidthColumns, ref float delta, bool resizeToFit, bool dragResize)
	{
	}

	[Token(Token = "0x6000858")]
	[Address(RVA = "0x2ABFDB0", Offset = "0x2ABEFB0", VA = "0x182ABFDB0")]
	private float RecomputeToMaxWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return default(float);
	}

	[Token(Token = "0x6000859")]
	[Address(RVA = "0x2AC0570", Offset = "0x2ABF770", VA = "0x182AC0570")]
	private float RecomputeToMinWidthProportionally(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return default(float);
	}

	[Token(Token = "0x600085A")]
	[Address(RVA = "0x2ABFC60", Offset = "0x2ABEE60", VA = "0x182ABFC60")]
	private float RecomputeToDesiredWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow)
	{
		return default(float);
	}

	[Token(Token = "0x600085B")]
	[Address(RVA = "0x2ABF940", Offset = "0x2ABEB40", VA = "0x182ABF940")]
	private float RecomputeToDesiredWidth(Column column, float distributedDelta, bool setDesiredWidthOnly, bool distributeOverflow)
	{
		return default(float);
	}

	[Token(Token = "0x600085C")]
	[Address(RVA = "0x2AC0A40", Offset = "0x2ABFC40", VA = "0x182AC0A40")]
	private float RecomputeToMinWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return default(float);
	}

	[Token(Token = "0x600085D")]
	[Address(RVA = "0x2AC02D0", Offset = "0x2ABF4D0", VA = "0x182AC02D0")]
	private float RecomputeToMaxWidth(List<Column> columns, float distributedDelta, bool setDesiredWidthOnly = false)
	{
		return default(float);
	}

	[Token(Token = "0x600085E")]
	[Address(RVA = "0x2AC0EC0", Offset = "0x2AC00C0", VA = "0x182AC0EC0")]
	public void ResizeToFit(float width)
	{
	}

	[Token(Token = "0x600085F")]
	[Address(RVA = "0x2AC0CE0", Offset = "0x2ABFEE0", VA = "0x182AC0CE0")]
	private void ResizeColumn(Column column, float width, bool setDesiredWidthOnly = false)
	{
	}

	[Token(Token = "0x6000860")]
	[Address(RVA = "0x2ABD200", Offset = "0x2ABC400", VA = "0x182ABD200")]
	internal void BeginDragResize(Column column, float pos, bool previewMode)
	{
	}

	[Token(Token = "0x6000861")]
	[Address(RVA = "0x2ABF4B0", Offset = "0x2ABE6B0", VA = "0x182ABF4B0")]
	public float GetDesiredPosition(Column column)
	{
		return default(float);
	}

	[Token(Token = "0x6000862")]
	[Address(RVA = "0x2ABF600", Offset = "0x2ABE800", VA = "0x182ABF600")]
	public float GetDesiredWidth(Column c)
	{
		return default(float);
	}

	[Token(Token = "0x6000863")]
	[Address(RVA = "0x2ABED60", Offset = "0x2ABDF60", VA = "0x182ABED60")]
	public void DragResize(Column column, float pos)
	{
	}

	[Token(Token = "0x6000864")]
	[Address(RVA = "0x2ABF260", Offset = "0x2ABE460", VA = "0x182ABF260")]
	internal void EndDragResize(Column column, bool cancelled)
	{
	}

	[Token(Token = "0x6000865")]
	[Address(RVA = "0x2AC1910", Offset = "0x2AC0B10", VA = "0x182AC1910")]
	private void UpdateCache()
	{
	}

	[Token(Token = "0x6000866")]
	[Address(RVA = "0x2AC1C40", Offset = "0x2AC0E40", VA = "0x182AC1C40")]
	private void UpdateMinAndMaxColumnsWidth()
	{
	}

	[Token(Token = "0x6000867")]
	[Address(RVA = "0x2ABD4F0", Offset = "0x2ABC6F0", VA = "0x182ABD4F0")]
	private void ClearCache()
	{
	}
}
