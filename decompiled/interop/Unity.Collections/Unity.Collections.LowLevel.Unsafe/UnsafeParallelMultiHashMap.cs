using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000080")]
[DebuggerTypeProxy(typeof(UnsafeParallelMultiHashMapDebuggerTypeProxy<, >))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct UnsafeParallelMultiHashMap<TKey, TValue> : IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x400020E")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	[Token(Token = "0x400020F")]
	[FieldOffset(Offset = "0x0")]
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	[Token(Token = "0x17000053")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001F5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001EE")]
	public UnsafeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60001EF")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001F0")]
	public void Add(TKey key, TValue item)
	{
	}

	[Token(Token = "0x60001F1")]
	public int Remove(TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x60001F2")]
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it)
	{
	}

	[Token(Token = "0x60001F3")]
	public readonly bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F4")]
	public readonly bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
	{
		return default(bool);
	}

	[Token(Token = "0x60001F6")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001F7")]
	private IEnumerator<KeyValue<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002ELowLevel_002EUnsafe_002EKeyValue_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001F8")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
