using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Card;
using YgomSystem.UI;

namespace YgomGame.Duel;

[Token(Token = "0x20019B2")]
public class CardPlane : MonoBehaviour
{
	[Token(Token = "0x20019B3")]
	private enum Step
	{
		[Token(Token = "0x400EDBE")]
		Idle,
		[Token(Token = "0x400EDBF")]
		FlipTurn
	}

	[Token(Token = "0x20019B4")]
	public enum IdlingType
	{
		[Token(Token = "0x400EDC1")]
		Default,
		[Token(Token = "0x400EDC2")]
		HandSelecting,
		[Token(Token = "0x400EDC3")]
		HandDeciding,
		[Token(Token = "0x400EDC4")]
		FieldSelecting,
		[Token(Token = "0x400EDC5")]
		FieldDeciding
	}

	[Token(Token = "0x20019B5")]
	public enum BrokenType
	{
		[Token(Token = "0x400EDC7")]
		Break,
		[Token(Token = "0x400EDC8")]
		Explosion
	}

	[Token(Token = "0x20019B6")]
	public enum MoveTrailType
	{
		[Token(Token = "0x400EDCA")]
		None,
		[Token(Token = "0x400EDCB")]
		Normal,
		[Token(Token = "0x400EDCC")]
		Break,
		[Token(Token = "0x400EDCD")]
		Fusion,
		[Token(Token = "0x400EDCE")]
		Attack,
		[Token(Token = "0x400EDCF")]
		Exclude,
		[Token(Token = "0x400EDD0")]
		BreakExclude,
		[Token(Token = "0x400EDD1")]
		Release,
		[Token(Token = "0x400EDD2")]
		ReleaseExclude,
		[Token(Token = "0x400EDD3")]
		XyzMaterial
	}

	[Token(Token = "0x400ED8F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x400ED90")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
	private float time;

	[Token(Token = "0x400ED91")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private Vector3 fromPosition;

	[Token(Token = "0x400ED92")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
	private Vector3 toPosition;

	[Token(Token = "0x400ED93")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Quaternion fromRotationModel;

	[Token(Token = "0x400ED94")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private Quaternion toRotationModel;

	[Token(Token = "0x400ED95")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private Quaternion fromRotationTurn;

	[Token(Token = "0x400ED96")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private Quaternion toRotationTurn;

	[Token(Token = "0x400ED97")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Action onFinished;

	[Token(Token = "0x400ED98")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private SimpleEffect highlightEff;

	[Token(Token = "0x400ED99")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private int highlightEffectOrder;

	[Token(Token = "0x400ED9A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int highlightEffectOrderOffset;

	[Token(Token = "0x400ED9B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private SimpleEffect moveTrail;

	[Token(Token = "0x400ED9C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private Transform pivot;

	[Token(Token = "0x400ED9F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private DuelEffectPool.Type auraEffType;

	[Token(Token = "0x400EDA2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	private Vector3 currentPivotPosition;

	[Token(Token = "0x400EDA3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xCC")]
	private Quaternion currentPivotRotation;

	[Token(Token = "0x400EDA4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xDC")]
	private bool insight;

	[Token(Token = "0x400EDA5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private IdlingType idlingType;

	[Token(Token = "0x400EDA6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE4")]
	private SharedDefinition.Location location;

	[Token(Token = "0x400EDA7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private BezierMotionSetting flipMotion;

	[Token(Token = "0x400EDA8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private BezierMotionSetting _flipMotionCard;

	[Token(Token = "0x400EDA9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private BezierMotionSetting _flipMotionPlateMonster;

	[Token(Token = "0x400EDAA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private BezierMotionSetting _flipMotionPlateMagic;

	[Token(Token = "0x400EDAB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private BezierMotionSetting _flipMotionDeckCard;

	[Token(Token = "0x400EDAC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private Tween[] tweens;

	[Token(Token = "0x400EDAD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private TweenPosition tweenShakePosition;

	[Token(Token = "0x400EDAE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private TweenRotation tweenShakeRotation;

	[Token(Token = "0x400EDAF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
	private TweenPositionTo tweenAttackReadyStart;

	[Token(Token = "0x400EDB0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
	private TweenPosition tweenAttackReadyIdle;

	[Token(Token = "0x400EDB1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
	private TweenPositionTo tweenAttackReadyFinish;

	[Token(Token = "0x400EDB2")]
	private const string tweenLabelIdlingDefault = "default";

	[Token(Token = "0x400EDB3")]
	private const string tweenLabelIdlingNearHandSelecting = "near_hand_selecting";

	[Token(Token = "0x400EDB4")]
	private const string tweenLabelIdlingNearHandDeciding = "near_hand_deciding";

	[Token(Token = "0x400EDB5")]
	private const string tweenLabelIdlingFarHandSelecting = "far_hand_selecting";

	[Token(Token = "0x400EDB6")]
	private const string tweenLabelIdlingFarHandDeciding = "far_hand_deciding";

	[Token(Token = "0x400EDB7")]
	private const string tweenLabelIdlingFieldSelecting = "field_selecting";

	[Token(Token = "0x400EDB8")]
	private const string tweenLabelIdlingFieldDeciding = "field_deciding";

	[Token(Token = "0x400EDB9")]
	private const string tweenLabelHandAppealEffect = "hand_appeal";

	[Token(Token = "0x17001945")]
	public Transform offset
	{
		[Token(Token = "0x600A534")]
		[Address(RVA = "0x49BDF0", Offset = "0x49AFF0", VA = "0x18049BDF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A535")]
		[Address(RVA = "0x42FF30", Offset = "0x42F130", VA = "0x18042FF30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001946")]
	public Transform turn
	{
		[Token(Token = "0x600A536")]
		[Address(RVA = "0x49BB20", Offset = "0x49AD20", VA = "0x18049BB20")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A537")]
		[Address(RVA = "0x42FF50", Offset = "0x42F150", VA = "0x18042FF50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001947")]
	public bool useFloatingPivot
	{
		[Token(Token = "0x600A538")]
		[Address(RVA = "0xF1A850", Offset = "0xF19A50", VA = "0x180F1A850")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A539")]
		[Address(RVA = "0xF1A8A0", Offset = "0xF19AA0", VA = "0x180F1A8A0")]
		set
		{
		}
	}

	[Token(Token = "0x17001948")]
	public bool floatingPivotPosition
	{
		[Token(Token = "0x600A53A")]
		[Address(RVA = "0xF1A7A0", Offset = "0xF199A0", VA = "0x180F1A7A0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A53B")]
		[Address(RVA = "0xF1A870", Offset = "0xF19A70", VA = "0x180F1A870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x17001949")]
	public bool floatingPivotRotation
	{
		[Token(Token = "0x600A53C")]
		[Address(RVA = "0xF1A7B0", Offset = "0xF199B0", VA = "0x180F1A7B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A53D")]
		[Address(RVA = "0xF1A880", Offset = "0xF19A80", VA = "0x180F1A880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x1700194A")]
	private BezierMotionSetting flipMotionCard
	{
		[Token(Token = "0x600A53E")]
		[Address(RVA = "0xF1A460", Offset = "0xF19660", VA = "0x180F1A460")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194B")]
	private BezierMotionSetting flipMotionPlateMonster
	{
		[Token(Token = "0x600A53F")]
		[Address(RVA = "0xF1A6D0", Offset = "0xF198D0", VA = "0x180F1A6D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194C")]
	private BezierMotionSetting flipMotionPlateMagic
	{
		[Token(Token = "0x600A540")]
		[Address(RVA = "0xF1A600", Offset = "0xF19800", VA = "0x180F1A600")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194D")]
	private BezierMotionSetting flipMotionDeckCard
	{
		[Token(Token = "0x600A541")]
		[Address(RVA = "0xF1A530", Offset = "0xF19730", VA = "0x180F1A530")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700194E")]
	public bool isTerminated
	{
		[Token(Token = "0x600A545")]
		[Address(RVA = "0xF1A800", Offset = "0xF19A00", VA = "0x180F1A800")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700194F")]
	public CardRoot cardRoot
	{
		[Token(Token = "0x600A546")]
		[Address(RVA = "0xB19AE0", Offset = "0xB18CE0", VA = "0x180B19AE0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A547")]
		[Address(RVA = "0xB19B50", Offset = "0xB18D50", VA = "0x180B19B50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001950")]
	public CardModel cardModel
	{
		[Token(Token = "0x600A54A")]
		[Address(RVA = "0xB19AD0", Offset = "0xB18CD0", VA = "0x180B19AD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600A54B")]
		[Address(RVA = "0xB19B30", Offset = "0xB18D30", VA = "0x180B19B30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001951")]
	public bool showing
	{
		[Token(Token = "0x600A54C")]
		[Address(RVA = "0xF1A840", Offset = "0xF19A40", VA = "0x180F1A840")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600A54D")]
		[Address(RVA = "0xF1A890", Offset = "0xF19A90", VA = "0x180F1A890")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001952")]
	public CardRoot.ModelType modelType
	{
		[Token(Token = "0x600A54E")]
		[Address(RVA = "0xF1A820", Offset = "0xF19A20", VA = "0x180F1A820")]
		get
		{
			return default(CardRoot.ModelType);
		}
	}

	[Token(Token = "0x17001953")]
	public bool isLoaded
	{
		[Token(Token = "0x600A55C")]
		[Address(RVA = "0xF1A7C0", Offset = "0xF199C0", VA = "0x180F1A7C0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600A542")]
	[Address(RVA = "0xF16E80", Offset = "0xF16080", VA = "0x180F16E80")]
	public static CardPlane Create(CardRoot cardRoot, GameObject go)
	{
		return null;
	}

	[Token(Token = "0x600A543")]
	[Address(RVA = "0xF17720", Offset = "0xF16920", VA = "0x180F17720")]
	private void Initialize()
	{
	}

	[Token(Token = "0x600A544")]
	[Address(RVA = "0xF19990", Offset = "0xF18B90", VA = "0x180F19990")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600A548")]
	[Address(RVA = "0xF17020", Offset = "0xF16220", VA = "0x180F17020")]
	public void FlipTurn(bool isFace, bool isAttack, bool immediate, bool deckFlip, Action onFinished)
	{
	}

	[Token(Token = "0x600A549")]
	[Address(RVA = "0xF16E40", Offset = "0xF16040", VA = "0x180F16E40")]
	public void CrearContents()
	{
	}

	[Token(Token = "0x600A54F")]
	[Address(RVA = "0xF19830", Offset = "0xF18A30", VA = "0x180F19830")]
	public void Show()
	{
	}

	[Token(Token = "0x600A550")]
	[Address(RVA = "0xF176B0", Offset = "0xF168B0", VA = "0x180F176B0")]
	public void Hide()
	{
	}

	[Token(Token = "0x600A551")]
	[Address(RVA = "0xF16E10", Offset = "0xF16010", VA = "0x180F16E10")]
	public void ChangeModel(CardRoot.ModelType modelType)
	{
	}

	[Token(Token = "0x600A552")]
	[Address(RVA = "0xF18D20", Offset = "0xF17F20", VA = "0x180F18D20")]
	private void SetDispModelCard(bool disp)
	{
	}

	[Token(Token = "0x600A553")]
	[Address(RVA = "0xF18BE0", Offset = "0xF17DE0", VA = "0x180F18BE0")]
	public void SetCardTextures(int cardId, int sleeveId, int uniqueId, int styleId, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x600A554")]
	[Address(RVA = "0xF18080", Offset = "0xF17280", VA = "0x180F18080")]
	public void ReloadTexture(int cardId, int uniqueId, [Optional] Action onLoaded)
	{
	}

	[Token(Token = "0x600A555")]
	[Address(RVA = "0xF183C0", Offset = "0xF175C0", VA = "0x180F183C0")]
	public void ReqHighlight(bool enable, SharedDefinition.ActivateAura type, int order = 0)
	{
	}

	[Token(Token = "0x600A556")]
	[Address(RVA = "0xF18DA0", Offset = "0xF17FA0", VA = "0x180F18DA0")]
	public void SetHighlightEffectOrderOffset(int offset)
	{
	}

	[Token(Token = "0x600A557")]
	[Address(RVA = "0xF199C0", Offset = "0xF18BC0", VA = "0x180F199C0")]
	public static DuelEffectPool.Type TrailTypeToEffectType(MoveTrailType trailType)
	{
		return default(DuelEffectPool.Type);
	}

	[Token(Token = "0x600A558")]
	[Address(RVA = "0xF187F0", Offset = "0xF179F0", VA = "0x180F187F0")]
	public void ReqMoveEffect(DuelEffectPool.Type eff_type, bool perisitent_vision = false)
	{
	}

	[Token(Token = "0x600A559")]
	[Address(RVA = "0xF18A10", Offset = "0xF17C10", VA = "0x180F18A10")]
	public void ReqStopMoveEffect()
	{
	}

	[Token(Token = "0x600A55A")]
	[Address(RVA = "0xF181A0", Offset = "0xF173A0", VA = "0x180F181A0")]
	public void ReqAppealEffect(Action on_finished)
	{
	}

	[Token(Token = "0x600A55B")]
	[Address(RVA = "0xF175F0", Offset = "0xF167F0", VA = "0x180F175F0")]
	public static (bool, DuelEffectPool.Type, string, string) GetBrokenEffectInfo(BrokenType brokenType)
	{
		return default((bool, DuelEffectPool.Type, string, string));
	}

	[Token(Token = "0x600A55D")]
	[Address(RVA = "0xF1A360", Offset = "0xF19560", VA = "0x180F1A360")]
	private void Update()
	{
	}

	[Token(Token = "0x600A55E")]
	[Address(RVA = "0xF18FB0", Offset = "0xF181B0", VA = "0x180F18FB0")]
	private void SetupBackInsight(bool force = false)
	{
	}

	[Token(Token = "0x600A55F")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600A560")]
	[Address(RVA = "0xF16F50", Offset = "0xF16150", VA = "0x180F16F50")]
	private void FlipTurnStep()
	{
	}

	[Token(Token = "0x600A561")]
	[Address(RVA = "0xF19FC0", Offset = "0xF191C0", VA = "0x180F19FC0")]
	private void UpdateTransition(float clampedTime)
	{
	}

	[Token(Token = "0x600A562")]
	[Address(RVA = "0xF18EA0", Offset = "0xF180A0", VA = "0x180F18EA0")]
	public void SetIdlingType(IdlingType idling_type, SharedDefinition.Location location)
	{
	}

	[Token(Token = "0x600A563")]
	[Address(RVA = "0xF17F00", Offset = "0xF17100", VA = "0x180F17F00")]
	public void PlayTween(string label, bool stop_all = true)
	{
	}

	[Token(Token = "0x600A564")]
	[Address(RVA = "0xF19A30", Offset = "0xF18C30", VA = "0x180F19A30")]
	private void UpdatePivot(bool reset = false)
	{
	}

	[Token(Token = "0x600A565")]
	[Address(RVA = "0xF18AA0", Offset = "0xF17CA0", VA = "0x180F18AA0")]
	public void ResetPivotPosition()
	{
	}

	[Token(Token = "0x600A566")]
	[Address(RVA = "0xF18CF0", Offset = "0xF17EF0", VA = "0x180F18CF0")]
	public void SetCastShadow(bool isOn)
	{
	}

	[Token(Token = "0x600A567")]
	[Address(RVA = "0xF190D0", Offset = "0xF182D0", VA = "0x180F190D0")]
	public void Shake(Vector3 groundZero)
	{
	}

	[Token(Token = "0x600A568")]
	[Address(RVA = "0xF198E0", Offset = "0xF18AE0", VA = "0x180F198E0")]
	public void StopShake()
	{
	}

	[Token(Token = "0x600A569")]
	[Address(RVA = "0xF198A0", Offset = "0xF18AA0", VA = "0x180F198A0")]
	public void StartAttackReady()
	{
	}

	[Token(Token = "0x600A56A")]
	[Address(RVA = "0xF16F00", Offset = "0xF16100", VA = "0x180F16F00")]
	public void FinishAttackReady()
	{
	}

	[Token(Token = "0x600A56B")]
	[Address(RVA = "0xF19920", Offset = "0xF18B20", VA = "0x180F19920")]
	public void StopTweens()
	{
	}

	[Token(Token = "0x600A56C")]
	[Address(RVA = "0xF18AB0", Offset = "0xF17CB0", VA = "0x180F18AB0")]
	public void ResetPosition()
	{
	}

	[Token(Token = "0x600A56D")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CardPlane()
	{
	}
}
