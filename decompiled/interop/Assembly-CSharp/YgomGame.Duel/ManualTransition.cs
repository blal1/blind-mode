using Il2CppDummyDll;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x2001B84")]
public struct ManualTransition
{
	[Token(Token = "0x400F9B3")]
	[FieldOffset(Offset = "0x0")]
	public PadInputDirection direction;

	[Token(Token = "0x400F9B4")]
	[FieldOffset(Offset = "0x4")]
	public int index;

	[Token(Token = "0x600B304")]
	[Address(RVA = "0x4ADCD0", Offset = "0x4ACED0", VA = "0x1804ADCD0")]
	public ManualTransition(int index, PadInputDirection direction)
	{
	}
}
