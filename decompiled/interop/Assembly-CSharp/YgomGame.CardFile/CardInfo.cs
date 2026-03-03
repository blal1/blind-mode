using Il2CppDummyDll;

namespace YgomGame.CardFile;

[Token(Token = "0x20015B5")]
public class CardInfo
{
	[Token(Token = "0x20015B6")]
	public enum PossessionStatus
	{
		[Token(Token = "0x400CE82")]
		Unknown,
		[Token(Token = "0x400CE83")]
		NotPossessing,
		[Token(Token = "0x400CE84")]
		PossessingNew,
		[Token(Token = "0x400CE85")]
		Possessing
	}

	[Token(Token = "0x400CE7D")]
	[FieldOffset(Offset = "0x10")]
	public int cardID;

	[Token(Token = "0x400CE7E")]
	[FieldOffset(Offset = "0x14")]
	public int premium;

	[Token(Token = "0x400CE7F")]
	[FieldOffset(Offset = "0x18")]
	public CardFileDefinition.PremiumType requiredPremiumType;

	[Token(Token = "0x400CE80")]
	[FieldOffset(Offset = "0x1C")]
	public PossessionStatus status;

	[Token(Token = "0x6008689")]
	[Address(RVA = "0xCF9B70", Offset = "0xCF8D70", VA = "0x180CF9B70")]
	public CardInfo(int cardID, int premium, CardFileDefinition.PremiumType requiredPremiumType, PossessionStatus status)
	{
	}

	[Token(Token = "0x600868A")]
	[Address(RVA = "0xCF9B60", Offset = "0xCF8D60", VA = "0x180CF9B60")]
	public void FlushFlags()
	{
	}
}
