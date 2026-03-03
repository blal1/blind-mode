using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B06")]
public class EffectTaskChainSet : EffectTask
{
	[Token(Token = "0x2001B07")]
	private enum Step
	{
		[Token(Token = "0x400F738")]
		WaitCardEffect,
		[Token(Token = "0x400F739")]
		WaitChainEffect,
		[Token(Token = "0x400F73A")]
		Finish
	}

	[Token(Token = "0x400F730")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F731")]
	[FieldOffset(Offset = "0x1C")]
	private bool finished;

	[Token(Token = "0x400F732")]
	[FieldOffset(Offset = "0x20")]
	private int player;

	[Token(Token = "0x400F733")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F734")]
	[FieldOffset(Offset = "0x28")]
	private int num;

	[Token(Token = "0x400F735")]
	[FieldOffset(Offset = "0x2C")]
	private int uniqueID;

	[Token(Token = "0x400F736")]
	[FieldOffset(Offset = "0x30")]
	private int actPlayer;

	[Token(Token = "0x600AF41")]
	[Address(RVA = "0x467F00", Offset = "0x467100", VA = "0x180467F00")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF42")]
	[Address(RVA = "0x467D60", Offset = "0x466F60", VA = "0x180467D60")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF43")]
	[Address(RVA = "0x468350", Offset = "0x467550", VA = "0x180468350")]
	public EffectTaskChainSet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF44")]
	[Address(RVA = "0x4680D0", Offset = "0x4672D0", VA = "0x1804680D0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF45")]
	[Address(RVA = "0x468110", Offset = "0x467310", VA = "0x180468110")]
	private void WaitCardEffectStep()
	{
	}

	[Token(Token = "0x600AF46")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitChainEffectStep()
	{
	}

	[Token(Token = "0x600AF47")]
	[Address(RVA = "0x467EF0", Offset = "0x4670F0", VA = "0x180467EF0")]
	private void FinishStep()
	{
	}
}
