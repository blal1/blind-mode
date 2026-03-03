using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001969")]
public class CardEffectCheatAppearEffect : CardEffectBase
{
	[Token(Token = "0x400EC42")]
	[FieldOffset(Offset = "0x28")]
	private bool waitEffect;

	[Token(Token = "0x400EC43")]
	[FieldOffset(Offset = "0x29")]
	private bool isInsight;

	[Token(Token = "0x400EC44")]
	[FieldOffset(Offset = "0x30")]
	private Action onEffectFinished;

	[Token(Token = "0x600A32F")]
	[Address(RVA = "0xF02490", Offset = "0xF01690", VA = "0x180F02490")]
	public static CardEffectCheatAppearEffect Create(CardRoot cardRoot, bool waitEffect, bool isInsight, Action onEffectFinished)
	{
		return null;
	}

	[Token(Token = "0x600A330")]
	[Address(RVA = "0xF02610", Offset = "0xF01810", VA = "0x180F02610", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A331")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectCheatAppearEffect()
	{
	}
}
