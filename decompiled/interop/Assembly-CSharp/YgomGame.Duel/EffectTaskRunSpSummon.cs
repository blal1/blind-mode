using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B5D")]
public class EffectTaskRunSpSummon : EffectTask
{
	[Token(Token = "0x2001B5E")]
	private enum Step
	{
		[Token(Token = "0x400F8B4")]
		WaitCardMove,
		[Token(Token = "0x400F8B5")]
		WaitCamMove,
		[Token(Token = "0x400F8B6")]
		WaitSummon
	}

	[Token(Token = "0x400F8AE")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F8AF")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F8B0")]
	[FieldOffset(Offset = "0x20")]
	private Engine.CardStatus st;

	[Token(Token = "0x400F8B1")]
	[FieldOffset(Offset = "0x38")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F8B2")]
	[FieldOffset(Offset = "0x40")]
	private bool camMoved;

	[Token(Token = "0x600B088")]
	[Address(RVA = "0x47E710", Offset = "0x47D910", VA = "0x18047E710")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600B089")]
	[Address(RVA = "0x47E950", Offset = "0x47DB50", VA = "0x18047E950")]
	public EffectTaskRunSpSummon(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600B08A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600B08B")]
	[Address(RVA = "0x47E7F0", Offset = "0x47D9F0", VA = "0x18047E7F0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600B08C")]
	[Address(RVA = "0x47E8C0", Offset = "0x47DAC0", VA = "0x18047E8C0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600B08D")]
	[Address(RVA = "0x47E8B0", Offset = "0x47DAB0", VA = "0x18047E8B0")]
	private void WaitCamMoveStep()
	{
	}

	[Token(Token = "0x600B08E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitSummonStep()
	{
	}
}
