using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000037")]
[BurstCompile]
internal struct NativeHashMapDisposeJob : IJob
{
	[Token(Token = "0x4000192")]
	[FieldOffset(Offset = "0x0")]
	internal NativeHashMapDispose Data;

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x22FCC10", Offset = "0x22FBE10", VA = "0x1822FCC10", Slot = "4")]
	public void Execute()
	{
	}
}
