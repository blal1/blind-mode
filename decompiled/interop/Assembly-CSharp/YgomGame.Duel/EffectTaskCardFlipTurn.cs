using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AE0")]
public class EffectTaskCardFlipTurn : EffectTask
{
	[Token(Token = "0x2001AE1")]
	private enum Step
	{
		[Token(Token = "0x400F64A")]
		WaitCardMove,
		[Token(Token = "0x400F64B")]
		WaitSetCard,
		[Token(Token = "0x400F64C")]
		StartMove,
		[Token(Token = "0x400F64D")]
		WaitCamMove,
		[Token(Token = "0x400F64E")]
		WaitFlipTurn,
		[Token(Token = "0x400F64F")]
		WaitSummon,
		[Token(Token = "0x400F650")]
		Finish
	}

	[Token(Token = "0x2001AE2")]
	private enum ReasonType
	{
		[Token(Token = "0x400F652")]
		CardEffect,
		[Token(Token = "0x400F653")]
		BattleAttack,
		[Token(Token = "0x400F654")]
		StandChange,
		[Token(Token = "0x400F655")]
		FlipSummon,
		[Token(Token = "0x400F656")]
		Look
	}

	[Token(Token = "0x400F63F")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F640")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F641")]
	[FieldOffset(Offset = "0x20")]
	private Engine.CardStatus st;

	[Token(Token = "0x400F642")]
	[FieldOffset(Offset = "0x38")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F643")]
	[FieldOffset(Offset = "0x40")]
	private bool camMoved;

	[Token(Token = "0x400F644")]
	[FieldOffset(Offset = "0x48")]
	private CardPlace cardPlace;

	[Token(Token = "0x400F645")]
	[FieldOffset(Offset = "0x50")]
	private int cardId;

	[Token(Token = "0x400F646")]
	[FieldOffset(Offset = "0x54")]
	private int uniqueID;

	[Token(Token = "0x400F647")]
	[FieldOffset(Offset = "0x58")]
	private ReasonType reasonType;

	[Token(Token = "0x400F648")]
	[FieldOffset(Offset = "0x5C")]
	private bool isReverse;

	[Token(Token = "0x600AE9C")]
	[Address(RVA = "0x459990", Offset = "0x458B90", VA = "0x180459990")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE9D")]
	[Address(RVA = "0x459AB0", Offset = "0x458CB0", VA = "0x180459AB0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE9E")]
	[Address(RVA = "0x4597C0", Offset = "0x4589C0", VA = "0x1804597C0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE9F")]
	[Address(RVA = "0x45A260", Offset = "0x459460", VA = "0x18045A260")]
	public EffectTaskCardFlipTurn(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AEA0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public override void OnDestroy()
	{
	}

	[Token(Token = "0x600AEA1")]
	[Address(RVA = "0x459CB0", Offset = "0x458EB0", VA = "0x180459CB0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AEA2")]
	[Address(RVA = "0x459860", Offset = "0x458A60", VA = "0x180459860")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600AEA3")]
	[Address(RVA = "0x459FC0", Offset = "0x4591C0", VA = "0x180459FC0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AEA4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void WaitSetCardStep()
	{
	}

	[Token(Token = "0x600AEA5")]
	[Address(RVA = "0x459C30", Offset = "0x458E30", VA = "0x180459C30")]
	private void StartMoveStep()
	{
	}

	[Token(Token = "0x600AEA6")]
	[Address(RVA = "0x459D50", Offset = "0x458F50", VA = "0x180459D50")]
	private void WaitCamMoveStep()
	{
	}
}
