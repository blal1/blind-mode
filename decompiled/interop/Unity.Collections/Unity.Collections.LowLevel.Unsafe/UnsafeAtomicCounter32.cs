using Il2CppDummyDll;

namespace Unity.Collections.LowLevel.Unsafe;

[Token(Token = "0x200006A")]
[GenerateTestsForBurstCompatibility]
public struct UnsafeAtomicCounter32
{
	[Token(Token = "0x40001D3")]
	[FieldOffset(Offset = "0x0")]
	public unsafe int* Counter;

	[Token(Token = "0x600017D")]
	[Address(RVA = "0xF789F0", Offset = "0xF77BF0", VA = "0x180F789F0")]
	public unsafe UnsafeAtomicCounter32(void* ptr)
	{
	}

	[Token(Token = "0x600017E")]
	[Address(RVA = "0x22FD490", Offset = "0x22FC690", VA = "0x1822FD490")]
	public int Add(int value)
	{
		return default(int);
	}
}
