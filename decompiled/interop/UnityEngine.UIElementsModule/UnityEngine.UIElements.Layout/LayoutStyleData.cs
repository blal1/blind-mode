using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x20005B8")]
[UnityEngine.Scripting.RequiredByNativeCode]
[UnityEngine.Bindings.NativeHeader("Modules/UIElements/Core/Layout/Native/LayoutModel.h")]
internal struct LayoutStyleData
{
	[Token(Token = "0x400149D")]
	[FieldOffset(Offset = "0x0")]
	public static LayoutStyleData Default;

	[Token(Token = "0x400149E")]
	[FieldOffset(Offset = "0x0")]
	public LayoutDirection Direction;

	[Token(Token = "0x400149F")]
	[FieldOffset(Offset = "0x4")]
	public LayoutFlexDirection FlexDirection;

	[Token(Token = "0x40014A0")]
	[FieldOffset(Offset = "0x8")]
	public LayoutJustify JustifyContent;

	[Token(Token = "0x40014A1")]
	[FieldOffset(Offset = "0xC")]
	public LayoutAlign AlignContent;

	[Token(Token = "0x40014A2")]
	[FieldOffset(Offset = "0x10")]
	public LayoutAlign AlignItems;

	[Token(Token = "0x40014A3")]
	[FieldOffset(Offset = "0x14")]
	public LayoutAlign AlignSelf;

	[Token(Token = "0x40014A4")]
	[FieldOffset(Offset = "0x18")]
	public LayoutPositionType PositionType;

	[Token(Token = "0x40014A5")]
	[FieldOffset(Offset = "0x1C")]
	public float AspectRatio;

	[Token(Token = "0x40014A6")]
	[FieldOffset(Offset = "0x20")]
	public LayoutWrap FlexWrap;

	[Token(Token = "0x40014A7")]
	[FieldOffset(Offset = "0x24")]
	public LayoutOverflow Overflow;

	[Token(Token = "0x40014A8")]
	[FieldOffset(Offset = "0x28")]
	public LayoutDisplay Display;

	[Token(Token = "0x40014A9")]
	[FieldOffset(Offset = "0x2C")]
	public float FlexGrow;

	[Token(Token = "0x40014AA")]
	[FieldOffset(Offset = "0x30")]
	public float FlexShrink;

	[Token(Token = "0x40014AB")]
	[FieldOffset(Offset = "0x34")]
	public LayoutValue FlexBasis;

	[Token(Token = "0x40014AC")]
	[FieldOffset(Offset = "0x3C")]
	public FixedBuffer9<LayoutValue> border;

	[Token(Token = "0x40014AD")]
	[FieldOffset(Offset = "0x84")]
	public FixedBuffer9<LayoutValue> position;

	[Token(Token = "0x40014AE")]
	[FieldOffset(Offset = "0xCC")]
	public FixedBuffer9<LayoutValue> margin;

	[Token(Token = "0x40014AF")]
	[FieldOffset(Offset = "0x114")]
	public FixedBuffer9<LayoutValue> padding;

	[Token(Token = "0x40014B0")]
	[FieldOffset(Offset = "0x15C")]
	public FixedBuffer2<LayoutValue> maxDimensions;

	[Token(Token = "0x40014B1")]
	[FieldOffset(Offset = "0x16C")]
	public FixedBuffer2<LayoutValue> minDimensions;

	[Token(Token = "0x40014B2")]
	[FieldOffset(Offset = "0x17C")]
	public FixedBuffer2<LayoutValue> dimensions;
}
