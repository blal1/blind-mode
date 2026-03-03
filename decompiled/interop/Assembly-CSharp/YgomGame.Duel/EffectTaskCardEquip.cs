using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001ADB")]
public class EffectTaskCardEquip : EffectTask
{
	[Token(Token = "0x600AE8E")]
	[Address(RVA = "0x459320", Offset = "0x458520", VA = "0x180459320")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE8F")]
	[Address(RVA = "0x459200", Offset = "0x458400", VA = "0x180459200")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE90")]
	[Address(RVA = "0x4593E0", Offset = "0x4585E0", VA = "0x1804593E0")]
	public EffectTaskCardEquip(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE91")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
