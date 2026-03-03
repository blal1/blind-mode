using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200006F")]
[DebuggerTypeProxy(typeof(UnsafeHashMapDebuggerTypeProxy<, >))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct UnsafeHashMap<TKey, TValue> : IDisposable, IEnumerable<KVPair<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x2000070")]
	public struct Enumerator : IEnumerator<KVPair<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x0")]
		internal HashMapHelper<TKey>.Enumerator m_Enumerator;

		[Token(Token = "0x17000047")]
		public KVPair<TKey, TValue> Current
		{
			[MethodImpl(256)]
			[Token(Token = "0x60001A6")]
			get
			{
				return default(KVPair<TKey, TValue>);
			}
		}

		[Token(Token = "0x17000048")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60001A7")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60001A3")]
		public void Dispose()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x60001A4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60001A5")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x40001E9")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal HashMapHelper<TKey> m_Data;

	[Token(Token = "0x17000044")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x600019A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000045")]
	public readonly int Count
	{
		[MethodImpl(256)]
		[Token(Token = "0x600019B")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000046")]
	public TValue this[TKey key]
	{
		[Token(Token = "0x600019E")]
		get
		{
			return (TValue)null;
		}
		[Token(Token = "0x600019F")]
		set
		{
		}
	}

	[Token(Token = "0x6000198")]
	public UnsafeHashMap(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x6000199")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600019C")]
	public bool TryAdd(TKey key, TValue item)
	{
		return default(bool);
	}

	[Token(Token = "0x600019D")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x60001A0")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x60001A1")]
	private IEnumerator<KVPair<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002EKVPair_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001A2")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
