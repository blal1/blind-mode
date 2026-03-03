using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B08")]
public class EffectTaskChainStep : EffectTask
{
	[Token(Token = "0x2001B09")]
	private enum Step
	{
		[Token(Token = "0x400F743")]
		Init,
		[Token(Token = "0x400F744")]
		WaitLoad,
		[Token(Token = "0x400F745")]
		WaitEffect,
		[Token(Token = "0x400F746")]
		Finish
	}

	[Token(Token = "0x400F73B")]
	[FieldOffset(Offset = "0x18")]
	private Step step;

	[Token(Token = "0x400F73C")]
	[FieldOffset(Offset = "0x1C")]
	private int mrk;

	[Token(Token = "0x400F73D")]
	[FieldOffset(Offset = "0x20")]
	private bool finished;

	[Token(Token = "0x400F73E")]
	[FieldOffset(Offset = "0x24")]
	private int player;

	[Token(Token = "0x400F73F")]
	[FieldOffset(Offset = "0x28")]
	private int position;

	[Token(Token = "0x400F740")]
	[FieldOffset(Offset = "0x2C")]
	private int actPlayer;

	[Token(Token = "0x400F741")]
	[FieldOffset(Offset = "0x30")]
	private CardRunEffect.CardRunEffectUnit cardRunEffectUnit;

	[Token(Token = "0x600AF49")]
	[Address(RVA = "0x468580", Offset = "0x467780", VA = "0x180468580")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF4A")]
	[Address(RVA = "0x4684B0", Offset = "0x4676B0", VA = "0x1804684B0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF4B")]
	[Address(RVA = "0x468DF0", Offset = "0x467FF0", VA = "0x180468DF0")]
	public EffectTaskChainStep(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF4C")]
	[Address(RVA = "0x4689A0", Offset = "0x467BA0", VA = "0x1804689A0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF4D")]
	[Address(RVA = "0x468A10", Offset = "0x467C10", VA = "0x180468A10")]
	private void WaitLoadStep()
	{
	}

	[Token(Token = "0x600AF4E")]
	[Address(RVA = "0x468540", Offset = "0x467740", VA = "0x180468540")]
	private void FinishStep()
	{
	}
}
