using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001909")]
public struct ShowChainData
{
	[Token(Token = "0x200190A")]
	public enum ChainDataType
	{
		[Token(Token = "0x400EA58")]
		SET,
		[Token(Token = "0x400EA59")]
		RUN,
		[Token(Token = "0x400EA5A")]
		STEP,
		[Token(Token = "0x400EA5B")]
		END
	}

	[Token(Token = "0x400EA53")]
	[FieldOffset(Offset = "0x0")]
	public short cardid;

	[Token(Token = "0x400EA54")]
	[FieldOffset(Offset = "0x2")]
	public short chainnum;

	[Token(Token = "0x400EA55")]
	[FieldOffset(Offset = "0x4")]
	public bool team;

	[Token(Token = "0x400EA56")]
	[FieldOffset(Offset = "0x8")]
	public ChainDataType type;

	[Token(Token = "0x600A196")]
	[Address(RVA = "0xEF9360", Offset = "0xEF8560", VA = "0x180EF9360")]
	public ShowChainData(bool team, int cardid, int chainnum, ChainDataType type)
	{
	}
}
