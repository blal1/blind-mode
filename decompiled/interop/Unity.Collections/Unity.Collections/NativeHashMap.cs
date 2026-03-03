using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000039")]
[NativeContainer]
[DebuggerTypeProxy(typeof(NativeHashMapDebuggerTypeProxy<, >))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct NativeHashMap<TKey, TValue> : IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x4000196")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe HashMapHelper<TKey>* m_Data;

	[Token(Token = "0x1700002D")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000D4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700002E")]
	public readonly int Count
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000D5")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700002F")]
	public TValue this[TKey key]
	{
		[Token(Token = "0x60000DC")]
		get
		{
			return (TValue)null;
		}
		[Token(Token = "0x60000DD")]
		set
		{
		}
	}

	[Token(Token = "0x60000D2")]
	public NativeHashMap(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60000D3")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60000D6")]
	public void Clear()
	{
	}

	[Token(Token = "0x60000D7")]
	public bool TryAdd(TKey key, TValue item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000D8")]
	public void Add(TKey key, TValue item)
	{
	}

	[Token(Token = "0x60000D9")]
	public bool Remove(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DA")]
	public bool TryGetValue(TKey key, out TValue item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DB")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x60000DE")]
	private IEnumerator<KVPair<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002EKVPair_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000DF")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
