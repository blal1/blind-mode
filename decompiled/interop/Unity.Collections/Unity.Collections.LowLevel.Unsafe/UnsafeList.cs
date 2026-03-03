using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000074")]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeListTDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct UnsafeList<T> : IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable where T : struct
{
	[Token(Token = "0x40001F2")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe T* Ptr;

	[Token(Token = "0x40001F3")]
	[FieldOffset(Offset = "0x0")]
	public int m_length;

	[Token(Token = "0x40001F4")]
	[FieldOffset(Offset = "0x0")]
	public int m_capacity;

	[Token(Token = "0x40001F5")]
	[FieldOffset(Offset = "0x0")]
	public AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x40001F6")]
	[FieldOffset(Offset = "0x0")]
	private readonly int padding;

	[Token(Token = "0x17000049")]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001A9")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60001AA")]
		set
		{
		}
	}

	[Token(Token = "0x1700004A")]
	public int Capacity
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001AB")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60001AC")]
		set
		{
		}
	}

	[Token(Token = "0x1700004B")]
	public T this[int index]
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001AD")]
		get
		{
			return (T)null;
		}
		[MethodImpl(256)]
		[Token(Token = "0x60001AE")]
		set
		{
		}
	}

	[Token(Token = "0x1700004C")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001B4")]
		get
		{
			return default(bool);
		}
	}

	[MethodImpl(256)]
	[Token(Token = "0x60001AF")]
	public unsafe ref T ElementAt(int index)
	{
		return ref *(T*)null;
	}

	[Token(Token = "0x60001B0")]
	public unsafe UnsafeList(T* ptr, int length)
	{
	}

	[Token(Token = "0x60001B1")]
	public UnsafeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
	}

	[Token(Token = "0x60001B2")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal unsafe static UnsafeList<T>* Create<U>(int initialCapacity, ref U allocator, NativeArrayOptions options) where U : struct, AllocatorManager.IAllocator
	{
		//IL_0002: Expected I, but got O
		return (UnsafeList<T>*)unchecked((nint)null);
	}

	[Token(Token = "0x60001B3")]
	public unsafe static void Destroy(UnsafeList<T>* listData)
	{
	}

	[Token(Token = "0x60001B5")]
	public void Dispose()
	{
	}

	[Token(Token = "0x60001B6")]
	public void Clear()
	{
	}

	[Token(Token = "0x60001B7")]
	public void Resize(int length, NativeArrayOptions options = NativeArrayOptions.UninitializedMemory)
	{
	}

	[Token(Token = "0x60001B8")]
	private void ResizeExact<U>(ref U allocator, int newCapacity) where U : struct, AllocatorManager.IAllocator
	{
	}

	[Token(Token = "0x60001B9")]
	private void SetCapacity<U>(ref U allocator, int capacity) where U : struct, AllocatorManager.IAllocator
	{
	}

	[Token(Token = "0x60001BA")]
	public void SetCapacity(int capacity)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60001BB")]
	public void AddNoResize(T value)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x60001BC")]
	public void Add(in T value)
	{
	}

	[Token(Token = "0x60001BD")]
	public unsafe void AddRange(void* ptr, int count)
	{
	}

	[Token(Token = "0x60001BE")]
	public void RemoveAtSwapBack(int index)
	{
	}

	[Token(Token = "0x60001BF")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x60001C0")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60001C1")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}
}
