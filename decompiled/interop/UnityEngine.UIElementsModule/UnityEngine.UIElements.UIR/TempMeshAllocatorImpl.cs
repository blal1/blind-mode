using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Unity.Collections;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200056F")]
internal class TempMeshAllocatorImpl : IDisposable
{
	[Token(Token = "0x2000570")]
	private struct ThreadData
	{
		[Token(Token = "0x400135C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public List<IntPtr> allocations;
	}

	[Token(Token = "0x4001357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private GCHandle m_GCHandle;

	[Token(Token = "0x4001358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private ThreadData[] m_ThreadData;

	[Token(Token = "0x4001359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private TempAllocator<Vertex> m_VertexPool;

	[Token(Token = "0x400135A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private TempAllocator<ushort> m_IndexPool;

	[Token(Token = "0x170009C1")]
	protected bool disposed
	{
		[Token(Token = "0x6002681")]
		[Address(RVA = "0x51FEA0", Offset = "0x51F0A0", VA = "0x18051FEA0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6002682")]
		[Address(RVA = "0x5FDF60", Offset = "0x5FD160", VA = "0x1805FDF60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x600267C")]
	[Address(RVA = "0x2A62E80", Offset = "0x2A62080", VA = "0x182A62E80")]
	public TempMeshAllocatorImpl()
	{
	}

	[Token(Token = "0x600267D")]
	[Address(RVA = "0x2A62D10", Offset = "0x2A61F10", VA = "0x182A62D10")]
	public void CreateNativeHandle(out TempMeshAllocator allocator)
	{
	}

	[Token(Token = "0x600267E")]
	private NativeSlice<T> Allocate<T>(int count, int alignment) where T : struct
	{
		return default(NativeSlice<T>);
	}

	[Token(Token = "0x600267F")]
	[Address(RVA = "0x2A628A0", Offset = "0x2A61AA0", VA = "0x182A628A0")]
	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex> vertices, out NativeSlice<ushort> indices)
	{
	}

	[Token(Token = "0x6002680")]
	[Address(RVA = "0x2A62B10", Offset = "0x2A61D10", VA = "0x182A62B10")]
	public void Clear()
	{
	}

	[Token(Token = "0x6002683")]
	[Address(RVA = "0x2A62D20", Offset = "0x2A61F20", VA = "0x182A62D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002684")]
	[Address(RVA = "0x2A62DE0", Offset = "0x2A61FE0", VA = "0x182A62DE0")]
	protected void Dispose(bool disposing)
	{
	}
}
