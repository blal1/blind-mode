using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x200005F")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeTextDispose
{
	[Token(Token = "0x40001BF")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UnsafeText* m_TextData;

	[Token(Token = "0x6000160")]
	[Address(RVA = "0x22FCD80", Offset = "0x22FBF80", VA = "0x1822FCD80")]
	public void Dispose()
	{
	}
}
