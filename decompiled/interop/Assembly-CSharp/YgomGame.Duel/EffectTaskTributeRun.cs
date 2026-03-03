using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B64")]
public class EffectTaskTributeRun : EffectTask
{
	[Token(Token = "0x600B09D")]
	[Address(RVA = "0x481650", Offset = "0x480850", VA = "0x180481650")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B09E")]
	[Address(RVA = "0x4817A0", Offset = "0x4809A0", VA = "0x1804817A0")]
	public EffectTaskTributeRun(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B09F")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
