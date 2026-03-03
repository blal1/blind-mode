using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[StructLayout(2)]
[Token(Token = "0x2000076")]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeParallelHashMapData
{
	[Token(Token = "0x40001F7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	internal unsafe byte* values;

	[Token(Token = "0x40001F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	internal unsafe byte* keys;

	[Token(Token = "0x40001F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	internal unsafe byte* next;

	[Token(Token = "0x40001FA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	internal unsafe byte* buckets;

	[Token(Token = "0x40001FB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	internal int keyCapacity;

	[Token(Token = "0x40001FC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	internal int bucketCapacityMask;

	[Token(Token = "0x40001FD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	internal int allocatedIndexLength;

	[Token(Token = "0x1700004D")]
	internal unsafe int* firstFreeTLS
	{
		[Token(Token = "0x60001C2")]
		[Address(RVA = "0x22FD9C0", Offset = "0x22FCBC0", VA = "0x1822FD9C0")]
		get
		{
			//IL_0002: Expected I, but got O
			return (int*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x60001C3")]
	[Address(RVA = "0x1B6FAF0", Offset = "0x1B6ECF0", VA = "0x181B6FAF0")]
	internal static int GetBucketSize(int capacity)
	{
		return default(int);
	}

	[Token(Token = "0x60001C4")]
	[Address(RVA = "0x22FD860", Offset = "0x22FCA60", VA = "0x1822FD860")]
	internal static int GrowCapacity(int capacity)
	{
		return default(int);
	}

	[Token(Token = "0x60001C5")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal unsafe static void AllocateHashMap<TKey, TValue>(int length, int bucketLength, AllocatorManager.AllocatorHandle label, out UnsafeParallelHashMapData* outBuf) where TKey : struct where TValue : struct
	{
	}

	[Token(Token = "0x60001C6")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal unsafe static void ReallocateHashMap<TKey, TValue>(UnsafeParallelHashMapData* data, int newCapacity, int newBucketCapacity, AllocatorManager.AllocatorHandle label) where TKey : struct where TValue : struct
	{
	}

	[Token(Token = "0x60001C7")]
	[Address(RVA = "0x22FD770", Offset = "0x22FC970", VA = "0x1822FD770")]
	internal unsafe static void DeallocateHashMap(UnsafeParallelHashMapData* data, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60001C8")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	internal static int CalculateDataSize<TKey, TValue>(int length, int bucketLength, out int keyOffset, out int nextOffset, out int bucketOffset) where TKey : struct where TValue : struct
	{
		return default(int);
	}

	[Token(Token = "0x60001C9")]
	[Address(RVA = "0x22FD7E0", Offset = "0x22FC9E0", VA = "0x1822FD7E0")]
	internal unsafe static int GetCount(UnsafeParallelHashMapData* data)
	{
		return default(int);
	}

	[Token(Token = "0x60001CA")]
	[Address(RVA = "0x22FD870", Offset = "0x22FCA70", VA = "0x1822FD870")]
	internal unsafe static bool MoveNextSearch(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x60001CB")]
	[Address(RVA = "0x22FD910", Offset = "0x22FCB10", VA = "0x1822FD910")]
	internal unsafe static bool MoveNext(UnsafeParallelHashMapData* data, ref int bucketIndex, ref int nextIndex, out int index)
	{
		return default(bool);
	}
}
