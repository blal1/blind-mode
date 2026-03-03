using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem;

namespace YgomGame.Menu;

[Token(Token = "0x200122A")]
public class OnDemandLogoViewController : BaseMenuViewController
{
	[Token(Token = "0x200122B")]
	private enum Step
	{
		[Token(Token = "0x400BA69")]
		Loading,
		[Token(Token = "0x400BA6A")]
		StartFade,
		[Token(Token = "0x400BA6B")]
		LogoIn,
		[Token(Token = "0x400BA6C")]
		LogoStay,
		[Token(Token = "0x400BA6D")]
		LogoOut,
		[Token(Token = "0x400BA6E")]
		EndFade,
		[Token(Token = "0x400BA6F")]
		Finish
	}

	[Token(Token = "0x200122D")]
	[CompilerGenerated]
	private sealed class _003CstepLoading_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA72")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA73")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA74")]
		[FieldOffset(Offset = "0x20")]
		public OnDemandLogoViewController _003C_003E4__this;

		[Token(Token = "0x400BA75")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x400BA76")]
		[FieldOffset(Offset = "0x30")]
		private string _003Clogo_path_003E5__2;

		[Token(Token = "0x170011D5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007141")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007143")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600713E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepLoading_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600713F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007140")]
		[Address(RVA = "0xB81E10", Offset = "0xB81010", VA = "0x180B81E10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007142")]
		[Address(RVA = "0xB82090", Offset = "0xB81290", VA = "0x180B82090", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BA62")]
	private const float LogoDelayTime = 1.5f;

	[Token(Token = "0x400BA63")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x400BA64")]
	[FieldOffset(Offset = "0xD8")]
	private OnDemandLogoData m_logoData;

	[Token(Token = "0x400BA65")]
	[FieldOffset(Offset = "0xE0")]
	private float m_logoDispTime;

	[Token(Token = "0x400BA66")]
	[FieldOffset(Offset = "0xE4")]
	private bool m_skipLogo;

	[Token(Token = "0x400BA67")]
	[FieldOffset(Offset = "0xE8")]
	private Action m_resultCallback;

	[Token(Token = "0x600712B")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void debugLog(string msg)
	{
	}

	[Token(Token = "0x600712C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void timeLog(string msg)
	{
	}

	[Token(Token = "0x600712D")]
	[Address(RVA = "0xB7BF80", Offset = "0xB7B180", VA = "0x180B7BF80", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600712E")]
	[Address(RVA = "0xB7C310", Offset = "0xB7B510", VA = "0x180B7C310", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600712F")]
	[Address(RVA = "0xB76B60", Offset = "0xB75D60", VA = "0x180B76B60", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007130")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x6007131")]
	[Address(RVA = "0xB7C7C0", Offset = "0xB7B9C0", VA = "0x180B7C7C0")]
	[IteratorStateMachine(typeof(_003CstepLoading_003Ed__13))]
	private IEnumerator stepLoading(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007132")]
	[Address(RVA = "0xB7C910", Offset = "0xB7BB10", VA = "0x180B7C910")]
	private void stepTweenPlay(StepSequencer seq, string tweenLabel, Step nextStep)
	{
	}

	[Token(Token = "0x6007133")]
	[Address(RVA = "0xB7C850", Offset = "0xB7BA50", VA = "0x180B7C850")]
	private void stepLogoStay(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007134")]
	[Address(RVA = "0xB7C770", Offset = "0xB7B970", VA = "0x180B7C770")]
	private void stepFinish(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007135")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public OnDemandLogoViewController()
	{
	}
}
