using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Playables;
using YgomGame.Card;

namespace YgomGame.Duel;

[Token(Token = "0x2001ACC")]
public class EffectTaskBattleRun : EffectTask
{
	[Token(Token = "0x2001ACD")]
	private enum Step
	{
		[Token(Token = "0x400F5C2")]
		LoadMotion,
		[Token(Token = "0x400F5C3")]
		WaitCardMove,
		[Token(Token = "0x400F5C4")]
		LoadSE,
		[Token(Token = "0x400F5C5")]
		FinalBlowInit,
		[Token(Token = "0x400F5C6")]
		FinalBlow,
		[Token(Token = "0x400F5C7")]
		AttackInit,
		[Token(Token = "0x400F5C8")]
		AttackMove,
		[Token(Token = "0x400F5C9")]
		AttackBack,
		[Token(Token = "0x400F5CA")]
		Lethal,
		[Token(Token = "0x400F5CB")]
		Finish
	}

	[Token(Token = "0x2001ACE")]
	public struct AttackEffectInfo
	{
		[Token(Token = "0x400F5CC")]
		[FieldOffset(Offset = "0x0")]
		public bool isFinished;

		[Token(Token = "0x400F5CD")]
		[FieldOffset(Offset = "0x4")]
		public int srcTeam;

		[Token(Token = "0x400F5CE")]
		[FieldOffset(Offset = "0x8")]
		public int srcPosition;

		[Token(Token = "0x400F5CF")]
		[FieldOffset(Offset = "0xC")]
		public int dstTeam;

		[Token(Token = "0x400F5D0")]
		[FieldOffset(Offset = "0x10")]
		public int dstPosition;

		[Token(Token = "0x400F5D1")]
		[FieldOffset(Offset = "0x14")]
		public int attackLevel;

		[Token(Token = "0x400F5D2")]
		[FieldOffset(Offset = "0x18")]
		public bool isDirectAttack;

		[Token(Token = "0x400F5D3")]
		[FieldOffset(Offset = "0x19")]
		public bool isSrcLethal;

		[Token(Token = "0x400F5D4")]
		[FieldOffset(Offset = "0x1A")]
		public bool isDstLethal;

		[Token(Token = "0x400F5D5")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 attackTargetPos;

		[Token(Token = "0x400F5D6")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 attackDefaultPos;

		[Token(Token = "0x400F5D7")]
		[FieldOffset(Offset = "0x34")]
		public Quaternion attackDefaultRot;

		[Token(Token = "0x400F5D8")]
		[FieldOffset(Offset = "0x44")]
		public Vector3 attackTargetHandPos;

		[Token(Token = "0x400F5D9")]
		[FieldOffset(Offset = "0x50")]
		public Vector3 attackSrcHandPos;

		[Token(Token = "0x400F5DA")]
		[FieldOffset(Offset = "0x5C")]
		public Vector3 attackTargetFieldCenterPos;

		[Token(Token = "0x400F5DB")]
		[FieldOffset(Offset = "0x68")]
		public bool isStart;

		[Token(Token = "0x400F5DC")]
		[FieldOffset(Offset = "0x69")]
		public bool isTrail;

		[Token(Token = "0x400F5DD")]
		[FieldOffset(Offset = "0x6A")]
		public bool isAttack;

		[Token(Token = "0x400F5DE")]
		[FieldOffset(Offset = "0x6B")]
		public bool isHit;

		[Token(Token = "0x400F5DF")]
		[FieldOffset(Offset = "0x6C")]
		public bool isShoot;

		[Token(Token = "0x400F5E0")]
		[FieldOffset(Offset = "0x70")]
		public bool[] timelinePlayed;

		[Token(Token = "0x400F5E1")]
		[FieldOffset(Offset = "0x78")]
		public PlayableDirector[] playingTimeline;

		[Token(Token = "0x400F5E2")]
		[FieldOffset(Offset = "0x80")]
		public SimpleEffect shootEffect;

		[Token(Token = "0x400F5E3")]
		[FieldOffset(Offset = "0x88")]
		public Vector3 shootOriginPosition;

		[Token(Token = "0x400F5E4")]
		[FieldOffset(Offset = "0x94")]
		public Vector3 shootTargetPosition;

		[Token(Token = "0x400F5E5")]
		[FieldOffset(Offset = "0xA0")]
		public Quaternion shootOriginRotation;

		[Token(Token = "0x400F5E6")]
		[FieldOffset(Offset = "0xB0")]
		public Quaternion shootTargetRotation;

		[Token(Token = "0x400F5E7")]
		[FieldOffset(Offset = "0xC0")]
		public ChainedBezierMotion shootMotion;

		[Token(Token = "0x17001AF2")]
		public bool isLethal
		{
			[Token(Token = "0x600AE51")]
			[Address(RVA = "0x455820", Offset = "0x454A20", VA = "0x180455820")]
			get
			{
				return default(bool);
			}
		}
	}

	[Token(Token = "0x2001ACF")]
	public enum AttackType
	{
		[Token(Token = "0x400F5E9")]
		Strike,
		[Token(Token = "0x400F5EA")]
		Flash,
		[Token(Token = "0x400F5EB")]
		Shoot,
		[Token(Token = "0x400F5EC")]
		Unknown
	}

	[Token(Token = "0x400F5A3")]
	[FieldOffset(Offset = "0x18")]
	private bool hitEffect;

	[Token(Token = "0x400F5A4")]
	[FieldOffset(Offset = "0x1C")]
	private Step step;

	[Token(Token = "0x400F5A5")]
	[FieldOffset(Offset = "0x20")]
	private float time;

	[Token(Token = "0x400F5A6")]
	[FieldOffset(Offset = "0x28")]
	private CardRoot cardRoot;

	[Token(Token = "0x400F5A7")]
	[FieldOffset(Offset = "0x30")]
	private int[] damages;

	[Token(Token = "0x400F5A8")]
	[FieldOffset(Offset = "0x38")]
	private int prop;

	[Token(Token = "0x400F5A9")]
	[FieldOffset(Offset = "0x3C")]
	private int srcDamage;

	[Token(Token = "0x400F5AA")]
	[FieldOffset(Offset = "0x40")]
	private int dstDamage;

	[Token(Token = "0x400F5AB")]
	[FieldOffset(Offset = "0x44")]
	private bool isSrcBreak;

	[Token(Token = "0x400F5AC")]
	[FieldOffset(Offset = "0x45")]
	private bool isDstBreak;

	[Token(Token = "0x400F5AD")]
	[FieldOffset(Offset = "0x46")]
	private bool isSrcDamage;

	[Token(Token = "0x400F5AE")]
	[FieldOffset(Offset = "0x47")]
	private bool isDstDamage;

	[Token(Token = "0x400F5AF")]
	[FieldOffset(Offset = "0x48")]
	private AttackEffectInfo attackEffectInfo;

	[Token(Token = "0x400F5B0")]
	[FieldOffset(Offset = "0x110")]
	private Content.Attribute attribute;

	[Token(Token = "0x400F5B1")]
	[FieldOffset(Offset = "0x114")]
	private bool lethalEffectPlaying;

	[Token(Token = "0x400F5B2")]
	[FieldOffset(Offset = "0x115")]
	private bool attackBackPlaying;

	[Token(Token = "0x400F5B3")]
	[FieldOffset(Offset = "0x118")]
	private float finalBlowTimer;

	[Token(Token = "0x400F5B4")]
	private const float finalBlowTime = 1f;

	[Token(Token = "0x400F5B5")]
	public const float hitEffectOfsH = 3f;

	[Token(Token = "0x400F5B6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly Vector3 hitEffectOffset;

	[Token(Token = "0x400F5B7")]
	[FieldOffset(Offset = "0x120")]
	private ChainedBezierMotion runMotion;

	[Token(Token = "0x400F5B8")]
	[FieldOffset(Offset = "0x128")]
	private AttackMotionSetting.MotionInfo motionInfo;

	[Token(Token = "0x400F5B9")]
	[FieldOffset(Offset = "0x130")]
	private int motionIndex;

	[Token(Token = "0x400F5BA")]
	private const string BattleRunAttackSettingPath = "Duel/ScriptableObject/BattleRunAttackSetting";

	[Token(Token = "0x400F5BB")]
	private const string AttackMotionSettingPath = "Duel/ScriptableObject/AttackMotionSetting";

	[Token(Token = "0x400F5BC")]
	[FieldOffset(Offset = "0x134")]
	private int loadCounter;

	[Token(Token = "0x400F5BD")]
	[FieldOffset(Offset = "0x138")]
	private BattleRunAttackSetting attackSetting;

	[Token(Token = "0x400F5BE")]
	[FieldOffset(Offset = "0x140")]
	private LethalEffect.EffectType lethalEffectType;

	[Token(Token = "0x400F5BF")]
	private const string TimelinePathObeliskPunch = "Duel/Timeline/Duel/Universal/Attack/Attack_m04998/Attack_m04998Punch";

	[Token(Token = "0x400F5C0")]
	private const string TimelinePathObeliskScreen = "Duel/Effects/HIT/fxp_hitM_fin/fxp_hitM_fin_m4998/Attackm4998ScreenEffect";

	[Token(Token = "0x17001AF1")]
	private float attackExecPostTime
	{
		[Token(Token = "0x600AE25")]
		[Address(RVA = "0x4420F0", Offset = "0x4412F0", VA = "0x1804420F0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600AE26")]
	[Address(RVA = "0x43D480", Offset = "0x43C680", VA = "0x18043D480")]
	public static void MinimumEffect(RunEffectWorker worker, int param1, int param2, int param3)
	{
	}

	[Token(Token = "0x600AE27")]
	[Address(RVA = "0x440220", Offset = "0x43F420", VA = "0x180440220")]
	public static Dictionary<string, object> PreCreate(RunEffectWorker worker, int param1, int param2, int param3)
	{
		return null;
	}

	[Token(Token = "0x600AE28")]
	[Address(RVA = "0x43CB50", Offset = "0x43BD50", VA = "0x18043CB50")]
	public static EffectTask Create(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
		return null;
	}

	[Token(Token = "0x600AE29")]
	[Address(RVA = "0x441D00", Offset = "0x440F00", VA = "0x180441D00")]
	public EffectTaskBattleRun(RunEffectWorker worker, int param1, int param2, int param3, Dictionary<string, object> immediateWork)
	{
	}

	[Token(Token = "0x600AE2A")]
	[Address(RVA = "0x441910", Offset = "0x440B10", VA = "0x180441910", Slot = "4")]
	public override bool Update()
	{
		return default(bool);
	}

	[Token(Token = "0x600AE2B")]
	[Address(RVA = "0x43D220", Offset = "0x43C420", VA = "0x18043D220")]
	private void LoadMotion()
	{
	}

	[Token(Token = "0x600AE2C")]
	[Address(RVA = "0x43CFD0", Offset = "0x43C1D0", VA = "0x18043CFD0")]
	private static string GetMotionLabel(AttackType attack_type, Content.Attribute attribute, Util.AttackLevel attackLevel, LethalEffect.EffectType effectType, bool isDirect)
	{
		return null;
	}

	[Token(Token = "0x600AE2D")]
	[Address(RVA = "0x43CED0", Offset = "0x43C0D0", VA = "0x18043CED0")]
	public static AttackMotionSetting.MotionInfo GetMotionInfo(AttackMotionSetting setting, AttackType attack_type, Content.Attribute attribute, Util.AttackLevel attackLevel, LethalEffect.EffectType effectType, bool isDirect)
	{
		return null;
	}

	[Token(Token = "0x600AE2E")]
	[Address(RVA = "0x441B00", Offset = "0x440D00", VA = "0x180441B00")]
	private void WaitCardMoveStep()
	{
	}

	[Token(Token = "0x600AE2F")]
	[Address(RVA = "0x43D460", Offset = "0x43C660", VA = "0x18043D460")]
	private void LoadSEStep()
	{
	}

	[Token(Token = "0x600AE30")]
	[Address(RVA = "0x43CBF0", Offset = "0x43BDF0", VA = "0x18043CBF0")]
	private void FinalBlowInitStep()
	{
	}

	[Token(Token = "0x600AE31")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void FinalBlowStep()
	{
	}

	[Token(Token = "0x600AE32")]
	[Address(RVA = "0x439F80", Offset = "0x439180", VA = "0x180439F80")]
	private void AttackInitStep()
	{
	}

	[Token(Token = "0x600AE33")]
	[Address(RVA = "0x43A9C0", Offset = "0x439BC0", VA = "0x18043A9C0")]
	private void AttackMoveStep()
	{
	}

	[Token(Token = "0x600AE34")]
	[Address(RVA = "0x43B3F0", Offset = "0x43A5F0", VA = "0x18043B3F0")]
	public static AttackEffectInfo AttackMove(CardRoot cardRoot, ChainedBezierMotion runMotion, AttackMotionSetting.MotionInfo motionInfo, int motionIndex, float time, AttackEffectInfo attackEffectInfo, DuelEffectPool effectPool)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE35")]
	[Address(RVA = "0x440150", Offset = "0x43F350", VA = "0x180440150")]
	private static AttackEffectInfo PlayTrailEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE36")]
	[Address(RVA = "0x43D560", Offset = "0x43C760", VA = "0x18043D560")]
	private static AttackEffectInfo PlayAttackEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, DuelEffectPool effectPool)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE37")]
	[Address(RVA = "0x43D820", Offset = "0x43CA20", VA = "0x18043D820")]
	private static AttackEffectInfo PlayHitEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, DuelEffectPool effectPool)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE38")]
	[Address(RVA = "0x43EAB0", Offset = "0x43DCB0", VA = "0x18043EAB0")]
	private static AttackEffectInfo PlayShootEffect(CardRoot cardRoot, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, DuelEffectPool effectPool)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE39")]
	[Address(RVA = "0x43F320", Offset = "0x43E520", VA = "0x18043F320")]
	public static AttackEffectInfo PlayTimeline(Transform card, Transform defaultParent, bool isMyself, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, int timelineIndex)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE3A")]
	[Address(RVA = "0x4404D0", Offset = "0x43F6D0", VA = "0x1804404D0")]
	private static void SetupObeliskPunchTimeline(PlayableDirector tl, AttackEffectInfo attackEffectInfo)
	{
	}

	[Token(Token = "0x600AE3B")]
	[Address(RVA = "0x440AC0", Offset = "0x43FCC0", VA = "0x180440AC0")]
	private static void SetupObeliskScreenTimeline(PlayableDirector tl, AttackEffectInfo attackEffectInfo)
	{
	}

	[Token(Token = "0x600AE3C")]
	[Address(RVA = "0x4413B0", Offset = "0x4405B0", VA = "0x1804413B0")]
	public static AttackEffectInfo UpdateTimeline(Transform card, AttackEffectInfo attackEffectInfo, AttackMotionSetting.MotionInfo motionInfo, int timelineIndex)
	{
		return default(AttackEffectInfo);
	}

	[Token(Token = "0x600AE3D")]
	[Address(RVA = "0x43CDC0", Offset = "0x43BFC0", VA = "0x18043CDC0")]
	private static int GetAttackLevel(CardRoot cardRoot, bool includeNoDamage, bool isBreak, bool isDamage, int targetPlayer)
	{
		return default(int);
	}

	[Token(Token = "0x600AE3E")]
	[Address(RVA = "0x43CCE0", Offset = "0x43BEE0", VA = "0x18043CCE0")]
	private Content.Attribute GetAttackAttribute(short element, Content.Attribute originalAttr)
	{
		return default(Content.Attribute);
	}

	[Token(Token = "0x600AE3F")]
	[Address(RVA = "0x43D1D0", Offset = "0x43C3D0", VA = "0x18043D1D0")]
	private int GetNumAttr(int element)
	{
		return default(int);
	}

	[Token(Token = "0x600AE40")]
	[Address(RVA = "0x4410A0", Offset = "0x4402A0", VA = "0x1804410A0")]
	private void ShowDamage()
	{
	}

	[Token(Token = "0x600AE41")]
	[Address(RVA = "0x440ED0", Offset = "0x4400D0", VA = "0x180440ED0")]
	private void ShowDamageImpl(int team, int position, int damage)
	{
	}

	[Token(Token = "0x600AE42")]
	[Address(RVA = "0x440380", Offset = "0x43F580", VA = "0x180440380")]
	private void SetCardLayer(int layer)
	{
	}

	[Token(Token = "0x600AE43")]
	[Address(RVA = "0x43D200", Offset = "0x43C400", VA = "0x18043D200")]
	private void LethalStep()
	{
	}
}
