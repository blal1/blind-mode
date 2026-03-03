using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001907")]
public struct ShowCardNameData
{
	[Token(Token = "0x400EA49")]
	[FieldOffset(Offset = "0x0")]
	public short cardid;

	[Token(Token = "0x400EA4A")]
	[FieldOffset(Offset = "0x2")]
	public bool team;

	[Token(Token = "0x400EA4B")]
	[FieldOffset(Offset = "0x3")]
	public bool indent;

	[Token(Token = "0x400EA4C")]
	[FieldOffset(Offset = "0x4")]
	public bool isCost;

	[Token(Token = "0x600A192")]
	[Address(RVA = "0xEF9340", Offset = "0xEF8540", VA = "0x180EF9340")]
	public ShowCardNameData(int cardid, bool team, bool indent, bool isCost = false)
	{
	}
}
