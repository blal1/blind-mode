using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B00")]
public class EffectTaskCardVanish : EffectTask
{
	[Token(Token = "0x2001B01")]
	private enum Step
	{
		[Token(Token = "0x400F721")]
		WaitCardMove,
		[Token(Token = "0x400F722")]
		Finish
	}

	[Token(Token = "0x400F71B")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F71C")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F71D")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F71E")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F71F")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x600AF2A")]
	[Address(RVA = "0x466FD0", Offset = "0x4661D0", VA = "0x180466FD0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF2B")]
	[Address(RVA = "0x467180", Offset = "0x466380", VA = "0x180467180")]
	public EffectTaskCardVanish(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF2C")]
	[Address(RVA = "0x467060", Offset = "0x466260", VA = "0x180467060", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF2D")]
	[Address(RVA = "0x467100", Offset = "0x466300", VA = "0x180467100")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AF2E")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}
}
