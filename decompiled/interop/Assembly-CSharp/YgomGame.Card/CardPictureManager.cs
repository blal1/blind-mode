using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Card;

[Token(Token = "0x2001624")]
public class CardPictureManager : CardTextureManagerBase
{
	[Token(Token = "0x400D4E4")]
	[FieldOffset(Offset = "0x50")]
	private CardIllustManager m_CardIllustManager;

	[Token(Token = "0x60089B5")]
	[Address(RVA = "0xD4DAD0", Offset = "0xD4CCD0", VA = "0x180D4DAD0")]
	public static CardPictureManager Create(CardIllustManager cardIllustManager)
	{
		return null;
	}

	[Token(Token = "0x60089B6")]
	[Address(RVA = "0xD4DB90", Offset = "0xD4CD90", VA = "0x180D4DB90")]
	public Texture GetLoadingCardTexture(int cardid)
	{
		return null;
	}

	[Token(Token = "0x60089B7")]
	[Address(RVA = "0xD4DC40", Offset = "0xD4CE40", VA = "0x180D4DC40")]
	public void IgnoreCardIllust(bool enable)
	{
	}

	[Token(Token = "0x60089B8")]
	[Address(RVA = "0xD4DCE0", Offset = "0xD4CEE0", VA = "0x180D4DCE0", Slot = "4")]
	public override void RecreateCardCreator()
	{
	}

	[Token(Token = "0x60089B9")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardPictureManager()
	{
	}
}
