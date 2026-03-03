using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Utility;

namespace YgomGame.Duel;

[Token(Token = "0x2001A7D")]
public class SharedDefinition
{
	[Token(Token = "0x2001A7E")]
	public enum Location
	{
		[Token(Token = "0x400F458")]
		Near,
		[Token(Token = "0x400F459")]
		Far,
		[Token(Token = "0x400F45A")]
		Max
	}

	[Token(Token = "0x2001A7F")]
	public enum SelectableShaderZTest
	{
		[Token(Token = "0x400F45C")]
		Always,
		[Token(Token = "0x400F45D")]
		NotEqual,
		[Token(Token = "0x400F45E")]
		Equal,
		[Token(Token = "0x400F45F")]
		GEqual,
		[Token(Token = "0x400F460")]
		LEqual,
		[Token(Token = "0x400F461")]
		Greater,
		[Token(Token = "0x400F462")]
		Less
	}

	[Token(Token = "0x2001A80")]
	public enum SelectableShaderCull
	{
		[Token(Token = "0x400F464")]
		None,
		[Token(Token = "0x400F465")]
		Front,
		[Token(Token = "0x400F466")]
		Back
	}

	[Token(Token = "0x2001A81")]
	public enum ActivateAura
	{
		[Token(Token = "0x400F468")]
		None,
		[Token(Token = "0x400F469")]
		LowDefault,
		[Token(Token = "0x400F46A")]
		LowSelecting,
		[Token(Token = "0x400F46B")]
		MiddleDefault,
		[Token(Token = "0x400F46C")]
		MiddleSelecting,
		[Token(Token = "0x400F46D")]
		HighDefault,
		[Token(Token = "0x400F46E")]
		HighSelecting,
		[Token(Token = "0x400F46F")]
		HighMidDefault,
		[Token(Token = "0x400F470")]
		HighMidSelecting
	}

	[Token(Token = "0x2001A82")]
	public enum DuelSelectorPriority
	{
		[Token(Token = "0x400F472")]
		Field = 0,
		[Token(Token = "0x400F473")]
		CardCommand = 1,
		[Token(Token = "0x400F474")]
		CardDetail = 2,
		[Token(Token = "0x400F475")]
		Dialog = 3,
		[Token(Token = "0x400F476")]
		EndMessage = 4,
		[Token(Token = "0x400F477")]
		CardList = 5,
		[Token(Token = "0x400F478")]
		DuelLog = 5,
		[Token(Token = "0x400F479")]
		DrawOperation = 6,
		[Token(Token = "0x400F47A")]
		HUD = 7,
		[Token(Token = "0x400F47B")]
		CardListMobile = 8,
		[Token(Token = "0x400F47C")]
		DuelLogMobile = 8,
		[Token(Token = "0x400F47D")]
		OverHUD = 9,
		[Token(Token = "0x400F47E")]
		CursorJump = 10,
		[Token(Token = "0x400F47F")]
		PhaseSelect = 11,
		[Token(Token = "0x400F480")]
		TutorialMessage = 12,
		[Token(Token = "0x400F481")]
		DuelMenu = 13,
		[Token(Token = "0x400F482")]
		CardInfoDetail = 14,
		[Token(Token = "0x400F483")]
		ProfileCard = 15,
		[Token(Token = "0x400F484")]
		AutoCloseToggle = 16,
		[Token(Token = "0x400F485")]
		Max = 17
	}

	[Token(Token = "0x2001A83")]
	public enum DuelSelectorFieldPriority
	{
		[Token(Token = "0x400F487")]
		Ground,
		[Token(Token = "0x400F488")]
		BG,
		[Token(Token = "0x400F489")]
		Field,
		[Token(Token = "0x400F48A")]
		Hand,
		[Token(Token = "0x400F48B")]
		Log,
		[Token(Token = "0x400F48C")]
		CardViewList,
		[Token(Token = "0x400F48D")]
		CardSelectList,
		[Token(Token = "0x400F48E")]
		GenericCardList,
		[Token(Token = "0x400F48F")]
		Command,
		[Token(Token = "0x400F490")]
		Dialog
	}

	[Token(Token = "0x2001A84")]
	public enum SummonMaterialType
	{
		[Token(Token = "0x400F492")]
		None,
		[Token(Token = "0x400F493")]
		Advance,
		[Token(Token = "0x400F494")]
		SpSummon,
		[Token(Token = "0x400F495")]
		Ritual,
		[Token(Token = "0x400F496")]
		Fusion,
		[Token(Token = "0x400F497")]
		Syncro,
		[Token(Token = "0x400F498")]
		Xyz,
		[Token(Token = "0x400F499")]
		Link,
		[Token(Token = "0x400F49A")]
		SuperFusion
	}

	[Token(Token = "0x2001A85")]
	public enum ZoneType
	{
		[Token(Token = "0x400F49C")]
		Monster,
		[Token(Token = "0x400F49D")]
		Magic,
		[Token(Token = "0x400F49E")]
		Card
	}

	[Token(Token = "0x400F404")]
	public const int numTeams = 2;

	[Token(Token = "0x400F405")]
	public const int numCardPoolInstances = 30;

	[Token(Token = "0x400F406")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<DuelClient.DuelSpeed, float> cardMoveDulationTbl;

	[Token(Token = "0x400F407")]
	[FieldOffset(Offset = "0x8")]
	private static readonly Dictionary<DuelClient.DuelSpeed, float> duelTimeScaleTbl;

	[Token(Token = "0x400F408")]
	[FieldOffset(Offset = "0x10")]
	public static readonly Vector3 deckToDeckMoveBezierOfs;

	[Token(Token = "0x400F409")]
	public const string cardModelResPath = "Duel/Models/CardModelWrapper";

	[Token(Token = "0x400F40A")]
	public const string nearFieldQuickModelResPath = "Duel/Models/DuelFieldQuick_FrameNear";

	[Token(Token = "0x400F40B")]
	public const string farFieldQuickModelResPath = "Duel/Models/DuelFieldQiuck_FrameFar";

	[Token(Token = "0x400F40C")]
	public const string nearFieldMaster3ModelResPath = "Duel/Models/DuelFieldMaster3_FrameNear";

	[Token(Token = "0x400F40D")]
	public const string farFieldMaster3ModelResPath = "Duel/Models/DuelFieldMaster3_FrameFar";

	[Token(Token = "0x400F40E")]
	public const string nearFieldNewMasterModelResPath = "Duel/Models/DuelFieldNewMaster_FrameNear";

	[Token(Token = "0x400F40F")]
	public const string farFieldNewMasterModelResPath = "Duel/Models/DuelFieldNewMaster_FrameFar";

	[Token(Token = "0x400F410")]
	public const float mainCameraFieldOfView = 60f;

	[Token(Token = "0x400F411")]
	public const float mainCameraDepth = -10f;

	[Token(Token = "0x400F412")]
	public const float demoCameraDepth = 1f;

	[Token(Token = "0x400F413")]
	public const float changeCameraDuration = 1f;

	[Token(Token = "0x400F414")]
	public const float cardObjAlphaDulation = 0.25f;

	[Token(Token = "0x400F415")]
	public const float cardPlaneBaseY = 0.025f;

	[Token(Token = "0x400F416")]
	public const float cardIconOfs = 0.01f;

	[Token(Token = "0x400F417")]
	public const float cardHighlightEffectOfs = 0.02f;

	[Token(Token = "0x400F418")]
	public const float cardIconY = 0.035f;

	[Token(Token = "0x400F419")]
	public const float modelStagingDistance = 140f;

	[Token(Token = "0x400F41A")]
	public const float handDistanceNear = 85f;

	[Token(Token = "0x400F41B")]
	public const float handDistanceFar = 105f;

	[Token(Token = "0x400F41C")]
	public const float drawStagingDistance = 56f;

	[Token(Token = "0x400F41D")]
	public const float deckShuffleStagingDistance = 56f;

	[Token(Token = "0x400F41E")]
	public const float modelStagingTweenDulation = 0.4f;

	[Token(Token = "0x400F41F")]
	public const float minIntervalTimeToAbortCutin = 0.5f;

	[Token(Token = "0x400F420")]
	[FieldOffset(Offset = "0x1C")]
	public static readonly int material_TintColor;

	[Token(Token = "0x400F421")]
	[FieldOffset(Offset = "0x20")]
	public static readonly int material_LineColor;

	[Token(Token = "0x400F422")]
	[FieldOffset(Offset = "0x24")]
	public static readonly int material_ZTest;

	[Token(Token = "0x400F423")]
	[FieldOffset(Offset = "0x28")]
	public static readonly int material_Cull;

	[Token(Token = "0x400F424")]
	[FieldOffset(Offset = "0x2C")]
	public static readonly int material_BlendDstFactor;

	[Token(Token = "0x400F425")]
	[FieldOffset(Offset = "0x30")]
	public static readonly int material_FogEnabled;

	[Token(Token = "0x400F426")]
	public const string reachedToDuelStartKey = "ReachedToDuelStart";

	[Token(Token = "0x400F427")]
	public const string reachedToDuelEndKey = "ReachedToDuelEnd";

	[Token(Token = "0x400F428")]
	[FieldOffset(Offset = "0x34")]
	public static readonly Color tunerColor;

	[Token(Token = "0x400F429")]
	public const string SelectorGroupLabelDuelMain = "DuelMain";

	[Token(Token = "0x400F42A")]
	public const string SelectorGroupLabelCommonDialog = "CommonDialog";

	[Token(Token = "0x400F42B")]
	public const string SelectorGroupLabelCardSelectList = "CardSelectList";

	[Token(Token = "0x400F42C")]
	public const string SelectorGroupLabelCardViewList = "CardViewList";

	[Token(Token = "0x400F42D")]
	[FieldOffset(Offset = "0x44")]
	public static int baseSelectorPriority;

	[Token(Token = "0x400F42E")]
	private const string duelDefinitionSettingPath = "Duel/ScriptableObject/Definition/";

	[Token(Token = "0x400F42F")]
	public const string handCardDefinitionSettingPath = "Duel/ScriptableObject/Definition/HandCardDefine";

	[Token(Token = "0x400F430")]
	public const string duelEffectDefinitionSettingPath = "Duel/ScriptableObject/Definition/DuelEffectDefine";

	[Token(Token = "0x400F431")]
	[FieldOffset(Offset = "0x48")]
	private static DefinitionSetting _duelEffectDefine;

	[Token(Token = "0x400F44F")]
	[FieldOffset(Offset = "0x110")]
	public static int[] positionPriority;

	[Token(Token = "0x400F450")]
	[FieldOffset(Offset = "0x118")]
	public static int[] positionPriorityEx;

	[Token(Token = "0x400F451")]
	[FieldOffset(Offset = "0x120")]
	public static int[] monsterPositionPriority;

	[Token(Token = "0x400F452")]
	[FieldOffset(Offset = "0x128")]
	private static int[] _playerPriority;

	[Token(Token = "0x400F453")]
	[FieldOffset(Offset = "0x130")]
	private static int[] _playerPriorityReverse;

	[Token(Token = "0x400F455")]
	public const int playerNum = 2;

	[Token(Token = "0x400F456")]
	public const float holdTime = 1f;

	[Token(Token = "0x17001A8F")]
	public static float cardMoveDulation
	{
		[Token(Token = "0x600AC23")]
		[Address(RVA = "0x4312F0", Offset = "0x4304F0", VA = "0x1804312F0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A90")]
	public static float cardFlipDulation
	{
		[Token(Token = "0x600AC24")]
		[Address(RVA = "0x430FB0", Offset = "0x4301B0", VA = "0x180430FB0")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A91")]
	public static float duelTimeScale
	{
		[Token(Token = "0x600AC25")]
		[Address(RVA = "0x431770", Offset = "0x430970", VA = "0x180431770")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A92")]
	public static bool waitCompleteTimeline
	{
		[Token(Token = "0x600AC28")]
		[Address(RVA = "0x431DE0", Offset = "0x430FE0", VA = "0x180431DE0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001A93")]
	public static float shuffleDeckSpeedNormal
	{
		[Token(Token = "0x600AC29")]
		[Address(RVA = "0x431D80", Offset = "0x430F80", VA = "0x180431D80")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A94")]
	public static float shuffleDeckSpeed
	{
		[Token(Token = "0x600AC2A")]
		[Address(RVA = "0x431D90", Offset = "0x430F90", VA = "0x180431D90")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A95")]
	public static DefinitionSetting duelEffectDefine
	{
		[Token(Token = "0x600AC2C")]
		[Address(RVA = "0x431720", Offset = "0x430920", VA = "0x180431720")]
		get
		{
			return null;
		}
		[Token(Token = "0x600AC2D")]
		[Address(RVA = "0x4326B0", Offset = "0x4318B0", VA = "0x1804326B0")]
		set
		{
		}
	}

	[Token(Token = "0x17001A96")]
	public static float cardFloatingPositionFactor
	{
		[Token(Token = "0x600AC2E")]
		[Address(RVA = "0x431060", Offset = "0x430260", VA = "0x180431060")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC2F")]
		[Address(RVA = "0x432000", Offset = "0x431200", VA = "0x180432000")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A97")]
	public static float cardFloatingRotationFactor
	{
		[Token(Token = "0x600AC30")]
		[Address(RVA = "0x431100", Offset = "0x430300", VA = "0x180431100")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC31")]
		[Address(RVA = "0x4320C0", Offset = "0x4312C0", VA = "0x1804320C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A98")]
	public static float cardFloatingPower
	{
		[Token(Token = "0x600AC32")]
		[Address(RVA = "0x4310B0", Offset = "0x4302B0", VA = "0x1804310B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC33")]
		[Address(RVA = "0x432060", Offset = "0x431260", VA = "0x180432060")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A99")]
	public static float cardFloatingRotationLimit
	{
		[Token(Token = "0x600AC34")]
		[Address(RVA = "0x431150", Offset = "0x430350", VA = "0x180431150")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC35")]
		[Address(RVA = "0x432120", Offset = "0x431320", VA = "0x180432120")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A9A")]
	public static float directAttackPositionHeight
	{
		[Token(Token = "0x600AC36")]
		[Address(RVA = "0x431610", Offset = "0x430810", VA = "0x180431610")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC37")]
		[Address(RVA = "0x432570", Offset = "0x431770", VA = "0x180432570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A9B")]
	public static Vector2 directAttackViewportNear
	{
		[Token(Token = "0x600AC38")]
		[Address(RVA = "0x4316C0", Offset = "0x4308C0", VA = "0x1804316C0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600AC39")]
		[Address(RVA = "0x432640", Offset = "0x431840", VA = "0x180432640")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A9C")]
	public static Vector2 directAttackViewportFar
	{
		[Token(Token = "0x600AC3A")]
		[Address(RVA = "0x431660", Offset = "0x430860", VA = "0x180431660")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Token(Token = "0x600AC3B")]
		[Address(RVA = "0x4325D0", Offset = "0x4317D0", VA = "0x1804325D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A9D")]
	public static float landingEffectTimeLow
	{
		[Token(Token = "0x600AC3C")]
		[Address(RVA = "0x431840", Offset = "0x430A40", VA = "0x180431840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC3D")]
		[Address(RVA = "0x433800", Offset = "0x432A00", VA = "0x180433800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A9E")]
	public static float landingEffectTimeMiddle
	{
		[Token(Token = "0x600AC3E")]
		[Address(RVA = "0x431890", Offset = "0x430A90", VA = "0x180431890")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC3F")]
		[Address(RVA = "0x433860", Offset = "0x432A60", VA = "0x180433860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001A9F")]
	public static float landingEffectTimeHigh
	{
		[Token(Token = "0x600AC40")]
		[Address(RVA = "0x4317F0", Offset = "0x4309F0", VA = "0x1804317F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC41")]
		[Address(RVA = "0x4337A0", Offset = "0x4329A0", VA = "0x1804337A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA0")]
	public static float cardShakeDurationMax
	{
		[Token(Token = "0x600AC42")]
		[Address(RVA = "0x4314F0", Offset = "0x4306F0", VA = "0x1804314F0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC43")]
		[Address(RVA = "0x432450", Offset = "0x431650", VA = "0x180432450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA1")]
	public static float cardShakeDurationDistanceReductor
	{
		[Token(Token = "0x600AC44")]
		[Address(RVA = "0x431490", Offset = "0x430690", VA = "0x180431490")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC45")]
		[Address(RVA = "0x4323F0", Offset = "0x4315F0", VA = "0x1804323F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA2")]
	public static float cardShakeDelayFactor
	{
		[Token(Token = "0x600AC46")]
		[Address(RVA = "0x431430", Offset = "0x430630", VA = "0x180431430")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC47")]
		[Address(RVA = "0x432390", Offset = "0x431590", VA = "0x180432390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA3")]
	public static float cardShakeHeightMax
	{
		[Token(Token = "0x600AC48")]
		[Address(RVA = "0x4315B0", Offset = "0x4307B0", VA = "0x1804315B0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC49")]
		[Address(RVA = "0x432510", Offset = "0x431710", VA = "0x180432510")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA4")]
	public static float cardShakeHeightDistanceReductor
	{
		[Token(Token = "0x600AC4A")]
		[Address(RVA = "0x431550", Offset = "0x430750", VA = "0x180431550")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC4B")]
		[Address(RVA = "0x4324B0", Offset = "0x4316B0", VA = "0x1804324B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA5")]
	public static float cardShakeAngleMax
	{
		[Token(Token = "0x600AC4C")]
		[Address(RVA = "0x4313D0", Offset = "0x4305D0", VA = "0x1804313D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC4D")]
		[Address(RVA = "0x432330", Offset = "0x431530", VA = "0x180432330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA6")]
	public static float cardShakeAngleDistanceReductor
	{
		[Token(Token = "0x600AC4E")]
		[Address(RVA = "0x431370", Offset = "0x430570", VA = "0x180431370")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC4F")]
		[Address(RVA = "0x4322D0", Offset = "0x4314D0", VA = "0x1804322D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA7")]
	public static Vector3 cardModelScaleDefault
	{
		[Token(Token = "0x600AC50")]
		[Address(RVA = "0x4311A0", Offset = "0x4303A0", VA = "0x1804311A0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AC51")]
		[Address(RVA = "0x432180", Offset = "0x431380", VA = "0x180432180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA8")]
	public static Vector3 cardModelScaleMonster
	{
		[Token(Token = "0x600AC52")]
		[Address(RVA = "0x431280", Offset = "0x430480", VA = "0x180431280")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AC53")]
		[Address(RVA = "0x432260", Offset = "0x431460", VA = "0x180432260")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AA9")]
	public static Vector3 cardModelScaleMagic
	{
		[Token(Token = "0x600AC54")]
		[Address(RVA = "0x431210", Offset = "0x430410", VA = "0x180431210")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AC55")]
		[Address(RVA = "0x4321F0", Offset = "0x4313F0", VA = "0x1804321F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AAA")]
	public static float lethalSlowScale
	{
		[Token(Token = "0x600AC56")]
		[Address(RVA = "0x4319A0", Offset = "0x430BA0", VA = "0x1804319A0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC57")]
		[Address(RVA = "0x433980", Offset = "0x432B80", VA = "0x180433980")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AAB")]
	public static float lethalSlowTime
	{
		[Token(Token = "0x600AC58")]
		[Address(RVA = "0x431A00", Offset = "0x430C00", VA = "0x180431A00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC59")]
		[Address(RVA = "0x4339E0", Offset = "0x432BE0", VA = "0x1804339E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AAC")]
	public static float lethalMateWonMotionTime
	{
		[Token(Token = "0x600AC5A")]
		[Address(RVA = "0x4318E0", Offset = "0x430AE0", VA = "0x1804318E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC5B")]
		[Address(RVA = "0x4338C0", Offset = "0x432AC0", VA = "0x1804338C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AAD")]
	public static float lethalMateWonMotionWaitTime
	{
		[Token(Token = "0x600AC5C")]
		[Address(RVA = "0x431940", Offset = "0x430B40", VA = "0x180431940")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Token(Token = "0x600AC5D")]
		[Address(RVA = "0x433920", Offset = "0x432B20", VA = "0x180433920")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AAE")]
	public static int zoneCardInNum
	{
		[Token(Token = "0x600AC5E")]
		[Address(RVA = "0x431FA0", Offset = "0x4311A0", VA = "0x180431FA0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600AC5F")]
		[Address(RVA = "0x433C40", Offset = "0x432E40", VA = "0x180433C40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AAF")]
	public static Vector3 zoneCardInGraveOffset
	{
		[Token(Token = "0x600AC60")]
		[Address(RVA = "0x431ED0", Offset = "0x4310D0", VA = "0x180431ED0")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AC61")]
		[Address(RVA = "0x433B70", Offset = "0x432D70", VA = "0x180433B70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AB0")]
	public static Vector3 zoneCardInExcludeOffset
	{
		[Token(Token = "0x600AC62")]
		[Address(RVA = "0x431E00", Offset = "0x431000", VA = "0x180431E00")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x600AC63")]
		[Address(RVA = "0x433AA0", Offset = "0x432CA0", VA = "0x180433AA0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AB1")]
	public static Quaternion zoneCardInGraveRotation
	{
		[Token(Token = "0x600AC64")]
		[Address(RVA = "0x431F40", Offset = "0x431140", VA = "0x180431F40")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600AC65")]
		[Address(RVA = "0x433BE0", Offset = "0x432DE0", VA = "0x180433BE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AB2")]
	public static Quaternion zoneCardInExcludeRotation
	{
		[Token(Token = "0x600AC66")]
		[Address(RVA = "0x431E70", Offset = "0x431070", VA = "0x180431E70")]
		[CompilerGenerated]
		get
		{
			return default(Quaternion);
		}
		[Token(Token = "0x600AC67")]
		[Address(RVA = "0x433B10", Offset = "0x432D10", VA = "0x180433B10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001AB3")]
	private static int[] playerPriority
	{
		[Token(Token = "0x600AC69")]
		[Address(RVA = "0x431BC0", Offset = "0x430DC0", VA = "0x180431BC0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AB4")]
	private static int[] playerPriorityReverse
	{
		[Token(Token = "0x600AC6A")]
		[Address(RVA = "0x431A60", Offset = "0x430C60", VA = "0x180431A60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001AB5")]
	public static int recommendSide
	{
		[Token(Token = "0x600AC6B")]
		[Address(RVA = "0x431D20", Offset = "0x430F20", VA = "0x180431D20")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600AC6C")]
		[Address(RVA = "0x433A40", Offset = "0x432C40", VA = "0x180433A40")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Token(Token = "0x600AC26")]
	[Address(RVA = "0x430A60", Offset = "0x42FC60", VA = "0x180430A60")]
	public static int LocationPlayer(Location location)
	{
		return default(int);
	}

	[Token(Token = "0x600AC27")]
	[Address(RVA = "0x430AD0", Offset = "0x42FCD0", VA = "0x180430AD0")]
	public static Location PlayerLocation(int player)
	{
		return default(Location);
	}

	[Token(Token = "0x600AC2B")]
	[Address(RVA = "0x430940", Offset = "0x42FB40", VA = "0x180430940")]
	public static int GetSelectorPriority(DuelSelectorPriority priority)
	{
		return default(int);
	}

	[Token(Token = "0x600AC68")]
	[Address(RVA = "0x4309A0", Offset = "0x42FBA0", VA = "0x1804309A0")]
	public static ZoneType GetZoneType(int player, int position, bool ignoreCard)
	{
		return default(ZoneType);
	}

	[Token(Token = "0x600AC6D")]
	[Address(RVA = "0x4306C0", Offset = "0x42F8C0", VA = "0x1804306C0")]
	public static int GetPlayerPriority(int index)
	{
		return default(int);
	}

	[Token(Token = "0x600AC6E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SharedDefinition()
	{
	}
}
