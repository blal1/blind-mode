using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B69")]
public class EffectTaskTuningSet : EffectTask
{
	[Token(Token = "0x400F8C9")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600B0AB")]
	[Address(RVA = "0x4821D0", Offset = "0x4813D0", VA = "0x1804821D0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0AC")]
	[Address(RVA = "0x4820B0", Offset = "0x4812B0", VA = "0x1804820B0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600B0AD")]
	[Address(RVA = "0x4822A0", Offset = "0x4814A0", VA = "0x1804822A0")]
	public EffectTaskTuningSet(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600B0AE")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
