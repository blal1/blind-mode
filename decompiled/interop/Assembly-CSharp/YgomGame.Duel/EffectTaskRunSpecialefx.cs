using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B58")]
public class EffectTaskRunSpecialefx : EffectTask
{
	[Token(Token = "0x2001B59")]
	private enum EffectType
	{
		[Token(Token = "0x400F89E")]
		None,
		[Token(Token = "0x400F89F")]
		InfiniteImpermanence,
		[Token(Token = "0x400F8A0")]
		EffectVeiler,
		[Token(Token = "0x400F8A1")]
		EffectVeilerAlt,
		[Token(Token = "0x400F8A2")]
		SnowRabbit,
		[Token(Token = "0x400F8A3")]
		SnowRabbitAlt,
		[Token(Token = "0x400F8A4")]
		MysticalSpaceTyphoon
	}

	[Token(Token = "0x2001B5A")]
	private enum Step
	{
		[Token(Token = "0x400F8A6")]
		WaitLoad,
		[Token(Token = "0x400F8A7")]
		PlayEffect,
		[Token(Token = "0x400F8A8")]
		WaitEffect,
		[Token(Token = "0x400F8A9")]
		Finished
	}

	[Token(Token = "0x400F894")]
	[FieldOffset(Offset = "0x18")]
	private int cardID;

	[Token(Token = "0x400F895")]
	[FieldOffset(Offset = "0x1C")]
	private int param2;

	[Token(Token = "0x400F896")]
	[FieldOffset(Offset = "0x20")]
	private int param3;

	[Token(Token = "0x400F897")]
	[FieldOffset(Offset = "0x24")]
	private bool finished;

	[Token(Token = "0x400F898")]
	[FieldOffset(Offset = "0x28")]
	private CardRunEffect.CardRunEffectUnit cardRunEffectUnit;

	[Token(Token = "0x400F899")]
	[FieldOffset(Offset = "0x30")]
	private EffectType effectType;

	[Token(Token = "0x400F89A")]
	[FieldOffset(Offset = "0x34")]
	private Step step;

	[Token(Token = "0x400F89B")]
	[FieldOffset(Offset = "0x38")]
	private int loadCounter;

	[Token(Token = "0x400F89C")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<int, EffectType> spfxList;

	[Token(Token = "0x600B06E")]
	[Address(RVA = "0x47EFD0", Offset = "0x47E1D0", VA = "0x18047EFD0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B06F")]
	[Address(RVA = "0x47EF30", Offset = "0x47E130", VA = "0x18047EF30")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B070")]
	[Address(RVA = "0x480C10", Offset = "0x47FE10", VA = "0x180480C10")]
	public EffectTaskRunSpecialefx(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B071")]
	[Address(RVA = "0x4808D0", Offset = "0x47FAD0", VA = "0x1804808D0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B072")]
	[Address(RVA = "0x480AA0", Offset = "0x47FCA0", VA = "0x180480AA0")]
	private void WaitLoadStep()
	{
	}

	[Token(Token = "0x600B073")]
	[Address(RVA = "0x47F290", Offset = "0x47E490", VA = "0x18047F290")]
	private bool PlayEffectStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600B074")]
	[Address(RVA = "0x47F8B0", Offset = "0x47EAB0", VA = "0x18047F8B0")]
	private void PlayInfiniteImtermanence()
	{
	}

	[Token(Token = "0x600B075")]
	[Address(RVA = "0x47F630", Offset = "0x47E830", VA = "0x18047F630")]
	private void PlayEffectVeiler()
	{
	}

	[Token(Token = "0x600B076")]
	[Address(RVA = "0x47F3B0", Offset = "0x47E5B0", VA = "0x18047F3B0")]
	private void PlayEffectVeilerAlt()
	{
	}

	[Token(Token = "0x600B077")]
	[Address(RVA = "0x4805A0", Offset = "0x47F7A0", VA = "0x1804805A0")]
	private void PlaySnowRabbit()
	{
	}

	[Token(Token = "0x600B078")]
	[Address(RVA = "0x4802B0", Offset = "0x47F4B0", VA = "0x1804802B0")]
	private void PlaySnowRabbitAlt()
	{
	}

	[Token(Token = "0x600B079")]
	[Address(RVA = "0x47FFC0", Offset = "0x47F1C0", VA = "0x18047FFC0")]
	private void PlayMysticalSpaceTyphoon()
	{
	}

	[Token(Token = "0x600B07A")]
	[Address(RVA = "0x480A80", Offset = "0x47FC80", VA = "0x180480A80")]
	private bool WaitEffectStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600B07B")]
	[Address(RVA = "0x47EFC0", Offset = "0x47E1C0", VA = "0x18047EFC0")]
	private void FinishedStep()
	{
	}
}
