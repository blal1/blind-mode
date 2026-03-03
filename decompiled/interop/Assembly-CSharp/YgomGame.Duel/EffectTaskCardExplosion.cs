using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001ADE")]
public class EffectTaskCardExplosion : EffectTask
{
	[Token(Token = "0x2001ADF")]
	private enum Step
	{
		[Token(Token = "0x400F63D")]
		WaitCardMove,
		[Token(Token = "0x400F63E")]
		Finish
	}

	[Token(Token = "0x400F63A")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F63B")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x600AE97")]
	[Address(RVA = "0x459700", Offset = "0x458900", VA = "0x180459700")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE98")]
	[Address(RVA = "0x459790", Offset = "0x458990", VA = "0x180459790")]
	public EffectTaskCardExplosion(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE99")]
	[Address(RVA = "0x459760", Offset = "0x458960", VA = "0x180459760", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE9A")]
	[Address(RVA = "0x459780", Offset = "0x458980", VA = "0x180459780")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AE9B")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}
}
