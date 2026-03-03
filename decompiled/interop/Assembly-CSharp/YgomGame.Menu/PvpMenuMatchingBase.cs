using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomSystem.Network;

namespace YgomGame.Menu;

[Token(Token = "0x20013A9")]
public abstract class PvpMenuMatchingBase : MonoBehaviour
{
	[Token(Token = "0x20013AC")]
	[CompilerGenerated]
	private sealed class _003CyCancelMatching_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C371")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C372")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C373")]
		[FieldOffset(Offset = "0x20")]
		public PvpMenuMatchingBase _003C_003E4__this;

		[Token(Token = "0x170012CD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A55")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012CE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A57")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A52")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyCancelMatching_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A53")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A54")]
		[Address(RVA = "0xC51530", Offset = "0xC50730", VA = "0x180C51530", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A56")]
		[Address(RVA = "0xC517A0", Offset = "0xC509A0", VA = "0x180C517A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20013AD")]
	[CompilerGenerated]
	private sealed class _003CyWaitMatching_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C374")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C375")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170012CF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A5B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A5D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A58")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitMatching_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A59")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A5A")]
		[Address(RVA = "0x59F130", Offset = "0x59E330", VA = "0x18059F130", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A5C")]
		[Address(RVA = "0xC523A0", Offset = "0xC515A0", VA = "0x180C523A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20013AE")]
	[CompilerGenerated]
	private sealed class _003CyWaitPrevious_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400C376")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400C377")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400C378")]
		[FieldOffset(Offset = "0x20")]
		public float time;

		[Token(Token = "0x170012D1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007A61")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170012D2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007A63")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007A5E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyWaitPrevious_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007A5F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007A60")]
		[Address(RVA = "0xC53700", Offset = "0xC52900", VA = "0x180C53700", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007A62")]
		[Address(RVA = "0xC537A0", Offset = "0xC529A0", VA = "0x180C537A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400C366")]
	[FieldOffset(Offset = "0x20")]
	private bool m_bCompleteMatching;

	[Token(Token = "0x400C367")]
	[FieldOffset(Offset = "0x21")]
	private bool m_bRequestCancel;

	[Token(Token = "0x400C368")]
	[FieldOffset(Offset = "0x22")]
	private bool m_bStartMatching;

	[Token(Token = "0x400C369")]
	[FieldOffset(Offset = "0x24")]
	private int m_ErrorCode;

	[Token(Token = "0x400C36A")]
	[FieldOffset(Offset = "0x28")]
	private int m_CancelErrorCode;

	[Token(Token = "0x400C36B")]
	[FieldOffset(Offset = "0x30")]
	protected Handle m_Handle;

	[Token(Token = "0x400C36C")]
	[FieldOffset(Offset = "0x38")]
	protected Dictionary<string, object> m_MatchParam;

	[Token(Token = "0x170012C7")]
	public bool IsComplete
	{
		[Token(Token = "0x6007A32")]
		[Address(RVA = "0x416680", Offset = "0x415880", VA = "0x180416680")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007A33")]
		[Address(RVA = "0x4166E0", Offset = "0x4158E0", VA = "0x1804166E0")]
		protected set
		{
		}
	}

	[Token(Token = "0x170012C8")]
	public bool IsRequestCancel
	{
		[Token(Token = "0x6007A34")]
		[Address(RVA = "0x5D7890", Offset = "0x5D6A90", VA = "0x1805D7890")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170012C9")]
	public bool IsStartMatching
	{
		[Token(Token = "0x6007A35")]
		[Address(RVA = "0xC43D40", Offset = "0xC42F40", VA = "0x180C43D40")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x6007A36")]
		[Address(RVA = "0xC43D50", Offset = "0xC42F50", VA = "0x180C43D50")]
		protected set
		{
		}
	}

	[Token(Token = "0x170012CA")]
	public int ErrorCode
	{
		[Token(Token = "0x6007A37")]
		[Address(RVA = "0x416290", Offset = "0x415490", VA = "0x180416290")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007A38")]
		[Address(RVA = "0x416370", Offset = "0x415570", VA = "0x180416370")]
		protected set
		{
		}
	}

	[Token(Token = "0x170012CB")]
	public int CancelErrorCode
	{
		[Token(Token = "0x6007A39")]
		[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6007A3A")]
		[Address(RVA = "0x62E240", Offset = "0x62D440", VA = "0x18062E240")]
		protected set
		{
		}
	}

	[Token(Token = "0x170012CC")]
	public Handle Handle
	{
		[Token(Token = "0x6007A3B")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6007A3C")]
	[Address(RVA = "0xC43E20", Offset = "0xC43020", VA = "0x180C43E20", Slot = "4")]
	[IteratorStateMachine(typeof(_003CyWaitPrevious_003Ed__16))]
	public virtual IEnumerator yWaitPrevious(float time)
	{
		return null;
	}

	[Token(Token = "0x6007A3D")]
	[Address(RVA = "0xC43B70", Offset = "0xC42D70", VA = "0x180C43B70", Slot = "5")]
	public virtual void StartMatching(Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A3E")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "6")]
	public virtual bool DispProgress()
	{
		return default(bool);
	}

	[Token(Token = "0x6007A3F")]
	[Address(RVA = "0x3EF020", Offset = "0x3EE220", VA = "0x1803EF020", Slot = "7")]
	public virtual int ProgressCount()
	{
		return default(int);
	}

	[Token(Token = "0x6007A40")]
	[Address(RVA = "0xC43DD0", Offset = "0xC42FD0", VA = "0x180C43DD0", Slot = "8")]
	[IteratorStateMachine(typeof(_003CyWaitMatching_003Ed__20))]
	public virtual IEnumerator yWaitMatching(Action callback)
	{
		return null;
	}

	[Token(Token = "0x6007A41")]
	[Address(RVA = "0xC43D60", Offset = "0xC42F60", VA = "0x180C43D60", Slot = "9")]
	[IteratorStateMachine(typeof(_003CyCancelMatching_003Ed__21))]
	public virtual IEnumerator yCancelMatching()
	{
		return null;
	}

	[Token(Token = "0x6007A42")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	public virtual void SetBootDuelParam(ref Dictionary<string, object> param)
	{
	}

	[Token(Token = "0x6007A43")]
	[Address(RVA = "0xC43800", Offset = "0xC42A00", VA = "0x180C43800", Slot = "11")]
	public virtual void AbortMatching()
	{
	}

	[Token(Token = "0x6007A44")]
	[Address(RVA = "0xC43860", Offset = "0xC42A60", VA = "0x180C43860", Slot = "12")]
	protected virtual Handle CallAPIMatching(Dictionary<string, object> matchParam)
	{
		return null;
	}

	[Token(Token = "0x6007A45")]
	[Address(RVA = "0xC43A40", Offset = "0xC42C40", VA = "0x180C43A40")]
	protected void OnCompleteMatching(Handle e)
	{
	}

	[Token(Token = "0x6007A46")]
	[Address(RVA = "0xC43870", Offset = "0xC42A70", VA = "0x180C43870", Slot = "13")]
	protected virtual void OnCompleteMatchingHandle(Handle e)
	{
	}

	[Token(Token = "0x6007A47")]
	[Address(RVA = "0xC43AE0", Offset = "0xC42CE0", VA = "0x180C43AE0")]
	protected void OnErrorMatching(Handle e)
	{
	}

	[Token(Token = "0x6007A48")]
	[Address(RVA = "0xC43AC0", Offset = "0xC42CC0", VA = "0x180C43AC0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6007A49")]
	[Address(RVA = "0xC43CC0", Offset = "0xC42EC0", VA = "0x180C43CC0")]
	protected PvpMenuMatchingBase()
	{
	}
}
