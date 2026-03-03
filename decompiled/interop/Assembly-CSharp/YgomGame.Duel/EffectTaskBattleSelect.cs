using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AD2")]
public class EffectTaskBattleSelect : EffectTask
{
	[Token(Token = "0x400F5F1")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AE56")]
	[Address(RVA = "0x455830", Offset = "0x454A30", VA = "0x180455830")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE57")]
	[Address(RVA = "0x455890", Offset = "0x454A90", VA = "0x180455890")]
	public EffectTaskBattleSelect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE58")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
