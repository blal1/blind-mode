using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001ACB")]
public class EffectTaskBattleInit : EffectTask
{
	[Token(Token = "0x600AE20")]
	[Address(RVA = "0x439C70", Offset = "0x438E70", VA = "0x180439C70")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE21")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE22")]
	[Address(RVA = "0x439E10", Offset = "0x439010", VA = "0x180439E10")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE23")]
	[Address(RVA = "0x439F20", Offset = "0x439120", VA = "0x180439F20")]
	public EffectTaskBattleInit(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AE24")]
	[Address(RVA = "0x439EA0", Offset = "0x4390A0", VA = "0x180439EA0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
