using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YgomGame.Download;

[Token(Token = "0x2000F87")]
public class TaskWebRequest : TaskBase
{
	[Token(Token = "0x2000F88")]
	public enum RequestType
	{
		[Token(Token = "0x400A89A")]
		Bytes,
		[Token(Token = "0x400A89B")]
		Text
	}

	[Token(Token = "0x2000F89")]
	[CompilerGenerated]
	private sealed class _003CyExec_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A89C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A89D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A89E")]
		[FieldOffset(Offset = "0x20")]
		public TaskWebRequest _003C_003E4__this;

		[Token(Token = "0x17000EDC")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E43")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EDD")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E45")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E40")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyExec_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E41")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E42")]
		[Address(RVA = "0xA4E110", Offset = "0xA4D310", VA = "0x180A4E110", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E44")]
		[Address(RVA = "0xA4E1A0", Offset = "0xA4D3A0", VA = "0x180A4E1A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000F8A")]
	[CompilerGenerated]
	private sealed class _003CyProgress_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A89F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A8A0")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A8A1")]
		[FieldOffset(Offset = "0x20")]
		public TaskWebRequest _003C_003E4__this;

		[Token(Token = "0x17000EDE")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E49")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EDF")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E4B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E46")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyProgress_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E47")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E48")]
		[Address(RVA = "0xA4E1E0", Offset = "0xA4D3E0", VA = "0x180A4E1E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E4A")]
		[Address(RVA = "0xA4E2C0", Offset = "0xA4D4C0", VA = "0x180A4E2C0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000F8B")]
	[CompilerGenerated]
	private sealed class _003CyRequest_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400A8A2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400A8A3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400A8A4")]
		[FieldOffset(Offset = "0x20")]
		public TaskWebRequest _003C_003E4__this;

		[Token(Token = "0x400A8A5")]
		[FieldOffset(Offset = "0x28")]
		private float _003CstartTime_003E5__2;

		[Token(Token = "0x400A8A6")]
		[FieldOffset(Offset = "0x2C")]
		private float _003CelapsedTime_003E5__3;

		[Token(Token = "0x400A8A7")]
		[FieldOffset(Offset = "0x30")]
		private bool _003CrequestAbort_003E5__4;

		[Token(Token = "0x400A8A8")]
		[FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003CwebReq_003E5__5;

		[Token(Token = "0x400A8A9")]
		[FieldOffset(Offset = "0x40")]
		private ulong _003CbeforeBytes_003E5__6;

		[Token(Token = "0x17000EE0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005E50")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000EE1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005E52")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6005E4C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CyRequest_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005E4D")]
		[Address(RVA = "0xA4EA30", Offset = "0xA4DC30", VA = "0x180A4EA30", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005E4E")]
		[Address(RVA = "0xA4E4D0", Offset = "0xA4D6D0", VA = "0x180A4E4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005E4F")]
		[Address(RVA = "0xA4EAC0", Offset = "0xA4DCC0", VA = "0x180A4EAC0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6005E51")]
		[Address(RVA = "0xA4E9F0", Offset = "0xA4DBF0", VA = "0x180A4E9F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400A88D")]
	private const float DownloadTimeOut = 60f;

	[Token(Token = "0x400A88E")]
	private const ulong kThresholdDLBytes = 1024uL;

	[Token(Token = "0x400A890")]
	[FieldOffset(Offset = "0x18")]
	protected string m_baseUrl;

	[Token(Token = "0x400A891")]
	[FieldOffset(Offset = "0x20")]
	protected string m_path;

	[Token(Token = "0x400A892")]
	[FieldOffset(Offset = "0x28")]
	protected RequestType m_requestType;

	[Token(Token = "0x400A893")]
	[FieldOffset(Offset = "0x30")]
	private IEnumerator m_executor;

	[Token(Token = "0x400A894")]
	[FieldOffset(Offset = "0x38")]
	protected bool m_success;

	[Token(Token = "0x400A895")]
	[FieldOffset(Offset = "0x39")]
	protected bool m_cancel;

	[Token(Token = "0x17000ED8")]
	protected virtual bool m_updateProgressTimeOut
	{
		[Token(Token = "0x6005E30")]
		[Address(RVA = "0x465880", Offset = "0x464A80", VA = "0x180465880", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000ED9")]
	public byte[] Bytes
	{
		[Token(Token = "0x6005E32")]
		[Address(RVA = "0x404850", Offset = "0x403A50", VA = "0x180404850")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005E33")]
		[Address(RVA = "0x595530", Offset = "0x594730", VA = "0x180595530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000EDA")]
	public string Text
	{
		[Token(Token = "0x6005E34")]
		[Address(RVA = "0x414E80", Offset = "0x414080", VA = "0x180414E80")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6005E35")]
		[Address(RVA = "0x414E90", Offset = "0x414090", VA = "0x180414E90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17000EDB")]
	public DownloadErrorCode errorCode
	{
		[Token(Token = "0x6005E36")]
		[Address(RVA = "0x49BD90", Offset = "0x49AF90", VA = "0x18049BD90")]
		[CompilerGenerated]
		get
		{
			return default(DownloadErrorCode);
		}
		[Token(Token = "0x6005E37")]
		[Address(RVA = "0x49C4A0", Offset = "0x49B6A0", VA = "0x18049C4A0")]
		[CompilerGenerated]
		protected set
		{
		}
	}

	[Token(Token = "0x6005E31")]
	[Address(RVA = "0xA4ACA0", Offset = "0xA49EA0", VA = "0x180A4ACA0")]
	public TaskWebRequest(string baseUrl, string path, RequestType requestType)
	{
	}

	[Token(Token = "0x6005E38")]
	[Address(RVA = "0xA4AC60", Offset = "0xA49E60", VA = "0x180A4AC60", Slot = "4")]
	public bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E39")]
	[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70", Slot = "9")]
	public virtual bool IsSuccess()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E3A")]
	[Address(RVA = "0xA4AC70", Offset = "0xA49E70", VA = "0x180A4AC70", Slot = "6")]
	public bool IsError()
	{
		return default(bool);
	}

	[Token(Token = "0x6005E3B")]
	[Address(RVA = "0xA4AB60", Offset = "0xA49D60", VA = "0x180A4AB60")]
	public void Cancel()
	{
	}

	[Token(Token = "0x6005E3C")]
	[Address(RVA = "0xA4AB70", Offset = "0xA49D70", VA = "0x180A4AB70", Slot = "7")]
	public void Exec()
	{
	}

	[Token(Token = "0x6005E3D")]
	[Address(RVA = "0xA4AD10", Offset = "0xA49F10", VA = "0x180A4AD10")]
	[IteratorStateMachine(typeof(_003CyExec_003Ed__30))]
	private IEnumerator yExec()
	{
		return null;
	}

	[Token(Token = "0x6005E3E")]
	[Address(RVA = "0xA4AD80", Offset = "0xA49F80", VA = "0x180A4AD80", Slot = "10")]
	[IteratorStateMachine(typeof(_003CyProgress_003Ed__31))]
	protected virtual IEnumerator yProgress()
	{
		return null;
	}

	[Token(Token = "0x6005E3F")]
	[Address(RVA = "0xA4ADF0", Offset = "0xA49FF0", VA = "0x180A4ADF0")]
	[IteratorStateMachine(typeof(_003CyRequest_003Ed__32))]
	protected IEnumerator yRequest()
	{
		return null;
	}
}
