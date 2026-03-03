using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000040")]
[NativeContainer]
[DebuggerDisplay("Length = {m_ListData == null ? default : m_ListData->Length}, Capacity = {m_ListData == null ? default : m_ListData->Capacity}")]
[DebuggerTypeProxy(typeof(NativeListDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeList<T> : IDisposable, INativeList<T>, IIndexable<T>, IEnumerable<T>, IEnumerable where T : struct
{
	[Token(Token = "0x2000041")]
	[NativeContainer]
	[NativeContainerIsAtomicWriteOnly]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public struct ParallelWriter
	{
		[Token(Token = "0x400019A")]
		[FieldOffset(Offset = "0x0")]
		[NativeDisableUnsafePtrRestriction]
		public unsafe UnsafeList<T>* ListData;

		[Token(Token = "0x600010A")]
		internal unsafe ParallelWriter(UnsafeList<T>* listData)
		{
		}

		[Token(Token = "0x600010B")]
		public unsafe void AddRangeNoResize(void* ptr, int count)
		{
		}
	}

	[Token(Token = "0x4000199")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeList<T>* m_ListData;

	[Token(Token = "0x17000033")]
	public T this[int index]
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000F0")]
		get
		{
			return (T)null;
		}
		[MethodImpl(256)]
		[Token(Token = "0x60000F1")]
		set
		{
		}
	}

	[Token(Token = "0x17000034")]
	public int Length
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000F3")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60000F4")]
		set
		{
		}
	}

	[Token(Token = "0x17000035")]
	public int Capacity
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000F5")]
		readonly get
		{
			return default(int);
		}
		[Token(Token = "0x60000F6")]
		set
		{
		}
	}

	[Token(Token = "0x17000036")]
	public readonly bool IsEmpty
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000FD")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000037")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60000FE")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60000ED")]
	public NativeList(AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60000EE")]
	public NativeList(int initialCapacity, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x60000EF")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(AllocatorManager.AllocatorHandle) })]
	internal void Initialize<U>(int initialCapacity, ref U allocator) where U : struct, AllocatorManager.IAllocator
	{
	}

	[Token(Token = "0x60000F2")]
	public unsafe ref T ElementAt(int index)
	{
		return ref *(T*)null;
	}

	[Token(Token = "0x60000F7")]
	public unsafe UnsafeList<T>* GetUnsafeList()
	{
		//IL_0002: Expected I, but got O
		return (UnsafeList<T>*)unchecked((nint)null);
	}

	[Token(Token = "0x60000F8")]
	public void Add(in T value)
	{
	}

	[Token(Token = "0x60000F9")]
	public void AddRange(NativeArray<T> array)
	{
	}

	[Token(Token = "0x60000FA")]
	public unsafe void AddRange(void* ptr, int count)
	{
	}

	[Token(Token = "0x60000FB")]
	public void RemoveAtSwapBack(int index)
	{
	}

	[Token(Token = "0x60000FC")]
	public void RemoveAt(int index)
	{
	}

	[Token(Token = "0x60000FF")]
	public void Dispose()
	{
	}

	[Token(Token = "0x6000100")]
	public JobHandle Dispose(JobHandle inputDeps)
	{
		return default(JobHandle);
	}

	[Token(Token = "0x6000101")]
	public void Clear()
	{
	}

	[Token(Token = "0x6000102")]
	public NativeArray<T> AsArray()
	{
		return default(NativeArray<T>);
	}

	[Token(Token = "0x6000103")]
	public NativeArray<T> AsDeferredJobArray()
	{
		return default(NativeArray<T>);
	}

	[Token(Token = "0x6000104")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000105")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000106")]
	public void Resize(int length, NativeArrayOptions options)
	{
	}

	[Token(Token = "0x6000107")]
	public void ResizeUninitialized(int length)
	{
	}

	[Token(Token = "0x6000108")]
	public void SetCapacity(int capacity)
	{
	}

	[Token(Token = "0x6000109")]
	public ParallelWriter AsParallelWriter()
	{
		return default(ParallelWriter);
	}
}
