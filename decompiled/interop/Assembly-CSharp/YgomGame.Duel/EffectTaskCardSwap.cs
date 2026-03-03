using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AFC")]
public class EffectTaskCardSwap : EffectTask
{
	[Token(Token = "0x2001AFD")]
	private enum Step
	{
		[Token(Token = "0x400F715")]
		WaitCardMove,
		[Token(Token = "0x400F716")]
		WaitCamMove,
		[Token(Token = "0x400F717")]
		WaitSwap,
		[Token(Token = "0x400F718")]
		Finish
	}

	[Token(Token = "0x400F706")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F707")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F708")]
	[FieldOffset(Offset = "0x20")]
	private Engine.CardStatus from;

	[Token(Token = "0x400F709")]
	[FieldOffset(Offset = "0x38")]
	private Engine.CardStatus to;

	[Token(Token = "0x400F70A")]
	[FieldOffset(Offset = "0x50")]
	private bool camMoved;

	[Token(Token = "0x400F70B")]
	[FieldOffset(Offset = "0x58")]
	private CardPlace fromPlace;

	[Token(Token = "0x400F70C")]
	[FieldOffset(Offset = "0x60")]
	private CardPlace toPlace;

	[Token(Token = "0x400F70D")]
	[FieldOffset(Offset = "0x68")]
	private CardRoot fromCardRoot;

	[Token(Token = "0x400F70E")]
	[FieldOffset(Offset = "0x70")]
	private CardRoot toCardRoot;

	[Token(Token = "0x400F70F")]
	[FieldOffset(Offset = "0x78")]
	private int fromCardID;

	[Token(Token = "0x400F710")]
	[FieldOffset(Offset = "0x7C")]
	private int fromUniqueID;

	[Token(Token = "0x400F711")]
	[FieldOffset(Offset = "0x80")]
	private int toCardID;

	[Token(Token = "0x400F712")]
	[FieldOffset(Offset = "0x84")]
	private int toUniqueID;

	[Token(Token = "0x400F713")]
	[FieldOffset(Offset = "0x88")]
	private bool reqAttackTargetLine;

	[Token(Token = "0x600AF18")]
	[Address(RVA = "0x465EC0", Offset = "0x4650C0", VA = "0x180465EC0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF19")]
	[Address(RVA = "0x4660E0", Offset = "0x4652E0", VA = "0x1804660E0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF1A")]
	[Address(RVA = "0x465C20", Offset = "0x464E20", VA = "0x180465C20")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF1B")]
	[Address(RVA = "0x466860", Offset = "0x465A60", VA = "0x180466860")]
	public EffectTaskCardSwap(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF1C")]
	[Address(RVA = "0x4664E0", Offset = "0x4656E0", VA = "0x1804664E0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF1D")]
	[Address(RVA = "0x466810", Offset = "0x465A10", VA = "0x180466810")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AF1E")]
	[Address(RVA = "0x466570", Offset = "0x465770", VA = "0x180466570")]
	private void WaitCamMoveStep()
	{
	}

	[Token(Token = "0x600AF1F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitSwapStep()
	{
	}

	[Token(Token = "0x600AF20")]
	[Address(RVA = "0x465CC0", Offset = "0x464EC0", VA = "0x180465CC0")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600AF21")]
	[Address(RVA = "0x466350", Offset = "0x465550", VA = "0x180466350")]
	private void SetBackCardStatus(CardRoot cardRoot, int uniqueID, int cardID)
	{
	}

	[Token(Token = "0x600AF22")]
	[Address(RVA = "0x466410", Offset = "0x465610", VA = "0x180466410")]
	private void ShowBackCardStatus(CardRoot cardRoot, Engine.CardStatus cardStatus)
	{
	}
}
