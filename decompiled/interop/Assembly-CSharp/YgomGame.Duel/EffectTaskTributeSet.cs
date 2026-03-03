using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B65")]
public class EffectTaskTributeSet : EffectTask
{
	[Token(Token = "0x400F8C3")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600B0A0")]
	[Address(RVA = "0x4818B0", Offset = "0x480AB0", VA = "0x1804818B0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0A1")]
	[Address(RVA = "0x481A50", Offset = "0x480C50", VA = "0x180481A50")]
	public EffectTaskTributeSet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B0A2")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
