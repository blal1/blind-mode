using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B62")]
public class EffectTaskTributeReset : EffectTask
{
	[Token(Token = "0x400F8BF")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600B098")]
	[Address(RVA = "0x481370", Offset = "0x480570", VA = "0x180481370")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B099")]
	[Address(RVA = "0x481400", Offset = "0x480600", VA = "0x180481400")]
	public EffectTaskTributeReset(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B09A")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
