using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001AEB")]
public class EffectTaskCardMove : EffectTask
{
	[Token(Token = "0x2001AEC")]
	private enum Step
	{
		[Token(Token = "0x400F6C2")]
		WaitCardMove,
		[Token(Token = "0x400F6C3")]
		WaitLoadCard,
		[Token(Token = "0x400F6C4")]
		WaitSetCard,
		[Token(Token = "0x400F6C5")]
		WaitLoadCardMoveEffect,
		[Token(Token = "0x400F6C6")]
		StartMove,
		[Token(Token = "0x400F6C7")]
		WaitMove,
		[Token(Token = "0x400F6C8")]
		Finish
	}

	[Token(Token = "0x2001AED")]
	public enum LandingType
	{
		[Token(Token = "0x400F6CA")]
		NORMAL,
		[Token(Token = "0x400F6CB")]
		SUMMON_LOW,
		[Token(Token = "0x400F6CC")]
		SUMMON_MIDDLE,
		[Token(Token = "0x400F6CD")]
		SUMMON_HIGH,
		[Token(Token = "0x400F6CE")]
		MAGIC,
		[Token(Token = "0x400F6CF")]
		MAGIC_SET
	}

	[Token(Token = "0x2001AEE")]
	public enum SummonEffectType
	{
		[Token(Token = "0x400F6D1")]
		None,
		[Token(Token = "0x400F6D2")]
		Advance,
		[Token(Token = "0x400F6D3")]
		Fusion,
		[Token(Token = "0x400F6D4")]
		Ritual,
		[Token(Token = "0x400F6D5")]
		Synchro,
		[Token(Token = "0x400F6D6")]
		Xyz,
		[Token(Token = "0x400F6D7")]
		Pendulum,
		[Token(Token = "0x400F6D8")]
		Link
	}

	[Token(Token = "0x2001AEF")]
	public struct LandingEffectInfo
	{
		[Token(Token = "0x400F6D9")]
		[FieldOffset(Offset = "0x0")]
		public bool useEffect;

		[Token(Token = "0x400F6DA")]
		[FieldOffset(Offset = "0x4")]
		public DuelEffectPool.Type effectType;

		[Token(Token = "0x400F6DB")]
		[FieldOffset(Offset = "0x8")]
		public bool useEffectImpact;

		[Token(Token = "0x400F6DC")]
		[FieldOffset(Offset = "0xC")]
		public DuelEffectPool.Type effectTypeImpact;

		[Token(Token = "0x400F6DD")]
		[FieldOffset(Offset = "0x10")]
		public bool useEffectSummon;

		[Token(Token = "0x400F6DE")]
		[FieldOffset(Offset = "0x14")]
		public DuelEffectPool.Type effectTypeSummon;

		[Token(Token = "0x400F6DF")]
		[FieldOffset(Offset = "0x18")]
		public string shakeLabel;

		[Token(Token = "0x400F6E0")]
		[FieldOffset(Offset = "0x20")]
		public string seLabel;

		[Token(Token = "0x400F6E1")]
		[FieldOffset(Offset = "0x28")]
		public float effectTime;
	}

	[Token(Token = "0x400F69D")]
	[FieldOffset(Offset = "0x18")]
	private bool finished;

	[Token(Token = "0x400F69E")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F69F")]
	[FieldOffset(Offset = "0x20")]
	private Engine.CardStatus from;

	[Token(Token = "0x400F6A0")]
	[FieldOffset(Offset = "0x38")]
	private Engine.CardStatus to;

	[Token(Token = "0x400F6A1")]
	[FieldOffset(Offset = "0x50")]
	private Engine.CardMoveType moveType;

	[Token(Token = "0x400F6A2")]
	[FieldOffset(Offset = "0x54")]
	private int uniqueId;

	[Token(Token = "0x400F6A3")]
	[FieldOffset(Offset = "0x58")]
	private int cardId;

	[Token(Token = "0x400F6A4")]
	[FieldOffset(Offset = "0x5C")]
	private int toTopUniqueID;

	[Token(Token = "0x400F6A5")]
	[FieldOffset(Offset = "0x60")]
	private int fromTopUniqueID;

	[Token(Token = "0x400F6A6")]
	[FieldOffset(Offset = "0x64")]
	private int directFlag;

	[Token(Token = "0x400F6A7")]
	[FieldOffset(Offset = "0x68")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F6A8")]
	[FieldOffset(Offset = "0x70")]
	private CardPlace fromPlace;

	[Token(Token = "0x400F6A9")]
	[FieldOffset(Offset = "0x78")]
	private CardPlace toPlace;

	[Token(Token = "0x400F6AA")]
	[FieldOffset(Offset = "0x80")]
	private BezierMotionSetting[] motionList;

	[Token(Token = "0x400F6AB")]
	[FieldOffset(Offset = "0x88")]
	private string motionSeCode;

	[Token(Token = "0x400F6AC")]
	[FieldOffset(Offset = "0x90")]
	private bool changeBgmOnLanding;

	[Token(Token = "0x400F6AD")]
	[FieldOffset(Offset = "0x91")]
	private bool toFace;

	[Token(Token = "0x400F6AE")]
	[FieldOffset(Offset = "0x98")]
	private CardLocator fromLocator;

	[Token(Token = "0x400F6AF")]
	[FieldOffset(Offset = "0xA0")]
	private CardLocator toLocator;

	[Token(Token = "0x400F6B0")]
	[FieldOffset(Offset = "0xA8")]
	private CardLocator summonLocator;

	[Token(Token = "0x400F6B1")]
	[FieldOffset(Offset = "0xB0")]
	private ZoneCard zoneCard;

	[Token(Token = "0x400F6B2")]
	[FieldOffset(Offset = "0xB8")]
	private CardRunEffect.CardRunEffectUnit cardRunEffectUnit;

	[Token(Token = "0x400F6B3")]
	[FieldOffset(Offset = "0xC0")]
	private CardRoot.ModelType toModelType;

	[Token(Token = "0x400F6B4")]
	[FieldOffset(Offset = "0xC4")]
	private CardRoot.ModelType fromModelType;

	[Token(Token = "0x400F6B5")]
	[FieldOffset(Offset = "0xC8")]
	private bool isSoul;

	[Token(Token = "0x400F6B6")]
	[FieldOffset(Offset = "0xC9")]
	private bool isWaitMaximum;

	[Token(Token = "0x400F6B7")]
	[FieldOffset(Offset = "0xCC")]
	private LandingType landingType;

	[Token(Token = "0x400F6B8")]
	[FieldOffset(Offset = "0xD0")]
	private bool moveFromScreenCenterStrongSummon;

	[Token(Token = "0x400F6B9")]
	[FieldOffset(Offset = "0xD1")]
	private bool moveFromScreenCenterSearchEffect;

	[Token(Token = "0x400F6BA")]
	[FieldOffset(Offset = "0xD2")]
	private bool isAttacker;

	[Token(Token = "0x400F6BB")]
	[FieldOffset(Offset = "0xD3")]
	private bool isAttackTarget;

	[Token(Token = "0x400F6BC")]
	[FieldOffset(Offset = "0xD4")]
	private int attackerPlayer;

	[Token(Token = "0x400F6BD")]
	[FieldOffset(Offset = "0xD8")]
	private int attackerPosition;

	[Token(Token = "0x400F6BE")]
	[FieldOffset(Offset = "0xDC")]
	private int attackTargetPlayer;

	[Token(Token = "0x400F6BF")]
	[FieldOffset(Offset = "0xE0")]
	private int attackTargetPosition;

	[Token(Token = "0x400F6C0")]
	[FieldOffset(Offset = "0xE8")]
	private SummonEffectBase summonEffect;

	[Token(Token = "0x600AED0")]
	[Address(RVA = "0x4605B0", Offset = "0x45F7B0", VA = "0x1804605B0")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AED1")]
	[Address(RVA = "0x460980", Offset = "0x45FB80", VA = "0x180460980")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AED2")]
	[Address(RVA = "0x45FC00", Offset = "0x45EE00", VA = "0x18045FC00")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AED3")]
	[Address(RVA = "0x461F00", Offset = "0x461100", VA = "0x180461F00")]
	public EffectTaskCardMove(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AED4")]
	[Address(RVA = "0x4613D0", Offset = "0x4605D0", VA = "0x1804613D0", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AED5")]
	[Address(RVA = "0x461690", Offset = "0x460890", VA = "0x180461690")]
	private bool WaitCardMoveStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600AED6")]
	[Address(RVA = "0x461D20", Offset = "0x460F20", VA = "0x180461D20")]
	private bool WaitLoadCardStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600AED7")]
	[Address(RVA = "0x461CE0", Offset = "0x460EE0", VA = "0x180461CE0")]
	private bool WaitLoadCardEffectStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600AED8")]
	[Address(RVA = "0x461230", Offset = "0x460430", VA = "0x180461230")]
	private bool StartMoveStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600AED9")]
	[Address(RVA = "0x45DE30", Offset = "0x45D030", VA = "0x18045DE30")]
	private void CommonMove()
	{
	}

	[Token(Token = "0x600AEDA")]
	[Address(RVA = "0x460970", Offset = "0x45FB70", VA = "0x180460970")]
	private void OnFinished()
	{
	}

	[Token(Token = "0x600AEDB")]
	[Address(RVA = "0x45FCA0", Offset = "0x45EEA0", VA = "0x18045FCA0")]
	private void FinishStep()
	{
	}

	[Token(Token = "0x600AEDC")]
	[Address(RVA = "0x4603A0", Offset = "0x45F5A0", VA = "0x1804603A0")]
	private LandingType GetLandingType()
	{
		return default(LandingType);
	}

	[Token(Token = "0x600AEDD")]
	[Address(RVA = "0x45FD30", Offset = "0x45EF30", VA = "0x18045FD30")]
	public static LandingEffectInfo GetLandingEffectInfo(LandingType landingType, SummonEffectType summonEffectType, Engine.CardMoveType moveType)
	{
		return default(LandingEffectInfo);
	}

	[Token(Token = "0x600AEDE")]
	[Address(RVA = "0x460C70", Offset = "0x45FE70", VA = "0x180460C70")]
	private void ReqLandingEffect()
	{
	}

	[Token(Token = "0x600AEDF")]
	[Address(RVA = "0x460560", Offset = "0x45F760", VA = "0x180460560")]
	private bool IsSamePosition(int positionA, int positionB)
	{
		return default(bool);
	}
}
