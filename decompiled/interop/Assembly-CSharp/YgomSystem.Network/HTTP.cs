using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Networking;

namespace YgomSystem.Network;

[Token(Token = "0x200028C")]
public class HTTP : PvP.Implement
{
	[Token(Token = "0x200028D")]
	[CompilerGenerated]
	private sealed class _003CExec_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000EA3")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4000EA4")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4000EA5")]
		[FieldOffset(Offset = "0x20")]
		public PvP.Event val;

		[Token(Token = "0x4000EA6")]
		[FieldOffset(Offset = "0x28")]
		public HTTP _003C_003E4__this;

		[Token(Token = "0x4000EA7")]
		[FieldOffset(Offset = "0x30")]
		private float _003Cwaittime_003E5__2;

		[Token(Token = "0x4000EA8")]
		[FieldOffset(Offset = "0x34")]
		private bool _003Crequest_abort_003E5__3;

		[Token(Token = "0x4000EA9")]
		[FieldOffset(Offset = "0x38")]
		private UnityWebRequest _003Cwww_003E5__4;

		[Token(Token = "0x4000EAA")]
		[FieldOffset(Offset = "0x40")]
		private float _003CendTime_003E5__5;

		[Token(Token = "0x4000EAB")]
		[FieldOffset(Offset = "0x44")]
		private bool _003CRequestStop_003E5__6;

		[Token(Token = "0x17000182")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6000FA5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000183")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6000FA7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000FA1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CExec_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000FA2")]
		[Address(RVA = "0xE7C660", Offset = "0xE7B860", VA = "0x180E7C660", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6000FA3")]
		[Address(RVA = "0xE7B0A0", Offset = "0xE7A2A0", VA = "0x180E7B0A0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000FA4")]
		[Address(RVA = "0xE7C6F0", Offset = "0xE7B8F0", VA = "0x180E7C6F0")]
		private void _003C_003Em__Finally1()
		{
		}

		[Token(Token = "0x6000FA6")]
		[Address(RVA = "0xE7C620", Offset = "0xE7B820", VA = "0x180E7C620", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4000E90")]
	[FieldOffset(Offset = "0x18")]
	private Queue<PvP.Event> send_queue;

	[Token(Token = "0x4000E91")]
	[FieldOffset(Offset = "0x20")]
	private Queue<PvP.Event> app_queue;

	[Token(Token = "0x4000E92")]
	[FieldOffset(Offset = "0x28")]
	private int connection_id;

	[Token(Token = "0x4000E93")]
	[FieldOffset(Offset = "0x30")]
	private int[] members;

	[Token(Token = "0x4000E94")]
	[FieldOffset(Offset = "0x38")]
	private string entry_url;

	[Token(Token = "0x4000E95")]
	[FieldOffset(Offset = "0x40")]
	private string entry_ticket;

	[Token(Token = "0x4000E96")]
	[FieldOffset(Offset = "0x48")]
	private bool is_poll;

	[Token(Token = "0x4000E97")]
	[FieldOffset(Offset = "0x49")]
	private bool is_entried;

	[Token(Token = "0x4000E98")]
	[FieldOffset(Offset = "0x50")]
	private PvP.EventHandler completeHandler;

	[Token(Token = "0x4000E99")]
	[FieldOffset(Offset = "0x58")]
	private PvP.EventHandler errorHandler;

	[Token(Token = "0x4000E9A")]
	[FieldOffset(Offset = "0x60")]
	private PvP.EventHandler fatalHandler;

	[Token(Token = "0x4000E9B")]
	[FieldOffset(Offset = "0x68")]
	private PvP.EventHandler recvHandler;

	[Token(Token = "0x4000E9C")]
	[FieldOffset(Offset = "0x70")]
	private uint received_serial;

	[Token(Token = "0x4000E9D")]
	[FieldOffset(Offset = "0x78")]
	private List<PvP.Event> evlist;

	[Token(Token = "0x4000E9E")]
	[FieldOffset(Offset = "0x80")]
	private bool closed;

	[Token(Token = "0x4000E9F")]
	[FieldOffset(Offset = "0x88")]
	private byte[] pollData;

	[Token(Token = "0x4000EA0")]
	[FieldOffset(Offset = "0x90")]
	private bool appQuitAbort;

	[Token(Token = "0x4000EA1")]
	[FieldOffset(Offset = "0x94")]
	private int jobCount;

	[Token(Token = "0x4000EA2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] dummy_bytes;

	[Token(Token = "0x6000F86")]
	[Address(RVA = "0xE6EF00", Offset = "0xE6E100", VA = "0x180E6EF00")]
	public HTTP()
	{
	}

	[Token(Token = "0x6000F87")]
	[Address(RVA = "0xE6E9B0", Offset = "0xE6DBB0", VA = "0x180E6E9B0", Slot = "4")]
	public override void Connect(string url, string ticket, int port)
	{
	}

	[Token(Token = "0x6000F88")]
	[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210", Slot = "11")]
	public override int GetConnectionID()
	{
		return default(int);
	}

	[Token(Token = "0x6000F89")]
	[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0", Slot = "12")]
	public override int[] GetMembers()
	{
		return null;
	}

	[Token(Token = "0x6000F8A")]
	[Address(RVA = "0xE6EDD0", Offset = "0xE6DFD0", VA = "0x180E6EDD0", Slot = "13")]
	public override void Send(PvP.Command cmd, byte[] bin, uint serial)
	{
	}

	[Token(Token = "0x6000F8B")]
	[Address(RVA = "0xE6ED70", Offset = "0xE6DF70", VA = "0x180E6ED70", Slot = "14")]
	public override void Send(PvP.Event ev)
	{
	}

	[Token(Token = "0x6000F8C")]
	[Address(RVA = "0xE6EC70", Offset = "0xE6DE70", VA = "0x180E6EC70", Slot = "15")]
	public override PvP.Event Recv()
	{
		return null;
	}

	[Token(Token = "0x6000F8D")]
	[Address(RVA = "0xE6E900", Offset = "0xE6DB00", VA = "0x180E6E900", Slot = "10")]
	public override void Close()
	{
	}

	[Token(Token = "0x6000F8E")]
	[Address(RVA = "0xE6EC00", Offset = "0xE6DE00", VA = "0x180E6EC00", Slot = "5")]
	public override bool IsQue()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F8F")]
	[Address(RVA = "0x7CE740", Offset = "0x7CD940", VA = "0x1807CE740", Slot = "6")]
	public override bool IsPoll()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F90")]
	[Address(RVA = "0x7CE730", Offset = "0x7CD930", VA = "0x1807CE730", Slot = "7")]
	public override bool IsEntried()
	{
		return default(bool);
	}

	[Token(Token = "0x6000F91")]
	[Address(RVA = "0xE6EAE0", Offset = "0xE6DCE0", VA = "0x180E6EAE0", Slot = "8")]
	public override PvP.Event Dequeue()
	{
		return null;
	}

	[Token(Token = "0x6000F92")]
	[Address(RVA = "0xE6EB50", Offset = "0xE6DD50", VA = "0x180E6EB50", Slot = "9")]
	[IteratorStateMachine(typeof(_003CExec_003Ed__31))]
	public override IEnumerator Exec(PvP.Event val)
	{
		return null;
	}

	[Token(Token = "0x6000F93")]
	[Address(RVA = "0xE6E620", Offset = "0xE6D820", VA = "0x180E6E620", Slot = "16")]
	public override void AddCompleteHandler(PvP.EventHandler handler)
	{
	}

	[Token(Token = "0x6000F94")]
	[Address(RVA = "0xE6E6C0", Offset = "0xE6D8C0", VA = "0x180E6E6C0", Slot = "17")]
	public override void AddErrorHandler(PvP.EventHandler handler)
	{
	}

	[Token(Token = "0x6000F95")]
	[Address(RVA = "0xE6E760", Offset = "0xE6D960", VA = "0x180E6E760", Slot = "18")]
	public override void AddFatalHandler(PvP.EventHandler handler)
	{
	}

	[Token(Token = "0x6000F96")]
	[Address(RVA = "0xE6E800", Offset = "0xE6DA00", VA = "0x180E6E800", Slot = "19")]
	public override void AddRecvHandler(PvP.EventHandler handler)
	{
	}

	[Token(Token = "0x6000F97")]
	[Address(RVA = "0xE6ECD0", Offset = "0xE6DED0", VA = "0x180E6ECD0", Slot = "20")]
	public override void RemoveRecvHandler(PvP.EventHandler handler)
	{
	}

	[Token(Token = "0x6000F98")]
	[Address(RVA = "0xE6E8A0", Offset = "0xE6DAA0", VA = "0x180E6E8A0", Slot = "21")]
	public override void ClearHandler()
	{
	}

	[Token(Token = "0x6000F99")]
	[Address(RVA = "0x457410", Offset = "0x456610", VA = "0x180457410", Slot = "22")]
	public override void SetPollingData(byte[] data)
	{
	}

	[Token(Token = "0x6000F9A")]
	[Address(RVA = "0x720320", Offset = "0x71F520", VA = "0x180720320", Slot = "23")]
	public override void ApplicationQuitAbort()
	{
	}

	[Token(Token = "0x6000F9B")]
	[Address(RVA = "0x6ABCC0", Offset = "0x6AAEC0", VA = "0x1806ABCC0", Slot = "24")]
	public override int GetJobCount()
	{
		return default(int);
	}

	[Token(Token = "0x6000F9C")]
	[Address(RVA = "0xE6E990", Offset = "0xE6DB90", VA = "0x180E6E990")]
	private void Complete(PvP.Event ev)
	{
	}

	[Token(Token = "0x6000F9D")]
	[Address(RVA = "0xE6EB30", Offset = "0xE6DD30", VA = "0x180E6EB30")]
	private void Error(PvP.Event ev, PvPCode code = PvPCode.ERROR)
	{
	}

	[Token(Token = "0x6000F9E")]
	[Address(RVA = "0xE6EBE0", Offset = "0xE6DDE0", VA = "0x180E6EBE0")]
	private void Fatal(PvP.Event ev, PvPCode code = PvPCode.FATAL)
	{
	}

	[Token(Token = "0x6000F9F")]
	[Address(RVA = "0xE6EC50", Offset = "0xE6DE50", VA = "0x180E6EC50")]
	private void Received(PvP.Event ev, PvPCode code = PvPCode.NONE)
	{
	}
}
