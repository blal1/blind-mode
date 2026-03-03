using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B19")]
public class EffectTaskDuelEnd : EffectTask
{
	[Token(Token = "0x400F77E")]
	[FieldOffset(Offset = "0x18")]
	private Engine.ResultType exactResultType;

	[Token(Token = "0x400F77F")]
	[FieldOffset(Offset = "0x1C")]
	private Engine.ResultType resultType;

	[Token(Token = "0x400F780")]
	[FieldOffset(Offset = "0x20")]
	private Engine.FinishType finishType;

	[Token(Token = "0x600AF83")]
	[Address(RVA = "0x46B050", Offset = "0x46A250", VA = "0x18046B050")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF84")]
	[Address(RVA = "0x46B150", Offset = "0x46A350", VA = "0x18046B150")]
	public EffectTaskDuelEnd(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF85")]
	[Address(RVA = "0x46B0E0", Offset = "0x46A2E0", VA = "0x18046B0E0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
