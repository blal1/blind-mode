using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000087")]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeStreamBlockData
{
	[Token(Token = "0x400021E")]
	[FieldOffset(Offset = "0x0")]
	internal AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x400021F")]
	[FieldOffset(Offset = "0x8")]
	internal unsafe UnsafeStreamBlock** Blocks;

	[Token(Token = "0x4000220")]
	[FieldOffset(Offset = "0x10")]
	internal int BlockCount;

	[Token(Token = "0x4000221")]
	[FieldOffset(Offset = "0x18")]
	internal AllocatorManager.Block Ranges;

	[Token(Token = "0x4000222")]
	[FieldOffset(Offset = "0x38")]
	internal int RangeCount;

	[Token(Token = "0x60001FC")]
	[Address(RVA = "0x22FDB40", Offset = "0x22FCD40", VA = "0x1822FDB40")]
	internal unsafe void Free(UnsafeStreamBlock* oldBlock)
	{
	}
}
