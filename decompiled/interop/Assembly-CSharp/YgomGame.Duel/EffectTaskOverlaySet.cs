using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B3A")]
public class EffectTaskOverlaySet : EffectTask
{
	[Token(Token = "0x400F7FE")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x600AFF8")]
	[Address(RVA = "0x472E70", Offset = "0x472070", VA = "0x180472E70")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFF9")]
	[Address(RVA = "0x472F90", Offset = "0x472190", VA = "0x180472F90")]
	public EffectTaskOverlaySet(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFFA")]
	[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
