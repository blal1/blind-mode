using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000086")]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeStreamRange
{
	[Token(Token = "0x4000219")]
	[FieldOffset(Offset = "0x0")]
	internal unsafe UnsafeStreamBlock* Block;

	[Token(Token = "0x400021A")]
	[FieldOffset(Offset = "0x8")]
	internal int OffsetInFirstBlock;

	[Token(Token = "0x400021B")]
	[FieldOffset(Offset = "0xC")]
	internal int ElementCount;

	[Token(Token = "0x400021C")]
	[FieldOffset(Offset = "0x10")]
	internal int LastOffset;

	[Token(Token = "0x400021D")]
	[FieldOffset(Offset = "0x14")]
	internal int NumberOfBlocks;
}
