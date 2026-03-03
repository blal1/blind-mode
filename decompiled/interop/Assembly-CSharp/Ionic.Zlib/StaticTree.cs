using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000DD")]
internal sealed class StaticTree
{
	[Token(Token = "0x4000503")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly short[] lengthAndLiteralsTreeCodes;

	[Token(Token = "0x4000504")]
	[FieldOffset(Offset = "0x8")]
	internal static readonly short[] distTreeCodes;

	[Token(Token = "0x4000505")]
	[FieldOffset(Offset = "0x10")]
	internal static readonly StaticTree Literals;

	[Token(Token = "0x4000506")]
	[FieldOffset(Offset = "0x18")]
	internal static readonly StaticTree Distances;

	[Token(Token = "0x4000507")]
	[FieldOffset(Offset = "0x20")]
	internal static readonly StaticTree BitLengths;

	[Token(Token = "0x4000508")]
	[FieldOffset(Offset = "0x10")]
	internal short[] treeCodes;

	[Token(Token = "0x4000509")]
	[FieldOffset(Offset = "0x18")]
	internal int[] extraBits;

	[Token(Token = "0x400050A")]
	[FieldOffset(Offset = "0x20")]
	internal int extraBase;

	[Token(Token = "0x400050B")]
	[FieldOffset(Offset = "0x24")]
	internal int elems;

	[Token(Token = "0x400050C")]
	[FieldOffset(Offset = "0x28")]
	internal int maxLength;

	[Token(Token = "0x60003FA")]
	[Address(RVA = "0x798E70", Offset = "0x798070", VA = "0x180798E70")]
	private StaticTree(short[] treeCodes, int[] extraBits, int extraBase, int elems, int maxLength)
	{
	}

	[Token(Token = "0x60003FB")]
	[Address(RVA = "0x798B30", Offset = "0x797D30", VA = "0x180798B30")]
	static StaticTree()
	{
	}
}
