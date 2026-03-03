using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000541")]
internal struct CopyMeshJobData
{
	[Token(Token = "0x400120B")]
	[FieldOffset(Offset = "0x0")]
	public IntPtr vertSrc;

	[Token(Token = "0x400120C")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr vertDst;

	[Token(Token = "0x400120D")]
	[FieldOffset(Offset = "0x10")]
	public int vertCount;

	[Token(Token = "0x400120E")]
	[FieldOffset(Offset = "0x18")]
	public IntPtr indexSrc;

	[Token(Token = "0x400120F")]
	[FieldOffset(Offset = "0x20")]
	public IntPtr indexDst;

	[Token(Token = "0x4001210")]
	[FieldOffset(Offset = "0x28")]
	public int indexCount;

	[Token(Token = "0x4001211")]
	[FieldOffset(Offset = "0x2C")]
	public int indexOffset;
}
