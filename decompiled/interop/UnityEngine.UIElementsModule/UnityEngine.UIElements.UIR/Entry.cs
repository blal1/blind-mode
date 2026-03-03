using System;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000539")]
internal class Entry
{
	[Token(Token = "0x40011C9")]
	[FieldOffset(Offset = "0x10")]
	public EntryType type;

	[Token(Token = "0x40011CA")]
	[FieldOffset(Offset = "0x12")]
	public EntryFlags flags;

	[Token(Token = "0x40011CB")]
	[FieldOffset(Offset = "0x18")]
	public NativeSlice<Vertex> vertices;

	[Token(Token = "0x40011CC")]
	[FieldOffset(Offset = "0x28")]
	public NativeSlice<ushort> indices;

	[Token(Token = "0x40011CD")]
	[FieldOffset(Offset = "0x38")]
	public Texture texture;

	[Token(Token = "0x40011CE")]
	[FieldOffset(Offset = "0x40")]
	public float textScale;

	[Token(Token = "0x40011CF")]
	[FieldOffset(Offset = "0x44")]
	public float fontSharpness;

	[Token(Token = "0x40011D0")]
	[FieldOffset(Offset = "0x48")]
	public VectorImage gradientsOwner;

	[Token(Token = "0x40011D1")]
	[FieldOffset(Offset = "0x50")]
	public Material material;

	[Token(Token = "0x40011D2")]
	[FieldOffset(Offset = "0x58")]
	public Action immediateCallback;

	[Token(Token = "0x40011D3")]
	[FieldOffset(Offset = "0x60")]
	public Entry nextSibling;

	[Token(Token = "0x40011D4")]
	[FieldOffset(Offset = "0x68")]
	public Entry firstChild;

	[Token(Token = "0x40011D5")]
	[FieldOffset(Offset = "0x70")]
	public Entry lastChild;

	[Token(Token = "0x600252D")]
	[Address(RVA = "0x2A4B000", Offset = "0x2A4A200", VA = "0x182A4B000")]
	public void Reset()
	{
	}

	[Token(Token = "0x600252E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Entry()
	{
	}
}
