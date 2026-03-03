using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000066")]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct UnsafeQueue<T> : IDisposable where T : struct
{
	[Token(Token = "0x40001CE")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeQueueData* m_Buffer;

	[Token(Token = "0x40001CF")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	[Token(Token = "0x17000041")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x6000177")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600016F")]
	public UnsafeQueue(AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x6000170")]
	internal unsafe static UnsafeQueue<T>* Alloc(AllocatorManager.AllocatorHandle allocator)
	{
		//IL_0002: Expected I, but got O
		return (UnsafeQueue<T>*)unchecked((nint)null);
	}

	[Token(Token = "0x6000171")]
	internal unsafe static void Free(UnsafeQueue<T>* data)
	{
	}

	[Token(Token = "0x6000172")]
	public readonly bool IsEmpty()
	{
		return default(bool);
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000173")]
	public T Peek()
	{
		return (T)null;
	}

	[Token(Token = "0x6000174")]
	public void Enqueue(T value)
	{
	}

	[Token(Token = "0x6000175")]
	public T Dequeue()
	{
		return (T)null;
	}

	[Token(Token = "0x6000176")]
	public bool TryDequeue(out T item)
	{
		return default(bool);
	}

	[Token(Token = "0x6000178")]
	public void Dispose()
	{
	}
}
