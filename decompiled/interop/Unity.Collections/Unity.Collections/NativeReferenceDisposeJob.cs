using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000052")]
[BurstCompile]
internal struct NativeReferenceDisposeJob : IJob
{
	[Token(Token = "0x40001AA")]
	[FieldOffset(Offset = "0x0")]
	internal NativeReferenceDispose Data;

	[Token(Token = "0x6000142")]
	[Address(RVA = "0x22FCCD0", Offset = "0x22FBED0", VA = "0x1822FCCD0", Slot = "4")]
	public void Execute()
	{
	}
}
