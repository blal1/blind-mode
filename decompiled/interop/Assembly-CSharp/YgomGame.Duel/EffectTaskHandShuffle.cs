using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B25")]
public class EffectTaskHandShuffle : EffectTask
{
	[Token(Token = "0x2001B26")]
	private enum Step
	{
		[Token(Token = "0x400F7CA")]
		WaitCardMove,
		[Token(Token = "0x400F7CB")]
		WaitShuffle
	}

	[Token(Token = "0x400F7C6")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F7C7")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F7C8")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x600AFBA")]
	[Address(RVA = "0x46FA90", Offset = "0x46EC90", VA = "0x18046FA90")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFBB")]
	[Address(RVA = "0x46FD40", Offset = "0x46EF40", VA = "0x18046FD40")]
	public EffectTaskHandShuffle(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFBC")]
	[Address(RVA = "0x46FB00", Offset = "0x46ED00", VA = "0x18046FB00", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AFBD")]
	[Address(RVA = "0x46FC20", Offset = "0x46EE20", VA = "0x18046FC20")]
	private void WaitCardMoveStep()
	{
	}
}
