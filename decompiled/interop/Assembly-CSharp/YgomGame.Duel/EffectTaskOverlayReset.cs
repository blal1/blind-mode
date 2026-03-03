using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B37")]
public class EffectTaskOverlayReset : EffectTask
{
	[Token(Token = "0x400F7FA")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AFF0")]
	[Address(RVA = "0x472960", Offset = "0x471B60", VA = "0x180472960")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFF1")]
	[Address(RVA = "0x4729F0", Offset = "0x471BF0", VA = "0x1804729F0")]
	public EffectTaskOverlayReset(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFF2")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
