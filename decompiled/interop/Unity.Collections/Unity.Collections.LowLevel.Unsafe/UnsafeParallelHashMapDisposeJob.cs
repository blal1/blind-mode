using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200007E")]
[BurstCompile]
internal struct UnsafeParallelHashMapDisposeJob : IJob
{
	[Token(Token = "0x400020C")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UnsafeParallelHashMapData* Data;

	[Token(Token = "0x400020D")]
	[FieldOffset(Offset = "0x8")]
	public AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x60001ED")]
	[Address(RVA = "0x22FD6D0", Offset = "0x22FC8D0", VA = "0x1822FD6D0", Slot = "4")]
	public void Execute()
	{
	}
}
