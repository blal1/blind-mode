using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Duel;

namespace YgomGame.Bg;

[Token(Token = "0x2001D6F")]
public class BgUnit
{
	[Token(Token = "0x2001D70")]
	public enum Side
	{
		[Token(Token = "0x40103DE")]
		Near,
		[Token(Token = "0x40103DF")]
		Far
	}

	[Token(Token = "0x2001D71")]
	public enum ResultType
	{
		[Token(Token = "0x40103E1")]
		None,
		[Token(Token = "0x40103E2")]
		Win,
		[Token(Token = "0x40103E3")]
		Lose,
		[Token(Token = "0x40103E4")]
		Draw,
		[Token(Token = "0x40103E5")]
		Time
	}

	[Token(Token = "0x2001D72")]
	public enum BgPhase
	{
		[Token(Token = "0x40103E7")]
		Phase1,
		[Token(Token = "0x40103E8")]
		Phase2,
		[Token(Token = "0x40103E9")]
		Phase3,
		[Token(Token = "0x40103EA")]
		Phase4,
		[Token(Token = "0x40103EB")]
		PhaseEnd
	}

	[Token(Token = "0x2001D73")]
	public enum BgResourceIdx
	{
		[Token(Token = "0x40103ED")]
		BgModel,
		[Token(Token = "0x40103EE")]
		AvatarStand,
		[Token(Token = "0x40103EF")]
		Grave,
		[Token(Token = "0x40103F0")]
		AvatarBase,
		[Token(Token = "0x40103F1")]
		AvatarModel,
		[Token(Token = "0x40103F2")]
		SubAvatarModel,
		[Token(Token = "0x40103F3")]
		ChangeEffect,
		[Token(Token = "0x40103F4")]
		Max
	}

	[Token(Token = "0x2001D74")]
	public enum AvatarStandType
	{
		[Token(Token = "0x40103F6")]
		None,
		[Token(Token = "0x40103F7")]
		Common,
		[Token(Token = "0x40103F8")]
		Unique
	}

	[Token(Token = "0x2001D7B")]
	[CompilerGenerated]
	private sealed class _003CAudienceReplayEnd_003Ed__120 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401040A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401040B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x401040C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BgUnit _003C_003E4__this;

		[Token(Token = "0x401040D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003CwaitTime_003E5__2;

		[Token(Token = "0x17001C1C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BD2C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C1D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BD2E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BD29")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAudienceReplayEnd_003Ed__120(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BD2A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BD2B")]
		[Address(RVA = "0x58F610", Offset = "0x58E810", VA = "0x18058F610", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BD2D")]
		[Address(RVA = "0x58F800", Offset = "0x58EA00", VA = "0x18058F800", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D7C")]
	[CompilerGenerated]
	private sealed class _003CPlayAvatarChangeAnimationInner_003Ed__108 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401040E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401040F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010410")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BgUnit _003C_003E4__this;

		[Token(Token = "0x4010411")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x4010412")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		public Character.SubAvatarChange condition;

		[Token(Token = "0x4010413")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x34")]
		public AvatarMotionSetting.MotionID motionId2;

		[Token(Token = "0x4010414")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public AvatarMotionSetting.MotionID motionId1;

		[Token(Token = "0x4010415")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private Action _003CchangeFunction_003E5__2;

		[Token(Token = "0x17001C1E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BD32")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C1F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BD34")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BD2F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayAvatarChangeAnimationInner_003Ed__108(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BD30")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BD31")]
		[Address(RVA = "0x590BF0", Offset = "0x58FDF0", VA = "0x180590BF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BD33")]
		[Address(RVA = "0x591040", Offset = "0x590240", VA = "0x180591040", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D7D")]
	[CompilerGenerated]
	private sealed class _003CPlayEffectDelay_003Ed__109 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010416")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010417")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010418")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BgUnit _003C_003E4__this;

		[Token(Token = "0x17001C20")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BD38")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C21")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BD3A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BD35")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayEffectDelay_003Ed__109(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BD36")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BD37")]
		[Address(RVA = "0x591080", Offset = "0x590280", VA = "0x180591080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BD39")]
		[Address(RVA = "0x5911E0", Offset = "0x5903E0", VA = "0x1805911E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40103B0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private BgEffectSettingInner.TriggerLabelDefine[] damageTriggerDefines;

	[Token(Token = "0x40103B1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private BgEffectSettingInner.TriggerLabelDefine[] phaseChangeDefines;

	[Token(Token = "0x40103B2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private BgEffectManagerInner.BgAnimationEventParam[] eventParams;

	[Token(Token = "0x40103B3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private BgEffectSettingInner.TriggerLabelDefine[] phaseKeepDefines;

	[Token(Token = "0x40103B4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private BgEffectSettingInner.AnimationLabelDefine[] loopDefines;

	[Token(Token = "0x40103B5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private BgEffectSettingInner.AnimationLabelDefine[] tapPhaseDefines;

	[Token(Token = "0x40103B6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private Dictionary<BgEffectSettingInner.TriggerLabelDefine, BgEffectSettingInner.TriggerLabelDefine> DamagePhaseLabelPairs;

	[Token(Token = "0x40103B7")]
	private const float avatarSePan = 0.4f;

	[Token(Token = "0x40103B8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private Side playerSide;

	[Token(Token = "0x40103B9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private int bgNo;

	[Token(Token = "0x40103BA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private string bgSeLabel;

	[Token(Token = "0x40103BB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private string[] bgResPath;

	[Token(Token = "0x40103BC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private GameObject[] bgModelSrc;

	[Token(Token = "0x40103BD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject bgModel;

	[Token(Token = "0x40103BE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private BgEffectManagerInner effectManager;

	[Token(Token = "0x40103C3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private GameObject avatarStandModel;

	[Token(Token = "0x40103C4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private Animator avatarStandAnimator;

	[Token(Token = "0x40103C5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private int graveNo;

	[Token(Token = "0x40103C6")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x9C")]
	private BgGrave.GraveType graveType;

	[Token(Token = "0x40103C7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private BgGrave bgGrave;

	[Token(Token = "0x40103C8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private int loadCount;

	[Token(Token = "0x40103C9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAC")]
	public bool isErrModelSrc;

	[Token(Token = "0x40103CA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAD")]
	public bool bgResLoaded;

	[Token(Token = "0x40103CB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xAE")]
	private bool isTerminated;

	[Token(Token = "0x40103CC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private BgPhase phase;

	[Token(Token = "0x40103CD")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	public Transform avatarStandRoot;

	[Token(Token = "0x40103CE")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
	public Transform avatarRoot;

	[Token(Token = "0x40103CF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
	public Transform graveRoot;

	[Token(Token = "0x40103D0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
	private Character activeCharacter;

	[Token(Token = "0x40103D1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
	private Character charaModel;

	[Token(Token = "0x40103D2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
	private Character subCharaModel;

	[Token(Token = "0x40103D3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
	private Dictionary<Character.SubAvatarChange, AvatarModelSetting.ChangeCondition> conditionDic;

	[Token(Token = "0x40103D4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
	private Dictionary<Character.SubAvatarChange, AvatarModelSetting.ChangeCondition> subAvatarConditionDic;

	[Token(Token = "0x40103D5")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
	private bool changeLock;

	[Token(Token = "0x40103D6")]
	private const int ChangeDelayCntDef = 2000;

	[Token(Token = "0x40103D7")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xFC")]
	private int changeDelayCnt;

	[Token(Token = "0x40103D8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
	private bool isPlayDirectAttack;

	[Token(Token = "0x40103D9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private BgAvatarChangeEffect changeEffect;

	[Token(Token = "0x40103DA")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private BgUnit otherUnit;

	[Token(Token = "0x40103DB")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private Action objectTapCallback;

	[Token(Token = "0x40103DC")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private Action delayChangeCallback;

	[Token(Token = "0x17001C13")]
	public int BgNo
	{
		[Token(Token = "0x600BCC9")]
		[Address(RVA = "0x49BD80", Offset = "0x49AF80", VA = "0x18049BD80")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C14")]
	public int AvatarNo
	{
		[Token(Token = "0x600BCCA")]
		[Address(RVA = "0x55E5E0", Offset = "0x55D7E0", VA = "0x18055E5E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600BCCB")]
		[Address(RVA = "0x55E600", Offset = "0x55D800", VA = "0x18055E600")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C15")]
	public int SubAvatarNo
	{
		[Token(Token = "0x600BCCC")]
		[Address(RVA = "0x55E5F0", Offset = "0x55D7F0", VA = "0x18055E5F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600BCCD")]
		[Address(RVA = "0x55E610", Offset = "0x55D810", VA = "0x18055E610")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C16")]
	public AvatarStandType StandType
	{
		[Token(Token = "0x600BCCE")]
		[Address(RVA = "0x5889C0", Offset = "0x587BC0", VA = "0x1805889C0")]
		[CompilerGenerated]
		get
		{
			return default(AvatarStandType);
		}
		[Token(Token = "0x600BCCF")]
		[Address(RVA = "0x588B20", Offset = "0x587D20", VA = "0x180588B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C17")]
	public int StandNo
	{
		[Token(Token = "0x600BCD0")]
		[Address(RVA = "0x4497E0", Offset = "0x4489E0", VA = "0x1804497E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x600BCD1")]
		[Address(RVA = "0x449830", Offset = "0x448A30", VA = "0x180449830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C18")]
	public BgGrave.GraveType GraveType
	{
		[Token(Token = "0x600BCD2")]
		[Address(RVA = "0x588970", Offset = "0x587B70", VA = "0x180588970")]
		get
		{
			return default(BgGrave.GraveType);
		}
	}

	[Token(Token = "0x17001C19")]
	public int GraveNo
	{
		[Token(Token = "0x600BCD3")]
		[Address(RVA = "0x3DDD20", Offset = "0x3DCF20", VA = "0x1803DDD20")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17001C1A")]
	public GameObject PosGrave
	{
		[Token(Token = "0x600BCD4")]
		[Address(RVA = "0x5889A0", Offset = "0x587BA0", VA = "0x1805889A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C1B")]
	public GameObject PosExclude
	{
		[Token(Token = "0x600BCD5")]
		[Address(RVA = "0x588980", Offset = "0x587B80", VA = "0x180588980")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600BCD6")]
	[Address(RVA = "0x3DA7A0", Offset = "0x3D99A0", VA = "0x1803DA7A0")]
	public void SetOtherUnit(BgUnit unit)
	{
	}

	[Token(Token = "0x600BCD7")]
	[Address(RVA = "0x5880E0", Offset = "0x5872E0", VA = "0x1805880E0")]
	public BgUnit(Side side)
	{
	}

	[Token(Token = "0x600BCD8")]
	[Address(RVA = "0x584290", Offset = "0x583490", VA = "0x180584290")]
	public void AssignSetting(int matNo, string matSeLabel, int avatarNo, int subAvatarNo, AvatarModelSetting modelSetting, AvatarStandType standType, int standNo, BgGrave.GraveType graveType, int graveNo)
	{
	}

	[Token(Token = "0x600BCD9")]
	[Address(RVA = "0x587BE0", Offset = "0x586DE0", VA = "0x180587BE0")]
	public void SetAvatarNo(int avatarNo, string avatarResPath, int subAvatarNo = 0, string subAvatarResPath = "", string changeEffectPath = "")
	{
	}

	[Token(Token = "0x600BCDA")]
	[Address(RVA = "0x587D20", Offset = "0x586F20", VA = "0x180587D20")]
	public void SetBgNo(int no, string seLabel)
	{
	}

	[Token(Token = "0x600BCDB")]
	[Address(RVA = "0x587C80", Offset = "0x586E80", VA = "0x180587C80")]
	public void SetAvatarStandTypeAndNo(AvatarStandType type, int no)
	{
	}

	[Token(Token = "0x600BCDC")]
	[Address(RVA = "0x587DD0", Offset = "0x586FD0", VA = "0x180587DD0")]
	public void SetGraveTypeAndNo(BgGrave.GraveType type, int no)
	{
	}

	[Token(Token = "0x600BCDD")]
	[Address(RVA = "0x5857C0", Offset = "0x5849C0", VA = "0x1805857C0")]
	public string GetGraveTypeInital()
	{
		return null;
	}

	[Token(Token = "0x600BCDE")]
	[Address(RVA = "0x587E30", Offset = "0x587030", VA = "0x180587E30")]
	public void SetObjectTapCallback(Action callback)
	{
	}

	[Token(Token = "0x600BCDF")]
	[Address(RVA = "0x586620", Offset = "0x585820", VA = "0x180586620")]
	public void Load(Action onLoad)
	{
	}

	[Token(Token = "0x600BCE0")]
	[Address(RVA = "0x5889D0", Offset = "0x587BD0", VA = "0x1805889D0")]
	private void load(BgResourceIdx idx, Action onLoad)
	{
	}

	[Token(Token = "0x600BCE1")]
	[Address(RVA = "0x5863E0", Offset = "0x5855E0", VA = "0x1805863E0")]
	public void Initialize(Transform root)
	{
	}

	[Token(Token = "0x600BCE2")]
	[Address(RVA = "0x585CA0", Offset = "0x584EA0", VA = "0x180585CA0")]
	public void InitializeMat(Transform root, int createLayer = 0)
	{
	}

	[Token(Token = "0x600BCE3")]
	[Address(RVA = "0x585B10", Offset = "0x584D10", VA = "0x180585B10")]
	public void InitializeGrave(int createLayer = 0)
	{
	}

	[Token(Token = "0x600BCE4")]
	[Address(RVA = "0x5861E0", Offset = "0x5853E0", VA = "0x1805861E0")]
	public void InitializeOtherSideEffectManager()
	{
	}

	[Token(Token = "0x600BCE5")]
	[Address(RVA = "0x585A30", Offset = "0x584C30", VA = "0x180585A30")]
	public void InitializeAvatar(int createLayer = 0)
	{
	}

	[Token(Token = "0x600BCE6")]
	[Address(RVA = "0x5845C0", Offset = "0x5837C0", VA = "0x1805845C0")]
	public void BgResourceUnload()
	{
	}

	[Token(Token = "0x600BCE7")]
	[Address(RVA = "0x584880", Offset = "0x583A80", VA = "0x180584880")]
	private void CharaModelInit(int createLayer = 0)
	{
	}

	[Token(Token = "0x600BCE8")]
	[Address(RVA = "0x5846D0", Offset = "0x5838D0", VA = "0x1805846D0")]
	private void CharaModelDestroy()
	{
	}

	[Token(Token = "0x600BCE9")]
	[Address(RVA = "0x585A50", Offset = "0x584C50", VA = "0x180585A50")]
	public void InitializeCharaModelSelector()
	{
	}

	[Token(Token = "0x600BCEA")]
	[Address(RVA = "0x587E50", Offset = "0x587050", VA = "0x180587E50")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600BCEB")]
	[Address(RVA = "0x586C10", Offset = "0x585E10", VA = "0x180586C10")]
	public void PlayBgStartAnimation(BgEffectSettingInner.TriggerLabelDefine trigger = BgEffectSettingInner.TriggerLabelDefine.StartToPhase1)
	{
	}

	[Token(Token = "0x600BCEC")]
	[Address(RVA = "0x586CB0", Offset = "0x585EB0", VA = "0x180586CB0")]
	public void PlayCharaEntryAnimation()
	{
	}

	[Token(Token = "0x600BCED")]
	[Address(RVA = "0x587400", Offset = "0x586600", VA = "0x180587400")]
	public void PlayFinishAnimation()
	{
	}

	[Token(Token = "0x600BCEE")]
	[Address(RVA = "0x587A90", Offset = "0x586C90", VA = "0x180587A90")]
	public void PlayWinAnimation([Optional] Action callback)
	{
	}

	[Token(Token = "0x600BCEF")]
	[Address(RVA = "0x587550", Offset = "0x586750", VA = "0x180587550")]
	public void PlayLoseAnimation([Optional] Action callback)
	{
	}

	[Token(Token = "0x600BCF0")]
	[Address(RVA = "0x587390", Offset = "0x586590", VA = "0x180587390")]
	public void PlayEndWinAnimation()
	{
	}

	[Token(Token = "0x600BCF1")]
	[Address(RVA = "0x587320", Offset = "0x586520", VA = "0x180587320")]
	public void PlayEndLoseAnimation()
	{
	}

	[Token(Token = "0x600BCF2")]
	[Address(RVA = "0x587300", Offset = "0x586500", VA = "0x180587300")]
	public void PlayEndAnimation(ResultType resultType)
	{
	}

	[Token(Token = "0x600BCF3")]
	[Address(RVA = "0x5879F0", Offset = "0x586BF0", VA = "0x1805879F0")]
	public void PlayTurnChangeAnimation()
	{
	}

	[Token(Token = "0x600BCF4")]
	[Address(RVA = "0x586D90", Offset = "0x585F90", VA = "0x180586D90")]
	public void PlayDamageAnimation(Engine.DamageType type, int lp)
	{
	}

	[Token(Token = "0x600BCF5")]
	[Address(RVA = "0x5868A0", Offset = "0x585AA0", VA = "0x1805868A0")]
	public void PlayAttackAnimation()
	{
	}

	[Token(Token = "0x600BCF6")]
	[Address(RVA = "0x5870D0", Offset = "0x5862D0", VA = "0x1805870D0")]
	public void PlayDirectAttack()
	{
	}

	[Token(Token = "0x600BCF7")]
	[Address(RVA = "0x587770", Offset = "0x586970", VA = "0x180587770")]
	public void PlayPhaseChangeAnimation(bool flg)
	{
	}

	[Token(Token = "0x600BCF8")]
	[Address(RVA = "0x5869F0", Offset = "0x585BF0", VA = "0x1805869F0")]
	public void PlayAvatarChangeAnimation(Character.SubAvatarChange condition, bool flg, [Optional] Action callback, AvatarMotionSetting.MotionID motionId = AvatarMotionSetting.MotionID.CHANGE)
	{
	}

	[Token(Token = "0x600BCF9")]
	[Address(RVA = "0x586A20", Offset = "0x585C20", VA = "0x180586A20")]
	public void PlayAvatarChangeAnimation(Character.SubAvatarChange condition, bool flg, AvatarMotionSetting.MotionID motionId1, AvatarMotionSetting.MotionID motionId2, [Optional] Action callback)
	{
	}

	[Token(Token = "0x600BCFA")]
	[Address(RVA = "0x586940", Offset = "0x585B40", VA = "0x180586940")]
	[IteratorStateMachine(typeof(_003CPlayAvatarChangeAnimationInner_003Ed__108))]
	private IEnumerator PlayAvatarChangeAnimationInner(Character.SubAvatarChange condition, AvatarMotionSetting.MotionID motionId1, AvatarMotionSetting.MotionID motionId2, [Optional] Action callback)
	{
		return null;
	}

	[Token(Token = "0x600BCFB")]
	[Address(RVA = "0x587270", Offset = "0x586470", VA = "0x180587270")]
	[IteratorStateMachine(typeof(_003CPlayEffectDelay_003Ed__109))]
	private IEnumerator PlayEffectDelay()
	{
		return null;
	}

	[Token(Token = "0x600BCFC")]
	[Address(RVA = "0x585750", Offset = "0x584950", VA = "0x180585750")]
	public bool CheckSubAvatarCondition(Character.SubAvatarChange condition)
	{
		return default(bool);
	}

	[Token(Token = "0x600BCFD")]
	[Address(RVA = "0x585610", Offset = "0x584810", VA = "0x180585610")]
	public bool CheckSubAvatarConditionParam(Character.SubAvatarChange condition, int target)
	{
		return default(bool);
	}

	[Token(Token = "0x600BCFE")]
	[Address(RVA = "0x5857B0", Offset = "0x5849B0", VA = "0x1805857B0")]
	public Character GetActiveCharacter()
	{
		return null;
	}

	[Token(Token = "0x600BCFF")]
	[Address(RVA = "0x586570", Offset = "0x585770", VA = "0x180586570")]
	public bool IsSubAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD00")]
	[Address(RVA = "0x586720", Offset = "0x585920", VA = "0x180586720")]
	public void MateEnable(bool flg)
	{
	}

	[Token(Token = "0x600BD01")]
	[Address(RVA = "0x5876A0", Offset = "0x5868A0", VA = "0x1805876A0")]
	public void PlayMatTapAnimation()
	{
	}

	[Token(Token = "0x600BD02")]
	[Address(RVA = "0x586550", Offset = "0x585750", VA = "0x180586550")]
	public bool IsMatTapPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600BD03")]
	[Address(RVA = "0x5867E0", Offset = "0x5859E0", VA = "0x1805867E0")]
	public void OnObjectTapCallback()
	{
	}

	[Token(Token = "0x600BD04")]
	[Address(RVA = "0x585230", Offset = "0x584430", VA = "0x180585230")]
	public void CheckDamagePhase(int lp, [Optional] BgEffectManagerInner.CheckDamageCallback cb)
	{
	}

	[Token(Token = "0x600BD05")]
	[Address(RVA = "0x5850B0", Offset = "0x5842B0", VA = "0x1805850B0")]
	public void CheckDamagePhaseForAudienceReplay(int lp, int initLp)
	{
	}

	[Token(Token = "0x600BD06")]
	[Address(RVA = "0x584550", Offset = "0x583750", VA = "0x180584550")]
	[IteratorStateMachine(typeof(_003CAudienceReplayEnd_003Ed__120))]
	private IEnumerator AudienceReplayEnd()
	{
		return null;
	}

	[Token(Token = "0x600BD07")]
	[Address(RVA = "0x5872E0", Offset = "0x5864E0", VA = "0x1805872E0")]
	public void PlayEffect(BgEffectSettingInner.AnimationLabelDefine label)
	{
	}

	[Token(Token = "0x600BD08")]
	[Address(RVA = "0x587DB0", Offset = "0x586FB0", VA = "0x180587DB0")]
	public void SetEnableTapEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
	{
	}

	[Token(Token = "0x600BD09")]
	[Address(RVA = "0x587D90", Offset = "0x586F90", VA = "0x180587D90")]
	public void SetEnableLoopEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
	{
	}

	[Token(Token = "0x600BD0A")]
	[Address(RVA = "0x586880", Offset = "0x585A80", VA = "0x180586880")]
	public void PlayAnimatorTrigger(BgEffectSettingInner.TriggerLabelDefine label, string seLabel = "")
	{
	}

	[Token(Token = "0x600BD0B")]
	[Address(RVA = "0x5876C0", Offset = "0x5868C0", VA = "0x1805876C0")]
	public void PlayOtherSideAnimatorTrigger(BgEffectSettingInner.TriggerLabelDefine label, string seLabel = "")
	{
	}

	[Token(Token = "0x600BD0C")]
	[Address(RVA = "0x586F80", Offset = "0x586180", VA = "0x180586F80")]
	public void PlayDamagePhaseTrigger(BgEffectSettingInner.TriggerLabelDefine label, string seLabel = "")
	{
	}

	[Token(Token = "0x600BD0D")]
	[Address(RVA = "0x585830", Offset = "0x584A30", VA = "0x180585830")]
	public string GetMatSeLabel(BgPhase phase)
	{
		return null;
	}

	[Token(Token = "0x600BD0E")]
	[Address(RVA = "0x585910", Offset = "0x584B10", VA = "0x180585910")]
	public string GetMatTapSeLabel()
	{
		return null;
	}

	[Token(Token = "0x600BD0F")]
	[Address(RVA = "0x587890", Offset = "0x586A90", VA = "0x180587890")]
	public static void PlayStartAnimationForPreviewParts(GameObject obj)
	{
	}

	[Token(Token = "0x600BD10")]
	[Address(RVA = "0x586780", Offset = "0x585980", VA = "0x180586780")]
	public void OnCursorEnterGrave()
	{
	}

	[Token(Token = "0x600BD11")]
	[Address(RVA = "0x5867C0", Offset = "0x5859C0", VA = "0x1805867C0")]
	public void OnCursorExitGrave()
	{
	}

	[Token(Token = "0x600BD12")]
	[Address(RVA = "0x586820", Offset = "0x585A20", VA = "0x180586820")]
	public void OnSelectPressedGrave()
	{
	}

	[Token(Token = "0x600BD13")]
	[Address(RVA = "0x586860", Offset = "0x585A60", VA = "0x180586860")]
	public void OnSelectReleasedGrave()
	{
	}

	[Token(Token = "0x600BD14")]
	[Address(RVA = "0x586760", Offset = "0x585960", VA = "0x180586760")]
	public void OnCursorEnterExclude()
	{
	}

	[Token(Token = "0x600BD15")]
	[Address(RVA = "0x5867A0", Offset = "0x5859A0", VA = "0x1805867A0")]
	public void OnCursorExitExclude()
	{
	}

	[Token(Token = "0x600BD16")]
	[Address(RVA = "0x586800", Offset = "0x585A00", VA = "0x180586800")]
	public void OnSelectPressedExclude()
	{
	}

	[Token(Token = "0x600BD17")]
	[Address(RVA = "0x586840", Offset = "0x585A40", VA = "0x180586840")]
	public void OnSelectReleasedExclude()
	{
	}

	[Token(Token = "0x600BD18")]
	[Address(RVA = "0x587CE0", Offset = "0x586EE0", VA = "0x180587CE0")]
	public void SetBgGraveHighlight(bool flg)
	{
	}

	[Token(Token = "0x600BD19")]
	[Address(RVA = "0x587D00", Offset = "0x586F00", VA = "0x180587D00")]
	public void SetBgGrave(int player, int position, bool cardIn)
	{
	}
}
