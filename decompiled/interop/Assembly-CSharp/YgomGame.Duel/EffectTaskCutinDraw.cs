using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B0D")]
public class EffectTaskCutinDraw : EffectTask
{
	[Token(Token = "0x400F752")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AF59")]
	[Address(RVA = "0x469560", Offset = "0x468760", VA = "0x180469560")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF5A")]
	[Address(RVA = "0x455890", Offset = "0x454A90", VA = "0x180455890")]
	public EffectTaskCutinDraw(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF5B")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
