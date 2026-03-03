using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000042")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeListDispose
{
	[Token(Token = "0x400019B")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	public unsafe UntypedUnsafeList* m_ListData;

	[Token(Token = "0x600010C")]
	[Address(RVA = "0x22FCC50", Offset = "0x22FBE50", VA = "0x1822FCC50")]
	public void Dispose()
	{
	}
}
