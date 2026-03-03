using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B6C")]
public class EffectTaskWaitFrame : EffectTask
{
	[Token(Token = "0x400F8D4")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F8D5")]
	[FieldOffset(Offset = "0x1C")]
	private float waitTime;

	[Token(Token = "0x400F8D6")]
	[FieldOffset(Offset = "0x20")]
	private float totalTime;

	[Token(Token = "0x600B0B8")]
	[Address(RVA = "0x482BE0", Offset = "0x481DE0", VA = "0x180482BE0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B0B9")]
	[Address(RVA = "0x482CA0", Offset = "0x481EA0", VA = "0x180482CA0")]
	public EffectTaskWaitFrame(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B0BA")]
	[Address(RVA = "0x482C60", Offset = "0x481E60", VA = "0x180482C60", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
