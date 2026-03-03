using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200058A")]
[DefaultMember("Item")]
internal struct LayoutNode : IEquatable<LayoutNode>
{
	[Token(Token = "0x40013DE")]
	private const int k_DefaultChildCapacity = 4;

	[Token(Token = "0x40013DF")]
	[FieldOffset(Offset = "0x0")]
	private readonly LayoutDataAccess m_Access;

	[Token(Token = "0x40013E0")]
	[FieldOffset(Offset = "0x28")]
	private readonly LayoutHandle m_Handle;

	[Token(Token = "0x170009D1")]
	public float LayoutX
	{
		[Token(Token = "0x600270D")]
		[Address(RVA = "0x2A73220", Offset = "0x2A72420", VA = "0x182A73220")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D2")]
	public float LayoutY
	{
		[Token(Token = "0x600270E")]
		[Address(RVA = "0x2A73240", Offset = "0x2A72440", VA = "0x182A73240")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D3")]
	public float LayoutRight
	{
		[Token(Token = "0x600270F")]
		[Address(RVA = "0x2A731E0", Offset = "0x2A723E0", VA = "0x182A731E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D4")]
	public float LayoutBottom
	{
		[Token(Token = "0x6002710")]
		[Address(RVA = "0x2A72FE0", Offset = "0x2A721E0", VA = "0x182A72FE0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D5")]
	public float LayoutWidth
	{
		[Token(Token = "0x6002711")]
		[Address(RVA = "0x2A73200", Offset = "0x2A72400", VA = "0x182A73200")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D6")]
	public float LayoutHeight
	{
		[Token(Token = "0x6002712")]
		[Address(RVA = "0x2A73000", Offset = "0x2A72200", VA = "0x182A73000")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D7")]
	public float LayoutMarginLeft
	{
		[Token(Token = "0x6002713")]
		[Address(RVA = "0x2A73040", Offset = "0x2A72240", VA = "0x182A73040")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D8")]
	public float LayoutMarginTop
	{
		[Token(Token = "0x6002714")]
		[Address(RVA = "0x2A730E0", Offset = "0x2A722E0", VA = "0x182A730E0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009D9")]
	public float LayoutMarginRight
	{
		[Token(Token = "0x6002715")]
		[Address(RVA = "0x2A73090", Offset = "0x2A72290", VA = "0x182A73090")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009DA")]
	public float LayoutMarginBottom
	{
		[Token(Token = "0x6002716")]
		[Address(RVA = "0x2A73020", Offset = "0x2A72220", VA = "0x182A73020")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009DB")]
	public float LayoutPaddingLeft
	{
		[Token(Token = "0x6002717")]
		[Address(RVA = "0x2A73120", Offset = "0x2A72320", VA = "0x182A73120")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009DC")]
	public float LayoutPaddingTop
	{
		[Token(Token = "0x6002718")]
		[Address(RVA = "0x2A731C0", Offset = "0x2A723C0", VA = "0x182A731C0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009DD")]
	public float LayoutPaddingRight
	{
		[Token(Token = "0x6002719")]
		[Address(RVA = "0x2A73170", Offset = "0x2A72370", VA = "0x182A73170")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009DE")]
	public float LayoutPaddingBottom
	{
		[Token(Token = "0x600271A")]
		[Address(RVA = "0x2A73100", Offset = "0x2A72300", VA = "0x182A73100")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009DF")]
	public float LayoutBorderLeft
	{
		[Token(Token = "0x600271B")]
		[Address(RVA = "0x2A72F20", Offset = "0x2A72120", VA = "0x182A72F20")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009E0")]
	public float LayoutBorderTop
	{
		[Token(Token = "0x600271C")]
		[Address(RVA = "0x2A72FC0", Offset = "0x2A721C0", VA = "0x182A72FC0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009E1")]
	public float LayoutBorderRight
	{
		[Token(Token = "0x600271D")]
		[Address(RVA = "0x2A72F70", Offset = "0x2A72170", VA = "0x182A72F70")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009E2")]
	public float LayoutBorderBottom
	{
		[Token(Token = "0x600271E")]
		[Address(RVA = "0x2A72F00", Offset = "0x2A72100", VA = "0x182A72F00")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009E3")]
	public float ComputedFlexBasis
	{
		[Token(Token = "0x600271F")]
		[Address(RVA = "0x2A72DD0", Offset = "0x2A71FD0", VA = "0x182A72DD0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x170009E4")]
	public LayoutNode Parent
	{
		[Token(Token = "0x6002721")]
		[Address(RVA = "0x2A732E0", Offset = "0x2A724E0", VA = "0x182A732E0")]
		get
		{
			return default(LayoutNode);
		}
		[Token(Token = "0x6002722")]
		[Address(RVA = "0x2A73B50", Offset = "0x2A72D50", VA = "0x182A73B50")]
		set
		{
		}
	}

	[Token(Token = "0x170009E5")]
	private LayoutList<LayoutHandle> Children
	{
		[Token(Token = "0x6002723")]
		[Address(RVA = "0x2A72DA0", Offset = "0x2A71FA0", VA = "0x182A72DA0")]
		get
		{
			return default(LayoutList<LayoutHandle>);
		}
	}

	[Token(Token = "0x170009E6")]
	public int Count
	{
		[Token(Token = "0x6002724")]
		[Address(RVA = "0x2A72DF0", Offset = "0x2A71FF0", VA = "0x182A72DF0")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x170009E7")]
	public LayoutFlexDirection FlexDirection
	{
		[Token(Token = "0x6002728")]
		[Address(RVA = "0x2A736A0", Offset = "0x2A728A0", VA = "0x182A736A0")]
		set
		{
		}
	}

	[Token(Token = "0x170009E8")]
	public LayoutJustify JustifyContent
	{
		[Token(Token = "0x6002729")]
		[Address(RVA = "0x2A73890", Offset = "0x2A72A90", VA = "0x182A73890")]
		set
		{
		}
	}

	[Token(Token = "0x170009E9")]
	public LayoutDisplay Display
	{
		[Token(Token = "0x600272A")]
		[Address(RVA = "0x2A73610", Offset = "0x2A72810", VA = "0x182A73610")]
		set
		{
		}
	}

	[Token(Token = "0x170009EA")]
	public LayoutAlign AlignItems
	{
		[Token(Token = "0x600272B")]
		[Address(RVA = "0x2A733B0", Offset = "0x2A725B0", VA = "0x182A733B0")]
		set
		{
		}
	}

	[Token(Token = "0x170009EB")]
	public LayoutAlign AlignSelf
	{
		[Token(Token = "0x600272C")]
		[Address(RVA = "0x2A73400", Offset = "0x2A72600", VA = "0x182A73400")]
		set
		{
		}
	}

	[Token(Token = "0x170009EC")]
	public LayoutAlign AlignContent
	{
		[Token(Token = "0x600272D")]
		[Address(RVA = "0x2A73360", Offset = "0x2A72560", VA = "0x182A73360")]
		set
		{
		}
	}

	[Token(Token = "0x170009ED")]
	public LayoutPositionType PositionType
	{
		[Token(Token = "0x600272E")]
		[Address(RVA = "0x2A73B80", Offset = "0x2A72D80", VA = "0x182A73B80")]
		set
		{
		}
	}

	[Token(Token = "0x170009EE")]
	public LayoutWrap Wrap
	{
		[Token(Token = "0x600272F")]
		[Address(RVA = "0x2A73C50", Offset = "0x2A72E50", VA = "0x182A73C50")]
		set
		{
		}
	}

	[Token(Token = "0x170009EF")]
	public float FlexGrow
	{
		[Token(Token = "0x6002730")]
		[Address(RVA = "0x2A736F0", Offset = "0x2A728F0", VA = "0x182A736F0")]
		set
		{
		}
	}

	[Token(Token = "0x170009F0")]
	public float FlexShrink
	{
		[Token(Token = "0x6002731")]
		[Address(RVA = "0x2A73750", Offset = "0x2A72950", VA = "0x182A73750")]
		set
		{
		}
	}

	[Token(Token = "0x170009F1")]
	public LayoutValue FlexBasis
	{
		[Token(Token = "0x6002732")]
		[Address(RVA = "0x2A73660", Offset = "0x2A72860", VA = "0x182A73660")]
		set
		{
		}
	}

	[Token(Token = "0x170009F2")]
	public LayoutValue Width
	{
		[Token(Token = "0x6002733")]
		[Address(RVA = "0x2A73BF0", Offset = "0x2A72DF0", VA = "0x182A73BF0")]
		set
		{
		}
	}

	[Token(Token = "0x170009F3")]
	public LayoutValue Height
	{
		[Token(Token = "0x6002734")]
		[Address(RVA = "0x2A737F0", Offset = "0x2A729F0", VA = "0x182A737F0")]
		set
		{
		}
	}

	[Token(Token = "0x170009F4")]
	public LayoutValue MaxWidth
	{
		[Token(Token = "0x6002735")]
		[Address(RVA = "0x2A73990", Offset = "0x2A72B90", VA = "0x182A73990")]
		set
		{
		}
	}

	[Token(Token = "0x170009F5")]
	public LayoutValue MaxHeight
	{
		[Token(Token = "0x6002736")]
		[Address(RVA = "0x2A73930", Offset = "0x2A72B30", VA = "0x182A73930")]
		set
		{
		}
	}

	[Token(Token = "0x170009F6")]
	public LayoutValue MinWidth
	{
		[Token(Token = "0x6002737")]
		[Address(RVA = "0x2A73A60", Offset = "0x2A72C60", VA = "0x182A73A60")]
		set
		{
		}
	}

	[Token(Token = "0x170009F7")]
	public LayoutValue MinHeight
	{
		[Token(Token = "0x6002738")]
		[Address(RVA = "0x2A73A00", Offset = "0x2A72C00", VA = "0x182A73A00")]
		set
		{
		}
	}

	[Token(Token = "0x170009F8")]
	public LayoutOverflow Overflow
	{
		[Token(Token = "0x6002739")]
		[Address(RVA = "0x2A73AC0", Offset = "0x2A72CC0", VA = "0x182A73AC0")]
		set
		{
		}
	}

	[Token(Token = "0x170009F9")]
	public LayoutValue Left
	{
		[Token(Token = "0x600273A")]
		[Address(RVA = "0x2A738E0", Offset = "0x2A72AE0", VA = "0x182A738E0")]
		set
		{
		}
	}

	[Token(Token = "0x170009FA")]
	public LayoutValue Top
	{
		[Token(Token = "0x600273B")]
		[Address(RVA = "0x2A73BE0", Offset = "0x2A72DE0", VA = "0x182A73BE0")]
		set
		{
		}
	}

	[Token(Token = "0x170009FB")]
	public LayoutValue Right
	{
		[Token(Token = "0x600273C")]
		[Address(RVA = "0x2A73BD0", Offset = "0x2A72DD0", VA = "0x182A73BD0")]
		set
		{
		}
	}

	[Token(Token = "0x170009FC")]
	public LayoutValue Bottom
	{
		[Token(Token = "0x600273D")]
		[Address(RVA = "0x2A735D0", Offset = "0x2A727D0", VA = "0x182A735D0")]
		set
		{
		}
	}

	[Token(Token = "0x170009FD")]
	public LayoutValue MarginLeft
	{
		[Token(Token = "0x600273E")]
		[Address(RVA = "0x2A73900", Offset = "0x2A72B00", VA = "0x182A73900")]
		set
		{
		}
	}

	[Token(Token = "0x170009FE")]
	public LayoutValue MarginTop
	{
		[Token(Token = "0x600273F")]
		[Address(RVA = "0x2A73920", Offset = "0x2A72B20", VA = "0x182A73920")]
		set
		{
		}
	}

	[Token(Token = "0x170009FF")]
	public LayoutValue MarginRight
	{
		[Token(Token = "0x6002740")]
		[Address(RVA = "0x2A73910", Offset = "0x2A72B10", VA = "0x182A73910")]
		set
		{
		}
	}

	[Token(Token = "0x17000A00")]
	public LayoutValue MarginBottom
	{
		[Token(Token = "0x6002741")]
		[Address(RVA = "0x2A738F0", Offset = "0x2A72AF0", VA = "0x182A738F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A01")]
	public LayoutValue PaddingLeft
	{
		[Token(Token = "0x6002742")]
		[Address(RVA = "0x2A73B20", Offset = "0x2A72D20", VA = "0x182A73B20")]
		set
		{
		}
	}

	[Token(Token = "0x17000A02")]
	public LayoutValue PaddingTop
	{
		[Token(Token = "0x6002743")]
		[Address(RVA = "0x2A73B40", Offset = "0x2A72D40", VA = "0x182A73B40")]
		set
		{
		}
	}

	[Token(Token = "0x17000A03")]
	public LayoutValue PaddingRight
	{
		[Token(Token = "0x6002744")]
		[Address(RVA = "0x2A73B30", Offset = "0x2A72D30", VA = "0x182A73B30")]
		set
		{
		}
	}

	[Token(Token = "0x17000A04")]
	public LayoutValue PaddingBottom
	{
		[Token(Token = "0x6002745")]
		[Address(RVA = "0x2A73B10", Offset = "0x2A72D10", VA = "0x182A73B10")]
		set
		{
		}
	}

	[Token(Token = "0x17000A05")]
	public float BorderLeftWidth
	{
		[Token(Token = "0x6002746")]
		[Address(RVA = "0x2A734B0", Offset = "0x2A726B0", VA = "0x182A734B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A06")]
	public float BorderTopWidth
	{
		[Token(Token = "0x6002747")]
		[Address(RVA = "0x2A73570", Offset = "0x2A72770", VA = "0x182A73570")]
		set
		{
		}
	}

	[Token(Token = "0x17000A07")]
	public float BorderRightWidth
	{
		[Token(Token = "0x6002748")]
		[Address(RVA = "0x2A73510", Offset = "0x2A72710", VA = "0x182A73510")]
		set
		{
		}
	}

	[Token(Token = "0x17000A08")]
	public float BorderBottomWidth
	{
		[Token(Token = "0x6002749")]
		[Address(RVA = "0x2A73450", Offset = "0x2A72650", VA = "0x182A73450")]
		set
		{
		}
	}

	[Token(Token = "0x17000A09")]
	public static LayoutNode Undefined
	{
		[Token(Token = "0x6002756")]
		[Address(RVA = "0x2A6DC20", Offset = "0x2A6CE20", VA = "0x182A6DC20")]
		get
		{
			return default(LayoutNode);
		}
	}

	[Token(Token = "0x17000A0A")]
	public bool IsUndefined
	{
		[Token(Token = "0x6002758")]
		[Address(RVA = "0x2A72EF0", Offset = "0x2A720F0", VA = "0x182A72EF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A0B")]
	public LayoutHandle Handle
	{
		[Token(Token = "0x6002759")]
		[Address(RVA = "0x4030F0", Offset = "0x4022F0", VA = "0x1804030F0")]
		get
		{
			return default(LayoutHandle);
		}
	}

	[Token(Token = "0x17000A0C")]
	public unsafe ref LayoutComputedData Layout
	{
		[Token(Token = "0x600275A")]
		[Address(RVA = "0x2A73260", Offset = "0x2A72460", VA = "0x182A73260")]
		get
		{
			return ref *(LayoutComputedData*)null;
		}
	}

	[Token(Token = "0x17000A0D")]
	public unsafe ref LayoutStyleData Style
	{
		[Token(Token = "0x600275B")]
		[Address(RVA = "0x2A73350", Offset = "0x2A72550", VA = "0x182A73350")]
		get
		{
			return ref *(LayoutStyleData*)null;
		}
	}

	[Token(Token = "0x17000A0E")]
	public bool IsDirty
	{
		[Token(Token = "0x600275C")]
		[Address(RVA = "0x2A72EB0", Offset = "0x2A720B0", VA = "0x182A72EB0")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600275D")]
		[Address(RVA = "0x2A73850", Offset = "0x2A72A50", VA = "0x182A73850")]
		set
		{
		}
	}

	[Token(Token = "0x17000A0F")]
	public bool HasNewLayout
	{
		[Token(Token = "0x600275E")]
		[Address(RVA = "0x2A72E90", Offset = "0x2A72090", VA = "0x182A72E90")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600275F")]
		[Address(RVA = "0x2A737B0", Offset = "0x2A729B0", VA = "0x182A737B0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A10")]
	public bool IsMeasureDefined
	{
		[Token(Token = "0x6002760")]
		[Address(RVA = "0x2A72ED0", Offset = "0x2A720D0", VA = "0x182A72ED0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A11")]
	public LayoutMeasureFunction Measure
	{
		[Token(Token = "0x6002761")]
		[Address(RVA = "0x2A73270", Offset = "0x2A72470", VA = "0x182A73270")]
		get
		{
			return null;
		}
		[Token(Token = "0x6002762")]
		[Address(RVA = "0x2A739F0", Offset = "0x2A72BF0", VA = "0x182A739F0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A12")]
	public LayoutBaselineFunction Baseline
	{
		[Token(Token = "0x6002765")]
		[Address(RVA = "0x2A72D30", Offset = "0x2A71F30", VA = "0x182A72D30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000A13")]
	public LayoutConfig Config
	{
		[Token(Token = "0x6002766")]
		[Address(RVA = "0x2A735E0", Offset = "0x2A727E0", VA = "0x182A735E0")]
		set
		{
		}
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002720")]
	[Address(RVA = "0x2A69AD0", Offset = "0x2A68CD0", VA = "0x182A69AD0")]
	private unsafe float GetLayoutValue(float* buffer, LayoutEdge edge)
	{
		return default(float);
	}

	[Token(Token = "0x6002725")]
	[Address(RVA = "0x2A720E0", Offset = "0x2A712E0", VA = "0x182A720E0")]
	public void Insert(int index, LayoutNode child)
	{
	}

	[Token(Token = "0x6002726")]
	[Address(RVA = "0x2A722F0", Offset = "0x2A714F0", VA = "0x182A722F0")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x6002727")]
	[Address(RVA = "0x2A716D0", Offset = "0x2A708D0", VA = "0x182A716D0")]
	public void Clear()
	{
	}

	[Token(Token = "0x600274A")]
	[Address(RVA = "0x2A72BB0", Offset = "0x2A71DB0", VA = "0x182A72BB0")]
	private void SetValue(ref float currentValue, float newValue)
	{
	}

	[Token(Token = "0x600274B")]
	[Address(RVA = "0x2A72A80", Offset = "0x2A71C80", VA = "0x182A72A80")]
	private void SetStyleValue(ref LayoutValue currentValue, LayoutValue newValue)
	{
	}

	[Token(Token = "0x600274C")]
	[Address(RVA = "0x2A729F0", Offset = "0x2A71BF0", VA = "0x182A729F0")]
	private void SetStyleValueUnit(ref LayoutValue currentValue, LayoutValue newValue)
	{
	}

	[Token(Token = "0x600274D")]
	[Address(RVA = "0x2A72940", Offset = "0x2A71B40", VA = "0x182A72940")]
	private void SetStyleValuePoint(ref LayoutValue currentValue, LayoutValue newValue)
	{
	}

	[Token(Token = "0x600274E")]
	[Address(RVA = "0x2A728D0", Offset = "0x2A71AD0", VA = "0x182A728D0")]
	private void SetStyleValuePercent(ref LayoutValue currentValue, LayoutValue newValue)
	{
	}

	[Token(Token = "0x600274F")]
	[Address(RVA = "0x2A728A0", Offset = "0x2A71AA0", VA = "0x182A728A0")]
	private void SetStyleValueAuto(ref LayoutValue currentValue)
	{
	}

	[Token(Token = "0x6002750")]
	[Address(RVA = "0x2A72770", Offset = "0x2A71970", VA = "0x182A72770")]
	private void SetStyleEdgePosition(LayoutEdge edge, LayoutValue value)
	{
	}

	[Token(Token = "0x6002751")]
	[Address(RVA = "0x2A72490", Offset = "0x2A71690", VA = "0x182A72490")]
	private void SetStyleEdgeMargin(LayoutEdge edge, LayoutValue value)
	{
	}

	[Token(Token = "0x6002752")]
	[Address(RVA = "0x2A72640", Offset = "0x2A71840", VA = "0x182A72640")]
	private void SetStyleEdgePadding(LayoutEdge edge, LayoutValue value)
	{
	}

	[Token(Token = "0x6002753")]
	[Address(RVA = "0x2A72C20", Offset = "0x2A71E20", VA = "0x182A72C20")]
	private void StyleEdgeSetPercent(ref LayoutValue value, float newValue)
	{
	}

	[Token(Token = "0x6002754")]
	[Address(RVA = "0x2A728A0", Offset = "0x2A71AA0", VA = "0x182A728A0")]
	private void StyleEdgeSetAuto(ref LayoutValue value)
	{
	}

	[Token(Token = "0x6002755")]
	[Address(RVA = "0x2A72CA0", Offset = "0x2A71EA0", VA = "0x182A72CA0")]
	private void StyleEdgeSetPoint(ref LayoutValue value, float newValue)
	{
	}

	[Token(Token = "0x6002757")]
	[Address(RVA = "0x2A6DBF0", Offset = "0x2A6CDF0", VA = "0x182A6DBF0")]
	internal LayoutNode(LayoutDataAccess access, LayoutHandle handle)
	{
	}

	[Token(Token = "0x6002763")]
	[Address(RVA = "0x2A72480", Offset = "0x2A71680", VA = "0x182A72480")]
	public void SetOwner(VisualElement func)
	{
	}

	[Token(Token = "0x6002764")]
	[Address(RVA = "0x2A72070", Offset = "0x2A71270", VA = "0x182A72070")]
	public VisualElement GetOwner()
	{
		return null;
	}

	[Token(Token = "0x6002767")]
	[Address(RVA = "0x2A721E0", Offset = "0x2A713E0", VA = "0x182A721E0")]
	public void MarkDirty()
	{
	}

	[Token(Token = "0x6002768")]
	[Address(RVA = "0x2A722D0", Offset = "0x2A714D0", VA = "0x182A722D0")]
	public void MarkLayoutSeen()
	{
	}

	[Token(Token = "0x6002769")]
	[Address(RVA = "0x2A71780", Offset = "0x2A70980", VA = "0x182A71780")]
	public void CopyFromComputedStyle(ComputedStyle style)
	{
	}

	[Token(Token = "0x600276A")]
	[Address(RVA = "0x2A72C00", Offset = "0x2A71E00", VA = "0x182A72C00")]
	public void SoftReset()
	{
	}

	[Token(Token = "0x600276B")]
	[Address(RVA = "0x2A71F80", Offset = "0x2A71180", VA = "0x182A71F80", Slot = "4")]
	public bool Equals(LayoutNode other)
	{
		return default(bool);
	}

	[Token(Token = "0x600276C")]
	[Address(RVA = "0x2A71FC0", Offset = "0x2A711C0", VA = "0x182A71FC0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600276D")]
	[Address(RVA = "0x2A72060", Offset = "0x2A71260", VA = "0x182A72060", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600276E")]
	[Address(RVA = "0x2A71530", Offset = "0x2A70730", VA = "0x182A71530")]
	public void CalculateLayout(float width = 0f / 0f, float height = 0f / 0f)
	{
	}
}
