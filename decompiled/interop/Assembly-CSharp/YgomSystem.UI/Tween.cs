using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace YgomSystem.UI;

[Token(Token = "0x20004DC")]
public abstract class Tween : MonoBehaviour
{
	[Token(Token = "0x20004DD")]
	public enum Easing
	{
		[Token(Token = "0x4001803")]
		Linear,
		[Token(Token = "0x4001804")]
		CubicIn,
		[Token(Token = "0x4001805")]
		CubicOut,
		[Token(Token = "0x4001806")]
		CubicInOut,
		[Token(Token = "0x4001807")]
		BackIn,
		[Token(Token = "0x4001808")]
		BackOut,
		[Token(Token = "0x4001809")]
		BackInOut,
		[Token(Token = "0x400180A")]
		BounceIn,
		[Token(Token = "0x400180B")]
		BounceOut,
		[Token(Token = "0x400180C")]
		BounceInOut,
		[Token(Token = "0x400180D")]
		Customize,
		[Token(Token = "0x400180E")]
		QuartIn,
		[Token(Token = "0x400180F")]
		QuartOut,
		[Token(Token = "0x4001810")]
		QuartInOut
	}

	[Token(Token = "0x20004DE")]
	public enum Style
	{
		[Token(Token = "0x4001812")]
		Once,
		[Token(Token = "0x4001813")]
		Loop,
		[Token(Token = "0x4001814")]
		PingPong,
		[Token(Token = "0x4001815")]
		PingPongLoop,
		[Token(Token = "0x4001816")]
		SyncLoop,
		[Token(Token = "0x4001817")]
		SyncPingPongLoop
	}

	[Token(Token = "0x20004DF")]
	[CompilerGenerated]
	private sealed class _003CyTargetPlayLabelRoutine_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001818")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001819")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400181A")]
		[FieldOffset(Offset = "0x20")]
		public GameObject target;

		[Token(Token = "0x400181B")]
		[FieldOffset(Offset = "0x28")]
		public string _label;

		[Token(Token = "0x400181C")]
		[FieldOffset(Offset = "0x30")]
		public bool includeChildren;

		[Token(Token = "0x400181D")]
		[FieldOffset(Offset = "0x38")]
		private List<Tween> _003CplayTweens_003E5__2;

		[Token(Token = "0x17000351")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002069")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000352")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600206B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002066")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyTargetPlayLabelRoutine_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002067")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002068")]
		[Address(RVA = "0x6473F0", Offset = "0x6465F0", VA = "0x1806473F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600206A")]
		[Address(RVA = "0x647840", Offset = "0x646A40", VA = "0x180647840", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40017F2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly float FRAMERATE_LIMIT;

	[Token(Token = "0x40017F3")]
	[FieldOffset(Offset = "0x20")]
	public string label;

	[Token(Token = "0x40017F4")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Easing easing;

	[Token(Token = "0x40017F5")]
	[FieldOffset(Offset = "0x2C")]
	[SerializeField]
	public Style style;

	[Token(Token = "0x40017F6")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	[SecField]
	public float duration;

	[Token(Token = "0x40017F7")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	[SecField]
	public float setupWait;

	[Token(Token = "0x40017F8")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	[SecField]
	public float startDelay;

	[Token(Token = "0x40017F9")]
	[FieldOffset(Offset = "0x3C")]
	[SerializeField]
	public bool ignoreTimeScale;

	[Token(Token = "0x40017FA")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	public UnityEvent onFinished;

	[Token(Token = "0x40017FB")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	public bool callOnFinishedDestroy;

	[Token(Token = "0x40017FC")]
	[FieldOffset(Offset = "0x50")]
	[HideInInspector]
	public AnimationCurve curve;

	[Token(Token = "0x40017FD")]
	[FieldOffset(Offset = "0x58")]
	protected float timeDelta;

	[Token(Token = "0x40017FE")]
	[FieldOffset(Offset = "0x5C")]
	protected float crntTime;

	[Token(Token = "0x40017FF")]
	[FieldOffset(Offset = "0x60")]
	private bool isCaptured;

	[Token(Token = "0x4001800")]
	[FieldOffset(Offset = "0x64")]
	private float setupWaitCount;

	[Token(Token = "0x4001801")]
	[FieldOffset(Offset = "0x68")]
	private bool isExecFinished;

	[Token(Token = "0x6002038")]
	[Address(RVA = "0x643300", Offset = "0x642500", VA = "0x180643300")]
	private static float BounceOut(float k)
	{
		return default(float);
	}

	[Token(Token = "0x6002039")]
	[Address(RVA = "0x6431D0", Offset = "0x6423D0", VA = "0x1806431D0")]
	private static float BounceIn(float k)
	{
		return default(float);
	}

	[Token(Token = "0x600203A")]
	[Address(RVA = "0x643400", Offset = "0x642600", VA = "0x180643400")]
	public static float EasingValue(float k, Easing e)
	{
		return default(float);
	}

	[Token(Token = "0x600203B")]
	[Address(RVA = "0x643DB0", Offset = "0x642FB0", VA = "0x180643DB0")]
	private float GetEasing(float k)
	{
		return default(float);
	}

	[Token(Token = "0x600203C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "4")]
	protected virtual void CaptureAwake()
	{
	}

	[Token(Token = "0x600203D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	protected virtual void CaptureFrom()
	{
	}

	[Token(Token = "0x600203E")]
	protected abstract void OnSetValue(float par);

	[Token(Token = "0x600203F")]
	[Address(RVA = "0x6431B0", Offset = "0x6423B0", VA = "0x1806431B0")]
	private void Awake()
	{
	}

	[Token(Token = "0x6002040")]
	[Address(RVA = "0x643B50", Offset = "0x642D50", VA = "0x180643B50")]
	private void ExecSetup()
	{
	}

	[Token(Token = "0x6002041")]
	[Address(RVA = "0x6438B0", Offset = "0x642AB0", VA = "0x1806438B0")]
	private void ExecPlay(float time, bool forceUpdate = false)
	{
	}

	[Token(Token = "0x6002042")]
	[Address(RVA = "0x644830", Offset = "0x643A30", VA = "0x180644830")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6002043")]
	[Address(RVA = "0x643B50", Offset = "0x642D50", VA = "0x180643B50")]
	private void Start()
	{
	}

	[Token(Token = "0x6002044")]
	[Address(RVA = "0x646170", Offset = "0x645370", VA = "0x180646170")]
	private void Update()
	{
	}

	[Token(Token = "0x6002045")]
	[Address(RVA = "0x644990", Offset = "0x643B90", VA = "0x180644990")]
	public void Play()
	{
	}

	[Token(Token = "0x6002046")]
	[Address(RVA = "0x644870", Offset = "0x643A70", VA = "0x180644870")]
	public void Pause()
	{
	}

	[Token(Token = "0x6002047")]
	[Address(RVA = "0x644A90", Offset = "0x643C90", VA = "0x180644A90")]
	public void Stop()
	{
	}

	[Token(Token = "0x6002048")]
	[Address(RVA = "0x6437F0", Offset = "0x6429F0", VA = "0x1806437F0")]
	public void End()
	{
	}

	[Token(Token = "0x6002049")]
	[Address(RVA = "0x644A50", Offset = "0x643C50", VA = "0x180644A50")]
	public void Reset()
	{
	}

	[Token(Token = "0x600204A")]
	[Address(RVA = "0x644A10", Offset = "0x643C10", VA = "0x180644A10")]
	public void ResetWithTimeDelta()
	{
	}

	[Token(Token = "0x600204B")]
	[Address(RVA = "0x644620", Offset = "0x643820", VA = "0x180644620")]
	public void GotoAndPlay(float time)
	{
	}

	[Token(Token = "0x600204C")]
	[Address(RVA = "0x6445E0", Offset = "0x6437E0", VA = "0x1806445E0")]
	public void GotoAndPause(float time)
	{
	}

	[Token(Token = "0x600204D")]
	[Address(RVA = "0x6433A0", Offset = "0x6425A0", VA = "0x1806433A0")]
	public void DestroySelf()
	{
	}

	[Token(Token = "0x600204E")]
	[Address(RVA = "0x644880", Offset = "0x643A80", VA = "0x180644880")]
	public void PlayLabel(string _label)
	{
	}

	[Token(Token = "0x600204F")]
	[Address(RVA = "0x6446E0", Offset = "0x6438E0", VA = "0x1806446E0")]
	public bool IsPlaying(string _label = "", bool isActive = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002050")]
	[Address(RVA = "0x644660", Offset = "0x643860", VA = "0x180644660")]
	public bool IsFinished()
	{
		return default(bool);
	}

	[Token(Token = "0x6002051")]
	[Address(RVA = "0x645C40", Offset = "0x644E40", VA = "0x180645C40")]
	public static void TargetPlayLabel(GameObject target, string _label = "", bool includeChildren = false, bool wakeup = false)
	{
	}

	[Token(Token = "0x6002052")]
	[Address(RVA = "0x6457D0", Offset = "0x6449D0", VA = "0x1806457D0")]
	public static bool TargetIsPlaying(GameObject target, string _label = "", bool includeChildren = false, bool isActive = false)
	{
		return default(bool);
	}

	[Token(Token = "0x6002053")]
	[Address(RVA = "0x6454A0", Offset = "0x6446A0", VA = "0x1806454A0")]
	public static void TargetGotoAndPlayLabel(GameObject target, float time, string _label = "", bool includeChildren = false, bool wakeup = false)
	{
	}

	[Token(Token = "0x6002054")]
	[Address(RVA = "0x645170", Offset = "0x644370", VA = "0x180645170")]
	public static void TargetGotoAndPauseLabel(GameObject target, float time, string _label = "", bool includeChildren = false, bool wakeup = false)
	{
	}

	[Token(Token = "0x6002055")]
	[Address(RVA = "0x645A40", Offset = "0x644C40", VA = "0x180645A40")]
	public static void TargetPauseLabel(GameObject target, string _label = "", bool includeChildren = false)
	{
	}

	[Token(Token = "0x6002056")]
	[Address(RVA = "0x645F50", Offset = "0x645150", VA = "0x180645F50")]
	public static void TargetStopLabel(GameObject target, string _label = "", bool includeChildren = false, string exlabel = "")
	{
	}

	[Token(Token = "0x6002057")]
	[Address(RVA = "0x644D30", Offset = "0x643F30", VA = "0x180644D30")]
	public static void TargetEndLabel(GameObject target, string _label = "", bool includeChildren = false)
	{
	}

	[Token(Token = "0x6002058")]
	[Address(RVA = "0x644F40", Offset = "0x644140", VA = "0x180644F40")]
	public static void TargetForwardLabel(GameObject target, float sec, string _label = "", bool includeChildren = false)
	{
	}

	[Token(Token = "0x6002059")]
	[Address(RVA = "0x644AF0", Offset = "0x643CF0", VA = "0x180644AF0")]
	public static void TargetCaptureFrom(GameObject target, string _label = "", bool includeChildren = false, bool force = false)
	{
	}

	[Token(Token = "0x600205A")]
	[Address(RVA = "0x644AB0", Offset = "0x643CB0", VA = "0x180644AB0")]
	public static void TargetCaptureFrom(Tween tween, bool force)
	{
	}

	[Token(Token = "0x600205B")]
	[Address(RVA = "0x642F00", Offset = "0x642100", VA = "0x180642F00")]
	public static void AllPlayLabel(string label)
	{
	}

	[Token(Token = "0x600205C")]
	[Address(RVA = "0x643050", Offset = "0x642250", VA = "0x180643050")]
	public static void AllStopLabel(string label)
	{
	}

	[Token(Token = "0x600205D")]
	[Address(RVA = "0x642DA0", Offset = "0x641FA0", VA = "0x180642DA0")]
	public static void AllPauseLabel(string label)
	{
	}

	[Token(Token = "0x600205E")]
	[Address(RVA = "0x642C50", Offset = "0x641E50", VA = "0x180642C50")]
	public static void AllEndLabel(string label)
	{
	}

	[Token(Token = "0x600205F")]
	[Address(RVA = "0x644370", Offset = "0x643570", VA = "0x180644370")]
	public static List<Tween> GetTweenTarget(GameObject target, string _label = "", bool includeChildren = false)
	{
		return null;
	}

	[Token(Token = "0x6002060")]
	[Address(RVA = "0x6441D0", Offset = "0x6433D0", VA = "0x1806441D0")]
	public static List<Tween> GetTweenAll(string label)
	{
		return null;
	}

	[Token(Token = "0x6002061")]
	[Address(RVA = "0x643BC0", Offset = "0x642DC0", VA = "0x180643BC0")]
	public static void FreezeTweenTarget(GameObject target, float freezeTime = 0f, string _label = "", bool includeChildren = false)
	{
	}

	[Token(Token = "0x6002062")]
	[Address(RVA = "0x643D60", Offset = "0x642F60", VA = "0x180643D60")]
	public void Freeze(float freezeTime = 0f)
	{
	}

	[Token(Token = "0x6002063")]
	[Address(RVA = "0x646450", Offset = "0x645650", VA = "0x180646450")]
	[IteratorStateMachine(typeof(_003CyTargetPlayLabelRoutine_003Ed__61))]
	public static IEnumerator yTargetPlayLabelRoutine(GameObject target, string _label = "", bool includeChildren = false)
	{
		return null;
	}

	[Token(Token = "0x6002064")]
	[Address(RVA = "0x6462C0", Offset = "0x6454C0", VA = "0x1806462C0")]
	protected Tween()
	{
	}
}
