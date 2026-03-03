using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B2D")]
public class EffectTaskLinkRun : EffectTask
{
	[Token(Token = "0x600AFD3")]
	[Address(RVA = "0x470EF0", Offset = "0x4700F0", VA = "0x180470EF0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFD4")]
	[Address(RVA = "0x471010", Offset = "0x470210", VA = "0x180471010")]
	public EffectTaskLinkRun(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFD5")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
