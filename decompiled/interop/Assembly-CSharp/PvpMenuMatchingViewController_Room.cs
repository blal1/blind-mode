using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Events;

[Token(Token = "0x200007B")]
public class PvpMenuMatchingViewController_Room : PvpMenuMatchingViewControllerBase
{
	[Token(Token = "0x200007C")]
	private enum View
	{
		[Token(Token = "0x4000280")]
		INIT,
		[Token(Token = "0x4000281")]
		SEARCHING,
		[Token(Token = "0x4000282")]
		MATCHING,
		[Token(Token = "0x4000283")]
		TIMEOUT
	}

	[Token(Token = "0x200007D")]
	[CompilerGenerated]
	private sealed class _003CyMatch_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000284")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000285")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000286")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController_Room _003C_003E4__this;

		[Token(Token = "0x4000287")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private IEnumerator _003CieWaitMatching_003E5__2;

		[Token(Token = "0x17000037")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600025C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000038")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600025E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000259")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyMatch_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600025A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600025B")]
		[Address(RVA = "0x3FDED0", Offset = "0x3FD0D0", VA = "0x1803FDED0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600025D")]
		[Address(RVA = "0x3FEC20", Offset = "0x3FDE20", VA = "0x1803FEC20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200007E")]
	[CompilerGenerated]
	private sealed class _003CyPopView_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000289")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400028A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingViewController_Room _003C_003E4__this;

		[Token(Token = "0x400028B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private float _003CpastSec_003E5__2;

		[Token(Token = "0x17000039")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000262")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700003A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600025F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyPopView_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000260")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000261")]
		[Address(RVA = "0x4002E0", Offset = "0x3FF4E0", VA = "0x1804002E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000263")]
		[Address(RVA = "0x400560", Offset = "0x3FF760", VA = "0x180400560", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400027A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
	private readonly string BTN_CANCEL_LABEL;

	[Token(Token = "0x400027B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
	private bool m_bCalledPop;

	[Token(Token = "0x400027C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
	private IEnumerator m_yPopViewRoutine;

	[Token(Token = "0x400027D")]
	private const float LIMIT_POP_TIME = 15f;

	[Token(Token = "0x400027E")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
	private View m_currentView;

	[Token(Token = "0x17000036")]
	protected override Type[] textIds
	{
		[Token(Token = "0x600024B")]
		[Address(RVA = "0x3F6380", Offset = "0x3F5580", VA = "0x1803F6380", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600024C")]
	[Address(RVA = "0x3F5FA0", Offset = "0x3F51A0", VA = "0x1803F5FA0", Slot = "23")]
	protected override void OnCreatedView()
	{
	}

	[Token(Token = "0x600024D")]
	[Address(RVA = "0x3F5E10", Offset = "0x3F5010", VA = "0x1803F5E10", Slot = "29")]
	protected override void Init()
	{
	}

	[Token(Token = "0x600024E")]
	[Address(RVA = "0x3F6450", Offset = "0x3F5650", VA = "0x1803F6450", Slot = "28")]
	[IteratorStateMachine(typeof(_003CyMatch_003Ed__10))]
	protected override IEnumerator yMatch()
	{
		return null;
	}

	[Token(Token = "0x600024F")]
	[Address(RVA = "0x3F6120", Offset = "0x3F5320", VA = "0x1803F6120")]
	private void Update()
	{
	}

	[Token(Token = "0x6000250")]
	[Address(RVA = "0x3F5E20", Offset = "0x3F5020", VA = "0x1803F5E20")]
	public void OnClickBackButton()
	{
	}

	[Token(Token = "0x6000251")]
	[Address(RVA = "0x3F64C0", Offset = "0x3F56C0", VA = "0x1803F64C0")]
	[IteratorStateMachine(typeof(_003CyPopView_003Ed__13))]
	private IEnumerator yPopView()
	{
		return null;
	}

	[Token(Token = "0x6000252")]
	[Address(RVA = "0x3F6060", Offset = "0x3F5260", VA = "0x1803F6060")]
	private void PopViewControllerSafety([Optional] UnityAction onSafetyPopAction)
	{
	}

	[Token(Token = "0x6000253")]
	[Address(RVA = "0x3F6320", Offset = "0x3F5520", VA = "0x1803F6320")]
	public PvpMenuMatchingViewController_Room()
	{
	}
}
