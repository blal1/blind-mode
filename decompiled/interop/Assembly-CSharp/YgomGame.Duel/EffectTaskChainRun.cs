using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B04")]
public class EffectTaskChainRun : EffectTask
{
	[Token(Token = "0x2001B05")]
	private enum Step
	{
		[Token(Token = "0x400F72D")]
		WaitCardEffect,
		[Token(Token = "0x400F72E")]
		WaitChainEffect,
		[Token(Token = "0x400F72F")]
		Finish
	}

	[Token(Token = "0x400F729")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F72A")]
	[FieldOffset(Offset = "0x1C")]
	private bool finished;

	[Token(Token = "0x400F72B")]
	[FieldOffset(Offset = "0x20")]
	private int num;

	[Token(Token = "0x600AF37")]
	[Address(RVA = "0x467820", Offset = "0x466A20", VA = "0x180467820")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF38")]
	[Address(RVA = "0x467910", Offset = "0x466B10", VA = "0x180467910")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF39")]
	[Address(RVA = "0x4676C0", Offset = "0x4668C0", VA = "0x1804676C0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF3A")]
	[Address(RVA = "0x467C80", Offset = "0x466E80", VA = "0x180467C80")]
	public EffectTaskChainRun(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF3B")]
	[Address(RVA = "0x467A50", Offset = "0x466C50", VA = "0x180467A50", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF3C")]
	[Address(RVA = "0x467B90", Offset = "0x466D90", VA = "0x180467B90")]
	private void WaitCardEffectStep()
	{
	}

	[Token(Token = "0x600AF3D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitChainEffectStep()
	{
	}

	[Token(Token = "0x600AF3E")]
	[Address(RVA = "0x467900", Offset = "0x466B00", VA = "0x180467900")]
	private void OnFinishChainEffect()
	{
	}

	[Token(Token = "0x600AF3F")]
	[Address(RVA = "0x4677E0", Offset = "0x4669E0", VA = "0x1804677E0")]
	private void FinishStep()
	{
	}
}
