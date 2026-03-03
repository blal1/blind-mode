using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000222")]
public static class PointerId
{
	[Token(Token = "0x40008BA")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int maxPointers;

	[Token(Token = "0x40008BB")]
	[FieldOffset(Offset = "0x4")]
	public static readonly int invalidPointerId;

	[Token(Token = "0x40008BC")]
	[FieldOffset(Offset = "0x8")]
	public static readonly int mousePointerId;

	[Token(Token = "0x40008BD")]
	[FieldOffset(Offset = "0xC")]
	public static readonly int touchPointerIdBase;

	[Token(Token = "0x40008BE")]
	[FieldOffset(Offset = "0x10")]
	public static readonly int touchPointerCount;

	[Token(Token = "0x40008BF")]
	[FieldOffset(Offset = "0x14")]
	public static readonly int penPointerIdBase;

	[Token(Token = "0x40008C0")]
	[FieldOffset(Offset = "0x18")]
	public static readonly int penPointerCount;

	[Token(Token = "0x40008C1")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly int[] hoveringPointers;
}
