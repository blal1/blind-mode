using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B10")]
public class EffectTaskCutinSummon : EffectTask
{
	[Token(Token = "0x2001B11")]
	private enum Step
	{
		[Token(Token = "0x400F75C")]
		Start,
		[Token(Token = "0x400F75D")]
		Wait,
		[Token(Token = "0x400F75E")]
		Finish
	}

	[Token(Token = "0x400F759")]
	[FieldOffset(Offset = "0x18")]
	private Engine.CutinSummonType summonType;

	[Token(Token = "0x400F75A")]
	[FieldOffset(Offset = "0x1C")]
	private bool waitEffect;

	[Token(Token = "0x600AF63")]
	[Address(RVA = "0x469950", Offset = "0x468B50", VA = "0x180469950")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF64")]
	[Address(RVA = "0x469B20", Offset = "0x468D20", VA = "0x180469B20")]
	public EffectTaskCutinSummon(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF65")]
	[Address(RVA = "0x469B10", Offset = "0x468D10", VA = "0x180469B10", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF66")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void FinishStep()
	{
	}
}
