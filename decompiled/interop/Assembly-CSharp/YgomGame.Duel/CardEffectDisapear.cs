using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x200196C")]
public class CardEffectDisapear : CardEffectBase
{
	[Token(Token = "0x600A33A")]
	[Address(RVA = "0xF02FA0", Offset = "0xF021A0", VA = "0x180F02FA0")]
	public static CardEffectDisapear Create(CardRoot cardRoot, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A33B")]
	[Address(RVA = "0xF03030", Offset = "0xF02230", VA = "0x180F03030", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A33C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectDisapear()
	{
	}
}
