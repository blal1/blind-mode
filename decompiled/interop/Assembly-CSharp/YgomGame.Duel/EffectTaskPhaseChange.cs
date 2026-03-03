using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B3B")]
public class EffectTaskPhaseChange : EffectTask
{
	[Token(Token = "0x2001B3C")]
	private enum Step
	{
		[Token(Token = "0x400F803")]
		Tutorial,
		[Token(Token = "0x400F804")]
		WaitEffect,
		[Token(Token = "0x400F805")]
		Finish
	}

	[Token(Token = "0x400F7FF")]
	[FieldOffset(Offset = "0x18")]
	private int player;

	[Token(Token = "0x400F800")]
	[FieldOffset(Offset = "0x1C")]
	private Engine.Phase phase;

	[Token(Token = "0x400F801")]
	[FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x600AFFB")]
	[Address(RVA = "0x4731F0", Offset = "0x4723F0", VA = "0x1804731F0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFFC")]
	[Address(RVA = "0x473080", Offset = "0x472280", VA = "0x180473080")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AFFD")]
	[Address(RVA = "0x473560", Offset = "0x472760", VA = "0x180473560")]
	public EffectTaskPhaseChange(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AFFE")]
	[Address(RVA = "0x473290", Offset = "0x472490", VA = "0x180473290")]
	private void PlayPhaseChangeEffect()
	{
	}

	[Token(Token = "0x600AFFF")]
	[Address(RVA = "0x473530", Offset = "0x472730", VA = "0x180473530", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}
}
