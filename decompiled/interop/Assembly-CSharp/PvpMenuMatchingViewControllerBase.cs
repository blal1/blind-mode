using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomSystem.UI;

[Token(Token = "0x2000076")]
public abstract class PvpMenuMatchingViewControllerBase : BaseMenuViewController
{
	[Token(Token = "0x2000077")]
	[CompilerGenerated]
	private sealed class _003CStart_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400026E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400026F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000270")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewControllerBase _003C_003E4__this;

		[Token(Token = "0x1700002E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700002F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000233")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CStart_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000234")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000235")]
		[Address(RVA = "0x3FBCD0", Offset = "0x3FAED0", VA = "0x1803FBCD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000237")]
		[Address(RVA = "0x3FBDB0", Offset = "0x3FAFB0", VA = "0x1803FBDB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000078")]
	[CompilerGenerated]
	private sealed class _003CyCancelMatching_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000271")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000272")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000273")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewControllerBase _003C_003E4__this;

		[Token(Token = "0x17000030")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600023C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000031")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600023E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000239")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCancelMatching_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600023A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600023B")]
		[Address(RVA = "0x3FD0E0", Offset = "0x3FC2E0", VA = "0x1803FD0E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600023D")]
		[Address(RVA = "0x3FD300", Offset = "0x3FC500", VA = "0x1803FD300", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000079")]
	[CompilerGenerated]
	private sealed class _003CyInit_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000274")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000275")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000276")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewControllerBase _003C_003E4__this;

		[Token(Token = "0x17000032")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000242")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000033")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600023F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyInit_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000240")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000241")]
		[Address(RVA = "0x3FD340", Offset = "0x3FC540", VA = "0x1803FD340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000243")]
		[Address(RVA = "0x3FDAD0", Offset = "0x3FCCD0", VA = "0x1803FDAD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200007A")]
	[CompilerGenerated]
	private sealed class _003CyStopByFatalError_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewControllerBase _003C_003E4__this;

		[Token(Token = "0x17000034")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000035")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000245")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyStopByFatalError_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000246")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000247")]
		[Address(RVA = "0x400AD0", Offset = "0x3FFCD0", VA = "0x180400AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000249")]
		[Address(RVA = "0x400C40", Offset = "0x3FFE40", VA = "0x180400C40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000264")]
	[FieldOffset(Offset = "0xD0")]
	protected bool m_bInit;

	[Token(Token = "0x4000265")]
	[FieldOffset(Offset = "0xD1")]
	protected bool m_bAbort;

	[Token(Token = "0x4000266")]
	[FieldOffset(Offset = "0xD2")]
	protected bool m_bStartDuel;

	[Token(Token = "0x4000267")]
	[FieldOffset(Offset = "0xD4")]
	protected PvpMenuDefine.MatchingType m_MatchingType;

	[Token(Token = "0x4000268")]
	[FieldOffset(Offset = "0xD8")]
	protected Dictionary<string, object> m_MatchingParam;

	[Token(Token = "0x4000269")]
	[FieldOffset(Offset = "0xE0")]
	protected Dictionary<string, object> m_DuelParam;

	[Token(Token = "0x400026A")]
	[FieldOffset(Offset = "0xE8")]
	protected PvpMenuMatchingBase m_MatchingComponent;

	[Token(Token = "0x400026B")]
	[FieldOffset(Offset = "0xF0")]
	protected IEnumerator m_MatchingCoroutine;

	[Token(Token = "0x400026C")]
	[FieldOffset(Offset = "0xF8")]
	protected IEnumerator m_AbortCoroutine;

	[Token(Token = "0x400026D")]
	[FieldOffset(Offset = "0x100")]
	private int showProgressCount;

	[Token(Token = "0x1700002D")]
	public int ShowProgressCount
	{
		[Token(Token = "0x6000222")]
		[Address(RVA = "0x3F4B30", Offset = "0x3F3D30", VA = "0x1803F4B30")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6000223")]
		[Address(RVA = "0x3F4B40", Offset = "0x3F3D40", VA = "0x1803F4B40")]
		set
		{
		}
	}

	[Token(Token = "0x6000221")]
	[Address(RVA = "0x3F4790", Offset = "0x3F3990", VA = "0x1803F4790")]
	public static bool ExistsMathingView(ViewControllerManager manager)
	{
		return default(bool);
	}

	[Token(Token = "0x6000224")]
	protected abstract IEnumerator yMatch();

	[Token(Token = "0x6000225")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "29")]
	protected virtual void Init()
	{
	}

	[Token(Token = "0x6000226")]
	[Address(RVA = "0x3F4850", Offset = "0x3F3A50", VA = "0x1803F4850", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6000227")]
	[Address(RVA = "0x3F48D0", Offset = "0x3F3AD0", VA = "0x1803F48D0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6000228")]
	[Address(RVA = "0x3F49E0", Offset = "0x3F3BE0", VA = "0x1803F49E0")]
	[IteratorStateMachine(typeof(_003CStart_003Ed__18))]
	private IEnumerator Start()
	{
		return null;
	}

	[Token(Token = "0x6000229")]
	[Address(RVA = "0x3F4BC0", Offset = "0x3F3DC0", VA = "0x1803F4BC0")]
	[IteratorStateMachine(typeof(_003CyInit_003Ed__19))]
	protected IEnumerator yInit()
	{
		return null;
	}

	[Token(Token = "0x600022A")]
	[Address(RVA = "0x3F4B50", Offset = "0x3F3D50", VA = "0x1803F4B50")]
	[IteratorStateMachine(typeof(_003CyCancelMatching_003Ed__20))]
	protected IEnumerator yCancelMatching()
	{
		return null;
	}

	[Token(Token = "0x600022B")]
	[Address(RVA = "0x3F4C30", Offset = "0x3F3E30", VA = "0x1803F4C30")]
	[IteratorStateMachine(typeof(_003CyStopByFatalError_003Ed__21))]
	protected IEnumerator yStopByFatalError()
	{
		return null;
	}

	[Token(Token = "0x600022C")]
	[Address(RVA = "0x3F4980", Offset = "0x3F3B80", VA = "0x1803F4980")]
	protected void ShowSystemProgress()
	{
	}

	[Token(Token = "0x600022D")]
	[Address(RVA = "0x3F4820", Offset = "0x3F3A20", VA = "0x1803F4820")]
	protected void HideSystemProgress()
	{
	}

	[Token(Token = "0x600022E")]
	[Address(RVA = "0x3F4930", Offset = "0x3F3B30", VA = "0x1803F4930")]
	private void ResetProgress()
	{
	}

	[Token(Token = "0x600022F")]
	[Address(RVA = "0x3F4A50", Offset = "0x3F3C50", VA = "0x1803F4A50")]
	public Coroutine WrapStartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Token(Token = "0x6000230")]
	[Address(RVA = "0x3F4A60", Offset = "0x3F3C60", VA = "0x1803F4A60")]
	public void WrapStopCoroutine(IEnumerator routine)
	{
	}

	[Token(Token = "0x6000231")]
	[Address(RVA = "0x3F4A70", Offset = "0x3F3C70", VA = "0x1803F4A70")]
	protected PvpMenuMatchingViewControllerBase()
	{
	}
}
