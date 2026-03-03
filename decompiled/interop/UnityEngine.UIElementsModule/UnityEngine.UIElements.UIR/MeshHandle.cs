using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200051D")]
internal class MeshHandle : LinkedPoolItem<MeshHandle>
{
	[Token(Token = "0x40010D5")]
	[FieldOffset(Offset = "0x18")]
	internal Alloc allocVerts;

	[Token(Token = "0x40010D6")]
	[FieldOffset(Offset = "0x30")]
	internal Alloc allocIndices;

	[Token(Token = "0x40010D7")]
	[FieldOffset(Offset = "0x48")]
	internal uint triangleCount;

	[Token(Token = "0x40010D8")]
	[FieldOffset(Offset = "0x50")]
	internal Page allocPage;

	[Token(Token = "0x40010D9")]
	[FieldOffset(Offset = "0x58")]
	internal uint allocTime;

	[Token(Token = "0x40010DA")]
	[FieldOffset(Offset = "0x5C")]
	internal uint updateAllocID;

	[Token(Token = "0x60024A0")]
	[Address(RVA = "0x2A31E10", Offset = "0x2A31010", VA = "0x182A31E10")]
	public MeshHandle()
	{
	}
}
