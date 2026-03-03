using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001971")]
public class CardEffectOneShotEffect : CardEffectBase
{
	[Token(Token = "0x2001972")]
	public enum Mode
	{
		[Token(Token = "0x400EC65")]
		TraceRootPosition,
		[Token(Token = "0x400EC66")]
		TraceRootPosture,
		[Token(Token = "0x400EC67")]
		TraceCardPosition,
		[Token(Token = "0x400EC68")]
		TraceCardPosture,
		[Token(Token = "0x400EC69")]
		Child
	}

	[Token(Token = "0x400EC5F")]
	[FieldOffset(Offset = "0x28")]
	protected DuelEffectPool.Type type;

	[Token(Token = "0x400EC60")]
	[FieldOffset(Offset = "0x2C")]
	protected bool waitEffect;

	[Token(Token = "0x400EC61")]
	[FieldOffset(Offset = "0x30")]
	protected Mode mode;

	[Token(Token = "0x400EC62")]
	[FieldOffset(Offset = "0x34")]
	protected Quaternion rotation;

	[Token(Token = "0x400EC63")]
	[FieldOffset(Offset = "0x48")]
	protected SimpleEffect effect;

	[Token(Token = "0x600A34A")]
	[Address(RVA = "0xF04090", Offset = "0xF03290", VA = "0x180F04090")]
	public static CardEffectOneShotEffect Create(CardRoot cardRoot, DuelEffectPool.Type type, Mode mode, bool waitEffect, Quaternion rotation)
	{
		return null;
	}

	[Token(Token = "0x600A34B")]
	[Address(RVA = "0xF04210", Offset = "0xF03410", VA = "0x180F04210", Slot = "4")]
	public override void StartEffect()
	{
	}

	[Token(Token = "0x600A34C")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CardEffectOneShotEffect()
	{
	}
}
