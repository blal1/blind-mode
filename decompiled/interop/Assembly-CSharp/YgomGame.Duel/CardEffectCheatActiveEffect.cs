using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001967")]
public class CardEffectCheatActiveEffect : CardEffectBase
{
	[Token(Token = "0x400EC3C")]
	[FieldOffset(Offset = "0x28")]
	private bool waitEffect;

	[Token(Token = "0x400EC3D")]
	[FieldOffset(Offset = "0x30")]
	private Action onEffectFinished;

	[Token(Token = "0x600A329")]
	[Address(RVA = "0xF021F0", Offset = "0xF013F0", VA = "0x180F021F0")]
	public static CardEffectCheatActiveEffect Create(CardRoot cardRoot, bool waitEffect, Action onEffectFinished)
	{
		return null;
	}

	[Token(Token = "0x600A32A")]
	[Address(RVA = "0xF02350", Offset = "0xF01550", VA = "0x180F02350", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A32B")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectCheatActiveEffect()
	{
	}
}
