using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000084")]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeStreamBlock
{
	[Token(Token = "0x4000216")]
	[FieldOffset(Offset = "0x0")]
	internal unsafe UnsafeStreamBlock* Next;

	[Token(Token = "0x4000217")]
	[FieldOffset(Offset = "0x8")]
	internal unsafe fixed byte Data[1];
}
