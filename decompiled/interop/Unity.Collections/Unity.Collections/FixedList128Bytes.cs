using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Properties;
using UnityEngine;

namespace Unity.Collections;

[Serializable]
[Token(Token = "0x2000020")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(FixedList128BytesDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct FixedList128Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
{
	[Token(Token = "0x4000057")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes128Align8 data;

	[Token(Token = "0x17000018")]
	internal ushort length
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000078")]
		readonly get
		{
			return default(ushort);
		}
		[MethodImpl(256)]
		[Token(Token = "0x6000079")]
		set
		{
		}
	}

	[Token(Token = "0x17000019")]
	internal unsafe readonly byte* buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x600007A")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x1700001A")]
	[CreateProperty]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x600007B")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x600007C")]
		set
		{
		}
	}

	[Token(Token = "0x1700001B")]
	[CreateProperty]
	private IEnumerable<T> Elements
	{
		[Token(Token = "0x600007D")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700001C")]
	internal int LengthInBytes
	{
		[Token(Token = "0x600007E")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x1700001D")]
	internal unsafe readonly byte* Buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x600007F")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x6000080")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000081")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000082")]
	public int CompareTo(FixedList32Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000083")]
	public bool Equals(FixedList32Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000084")]
	public int CompareTo(FixedList64Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000085")]
	public bool Equals(FixedList64Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000086")]
	public int CompareTo(FixedList128Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000087")]
	public bool Equals(FixedList128Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000088")]
	public int CompareTo(FixedList512Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000089")]
	public bool Equals(FixedList512Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600008A")]
	public int CompareTo(FixedList4096Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600008B")]
	public bool Equals(FixedList4096Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600008C")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600008D")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600008E")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}
}
