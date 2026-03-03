using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B39")]
public class EffectTaskOverlayRun : EffectTask
{
	[Token(Token = "0x600AFF5")]
	[Address(RVA = "0x472C40", Offset = "0x471E40", VA = "0x180472C40")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFF6")]
	[Address(RVA = "0x472D70", Offset = "0x471F70", VA = "0x180472D70")]
	public EffectTaskOverlayRun(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFF7")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
