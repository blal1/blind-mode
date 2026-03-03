using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001ACA")]
public class EffectTaskBattleEnd : EffectTask
{
	[Token(Token = "0x600AE1C")]
	[Address(RVA = "0x439C70", Offset = "0x438E70", VA = "0x180439C70")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE1D")]
	[Address(RVA = "0x439B50", Offset = "0x438D50", VA = "0x180439B50")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE1E")]
	[Address(RVA = "0x439D10", Offset = "0x438F10", VA = "0x180439D10")]
	public EffectTaskBattleEnd(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE1F")]
	[Address(RVA = "0x439CB0", Offset = "0x438EB0", VA = "0x180439CB0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
