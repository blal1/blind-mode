using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x2000072")]
[BurstCompile]
internal struct UnsafeDisposeJob : IJob
{
	[Token(Token = "0x40001EB")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe void* Ptr;

	[Token(Token = "0x40001EC")]
	[FieldOffset(Offset = "0x8")]
	public AllocatorManager.AllocatorHandle Allocator;

	[Token(Token = "0x60001A8")]
	[Address(RVA = "0x22FD620", Offset = "0x22FC820", VA = "0x1822FD620", Slot = "4")]
	public void Execute()
	{
	}
}
