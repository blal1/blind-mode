using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x20018F6")]
public struct ChoiceFirstPlayerData
{
	[Token(Token = "0x400E986")]
	[FieldOffset(Offset = "0x0")]
	public int choicePlayer;

	[Token(Token = "0x400E987")]
	[FieldOffset(Offset = "0x4")]
	public int firstPlayer;

	[Token(Token = "0x400E988")]
	[FieldOffset(Offset = "0x8")]
	public int myID;

	[Token(Token = "0x600A0D5")]
	[Address(RVA = "0xED0490", Offset = "0xECF690", VA = "0x180ED0490")]
	public ChoiceFirstPlayerData(int choicePlayer, int firstPlayer)
	{
	}
}
