using Il2CppDummyDll;
using Unity.Collections.LowLevel.Unsafe;

namespace Unity.Collections;

[Token(Token = "0x2000036")]
[NativeContainer]
[GenerateTestsForBurstCompatibility]
internal struct NativeHashMapDispose
{
	[Token(Token = "0x4000190")]
	[FieldOffset(Offset = "0x0")]
	[NativeDisableUnsafePtrRestriction]
	internal unsafe UnsafeHashMap<int, int>* m_HashMapData;

	[Token(Token = "0x4000191")]
	[FieldOffset(Offset = "0x8")]
	internal AllocatorManager.AllocatorHandle m_Allocator;

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x22FCC10", Offset = "0x22FBE10", VA = "0x1822FCC10")]
	internal void Dispose()
	{
	}
}
