using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000051")]
[NativeContainer]
internal struct NativeReferenceDispose
{
	[Token(Token = "0x40001A8")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe void* m_Data;

	[Token(Token = "0x40001A9")]
	[FieldOffset(Offset = "0x8")]
	internal AllocatorManager.AllocatorHandle m_AllocatorLabel;

	[Token(Token = "0x6000141")]
	[Address(RVA = "0x22FCCD0", Offset = "0x22FBED0", VA = "0x1822FCCD0")]
	public void Dispose()
	{
	}
}
