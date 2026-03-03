using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000068")]
[BurstCompile]
internal struct UnsafeQueueDisposeJob : IJob
{
	[Token(Token = "0x40001D2")]
	[FieldOffset(Offset = "0x0")]
	public UnsafeQueueDispose Data;

	[Token(Token = "0x600017A")]
	[Address(RVA = "0x22FDA90", Offset = "0x22FCC90", VA = "0x1822FDA90", Slot = "4")]
	public void Execute()
	{
	}
}
