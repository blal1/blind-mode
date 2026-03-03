using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004D5")]
internal struct VectorImageVertex
{
	[Token(Token = "0x4000FCF")]
	[FieldOffset(Offset = "0x0")]
	public Vector3 position;

	[Token(Token = "0x4000FD0")]
	[FieldOffset(Offset = "0xC")]
	public Color32 tint;

	[Token(Token = "0x4000FD1")]
	[FieldOffset(Offset = "0x10")]
	public Vector2 uv;

	[Token(Token = "0x4000FD2")]
	[FieldOffset(Offset = "0x18")]
	public uint settingIndex;

	[Token(Token = "0x4000FD3")]
	[FieldOffset(Offset = "0x1C")]
	public Color32 flags;

	[Token(Token = "0x4000FD4")]
	[FieldOffset(Offset = "0x20")]
	public Vector4 circle;
}
