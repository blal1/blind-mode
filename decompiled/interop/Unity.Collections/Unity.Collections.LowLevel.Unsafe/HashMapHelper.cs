using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200006D")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
internal struct HashMapHelper<TKey> where TKey : struct, IEquatable<TKey>
{
	[Token(Token = "0x200006E")]
	internal struct Enumerator
	{
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe HashMapHelper<TKey>* m_Data;

		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x0")]
		internal int m_Index;

		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x0")]
		internal int m_BucketIndex;

		[Token(Token = "0x40001E8")]
		[FieldOffset(Offset = "0x0")]
		internal int m_NextIndex;

		[Token(Token = "0x6000194")]
		internal unsafe Enumerator(HashMapHelper<TKey>* data)
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000195")]
		internal bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000196")]
		internal void Reset()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000197")]
		internal KVPair<TKey, TValue> GetCurrent<TValue>() where TValue : struct
		{
			return default(KVPair<TKey, TValue>);
		}
	}

	[Token(Token = "0x40001D8")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe byte* Ptr;

	[Token(Token = "0x40001D9")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe TKey* Keys;

	[Token(Token = "0x40001DA")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe int* Next;

	[Token(Token = "0x40001DB")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe int* Buckets;

	[Token(Token = "0x40001DC")]
	[FieldOffset(Offset = "0x0")]
	internal int Count;

	[Token(Token = "0x40001DD")]
	[FieldOffset(Offset = "0x0")]
	internal int Capacity;

	[Token(Token = "0x40001DE")]
	[FieldOffset(Offset = "0x0")]
	internal int Log2MinGrowth;

	[Token(Token = "0x40001DF")]
	[FieldOffset(Offset = "0x0")]
	internal int BucketCapacity;

	[Token(Token = "0x40001E0")]
	[FieldOffset(Offset = "0x0")]
	internal int AllocatedIndex;

	[Token(Token = "0x40001E1")]
	[FieldOffset(Offset = "0x0")]
	internal int FirstFreeIdx;

	[Token(Token = "0x40001E2")]
	[FieldOffset(Offset = "0x0")]
	internal int SizeOfTValue;

	[Token(Token = "0x40001E3")]
	[FieldOffset(Offset = "0x0")]
	internal AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x40001E4")]
	internal const int kMinimumCapacity = 256;

	[Token(Token = "0x17000043")]
	internal readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000184")]
		get
		{
			return default(bool);
		}
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000182")]
	internal int CalcCapacityCeilPow2(int capacity)
	{
		return default(int);
	}

	[Token(Token = "0x6000183")]
	internal static int GetBucketSize(int capacity)
	{
		return default(int);
	}

	[Token(Token = "0x6000185")]
	internal void Clear()
	{
	}

	[Token(Token = "0x6000186")]
	internal void Init(int capacity, int sizeOfValueT, int minGrowth, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x6000187")]
	internal void Dispose()
	{
	}

	[Token(Token = "0x6000188")]
	internal unsafe static HashMapHelper<TKey>* Alloc(int capacity, int sizeOfValueT, int minGrowth, AllocatorManager.AllocatorHandle allocator)
	{
		//IL_0002: Expected I, but got O
		return (HashMapHelper<TKey>*)unchecked((nint)null);
	}

	[Token(Token = "0x6000189")]
	internal unsafe static void Free(HashMapHelper<TKey>* data)
	{
	}

	[Token(Token = "0x600018A")]
	internal void Resize(int newCapacity)
	{
	}

	[Token(Token = "0x600018B")]
	internal void ResizeExact(int newCapacity, int newBucketCapacity)
	{
	}

	[Token(Token = "0x600018C")]
	internal static int CalculateDataSize(int capacity, int bucketCapacity, int sizeOfTValue, out int outKeyOffset, out int outNextOffset, out int outBucketOffset)
	{
		return default(int);
	}

	[MethodImpl(256)]
	[Token(Token = "0x600018D")]
	private int GetBucket(in TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x600018E")]
	internal int TryAdd(in TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x600018F")]
	internal int Find(TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x6000190")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	internal bool TryGetValue<TValue>(TKey key, out TValue item) where TValue : struct
	{
		return default(bool);
	}

	[Token(Token = "0x6000191")]
	internal int TryRemove(TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x6000192")]
	internal bool MoveNextSearch(ref int bucketIndex, ref int nextIndex, out int index)
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000193")]
	internal bool MoveNext(ref int bucketIndex, ref int nextIndex, out int index)
	{
		return default(bool);
	}
}
