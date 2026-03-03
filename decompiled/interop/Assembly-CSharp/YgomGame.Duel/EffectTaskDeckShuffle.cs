using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B17")]
public class EffectTaskDeckShuffle : EffectTask
{
	[Token(Token = "0x2001B18")]
	private enum Step
	{
		[Token(Token = "0x400F77B")]
		WaitCardMove,
		[Token(Token = "0x400F77C")]
		WaitFinish,
		[Token(Token = "0x400F77D")]
		Finished
	}

	[Token(Token = "0x400F777")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F778")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F779")]
	[FieldOffset(Offset = "0x20")]
	private DeckCardPlace deckPlace;

	[Token(Token = "0x600AF7D")]
	[Address(RVA = "0x46AC30", Offset = "0x469E30", VA = "0x18046AC30")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF7E")]
	[Address(RVA = "0x46AF20", Offset = "0x46A120", VA = "0x18046AF20")]
	public EffectTaskDeckShuffle(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF7F")]
	[Address(RVA = "0x46AD90", Offset = "0x469F90", VA = "0x18046AD90", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF80")]
	[Address(RVA = "0x46AE70", Offset = "0x46A070", VA = "0x18046AE70")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AF81")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishedStep()
	{
	}
}
