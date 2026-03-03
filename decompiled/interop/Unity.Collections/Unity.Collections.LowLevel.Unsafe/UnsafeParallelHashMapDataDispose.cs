using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000077")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeParallelHashMapDataDispose
{
	[Token(Token = "0x40001FE")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeParallelHashMapData* m_Buffer;

	[Token(Token = "0x40001FF")]
	[FieldOffset(Offset = "0x8")]
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	[Token(Token = "0x60001CC")]
	[Address(RVA = "0x22FD6D0", Offset = "0x22FC8D0", VA = "0x1822FD6D0")]
	public void Dispose()
	{
	}
}
