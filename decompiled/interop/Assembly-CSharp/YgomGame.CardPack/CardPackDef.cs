using Il2CppDummyDll;

namespace YgomGame.CardPack;

[Token(Token = "0x2001527")]
public static class CardPackDef
{
	[Token(Token = "0x2001528")]
	public enum PackType
	{
		[Token(Token = "0x400CB6F")]
		None,
		[Token(Token = "0x400CB70")]
		Standard,
		[Token(Token = "0x400CB71")]
		Pickup,
		[Token(Token = "0x400CB72")]
		Secret,
		[Token(Token = "0x400CB73")]
		Bonus
	}
}
