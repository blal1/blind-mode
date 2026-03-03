using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001913")]
public struct ShowTextData
{
	[Token(Token = "0x400EA75")]
	[FieldOffset(Offset = "0x0")]
	public short textid;

	[Token(Token = "0x400EA76")]
	[FieldOffset(Offset = "0x2")]
	public bool indent;

	[Token(Token = "0x600A1AE")]
	[Address(RVA = "0xEF9390", Offset = "0xEF8590", VA = "0x180EF9390")]
	public ShowTextData(int textid, bool indent)
	{
	}
}
