using Il2CppDummyDll;

namespace YgomGame.Common;

[Token(Token = "0x2000C4D")]
public static class JsonObjectAnalyzer
{
	[Token(Token = "0x4009AAD")]
	[FieldOffset(Offset = "0x0")]
	public static readonly JsonCardAnalyzer cardAnalyzer;

	[Token(Token = "0x4009AAE")]
	[FieldOffset(Offset = "0x8")]
	public static readonly JsonStructureAnalyzer structure;

	[Token(Token = "0x4009AAF")]
	[FieldOffset(Offset = "0x10")]
	public static readonly JsonShopAnalyzer shop;

	[Token(Token = "0x6004AED")]
	[Address(RVA = "0x933820", Offset = "0x932A20", VA = "0x180933820")]
	static JsonObjectAnalyzer()
	{
	}
}
