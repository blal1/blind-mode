using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200007C")]
[DebuggerDisplay("Count = {Count()}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeParallelHashMapDebuggerTypeProxy<, >))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct UnsafeParallelHashMap<TKey, TValue> : IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x200007D")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct ParallelWriter
	{
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe UnsafeParallelHashMapData* m_Buffer;

		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x0")]
		[NativeSetThreadIndex]
		internal int m_ThreadIndex;

		[Token(Token = "0x60001EC")]
		public bool TryAdd(TKey key, TValue item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x4000208")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	[Token(Token = "0x4000209")]
	[FieldOffset(Offset = "0x0")]
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	[Token(Token = "0x17000050")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001DF")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000051")]
	public int Capacity
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001E1")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60001E2")]
		set
		{
		}
	}

	[Token(Token = "0x17000052")]
	public TKey this[TKey key]
	{
		[Token(Token = "0x60001E7")]
		set
		{
		}
	}

	[Token(Token = "0x60001DE")]
	public UnsafeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60001E0")]
	public readonly int Count()
	{
		return default(int);
	}

	[Token(Token = "0x60001E3")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001E4")]
	public bool Remove(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E5")]
	public bool TryGetValue(TKey key, out TValue item)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E6")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x60001E8")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001E9")]
	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	[Token(Token = "0x60001EA")]
	private IEnumerator<KeyValue<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002ELowLevel_002EUnsafe_002EKeyValue_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001EB")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
