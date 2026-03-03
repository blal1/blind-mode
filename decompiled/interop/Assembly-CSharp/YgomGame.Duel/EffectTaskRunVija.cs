using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B61")]
public class EffectTaskRunVija : EffectTask
{
	[Token(Token = "0x600B095")]
	[Address(RVA = "0x481300", Offset = "0x480500", VA = "0x180481300")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B096")]
	[Address(RVA = "0x481360", Offset = "0x480560", VA = "0x180481360")]
	public EffectTaskRunVija(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B097")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
