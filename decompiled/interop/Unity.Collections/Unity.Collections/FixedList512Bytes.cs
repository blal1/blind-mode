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
[Token(Token = "0x2000022")]
[DefaultMember("Item")]
[DebuggerTypeProxy(typeof(FixedList512BytesDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct FixedList512Bytes<T> : INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable, IEquatable<FixedList32Bytes<T>>, IComparable<FixedList32Bytes<T>>, IEquatable<FixedList64Bytes<T>>, IComparable<FixedList64Bytes<T>>, IEquatable<FixedList128Bytes<T>>, IComparable<FixedList128Bytes<T>>, IEquatable<FixedList512Bytes<T>>, IComparable<FixedList512Bytes<T>>, IEquatable<FixedList4096Bytes<T>>, IComparable<FixedList4096Bytes<T>> where T : struct
{
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x0")]
	[SerializeField]
	internal FixedBytes512Align8 data;

	[Token(Token = "0x1700001E")]
	internal ushort length
	{
		[MethodImpl(256)]
		[Token(Token = "0x600008F")]
		readonly get
		{
			return default(ushort);
		}
		[MethodImpl(256)]
		[Token(Token = "0x6000090")]
		set
		{
		}
	}

	[Token(Token = "0x1700001F")]
	internal unsafe readonly byte* buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000091")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x17000020")]
	[CreateProperty]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000092")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x6000093")]
		set
		{
		}
	}

	[Token(Token = "0x17000021")]
	[CreateProperty]
	private IEnumerable<T> Elements
	{
		[Token(Token = "0x6000094")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000022")]
	internal int LengthInBytes
	{
		[Token(Token = "0x6000095")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000023")]
	internal unsafe readonly byte* Buffer
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000096")]
		get
		{
			//IL_0002: Expected I, but got O
			return (byte*)unchecked((nint)null);
		}
	}

	[Token(Token = "0x6000097")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6000098")]
	[ExcludeFromBurstCompatTesting("Returns managed array")]
	public T[] ToArray()
	{
		return null;
	}

	[Token(Token = "0x6000099")]
	public int CompareTo(FixedList32Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600009A")]
	public bool Equals(FixedList32Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600009B")]
	public int CompareTo(FixedList64Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600009C")]
	public bool Equals(FixedList64Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600009D")]
	public int CompareTo(FixedList128Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x600009E")]
	public bool Equals(FixedList128Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x600009F")]
	public int CompareTo(FixedList512Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000A0")]
	public bool Equals(FixedList512Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	public int CompareTo(FixedList4096Bytes<T> other)
	{
		return default(int);
	}

	[Token(Token = "0x60000A2")]
	public bool Equals(FixedList4096Bytes<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A3")]
	[ExcludeFromBurstCompatTesting("Takes managed object")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60000A4")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000A5")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}
}
