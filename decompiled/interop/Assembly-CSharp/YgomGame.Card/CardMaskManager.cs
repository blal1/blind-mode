using Il2CppDummyDll;

namespace YgomGame.Card;

[Token(Token = "0x2001610")]
public class CardMaskManager : CardTextureManagerBase
{
	[Token(Token = "0x6008930")]
	[Address(RVA = "0xD484F0", Offset = "0xD476F0", VA = "0x180D484F0")]
	public static CardMaskManager Create()
	{
		return null;
	}

	[Token(Token = "0x6008931")]
	[Address(RVA = "0xD48590", Offset = "0xD47790", VA = "0x180D48590", Slot = "4")]
	public override void RecreateCardCreator()
	{
	}

	[Token(Token = "0x6008932")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardMaskManager()
	{
	}
}
