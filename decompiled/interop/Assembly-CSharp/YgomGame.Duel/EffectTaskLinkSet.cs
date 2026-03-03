using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B2E")]
public class EffectTaskLinkSet : EffectTask
{
	[Token(Token = "0x600AFD6")]
	[Address(RVA = "0x4710F0", Offset = "0x4702F0", VA = "0x1804710F0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFD7")]
	[Address(RVA = "0x471210", Offset = "0x470410", VA = "0x180471210")]
	public EffectTaskLinkSet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFD8")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
