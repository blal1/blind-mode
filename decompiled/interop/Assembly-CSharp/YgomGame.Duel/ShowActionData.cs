using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001902")]
public struct ShowActionData
{
	[Token(Token = "0x400EA05")]
	[FieldOffset(Offset = "0x0")]
	public LogDataSide datal;

	[Token(Token = "0x400EA06")]
	[FieldOffset(Offset = "0x8")]
	public LogDataSide datar;

	[Token(Token = "0x400EA07")]
	[FieldOffset(Offset = "0x10")]
	public LogDataCenter datac;

	[Token(Token = "0x400EA08")]
	[FieldOffset(Offset = "0x1C")]
	public bool isCost;

	[Token(Token = "0x600A169")]
	[Address(RVA = "0xEF9310", Offset = "0xEF8510", VA = "0x180EF9310")]
	public ShowActionData(LogDataSide datal, LogDataSide datar, LogDataCenter datac, bool isCost = false)
	{
	}

	[Token(Token = "0x600A16A")]
	[Address(RVA = "0xEF92F0", Offset = "0xEF84F0", VA = "0x180EF92F0")]
	public bool IsShowArrow()
	{
		return default(bool);
	}
}
