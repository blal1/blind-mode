using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000073")]
internal struct UntypedUnsafeList
{
	[Token(Token = "0x40001ED")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe readonly void* Ptr;

	[Token(Token = "0x40001EE")]
	[FieldOffset(Offset = "0x8")]
	internal readonly int m_length;

	[Token(Token = "0x40001EF")]
	[FieldOffset(Offset = "0xC")]
	internal readonly int m_capacity;

	[Token(Token = "0x40001F0")]
	[FieldOffset(Offset = "0x10")]
	internal readonly AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x40001F1")]
	[FieldOffset(Offset = "0x14")]
	internal readonly int padding;
}
