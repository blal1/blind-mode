using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.ElementSystem;

namespace YgomGame.Bg;

[Token(Token = "0x2001D33")]
public class BgEffectManagerInner : ElementObjectManager
{
	[Token(Token = "0x2001D34")]
	public class BgEffectRequest
	{
		[Token(Token = "0x4010261")]
		[FieldOffset(Offset = "0x10")]
		public BgEffectSettingInner setting;

		[Token(Token = "0x4010262")]
		[FieldOffset(Offset = "0x18")]
		public float time;

		[Token(Token = "0x4010263")]
		[FieldOffset(Offset = "0x1C")]
		public BgEffectSettingInner.AnimationLabelDefine animationLabel;

		[Token(Token = "0x4010264")]
		[FieldOffset(Offset = "0x20")]
		public BgEffectSettingInner.TriggerLabelDefine trigerLabel;

		[Token(Token = "0x4010265")]
		[FieldOffset(Offset = "0x24")]
		public bool isAudienceReplay;

		[Token(Token = "0x600BBB5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BgEffectRequest()
		{
		}
	}

	[Token(Token = "0x2001D35")]
	public class BgPhaseChangeSeRequest
	{
		[Token(Token = "0x4010266")]
		[FieldOffset(Offset = "0x10")]
		public BgEffectSettingInner.TriggerLabelDefine trigerLabel;

		[Token(Token = "0x4010267")]
		[FieldOffset(Offset = "0x18")]
		public string seLabel;

		[Token(Token = "0x600BBB6")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BgPhaseChangeSeRequest()
		{
		}
	}

	[Token(Token = "0x2001D36")]
	public class BgAnimationEventParam
	{
		[Token(Token = "0x4010268")]
		[FieldOffset(Offset = "0x10")]
		public BgEffectSettingInner.TriggerLabelDefine trigger;

		[Token(Token = "0x4010269")]
		[FieldOffset(Offset = "0x14")]
		public BgEffectSettingInner.AnimationLabelDefine animationLabel;

		[Token(Token = "0x600BBB7")]
		[Address(RVA = "0x55DEE0", Offset = "0x55D0E0", VA = "0x18055DEE0")]
		public BgAnimationEventParam(BgEffectSettingInner.TriggerLabelDefine tLabel, BgEffectSettingInner.AnimationLabelDefine aLabel)
		{
		}
	}

	[Serializable]
	[Token(Token = "0x2001D37")]
	public class BgEffectAdditionalSe
	{
		[Token(Token = "0x401026A")]
		[FieldOffset(Offset = "0x10")]
		public string animationName;

		[Token(Token = "0x401026B")]
		[FieldOffset(Offset = "0x18")]
		public string seLabel;

		[Token(Token = "0x401026C")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x401026D")]
		[FieldOffset(Offset = "0x24")]
		public bool enable3DSound;

		[Token(Token = "0x401026E")]
		[FieldOffset(Offset = "0x28")]
		public Vector3 position;

		[Token(Token = "0x600BBB8")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public BgEffectAdditionalSe()
		{
		}
	}

	[Token(Token = "0x2001D38")]
	public delegate void CheckDamageCallback();

	[Token(Token = "0x2001D3B")]
	[CompilerGenerated]
	private sealed class _003CPlayAnimatorTriggerDelayCoroutine_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4010272")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4010273")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010274")]
		[FieldOffset(Offset = "0x20")]
		public float delay;

		[Token(Token = "0x4010275")]
		[FieldOffset(Offset = "0x28")]
		public BgEffectManagerInner _003C_003E4__this;

		[Token(Token = "0x4010276")]
		[FieldOffset(Offset = "0x30")]
		public BgEffectSettingInner.TriggerLabelDefine label;

		[Token(Token = "0x4010277")]
		[FieldOffset(Offset = "0x38")]
		public string seLabel;

		[Token(Token = "0x17001BF7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BBC4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001BF8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BBC6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BBC1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CPlayAnimatorTriggerDelayCoroutine_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BBC2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BBC3")]
		[Address(RVA = "0x57AC20", Offset = "0x579E20", VA = "0x18057AC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BBC5")]
		[Address(RVA = "0x57ACE0", Offset = "0x579EE0", VA = "0x18057ACE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x401024E")]
	[FieldOffset(Offset = "0x50")]
	private List<BgEffectSettingInner.TriggerLabelDefine> phaseCheckLabel;

	[Token(Token = "0x401024F")]
	private const string animationEventFuncName = "PlayAnimationEvent";

	[Token(Token = "0x4010250")]
	private const string additionalSeEventFuncName = "PlayAdditionalSeEvent";

	[Token(Token = "0x4010251")]
	[FieldOffset(Offset = "0x58")]
	private Dictionary<BgEffectSettingInner.AnimationLabelDefine, List<BgEffectSettingInner>> effectSettings;

	[Token(Token = "0x4010252")]
	[FieldOffset(Offset = "0x60")]
	private List<BgEffectSettingInner> triggerSettings;

	[Token(Token = "0x4010253")]
	[FieldOffset(Offset = "0x68")]
	private List<BgEffectRequest> playEffectReqList;

	[Token(Token = "0x4010254")]
	[FieldOffset(Offset = "0x70")]
	private List<BgEffectRequest> removeEffectList;

	[Token(Token = "0x4010255")]
	[FieldOffset(Offset = "0x78")]
	private List<BgPhaseChangeSeRequest> playSeReqList;

	[Token(Token = "0x4010256")]
	[FieldOffset(Offset = "0x80")]
	private Animator rootAnimator;

	[Token(Token = "0x4010257")]
	[FieldOffset(Offset = "0x88")]
	public float finishAnimationDelay;

	[Token(Token = "0x4010258")]
	[FieldOffset(Offset = "0x90")]
	private Dictionary<string, BgAnimationEventParam> animationEventParamDic;

	[Token(Token = "0x4010259")]
	[FieldOffset(Offset = "0x98")]
	private List<string> playedAnimationEventList;

	[Token(Token = "0x401025A")]
	[FieldOffset(Offset = "0xA0")]
	private BgUnit bgUnit;

	[Token(Token = "0x401025B")]
	[FieldOffset(Offset = "0xA8")]
	private bool initalized;

	[Token(Token = "0x401025C")]
	[FieldOffset(Offset = "0xA9")]
	private bool enableSe;

	[Token(Token = "0x401025D")]
	[FieldOffset(Offset = "0xAA")]
	private bool isAudienceReplay;

	[Token(Token = "0x401025E")]
	[FieldOffset(Offset = "0xB0")]
	private CheckDamageCallback checkDamageCallback;

	[Token(Token = "0x401025F")]
	[FieldOffset(Offset = "0xB8")]
	private BgUnit.BgPhase checkDamagePhase;

	[Token(Token = "0x4010260")]
	[FieldOffset(Offset = "0xC0")]
	public List<BgEffectAdditionalSe> additionalSeList;

	[Token(Token = "0x600BB9D")]
	[Address(RVA = "0x49B7D0", Offset = "0x49A9D0", VA = "0x18049B7D0")]
	public BgUnit GetBgUnit()
	{
		return null;
	}

	[Token(Token = "0x600BB9E")]
	[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
	public ElementObject[] GetSerializedElements()
	{
		return null;
	}

	[Token(Token = "0x600BB9F")]
	[Address(RVA = "0x565220", Offset = "0x564420", VA = "0x180565220")]
	private void Update()
	{
	}

	[Token(Token = "0x600BBA0")]
	[Address(RVA = "0x563160", Offset = "0x562360", VA = "0x180563160")]
	public void Initialize(BgAnimationEventParam[] animationEventParams, BgUnit unit)
	{
	}

	[Token(Token = "0x600BBA1")]
	[Address(RVA = "0x5638A0", Offset = "0x562AA0", VA = "0x1805638A0")]
	public void Initialize(BgEffectManagerInner childlenMng, ElementObject[] elementObjects, bool isOtherSideElement = false)
	{
	}

	[Token(Token = "0x600BBA2")]
	[Address(RVA = "0x564E60", Offset = "0x564060", VA = "0x180564E60")]
	public void SetupBgEfectSettings(ElementObject[] elementObjects, bool isOtherSideElement = false)
	{
	}

	[Token(Token = "0x600BBA3")]
	[Address(RVA = "0x563D60", Offset = "0x562F60", VA = "0x180563D60")]
	public void PlayAnimationEvent(string str)
	{
	}

	[Token(Token = "0x600BBA4")]
	[Address(RVA = "0x563BC0", Offset = "0x562DC0", VA = "0x180563BC0")]
	public void PlayAdditionalSeEvent(string label)
	{
	}

	[Token(Token = "0x600BBA5")]
	[Address(RVA = "0x564410", Offset = "0x563610", VA = "0x180564410")]
	public void PlayEffect(BgEffectSettingInner.AnimationLabelDefine label)
	{
	}

	[Token(Token = "0x600BBA6")]
	[Address(RVA = "0x564AC0", Offset = "0x563CC0", VA = "0x180564AC0")]
	public void SetEnableTapEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
	{
	}

	[Token(Token = "0x600BBA7")]
	[Address(RVA = "0x5647C0", Offset = "0x5639C0", VA = "0x1805647C0")]
	public void SetEnableLoopEffect(BgEffectSettingInner.AnimationLabelDefine label, bool flg)
	{
	}

	[Token(Token = "0x600BBA8")]
	[Address(RVA = "0x563FB0", Offset = "0x5631B0", VA = "0x180563FB0")]
	public void PlayAnimatorTriggerDelay(BgEffectSettingInner.TriggerLabelDefine label, float delay, string seLabel = "")
	{
	}

	[Token(Token = "0x600BBA9")]
	[Address(RVA = "0x563F00", Offset = "0x563100", VA = "0x180563F00")]
	[IteratorStateMachine(typeof(_003CPlayAnimatorTriggerDelayCoroutine_003Ed__36))]
	private IEnumerator PlayAnimatorTriggerDelayCoroutine(BgEffectSettingInner.TriggerLabelDefine label, float delay, string seLabel = "")
	{
		return null;
	}

	[Token(Token = "0x600BBAA")]
	[Address(RVA = "0x564060", Offset = "0x563260", VA = "0x180564060")]
	public void PlayAnimatorTrigger(BgEffectSettingInner.TriggerLabelDefine label, string seLabel = "")
	{
	}

	[Token(Token = "0x600BBAB")]
	[Address(RVA = "0x564630", Offset = "0x563830", VA = "0x180564630")]
	public void PlayTapAnimation()
	{
	}

	[Token(Token = "0x600BBAC")]
	[Address(RVA = "0x563A30", Offset = "0x562C30", VA = "0x180563A30")]
	public bool IsTapPlaying()
	{
		return default(bool);
	}

	[Token(Token = "0x600BBAD")]
	[Address(RVA = "0x564AB0", Offset = "0x563CB0", VA = "0x180564AB0")]
	public void SetEnableSE(bool flg)
	{
	}

	[Token(Token = "0x600BBAE")]
	[Address(RVA = "0x564C50", Offset = "0x563E50", VA = "0x180564C50")]
	public void SetRootAnimatorSpeed(float speed)
	{
	}

	[Token(Token = "0x600BBAF")]
	[Address(RVA = "0x564CE0", Offset = "0x563EE0", VA = "0x180564CE0")]
	public void SetSubAnimatorSpeed(float speed)
	{
	}

	[Token(Token = "0x600BBB0")]
	[Address(RVA = "0x564C40", Offset = "0x563E40", VA = "0x180564C40")]
	public void SetIsAudienceReplay(bool flg)
	{
	}

	[Token(Token = "0x600BBB1")]
	[Address(RVA = "0x563080", Offset = "0x562280", VA = "0x180563080")]
	public bool GetCurrentAnimatorStateInfoIsName(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x600BBB2")]
	[Address(RVA = "0x5647A0", Offset = "0x5639A0", VA = "0x1805647A0")]
	public void SetCheckDamageCallback(BgUnit.BgPhase phase, CheckDamageCallback cb)
	{
	}

	[Token(Token = "0x600BBB3")]
	[Address(RVA = "0x562FF0", Offset = "0x5621F0", VA = "0x180562FF0")]
	public List<BgEffectSettingInner> GetAnimationLabelSettings(BgEffectSettingInner.AnimationLabelDefine label)
	{
		return null;
	}

	[Token(Token = "0x600BBB4")]
	[Address(RVA = "0x565710", Offset = "0x564910", VA = "0x180565710")]
	public BgEffectManagerInner()
	{
	}
}
