using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20018F3")]
public class ListCardBaseData
{
	[Token(Token = "0x400E97D")]
	[FieldOffset(Offset = "0x10")]
	public int cardid;

	[Token(Token = "0x400E97E")]
	[FieldOffset(Offset = "0x14")]
	public int premid;

	[Token(Token = "0x400E97F")]
	[FieldOffset(Offset = "0x18")]
	public int dataindex;

	[Token(Token = "0x600A0C6")]
	[Address(RVA = "0xEDE990", Offset = "0xEDDB90", VA = "0x180EDE990")]
	public ListCardBaseData(int cardid, int dataindex)
	{
	}

	[Token(Token = "0x600A0C7")]
	[Address(RVA = "0xEDE9D0", Offset = "0xEDDBD0", VA = "0x180EDE9D0")]
	public ListCardBaseData(int cardid, int premid, int dataindex)
	{
	}
}
