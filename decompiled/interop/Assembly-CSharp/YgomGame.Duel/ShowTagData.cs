using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001911")]
public struct ShowTagData
{
	[Token(Token = "0x400EA6D")]
	[FieldOffset(Offset = "0x0")]
	public ShowTagType type;

	[Token(Token = "0x400EA6E")]
	[FieldOffset(Offset = "0x4")]
	public bool isIndent;

	[Token(Token = "0x600A1A7")]
	[Address(RVA = "0xEF9380", Offset = "0xEF8580", VA = "0x180EF9380")]
	public ShowTagData(ShowTagType type, bool isIndent)
	{
	}
}
