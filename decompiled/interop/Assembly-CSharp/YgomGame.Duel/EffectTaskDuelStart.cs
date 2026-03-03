using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001B1A")]
public class EffectTaskDuelStart : EffectTask
{
	[Token(Token = "0x2001B1B")]
	private enum Step
	{
		[Token(Token = "0x400F791")]
		PlayEachPlayer,
		[Token(Token = "0x400F792")]
		WaitEachPlayer,
		[Token(Token = "0x400F793")]
		Finish,
		[Token(Token = "0x400F794")]
		Tutorial,
		[Token(Token = "0x400F795")]
		Appear,
		[Token(Token = "0x400F796")]
		Move,
		[Token(Token = "0x400F797")]
		DiceRally,
		[Token(Token = "0x400F798")]
		WaitDiceRally
	}

	[Token(Token = "0x2001B1C")]
	private enum CharaStep
	{
		[Token(Token = "0x400F79A")]
		Entry,
		[Token(Token = "0x400F79B")]
		Wait,
		[Token(Token = "0x400F79C")]
		Finish
	}

	[Token(Token = "0x400F781")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F782")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F783")]
	[FieldOffset(Offset = "0x20")]
	private bool charaFinished;

	[Token(Token = "0x400F784")]
	[FieldOffset(Offset = "0x24")]
	private CharaStep charaStep;

	[Token(Token = "0x400F785")]
	[FieldOffset(Offset = "0x28")]
	private BezierMotionContainer appearMotionContainer;

	[Token(Token = "0x400F786")]
	[FieldOffset(Offset = "0x30")]
	private BezierMotionContainer moveMotionContainer;

	[Token(Token = "0x400F787")]
	[FieldOffset(Offset = "0x38")]
	private int cid;

	[Token(Token = "0x400F788")]
	[FieldOffset(Offset = "0x3C")]
	private int pos;

	[Token(Token = "0x400F789")]
	[FieldOffset(Offset = "0x40")]
	private bool face;

	[Token(Token = "0x400F78A")]
	[FieldOffset(Offset = "0x41")]
	private bool turn;

	[Token(Token = "0x400F78B")]
	[FieldOffset(Offset = "0x42")]
	private bool isExsistCheatCard;

	[Token(Token = "0x400F78C")]
	[FieldOffset(Offset = "0x48")]
	private CardLocator cardLocator;

	[Token(Token = "0x400F78D")]
	[FieldOffset(Offset = "0x50")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F78E")]
	[FieldOffset(Offset = "0x58")]
	private bool isAppearing;

	[Token(Token = "0x400F78F")]
	[FieldOffset(Offset = "0x59")]
	private bool isMoving;

	[Token(Token = "0x600AF86")]
	[Address(RVA = "0x46C070", Offset = "0x46B270", VA = "0x18046C070")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AF87")]
	[Address(RVA = "0x46C730", Offset = "0x46B930", VA = "0x18046C730")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AF88")]
	[Address(RVA = "0x46BCD0", Offset = "0x46AED0", VA = "0x18046BCD0")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AF89")]
	[Address(RVA = "0x46D400", Offset = "0x46C600", VA = "0x18046D400")]
	public EffectTaskDuelStart(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AF8A")]
	[Address(RVA = "0x46CE30", Offset = "0x46C030", VA = "0x18046CE30", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AF8B")]
	[Address(RVA = "0x46C530", Offset = "0x46B730", VA = "0x18046C530")]
	private void PlayEachPlayerStep()
	{
	}

	[Token(Token = "0x600AF8C")]
	[Address(RVA = "0x46BEF0", Offset = "0x46B0F0", VA = "0x18046BEF0")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600AF8D")]
	[Address(RVA = "0x46D3C0", Offset = "0x46C5C0", VA = "0x18046D3C0")]
	private void WaitCharaStep()
	{
	}

	[Token(Token = "0x600AF8E")]
	[Address(RVA = "0x46BE90", Offset = "0x46B090", VA = "0x18046BE90")]
	private void FinishCharaStep()
	{
	}

	[Token(Token = "0x600AF8F")]
	[Address(RVA = "0x46BD70", Offset = "0x46AF70", VA = "0x18046BD70")]
	private void DiceRallyEffectStep()
	{
	}

	[Token(Token = "0x600AF90")]
	[Address(RVA = "0x46B470", Offset = "0x46A670", VA = "0x18046B470")]
	private void AppearStep()
	{
	}

	[Token(Token = "0x600AF91")]
	[Address(RVA = "0x46C0F0", Offset = "0x46B2F0", VA = "0x18046C0F0")]
	private void MoveStep()
	{
	}

	[Token(Token = "0x600AF92")]
	[Address(RVA = "0x46B900", Offset = "0x46AB00", VA = "0x18046B900")]
	private Vector3 CenterPos(bool isMyself = true)
	{
		return default(Vector3);
	}

	[Token(Token = "0x600AF93")]
	[Address(RVA = "0x46BA20", Offset = "0x46AC20", VA = "0x18046BA20")]
	private Quaternion CenterRot(bool isMyself = true)
	{
		return default(Quaternion);
	}
}
