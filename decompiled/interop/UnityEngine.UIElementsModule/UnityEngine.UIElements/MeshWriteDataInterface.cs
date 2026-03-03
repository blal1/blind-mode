using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200027C")]
internal struct MeshWriteDataInterface
{
	[Token(Token = "0x40009BD")]
	[FieldOffset(Offset = "0x0")]
	public IntPtr vertices;

	[Token(Token = "0x40009BE")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr indices;

	[Token(Token = "0x40009BF")]
	[FieldOffset(Offset = "0x10")]
	public int vertexCount;

	[Token(Token = "0x40009C0")]
	[FieldOffset(Offset = "0x14")]
	public int indexCount;
}
