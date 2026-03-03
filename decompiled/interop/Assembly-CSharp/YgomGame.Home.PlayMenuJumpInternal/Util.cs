using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem.Network;

namespace YgomGame.Home.PlayMenuJumpInternal;

[Token(Token = "0x2000D73")]
internal static class Util
{
	[Token(Token = "0x2000D74")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[Token(Token = "0x4009EF3")]
		[FieldOffset(Offset = "0x10")]
		public int code;

		[Token(Token = "0x60050F5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass0_0()
		{
		}

		[Token(Token = "0x60050F6")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CCallDuelMenuInfo_003Eb__0(int _code)
		{
		}
	}

	[Token(Token = "0x2000D75")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass4_0
	{
		[Token(Token = "0x4009EF4")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x60050F7")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass4_0()
		{
		}

		[Token(Token = "0x60050F8")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CShowErrorDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2000D76")]
	[CompilerGenerated]
	private sealed class _003CCallDuelMenuInfo_003Ed__0 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009EF5")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009EF6")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009EF7")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

		[Token(Token = "0x4009EF8")]
		[FieldOffset(Offset = "0x28")]
		private Handle _003Chandle_003E5__2;

		[Token(Token = "0x17000BAB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60050FC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60050FE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050F9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCallDuelMenuInfo_003Ed__0(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60050FA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60050FB")]
		[Address(RVA = "0x996B80", Offset = "0x995D80", VA = "0x180996B80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60050FD")]
		[Address(RVA = "0x996D40", Offset = "0x995F40", VA = "0x180996D40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000D77")]
	[CompilerGenerated]
	private sealed class _003CShowErrorDialog_003Ed__4 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4009EF9")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4009EFA")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4009EFB")]
		[FieldOffset(Offset = "0x20")]
		public string msg;

		[Token(Token = "0x4009EFC")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass4_0 _003C_003E8__1;

		[Token(Token = "0x17000BAD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6005102")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000BAE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6005104")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60050FF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CShowErrorDialog_003Ed__4(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6005100")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6005101")]
		[Address(RVA = "0x996D80", Offset = "0x995F80", VA = "0x180996D80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6005103")]
		[Address(RVA = "0x996F10", Offset = "0x996110", VA = "0x180996F10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x60050F0")]
	[Address(RVA = "0x99B410", Offset = "0x99A610", VA = "0x18099B410")]
	[IteratorStateMachine(typeof(_003CCallDuelMenuInfo_003Ed__0))]
	public static IEnumerator CallDuelMenuInfo()
	{
		return null;
	}

	[Token(Token = "0x60050F1")]
	[Address(RVA = "0x99B460", Offset = "0x99A660", VA = "0x18099B460")]
	public static bool CheckEventInTime(Dictionary<string, object> targetInfo, string endTsKey)
	{
		return default(bool);
	}

	[Token(Token = "0x60050F2")]
	[Address(RVA = "0x99B480", Offset = "0x99A680", VA = "0x18099B480")]
	public static int FindEventInTime(Dictionary<string, object> eventInfos, int targetId, string endTsKey)
	{
		return default(int);
	}

	[Token(Token = "0x60050F3")]
	[Address(RVA = "0x99B920", Offset = "0x99AB20", VA = "0x18099B920")]
	private static bool checkEventHolding(Dictionary<string, object> eventDic, string endTsKey)
	{
		return default(bool);
	}

	[Token(Token = "0x60050F4")]
	[Address(RVA = "0x99B7C0", Offset = "0x99A9C0", VA = "0x18099B7C0")]
	[IteratorStateMachine(typeof(_003CShowErrorDialog_003Ed__4))]
	public static IEnumerator ShowErrorDialog(string msg)
	{
		return null;
	}
}
