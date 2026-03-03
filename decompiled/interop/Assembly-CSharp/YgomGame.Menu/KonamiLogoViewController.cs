using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem;

namespace YgomGame.Menu;

[Token(Token = "0x2001225")]
public class KonamiLogoViewController : BaseMenuViewController
{
	[Token(Token = "0x2001226")]
	private enum Step
	{
		[Token(Token = "0x400BA51")]
		Init,
		[Token(Token = "0x400BA52")]
		StartFade,
		[Token(Token = "0x400BA53")]
		LogoIn,
		[Token(Token = "0x400BA54")]
		LogoStay,
		[Token(Token = "0x400BA55")]
		LogoOut,
		[Token(Token = "0x400BA56")]
		EndFade,
		[Token(Token = "0x400BA57")]
		Finish
	}

	[Token(Token = "0x2001228")]
	[CompilerGenerated]
	private sealed class _003CstepFinish_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA5A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA5B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA5C")]
		[FieldOffset(Offset = "0x20")]
		public StepSequencer seq;

		[Token(Token = "0x400BA5D")]
		[FieldOffset(Offset = "0x28")]
		public KonamiLogoViewController _003C_003E4__this;

		[Token(Token = "0x400BA5E")]
		[FieldOffset(Offset = "0x30")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x400BA5F")]
		[FieldOffset(Offset = "0x34")]
		private bool _003CshowProgress_003E5__3;

		[Token(Token = "0x170011D3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007127")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007129")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007124")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepFinish_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007125")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007126")]
		[Address(RVA = "0xB81870", Offset = "0xB80A70", VA = "0x180B81870", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007128")]
		[Address(RVA = "0xB81DD0", Offset = "0xB80FD0", VA = "0x180B81DD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BA4C")]
	private const float KonamiLogoDelayTime = 2f;

	[Token(Token = "0x400BA4D")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x400BA4E")]
	[FieldOffset(Offset = "0xD8")]
	private float m_KonamiLogoDispTime;

	[Token(Token = "0x400BA4F")]
	[FieldOffset(Offset = "0xDC")]
	private bool m_KonamiLogoSkip;

	[Token(Token = "0x6007112")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private void debugLog(string msg)
	{
	}

	[Token(Token = "0x6007113")]
	[Address(RVA = "0xB76A30", Offset = "0xB75C30", VA = "0x180B76A30", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007114")]
	[Address(RVA = "0xB76BC0", Offset = "0xB75DC0", VA = "0x180B76BC0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6007115")]
	[Address(RVA = "0xB76B60", Offset = "0xB75D60", VA = "0x180B76B60", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007116")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x6007117")]
	[Address(RVA = "0xB77050", Offset = "0xB76250", VA = "0x180B77050")]
	private void stepInit(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007118")]
	[Address(RVA = "0xB774A0", Offset = "0xB766A0", VA = "0x180B774A0")]
	private void stepTweenPlay(StepSequencer seq, string tweenLabel, Step nextStep)
	{
	}

	[Token(Token = "0x6007119")]
	[Address(RVA = "0xB773E0", Offset = "0xB765E0", VA = "0x180B773E0")]
	private void stepLogoStay(StepSequencer seq)
	{
	}

	[Token(Token = "0x600711A")]
	[Address(RVA = "0xB76FC0", Offset = "0xB761C0", VA = "0x180B76FC0")]
	[IteratorStateMachine(typeof(_003CstepFinish_003Ed__13))]
	private IEnumerator stepFinish(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600711B")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public KonamiLogoViewController()
	{
	}
}
