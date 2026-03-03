using System;
using System.Diagnostics;
using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200006B")]
[DebuggerDisplay("Length = {Length}, IsCreated = {IsCreated}")]
[DebuggerTypeProxy(typeof(UnsafeBitArrayDebugView))]
[GenerateTestsForBurstCompatibility]
public struct UnsafeBitArray : IDisposable
{
	[Token(Token = "0x40001D4")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe ulong* Ptr;

	[Token(Token = "0x40001D5")]
	[FieldOffset(Offset = "0x8")]
	public int Length;

	[Token(Token = "0x40001D6")]
	[FieldOffset(Offset = "0xC")]
	public int Capacity;

	[Token(Token = "0x40001D7")]
	[FieldOffset(Offset = "0x10")]
	public AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x17000042")]
	public readonly bool IsCreated
	{
		[Token(Token = "0x6000180")]
		[Address(RVA = "0x12CF0D0", Offset = "0x12CE2D0", VA = "0x1812CF0D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600017F")]
	[Address(RVA = "0x22FD580", Offset = "0x22FC780", VA = "0x1822FD580")]
	internal unsafe static void Free(UnsafeBitArray* data, AllocatorManager.AllocatorHandle allocator)
	{
	}

	[Token(Token = "0x6000181")]
	[Address(RVA = "0x22FD4E0", Offset = "0x22FC6E0", VA = "0x1822FD4E0", Slot = "4")]
	public void Dispose()
	{
	}
}
