using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000078")]
[BurstCompile]
internal struct UnsafeParallelHashMapDataDisposeJob : IJob
{
	[Token(Token = "0x4000200")]
	[FieldOffset(Offset = "0x0")]
	internal UnsafeParallelHashMapDataDispose Data;

	[Token(Token = "0x60001CD")]
	[Address(RVA = "0x22FD6D0", Offset = "0x22FC8D0", VA = "0x1822FD6D0", Slot = "4")]
	public void Execute()
	{
	}
}
