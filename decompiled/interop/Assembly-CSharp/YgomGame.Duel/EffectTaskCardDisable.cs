using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AD9")]
public class EffectTaskCardDisable : EffectTask
{
	[Token(Token = "0x2001ADA")]
	private enum Step
	{
		[Token(Token = "0x400F62C")]
		WaitInit,
		[Token(Token = "0x400F62D")]
		WaitCardLoad,
		[Token(Token = "0x400F62E")]
		Show,
		[Token(Token = "0x400F62F")]
		WaitEffect,
		[Token(Token = "0x400F630")]
		Finish
	}

	[Token(Token = "0x400F61C")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F61D")]
	[FieldOffset(Offset = "0x20")]
	private CardShow cardShow;

	[Token(Token = "0x400F61E")]
	[FieldOffset(Offset = "0x28")]
	private SimpleEffect effAura;

	[Token(Token = "0x400F61F")]
	[FieldOffset(Offset = "0x30")]
	private int player;

	[Token(Token = "0x400F620")]
	[FieldOffset(Offset = "0x34")]
	private int position;

	[Token(Token = "0x400F621")]
	[FieldOffset(Offset = "0x38")]
	private int index;

	[Token(Token = "0x400F622")]
	[FieldOffset(Offset = "0x3C")]
	private int uniqueID;

	[Token(Token = "0x400F623")]
	[FieldOffset(Offset = "0x40")]
	private int cardID;

	[Token(Token = "0x400F624")]
	[FieldOffset(Offset = "0x44")]
	private bool face;

	[Token(Token = "0x400F625")]
	[FieldOffset(Offset = "0x48")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F626")]
	[FieldOffset(Offset = "0x50")]
	private bool tempCard;

	[Token(Token = "0x400F627")]
	[FieldOffset(Offset = "0x51")]
	private bool isAttacker;

	[Token(Token = "0x400F628")]
	[FieldOffset(Offset = "0x52")]
	private bool isCardRunEffectPlaying;

	[Token(Token = "0x400F629")]
	[FieldOffset(Offset = "0x58")]
	private CardRunEffect.CardRunEffectUnit cardRunEffectUnit;

	[Token(Token = "0x400F62A")]
	[FieldOffset(Offset = "0x60")]
	private Step step;

	[Token(Token = "0x600AE7F")]
	[Address(RVA = "0x458490", Offset = "0x457690", VA = "0x180458490")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE80")]
	[Address(RVA = "0x457C80", Offset = "0x456E80", VA = "0x180457C80")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE81")]
	[Address(RVA = "0x458EB0", Offset = "0x4580B0", VA = "0x180458EB0")]
	public EffectTaskCardDisable(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AE82")]
	[Address(RVA = "0x458B70", Offset = "0x457D70", VA = "0x180458B70", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE83")]
	[Address(RVA = "0x458720", Offset = "0x457920", VA = "0x180458720")]
	private void StepWaitInit()
	{
	}

	[Token(Token = "0x600AE84")]
	[Address(RVA = "0x458C00", Offset = "0x457E00", VA = "0x180458C00")]
	private void WaitCardLoad()
	{
	}

	[Token(Token = "0x600AE85")]
	[Address(RVA = "0x4586F0", Offset = "0x4578F0", VA = "0x1804586F0")]
	private void StepShow()
	{
	}

	[Token(Token = "0x600AE86")]
	[Address(RVA = "0x457ED0", Offset = "0x4570D0", VA = "0x180457ED0")]
	private void OnInit()
	{
	}

	[Token(Token = "0x600AE87")]
	[Address(RVA = "0x457FA0", Offset = "0x4571A0", VA = "0x180457FA0")]
	private void OnMove()
	{
	}

	[Token(Token = "0x600AE88")]
	[Address(RVA = "0x4583A0", Offset = "0x4575A0", VA = "0x1804583A0")]
	private void OnWait()
	{
	}

	[Token(Token = "0x600AE89")]
	[Address(RVA = "0x457D20", Offset = "0x456F20", VA = "0x180457D20")]
	private void OnBack()
	{
	}

	[Token(Token = "0x600AE8A")]
	[Address(RVA = "0x457DE0", Offset = "0x456FE0", VA = "0x180457DE0")]
	private void OnFinish()
	{
	}

	[Token(Token = "0x600AE8B")]
	[Address(RVA = "0x458710", Offset = "0x457910", VA = "0x180458710")]
	private void StepWaitEffect()
	{
	}
}
