using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000043")]
[BurstCompile]
[GenerateTestsForBurstCompatibility]
internal struct NativeListDisposeJob : IJob
{
	[Token(Token = "0x400019C")]
	[FieldOffset(Offset = "0x0")]
	internal NativeListDispose Data;

	[Token(Token = "0x600010D")]
	[Address(RVA = "0x22FCC50", Offset = "0x22FBE50", VA = "0x1822FCC50", Slot = "4")]
	public void Execute()
	{
	}
}
