using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000060")]
[BurstCompile]
internal struct NativeTextDisposeJob : IJob
{
	[Token(Token = "0x40001C0")]
	[FieldOffset(Offset = "0x0")]
	public NativeTextDispose Data;

	[Token(Token = "0x6000161")]
	[Address(RVA = "0x22FCD70", Offset = "0x22FBF70", VA = "0x1822FCD70", Slot = "4")]
	public void Execute()
	{
	}
}
