using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B68")]
public class EffectTaskTuningRun : EffectTask
{
	[Token(Token = "0x400F8C8")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600B0A8")]
	[Address(RVA = "0x481EA0", Offset = "0x4810A0", VA = "0x180481EA0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0A9")]
	[Address(RVA = "0x481FC0", Offset = "0x4811C0", VA = "0x180481FC0")]
	public EffectTaskTuningRun(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B0AA")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
