using Il2CppDummyDll;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x2000591")]
internal struct LayoutCachedMeasurement
{
	[Token(Token = "0x40013EC")]
	[FieldOffset(Offset = "0x0")]
	public static LayoutCachedMeasurement Default;

	[Token(Token = "0x40013ED")]
	[FieldOffset(Offset = "0x0")]
	public float AvailableWidth;

	[Token(Token = "0x40013EE")]
	[FieldOffset(Offset = "0x4")]
	public float AvailableHeight;

	[Token(Token = "0x40013EF")]
	[FieldOffset(Offset = "0x8")]
	public float ParentWidth;

	[Token(Token = "0x40013F0")]
	[FieldOffset(Offset = "0xC")]
	public float ParentHeight;

	[Token(Token = "0x40013F1")]
	[FieldOffset(Offset = "0x10")]
	public LayoutMeasureMode WidthMeasureMode;

	[Token(Token = "0x40013F2")]
	[FieldOffset(Offset = "0x14")]
	public LayoutMeasureMode HeightMeasureMode;

	[Token(Token = "0x40013F3")]
	[FieldOffset(Offset = "0x18")]
	public float ComputedWidth;

	[Token(Token = "0x40013F4")]
	[FieldOffset(Offset = "0x1C")]
	public float ComputedHeight;
}
