using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B34")]
public class EffectTaskMaterialSet : EffectTask
{
	[Token(Token = "0x400F7F1")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AFE7")]
	[Address(RVA = "0x471E30", Offset = "0x471030", VA = "0x180471E30")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFE8")]
	[Address(RVA = "0x471FA0", Offset = "0x4711A0", VA = "0x180471FA0")]
	public EffectTaskMaterialSet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFE9")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
