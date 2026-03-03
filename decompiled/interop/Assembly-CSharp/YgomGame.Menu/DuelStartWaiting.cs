using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20012A7")]
public class DuelStartWaiting : DuelStartWaitingBase
{
	[Token(Token = "0x20012A8")]
	[CompilerGenerated]
	private sealed class _003CyWaitWaiting_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BCD3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BCD4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BCD5")]
		[FieldOffset(Offset = "0x20")]
		public DuelStartWaiting _003C_003E4__this;

		[Token(Token = "0x400BCD6")]
		[FieldOffset(Offset = "0x28")]
		public Action callback;

		[Token(Token = "0x17001244")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007404")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001245")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007406")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007401")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitWaiting_003Ed__2(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007402")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007403")]
		[Address(RVA = "0xBBA030", Offset = "0xBB9230", VA = "0x180BBA030", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007405")]
		[Address(RVA = "0xBBA2A0", Offset = "0xBB94A0", VA = "0x180BBA2A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BCD2")]
	[FieldOffset(Offset = "0x40")]
	private float m_ProgressCount;

	[Token(Token = "0x60073FB")]
	[Address(RVA = "0xB9EDB0", Offset = "0xB9DFB0", VA = "0x180B9EDB0", Slot = "7")]
	public override int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x60073FC")]
	[Address(RVA = "0xB9EE10", Offset = "0xB9E010", VA = "0x180B9EE10", Slot = "5")]
	public override void StartWaiting()
	{
	}

	[Token(Token = "0x60073FD")]
	[Address(RVA = "0xB9EF00", Offset = "0xB9E100", VA = "0x180B9EF00", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitWaiting_003Ed__2))]
	public override IEnumerator yWaitWaiting(Action callback)
	{
		return null;
	}

	[Token(Token = "0x60073FE")]
	[Address(RVA = "0xB9EC50", Offset = "0xB9DE50", VA = "0x180B9EC50")]
	public DuelStartWaiting()
	{
	}
}
