using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame;

[Token(Token = "0x2000703")]
public static class ServerConnection
{
	[Token(Token = "0x2000704")]
	public enum Status
	{
		[Token(Token = "0x400231D")]
		None,
		[Token(Token = "0x400231E")]
		Success,
		[Token(Token = "0x400231F")]
		Maintenance,
		[Token(Token = "0x4002320")]
		VersionUpRequired,
		[Token(Token = "0x4002321")]
		Failed
	}

	[Token(Token = "0x2000706")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass14_0
	{
		[Token(Token = "0x4002324")]
		[FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x4002325")]
		[FieldOffset(Offset = "0x14")]
		public bool wait_system_info;

		[Token(Token = "0x6002E7E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass14_0()
		{
		}

		[Token(Token = "0x6002E7F")]
		[Address(RVA = "0x725B10", Offset = "0x724D10", VA = "0x180725B10")]
		internal void _003CconnectCoroutine_003Eb__0(Handle handle)
		{
		}
	}

	[Token(Token = "0x2000707")]
	[CompilerGenerated]
	private sealed class _003CconnectCoroutine_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002326")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4002327")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4002328")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass14_0 _003C_003E8__1;

		[Token(Token = "0x170005C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E83")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E85")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E80")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CconnectCoroutine_003Ed__14(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E81")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E82")]
		[Address(RVA = "0x727060", Offset = "0x726260", VA = "0x180727060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x7273F0", Offset = "0x7265F0", VA = "0x1807273F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000708")]
	[CompilerGenerated]
	private sealed class _003CshowFatalErrorDialog_003Ed__3 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4002329")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400232A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x170005C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002E89")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170005C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002E8B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowFatalErrorDialog_003Ed__3(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x727430", Offset = "0x726630", VA = "0x180727430", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x727530", Offset = "0x726730", VA = "0x180727530", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400231A")]
	[FieldOffset(Offset = "0x0")]
	private static Status m_status;

	[Token(Token = "0x400231B")]
	[FieldOffset(Offset = "0x8")]
	private static IEnumerator m_connectCoroutine;

	[Token(Token = "0x170005BE")]
	public static bool isConnecting
	{
		[Token(Token = "0x6002E74")]
		[Address(RVA = "0x722600", Offset = "0x721800", VA = "0x180722600")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x170005BF")]
	public static Status status
	{
		[Token(Token = "0x6002E75")]
		[Address(RVA = "0x722680", Offset = "0x721880", VA = "0x180722680")]
		get
		{
			return default(Status);
		}
	}

	[Token(Token = "0x170005C0")]
	public static bool isSuccess
	{
		[Token(Token = "0x6002E76")]
		[Address(RVA = "0x722640", Offset = "0x721840", VA = "0x180722640")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002E71")]
	[Address(RVA = "0x722580", Offset = "0x721780", VA = "0x180722580")]
	private static Status codeToStatus(ErrorCode code)
	{
		return default(Status);
	}

	[Token(Token = "0x6002E72")]
	[Address(RVA = "0x7226C0", Offset = "0x7218C0", VA = "0x1807226C0")]
	private static bool isFatalError(Status st)
	{
		return default(bool);
	}

	[Token(Token = "0x6002E73")]
	[Address(RVA = "0x7226D0", Offset = "0x7218D0", VA = "0x1807226D0")]
	[IteratorStateMachine(typeof(_003CshowFatalErrorDialog_003Ed__3))]
	private static IEnumerator showFatalErrorDialog()
	{
		return null;
	}

	[Token(Token = "0x6002E77")]
	[Address(RVA = "0x7223D0", Offset = "0x7215D0", VA = "0x1807223D0")]
	public static void Reset()
	{
	}

	[Token(Token = "0x6002E78")]
	[Address(RVA = "0x722490", Offset = "0x721690", VA = "0x180722490")]
	public static void StartConnect()
	{
	}

	[Token(Token = "0x6002E79")]
	[Address(RVA = "0x7225B0", Offset = "0x7217B0", VA = "0x1807225B0")]
	[IteratorStateMachine(typeof(_003CconnectCoroutine_003Ed__14))]
	private static IEnumerator connectCoroutine()
	{
		return null;
	}

	[Token(Token = "0x6002E7A")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("ENABLE_DEBUGLOG")]
	private static void timeLog(string msg)
	{
	}
}
