using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200053A")]
internal class EntryRecorder
{
	[Token(Token = "0x40011D6")]
	[FieldOffset(Offset = "0x10")]
	private EntryPool m_EntryPool;

	[Token(Token = "0x600252F")]
	[Address(RVA = "0x2A4AF80", Offset = "0x2A4A180", VA = "0x182A4AF80")]
	public EntryRecorder(EntryPool entryPool)
	{
	}

	[Token(Token = "0x6002530")]
	[Address(RVA = "0x2A4AA60", Offset = "0x2A49C60", VA = "0x182A4AA60")]
	public void DrawMesh(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, bool skipAtlas)
	{
	}

	[Token(Token = "0x6002531")]
	[Address(RVA = "0x2A4AB00", Offset = "0x2A49D00", VA = "0x182A4AB00")]
	public void DrawRasterText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, bool multiChannel)
	{
	}

	[Token(Token = "0x6002532")]
	[Address(RVA = "0x2A4ABA0", Offset = "0x2A49DA0", VA = "0x182A4ABA0")]
	public void DrawSdfText(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, Texture texture, float scale, float sharpness)
	{
	}

	[Token(Token = "0x6002533")]
	[Address(RVA = "0x2A4A950", Offset = "0x2A49B50", VA = "0x182A4A950")]
	public void DrawGradients(Entry parentEntry, NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner)
	{
	}

	[Token(Token = "0x6002534")]
	[Address(RVA = "0x2A4A9E0", Offset = "0x2A49BE0", VA = "0x182A4A9E0")]
	public void DrawImmediate(Entry parentEntry, Action callback, bool cullingEnabled)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002535")]
	[Address(RVA = "0x2A4A910", Offset = "0x2A49B10", VA = "0x182A4A910")]
	public void DrawChildren(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002536")]
	[Address(RVA = "0x2A4A850", Offset = "0x2A49A50", VA = "0x182A4A850")]
	public void BeginStencilMask(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002537")]
	[Address(RVA = "0x2A4AC40", Offset = "0x2A49E40", VA = "0x182A4AC40")]
	public void EndStencilMask(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002538")]
	[Address(RVA = "0x2A4ADD0", Offset = "0x2A49FD0", VA = "0x182A4ADD0")]
	public void PopStencilMask(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002539")]
	[Address(RVA = "0x2A4AE10", Offset = "0x2A4A010", VA = "0x182A4AE10")]
	public void PushClippingRect(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600253A")]
	[Address(RVA = "0x2A4ACD0", Offset = "0x2A49ED0", VA = "0x182A4ACD0")]
	public void PopClippingRect(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600253B")]
	[Address(RVA = "0x2A4AF40", Offset = "0x2A4A140", VA = "0x182A4AF40")]
	public void PushScissors(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600253C")]
	[Address(RVA = "0x2A4AD90", Offset = "0x2A49F90", VA = "0x182A4AD90")]
	public void PopScissors(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600253D")]
	[Address(RVA = "0x2A4AEC0", Offset = "0x2A4A0C0", VA = "0x182A4AEC0")]
	public void PushGroupMatrix(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600253E")]
	[Address(RVA = "0x2A4AD50", Offset = "0x2A49F50", VA = "0x182A4AD50")]
	public void PopGroupMatrix(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600253F")]
	[Address(RVA = "0x2A4AF00", Offset = "0x2A4A100", VA = "0x182A4AF00")]
	public void PushRenderTexture(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002540")]
	[Address(RVA = "0x2A4A890", Offset = "0x2A49A90", VA = "0x182A4A890")]
	public void BlitAndPopRenderTexture(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002541")]
	[Address(RVA = "0x2A4AE50", Offset = "0x2A4A050", VA = "0x182A4AE50")]
	public void PushDefaultMaterial(Entry parentEntry, Material material)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002542")]
	[Address(RVA = "0x2A4AD10", Offset = "0x2A49F10", VA = "0x182A4AD10")]
	public void PopDefaultMaterial(Entry parentEntry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002543")]
	[Address(RVA = "0x2A4A8D0", Offset = "0x2A49AD0", VA = "0x182A4A8D0")]
	public void CutRenderChain(Entry parentEntry)
	{
	}

	[Token(Token = "0x6002544")]
	[Address(RVA = "0x2A4AC80", Offset = "0x2A49E80", VA = "0x182A4AC80")]
	public Entry InsertPlaceholder(Entry parentEntry)
	{
		return null;
	}

	[Token(Token = "0x6002545")]
	[Address(RVA = "0x2A4A5A0", Offset = "0x2A497A0", VA = "0x182A4A5A0")]
	private static void AppendMeshEntry(Entry parentEntry, Entry entry)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002546")]
	[Address(RVA = "0x2A4A780", Offset = "0x2A49980", VA = "0x182A4A780")]
	private static void Append(Entry parentEntry, Entry entry)
	{
	}
}
