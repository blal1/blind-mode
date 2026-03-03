using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AD5")]
public class EffectTaskCardCheat : EffectTask
{
	[Token(Token = "0x2001AD6")]
	private enum Step
	{
		[Token(Token = "0x400F60E")]
		WaitCardMove,
		[Token(Token = "0x400F60F")]
		WaitCamMove,
		[Token(Token = "0x400F610")]
		StartPlacement,
		[Token(Token = "0x400F611")]
		WaitSetCard,
		[Token(Token = "0x400F612")]
		WaitEffect,
		[Token(Token = "0x400F613")]
		Finish,
		[Token(Token = "0x400F614")]
		Appear,
		[Token(Token = "0x400F615")]
		Move
	}

	[Token(Token = "0x400F5FA")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F5FB")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F5FC")]
	[FieldOffset(Offset = "0x20")]
	private Engine.CardStatus st;

	[Token(Token = "0x400F5FD")]
	[FieldOffset(Offset = "0x38")]
	private int cardId;

	[Token(Token = "0x400F5FE")]
	[FieldOffset(Offset = "0x40")]
	private CardLocator cardLocator;

	[Token(Token = "0x400F5FF")]
	[FieldOffset(Offset = "0x48")]
	private bool camMoved;

	[Token(Token = "0x400F600")]
	[FieldOffset(Offset = "0x50")]
	private CardPlace cardPlace;

	[Token(Token = "0x400F601")]
	[FieldOffset(Offset = "0x58")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F602")]
	[FieldOffset(Offset = "0x60")]
	private bool isFace;

	[Token(Token = "0x400F603")]
	[FieldOffset(Offset = "0x61")]
	private bool waitEffect;

	[Token(Token = "0x400F604")]
	[FieldOffset(Offset = "0x64")]
	private int uniqueID;

	[Token(Token = "0x400F605")]
	[FieldOffset(Offset = "0x68")]
	private int param1;

	[Token(Token = "0x400F606")]
	[FieldOffset(Offset = "0x6C")]
	private int param2;

	[Token(Token = "0x400F607")]
	[FieldOffset(Offset = "0x70")]
	private int param3;

	[Token(Token = "0x400F608")]
	[FieldOffset(Offset = "0x78")]
	private BezierMotionContainer appearMotionContainer;

	[Token(Token = "0x400F609")]
	[FieldOffset(Offset = "0x80")]
	private BezierMotionContainer moveMotionContainer_ToHand;

	[Token(Token = "0x400F60A")]
	[FieldOffset(Offset = "0x88")]
	private BezierMotionContainer moveMotionContainer_ToField;

	[Token(Token = "0x400F60B")]
	[FieldOffset(Offset = "0x90")]
	private bool isAppearing;

	[Token(Token = "0x400F60C")]
	[FieldOffset(Offset = "0x91")]
	private bool isMoving;

	[Token(Token = "0x600AE61")]
	[Address(RVA = "0x456840", Offset = "0x455A40", VA = "0x180456840")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE62")]
	[Address(RVA = "0x456DB0", Offset = "0x455FB0", VA = "0x180456DB0")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE63")]
	[Address(RVA = "0x456350", Offset = "0x455550", VA = "0x180456350")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE64")]
	[Address(RVA = "0x457960", Offset = "0x456B60", VA = "0x180457960")]
	public EffectTaskCardCheat(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AE65")]
	[Address(RVA = "0x457430", Offset = "0x456630", VA = "0x180457430", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE66")]
	[Address(RVA = "0x4575C0", Offset = "0x4567C0", VA = "0x1804575C0")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AE67")]
	[Address(RVA = "0x4575B0", Offset = "0x4567B0", VA = "0x1804575B0")]
	private void WaitCamMoveStep()
	{
	}

	[Token(Token = "0x600AE68")]
	[Address(RVA = "0x456F30", Offset = "0x456130", VA = "0x180456F30")]
	private void StartPlacementStep()
	{
	}

	[Token(Token = "0x600AE69")]
	[Address(RVA = "0x4578A0", Offset = "0x456AA0", VA = "0x1804578A0")]
	private void WaitEffectStep()
	{
	}

	[Token(Token = "0x600AE6A")]
	[Address(RVA = "0x455950", Offset = "0x454B50", VA = "0x180455950")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600AE6B")]
	[Address(RVA = "0x455DB0", Offset = "0x454FB0", VA = "0x180455DB0")]
	private void AppearStep()
	{
	}

	[Token(Token = "0x600AE6C")]
	[Address(RVA = "0x456980", Offset = "0x455B80", VA = "0x180456980")]
	private void MoveStep()
	{
	}

	[Token(Token = "0x600AE6D")]
	[Address(RVA = "0x456690", Offset = "0x455890", VA = "0x180456690")]
	private EffectTaskCardMove.LandingType GetLandingType(int pos, bool face)
	{
		return default(EffectTaskCardMove.LandingType);
	}

	[Token(Token = "0x600AE6E")]
	[Address(RVA = "0x4563F0", Offset = "0x4555F0", VA = "0x1804563F0")]
	public static EffectTaskCardMove.LandingEffectInfo GetLandingEffectInfo(EffectTaskCardMove.LandingType landingType)
	{
		return default(EffectTaskCardMove.LandingEffectInfo);
	}
}
