using System;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000079")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
internal struct UnsafeParallelHashMapBase<TKey, TValue> where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x60001CE")]
	internal unsafe static void Clear(UnsafeParallelHashMapData* data)
	{
	}

	[Token(Token = "0x60001CF")]
	internal unsafe static int AllocEntry(UnsafeParallelHashMapData* data, int threadIndex)
	{
		return default(int);
	}

	[Token(Token = "0x60001D0")]
	internal unsafe static void FreeEntry(UnsafeParallelHashMapData* data, int idx, int threadIndex)
	{
	}

	[Token(Token = "0x60001D1")]
	internal unsafe static bool TryAddAtomic(UnsafeParallelHashMapData* data, TKey key, TValue item, int threadIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D2")]
	internal unsafe static bool TryAdd(UnsafeParallelHashMapData* data, TKey key, TValue item, bool isMultiHashMap, AllocatorManager.AllocatorHandle allocation)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D3")]
	internal unsafe static int Remove(UnsafeParallelHashMapData* data, TKey key, bool isMultiHashMap)
	{
		return default(int);
	}

	[Token(Token = "0x60001D4")]
	internal unsafe static void Remove(UnsafeParallelHashMapData* data, NativeParallelMultiHashMapIterator<TKey> it)
	{
	}

	[Token(Token = "0x60001D5")]
	internal unsafe static bool TryGetFirstValueAtomic(UnsafeParallelHashMapData* data, TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D6")]
	internal unsafe static bool TryGetNextValueAtomic(UnsafeParallelHashMapData* data, out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
	{
		return default(bool);
	}

	[Token(Token = "0x60001D7")]
	internal unsafe static bool SetValue(UnsafeParallelHashMapData* data, ref NativeParallelMultiHashMapIterator<TKey> it, ref TValue item)
	{
		return default(bool);
	}
}
