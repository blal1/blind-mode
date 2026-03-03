using System;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001970")]
public class CardEffectMove : CardEffectBase
{
	[Token(Token = "0x400EC56")]
	[FieldOffset(Offset = "0x28")]
	private CardLocator from;

	[Token(Token = "0x400EC57")]
	[FieldOffset(Offset = "0x30")]
	private CardLocator to;

	[Token(Token = "0x400EC58")]
	[FieldOffset(Offset = "0x38")]
	private bool isFace;

	[Token(Token = "0x400EC59")]
	[FieldOffset(Offset = "0x39")]
	private bool isAttack;

	[Token(Token = "0x400EC5A")]
	[FieldOffset(Offset = "0x3A")]
	private bool immediate;

	[Token(Token = "0x400EC5B")]
	[FieldOffset(Offset = "0x3B")]
	private bool firstUpdate;

	[Token(Token = "0x400EC5C")]
	[FieldOffset(Offset = "0x40")]
	private CardRootTransition transition;

	[Token(Token = "0x400EC5D")]
	[FieldOffset(Offset = "0x48")]
	private Action onStarted;

	[Token(Token = "0x400EC5E")]
	[FieldOffset(Offset = "0x50")]
	private bool finishFlipTurn;

	[Token(Token = "0x600A344")]
	[Address(RVA = "0xF03A50", Offset = "0xF02C50", VA = "0x180F03A50")]
	public static CardEffectMove Create(CardRoot cardRoot, CardLocator from, CardLocator to, bool isFace, bool isAttack, bool immediate, CardRootTransition transition, Action onStarted, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A345")]
	[Address(RVA = "0xF03980", Offset = "0xF02B80", VA = "0x180F03980")]
	public static CardEffectMove CreateFlipTurn(CardRoot cardRoot, bool isFace, bool isAttack, bool immediate, Action onStarted, Action onFinished)
	{
		return null;
	}

	[Token(Token = "0x600A346")]
	[Address(RVA = "0xF03B80", Offset = "0xF02D80", VA = "0x180F03B80", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A347")]
	[Address(RVA = "0xF03E50", Offset = "0xF03050", VA = "0x180F03E50", Slot = "5")]
	public override bool UpdateEffect()
	{
		return default(bool);
	}

	[Token(Token = "0x600A348")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectMove()
	{
	}
}
