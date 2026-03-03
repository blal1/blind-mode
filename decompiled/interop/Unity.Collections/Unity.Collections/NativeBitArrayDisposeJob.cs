using Il2CppDummyDll;
using Unity.Burst;
using Unity.Jobs;

namespace Unity.Collections;

[Token(Token = "0x2000035")]
[BurstCompile]
internal struct NativeBitArrayDisposeJob : IJob
{
	[Token(Token = "0x400018F")]
	[FieldOffset(Offset = "0x0")]
	public NativeBitArrayDispose Data;

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x22FCB60", Offset = "0x22FBD60", VA = "0x1822FCB60", Slot = "4")]
	public void Execute()
	{
	}
}
