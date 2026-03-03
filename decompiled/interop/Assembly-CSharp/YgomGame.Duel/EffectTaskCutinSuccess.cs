using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B0F")]
public class EffectTaskCutinSuccess : EffectTask
{
	[Token(Token = "0x400F753")]
	private const int DEF_SUCCESS_SUMMON_EFXNO_MASK = 49152;

	[Token(Token = "0x400F754")]
	private const int DEF_SUCCESS_SUMMON_EFXNO_SHIFT = 14;

	[Token(Token = "0x400F755")]
	private const int DEF_SUCCESS_SUMMON_NORMAL = 0;

	[Token(Token = "0x400F756")]
	private const int DEF_SUCCESS_SUMMON_SPECIAL = 4;

	[Token(Token = "0x400F757")]
	private const int DEF_SUCCESS_SUMMON_DUAL = 8;

	[Token(Token = "0x400F758")]
	[FieldOffset(Offset = "0x18")]
	private int efxNoBase;

	[Token(Token = "0x600AF5F")]
	[Address(RVA = "0x4696A0", Offset = "0x4688A0", VA = "0x1804696A0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF60")]
	[Address(RVA = "0x469760", Offset = "0x468960", VA = "0x180469760")]
	public EffectTaskCutinSuccess(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF61")]
	[Address(RVA = "0x469730", Offset = "0x468930", VA = "0x180469730")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF62")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
