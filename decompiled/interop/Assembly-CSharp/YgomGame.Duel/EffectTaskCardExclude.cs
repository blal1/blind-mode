using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001ADC")]
public class EffectTaskCardExclude : EffectTask
{
	[Token(Token = "0x2001ADD")]
	private enum Step
	{
		[Token(Token = "0x400F638")]
		WaitCardMove,
		[Token(Token = "0x400F639")]
		Finish
	}

	[Token(Token = "0x400F631")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F632")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F633")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F634")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F635")]
	[FieldOffset(Offset = "0x28")]
	private int index;

	[Token(Token = "0x400F636")]
	[FieldOffset(Offset = "0x2C")]
	private int uniqueID;

	[Token(Token = "0x600AE92")]
	[Address(RVA = "0x4594D0", Offset = "0x4586D0", VA = "0x1804594D0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE93")]
	[Address(RVA = "0x4596A0", Offset = "0x4588A0", VA = "0x1804596A0")]
	public EffectTaskCardExclude(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE94")]
	[Address(RVA = "0x459570", Offset = "0x458770", VA = "0x180459570", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE95")]
	[Address(RVA = "0x459620", Offset = "0x458820", VA = "0x180459620")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AE96")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}
}
