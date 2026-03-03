using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x200004E")]
[NativeContainer]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct NativeQueue<T> : IDisposable where T : struct
{
	[Token(Token = "0x40001A5")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	private unsafe UnsafeQueue<T>* m_Queue;

	[Token(Token = "0x1700003E")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x600013D")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6000137")]
	public NativeQueue(AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x6000138")]
	public readonly bool IsEmpty()
	{
		return default(bool);
	}

	[Token(Token = "0x6000139")]
	public T Peek()
	{
		return (T)null;
	}

	[Token(Token = "0x600013A")]
	public void Enqueue(T value)
	{
	}

	[Token(Token = "0x600013B")]
	public T Dequeue()
	{
		return (T)null;
	}

	[Token(Token = "0x600013C")]
	public bool TryDequeue(out T item)
	{
		return default(bool);
	}

	[Token(Token = "0x600013E")]
	public void Dispose()
	{
	}
}
