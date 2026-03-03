using System.Collections.Generic;
using Il2CppDummyDll;
using YgomGame.Card;

namespace YgomGame.CardPack.Open;

[Token(Token = "0x200154D")]
public class DrawPackData
{
	[Token(Token = "0x400CC25")]
	[FieldOffset(Offset = "0x10")]
	public readonly List<DrawCardData> drawCardDatas;

	[Token(Token = "0x400CC26")]
	[FieldOffset(Offset = "0x18")]
	public string packImagePath;

	[Token(Token = "0x400CC27")]
	[FieldOffset(Offset = "0x20")]
	public CardCollectionInfo.Rarity packType;

	[Token(Token = "0x400CC28")]
	[FieldOffset(Offset = "0x24")]
	public CardCollectionInfo.Rarity packTypeUpgrade1;

	[Token(Token = "0x400CC29")]
	[FieldOffset(Offset = "0x28")]
	public CardCollectionInfo.Rarity packTypeUpgrade2;

	[Token(Token = "0x400CC2A")]
	[FieldOffset(Offset = "0x2C")]
	public int thunderType;

	[Token(Token = "0x400CC2B")]
	[FieldOffset(Offset = "0x30")]
	public int cutType;

	[Token(Token = "0x600839D")]
	[Address(RVA = "0xCBDBE0", Offset = "0xCBCDE0", VA = "0x180CBDBE0")]
	public DrawPackData()
	{
	}
}
