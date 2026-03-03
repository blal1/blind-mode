using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B0E")]
public class EffectTaskCutinSet : EffectTask
{
	[Token(Token = "0x600AF5C")]
	[Address(RVA = "0x4695C0", Offset = "0x4687C0", VA = "0x1804695C0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF5D")]
	[Address(RVA = "0x469650", Offset = "0x468850", VA = "0x180469650")]
	public EffectTaskCutinSet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF5E")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
