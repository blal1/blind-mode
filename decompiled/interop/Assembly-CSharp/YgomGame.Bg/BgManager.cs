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

[Token(Token = "0x2001D55")]
public class BgManager : MonoBehaviour
{
	[Token(Token = "0x2001D56")]
	private enum Step
	{
		[Token(Token = "0x401036C")]
		InitializingLoad,
		[Token(Token = "0x401036D")]
		InitializingLight,
		[Token(Token = "0x401036E")]
		InitializingSphere,
		[Token(Token = "0x401036F")]
		InitializingMyMat,
		[Token(Token = "0x4010370")]
		InitializingRivalMat,
		[Token(Token = "0x4010371")]
		InitializingMyGrave,
		[Token(Token = "0x4010372")]
		InitializingRivalGrave,
		[Token(Token = "0x4010373")]
		InitializingAvatar,
		[Token(Token = "0x4010374")]
		Idle
	}

	[Token(Token = "0x2001D57")]
	private enum SphereId
	{
		[Token(Token = "0x4010376")]
		NormalSphere = 1,
		[Token(Token = "0x4010377")]
		WCSSphere
	}

	[Token(Token = "0x2001D5B")]
	[CompilerGenerated]
	private sealed class _003CLoadAudioClipCoroutine_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401037E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401037F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17001C09")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BC7E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C0A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BC80")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BC7B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CLoadAudioClipCoroutine_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BC7C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BC7D")]
		[Address(RVA = "0x58FBA0", Offset = "0x58EDA0", VA = "0x18058FBA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BC7F")]
		[Address(RVA = "0x58FD50", Offset = "0x58EF50", VA = "0x18058FD50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D5C")]
	[CompilerGenerated]
	private sealed class _003CSkipWait_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BgManager _003C_003E4__this;

		[Token(Token = "0x17001C0B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BC84")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C0C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BC86")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BC81")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSkipWait_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BC82")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BC83")]
		[Address(RVA = "0x591420", Offset = "0x590620", VA = "0x180591420", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BC85")]
		[Address(RVA = "0x591490", Offset = "0x590690", VA = "0x180591490", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D5D")]
	[CompilerGenerated]
	private sealed class _003CWaitSkip_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public BgManager _003C_003E4__this;

		[Token(Token = "0x17001C0D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BC8A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C0E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BC8C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BC87")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CWaitSkip_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BC88")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BC89")]
		[Address(RVA = "0x594BE0", Offset = "0x593DE0", VA = "0x180594BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BC8B")]
		[Address(RVA = "0x594D30", Offset = "0x593F30", VA = "0x180594D30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x401034D")]
	public const string bgLightResPath = "Duel/BG/Light/GlobalFieldLight";

	[Token(Token = "0x401034E")]
	public const string bgSphereResPath = "Duel/BG/CelestialSphere/CelestialSphere_{0}{1:000}/CelestialSphere_{0}{1:000}";

	[Token(Token = "0x401034F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private Step step;

	[Token(Token = "0x4010350")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private int[] matId;

	[Token(Token = "0x4010351")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private int[] standId;

	[Token(Token = "0x4010352")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private int[] graveId;

	[Token(Token = "0x4010353")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private int[] avatarId;

	[Token(Token = "0x4010354")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private int sphereId;

	[Token(Token = "0x4010355")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private bool useClientworkId;

	[Token(Token = "0x4010356")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4D")]
	private bool bgResLoaded;

	[Token(Token = "0x4010357")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	private GameObject bgLightRes;

	[Token(Token = "0x4010358")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	private GameObject bgLightObj;

	[Token(Token = "0x4010359")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
	private bool bgLightLoaded;

	[Token(Token = "0x401035A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
	private GameObject bgSphereRes;

	[Token(Token = "0x401035B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
	private GameObject bgSphereObj;

	[Token(Token = "0x401035C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
	private bool bgSphereLoaded;

	[Token(Token = "0x401035D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x79")]
	private bool isErrModelSrc;

	[Token(Token = "0x401035E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
	private Animator timerAnimator;

	[Token(Token = "0x401035F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
	private Animator phaseSelectAnimator;

	[Token(Token = "0x4010360")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
	private bool timerAudienceReplayStart;

	[Token(Token = "0x4010361")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x91")]
	private bool phaseSelectAudienceReplayStart;

	[Token(Token = "0x4010362")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x94")]
	private int createLayer;

	[Token(Token = "0x4010363")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
	private BgUnit[] bgUnits;

	[Token(Token = "0x4010364")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
	private BgMatModelSetting matModelSetting;

	[Token(Token = "0x4010365")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
	private BgGraveModelSetting graveModelSetting;

	[Token(Token = "0x4010366")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
	private BgStandModelSetting standModelSetting;

	[Token(Token = "0x4010367")]
	[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
	private AvatarModelSetting characterModelSetting;

	[Token(Token = "0x17001C03")]
	private bool useSphere
	{
		[Token(Token = "0x600BC38")]
		[Address(RVA = "0x56D8A0", Offset = "0x56CAA0", VA = "0x18056D8A0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001C04")]
	public BgMatModelSetting MatModelSetting
	{
		[Token(Token = "0x600BC3B")]
		[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17001C05")]
	public bool isInitialized
	{
		[Token(Token = "0x600BC55")]
		[Address(RVA = "0x56D880", Offset = "0x56CA80", VA = "0x18056D880")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BC56")]
		[Address(RVA = "0x56D8B0", Offset = "0x56CAB0", VA = "0x18056D8B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C06")]
	public bool isTerminated
	{
		[Token(Token = "0x600BC58")]
		[Address(RVA = "0x56D890", Offset = "0x56CA90", VA = "0x18056D890")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600BC59")]
		[Address(RVA = "0x56D8C0", Offset = "0x56CAC0", VA = "0x18056D8C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C07")]
	public DuelGameObjectManager goManager
	{
		[Token(Token = "0x600BC5B")]
		[Address(RVA = "0x49BAD0", Offset = "0x49ACD0", VA = "0x18049BAD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x600BC5C")]
		[Address(RVA = "0x42FF90", Offset = "0x42F190", VA = "0x18042FF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001C08")]
	public bool bgCameraEnabled
	{
		[Token(Token = "0x600BC5D")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600BC39")]
	[Address(RVA = "0x56AA40", Offset = "0x569C40", VA = "0x18056AA40")]
	public BgUnit GetBgUnit(BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BC3A")]
	[Address(RVA = "0x56A9E0", Offset = "0x569BE0", VA = "0x18056A9E0")]
	public BgUnit GetBgUnit(bool isMyself)
	{
		return null;
	}

	[Token(Token = "0x600BC3C")]
	[Address(RVA = "0x56A900", Offset = "0x569B00", VA = "0x18056A900")]
	public static BgManager Create(DuelGameObjectManager goManager, GameObject root, string name, bool useCwId = true)
	{
		return null;
	}

	[Token(Token = "0x600BC3D")]
	[Address(RVA = "0x56A800", Offset = "0x569A00", VA = "0x18056A800")]
	public static BgManager Create(Transform root, string name, int sphereId, params int[] ids)
	{
		return null;
	}

	[Token(Token = "0x600BC3E")]
	[Address(RVA = "0x56A730", Offset = "0x569930", VA = "0x18056A730")]
	private static BgManager Create(Transform root, string name, bool useCwId, int sphereId = 1)
	{
		return null;
	}

	[Token(Token = "0x600BC3F")]
	[Address(RVA = "0x56B550", Offset = "0x56A750", VA = "0x18056B550")]
	public void Initialize()
	{
	}

	[Token(Token = "0x600BC40")]
	[Address(RVA = "0x56AAF0", Offset = "0x569CF0", VA = "0x18056AAF0")]
	public void InitalizeLoad()
	{
	}

	[Token(Token = "0x600BC41")]
	[Address(RVA = "0x56BB90", Offset = "0x56AD90", VA = "0x18056BB90")]
	[IteratorStateMachine(typeof(_003CLoadAudioClipCoroutine_003Ed__40))]
	private IEnumerator LoadAudioClipCoroutine()
	{
		return null;
	}

	[Token(Token = "0x600BC42")]
	[Address(RVA = "0x56CC00", Offset = "0x56BE00", VA = "0x18056CC00")]
	public void SetLight(bool flag)
	{
	}

	[Token(Token = "0x600BC43")]
	[Address(RVA = "0x56AA90", Offset = "0x569C90", VA = "0x18056AA90")]
	public BgEffectSettingInner.TriggerLabelDefine GetStartToPhase1Trigger()
	{
		return default(BgEffectSettingInner.TriggerLabelDefine);
	}

	[Token(Token = "0x600BC44")]
	[Address(RVA = "0x56BF80", Offset = "0x56B180", VA = "0x18056BF80")]
	public void PlayCameraStartAnimation()
	{
	}

	[Token(Token = "0x600BC45")]
	[Address(RVA = "0x56BE10", Offset = "0x56B010", VA = "0x18056BE10")]
	public void PlayCameraStartAnimationTimer(BgEffectSettingInner.TriggerLabelDefine startTrigger, [Optional] GameObject timer)
	{
	}

	[Token(Token = "0x600BC46")]
	[Address(RVA = "0x56BC90", Offset = "0x56AE90", VA = "0x18056BC90")]
	public void PlayCameraStartAnimationPhaseSelect(BgEffectSettingInner.TriggerLabelDefine startTrigger, [Optional] GameObject phaseSelect)
	{
	}

	[Token(Token = "0x600BC47")]
	[Address(RVA = "0x56CC90", Offset = "0x56BE90", VA = "0x18056CC90")]
	public void SkipObjectStartAnimation()
	{
	}

	[Token(Token = "0x600BC48")]
	[Address(RVA = "0x56CEB0", Offset = "0x56C0B0", VA = "0x18056CEB0")]
	[IteratorStateMachine(typeof(_003CSkipWait_003Ed__47))]
	private IEnumerator SkipWait()
	{
		return null;
	}

	[Token(Token = "0x600BC49")]
	[Address(RVA = "0x56A560", Offset = "0x569760", VA = "0x18056A560")]
	private void CheckStartAnimation()
	{
	}

	[Token(Token = "0x600BC4A")]
	[Address(RVA = "0x56D720", Offset = "0x56C920", VA = "0x18056D720")]
	[IteratorStateMachine(typeof(_003CWaitSkip_003Ed__49))]
	private IEnumerator WaitSkip()
	{
		return null;
	}

	[Token(Token = "0x600BC4B")]
	[Address(RVA = "0x56C580", Offset = "0x56B780", VA = "0x18056C580")]
	public void PlayEntryAnimation()
	{
	}

	[Token(Token = "0x600BC4C")]
	[Address(RVA = "0x56C2F0", Offset = "0x56B4F0", VA = "0x18056C2F0")]
	public void PlayDamageAnimation(Engine.DamageType type, int team, int damage)
	{
	}

	[Token(Token = "0x600BC4D")]
	[Address(RVA = "0x56C450", Offset = "0x56B650", VA = "0x18056C450")]
	public void PlayDirectAttackAnimation(int player)
	{
	}

	[Token(Token = "0x600BC4E")]
	[Address(RVA = "0x56C5F0", Offset = "0x56B7F0", VA = "0x18056C5F0")]
	public void PlayFinishAnimation(int team)
	{
	}

	[Token(Token = "0x600BC4F")]
	[Address(RVA = "0x56C900", Offset = "0x56BB00", VA = "0x18056C900")]
	public void PlayWinAnimation(int team)
	{
	}

	[Token(Token = "0x600BC50")]
	[Address(RVA = "0x56C690", Offset = "0x56B890", VA = "0x18056C690")]
	public void PlayLoseAnimation(int team)
	{
	}

	[Token(Token = "0x600BC51")]
	[Address(RVA = "0x56C4F0", Offset = "0x56B6F0", VA = "0x18056C4F0")]
	public void PlayEndAnimation(Engine.ResultType engineResultType)
	{
	}

	[Token(Token = "0x600BC52")]
	[Address(RVA = "0x56C890", Offset = "0x56BA90", VA = "0x18056C890")]
	public void PlayTurnChangeAnimation()
	{
	}

	[Token(Token = "0x600BC53")]
	[Address(RVA = "0x56C4A0", Offset = "0x56B6A0", VA = "0x18056C4A0")]
	public void PlayEffect(int side, BgEffectSettingInner.AnimationLabelDefine label)
	{
	}

	[Token(Token = "0x600BC54")]
	[Address(RVA = "0x56BBE0", Offset = "0x56ADE0", VA = "0x18056BBE0")]
	public void ObjectTapCallback()
	{
	}

	[Token(Token = "0x600BC57")]
	[Address(RVA = "0x56CF20", Offset = "0x56C120", VA = "0x18056CF20")]
	public void Terminate()
	{
	}

	[Token(Token = "0x600BC5A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public void Inactivate()
	{
	}

	[Token(Token = "0x600BC5E")]
	[Address(RVA = "0x56D2C0", Offset = "0x56C4C0", VA = "0x18056D2C0")]
	private void Update()
	{
	}

	[Token(Token = "0x600BC5F")]
	[Address(RVA = "0x56B830", Offset = "0x56AA30", VA = "0x18056B830")]
	private void InitializingLightStep()
	{
	}

	[Token(Token = "0x600BC60")]
	[Address(RVA = "0x56BA90", Offset = "0x56AC90", VA = "0x18056BA90")]
	private void InitializingSphereStep()
	{
	}

	[Token(Token = "0x600BC61")]
	[Address(RVA = "0x56B960", Offset = "0x56AB60", VA = "0x18056B960")]
	private void InitializingMyMatStep()
	{
	}

	[Token(Token = "0x600BC62")]
	[Address(RVA = "0x56BA20", Offset = "0x56AC20", VA = "0x18056BA20")]
	private void InitializingRivalMatStep()
	{
	}

	[Token(Token = "0x600BC63")]
	[Address(RVA = "0x56B910", Offset = "0x56AB10", VA = "0x18056B910")]
	private void InitializingMyGraveStep()
	{
	}

	[Token(Token = "0x600BC64")]
	[Address(RVA = "0x56B9D0", Offset = "0x56ABD0", VA = "0x18056B9D0")]
	private void InitializingRivalGraveStep()
	{
	}

	[Token(Token = "0x600BC65")]
	[Address(RVA = "0x56B760", Offset = "0x56A960", VA = "0x18056B760")]
	private void InitializingAvatarStep()
	{
	}

	[Token(Token = "0x600BC66")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void IdleStep()
	{
	}

	[Token(Token = "0x600BC67")]
	[Address(RVA = "0x56B450", Offset = "0x56A650", VA = "0x18056B450")]
	public void InitializeSelector()
	{
	}

	[Token(Token = "0x600BC68")]
	[Address(RVA = "0x56CBB0", Offset = "0x56BDB0", VA = "0x18056CBB0")]
	public void SetBgGraveHighlight(bool flg)
	{
	}

	[Token(Token = "0x600BC69")]
	[Address(RVA = "0x56CBF0", Offset = "0x56BDF0", VA = "0x18056CBF0")]
	public void SetCreateLayer(int layer)
	{
	}

	[Token(Token = "0x600BC6A")]
	[Address(RVA = "0x56CA60", Offset = "0x56BC60", VA = "0x18056CA60")]
	public void ReloadSphere(int id)
	{
	}

	[Token(Token = "0x600BC6B")]
	[Address(RVA = "0x56D790", Offset = "0x56C990", VA = "0x18056D790")]
	public BgManager()
	{
	}
}
