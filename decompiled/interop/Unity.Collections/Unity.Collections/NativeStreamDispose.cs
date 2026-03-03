using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x200005D")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeStreamDispose
{
	[Token(Token = "0x40001BD")]
	[FieldOffset(Offset = "0x0")]
	public UnsafeStream m_StreamData;

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x22FCD50", Offset = "0x22FBF50", VA = "0x1822FCD50")]
	public void Dispose()
	{
	}
}
