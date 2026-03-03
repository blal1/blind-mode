using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B2B")]
public class EffectTaskLinkReset : EffectTask
{
	[Token(Token = "0x400F7DD")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AFCE")]
	[Address(RVA = "0x470C10", Offset = "0x46FE10", VA = "0x180470C10")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFCF")]
	[Address(RVA = "0x470CA0", Offset = "0x46FEA0", VA = "0x180470CA0")]
	public EffectTaskLinkReset(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFD0")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
