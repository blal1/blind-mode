using Il2CppDummyDll;

namespace YgomGame.Deck;

[Token(Token = "0x2001056")]
public class AlterCompensation
{
	[Token(Token = "0x400AE45")]
	[FieldOffset(Offset = "0x10")]
	public int id;

	[Token(Token = "0x400AE46")]
	[FieldOffset(Offset = "0x14")]
	public int category;

	[Token(Token = "0x400AE47")]
	[FieldOffset(Offset = "0x18")]
	public int itemId;

	[Token(Token = "0x400AE48")]
	[FieldOffset(Offset = "0x1C")]
	public bool isPeriod;

	[Token(Token = "0x400AE49")]
	[FieldOffset(Offset = "0x20")]
	public int num;

	[Token(Token = "0x60062F7")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AlterCompensation()
	{
	}
}
