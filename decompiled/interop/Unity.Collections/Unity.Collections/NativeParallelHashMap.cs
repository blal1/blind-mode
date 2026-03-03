using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000046")]
[NativeContainer]
[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy<, >))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
{
	typeof(int),
	typeof(int)
})]
public struct NativeParallelHashMap<TKey, TValue> : IDisposable, IEnumerable<KeyValue<TKey, TValue>>, IEnumerable where TKey : struct, IEquatable<TKey> where TValue : struct
{
	[Token(Token = "0x2000047")]
	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[DebuggerTypeProxy(typeof(NativeParallelHashMapDebuggerTypeProxy<, >))]
	[DebuggerDisplay("Count = {m_HashMapData.Count()}, Capacity = {m_HashMapData.Capacity}, IsCreated = {m_HashMapData.IsCreated}, IsEmpty = {IsEmpty}")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct ReadOnly : IEnumerable<KeyValue<TKey, TValue>>, IEnumerable
	{
		[Token(Token = "0x400019E")]
		[FieldOffset(Offset = "0x0")]
		internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData;

		[Token(Token = "0x6000121")]
		internal ReadOnly(UnsafeParallelHashMap<TKey, TValue> hashMapData)
		{
		}

		[Token(Token = "0x6000122")]
		public readonly bool TryGetValue(TKey key, out TValue item)
		{
			return default(bool);
		}

		[Token(Token = "0x6000123")]
		public readonly bool ContainsKey(TKey key)
		{
			return default(bool);
		}

		[Token(Token = "0x6000124")]
		private IEnumerator<KeyValue<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002ELowLevel_002EUnsafe_002EKeyValue_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x6000125")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x2000048")]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[DebuggerDisplay("Capacity = {m_Writer.Capacity}")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[]
	{
		typeof(int),
		typeof(int)
	})]
	public struct ParallelWriter
	{
		[Token(Token = "0x400019F")]
		[FieldOffset(Offset = "0x0")]
		internal UnsafeParallelHashMap<TKey, TValue>.ParallelWriter m_Writer;

		[Token(Token = "0x6000126")]
		public bool TryAdd(TKey key, TValue item)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000049")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	public struct Enumerator : IEnumerator<KeyValue<TKey, TValue>>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40001A0")]
		[FieldOffset(Offset = "0x0")]
		internal UnsafeParallelHashMapDataEnumerator m_Enumerator;

		[Token(Token = "0x1700003B")]
		public KeyValue<TKey, TValue> Current
		{
			[MethodImpl(256)]
			[Token(Token = "0x600012A")]
			get
			{
				return default(KeyValue<TKey, TValue>);
			}
		}

		[Token(Token = "0x1700003C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600012B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000127")]
		public void Dispose()
		{
		}

		[MethodImpl(256)]
		[Token(Token = "0x6000128")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000129")]
		public void Reset()
		{
		}
	}

	[Token(Token = "0x400019D")]
	[FieldOffset(Offset = "0x0")]
	internal UnsafeParallelHashMap<TKey, TValue> m_HashMapData;

	[Token(Token = "0x17000038")]
	public int Capacity
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000111")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x6000112")]
		set
		{
		}
	}

	[Token(Token = "0x17000039")]
	public TValue this[TKey key]
	{
		[Token(Token = "0x6000118")]
		get
		{
			return (TValue)null;
		}
		[Token(Token = "0x6000119")]
		set
		{
		}
	}

	[Token(Token = "0x1700003A")]
	public readonly bool IsCreated
	{
		[Token(Token = "0x600011A")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600010F")]
	public NativeParallelHashMap(int capacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x6000110")]
	public int Count()
	{
		return default(int);
	}

	[Token(Token = "0x6000113")]
	public bool TryAdd(TKey key, TValue item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000114")]
	public void Add(TKey key, TValue item)
	{
	}

	[Token(Token = "0x6000115")]
	public bool Remove(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x6000116")]
	public bool TryGetValue(TKey key, out TValue item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000117")]
	public bool ContainsKey(TKey key)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	public void Dispose()
	{
	}

	[Token(Token = "0x600011C")]
	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}

	[Token(Token = "0x600011D")]
	public ReadOnly AsReadOnly()
	{
		return default(ReadOnly);
	}

	[Token(Token = "0x600011E")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x600011F")]
	private IEnumerator<KeyValue<TKey, TValue>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002ECollections_002ELowLevel_002EUnsafe_002EKeyValue_003CTKey_002CTValue_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000120")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
