using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x2000083")]
public class PvpMenuMatchingViewController_WcsFinal : PvpMenuMatchingViewControllerBase
{
	[Token(Token = "0x2000084")]
	private enum View
	{
		[Token(Token = "0x40002A3")]
		INIT,
		[Token(Token = "0x40002A4")]
		SEARCHING,
		[Token(Token = "0x40002A5")]
		MATCHING,
		[Token(Token = "0x40002A6")]
		TIMEOUT
	}

	[Token(Token = "0x2000085")]
	[CompilerGenerated]
	private sealed class _003CyMatch_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController_WcsFinal _003C_003E4__this;

		[Token(Token = "0x40002AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnumerator _003CieWaitMatching_003E5__2;

		[Token(Token = "0x17000041")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000291")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000042")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000293")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600028E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMatch_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600028F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000290")]
		[Address(RVA = "0x3FE5F0", Offset = "0x3FD7F0", VA = "0x1803FE5F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000292")]
		[Address(RVA = "0x3FEC60", Offset = "0x3FDE60", VA = "0x1803FEC60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000086")]
	[CompilerGenerated]
	private sealed class _003CyPopView_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x40002AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x40002AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x40002AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController_WcsFinal _003C_003E4__this;

		[Token(Token = "0x40002AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003CpastSec_003E5__2;

		[Token(Token = "0x17000043")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000297")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000044")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000299")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000294")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPopView_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000295")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000296")]
		[Address(RVA = "0x400060", Offset = "0x3FF260", VA = "0x180400060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000298")]
		[Address(RVA = "0x4005A0", Offset = "0x3FF7A0", VA = "0x1804005A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400029D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string BTN_CANCEL_LABEL;

	[Token(Token = "0x400029E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool m_bCalledPop;

	[Token(Token = "0x400029F")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private IEnumerator m_yPopViewRoutine;

	[Token(Token = "0x40002A0")]
	private const float LIMIT_POP_TIME = 15f;

	[Token(Token = "0x40002A1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private View m_currentView;

	[Token(Token = "0x17000040")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6000280")]
		[Address(RVA = "0x3F7770", Offset = "0x3F6970", VA = "0x1803F7770", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000281")]
	[Address(RVA = "0x3F7450", Offset = "0x3F6650", VA = "0x1803F7450", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x6000282")]
	[Address(RVA = "0x3F5E10", Offset = "0x3F5010", VA = "0x1803F5E10", Slot = "29")]
	protected override void Init()
	{
	}

	[Token(Token = "0x6000283")]
	[Address(RVA = "0x3F7840", Offset = "0x3F6A40", VA = "0x1803F7840", Slot = "28")]
	[IteratorStateMachine(typeof(_003CyMatch_003Ed__10))]
	protected override IEnumerator yMatch()
	{
		return null;
	}

	[Token(Token = "0x6000284")]
	[Address(RVA = "0x3F7510", Offset = "0x3F6710", VA = "0x1803F7510")]
	private void Update()
	{
	}

	[Token(Token = "0x6000285")]
	[Address(RVA = "0x3F72D0", Offset = "0x3F64D0", VA = "0x1803F72D0")]
	public void OnClickBackButton()
	{
	}

	[Token(Token = "0x6000286")]
	[Address(RVA = "0x3F78B0", Offset = "0x3F6AB0", VA = "0x1803F78B0")]
	[IteratorStateMachine(typeof(_003CyPopView_003Ed__13))]
	private IEnumerator yPopView()
	{
		return null;
	}

	[Token(Token = "0x6000287")]
	[Address(RVA = "0x3F6060", Offset = "0x3F5260", VA = "0x1803F6060")]
	private void PopViewControllerSafety([Optional] UnityAction onSafetyPopAction)
	{
	}

	[Token(Token = "0x6000288")]
	[Address(RVA = "0x3F7710", Offset = "0x3F6910", VA = "0x1803F7710")]
	public PvpMenuMatchingViewController_WcsFinal()
	{
	}
}
