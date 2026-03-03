using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;
using UnityEngine.UIElements.UIR;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002AE")]
internal class MeshGenerationNodeImpl : IDisposable
{
	[Token(Token = "0x4000AD1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GCHandle m_SelfHandle;

	[Token(Token = "0x4000AD2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private Entry m_ParentEntry;

	[Token(Token = "0x4000AD3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private EntryRecorder m_EntryRecorder;

	[Token(Token = "0x1700038E")]
	protected bool disposed
	{
		[Token(Token = "0x60012AB")]
		[Address(RVA = "0x588F60", Offset = "0x588160", VA = "0x180588F60")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x60012AC")]
		[Address(RVA = "0x588F70", Offset = "0x588170", VA = "0x180588F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x2B69360", Offset = "0x2B68560", VA = "0x182B69360")]
	public MeshGenerationNodeImpl()
	{
	}

	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x2B69220", Offset = "0x2B68420", VA = "0x182B69220")]
	public void Init(Entry parentEntry, EntryRecorder entryRecorder, bool safe)
	{
	}

	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x2B692D0", Offset = "0x2B684D0", VA = "0x182B692D0")]
	public void Reset()
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x2B69210", Offset = "0x2B68410", VA = "0x182B69210")]
	public void GetNode(out MeshGenerationNode node)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x2B69210", Offset = "0x2B68410", VA = "0x182B69210")]
	public void GetUnsafeNode(out UnsafeMeshGenerationNode node)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
	public Entry GetParentEntry()
	{
		return null;
	}

	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x2B69130", Offset = "0x2B68330", VA = "0x182B69130")]
	public void DrawMesh(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, [Optional] Texture texture, bool skipAtlas = false)
	{
	}

	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x2B69030", Offset = "0x2B68230", VA = "0x182B69030")]
	public void DrawGradients(NativeSlice<Vertex> vertices, NativeSlice<ushort> indices, VectorImage gradientsOwner)
	{
	}

	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x2B68FC0", Offset = "0x2B681C0", VA = "0x182B68FC0", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x2B68F80", Offset = "0x2B68180", VA = "0x182B68F80")]
	protected void Dispose(bool disposing)
	{
	}
}
