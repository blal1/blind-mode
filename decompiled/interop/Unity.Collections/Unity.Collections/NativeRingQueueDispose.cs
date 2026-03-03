using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000053")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeRingQueueDispose
{
	[Token(Token = "0x40001AB")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UnsafeRingQueue<int>* m_QueueData;

	[Token(Token = "0x6000143")]
	[Address(RVA = "0x22FCD10", Offset = "0x22FBF10", VA = "0x1822FCD10")]
	public void Dispose()
	{
	}
}
