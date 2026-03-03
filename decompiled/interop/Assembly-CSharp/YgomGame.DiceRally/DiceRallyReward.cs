using Il2CppDummyDll;

namespace YgomGame.DiceRally;

[Token(Token = "0x2000F96")]
public class DiceRallyReward
{
	[Token(Token = "0x400A920")]
	[FieldOffset(Offset = "0x10")]
	public bool isPeriod;

	[Token(Token = "0x400A921")]
	[FieldOffset(Offset = "0x14")]
	public int itemCategory;

	[Token(Token = "0x400A922")]
	[FieldOffset(Offset = "0x18")]
	public int itemId;

	[Token(Token = "0x400A923")]
	[FieldOffset(Offset = "0x1C")]
	public int itemNum;

	[Token(Token = "0x400A924")]
	[FieldOffset(Offset = "0x20")]
	public int premiumId;

	[Token(Token = "0x6005EA4")]
	[Address(RVA = "0xA36440", Offset = "0xA35640", VA = "0x180A36440")]
	public DiceRallyReward(bool isPeriod, int itemCategory, int itemId, int itemNum = -1, int premiumId = 1)
	{
	}
}
