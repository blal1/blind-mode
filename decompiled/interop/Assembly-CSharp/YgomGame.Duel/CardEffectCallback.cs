using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001965")]
public class CardEffectCallback : CardEffectBase
{
	[Token(Token = "0x400EC39")]
	[FieldOffset(Offset = "0x28")]
	private float delay;

	[Token(Token = "0x400EC3A")]
	[FieldOffset(Offset = "0x2C")]
	private float currentTime;

	[Token(Token = "0x600A322")]
	[Address(RVA = "0xF02040", Offset = "0xF01240", VA = "0x180F02040")]
	public static CardEffectCallback Create(CardRoot cardRoot, float delay, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A323")]
	[Address(RVA = "0xF020E0", Offset = "0xF012E0", VA = "0x180F020E0", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A324")]
	[Address(RVA = "0xF020F0", Offset = "0xF012F0", VA = "0x180F020F0", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A325")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectCallback()
	{
	}
}
