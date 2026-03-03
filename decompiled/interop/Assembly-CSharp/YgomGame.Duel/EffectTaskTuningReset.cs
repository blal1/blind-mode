using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B66")]
public class EffectTaskTuningReset : EffectTask
{
	[Token(Token = "0x400F8C4")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600B0A3")]
	[Address(RVA = "0x481BA0", Offset = "0x480DA0", VA = "0x180481BA0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0A4")]
	[Address(RVA = "0x481C30", Offset = "0x480E30", VA = "0x180481C30")]
	public EffectTaskTuningReset(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B0A5")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
