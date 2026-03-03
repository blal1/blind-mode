using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem;
using YgomSystem.Network;

namespace YgomGame;

[Token(Token = "0x200063B")]
public static class AccountUtility
{
	[Token(Token = "0x200063C")]
	public class AccoutCreateParamter
	{
		[Token(Token = "0x4001E4C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int countryNumeric;

		[Token(Token = "0x4001E4D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		public UserAgreementType userAgreementType;

		[Token(Token = "0x4001E4E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public PrivacyOptionType privacyOption;

		[Token(Token = "0x4001E4F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Dictionary<string, object> survayAnswer;

		[Token(Token = "0x6002942")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public AccoutCreateParamter()
		{
		}
	}

	[Token(Token = "0x200063D")]
	public enum PrivacyOptionType
	{
		[Token(Token = "0x4001E51")]
		None,
		[Token(Token = "0x4001E52")]
		OptIn,
		[Token(Token = "0x4001E53")]
		OptOut
	}

	[Token(Token = "0x200063E")]
	public enum LoginResultCode
	{
		[Token(Token = "0x4001E55")]
		Success,
		[Token(Token = "0x4001E56")]
		Error_Create,
		[Token(Token = "0x4001E57")]
		Error_Auth,
		[Token(Token = "0x4001E58")]
		Error_Platform_Check,
		[Token(Token = "0x4001E59")]
		Error_Platform_Reauth,
		[Token(Token = "0x4001E5A")]
		Error_Agreement_Required,
		[Token(Token = "0x4001E5B")]
		Error_Password_Required,
		[Token(Token = "0x4001E5C")]
		Error_Banned,
		[Token(Token = "0x4001E5D")]
		Error_DeeplinkTitleBack,
		[Token(Token = "0x4001E5E")]
		Error_kIDAgeGate_Required,
		[Token(Token = "0x4001E5F")]
		Error_USState_Required,
		[Token(Token = "0x4001E60")]
		Error_Unknown
	}

	[Token(Token = "0x200063F")]
	public struct LoginResultInfo
	{
		[Token(Token = "0x4001E61")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		public LoginResultCode resultCode;

		[Token(Token = "0x4001E62")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
		public int apiCode;
	}

	[Token(Token = "0x2000640")]
	public enum BanType
	{
		[Token(Token = "0x4001E64")]
		None,
		[Token(Token = "0x4001E65")]
		Alert,
		[Token(Token = "0x4001E66")]
		LimitedBan,
		[Token(Token = "0x4001E67")]
		PermanentBan,
		[Token(Token = "0x4001E68")]
		Removed
	}

	[Token(Token = "0x2000641")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_0
	{
		[Token(Token = "0x4001E69")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string authSession;

		[Token(Token = "0x6002943")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass10_0()
		{
		}

		[Token(Token = "0x6002944")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CresumeCoroutine_003Eb__0(string session)
		{
		}

		[Token(Token = "0x6002945")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CresumeCoroutine_003Eb__2(string session)
		{
		}
	}

	[Token(Token = "0x2000642")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_1
	{
		[Token(Token = "0x4001E6A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x6002946")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass10_1()
		{
		}

		[Token(Token = "0x6002947")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CresumeCoroutine_003Eb__1(int code)
		{
		}
	}

	[Token(Token = "0x2000643")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass10_2
	{
		[Token(Token = "0x4001E6B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x6002948")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass10_2()
		{
		}

		[Token(Token = "0x6002949")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CresumeCoroutine_003Eb__3(int code)
		{
		}
	}

	[Token(Token = "0x2000644")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x4001E6C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x600294A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600294B")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CReagreeCoroutine_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x2000645")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x4001E6D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x600294C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x600294D")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CUnlockCoroutine_003Eb__0(int _code)
		{
		}
	}

	[Token(Token = "0x2000646")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_1
	{
		[Token(Token = "0x4001E6E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public LoginResultCode loginResult;

		[Token(Token = "0x600294E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass22_1()
		{
		}

		[Token(Token = "0x600294F")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CUnlockCoroutine_003Eb__1(LoginResultInfo _info)
		{
		}
	}

	[Token(Token = "0x2000648")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass5_0
	{
		[Token(Token = "0x4001E70")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string session;

		[Token(Token = "0x4001E71")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		public bool response;

		[Token(Token = "0x6002952")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass5_0()
		{
		}

		[Token(Token = "0x6002953")]
		[Address(RVA = "0x6E6F40", Offset = "0x6E6140", VA = "0x1806E6F40")]
		internal void _003CGetSteamAuthSession_003Eb__0(string auth)
		{
		}

		[Token(Token = "0x6002954")]
		[Address(RVA = "0x444790", Offset = "0x443990", VA = "0x180444790")]
		internal bool _003CGetSteamAuthSession_003Eb__1()
		{
			return default(bool);
		}
	}

	[Token(Token = "0x2000649")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass6_0
	{
		[Token(Token = "0x4001E72")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string authSession;

		[Token(Token = "0x6002955")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass6_0()
		{
		}

		[Token(Token = "0x6002956")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CGetAuthSessionForKidCheck_003Eb__0(string session)
		{
		}
	}

	[Token(Token = "0x200064A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass7_0
	{
		[Token(Token = "0x4001E73")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x6002957")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass7_0()
		{
		}

		[Token(Token = "0x6002958")]
		[Address(RVA = "0x5F4420", Offset = "0x5F3620", VA = "0x1805F4420")]
		internal void _003CcallAPICoroutine_003Eb__0(Handle handle)
		{
		}
	}

	[Token(Token = "0x200064B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_0
	{
		[Token(Token = "0x4001E74")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public string authSession;

		[Token(Token = "0x6002959")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_0()
		{
		}

		[Token(Token = "0x600295A")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CloginCoroutine_003Eb__0(string session)
		{
		}
	}

	[Token(Token = "0x200064C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_1
	{
		[Token(Token = "0x4001E75")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int apiCode;

		[Token(Token = "0x600295B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_1()
		{
		}

		[Token(Token = "0x600295C")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CloginCoroutine_003Eb__1(int code)
		{
		}
	}

	[Token(Token = "0x200064D")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass8_2
	{
		[Token(Token = "0x4001E76")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		public int apiCode;

		[Token(Token = "0x600295D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass8_2()
		{
		}

		[Token(Token = "0x600295E")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CloginCoroutine_003Eb__2(int code)
		{
		}
	}

	[Token(Token = "0x200064F")]
	[CompilerGenerated]
	private sealed class _003CAuthCoroutine_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E78")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E79")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E7A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<LoginResultInfo> resultCallback;

		[Token(Token = "0x17000543")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002964")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000544")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002966")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002961")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAuthCoroutine_003Ed__18(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002962")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002963")]
		[Address(RVA = "0x6D9980", Offset = "0x6D8B80", VA = "0x1806D9980", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002965")]
		[Address(RVA = "0x6D99E0", Offset = "0x6D8BE0", VA = "0x1806D99E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000650")]
	[CompilerGenerated]
	private sealed class _003CAuthCoroutineV1_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E7B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E7C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E7D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<LoginResultCode> resultCallback;

		[Token(Token = "0x17000545")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600296A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000546")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600296C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002967")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CAuthCoroutineV1_003Ed__19(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002968")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002969")]
		[Address(RVA = "0x6D9A20", Offset = "0x6D8C20", VA = "0x1806D9A20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600296B")]
		[Address(RVA = "0x6D9A80", Offset = "0x6D8C80", VA = "0x1806D9A80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000651")]
	[CompilerGenerated]
	private sealed class _003CCreateAccountCoroutine_003Ed__15 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E7E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E7F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E80")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AccoutCreateParamter parameter;

		[Token(Token = "0x4001E81")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<LoginResultInfo> resultCallback;

		[Token(Token = "0x17000547")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002970")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000548")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002972")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600296D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCreateAccountCoroutine_003Ed__15(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600296E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600296F")]
		[Address(RVA = "0x6D9AC0", Offset = "0x6D8CC0", VA = "0x1806D9AC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002971")]
		[Address(RVA = "0x6D9B20", Offset = "0x6D8D20", VA = "0x1806D9B20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000652")]
	[CompilerGenerated]
	private sealed class _003CCreateAccountCoroutineV1_003Ed__16 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E82")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E83")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E84")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public AccoutCreateParamter parameter;

		[Token(Token = "0x4001E85")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<LoginResultCode> resultCallback;

		[Token(Token = "0x17000549")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002976")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002978")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002973")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CCreateAccountCoroutineV1_003Ed__16(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002974")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002975")]
		[Address(RVA = "0x6D9B60", Offset = "0x6D8D60", VA = "0x1806D9B60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002977")]
		[Address(RVA = "0x6D9BC0", Offset = "0x6D8DC0", VA = "0x1806D9BC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000653")]
	[CompilerGenerated]
	private sealed class _003CGetAuthSessionForKidCheck_003Ed__6 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E86")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E87")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E88")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<string, bool> resultCallback;

		[Token(Token = "0x4001E89")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass6_0 _003C_003E8__1;

		[Token(Token = "0x1700054B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600297C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600297E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002979")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetAuthSessionForKidCheck_003Ed__6(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600297A")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600297B")]
		[Address(RVA = "0x6DA750", Offset = "0x6D9950", VA = "0x1806DA750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600297D")]
		[Address(RVA = "0x6DA900", Offset = "0x6D9B00", VA = "0x1806DA900", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000654")]
	[CompilerGenerated]
	private sealed class _003CGetSteamAuthSession_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E8A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E8B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E8C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<string> resultCallback;

		[Token(Token = "0x4001E8D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public bool cancel;

		[Token(Token = "0x4001E8E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass5_0 _003C_003E8__1;

		[Token(Token = "0x1700054D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002982")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700054E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002984")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600297F")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CGetSteamAuthSession_003Ed__5(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002980")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002981")]
		[Address(RVA = "0x6DA940", Offset = "0x6D9B40", VA = "0x1806DA940", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002983")]
		[Address(RVA = "0x6DAC00", Offset = "0x6D9E00", VA = "0x1806DAC00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000655")]
	[CompilerGenerated]
	private sealed class _003CReagreeCoroutine_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E8F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E90")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E91")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public IReadOnlyList<AgreementKind> agreementKinds;

		[Token(Token = "0x4001E92")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public PrivacyOptionType privacyOption;

		[Token(Token = "0x4001E93")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		[Token(Token = "0x4001E94")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<int> resultCallback;

		[Token(Token = "0x1700054F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002988")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000550")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600298A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002985")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CReagreeCoroutine_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002986")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002987")]
		[Address(RVA = "0x6DAC40", Offset = "0x6D9E40", VA = "0x1806DAC40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002989")]
		[Address(RVA = "0x6DAE40", Offset = "0x6DA040", VA = "0x1806DAE40", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000656")]
	[CompilerGenerated]
	private sealed class _003CRefreshAuthCoroutine_003Ed__11 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E95")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E96")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E97")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool> resultCallback;

		[Token(Token = "0x17000551")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600298E")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000552")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002990")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600298B")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CRefreshAuthCoroutine_003Ed__11(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600298C")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600298D")]
		[Address(RVA = "0x6DAE80", Offset = "0x6DA080", VA = "0x1806DAE80", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600298F")]
		[Address(RVA = "0x6DAF20", Offset = "0x6DA120", VA = "0x1806DAF20", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000657")]
	[CompilerGenerated]
	private sealed class _003CResumeCoroutine_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E98")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E99")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E9A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<bool> resultCallback;

		[Token(Token = "0x17000553")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6002994")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000554")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6002996")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002991")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CResumeCoroutine_003Ed__13(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002992")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002993")]
		[Address(RVA = "0x6DAF60", Offset = "0x6DA160", VA = "0x1806DAF60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002995")]
		[Address(RVA = "0x6DB020", Offset = "0x6DA220", VA = "0x1806DB020", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000658")]
	[CompilerGenerated]
	private sealed class _003CSetAppSettingsCoroutine_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E9B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E9C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001E9D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action resultCallback;

		[Token(Token = "0x17000555")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600299A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000556")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600299C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6002997")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CSetAppSettingsCoroutine_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6002998")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6002999")]
		[Address(RVA = "0x6DB060", Offset = "0x6DA260", VA = "0x1806DB060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600299B")]
		[Address(RVA = "0x6DB230", Offset = "0x6DA430", VA = "0x1806DB230", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2000659")]
	[CompilerGenerated]
	private sealed class _003CUnlockCoroutine_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001E9E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001E9F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EA0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public string password;

		[Token(Token = "0x4001EA1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x4001EA2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass22_1 _003C_003E8__2;

		[Token(Token = "0x4001EA3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<bool> resultCallback;

		[Token(Token = "0x4001EA4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _003Cunlocked_003E5__2;

		[Token(Token = "0x17000557")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60029A0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000558")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60029A2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600299D")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CUnlockCoroutine_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600299E")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600299F")]
		[Address(RVA = "0x6E8740", Offset = "0x6E7940", VA = "0x1806E8740", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60029A1")]
		[Address(RVA = "0x6E8A00", Offset = "0x6E7C00", VA = "0x1806E8A00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200065A")]
	[CompilerGenerated]
	private sealed class _003CcallAPICoroutine_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EA5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EA6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EA7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Handle apiHandle;

		[Token(Token = "0x4001EA8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public Action<int> resultCallback;

		[Token(Token = "0x4001EA9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass7_0 _003C_003E8__1;

		[Token(Token = "0x17000559")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60029A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60029A8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029A3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallAPICoroutine_003Ed__7(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60029A4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60029A5")]
		[Address(RVA = "0x6E8A40", Offset = "0x6E7C40", VA = "0x1806E8A40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60029A7")]
		[Address(RVA = "0x6E8BC0", Offset = "0x6E7DC0", VA = "0x1806E8BC0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200065B")]
	[CompilerGenerated]
	private sealed class _003CloginCoroutine_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EAA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EAB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EAC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass8_0 _003C_003E8__1;

		[Token(Token = "0x4001EAD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AccoutCreateParamter createParam;

		[Token(Token = "0x4001EAE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass8_1 _003C_003E8__2;

		[Token(Token = "0x4001EAF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<LoginResultInfo> resultCallback;

		[Token(Token = "0x4001EB0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass8_2 _003C_003E8__3;

		[Token(Token = "0x4001EB1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private bool _003CwithSession_003E5__2;

		[Token(Token = "0x1700055B")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60029AC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60029AE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029A9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloginCoroutine_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60029AA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60029AB")]
		[Address(RVA = "0x6E8C00", Offset = "0x6E7E00", VA = "0x1806E8C00", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60029AD")]
		[Address(RVA = "0x6E92E0", Offset = "0x6E84E0", VA = "0x1806E92E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200065C")]
	[CompilerGenerated]
	private sealed class _003CloginCoroutineV1_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EB2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EB3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EB4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		public Action<LoginResultCode> resultCallback;

		[Token(Token = "0x4001EB5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		public AccoutCreateParamter createParam;

		[Token(Token = "0x1700055D")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60029B2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700055E")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60029B4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029AF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CloginCoroutineV1_003Ed__9(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60029B0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60029B1")]
		[Address(RVA = "0x6E9320", Offset = "0x6E8520", VA = "0x1806E9320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60029B3")]
		[Address(RVA = "0x6E9430", Offset = "0x6E8630", VA = "0x1806E9430", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200065D")]
	[CompilerGenerated]
	private sealed class _003CresumeCoroutine_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4001EB6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x4001EB7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x4001EB8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass10_0 _003C_003E8__1;

		[Token(Token = "0x4001EB9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass10_1 _003C_003E8__2;

		[Token(Token = "0x4001EBA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass10_2 _003C_003E8__3;

		[Token(Token = "0x4001EBB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		public Action<bool> resultCallback;

		[Token(Token = "0x4001EBC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private bool _003CisSuccess_003E5__2;

		[Token(Token = "0x4001EBD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x41")]
		private bool _003CreAuth_003E5__3;

		[Token(Token = "0x4001EBE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x42")]
		private bool _003CcallPlatformCheck_003E5__4;

		[Token(Token = "0x1700055F")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60029B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000560")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60029BA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60029B5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CresumeCoroutine_003Ed__10(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60029B6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60029B7")]
		[Address(RVA = "0x6E9470", Offset = "0x6E8670", VA = "0x1806E9470", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60029B9")]
		[Address(RVA = "0x6E9860", Offset = "0x6E8A60", VA = "0x1806E9860", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x4001E4B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SteamAuthSession steamAuthSession;

	[Token(Token = "0x600292C")]
	[Address(RVA = "0x6D81B0", Offset = "0x6D73B0", VA = "0x1806D81B0")]
	[IteratorStateMachine(typeof(_003CGetSteamAuthSession_003Ed__5))]
	private static IEnumerator GetSteamAuthSession(bool cancel, Action<string> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600292D")]
	[Address(RVA = "0x6D7DA0", Offset = "0x6D6FA0", VA = "0x1806D7DA0")]
	[IteratorStateMachine(typeof(_003CGetAuthSessionForKidCheck_003Ed__6))]
	public static IEnumerator GetAuthSessionForKidCheck(Action<string, bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600292E")]
	[Address(RVA = "0x6D8630", Offset = "0x6D7830", VA = "0x1806D8630")]
	[IteratorStateMachine(typeof(_003CcallAPICoroutine_003Ed__7))]
	private static IEnumerator callAPICoroutine(Handle apiHandle, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600292F")]
	[Address(RVA = "0x6D8860", Offset = "0x6D7A60", VA = "0x1806D8860")]
	[IteratorStateMachine(typeof(_003CloginCoroutine_003Ed__8))]
	private static IEnumerator loginCoroutine(AccoutCreateParamter createParam, Action<LoginResultInfo> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002930")]
	[Address(RVA = "0x6D87D0", Offset = "0x6D79D0", VA = "0x1806D87D0")]
	[IteratorStateMachine(typeof(_003CloginCoroutineV1_003Ed__9))]
	private static IEnumerator loginCoroutineV1(AccoutCreateParamter createParam, Action<LoginResultCode> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002931")]
	[Address(RVA = "0x6D88F0", Offset = "0x6D7AF0", VA = "0x1806D88F0")]
	[IteratorStateMachine(typeof(_003CresumeCoroutine_003Ed__10))]
	private static IEnumerator resumeCoroutine(Action<bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002932")]
	[Address(RVA = "0x6D82D0", Offset = "0x6D74D0", VA = "0x1806D82D0")]
	[IteratorStateMachine(typeof(_003CRefreshAuthCoroutine_003Ed__11))]
	public static IEnumerator RefreshAuthCoroutine(Action<bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002933")]
	[Address(RVA = "0x6D8470", Offset = "0x6D7670", VA = "0x1806D8470")]
	public static void Resume(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x6002934")]
	[Address(RVA = "0x6D8400", Offset = "0x6D7600", VA = "0x1806D8400")]
	[IteratorStateMachine(typeof(_003CResumeCoroutine_003Ed__13))]
	public static IEnumerator ResumeCoroutine(Action<bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002935")]
	[Address(RVA = "0x6D7D20", Offset = "0x6D6F20", VA = "0x1806D7D20")]
	public static void CreateAccount(AccoutCreateParamter parameter, Action<LoginResultInfo> resultCallback)
	{
	}

	[Token(Token = "0x6002936")]
	[Address(RVA = "0x6D7C90", Offset = "0x6D6E90", VA = "0x1806D7C90")]
	[IteratorStateMachine(typeof(_003CCreateAccountCoroutine_003Ed__15))]
	public static IEnumerator CreateAccountCoroutine(AccoutCreateParamter parameter, Action<LoginResultInfo> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002937")]
	[Address(RVA = "0x6D7C00", Offset = "0x6D6E00", VA = "0x1806D7C00")]
	[IteratorStateMachine(typeof(_003CCreateAccountCoroutineV1_003Ed__16))]
	public static IEnumerator CreateAccountCoroutineV1(AccoutCreateParamter parameter, Action<LoginResultCode> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6002938")]
	[Address(RVA = "0x6D7B90", Offset = "0x6D6D90", VA = "0x1806D7B90")]
	public static void Auth(Action<LoginResultInfo> resultCallback)
	{
	}

	[Token(Token = "0x6002939")]
	[Address(RVA = "0x6D7B20", Offset = "0x6D6D20", VA = "0x1806D7B20")]
	[IteratorStateMachine(typeof(_003CAuthCoroutine_003Ed__18))]
	public static IEnumerator AuthCoroutine(Action<LoginResultInfo> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600293A")]
	[Address(RVA = "0x6D7AB0", Offset = "0x6D6CB0", VA = "0x1806D7AB0")]
	[IteratorStateMachine(typeof(_003CAuthCoroutineV1_003Ed__19))]
	public static IEnumerator AuthCoroutineV1(Action<LoginResultCode> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600293B")]
	[Address(RVA = "0x6D8340", Offset = "0x6D7540", VA = "0x1806D8340")]
	public static void RefreshAuth(Action<bool> resultCallback)
	{
	}

	[Token(Token = "0x600293C")]
	[Address(RVA = "0x6D8230", Offset = "0x6D7430", VA = "0x1806D8230")]
	[IteratorStateMachine(typeof(_003CReagreeCoroutine_003Ed__21))]
	public static IEnumerator ReagreeCoroutine(IReadOnlyList<AgreementKind> agreementKinds, PrivacyOptionType privacyOption, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600293D")]
	[Address(RVA = "0x6D85A0", Offset = "0x6D77A0", VA = "0x1806D85A0")]
	[IteratorStateMachine(typeof(_003CUnlockCoroutine_003Ed__22))]
	public static IEnumerator UnlockCoroutine(string password, Action<bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600293E")]
	[Address(RVA = "0x6D8530", Offset = "0x6D7730", VA = "0x1806D8530")]
	[IteratorStateMachine(typeof(_003CSetAppSettingsCoroutine_003Ed__23))]
	public static IEnumerator SetAppSettingsCoroutine(Action resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600293F")]
	[Address(RVA = "0x51B3B0", Offset = "0x51A5B0", VA = "0x18051B3B0")]
	public static void AlertXboxMultiplayOFFMessage([Optional] Action onEnd)
	{
	}

	[Token(Token = "0x6002940")]
	[Address(RVA = "0x6D7E10", Offset = "0x6D7010", VA = "0x1806D7E10")]
	public static bool GetBanDialogData(out BanType banType, out string title, out string message, out string button)
	{
		return default(bool);
	}

	[Token(Token = "0x6002941")]
	[Address(RVA = "0x6D86C0", Offset = "0x6D78C0", VA = "0x1806D86C0")]
	private static string getBanText(Dictionary<string, object> cw, string textIdKey, string textKey)
	{
		return null;
	}
}
