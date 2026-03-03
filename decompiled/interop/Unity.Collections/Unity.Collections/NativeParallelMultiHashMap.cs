using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x200004C")]
[NativeContainer]
[DebuggerTypeProxy(typeof(NativeParallelMultiHashMapDebuggerTypeProxy<, >))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct NativeParallelMultiHashMap<TKey, TValue> : IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x40001A4")]
	[FieldOffset(Offset = "0x0")]
	internal UnsafeParallelMultiHashMap<TKey, TValue> m_MultiHashMapData;

	[Token(Token = "0x1700003D")]
	public readonly bool IsCreated
	{
		[Token(Token = "0x6000133")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600012C")]
	public NativeParallelMultiHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x600012D")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal void Initialize<U>(int capacity, ref U allocator) where U : struct, AllocatorManager.IAllocator
	{
	}

	[Token(Token = "0x600012E")]
	public void Add(TKey key, TValue item)
	{
	}

	[Token(Token = "0x600012F")]
	public int Remove(TKey key)
	{
		return default(int);
	}

	[Token(Token = "0x6000130")]
	public void Remove(NativeParallelMultiHashMapIterator<TKey> it)
	{
	}

	[Token(Token = "0x6000131")]
	public bool TryGetFirstValue(TKey key, out TValue item, out NativeParallelMultiHashMapIterator<TKey> it)
	{
		return default(bool);
	}

	[Token(Token = "0x6000132")]
	public bool TryGetNextValue(out TValue item, ref NativeParallelMultiHashMapIterator<TKey> it)
	{
		return default(bool);
	}

	[Token(Token = "0x6000134")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000135")]
	private IEnumerator<KeyValue<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002ELowLevel_002EUnsafe_002EKeyValue_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000136")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
