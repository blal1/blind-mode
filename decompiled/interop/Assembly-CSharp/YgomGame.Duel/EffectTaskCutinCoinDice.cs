using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B0C")]
public class EffectTaskCutinCoinDice : EffectTask
{
	[Token(Token = "0x400F751")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AF56")]
	[Address(RVA = "0x469500", Offset = "0x468700", VA = "0x180469500")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF57")]
	[Address(RVA = "0x455890", Offset = "0x454A90", VA = "0x180455890")]
	public EffectTaskCutinCoinDice(RunEffectWorker worker, int player, int cardId, int result)
	{
	}

	[Token(Token = "0x600AF58")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
