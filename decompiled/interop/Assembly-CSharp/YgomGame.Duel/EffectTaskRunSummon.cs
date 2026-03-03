using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B5F")]
public class EffectTaskRunSummon : EffectTask
{
	[Token(Token = "0x2001B60")]
	private enum Step
	{
		[Token(Token = "0x400F8BD")]
		WaitCardMove,
		[Token(Token = "0x400F8BE")]
		WaitSummon
	}

	[Token(Token = "0x400F8B7")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F8B8")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F8B9")]
	[FieldOffset(Offset = "0x20")]
	private Engine.CardStatus st;

	[Token(Token = "0x400F8BA")]
	[FieldOffset(Offset = "0x38")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F8BB")]
	[FieldOffset(Offset = "0x40")]
	private bool camMoved;

	[Token(Token = "0x600B08F")]
	[Address(RVA = "0x480FF0", Offset = "0x4801F0", VA = "0x180480FF0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B090")]
	[Address(RVA = "0x481220", Offset = "0x480420", VA = "0x180481220")]
	public EffectTaskRunSummon(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B091")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600B092")]
	[Address(RVA = "0x481100", Offset = "0x480300", VA = "0x180481100", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B093")]
	[Address(RVA = "0x481190", Offset = "0x480390", VA = "0x180481190")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600B094")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitSummonStep()
	{
	}
}
