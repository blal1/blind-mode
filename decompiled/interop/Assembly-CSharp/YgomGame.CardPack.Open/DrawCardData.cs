using Il2CppDummyDll;
using YgomGame.Card;
using YgomSystem.ElementSystem;

namespace YgomGame.CardPack.Open;

[Token(Token = "0x200154C")]
public class DrawCardData
{
	[Token(Token = "0x400CC1D")]
	[FieldOffset(Offset = "0x10")]
	public int mrk;

	[Token(Token = "0x400CC1E")]
	[FieldOffset(Offset = "0x14")]
	public int premium;

	[Token(Token = "0x400CC1F")]
	[FieldOffset(Offset = "0x18")]
	public int locatePos;

	[Token(Token = "0x400CC20")]
	[FieldOffset(Offset = "0x1C")]
	public bool isNew;

	[Token(Token = "0x400CC21")]
	[FieldOffset(Offset = "0x20")]
	public int foundSecretNum;

	[Token(Token = "0x400CC22")]
	[FieldOffset(Offset = "0x28")]
	public ElementObjectManager cardPref;

	[Token(Token = "0x400CC23")]
	[FieldOffset(Offset = "0x30")]
	public bool isVisibleRarityFrame;

	[Token(Token = "0x400CC24")]
	[FieldOffset(Offset = "0x34")]
	public CardCollectionInfo.Rarity backSideRarity;

	[Token(Token = "0x17001411")]
	public CardCollectionInfo.Rarity rarity
	{
		[Token(Token = "0x600839B")]
		[Address(RVA = "0xCBDB90", Offset = "0xCBCD90", VA = "0x180CBDB90")]
		get
		{
			return default(CardCollectionInfo.Rarity);
		}
	}

	[Token(Token = "0x600839C")]
	[Address(RVA = "0xCBDB70", Offset = "0xCBCD70", VA = "0x180CBDB70")]
	public DrawCardData()
	{
	}
}
