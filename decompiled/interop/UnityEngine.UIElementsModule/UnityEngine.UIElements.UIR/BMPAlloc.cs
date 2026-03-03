using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200057D")]
internal struct BMPAlloc
{
	[Token(Token = "0x4001397")]
	[FieldOffset(Offset = "0x0")]
	public static readonly BMPAlloc Invalid;

	[Token(Token = "0x4001398")]
	[FieldOffset(Offset = "0x0")]
	public int page;

	[Token(Token = "0x4001399")]
	[FieldOffset(Offset = "0x4")]
	public ushort pageLine;

	[Token(Token = "0x400139A")]
	[FieldOffset(Offset = "0x6")]
	public byte bitIndex;

	[Token(Token = "0x400139B")]
	[FieldOffset(Offset = "0x7")]
	public OwnedState ownedState;

	[Token(Token = "0x60026B7")]
	[Address(RVA = "0x2A56F60", Offset = "0x2A56160", VA = "0x182A56F60")]
	public bool Equals(BMPAlloc other)
	{
		return default(bool);
	}

	[Token(Token = "0x60026B8")]
	[Address(RVA = "0x2A56F80", Offset = "0x2A56180", VA = "0x182A56F80")]
	public bool IsValid()
	{
		return default(bool);
	}

	[Token(Token = "0x60026B9")]
	[Address(RVA = "0x2A56F90", Offset = "0x2A56190", VA = "0x182A56F90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
