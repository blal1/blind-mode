using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000065")]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeQueueData
{
	[Token(Token = "0x40001C9")]
	[FieldOffset(Offset = "0x0")]
	public IntPtr m_FirstBlock;

	[Token(Token = "0x40001CA")]
	[FieldOffset(Offset = "0x8")]
	public IntPtr m_LastBlock;

	[Token(Token = "0x40001CB")]
	[FieldOffset(Offset = "0x10")]
	public int m_MaxItems;

	[Token(Token = "0x40001CC")]
	[FieldOffset(Offset = "0x14")]
	public int m_CurrentRead;

	[Token(Token = "0x40001CD")]
	[FieldOffset(Offset = "0x18")]
	public unsafe byte* m_CurrentWriteBlockTLS;

	[MethodImpl(256)]
	[Token(Token = "0x600016A")]
	[Address(RVA = "0x22FDA70", Offset = "0x22FCC70", VA = "0x1822FDA70")]
	internal unsafe UnsafeQueueBlockHeader* GetCurrentWriteBlockTLS(int threadIndex)
	{
		//IL_0002: Expected I, but got O
		return (UnsafeQueueBlockHeader*)unchecked((nint)null);
	}

	[MethodImpl(256)]
	[Token(Token = "0x600016B")]
	[Address(RVA = "0x22FDA80", Offset = "0x22FCC80", VA = "0x1822FDA80")]
	internal unsafe void SetCurrentWriteBlockTLS(int threadIndex, UnsafeQueueBlockHeader* currentWriteBlock)
	{
	}

	[Token(Token = "0x600016C")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static UnsafeQueueBlockHeader* AllocateWriteBlockMT<T>(UnsafeQueueData* data, AllocatorManager.AllocatorHandle allocator, int threadIndex) where T : struct
	{
		//IL_0002: Expected I, but got O
		return (UnsafeQueueBlockHeader*)unchecked((nint)null);
	}

	[Token(Token = "0x600016D")]
	[GenerateTestsForBurstCompatibility(GenericTypeArguments = new Type[] { typeof(int) })]
	public unsafe static void AllocateQueue<T>(AllocatorManager.AllocatorHandle allocator, out UnsafeQueueData* outBuf) where T : struct
	{
	}

	[Token(Token = "0x600016E")]
	[Address(RVA = "0x22FD9D0", Offset = "0x22FCBD0", VA = "0x1822FD9D0")]
	public unsafe static void DeallocateQueue(UnsafeQueueData* data, AllocatorManager.AllocatorHandle allocator)
	{
	}
}
