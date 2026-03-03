using Il2CppDummyDll;

namespace Unity.Collections;

[Token(Token = "0x2000064")]
internal struct UnsafeQueueBlockHeader
{
	[Token(Token = "0x40001C7")]
	[FieldOffset(Offset = "0x0")]
	public unsafe UnsafeQueueBlockHeader* m_NextBlock;

	[Token(Token = "0x40001C8")]
	[FieldOffset(Offset = "0x8")]
	public int m_NumItems;
}
