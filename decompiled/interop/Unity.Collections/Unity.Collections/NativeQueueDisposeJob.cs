using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000050")]
[BurstCompile]
internal struct NativeQueueDisposeJob : IJob
{
	[Token(Token = "0x40001A7")]
	[FieldOffset(Offset = "0x0")]
	public NativeQueueDispose Data;

	[Token(Token = "0x6000140")]
	[Address(RVA = "0x22FCC90", Offset = "0x22FBE90", VA = "0x1822FCC90", Slot = "4")]
	public void Execute()
	{
	}
}
