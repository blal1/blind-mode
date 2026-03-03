using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YgomSystem.Network;

[Token(Token = "0x2000288")]
public class ProtocolHttpDeckExt : Protocol
{
	[Token(Token = "0x2000289")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x10")]
		public NetworkMain.RequestStructure data;

		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x18")]
		public ProtocolHttpDeckExt _003C_003E4__this;

		[Token(Token = "0x6000F7B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x6000F7C")]
		[Address(RVA = "0xE822A0", Offset = "0xE814A0", VA = "0x180E822A0")]
		internal void _003CExec_003Eb__0(object r)
		{
		}
	}

	[Token(Token = "0x200028A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		[Token(Token = "0x4000E86")]
		[FieldOffset(Offset = "0x10")]
		public int responseCode;

		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x18")]
		public _003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals1;

		[Token(Token = "0x6000F7D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[Token(Token = "0x6000F7E")]
		[Address(RVA = "0xE82570", Offset = "0xE81770", VA = "0x180E82570")]
		internal void _003CExec_003Eb__1(object r)
		{
		}
	}

	[Token(Token = "0x200028B")]
	[CompilerGenerated]
	private sealed class _003CExec_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000E88")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x20")]
		public NetworkMain.RequestStructure data;

		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0x28")]
		public ProtocolHttpDeckExt _003C_003E4__this;

		[Token(Token = "0x4000E8C")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass8_1 _003C_003E8__1;

		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003Cwww_003E5__2;

		[Token(Token = "0x4000E8E")]
		[FieldOffset(Offset = "0x40")]
		private float _003CendTime_003E5__3;

		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0x44")]
		private bool _003Crequest_abort_003E5__4;

		[Token(Token = "0x17000180")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000F83")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000181")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000F85")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000F7F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CExec_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000F80")]
		[Address(RVA = "0xE7F010", Offset = "0xE7E210", VA = "0x180E7F010", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000F81")]
		[Address(RVA = "0xE7E070", Offset = "0xE7D270", VA = "0x180E7E070", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000F82")]
		[Address(RVA = "0xE7F0A0", Offset = "0xE7E2A0", VA = "0x180E7F0A0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000F84")]
		[Address(RVA = "0xE7EFD0", Offset = "0xE7E1D0", VA = "0x180E7EFD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000E82")]
	[FieldOffset(Offset = "0x10")]
	private bool appQuitAbort;

	[Token(Token = "0x4000E83")]
	[FieldOffset(Offset = "0x14")]
	private int jobCount;

	[Token(Token = "0x6000F72")]
	[Address(RVA = "0xE72110", Offset = "0xE71310", VA = "0x180E72110")]
	private static Dictionary<string, object> GetUrl(string cmd)
	{
		return null;
	}

	[Token(Token = "0x6000F73")]
	[Address(RVA = "0xE72240", Offset = "0xE71440", VA = "0x180E72240")]
	private static Dictionary<string, object> GetUrls()
	{
		return null;
	}

	[Token(Token = "0x6000F74")]
	[Address(RVA = "0xE71E40", Offset = "0xE71040", VA = "0x180E71E40")]
	public static bool ContainsUrl(string cmd)
	{
		return default(bool);
	}

	[Token(Token = "0x6000F75")]
	[Address(RVA = "0xE71F70", Offset = "0xE71170", VA = "0x180E71F70")]
	public static string GetCommandName(string cmd)
	{
		return null;
	}

	[Token(Token = "0x6000F76")]
	[Address(RVA = "0x465890", Offset = "0x464A90", VA = "0x180465890", Slot = "5")]
	public override void ApplicationQuitAbort()
	{
	}

	[Token(Token = "0x6000F77")]
	[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770", Slot = "6")]
	public override int GetJobCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000F78")]
	[Address(RVA = "0xE71EE0", Offset = "0xE710E0", VA = "0x180E71EE0", Slot = "4")]
	[IteratorStateMachine(typeof(_003CExec_003Ed__8))]
	public override IEnumerator Exec(NetworkMain.RequestStructure data)
	{
		return null;
	}

	[Token(Token = "0x6000F79")]
	[Address(RVA = "0xE71DE0", Offset = "0xE70FE0", VA = "0x180E71DE0")]
	private void AbortRequest(NetworkMain.RequestStructure chaindata, Status states = Status.FAILED)
	{
	}

	[Token(Token = "0x6000F7A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ProtocolHttpDeckExt()
	{
	}
}
