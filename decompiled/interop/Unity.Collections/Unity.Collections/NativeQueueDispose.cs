using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x200004F")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeQueueDispose
{
	[Token(Token = "0x40001A6")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UnsafeQueue<int>* m_QueueData;

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x22FCC90", Offset = "0x22FBE90", VA = "0x1822FCC90")]
	public void Dispose()
	{
	}
}
