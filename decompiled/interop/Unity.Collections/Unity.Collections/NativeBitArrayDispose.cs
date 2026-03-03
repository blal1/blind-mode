using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000034")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeBitArrayDispose
{
	[Token(Token = "0x400018D")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UnsafeBitArray* m_BitArrayData;

	[Token(Token = "0x400018E")]
	[FieldOffset(Offset = "0x8")]
	public AllocatorManager.AllocatorHandle m_Allocator;

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x22FCB70", Offset = "0x22FBD70", VA = "0x1822FCB70")]
	public void Dispose()
	{
	}
}
