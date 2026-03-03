using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B12")]
public class EffectTaskCutinTurnEnd : EffectTask
{
	[Token(Token = "0x400F75F")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AF68")]
	[Address(RVA = "0x469D30", Offset = "0x468F30", VA = "0x180469D30")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF69")]
	[Address(RVA = "0x469CA0", Offset = "0x468EA0", VA = "0x180469CA0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF6A")]
	[Address(RVA = "0x469D60", Offset = "0x468F60", VA = "0x180469D60")]
	public EffectTaskCutinTurnEnd(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF6B")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
