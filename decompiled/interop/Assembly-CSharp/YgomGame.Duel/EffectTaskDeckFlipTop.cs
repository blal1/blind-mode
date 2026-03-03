using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001B13")]
public class EffectTaskDeckFlipTop : EffectTask
{
	[Token(Token = "0x2001B14")]
	private enum Step
	{
		[Token(Token = "0x400F76B")]
		WaitCardMoving,
		[Token(Token = "0x400F76C")]
		WaitCardLoading,
		[Token(Token = "0x400F76D")]
		Wait
	}

	[Token(Token = "0x400F760")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F761")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F762")]
	[FieldOffset(Offset = "0x20")]
	private int team;

	[Token(Token = "0x400F763")]
	[FieldOffset(Offset = "0x24")]
	private int position;

	[Token(Token = "0x400F764")]
	[FieldOffset(Offset = "0x28")]
	private bool isOpen;

	[Token(Token = "0x400F765")]
	[FieldOffset(Offset = "0x2C")]
	private int index;

	[Token(Token = "0x400F766")]
	[FieldOffset(Offset = "0x30")]
	private int uniqueId;

	[Token(Token = "0x400F767")]
	[FieldOffset(Offset = "0x34")]
	private int cardId;

	[Token(Token = "0x400F768")]
	[FieldOffset(Offset = "0x38")]
	private DeckCardPlace deckPlace;

	[Token(Token = "0x400F769")]
	[FieldOffset(Offset = "0x40")]
	private CardRoot cardRoot;

	[Token(Token = "0x600AF6C")]
	[Address(RVA = "0x469EF0", Offset = "0x4690F0", VA = "0x180469EF0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF6D")]
	[Address(RVA = "0x469DC0", Offset = "0x468FC0", VA = "0x180469DC0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF6E")]
	[Address(RVA = "0x46A400", Offset = "0x469600", VA = "0x18046A400")]
	public EffectTaskDeckFlipTop(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF6F")]
	[Address(RVA = "0x46A180", Offset = "0x469380", VA = "0x18046A180", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF70")]
	[Address(RVA = "0x46A1E0", Offset = "0x4693E0", VA = "0x18046A1E0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AF71")]
	[Address(RVA = "0x46A1D0", Offset = "0x4693D0", VA = "0x18046A1D0")]
	private void WaitCardLoadingStep()
	{
	}

	[Token(Token = "0x600AF72")]
	[Address(RVA = "0x46A060", Offset = "0x469260", VA = "0x18046A060")]
	private void StartMove()
	{
	}
}
