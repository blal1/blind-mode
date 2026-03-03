using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem;
using YgomSystem.ElementSystem;
using YgomSystem.Timeline;
using YgomSystem.UI;

namespace YgomGame.Tdy;

[Token(Token = "0x2000843")]
public abstract class TdyCutInViewController : BaseMenuViewController
{
	[Token(Token = "0x2000844")]
	private enum Step
	{
		[Token(Token = "0x40085B4")]
		Play
	}

	[Token(Token = "0x2000846")]
	[CompilerGenerated]
	private sealed class _003CpostProcessTimelineLoad_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085B7")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085B8")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x17000641")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003277")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000642")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003279")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003274")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CpostProcessTimelineLoad_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003275")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003276")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003278")]
		[Address(RVA = "0x75D710", Offset = "0x75C910", VA = "0x18075D710", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000847")]
	[CompilerGenerated]
	private sealed class _003CstepPlay_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085B9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085BA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40085BB")]
		[FieldOffset(Offset = "0x20")]
		public TdyCutInViewController _003C_003E4__this;

		[Token(Token = "0x40085BC")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x17000643")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600327D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000644")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600327F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600327A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepPlay_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600327B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600327C")]
		[Address(RVA = "0x75DA10", Offset = "0x75CC10", VA = "0x18075DA10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600327E")]
		[Address(RVA = "0x75DF10", Offset = "0x75D110", VA = "0x18075DF10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000848")]
	[CompilerGenerated]
	private sealed class _003CwaitForCutInLoad_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085BD")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085BE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40085BF")]
		[FieldOffset(Offset = "0x20")]
		public TdyCutInViewController _003C_003E4__this;

		[Token(Token = "0x17000645")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003283")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000646")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003285")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003280")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitForCutInLoad_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003281")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003282")]
		[Address(RVA = "0x75E670", Offset = "0x75D870", VA = "0x18075E670", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003284")]
		[Address(RVA = "0x75E960", Offset = "0x75DB60", VA = "0x18075E960", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000849")]
	[CompilerGenerated]
	private sealed class _003CwaitForCutInPlay_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085C0")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085C1")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40085C2")]
		[FieldOffset(Offset = "0x20")]
		public TdyCutInViewController _003C_003E4__this;

		[Token(Token = "0x40085C3")]
		[FieldOffset(Offset = "0x28")]
		private double _003Ctl_dialog_time_003E5__2;

		[Token(Token = "0x17000647")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6003289")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000648")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600328B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6003286")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitForCutInPlay_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6003287")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6003288")]
		[Address(RVA = "0x75E9A0", Offset = "0x75DBA0", VA = "0x18075E9A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600328A")]
		[Address(RVA = "0x75EBE0", Offset = "0x75DDE0", VA = "0x18075EBE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200084A")]
	[CompilerGenerated]
	private sealed class _003CwaitForOKClick_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40085C4")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40085C5")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40085C6")]
		[FieldOffset(Offset = "0x20")]
		public TdyCutInViewController _003C_003E4__this;

		[Token(Token = "0x17000649")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600328F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700064A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6003291")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600328C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CwaitForOKClick_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600328D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600328E")]
		[Address(RVA = "0x75EC20", Offset = "0x75DE20", VA = "0x18075EC20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6003290")]
		[Address(RVA = "0x75ED50", Offset = "0x75DF50", VA = "0x18075ED50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x40085A6")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x40085A7")]
	[FieldOffset(Offset = "0xD8")]
	private PlayEffectDesc m_desc;

	[Token(Token = "0x40085A8")]
	[FieldOffset(Offset = "0xE0")]
	private TimelineObject m_cutinTMObj;

	[Token(Token = "0x40085A9")]
	[FieldOffset(Offset = "0xE8")]
	private ElementObjectManager m_cutinEOM;

	[Token(Token = "0x40085AA")]
	[FieldOffset(Offset = "0xF0")]
	private bool m_clickSkip;

	[Token(Token = "0x40085AB")]
	[FieldOffset(Offset = "0xF1")]
	private bool m_clickBack;

	[Token(Token = "0x40085AC")]
	[FieldOffset(Offset = "0xF2")]
	private bool m_clickOK;

	[Token(Token = "0x40085AD")]
	private const string LABEL_BTN_OK = "ButtonOK";

	[Token(Token = "0x40085AE")]
	private const string LABEL_BTN_SKIP = "ButtonSkip";

	[Token(Token = "0x40085AF")]
	private const string LABEL_FADEMASK = "FadeMask";

	[Token(Token = "0x40085B0")]
	[FieldOffset(Offset = "0xF8")]
	private SelectionButton m_buttonOK;

	[Token(Token = "0x40085B1")]
	[FieldOffset(Offset = "0x100")]
	private SelectionButton m_buttonSkip;

	[Token(Token = "0x40085B2")]
	[FieldOffset(Offset = "0x108")]
	private GameObject m_maskObj;

	[Token(Token = "0x17000640")]
	protected PlayEffectDesc currentDesc
	{
		[Token(Token = "0x6003258")]
		[Address(RVA = "0x5961F0", Offset = "0x5953F0", VA = "0x1805961F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6003259")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	protected void debugLog(string msg)
	{
	}

	[Token(Token = "0x600325A")]
	[Address(RVA = "0x755040", Offset = "0x754240", VA = "0x180755040", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x600325B")]
	[Address(RVA = "0x7551E0", Offset = "0x7543E0", VA = "0x1807551E0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600325C")]
	[Address(RVA = "0x7551A0", Offset = "0x7543A0", VA = "0x1807551A0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x600325D")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x600325E")]
	[Address(RVA = "0x755860", Offset = "0x754A60", VA = "0x180755860")]
	[IteratorStateMachine(typeof(_003CstepPlay_003Ed__21))]
	private IEnumerator stepPlay(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600325F")]
	[Address(RVA = "0x755820", Offset = "0x754A20", VA = "0x180755820")]
	private void setPostEffect(bool enable)
	{
	}

	[Token(Token = "0x6003260")]
	[Address(RVA = "0x7558F0", Offset = "0x754AF0", VA = "0x1807558F0")]
	[IteratorStateMachine(typeof(_003CwaitForCutInLoad_003Ed__23))]
	private IEnumerator waitForCutInLoad()
	{
		return null;
	}

	[Token(Token = "0x6003261")]
	[Address(RVA = "0x755960", Offset = "0x754B60", VA = "0x180755960")]
	[IteratorStateMachine(typeof(_003CwaitForCutInPlay_003Ed__24))]
	private IEnumerator waitForCutInPlay()
	{
		return null;
	}

	[Token(Token = "0x6003262")]
	[Address(RVA = "0x7559D0", Offset = "0x754BD0", VA = "0x1807559D0")]
	[IteratorStateMachine(typeof(_003CwaitForOKClick_003Ed__25))]
	private IEnumerator waitForOKClick()
	{
		return null;
	}

	[Token(Token = "0x6003263")]
	[Address(RVA = "0x755600", Offset = "0x754800", VA = "0x180755600")]
	protected void setKizunaIcon(int kizunaID, KizunaStatus st)
	{
	}

	[Token(Token = "0x6003264")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "28")]
	protected virtual void onStackEntry()
	{
	}

	[Token(Token = "0x6003265")]
	protected abstract PlayEffectDesc getPlayDesc();

	[Token(Token = "0x6003266")]
	protected abstract string getTimelinePrefabPath();

	[Token(Token = "0x6003267")]
	[Address(RVA = "0x7555B0", Offset = "0x7547B0", VA = "0x1807555B0", Slot = "31")]
	[IteratorStateMachine(typeof(_003CpostProcessTimelineLoad_003Ed__30))]
	protected virtual IEnumerator postProcessTimelineLoad(ElementObjectManager eom)
	{
		return null;
	}

	[Token(Token = "0x6003268")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "32")]
	protected virtual void onTimelineLoadFinish(ElementObjectManager eom)
	{
	}

	[Token(Token = "0x6003269")]
	protected abstract IEnumerator waitForConfirmationDialogs();

	[Token(Token = "0x600326A")]
	protected abstract void onEnd();

	[Token(Token = "0x600326B")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	protected TdyCutInViewController()
	{
	}
}
