using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B02")]
public class EffectTaskChainEnd : EffectTask
{
	[Token(Token = "0x2001B03")]
	private enum Step
	{
		[Token(Token = "0x400F726")]
		WaitCardEffect,
		[Token(Token = "0x400F727")]
		WaitTutorial,
		[Token(Token = "0x400F728")]
		Finish
	}

	[Token(Token = "0x400F723")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F724")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x600AF2F")]
	[Address(RVA = "0x4672F0", Offset = "0x4664F0", VA = "0x1804672F0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF30")]
	[Address(RVA = "0x4671D0", Offset = "0x4663D0", VA = "0x1804671D0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF31")]
	[Address(RVA = "0x467650", Offset = "0x466850", VA = "0x180467650")]
	public EffectTaskChainEnd(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF32")]
	[Address(RVA = "0x467340", Offset = "0x466540", VA = "0x180467340", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF33")]
	[Address(RVA = "0x467510", Offset = "0x466710", VA = "0x180467510")]
	private void WaitCardEffectStep()
	{
	}

	[Token(Token = "0x600AF34")]
	[Address(RVA = "0x459CA0", Offset = "0x458EA0", VA = "0x180459CA0")]
	private void OnFinishChainEffect()
	{
	}

	[Token(Token = "0x600AF35")]
	[Address(RVA = "0x467280", Offset = "0x466480", VA = "0x180467280")]
	private void FinishStep()
	{
	}
}
