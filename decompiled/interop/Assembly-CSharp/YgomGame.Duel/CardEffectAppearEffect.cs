using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001962")]
public class CardEffectAppearEffect : CardEffectBase
{
	[Token(Token = "0x400EC2E")]
	[FieldOffset(Offset = "0x28")]
	private bool isToken;

	[Token(Token = "0x400EC2F")]
	[FieldOffset(Offset = "0x29")]
	private bool waitEffect;

	[Token(Token = "0x400EC30")]
	[FieldOffset(Offset = "0x30")]
	private Action onEffectFinished;

	[Token(Token = "0x600A312")]
	[Address(RVA = "0xF017C0", Offset = "0xF009C0", VA = "0x180F017C0")]
	public static CardEffectAppearEffect Create(CardRoot cardRoot, bool isToken, bool waitEffect, Action onEffectFinished)
	{
		return null;
	}

	[Token(Token = "0x600A313")]
	[Address(RVA = "0xF01940", Offset = "0xF00B40", VA = "0x180F01940", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A314")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectAppearEffect()
	{
	}
}
