using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x200003B")]
[NativeContainer]
[DebuggerTypeProxy(typeof(NativeHashSetDebuggerTypeProxy<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeHashSet<T> : IDisposable, IEnumerable<T>, IEnumerable where T : struct, IEquatable<T>
{
	[Token(Token = "0x200003C")]
	[NativeContainer]
	[NativeContainerIsReadOnly]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ReadOnly : IEnumerable<T>, IEnumerable
	{
		[Token(Token = "0x4000198")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		internal unsafe HashMapHelper<T>* m_Data;

		[Token(Token = "0x60000E8")]
		internal ReadOnly(ref NativeHashSet<T> data)
		{
		}

		[Token(Token = "0x60000E9")]
		public readonly bool Contains(T item)
		{
			return default(bool);
		}

		[Token(Token = "0x60000EA")]
		private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000EB")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000197")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe HashMapHelper<T>* m_Data;

	[Token(Token = "0x17000030")]
	public readonly int Count
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000E1")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000031")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000E2")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000E0")]
	public NativeHashSet(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60000E3")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60000E4")]
	public bool Add(T item)
	{
		return default(bool);
	}

	[Token(Token = "0x60000E5")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000E6")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60000E7")]
	public ReadOnly AsReadOnly()
	{
		return default(ReadOnly);
	}
}
