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
[Token(Token = "0x2000024")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(FixedList4096BytesDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct FixedList4096Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
{
	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes4096Align8 data;

	[Token(Token = "0x17000024")]
	internal ushort length
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000A6")]
		readonly get
		{
			return default(ushort);
		}
		[MethodImpl(256)]
		[Token(Token = "0x60000A7")]
		set
		{
		}
	}

	[Token(Token = "0x17000025")]
	internal unsafe readonly byte* buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000A8")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x17000026")]
	[CreateProperty]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000A9")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60000AA")]
		set
		{
		}
	}

	[Token(Token = "0x17000027")]
	[CreateProperty]
	private IEnumerable<T> Elements
	{
		[Token(Token = "0x60000AB")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000028")]
	internal int LengthInBytes
	{
		[Token(Token = "0x60000AC")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000029")]
	internal unsafe readonly byte* Buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000AD")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x60000AE")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x60000AF")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x60000B0")]
	public int CompareTo(FixedList32Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000B1")]
	public bool Equals(FixedList32Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B2")]
	public int CompareTo(FixedList64Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000B3")]
	public bool Equals(FixedList64Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B4")]
	public int CompareTo(FixedList128Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000B5")]
	public bool Equals(FixedList128Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B6")]
	public int CompareTo(FixedList512Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000B7")]
	public bool Equals(FixedList512Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000B8")]
	public int CompareTo(FixedList4096Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000B9")]
	public bool Equals(FixedList4096Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BA")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000BB")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000BC")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}
}
