using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[Token(Token = "0x200001C")]
[DebuggerTypeProxy(typeof(FixedList32BytesDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct FixedList32Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
{
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes32Align8 data;

	[Token(Token = "0x1700000A")]
	internal ushort length
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000047")]
		readonly get
		{
			return default(ushort);
		}
		[MethodImpl(256)]
		[Token(Token = "0x6000048")]
		set
		{
		}
	}

	[Token(Token = "0x1700000B")]
	internal unsafe readonly byte* buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000049")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x1700000C")]
	[CreateProperty]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x600004A")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x600004B")]
		set
		{
		}
	}

	[Token(Token = "0x1700000D")]
	[CreateProperty]
	private IEnumerable<T> Elements
	{
		[Token(Token = "0x600004C")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700000E")]
	internal int LengthInBytes
	{
		[Token(Token = "0x600004D")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700000F")]
	internal unsafe readonly byte* Buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x600004E")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x17000010")]
	public readonly int Capacity
	{
		[MethodImpl(256)]
		[Token(Token = "0x600004F")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000011")]
	public T this[int index]
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000050")]
		readonly get
		{
			return (T)null;
		}
		[MethodImpl(256)]
		[Token(Token = "0x6000051")]
		set
		{
		}
	}

	[Token(Token = "0x6000052")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000053")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000054")]
	public int CompareTo(FixedList32Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000055")]
	public bool Equals(FixedList32Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000056")]
	public int CompareTo(FixedList64Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000057")]
	public bool Equals(FixedList64Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000058")]
	public int CompareTo(FixedList128Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000059")]
	public bool Equals(FixedList128Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600005A")]
	public int CompareTo(FixedList512Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600005B")]
	public bool Equals(FixedList512Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600005C")]
	public int CompareTo(FixedList4096Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600005D")]
	public bool Equals(FixedList4096Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600005E")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600005F")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}
}
