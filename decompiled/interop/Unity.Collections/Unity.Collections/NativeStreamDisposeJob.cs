using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x200005E")]
[BurstCompile]
internal struct NativeStreamDisposeJob : IJob
{
	[Token(Token = "0x40001BE")]
	[FieldOffset(Offset = "0x0")]
	public NativeStreamDispose Data;

	[Token(Token = "0x600015F")]
	[Address(RVA = "0x22FCD50", Offset = "0x22FBF50", VA = "0x1822FCD50", Slot = "4")]
	public void Execute()
	{
	}
}
