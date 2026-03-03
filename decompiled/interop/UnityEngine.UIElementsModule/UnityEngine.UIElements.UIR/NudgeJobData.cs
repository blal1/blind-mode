using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200053F")]
internal struct NudgeJobData
{
	[Token(Token = "0x40011EF")]
	[FieldOffset(Offset = "0x0")]
	public IntPtr headSrc;

	[Token(Token = "0x40011F0")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr headDst;

	[Token(Token = "0x40011F1")]
	[FieldOffset(Offset = "0x10")]
	public int headCount;

	[Token(Token = "0x40011F2")]
	[FieldOffset(Offset = "0x18")]
	public IntPtr tailSrc;

	[Token(Token = "0x40011F3")]
	[FieldOffset(Offset = "0x20")]
	public IntPtr tailDst;

	[Token(Token = "0x40011F4")]
	[FieldOffset(Offset = "0x28")]
	public int tailCount;

	[Token(Token = "0x40011F5")]
	[FieldOffset(Offset = "0x2C")]
	public Matrix4x4 transform;
}
