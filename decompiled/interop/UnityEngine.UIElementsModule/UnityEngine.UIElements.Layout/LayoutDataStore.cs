using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;

namespace UnityEngine.UIElements.Layout;

[Token(Token = "0x200059C")]
internal struct LayoutDataStore : IDisposable
{
	[Token(Token = "0x200059D")]
	private struct Chunk
	{
		[Token(Token = "0x4001411")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe byte* Buffer;
	}

	[Token(Token = "0x200059E")]
	private struct ComponentDataStore : IDisposable
	{
		[Token(Token = "0x4001412")]
		[FieldOffset(Offset = "0x0")]
		public Allocator Allocator;

		[Token(Token = "0x4001413")]
		[FieldOffset(Offset = "0x4")]
		public int Size;

		[Token(Token = "0x4001414")]
		[FieldOffset(Offset = "0x8")]
		public int ComponentCountPerChunk;

		[Token(Token = "0x4001415")]
		[FieldOffset(Offset = "0xC")]
		public int ChunkCount;

		[Token(Token = "0x4001416")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		private unsafe Chunk* m_Chunks;

		[Token(Token = "0x600279C")]
		[Address(RVA = "0x2A69DA0", Offset = "0x2A68FA0", VA = "0x182A69DA0")]
		public ComponentDataStore(int size, Allocator allocator)
		{
		}

		[Token(Token = "0x600279D")]
		[Address(RVA = "0x2A69B50", Offset = "0x2A68D50", VA = "0x182A69B50", Slot = "4")]
		public void Dispose()
		{
		}

		[Token(Token = "0x600279E")]
		[Address(RVA = "0x2A69BE0", Offset = "0x2A68DE0", VA = "0x182A69BE0")]
		public unsafe byte* GetComponentDataPtr(int index)
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}

		[Token(Token = "0x600279F")]
		[Address(RVA = "0x2A69C10", Offset = "0x2A68E10", VA = "0x182A69C10")]
		public void ResizeCapacity(int capacity)
		{
		}
	}

	[Token(Token = "0x200059F")]
	private struct Data
	{
		[Token(Token = "0x4001417")]
		[FieldOffset(Offset = "0x0")]
		public int Capacity;

		[Token(Token = "0x4001418")]
		[FieldOffset(Offset = "0x4")]
		public int NextFreeIndex;

		[Token(Token = "0x4001419")]
		[FieldOffset(Offset = "0x8")]
		public int ComponentCount;

		[Token(Token = "0x400141A")]
		[FieldOffset(Offset = "0x10")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe int* Versions;

		[Token(Token = "0x400141B")]
		[FieldOffset(Offset = "0x18")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe ComponentDataStore* Components;
	}

	[Token(Token = "0x400140E")]
	private const int k_ChunkSize = 32768;

	[Token(Token = "0x400140F")]
	[FieldOffset(Offset = "0x0")]
	private readonly Allocator m_Allocator;

	[Token(Token = "0x4001410")]
	[FieldOffset(Offset = "0x8")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe Data* m_Data;

	[Token(Token = "0x17000A1A")]
	public bool IsValid
	{
		[Token(Token = "0x600278E")]
		[Address(RVA = "0x1C3E770", Offset = "0x1C3D970", VA = "0x181C3E770")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600278F")]
	[Address(RVA = "0x2A6E9B0", Offset = "0x2A6DBB0", VA = "0x182A6E9B0")]
	public LayoutDataStore(ComponentType[] components, int initialCapacity, Allocator allocator)
	{
	}

	[Token(Token = "0x6002790")]
	[Address(RVA = "0x2A6E330", Offset = "0x2A6D530", VA = "0x182A6E330", Slot = "4")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6002791")]
	[Address(RVA = "0x2A6E470", Offset = "0x2A6D670", VA = "0x182A6E470")]
	public bool Exists(in LayoutHandle handle)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6002792")]
	[Address(RVA = "0x2A6E5E0", Offset = "0x2A6D7E0", VA = "0x182A6E5E0")]
	internal unsafe readonly void* GetComponentDataPtr(int index, int componentIndex)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	[Token(Token = "0x6002793")]
	[Address(RVA = "0x2A6E0F0", Offset = "0x2A6D2F0", VA = "0x182A6E0F0")]
	private unsafe LayoutHandle Allocate(byte** data, int count)
	{
		return default(LayoutHandle);
	}

	[Token(Token = "0x6002794")]
	[Address(RVA = "0x2A6E4B0", Offset = "0x2A6D6B0", VA = "0x182A6E4B0")]
	public void Free(in LayoutHandle handle)
	{
	}

	[Token(Token = "0x6002795")]
	[Address(RVA = "0x2A6E970", Offset = "0x2A6DB70", VA = "0x182A6E970")]
	private unsafe static void SetNextFreeIndex(ComponentDataStore* ptr, int index, int value)
	{
	}

	[Token(Token = "0x6002796")]
	[Address(RVA = "0x2A6E630", Offset = "0x2A6D830", VA = "0x182A6E630")]
	private unsafe static int GetNextFreeIndex(ComponentDataStore* ptr, int index)
	{
		return default(int);
	}

	[Token(Token = "0x6002797")]
	[Address(RVA = "0x2A6E670", Offset = "0x2A6D870", VA = "0x182A6E670")]
	private void IncreaseCapacity()
	{
	}

	[Token(Token = "0x6002798")]
	[Address(RVA = "0x2A6E790", Offset = "0x2A6D990", VA = "0x182A6E790")]
	private void ResizeCapacity(int capacity)
	{
	}

	[Token(Token = "0x6002799")]
	[Address(RVA = "0x2A6E6B0", Offset = "0x2A6D8B0", VA = "0x182A6E6B0")]
	private unsafe static void* ResizeArray(void* fromPtr, long fromCount, long toCount, long size, int align, Allocator allocator)
	{
		//IL_0002: Expected I, but got O
		return (void*)unchecked((nint)null);
	}

	[Token(Token = "0x600279A")]
	public LayoutHandle Allocate<T0>(in T0 component0) where T0 : struct
	{
		return default(LayoutHandle);
	}

	[Token(Token = "0x600279B")]
	public LayoutHandle Allocate<T0, T1, T2, T3>(in T0 component0, in T1 component1, in T2 component2, in T3 component3) where T0 : struct where T1 : struct where T2 : struct where T3 : struct
	{
		return default(LayoutHandle);
	}
}
