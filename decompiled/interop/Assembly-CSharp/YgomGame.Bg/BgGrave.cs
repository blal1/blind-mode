using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Bg;

[Token(Token = "0x2001D45")]
public class BgGrave : MonoBehaviour
{
	[Token(Token = "0x2001D46")]
	public enum GraveType
	{
		[Token(Token = "0x4010313")]
		None,
		[Token(Token = "0x4010314")]
		Common,
		[Token(Token = "0x4010315")]
		Unique
	}

	[Token(Token = "0x2001D47")]
	public enum BgGravePos
	{
		[Token(Token = "0x4010317")]
		PosGrave = 16,
		[Token(Token = "0x4010318")]
		PosExclude
	}

	[Token(Token = "0x2001D48")]
	private enum ParticleEffectIdx
	{
		[Token(Token = "0x401031A")]
		GraveIn,
		[Token(Token = "0x401031B")]
		GraveInend,
		[Token(Token = "0x401031C")]
		GraveOut,
		[Token(Token = "0x401031D")]
		GraveOutend,
		[Token(Token = "0x401031E")]
		ExcludeIn,
		[Token(Token = "0x401031F")]
		ExcludeInend,
		[Token(Token = "0x4010320")]
		ExcludeOut,
		[Token(Token = "0x4010321")]
		ExcludeOutend,
		[Token(Token = "0x4010322")]
		GraveIdleS1,
		[Token(Token = "0x4010323")]
		GraveIdleS2,
		[Token(Token = "0x4010324")]
		GraveIdleS3,
		[Token(Token = "0x4010325")]
		ExcludeIdleS1,
		[Token(Token = "0x4010326")]
		ExcludeIdleS2,
		[Token(Token = "0x4010327")]
		ExcludeIdleS3,
		[Token(Token = "0x4010328")]
		Max
	}

	[Token(Token = "0x2001D49")]
	private class GraveParticle
	{
		[Token(Token = "0x4010329")]
		[FieldOffset(Offset = "0x10")]
		private ParticleSystem effect;

		[Token(Token = "0x401032A")]
		[FieldOffset(Offset = "0x18")]
		public BgEffectSettingInner setting;

		[Token(Token = "0x600BC10")]
		[Address(RVA = "0x438FD0", Offset = "0x4381D0", VA = "0x180438FD0")]
		public GraveParticle(ParticleSystem effect)
		{
		}

		[Token(Token = "0x600BC11")]
		[Address(RVA = "0x57A680", Offset = "0x579880", VA = "0x18057A680")]
		public void SetEffectSetting()
		{
		}

		[Token(Token = "0x600BC12")]
		[Address(RVA = "0x57A600", Offset = "0x579800", VA = "0x18057A600")]
		public void Play()
		{
		}

		[Token(Token = "0x600BC13")]
		[Address(RVA = "0x57A6F0", Offset = "0x5798F0", VA = "0x18057A6F0")]
		public void Stop()
		{
		}
	}

	[Token(Token = "0x2001D4A")]
	private class GraveEffect
	{
		[Token(Token = "0x401032B")]
		[FieldOffset(Offset = "0x10")]
		private Action start;

		[Token(Token = "0x401032C")]
		[FieldOffset(Offset = "0x18")]
		private Action<float> update;

		[Token(Token = "0x401032D")]
		[FieldOffset(Offset = "0x20")]
		private Action end;

		[Token(Token = "0x401032E")]
		[FieldOffset(Offset = "0x28")]
		private float targetTime;

		[Token(Token = "0x401032F")]
		[FieldOffset(Offset = "0x2C")]
		private float time;

		[Token(Token = "0x4010330")]
		[FieldOffset(Offset = "0x30")]
		public string name;

		[Token(Token = "0x4010331")]
		[FieldOffset(Offset = "0x38")]
		public bool remove;

		[Token(Token = "0x600BC14")]
		[Address(RVA = "0x57A4F0", Offset = "0x5796F0", VA = "0x18057A4F0")]
		public GraveEffect(Action startFunc, Action<float> updateFunc, Action endFunc, float target)
		{
		}

		[Token(Token = "0x600BC15")]
		[Address(RVA = "0x57A470", Offset = "0x579670", VA = "0x18057A470")]
		public void Update()
		{
		}
	}

	[Token(Token = "0x2001D4E")]
	[CompilerGenerated]
	private sealed class _003CSkipWait_003Ed__69 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x401033E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x401033F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4010340")]
		[FieldOffset(Offset = "0x20")]
		public BgGrave _003C_003E4__this;

		[Token(Token = "0x17001C01")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600BC23")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001C02")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600BC25")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600BC20")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSkipWait_003Ed__69(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600BC21")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600BC22")]
		[Address(RVA = "0x57AD20", Offset = "0x579F20", VA = "0x18057AD20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600BC24")]
		[Address(RVA = "0x57AEB0", Offset = "0x57A0B0", VA = "0x18057AEB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40102EB")]
	private const string posGraveLabel = "POS_Grave";

	[Token(Token = "0x40102EC")]
	private const string posExclueLabel = "POS_Exclude";

	[Token(Token = "0x40102ED")]
	private const string meshElementLabel01 = "Material01";

	[Token(Token = "0x40102EE")]
	private const string graveHighlightAnimatorLabelBase = "GraveHighlight";

	[Token(Token = "0x40102EF")]
	private const string excludeHighlightAnimatorLabelBase = "ExcludeHighlight";

	[Token(Token = "0x40102F0")]
	private const string highlightTriggerName = "On";

	[Token(Token = "0x40102F1")]
	private const string graveMouseOverPropertyName = "_GraveMouseOver";

	[Token(Token = "0x40102F2")]
	private const string excludeMouseOverPropertyName = "_ExcludeMouseOver";

	[Token(Token = "0x40102F3")]
	private const string gravePressButtonPropertyName = "_GravePressButton";

	[Token(Token = "0x40102F4")]
	private const string excludePressButtonPropertyName = "_ExcludePressButton";

	[Token(Token = "0x40102F5")]
	private const string graveExistPropertyName = "_GraveCardExist";

	[Token(Token = "0x40102F6")]
	private const string excludeExistPropertyName = "_ExcludeCardExist";

	[Token(Token = "0x40102F7")]
	private const string graveInElementLabel = "GraveIn";

	[Token(Token = "0x40102F8")]
	private const string graveInendElementLabel = "GraveInend";

	[Token(Token = "0x40102F9")]
	private const string graveOutElementLabel = "GraveOut";

	[Token(Token = "0x40102FA")]
	private const string graveOutendElementLabel = "GraveOutend";

	[Token(Token = "0x40102FB")]
	private const string excludeInElementLabel = "ExcludeIn";

	[Token(Token = "0x40102FC")]
	private const string excludeInendElementLabel = "ExcludeInend";

	[Token(Token = "0x40102FD")]
	private const string excludeOutElementLabel = "ExcludeOut";

	[Token(Token = "0x40102FE")]
	private const string excludeOutendElementLabel = "ExcludeOutend";

	[Token(Token = "0x40102FF")]
	private const string graveIdleS1ElementLabel = "GraveIdleS1";

	[Token(Token = "0x4010300")]
	private const string graveIdleS2ElementLabel = "GraveIdleS2";

	[Token(Token = "0x4010301")]
	private const string graveIdleS3ElementLabel = "GraveIdleS3";

	[Token(Token = "0x4010302")]
	private const string excludeIdleS1ElementLabel = "ExcludeIdleS1";

	[Token(Token = "0x4010303")]
	private const string excludeIdleS2ElementLabel = "ExcludeIdleS2";

	[Token(Token = "0x4010304")]
	private const string excludeIdleS3ElementLabel = "ExcludeIdleS3";

	[Token(Token = "0x4010305")]
	private const float particleEffectWait = 0.5f;

	[Token(Token = "0x4010306")]
	private const float materialUpdateWait = 0.05f;

	[Token(Token = "0x4010307")]
	private const float cardExistMaterialUpdateWait = 0.5f;

	[Token(Token = "0x4010308")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<string, Renderer> renderers;

	[Token(Token = "0x4010309")]
	[FieldOffset(Offset = "0x28")]
	private Animator excludeHighlightAnimator;

	[Token(Token = "0x401030A")]
	[FieldOffset(Offset = "0x30")]
	private Animator graveHighlightAnimator;

	[Token(Token = "0x401030B")]
	[FieldOffset(Offset = "0x38")]
	private Animator graveAnimator;

	[Token(Token = "0x401030C")]
	[FieldOffset(Offset = "0x40")]
	private bool audienceReplayStart;

	[Token(Token = "0x401030D")]
	[FieldOffset(Offset = "0x48")]
	public GameObject posGrave;

	[Token(Token = "0x401030E")]
	[FieldOffset(Offset = "0x50")]
	public GameObject posExclude;

	[Token(Token = "0x401030F")]
	[FieldOffset(Offset = "0x58")]
	private GraveParticle[] particleEffect;

	[Token(Token = "0x4010310")]
	[FieldOffset(Offset = "0x60")]
	private List<GraveEffect> effectUpdateList;

	[Token(Token = "0x4010311")]
	[FieldOffset(Offset = "0x68")]
	private List<GraveEffect> removeEffectUpdateList;

	[Token(Token = "0x600BBF4")]
	[Address(RVA = "0x569F20", Offset = "0x569120", VA = "0x180569F20")]
	private void SetParticleEffect(ParticleEffectIdx startIdx, ParticleEffectIdx endIdx)
	{
	}

	[Token(Token = "0x600BBF5")]
	[Address(RVA = "0x568130", Offset = "0x567330", VA = "0x180568130")]
	private void ChangeMaterialProperty(string meshLabel, string propertyName, float start, float end, float target)
	{
	}

	[Token(Token = "0x600BBF6")]
	[Address(RVA = "0x5696B0", Offset = "0x5688B0", VA = "0x1805696B0")]
	private void SetAnimaterTrigger(Animator animator, string start, string end, float target = 0.5f)
	{
	}

	[Token(Token = "0x600BBF7")]
	[Address(RVA = "0x5684F0", Offset = "0x5676F0", VA = "0x1805684F0")]
	public static BgGrave Create(GameObject res, Transform root, BgUnit.Side side)
	{
		return null;
	}

	[Token(Token = "0x600BBF8")]
	[Address(RVA = "0x568900", Offset = "0x567B00", VA = "0x180568900")]
	private void Initialize(BgUnit.Side side)
	{
	}

	[Token(Token = "0x600BBF9")]
	[Address(RVA = "0x56A460", Offset = "0x569660", VA = "0x18056A460")]
	private void Update()
	{
	}

	[Token(Token = "0x600BBFA")]
	[Address(RVA = "0x568610", Offset = "0x567810", VA = "0x180568610")]
	private void EffectUpdate()
	{
	}

	[Token(Token = "0x600BBFB")]
	[Address(RVA = "0x569E90", Offset = "0x569090", VA = "0x180569E90")]
	public void SetBgGrave(int player, int position, bool cardIn)
	{
	}

	[Token(Token = "0x600BBFC")]
	[Address(RVA = "0x569A80", Offset = "0x568C80", VA = "0x180569A80")]
	private void SetBgGraveInner(int position, int num, bool cardIn)
	{
	}

	[Token(Token = "0x600BBFD")]
	[Address(RVA = "0x569890", Offset = "0x568A90", VA = "0x180569890")]
	public void SetBgGraveHighlight(bool flg)
	{
	}

	[Token(Token = "0x600BBFE")]
	[Address(RVA = "0x569330", Offset = "0x568530", VA = "0x180569330")]
	public void OnCursorEnterGrave()
	{
	}

	[Token(Token = "0x600BBFF")]
	[Address(RVA = "0x569430", Offset = "0x568630", VA = "0x180569430")]
	public void OnCursorExitGrave()
	{
	}

	[Token(Token = "0x600BC00")]
	[Address(RVA = "0x569530", Offset = "0x568730", VA = "0x180569530")]
	public void OnSelectPressedGrave()
	{
	}

	[Token(Token = "0x600BC01")]
	[Address(RVA = "0x569630", Offset = "0x568830", VA = "0x180569630")]
	public void OnSelectReleasedGrave()
	{
	}

	[Token(Token = "0x600BC02")]
	[Address(RVA = "0x569260", Offset = "0x568460", VA = "0x180569260")]
	public void OnCardIntoGrave()
	{
	}

	[Token(Token = "0x600BC03")]
	[Address(RVA = "0x5691A0", Offset = "0x5683A0", VA = "0x1805691A0")]
	public void OnCardInGrave(bool flg)
	{
	}

	[Token(Token = "0x600BC04")]
	[Address(RVA = "0x569290", Offset = "0x568490", VA = "0x180569290")]
	public void OnCardOutGrave(int num)
	{
	}

	[Token(Token = "0x600BC05")]
	[Address(RVA = "0x5692B0", Offset = "0x5684B0", VA = "0x1805692B0")]
	public void OnCursorEnterExclude()
	{
	}

	[Token(Token = "0x600BC06")]
	[Address(RVA = "0x5693B0", Offset = "0x5685B0", VA = "0x1805693B0")]
	public void OnCursorExitExclude()
	{
	}

	[Token(Token = "0x600BC07")]
	[Address(RVA = "0x5694B0", Offset = "0x5686B0", VA = "0x1805694B0")]
	public void OnSelectPressedExclude()
	{
	}

	[Token(Token = "0x600BC08")]
	[Address(RVA = "0x5695B0", Offset = "0x5687B0", VA = "0x1805695B0")]
	public void OnSelectReleasedExclude()
	{
	}

	[Token(Token = "0x600BC09")]
	[Address(RVA = "0x569240", Offset = "0x568440", VA = "0x180569240")]
	public void OnCardIntoExclude()
	{
	}

	[Token(Token = "0x600BC0A")]
	[Address(RVA = "0x569100", Offset = "0x568300", VA = "0x180569100")]
	public void OnCardInExclude(bool flg)
	{
	}

	[Token(Token = "0x600BC0B")]
	[Address(RVA = "0x569270", Offset = "0x568470", VA = "0x180569270")]
	public void OnCardOutExclude()
	{
	}

	[Token(Token = "0x600BC0C")]
	[Address(RVA = "0x56A310", Offset = "0x569510", VA = "0x18056A310")]
	public void SkipStartAnimation()
	{
	}

	[Token(Token = "0x600BC0D")]
	[Address(RVA = "0x56A3F0", Offset = "0x5695F0", VA = "0x18056A3F0")]
	[IteratorStateMachine(typeof(_003CSkipWait_003Ed__69))]
	private IEnumerator SkipWait()
	{
		return null;
	}

	[Token(Token = "0x600BC0E")]
	[Address(RVA = "0x5683D0", Offset = "0x5675D0", VA = "0x1805683D0")]
	private void CheckStartAnimation()
	{
	}

	[Token(Token = "0x600BC0F")]
	[Address(RVA = "0x56A470", Offset = "0x569670", VA = "0x18056A470")]
	public BgGrave()
	{
	}
}
