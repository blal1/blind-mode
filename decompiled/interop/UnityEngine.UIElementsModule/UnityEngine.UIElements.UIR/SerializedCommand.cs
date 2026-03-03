using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000517")]
internal struct SerializedCommand
{
	[Token(Token = "0x40010BB")]
	[FieldOffset(Offset = "0x0")]
	public SerializedCommandType type;

	[Token(Token = "0x40010BC")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr vertexBuffer;

	[Token(Token = "0x40010BD")]
	[FieldOffset(Offset = "0x10")]
	public IntPtr indexBuffer;

	[Token(Token = "0x40010BE")]
	[FieldOffset(Offset = "0x18")]
	public int firstRange;

	[Token(Token = "0x40010BF")]
	[FieldOffset(Offset = "0x1C")]
	public int rangeCount;

	[Token(Token = "0x40010C0")]
	[FieldOffset(Offset = "0x20")]
	public int textureName;

	[Token(Token = "0x40010C1")]
	[FieldOffset(Offset = "0x28")]
	public Texture texture;

	[Token(Token = "0x40010C2")]
	[FieldOffset(Offset = "0x30")]
	public int gpuDataOffset;

	[Token(Token = "0x40010C3")]
	[FieldOffset(Offset = "0x34")]
	public Vector4 gpuData0;

	[Token(Token = "0x40010C4")]
	[FieldOffset(Offset = "0x44")]
	public Vector4 gpuData1;
}
