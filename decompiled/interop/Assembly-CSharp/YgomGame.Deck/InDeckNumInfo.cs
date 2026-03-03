using Il2CppDummyDll;

namespace YgomGame.Deck;

[Token(Token = "0x2001057")]
public class InDeckNumInfo
{
	[Token(Token = "0x400AE4A")]
	[FieldOffset(Offset = "0x10")]
	public int N;

	[Token(Token = "0x400AE4B")]
	[FieldOffset(Offset = "0x14")]
	public int aN;

	[Token(Token = "0x400AE4C")]
	[FieldOffset(Offset = "0x18")]
	public int P1;

	[Token(Token = "0x400AE4D")]
	[FieldOffset(Offset = "0x1C")]
	public int aP1;

	[Token(Token = "0x400AE4E")]
	[FieldOffset(Offset = "0x20")]
	public int P2;

	[Token(Token = "0x400AE4F")]
	[FieldOffset(Offset = "0x24")]
	public int aP2;

	[Token(Token = "0x400AE50")]
	[FieldOffset(Offset = "0x28")]
	public int rental;

	[Token(Token = "0x400AE51")]
	[FieldOffset(Offset = "0x2C")]
	public int aRental;

	[Token(Token = "0x60062F8")]
	[Address(RVA = "0xA92590", Offset = "0xA91790", VA = "0x180A92590")]
	public InDeckNumInfo(int N, int aN, int P1, int aP1, int P2, int aP2, int R, int aR)
	{
	}
}
