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
[Token(Token = "0x200001E")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(FixedList64BytesDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct FixedList64Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
{
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes64Align8 data;

	[Token(Token = "0x17000012")]
	internal ushort length
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000061")]
		readonly get
		{
			return default(ushort);
		}
		[MethodImpl(256)]
		[Token(Token = "0x6000062")]
		set
		{
		}
	}

	[Token(Token = "0x17000013")]
	internal unsafe readonly byte* buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000063")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x17000014")]
	[CreateProperty]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000064")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x6000065")]
		set
		{
		}
	}

	[Token(Token = "0x17000015")]
	[CreateProperty]
	private IEnumerable<T> Elements
	{
		[Token(Token = "0x6000066")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000016")]
	internal int LengthInBytes
	{
		[Token(Token = "0x6000067")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000017")]
	internal unsafe readonly byte* Buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000068")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x6000069")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x600006A")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x600006B")]
	public int CompareTo(FixedList32Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600006C")]
	public bool Equals(FixedList32Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600006D")]
	public int CompareTo(FixedList64Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600006E")]
	public bool Equals(FixedList64Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600006F")]
	public int CompareTo(FixedList128Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000070")]
	public bool Equals(FixedList128Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000071")]
	public int CompareTo(FixedList512Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000072")]
	public bool Equals(FixedList512Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000073")]
	public int CompareTo(FixedList4096Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x6000074")]
	public bool Equals(FixedList4096Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000075")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000076")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000077")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}
}
