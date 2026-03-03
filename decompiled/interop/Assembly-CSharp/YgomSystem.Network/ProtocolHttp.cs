using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;
using YgomSystem.Utility;

namespace YgomSystem.Network;

[Token(Token = "0x2000285")]
public class ProtocolHttp : Protocol
{
	[Token(Token = "0x2000286")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x10")]
		public NetworkMain.RequestStructure data;

		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x18")]
		public ProtocolHttp _003C_003E4__this;

		[Token(Token = "0x6000F69")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6000F6A")]
		[Address(RVA = "0xE818E0", Offset = "0xE80AE0", VA = "0x180E818E0")]
		internal void _003CExec_003Eb__0(Dictionary<string, object> obj)
		{
		}
	}

	[Token(Token = "0x2000287")]
	[CompilerGenerated]
	private sealed class _003CExec_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x20")]
		public NetworkMain.RequestStructure data;

		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x28")]
		public ProtocolHttp _003C_003E4__this;

		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003Cwww_003E5__2;

		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x40")]
		private float _003CendTime_003E5__3;

		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x44")]
		private bool _003Crequest_abort_003E5__4;

		[Token(Token = "0x1700017E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F6F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700017F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F71")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F6B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CExec_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F6C")]
		[Address(RVA = "0xE7DF90", Offset = "0xE7D190", VA = "0x180E7DF90", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F6D")]
		[Address(RVA = "0xE7C740", Offset = "0xE7B940", VA = "0x180E7C740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F6E")]
		[Address(RVA = "0xE7E020", Offset = "0xE7D220", VA = "0x180E7E020")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000F70")]
		[Address(RVA = "0xE7DF50", Offset = "0xE7D150", VA = "0x180E7DF50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000E76")]
	[FieldOffset(Offset = "0x10")]
	private bool appQuitAbort;

	[Token(Token = "0x4000E77")]
	[FieldOffset(Offset = "0x14")]
	private int jobCount;

	[Token(Token = "0x6000F61")]
	[Address(RVA = "0xE72390", Offset = "0xE71590", VA = "0x180E72390")]
	public static void GetServerDefaultUrl(RuntimeEnvironment.ServerType type, out string url, out string pollingUrl)
	{
	}

	[Token(Token = "0x6000F62")]
	[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890", Slot = "5")]
	public override void ApplicationQuitAbort()
	{
	}

	[Token(Token = "0x6000F63")]
	[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
	public override int GetJobCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000F64")]
	[Address(RVA = "0xE72300", Offset = "0xE71500", VA = "0x180E72300", Slot = "4")]
	[IteratorStateMachine(typeof(_003CExec_003Ed__5))]
	public override IEnumerator Exec(NetworkMain.RequestStructure data)
	{
		return null;
	}

	[Token(Token = "0x6000F65")]
	[Address(RVA = "0xE722A0", Offset = "0xE714A0", VA = "0x180E722A0")]
	private void AbortRequest(NetworkMain.RequestStructure chaindata, Status states = Status.FAILED)
	{
	}

	[Token(Token = "0x6000F66")]
	[Address(RVA = "0xE72440", Offset = "0xE71640", VA = "0x180E72440")]
	private static bool isRebootableCode(int code)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F67")]
	[Address(RVA = "0xE72460", Offset = "0xE71660", VA = "0x180E72460")]
	private static void postProcessRequestData(NetworkMain.RequestStructure data)
	{
	}

	[Token(Token = "0x6000F68")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ProtocolHttp()
	{
	}
}
