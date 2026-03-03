using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;
using YgomSystem.Utility;

namespace YgomGame.Bg;

[Token(Token = "0x2001D3D")]
public class BgEffectSettingInner : ElementObject
{
	[Token(Token = "0x2001D3E")]
	public enum AnimationLabelDefine
	{
		[Token(Token = "0x4010292")]
		None,
		[Token(Token = "0x4010293")]
		Start,
		[Token(Token = "0x4010294")]
		LoopPhase1,
		[Token(Token = "0x4010295")]
		LoopPhase2,
		[Token(Token = "0x4010296")]
		LoopPhase3,
		[Token(Token = "0x4010297")]
		LoopPhase4,
		[Token(Token = "0x4010298")]
		LoopAll,
		[Token(Token = "0x4010299")]
		DamagePhase1,
		[Token(Token = "0x401029A")]
		DamagePhase2,
		[Token(Token = "0x401029B")]
		DamagePhase3,
		[Token(Token = "0x401029C")]
		DamagePhase4,
		[Token(Token = "0x401029D")]
		DamagePhaseAll,
		[Token(Token = "0x401029E")]
		ToPhase2,
		[Token(Token = "0x401029F")]
		ToPhase3,
		[Token(Token = "0x40102A0")]
		ToPhase4,
		[Token(Token = "0x40102A1")]
		ToEnd,
		[Token(Token = "0x40102A2")]
		ToPhaseAll,
		[Token(Token = "0x40102A3")]
		End,
		[Token(Token = "0x40102A4")]
		EndWin,
		[Token(Token = "0x40102A5")]
		EndLose,
		[Token(Token = "0x40102A6")]
		TapPhase1,
		[Token(Token = "0x40102A7")]
		TapPhase2,
		[Token(Token = "0x40102A8")]
		TapPhase3,
		[Token(Token = "0x40102A9")]
		TapPhase4,
		[Token(Token = "0x40102AA")]
		TapAll,
		[Token(Token = "0x40102AB")]
		KeepPhaseAll,
		[Token(Token = "0x40102AC")]
		DefineMax
	}

	[Token(Token = "0x2001D3F")]
	public enum TriggerLabelDefine
	{
		[Token(Token = "0x40102AE")]
		None,
		[Token(Token = "0x40102AF")]
		StartToPhase1,
		[Token(Token = "0x40102B0")]
		Phase1ToDamagePhase1,
		[Token(Token = "0x40102B1")]
		DamagePhase1ToPhase1,
		[Token(Token = "0x40102B2")]
		DamagePhase1ToPhase2,
		[Token(Token = "0x40102B3")]
		Phase2ToDamagePhase2,
		[Token(Token = "0x40102B4")]
		DamagePhase2ToPhase2,
		[Token(Token = "0x40102B5")]
		DamagePhase2ToPhase3,
		[Token(Token = "0x40102B6")]
		Phase3ToDamagePhase3,
		[Token(Token = "0x40102B7")]
		DamagePhase3ToPhase3,
		[Token(Token = "0x40102B8")]
		DamagePhase3ToPhase4,
		[Token(Token = "0x40102B9")]
		Phase4ToDamagePhase4,
		[Token(Token = "0x40102BA")]
		DamagePhase4ToPhase4,
		[Token(Token = "0x40102BB")]
		DamagePhase4ToEnd,
		[Token(Token = "0x40102BC")]
		PhaseToDamagePhaseAll,
		[Token(Token = "0x40102BD")]
		DamagePhaseToPhaseAll,
		[Token(Token = "0x40102BE")]
		DamagePhaseToNextPhaseAll,
		[Token(Token = "0x40102BF")]
		EndWin,
		[Token(Token = "0x40102C0")]
		EndLose,
		[Token(Token = "0x40102C1")]
		TapPhase1,
		[Token(Token = "0x40102C2")]
		TapPhase2,
		[Token(Token = "0x40102C3")]
		TapPhase3,
		[Token(Token = "0x40102C4")]
		TapPhase4,
		[Token(Token = "0x40102C5")]
		TapAll,
		[Token(Token = "0x40102C6")]
		OtherSidePhase1ToDamagePhase1,
		[Token(Token = "0x40102C7")]
		OtherSideDamagePhase1ToPhase1,
		[Token(Token = "0x40102C8")]
		OtherSideDamagePhase1ToPhase2,
		[Token(Token = "0x40102C9")]
		OtherSidePhase2ToDamagePhase2,
		[Token(Token = "0x40102CA")]
		OtherSideDamagePhase2ToPhase2,
		[Token(Token = "0x40102CB")]
		OtherSideDamagePhase2ToPhase3,
		[Token(Token = "0x40102CC")]
		OtherSidePhase3ToDamagePhase3,
		[Token(Token = "0x40102CD")]
		OtherSideDamagePhase3ToPhase3,
		[Token(Token = "0x40102CE")]
		OtherSideDamagePhase3ToPhase4,
		[Token(Token = "0x40102CF")]
		OtherSidePhase4ToDamagePhase4,
		[Token(Token = "0x40102D0")]
		OtherSideDamagePhase4ToPhase4,
		[Token(Token = "0x40102D1")]
		OtherSideDamagePhase4ToEnd,
		[Token(Token = "0x40102D2")]
		OtherSidePhaseToDamagePhaseAll,
		[Token(Token = "0x40102D3")]
		OtherSideDamagePhaseToPhaseAll,
		[Token(Token = "0x40102D4")]
		OtherSideDamagePhaseToNextPhaseAll,
		[Token(Token = "0x40102D5")]
		StartToPhase1Extra
	}

	[Token(Token = "0x2001D40")]
	[CompilerGenerated]
	private sealed class _003CCheckActiveTime_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40102D6")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40102D7")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40102D8")]
		[FieldOffset(Offset = "0x20")]
		public BgEffectSettingInner _003C_003E4__this;

		[Token(Token = "0x40102D9")]
		[FieldOffset(Offset = "0x28")]
		private float _003CcheckTime_003E5__2;

		[Token(Token = "0x17001BF9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BBDC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BFA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BBDE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BBD9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckActiveTime_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BBDA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BBDB")]
		[Address(RVA = "0x57A770", Offset = "0x579970", VA = "0x18057A770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BBDD")]
		[Address(RVA = "0x57A850", Offset = "0x579A50", VA = "0x18057A850", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D41")]
	[CompilerGenerated]
	private sealed class _003CCheckParticleEffectEnd_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40102DA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40102DB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40102DC")]
		[FieldOffset(Offset = "0x20")]
		public BgEffectSettingInner _003C_003E4__this;

		[Token(Token = "0x17001BFB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BBE2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BFC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BBE4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BBDF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckParticleEffectEnd_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BBE0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BBE1")]
		[Address(RVA = "0x57A890", Offset = "0x579A90", VA = "0x18057A890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BBE3")]
		[Address(RVA = "0x57A940", Offset = "0x579B40", VA = "0x18057A940", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001D42")]
	[CompilerGenerated]
	private sealed class _003CCheckTapAnimationEnd_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40102DD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40102DE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40102DF")]
		[FieldOffset(Offset = "0x20")]
		public BgEffectSettingInner _003C_003E4__this;

		[Token(Token = "0x40102E0")]
		[FieldOffset(Offset = "0x28")]
		private int _003Cidx_003E5__2;

		[Token(Token = "0x40102E1")]
		[FieldOffset(Offset = "0x2C")]
		private AnimatorStateInfo _003Cstart_003E5__3;

		[Token(Token = "0x40102E2")]
		[FieldOffset(Offset = "0x50")]
		private float _003Cwait_003E5__4;

		[Token(Token = "0x17001BFD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BBE8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BFE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BBEA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BBE5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCheckTapAnimationEnd_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BBE6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BBE7")]
		[Address(RVA = "0x57A980", Offset = "0x579B80", VA = "0x18057A980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BBE9")]
		[Address(RVA = "0x57ABE0", Offset = "0x579DE0", VA = "0x18057ABE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4010278")]
	[FieldOffset(Offset = "0x60")]
	public float delay;

	[Token(Token = "0x4010279")]
	[FieldOffset(Offset = "0x64")]
	public float activeTime;

	[Token(Token = "0x401027A")]
	[FieldOffset(Offset = "0x68")]
	public AnimationLabelDefine animationLabel;

	[Token(Token = "0x401027B")]
	[FieldOffset(Offset = "0x6C")]
	public bool playingOnlyActive;

	[Token(Token = "0x401027C")]
	[FieldOffset(Offset = "0x70")]
	public Vector3 tapSize;

	[Token(Token = "0x401027D")]
	[FieldOffset(Offset = "0x7C")]
	public Vector3 tapOffset;

	[Token(Token = "0x401027E")]
	[FieldOffset(Offset = "0x88")]
	public bool otherSide;

	[Token(Token = "0x401027F")]
	[FieldOffset(Offset = "0x89")]
	public bool isRootAnimator;

	[Token(Token = "0x4010280")]
	[FieldOffset(Offset = "0x8C")]
	public float endDelay;

	[Token(Token = "0x4010281")]
	[FieldOffset(Offset = "0x90")]
	public bool disableLowEndPlatform;

	[Token(Token = "0x4010282")]
	[FieldOffset(Offset = "0x91")]
	public bool enableLowEndPlatformOnly;

	[Token(Token = "0x4010283")]
	[FieldOffset(Offset = "0x92")]
	public bool disableAudienceReplay;

	[Token(Token = "0x4010284")]
	[FieldOffset(Offset = "0x93")]
	public bool initialized;

	[Token(Token = "0x4010285")]
	[FieldOffset(Offset = "0x98")]
	public string exclusiveSeLabel;

	[Token(Token = "0x4010286")]
	[FieldOffset(Offset = "0xA0")]
	public bool syncAnimatorEnableTap;

	[Token(Token = "0x4010287")]
	[FieldOffset(Offset = "0xA8")]
	public BgEffectManagerInner manager;

	[Token(Token = "0x4010288")]
	[FieldOffset(Offset = "0xB0")]
	public ParticleSystem particle;

	[Token(Token = "0x4010289")]
	[FieldOffset(Offset = "0xB8")]
	public Animator animator;

	[Token(Token = "0x401028A")]
	[FieldOffset(Offset = "0xC0")]
	private MonoBehaviour monoBehaviour;

	[Token(Token = "0x401028B")]
	[FieldOffset(Offset = "0xC8")]
	private Coroutine CheckactiveTime;

	[Token(Token = "0x401028C")]
	[FieldOffset(Offset = "0xD0")]
	private bool enableTap;

	[Token(Token = "0x401028D")]
	[FieldOffset(Offset = "0xD1")]
	private bool tapPlaying;

	[Token(Token = "0x401028E")]
	[FieldOffset(Offset = "0xD2")]
	private bool enableLoop;

	[Token(Token = "0x401028F")]
	[FieldOffset(Offset = "0xD8")]
	private List<string> animatorParams;

	[Token(Token = "0x4010290")]
	[FieldOffset(Offset = "0xE0")]
	private List<string> playedAnimationEventLabelList;

	[Token(Token = "0x600BBC8")]
	[Address(RVA = "0x5661F0", Offset = "0x5653F0", VA = "0x1805661F0")]
	private void OnValidate()
	{
	}

	[Token(Token = "0x600BBC9")]
	[Address(RVA = "0x565B50", Offset = "0x564D50", VA = "0x180565B50")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BBCA")]
	[Address(RVA = "0x567080", Offset = "0x566280", VA = "0x180567080")]
	public void SetBgEffectManager(BgEffectManagerInner mng)
	{
	}

	[Token(Token = "0x600BBCB")]
	[Address(RVA = "0x566930", Offset = "0x565B30", VA = "0x180566930")]
	public void PlayEffect(TriggerLabelDefine triggerLabel, bool isAudienceReplay = false)
	{
	}

	[Token(Token = "0x600BBCC")]
	[Address(RVA = "0x49C230", Offset = "0x49B430", VA = "0x18049C230")]
	public void SetEnableLoop(bool flg)
	{
	}

	[Token(Token = "0x600BBCD")]
	[Address(RVA = "0x566CC0", Offset = "0x565EC0", VA = "0x180566CC0")]
	public void PlayLoopEffect(bool isAudienceReplay = false)
	{
	}

	[Token(Token = "0x600BBCE")]
	[Address(RVA = "0x567140", Offset = "0x566340", VA = "0x180567140")]
	public void SetEnableTap(bool flg)
	{
	}

	[Token(Token = "0x600BBCF")]
	[Address(RVA = "0x566E30", Offset = "0x566030", VA = "0x180566E30")]
	public void PlayTapEffect()
	{
	}

	[Token(Token = "0x600BBD0")]
	[Address(RVA = "0x49BB40", Offset = "0x49AD40", VA = "0x18049BB40")]
	public bool IsTapPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600BBD1")]
	[Address(RVA = "0x566140", Offset = "0x565340", VA = "0x180566140")]
	[IteratorStateMachine(typeof(_003CCheckTapAnimationEnd_003Ed__36))]
	private IEnumerator CheckTapAnimationEnd()
	{
		return null;
	}

	[Token(Token = "0x600BBD2")]
	[Address(RVA = "0x5660D0", Offset = "0x5652D0", VA = "0x1805660D0")]
	[IteratorStateMachine(typeof(_003CCheckParticleEffectEnd_003Ed__37))]
	private IEnumerator CheckParticleEffectEnd()
	{
		return null;
	}

	[Token(Token = "0x600BBD3")]
	[Address(RVA = "0x566060", Offset = "0x565260", VA = "0x180566060")]
	[IteratorStateMachine(typeof(_003CCheckActiveTime_003Ed__38))]
	private IEnumerator CheckActiveTime()
	{
		return null;
	}

	[Token(Token = "0x600BBD4")]
	[Address(RVA = "0x566810", Offset = "0x565A10", VA = "0x180566810")]
	public void PlayAnimatorTrigger(TriggerLabelDefine label)
	{
	}

	[Token(Token = "0x600BBD5")]
	[Address(RVA = "0x5665F0", Offset = "0x5657F0", VA = "0x1805665F0")]
	public void PlayAnimationEvent(string str)
	{
	}

	[Token(Token = "0x600BBD6")]
	[Address(RVA = "0x5661B0", Offset = "0x5653B0", VA = "0x1805661B0")]
	private DeviceInfo.ResourceType GetResourceType()
	{
		return default(DeviceInfo.ResourceType);
	}

	[Token(Token = "0x600BBD7")]
	[Address(RVA = "0x567160", Offset = "0x566360", VA = "0x180567160")]
	public BgEffectSettingInner()
	{
	}
}
