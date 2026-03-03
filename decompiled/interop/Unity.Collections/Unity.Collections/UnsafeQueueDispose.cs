using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000067")]
[GenerateTestsForBurstCompatibility]
internal struct UnsafeQueueDispose
{
	[Token(Token = "0x40001D0")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeQueueData* m_Buffer;

	[Token(Token = "0x40001D1")]
	[FieldOffset(Offset = "0x8")]
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	[Token(Token = "0x6000179")]
	[Address(RVA = "0x22FDAA0", Offset = "0x22FCCA0", VA = "0x1822FDAA0")]
	public void Dispose()
	{
	}
}
