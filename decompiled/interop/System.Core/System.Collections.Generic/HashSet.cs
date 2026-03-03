using System.Diagnostics;
using System.Runtime.Serialization;
using Il2CppDummyDll;

namespace System.Collections.Generic;

[Serializable]
[Token(Token = "0x200003D")]
[DebuggerTypeProxy(typeof(System.Collections.Generic.ICollectionDebugView<>))]
[DebuggerDisplay("Count = {Count}")]
public class HashSet<T> : ICollection<T>, IEnumerable<T>, IEnumerable, ISet<T>, IReadOnlyCollection<T>, ISerializable, IDeserializationCallback
{
	[Token(Token = "0x200003E")]
	internal struct Slot
	{
		[Token(Token = "0x400011A")]
		[FieldOffset(Offset = "0x0")]
		internal int hashCode;

		[Token(Token = "0x400011B")]
		[FieldOffset(Offset = "0x0")]
		internal int next;

		[Token(Token = "0x400011C")]
		[FieldOffset(Offset = "0x0")]
		internal T value;
	}

	[Serializable]
	[Token(Token = "0x200003F")]
	public struct Enumerator : IEnumerator<T>, IDisposable, IEnumerator
	{
		[Token(Token = "0x400011D")]
		[FieldOffset(Offset = "0x0")]
		private HashSet<T> _set;

		[Token(Token = "0x400011E")]
		[FieldOffset(Offset = "0x0")]
		private int _index;

		[Token(Token = "0x400011F")]
		[FieldOffset(Offset = "0x0")]
		private int _version;

		[Token(Token = "0x4000120")]
		[FieldOffset(Offset = "0x0")]
		private T _current;

		[Token(Token = "0x17000033")]
		public T Current
		{
			[Token(Token = "0x600016A")]
			get
			{
				return (T)null;
			}
		}

		[Token(Token = "0x17000034")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600016B")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000167")]
		internal Enumerator(HashSet<T> set)
		{
		}

		[Token(Token = "0x6000168")]
		public void Dispose()
		{
		}

		[Token(Token = "0x6000169")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600016C")]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400010B")]
	private const int Lower31BitMask = 2147483647;

	[Token(Token = "0x400010C")]
	private const int StackAllocThreshold = 100;

	[Token(Token = "0x400010D")]
	private const int ShrinkThreshold = 3;

	[Token(Token = "0x400010E")]
	private const string CapacityName = "Capacity";

	[Token(Token = "0x400010F")]
	private const string ElementsName = "Elements";

	[Token(Token = "0x4000110")]
	private const string ComparerName = "Comparer";

	[Token(Token = "0x4000111")]
	private const string VersionName = "Version";

	[Token(Token = "0x4000112")]
	[FieldOffset(Offset = "0x0")]
	private int[] _buckets;

	[Token(Token = "0x4000113")]
	[FieldOffset(Offset = "0x0")]
	private Slot[] _slots;

	[Token(Token = "0x4000114")]
	[FieldOffset(Offset = "0x0")]
	private int _count;

	[Token(Token = "0x4000115")]
	[FieldOffset(Offset = "0x0")]
	private int _lastIndex;

	[Token(Token = "0x4000116")]
	[FieldOffset(Offset = "0x0")]
	private int _freeList;

	[Token(Token = "0x4000117")]
	[FieldOffset(Offset = "0x0")]
	private IEqualityComparer<T> _comparer;

	[Token(Token = "0x4000118")]
	[FieldOffset(Offset = "0x0")]
	private int _version;

	[Token(Token = "0x4000119")]
	[FieldOffset(Offset = "0x0")]
	private SerializationInfo _siInfo;

	[Token(Token = "0x17000030")]
	public int Count
	{
		[Token(Token = "0x6000152")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000031")]
	private bool System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EIsReadOnly
	{
		[Token(Token = "0x6000153")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000032")]
	public IEqualityComparer<T> Comparer
	{
		[Token(Token = "0x600015E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000145")]
	public HashSet()
	{
	}

	[Token(Token = "0x6000146")]
	public HashSet(IEqualityComparer<T> comparer)
	{
	}

	[Token(Token = "0x6000147")]
	public HashSet(int capacity)
	{
	}

	[Token(Token = "0x6000148")]
	public HashSet(IEnumerable<T> collection)
	{
	}

	[Token(Token = "0x6000149")]
	public HashSet(IEnumerable<T> collection, IEqualityComparer<T> comparer)
	{
	}

	[Token(Token = "0x600014A")]
	protected HashSet(SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x600014B")]
	private void CopyFrom(HashSet<T> source)
	{
	}

	[Token(Token = "0x600014C")]
	public HashSet(int capacity, IEqualityComparer<T> comparer)
	{
	}

	[Token(Token = "0x600014D")]
	private void System_002ECollections_002EGeneric_002EICollection_003CT_003E_002EAdd(T item)
	{
	}

	[Token(Token = "0x600014E")]
	public void Clear()
	{
	}

	[Token(Token = "0x600014F")]
	public bool Contains(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000150")]
	public void CopyTo(T[] array, int arrayIndex)
	{
	}

	[Token(Token = "0x6000151")]
	public bool Remove(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000154")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000155")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000156")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000157")]
	public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	[Token(Token = "0x6000158")]
	public virtual void OnDeserialization(object sender)
	{
	}

	[Token(Token = "0x6000159")]
	public bool Add(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600015A")]
	public void UnionWith(IEnumerable<T> other)
	{
	}

	[Token(Token = "0x600015B")]
	public void CopyTo(T[] array)
	{
	}

	[Token(Token = "0x600015C")]
	public void CopyTo(T[] array, int arrayIndex, int count)
	{
	}

	[Token(Token = "0x600015D")]
	public int RemoveWhere(Predicate<T> match)
	{
		return default(int);
	}

	[Token(Token = "0x600015F")]
	public void TrimExcess()
	{
	}

	[Token(Token = "0x6000160")]
	private int Initialize(int capacity)
	{
		return default(int);
	}

	[Token(Token = "0x6000161")]
	private void IncreaseCapacity()
	{
	}

	[Token(Token = "0x6000162")]
	private void SetCapacity(int newSize)
	{
	}

	[Token(Token = "0x6000163")]
	private bool AddIfNotPresent(T value)
	{
		return default(bool);
	}

	[Token(Token = "0x6000164")]
	private void AddValue(int index, int hashCode, T value)
	{
	}

	[Token(Token = "0x6000165")]
	private static bool AreEqualityComparersEqual(HashSet<T> set1, HashSet<T> set2)
	{
		return default(bool);
	}

	[Token(Token = "0x6000166")]
	private int InternalGetHashCode(T item)
	{
		return default(int);
	}
}
