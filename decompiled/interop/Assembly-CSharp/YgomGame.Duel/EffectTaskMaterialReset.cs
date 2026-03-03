using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B31")]
public class EffectTaskMaterialReset : EffectTask
{
	[Token(Token = "0x400F7ED")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AFDF")]
	[Address(RVA = "0x4718C0", Offset = "0x470AC0", VA = "0x1804718C0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFE0")]
	[Address(RVA = "0x471950", Offset = "0x470B50", VA = "0x180471950")]
	public EffectTaskMaterialReset(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFE1")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
