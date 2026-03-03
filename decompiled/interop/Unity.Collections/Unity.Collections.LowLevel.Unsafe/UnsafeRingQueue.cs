using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000082")]
[DebuggerDisplay("Length = {Length}, Capacity = {Capacity}, IsCreated = {IsCreated}, IsEmpty = {IsEmpty}")]
[DebuggerTypeProxy(typeof(UnsafeRingQueueDebugView<>))]
[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
public struct UnsafeRingQueue<T> : IDisposable where T : struct
{
	[Token(Token = "0x4000210")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe T* Ptr;

	[Token(Token = "0x4000211")]
	[FieldOffset(Offset = "0x0")]
	public AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x4000212")]
	[FieldOffset(Offset = "0x0")]
	internal readonly int m_Capacity;

	[Token(Token = "0x4000213")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Filled;

	[Token(Token = "0x4000214")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Write;

	[Token(Token = "0x4000215")]
	[FieldOffset(Offset = "0x0")]
	internal int m_Read;

	[Token(Token = "0x17000054")]
	public readonly bool IsCreated
	{
		[MethodImpl(256)]
		[Token(Token = "0x60001FA")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60001F9")]
	internal unsafe static void Free(UnsafeRingQueue<T>* data)
	{
	}

	[Token(Token = "0x60001FB")]
	public void Dispose()
	{
	}
}
