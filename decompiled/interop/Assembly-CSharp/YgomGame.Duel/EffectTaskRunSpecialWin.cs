using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B5B")]
public class EffectTaskRunSpecialWin : EffectTask
{
	[Token(Token = "0x2001B5C")]
	private enum Step
	{
		[Token(Token = "0x400F8AC")]
		Wait,
		[Token(Token = "0x400F8AD")]
		Finish
	}

	[Token(Token = "0x400F8AA")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x600B085")]
	[Address(RVA = "0x47EA00", Offset = "0x47DC00", VA = "0x18047EA00")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B086")]
	[Address(RVA = "0x47EAE0", Offset = "0x47DCE0", VA = "0x18047EAE0")]
	public EffectTaskRunSpecialWin(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B087")]
	[Address(RVA = "0x47EA90", Offset = "0x47DC90", VA = "0x18047EA90", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
