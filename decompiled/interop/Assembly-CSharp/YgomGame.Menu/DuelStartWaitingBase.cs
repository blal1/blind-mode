using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Network;

namespace YgomGame.Menu;

[Token(Token = "0x20012A9")]
public abstract class DuelStartWaitingBase : MonoBehaviour
{
	[Token(Token = "0x20012AA")]
	[CompilerGenerated]
	private sealed class _003CyWaitPrevious_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BCDC")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BCDD")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BCDE")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x17001249")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007419")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700124A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600741B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007416")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitPrevious_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007417")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007418")]
		[Address(RVA = "0xBB9F10", Offset = "0xBB9110", VA = "0x180BB9F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600741A")]
		[Address(RVA = "0xBB9FB0", Offset = "0xBB91B0", VA = "0x180BB9FB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20012AB")]
	[CompilerGenerated]
	private sealed class _003CyWaitWaiting_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BCDF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BCE0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x1700124B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600741F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700124C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007421")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600741C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitWaiting_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600741D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600741E")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007420")]
		[Address(RVA = "0xBB9FF0", Offset = "0xBB91F0", VA = "0x180BB9FF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400BCD7")]
	[FieldOffset(Offset = "0x20")]
	private bool m_bComplete;

	[Token(Token = "0x400BCD8")]
	[FieldOffset(Offset = "0x24")]
	private int m_ErrorCode;

	[Token(Token = "0x400BCD9")]
	[FieldOffset(Offset = "0x28")]
	protected Handle m_Handle;

	[Token(Token = "0x400BCDA")]
	[FieldOffset(Offset = "0x30")]
	protected Dictionary<string, object> m_Result;

	[Token(Token = "0x400BCDB")]
	[FieldOffset(Offset = "0x38")]
	protected Dictionary<string, object> m_Param;

	[Token(Token = "0x17001246")]
	public bool IsComplete
	{
		[Token(Token = "0x6007407")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17001247")]
	public int ErrorCode
	{
		[Token(Token = "0x6007408")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007409")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		protected set
		{
		}
	}

	[Token(Token = "0x17001248")]
	public Dictionary<string, object> Result
	{
		[Token(Token = "0x600740A")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600740B")]
	[Address(RVA = "0xB9ED00", Offset = "0xB9DF00", VA = "0x180B9ED00", Slot = "4")]
	[IteratorStateMachine(typeof(_003CyWaitPrevious_003Ed__7))]
	public virtual IEnumerator yWaitPrevious(float time)
	{
		return null;
	}

	[Token(Token = "0x600740C")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
	public virtual void StartWaiting()
	{
	}

	[Token(Token = "0x600740D")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "6")]
	public virtual bool DispProgress()
	{
		return default(bool);
	}

	[Token(Token = "0x600740E")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "7")]
	public virtual int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x600740F")]
	[Address(RVA = "0xB9ED60", Offset = "0xB9DF60", VA = "0x180B9ED60", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitWaiting_003Ed__11))]
	public virtual IEnumerator yWaitWaiting(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007410")]
	[Address(RVA = "0xB9E9C0", Offset = "0xB9DBC0", VA = "0x180B9E9C0")]
	protected void OnCompleteWaiting(Handle e)
	{
	}

	[Token(Token = "0x6007411")]
	[Address(RVA = "0xB9EBB0", Offset = "0xB9DDB0", VA = "0x180B9EBB0")]
	protected void OnErrorWaiting(Handle e)
	{
	}

	[Token(Token = "0x6007412")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007413")]
	[Address(RVA = "0xB9EC50", Offset = "0xB9DE50", VA = "0x180B9EC50")]
	protected DuelStartWaitingBase()
	{
	}
}
