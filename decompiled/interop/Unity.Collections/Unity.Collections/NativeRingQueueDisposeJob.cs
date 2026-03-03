using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000054")]
[BurstCompile]
internal struct NativeRingQueueDisposeJob : IJob
{
	[Token(Token = "0x40001AC")]
	[FieldOffset(Offset = "0x0")]
	public NativeRingQueueDispose Data;

	[Token(Token = "0x6000144")]
	[Address(RVA = "0x22FCD10", Offset = "0x22FBF10", VA = "0x1822FCD10", Slot = "4")]
	public void Execute()
	{
	}
}
