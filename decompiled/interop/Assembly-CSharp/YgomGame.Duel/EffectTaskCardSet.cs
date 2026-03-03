using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AFB")]
public class EffectTaskCardSet : EffectTask
{
	[Token(Token = "0x400F705")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AF15")]
	[Address(RVA = "0x465BC0", Offset = "0x464DC0", VA = "0x180465BC0")]
	public static EffectTask Create(RunEffectWorker workerHUD, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF16")]
	[Address(RVA = "0x455890", Offset = "0x454A90", VA = "0x180455890")]
	public EffectTaskCardSet(RunEffectWorker workerHUD, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF17")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
