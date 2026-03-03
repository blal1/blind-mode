using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem;

namespace YgomGame.Menu;

[Token(Token = "0x20011FA")]
public class GameEntrySequenceViewController : BaseMenuViewController
{
	[Token(Token = "0x20011FB")]
	private enum Step
	{
		[Token(Token = "0x400B9AC")]
		Start = 0,
		[Token(Token = "0x400B9AD")]
		CountrySelect = 1,
		[Token(Token = "0x400B9AE")]
		StartingAgeGate = 2,
		[Token(Token = "0x400B9AF")]
		USAStateSelect = 3,
		[Token(Token = "0x400B9B0")]
		StartingTermOfService = 4,
		[Token(Token = "0x400B9B1")]
		StartingPrivacyPolicy = 5,
		[Token(Token = "0x400B9B2")]
		StartSurvey = 6,
		[Token(Token = "0x400B9B3")]
		AccountCreate = 7,
		[Token(Token = "0x400B9B4")]
		ExistingLogin = 8,
		[Token(Token = "0x400B9B5")]
		ReagreementAgeGate = 9,
		[Token(Token = "0x400B9B6")]
		ReagreementTermOfService = 10,
		[Token(Token = "0x400B9B7")]
		ReagreementPrivacyPolicy = 11,
		[Token(Token = "0x400B9B8")]
		Reagree = 12,
		[Token(Token = "0x400B9B9")]
		PasswordInput = 13,
		[Token(Token = "0x400B9BA")]
		SetAppSettings = 14,
		[Token(Token = "0x400B9BB")]
		RestoreProduct = 15,
		[Token(Token = "0x400B9BC")]
		Finish = 1000,
		[Token(Token = "0x400B9BD")]
		ErrorAbort = 9999
	}

	[Token(Token = "0x20011FC")]
	private class UserData
	{
		[Token(Token = "0x400B9BE")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirstPlay;

		[Token(Token = "0x400B9BF")]
		[FieldOffset(Offset = "0x14")]
		public int countryCode;

		[Token(Token = "0x400B9C0")]
		[FieldOffset(Offset = "0x18")]
		public int stateCode;

		[Token(Token = "0x400B9C1")]
		[FieldOffset(Offset = "0x1C")]
		public int ageGateYear;

		[Token(Token = "0x400B9C2")]
		[FieldOffset(Offset = "0x20")]
		public int ageGateMonth;

		[Token(Token = "0x400B9C3")]
		[FieldOffset(Offset = "0x24")]
		public int ageGateDay;

		[Token(Token = "0x400B9C4")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, object> surveyAnswer;

		[Token(Token = "0x6007073")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public UserData()
		{
		}
	}

	[Token(Token = "0x20011FE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass20_0
	{
		[Token(Token = "0x400B9C7")]
		[FieldOffset(Offset = "0x10")]
		public int country;

		[Token(Token = "0x400B9C8")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6007077")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass20_0()
		{
		}

		[Token(Token = "0x6007078")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CstepCountrySelect_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011FF")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass21_0
	{
		[Token(Token = "0x400B9C9")]
		[FieldOffset(Offset = "0x10")]
		public int res_year;

		[Token(Token = "0x400B9CA")]
		[FieldOffset(Offset = "0x14")]
		public int res_month;

		[Token(Token = "0x400B9CB")]
		[FieldOffset(Offset = "0x18")]
		public int res_day;

		[Token(Token = "0x6007079")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass21_0()
		{
		}

		[Token(Token = "0x600707A")]
		[Address(RVA = "0xB6CE90", Offset = "0xB6C090", VA = "0x180B6CE90")]
		internal void _003CstepStartingAgeGate_003Eb__0(int _year, int _month, int _day)
		{
		}
	}

	[Token(Token = "0x2001200")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass22_0
	{
		[Token(Token = "0x400B9CC")]
		[FieldOffset(Offset = "0x10")]
		public int stateCode;

		[Token(Token = "0x400B9CD")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x600707B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass22_0()
		{
		}

		[Token(Token = "0x600707C")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CstepUSAStateSelect_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x2001201")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass23_0
	{
		[Token(Token = "0x400B9CE")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x600707D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass23_0()
		{
		}

		[Token(Token = "0x600707E")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStartingTermOfService_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x2001202")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		[Token(Token = "0x400B9CF")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x600707F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass24_0()
		{
		}

		[Token(Token = "0x6007080")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStartingPrivacyPolicy_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x2001203")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass25_0
	{
		[Token(Token = "0x400B9D0")]
		[FieldOffset(Offset = "0x10")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400B9D1")]
		[FieldOffset(Offset = "0x18")]
		public bool wait;

		[Token(Token = "0x6007081")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass25_0()
		{
		}

		[Token(Token = "0x6007082")]
		[Address(RVA = "0xB7ED00", Offset = "0xB7DF00", VA = "0x180B7ED00")]
		internal void _003CstepStartSurvey_003Eb__0(Dictionary<string, object> _values)
		{
		}
	}

	[Token(Token = "0x2001204")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass26_0
	{
		[Token(Token = "0x400B9D2")]
		[FieldOffset(Offset = "0x10")]
		public AccountUtility.LoginResultCode resultCode;

		[Token(Token = "0x6007083")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass26_0()
		{
		}

		[Token(Token = "0x6007084")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepAccountCreate_003Eb__0(AccountUtility.LoginResultCode code)
		{
		}
	}

	[Token(Token = "0x2001205")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_0
	{
		[Token(Token = "0x400B9D3")]
		[FieldOffset(Offset = "0x10")]
		public AccountUtility.LoginResultCode resultCode;

		[Token(Token = "0x6007085")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass27_0()
		{
		}

		[Token(Token = "0x6007086")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepExistingLogin_003Eb__0(AccountUtility.LoginResultCode code)
		{
		}
	}

	[Token(Token = "0x2001206")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_1
	{
		[Token(Token = "0x400B9D4")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6007087")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass27_1()
		{
		}

		[Token(Token = "0x6007088")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CstepExistingLogin_003Eb__1()
		{
		}
	}

	[Token(Token = "0x2001207")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass27_2
	{
		[Token(Token = "0x400B9D5")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6007089")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass27_2()
		{
		}

		[Token(Token = "0x600708A")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CstepExistingLogin_003Eb__2()
		{
		}
	}

	[Token(Token = "0x2001208")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass28_0
	{
		[Token(Token = "0x400B9D6")]
		[FieldOffset(Offset = "0x10")]
		public int res_year;

		[Token(Token = "0x400B9D7")]
		[FieldOffset(Offset = "0x14")]
		public int res_month;

		[Token(Token = "0x400B9D8")]
		[FieldOffset(Offset = "0x18")]
		public int res_day;

		[Token(Token = "0x600708B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass28_0()
		{
		}

		[Token(Token = "0x600708C")]
		[Address(RVA = "0xB6CE90", Offset = "0xB6C090", VA = "0x180B6CE90")]
		internal void _003CstepReagreementAgeGate_003Eb__0(int _year, int _month, int _day)
		{
		}
	}

	[Token(Token = "0x2001209")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass29_0
	{
		[Token(Token = "0x400B9D9")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x600708D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass29_0()
		{
		}

		[Token(Token = "0x600708E")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepReagreementTermOfService_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x200120A")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		[Token(Token = "0x400B9DA")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x600708F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[Token(Token = "0x6007090")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepReagreementPrivacyPolicy_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x200120B")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		[Token(Token = "0x400B9DB")]
		[FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x6007091")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass31_0()
		{
		}

		[Token(Token = "0x6007092")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepReagree_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x200120C")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		[Token(Token = "0x400B9DC")]
		[FieldOffset(Offset = "0x10")]
		public string input_str;

		[Token(Token = "0x400B9DD")]
		[FieldOffset(Offset = "0x18")]
		public bool successed;

		[Token(Token = "0x6007093")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6007094")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CstepPasswordInput_003Eb__0(string str)
		{
		}

		[Token(Token = "0x6007095")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		internal void _003CstepPasswordInput_003Eb__1(bool _success)
		{
		}
	}

	[Token(Token = "0x200120E")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400B9E1")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x400B9E2")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6007099")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x600709A")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallTermOfServiceView_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x200120F")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x400B9E3")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x400B9E4")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x600709B")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x600709C")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallPrivacyPolicyView_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x2001210")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x400B9E5")]
		[FieldOffset(Offset = "0x10")]
		public int res_year;

		[Token(Token = "0x400B9E6")]
		[FieldOffset(Offset = "0x14")]
		public int res_month;

		[Token(Token = "0x400B9E7")]
		[FieldOffset(Offset = "0x18")]
		public int res_day;

		[Token(Token = "0x400B9E8")]
		[FieldOffset(Offset = "0x1C")]
		public bool wait;

		[Token(Token = "0x600709D")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x600709E")]
		[Address(RVA = "0xB6D000", Offset = "0xB6C200", VA = "0x180B6D000")]
		internal void _003CcallAgeGateView_003Eb__0(int _year, int _month, int _day)
		{
		}
	}

	[Token(Token = "0x2001211")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x400B9E9")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x600709F")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x60070A0")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CshowErrorDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x2001212")]
	[CompilerGenerated]
	private sealed class _003CcallAgeGateView_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B9EA")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B9EB")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B9EC")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400B9ED")]
		[FieldOffset(Offset = "0x28")]
		public int defaultYear;

		[Token(Token = "0x400B9EE")]
		[FieldOffset(Offset = "0x2C")]
		public int defaultMonth;

		[Token(Token = "0x400B9EF")]
		[FieldOffset(Offset = "0x30")]
		public int defaultDay;

		[Token(Token = "0x400B9F0")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		[Token(Token = "0x400B9F1")]
		[FieldOffset(Offset = "0x40")]
		public Action<int, int, int> resultCallback;

		[Token(Token = "0x170011AF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070A4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070A6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070A1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallAgeGateView_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070A2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070A3")]
		[Address(RVA = "0xB7FBF0", Offset = "0xB7EDF0", VA = "0x180B7FBF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070A5")]
		[Address(RVA = "0xB7FE10", Offset = "0xB7F010", VA = "0x180B7FE10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001213")]
	[CompilerGenerated]
	private sealed class _003CcallPrivacyPolicyView_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B9F2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B9F3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B9F4")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400B9F5")]
		[FieldOffset(Offset = "0x28")]
		public UserAgreementType agreementType;

		[Token(Token = "0x400B9F6")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

		[Token(Token = "0x400B9F7")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> resultCallback;

		[Token(Token = "0x170011B1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070AA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070AC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070A7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallPrivacyPolicyView_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070A8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070A9")]
		[Address(RVA = "0xB7FE50", Offset = "0xB7F050", VA = "0x180B7FE50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070AB")]
		[Address(RVA = "0xB80040", Offset = "0xB7F240", VA = "0x180B80040", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001214")]
	[CompilerGenerated]
	private sealed class _003CcallTermOfServiceView_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B9F8")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B9F9")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B9FA")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400B9FB")]
		[FieldOffset(Offset = "0x28")]
		public UserAgreementType agreementType;

		[Token(Token = "0x400B9FC")]
		[FieldOffset(Offset = "0x30")]
		public string url;

		[Token(Token = "0x400B9FD")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x400B9FE")]
		[FieldOffset(Offset = "0x40")]
		public Action<int> resultCallback;

		[Token(Token = "0x170011B3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070B0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070B2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070AD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallTermOfServiceView_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070AE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070AF")]
		[Address(RVA = "0xB80080", Offset = "0xB7F280", VA = "0x180B80080", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070B1")]
		[Address(RVA = "0xB80280", Offset = "0xB7F480", VA = "0x180B80280", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001215")]
	[CompilerGenerated]
	private sealed class _003CshowErrorDialog_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B9FF")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA00")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA01")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x400BA02")]
		[FieldOffset(Offset = "0x28")]
		public string msg;

		[Token(Token = "0x400BA03")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		[Token(Token = "0x170011B5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070B6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070B8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070B3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowErrorDialog_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070B4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070B5")]
		[Address(RVA = "0xB80750", Offset = "0xB7F950", VA = "0x180B80750", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070B7")]
		[Address(RVA = "0xB80910", Offset = "0xB7FB10", VA = "0x180B80910", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001216")]
	[CompilerGenerated]
	private sealed class _003CstepAccountCreate_003Ed__26 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA04")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA05")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA06")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA07")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x400BA08")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass26_0 _003C_003E8__1;

		[Token(Token = "0x170011B7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070BC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011B8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070BE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070B9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepAccountCreate_003Ed__26(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070BA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070BB")]
		[Address(RVA = "0xB80950", Offset = "0xB7FB50", VA = "0x180B80950", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070BD")]
		[Address(RVA = "0xB80CB0", Offset = "0xB7FEB0", VA = "0x180B80CB0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001217")]
	[CompilerGenerated]
	private sealed class _003CstepCountrySelect_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA09")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA0A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA0B")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA0C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass20_0 _003C_003E8__1;

		[Token(Token = "0x400BA0D")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011B9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070C2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070C4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070BF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepCountrySelect_003Ed__20(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070C0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070C1")]
		[Address(RVA = "0xB80CF0", Offset = "0xB7FEF0", VA = "0x180B80CF0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070C3")]
		[Address(RVA = "0xB81020", Offset = "0xB80220", VA = "0x180B81020", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001218")]
	[CompilerGenerated]
	private sealed class _003CstepExistingLogin_003Ed__27 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA0E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA0F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA10")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA11")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass27_0 _003C_003E8__1;

		[Token(Token = "0x400BA12")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass27_1 _003C_003E8__2;

		[Token(Token = "0x400BA13")]
		[FieldOffset(Offset = "0x38")]
		public StepSequencer seq;

		[Token(Token = "0x400BA14")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass27_2 _003C_003E8__3;

		[Token(Token = "0x400BA15")]
		[FieldOffset(Offset = "0x48")]
		private AccountUtility.BanType _003Ctype_003E5__2;

		[Token(Token = "0x170011BB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070C8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070CA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070C5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepExistingLogin_003Ed__27(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070C6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070C7")]
		[Address(RVA = "0xB81060", Offset = "0xB80260", VA = "0x180B81060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070C9")]
		[Address(RVA = "0xB81830", Offset = "0xB80A30", VA = "0x180B81830", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001219")]
	[CompilerGenerated]
	private sealed class _003CstepPasswordInput_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA16")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA17")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA18")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		[Token(Token = "0x400BA19")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x170011BD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070CE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011BE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070D0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070CB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepPasswordInput_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070CC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070CD")]
		[Address(RVA = "0xB820D0", Offset = "0xB812D0", VA = "0x180B820D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070CF")]
		[Address(RVA = "0xB82300", Offset = "0xB81500", VA = "0x180B82300", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200121A")]
	[CompilerGenerated]
	private sealed class _003CstepReagree_003Ed__31 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA1A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA1B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA1C")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA1D")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		[Token(Token = "0x400BA1E")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011BF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070D4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070D6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070D1")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagree_003Ed__31(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070D2")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070D3")]
		[Address(RVA = "0xB825B0", Offset = "0xB817B0", VA = "0x180B825B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070D5")]
		[Address(RVA = "0xB82850", Offset = "0xB81A50", VA = "0x180B82850", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200121B")]
	[CompilerGenerated]
	private sealed class _003CstepReagreementAgeGate_003Ed__28 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA1F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA20")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA21")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA22")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass28_0 _003C_003E8__1;

		[Token(Token = "0x400BA23")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011C1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070DA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070D7")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagreementAgeGate_003Ed__28(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070D8")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070D9")]
		[Address(RVA = "0xB82B40", Offset = "0xB81D40", VA = "0x180B82B40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070DB")]
		[Address(RVA = "0xB82DF0", Offset = "0xB81FF0", VA = "0x180B82DF0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200121C")]
	[CompilerGenerated]
	private sealed class _003CstepReagreementPrivacyPolicy_003Ed__30 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA24")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA25")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA26")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA27")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass30_0 _003C_003E8__1;

		[Token(Token = "0x400BA28")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011C3")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070E0")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C4")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070E2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070DD")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagreementPrivacyPolicy_003Ed__30(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070DE")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070DF")]
		[Address(RVA = "0xB830E0", Offset = "0xB822E0", VA = "0x180B830E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070E1")]
		[Address(RVA = "0xB832D0", Offset = "0xB824D0", VA = "0x180B832D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200121D")]
	[CompilerGenerated]
	private sealed class _003CstepReagreementTermOfService_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA29")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA2A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA2B")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA2C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass29_0 _003C_003E8__1;

		[Token(Token = "0x400BA2D")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011C5")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070E6")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C6")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070E8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070E3")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagreementTermOfService_003Ed__29(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070E4")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070E5")]
		[Address(RVA = "0xB834F0", Offset = "0xB826F0", VA = "0x180B834F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070E7")]
		[Address(RVA = "0xB83730", Offset = "0xB82930", VA = "0x180B83730", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200121E")]
	[CompilerGenerated]
	private sealed class _003CstepStartSurvey_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA2E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA2F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA30")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA31")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass25_0 _003C_003E8__1;

		[Token(Token = "0x400BA32")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011C7")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070EC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011C8")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070EE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070E9")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartSurvey_003Ed__25(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070EA")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070EB")]
		[Address(RVA = "0xB839B0", Offset = "0xB82BB0", VA = "0x180B839B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070ED")]
		[Address(RVA = "0xB83BA0", Offset = "0xB82DA0", VA = "0x180B83BA0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x200121F")]
	[CompilerGenerated]
	private sealed class _003CstepStartingAgeGate_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA33")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA34")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA35")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA36")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass21_0 _003C_003E8__1;

		[Token(Token = "0x400BA37")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011C9")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070F2")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011CA")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070F4")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070EF")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingAgeGate_003Ed__21(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070F0")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070F1")]
		[Address(RVA = "0xB83FA0", Offset = "0xB831A0", VA = "0x180B83FA0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070F3")]
		[Address(RVA = "0xB84250", Offset = "0xB83450", VA = "0x180B84250", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001220")]
	[CompilerGenerated]
	private sealed class _003CstepStartingPrivacyPolicy_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA38")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA39")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA3A")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA3B")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		[Token(Token = "0x400BA3C")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011CB")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070F8")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011CC")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60070FA")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070F5")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingPrivacyPolicy_003Ed__24(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070F6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070F7")]
		[Address(RVA = "0xB846B0", Offset = "0xB838B0", VA = "0x180B846B0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070F9")]
		[Address(RVA = "0xB848A0", Offset = "0xB83AA0", VA = "0x180B848A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001221")]
	[CompilerGenerated]
	private sealed class _003CstepStartingTermOfService_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA3D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA3E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA3F")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA40")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass23_0 _003C_003E8__1;

		[Token(Token = "0x400BA41")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011CD")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x60070FE")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011CE")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007100")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60070FB")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingTermOfService_003Ed__23(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x60070FC")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x60070FD")]
		[Address(RVA = "0xB84AD0", Offset = "0xB83CD0", VA = "0x180B84AD0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x60070FF")]
		[Address(RVA = "0xB84D80", Offset = "0xB83F80", VA = "0x180B84D80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001222")]
	[CompilerGenerated]
	private sealed class _003CstepSurveySetting_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA42")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA43")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA44")]
		[FieldOffset(Offset = "0x20")]
		public StepSequencer seq;

		[Token(Token = "0x170011CF")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007104")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D0")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007106")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007101")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepSurveySetting_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007102")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007103")]
		[Address(RVA = "0xB85060", Offset = "0xB84260", VA = "0x180B85060", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007105")]
		[Address(RVA = "0xB85180", Offset = "0xB84380", VA = "0x180B85180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x2001223")]
	[CompilerGenerated]
	private sealed class _003CstepUSAStateSelect_003Ed__22 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400BA45")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400BA46")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400BA47")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceViewController _003C_003E4__this;

		[Token(Token = "0x400BA48")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass22_0 _003C_003E8__1;

		[Token(Token = "0x400BA49")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011D1")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600710A")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011D2")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600710C")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007107")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepUSAStateSelect_003Ed__22(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007108")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007109")]
		[Address(RVA = "0xB85320", Offset = "0xB84520", VA = "0x180B85320", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600710B")]
		[Address(RVA = "0xB85600", Offset = "0xB84800", VA = "0x180B85600", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B9A6")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x400B9A7")]
	[FieldOffset(Offset = "0xD8")]
	private Stack<Step> m_backSteps;

	[Token(Token = "0x400B9A8")]
	[FieldOffset(Offset = "0xE0")]
	private UserData m_userData;

	[Token(Token = "0x400B9A9")]
	[FieldOffset(Offset = "0xE8")]
	private CountryList m_countryList;

	[Token(Token = "0x400B9AA")]
	[FieldOffset(Offset = "0xF0")]
	private USAStateList m_stateList;

	[Token(Token = "0x170011AE")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6007052")]
		[Address(RVA = "0xB75C20", Offset = "0xB74E20", VA = "0x180B75C20", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600704E")]
	[Address(RVA = "0xB759E0", Offset = "0xB74BE0", VA = "0x180B759E0")]
	private UserAgreementType currentAgreementType()
	{
		return default(UserAgreementType);
	}

	[Token(Token = "0x600704F")]
	[Address(RVA = "0xB75CF0", Offset = "0xB74EF0", VA = "0x180B75CF0")]
	private static bool isMobile()
	{
		return default(bool);
	}

	[Token(Token = "0x6007050")]
	[Address(RVA = "0xB75B30", Offset = "0xB74D30", VA = "0x180B75B30")]
	private static AccountUtility.PrivacyOptionType getUSAPrivacyOption(int birthYear, int birthMonth, int birthDay)
	{
		return default(AccountUtility.PrivacyOptionType);
	}

	[Token(Token = "0x6007051")]
	[Address(RVA = "0xB75D40", Offset = "0xB74F40", VA = "0x180B75D40")]
	private static void quitGameEntry()
	{
	}

	[Token(Token = "0x6007053")]
	[Address(RVA = "0xB74AB0", Offset = "0xB73CB0", VA = "0x180B74AB0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6007054")]
	[Address(RVA = "0xB753C0", Offset = "0xB745C0", VA = "0x180B753C0", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6007055")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x6007056")]
	[Address(RVA = "0xB75DC0", Offset = "0xB74FC0", VA = "0x180B75DC0")]
	private void saveStepHistory(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007057")]
	[Address(RVA = "0xB756D0", Offset = "0xB748D0", VA = "0x180B756D0")]
	private void backStepHistory(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007058")]
	[Address(RVA = "0xB75990", Offset = "0xB74B90", VA = "0x180B75990")]
	private void clearStepHistory()
	{
	}

	[Token(Token = "0x6007059")]
	[Address(RVA = "0xB76700", Offset = "0xB75900", VA = "0x180B76700")]
	private void stepStart(StepSequencer seq)
	{
	}

	[Token(Token = "0x600705A")]
	[Address(RVA = "0xB75F40", Offset = "0xB75140", VA = "0x180B75F40")]
	[IteratorStateMachine(typeof(_003CstepCountrySelect_003Ed__20))]
	private IEnumerator stepCountrySelect(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600705B")]
	[Address(RVA = "0xB76780", Offset = "0xB75980", VA = "0x180B76780")]
	[IteratorStateMachine(typeof(_003CstepStartingAgeGate_003Ed__21))]
	private IEnumerator stepStartingAgeGate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600705C")]
	[Address(RVA = "0xB769A0", Offset = "0xB75BA0", VA = "0x180B769A0")]
	[IteratorStateMachine(typeof(_003CstepUSAStateSelect_003Ed__22))]
	private IEnumerator stepUSAStateSelect(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600705D")]
	[Address(RVA = "0xB768A0", Offset = "0xB75AA0", VA = "0x180B768A0")]
	[IteratorStateMachine(typeof(_003CstepStartingTermOfService_003Ed__23))]
	private IEnumerator stepStartingTermOfService(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600705E")]
	[Address(RVA = "0xB76810", Offset = "0xB75A10", VA = "0x180B76810")]
	[IteratorStateMachine(typeof(_003CstepStartingPrivacyPolicy_003Ed__24))]
	private IEnumerator stepStartingPrivacyPolicy(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x600705F")]
	[Address(RVA = "0xB76670", Offset = "0xB75870", VA = "0x180B76670")]
	[IteratorStateMachine(typeof(_003CstepStartSurvey_003Ed__25))]
	private IEnumerator stepStartSurvey(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007060")]
	[Address(RVA = "0xB75EB0", Offset = "0xB750B0", VA = "0x180B75EB0")]
	[IteratorStateMachine(typeof(_003CstepAccountCreate_003Ed__26))]
	private IEnumerator stepAccountCreate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007061")]
	[Address(RVA = "0xB76060", Offset = "0xB75260", VA = "0x180B76060")]
	[IteratorStateMachine(typeof(_003CstepExistingLogin_003Ed__27))]
	private IEnumerator stepExistingLogin(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007062")]
	[Address(RVA = "0xB763E0", Offset = "0xB755E0", VA = "0x180B763E0")]
	[IteratorStateMachine(typeof(_003CstepReagreementAgeGate_003Ed__28))]
	private IEnumerator stepReagreementAgeGate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007063")]
	[Address(RVA = "0xB76500", Offset = "0xB75700", VA = "0x180B76500")]
	[IteratorStateMachine(typeof(_003CstepReagreementTermOfService_003Ed__29))]
	private IEnumerator stepReagreementTermOfService(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007064")]
	[Address(RVA = "0xB76470", Offset = "0xB75670", VA = "0x180B76470")]
	[IteratorStateMachine(typeof(_003CstepReagreementPrivacyPolicy_003Ed__30))]
	private IEnumerator stepReagreementPrivacyPolicy(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007065")]
	[Address(RVA = "0xB76350", Offset = "0xB75550", VA = "0x180B76350")]
	[IteratorStateMachine(typeof(_003CstepReagree_003Ed__31))]
	private IEnumerator stepReagree(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007066")]
	[Address(RVA = "0xB762E0", Offset = "0xB754E0", VA = "0x180B762E0")]
	[IteratorStateMachine(typeof(_003CstepPasswordInput_003Ed__32))]
	private IEnumerator stepPasswordInput(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007067")]
	[Address(RVA = "0xB76930", Offset = "0xB75B30", VA = "0x180B76930")]
	[IteratorStateMachine(typeof(_003CstepSurveySetting_003Ed__33))]
	private IEnumerator stepSurveySetting(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6007068")]
	[Address(RVA = "0xB76590", Offset = "0xB75790", VA = "0x180B76590")]
	private void stepRestoreUnfinishedProducts(StepSequencer seq)
	{
	}

	[Token(Token = "0x6007069")]
	[Address(RVA = "0xB75FD0", Offset = "0xB751D0", VA = "0x180B75FD0")]
	private void stepErrorAbort(StepSequencer seq)
	{
	}

	[Token(Token = "0x600706A")]
	[Address(RVA = "0xB760F0", Offset = "0xB752F0", VA = "0x180B760F0")]
	private void stepFinish(StepSequencer seq)
	{
	}

	[Token(Token = "0x600706B")]
	[Address(RVA = "0xB758D0", Offset = "0xB74AD0", VA = "0x180B758D0")]
	[IteratorStateMachine(typeof(_003CcallTermOfServiceView_003Ed__37))]
	private IEnumerator callTermOfServiceView(UserAgreementType agreementType, string url, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600706C")]
	[Address(RVA = "0xB75830", Offset = "0xB74A30", VA = "0x180B75830")]
	[IteratorStateMachine(typeof(_003CcallPrivacyPolicyView_003Ed__38))]
	private IEnumerator callPrivacyPolicyView(UserAgreementType agreementType, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600706D")]
	[Address(RVA = "0xB75780", Offset = "0xB74980", VA = "0x180B75780")]
	[IteratorStateMachine(typeof(_003CcallAgeGateView_003Ed__39))]
	private IEnumerator callAgeGateView(int defaultYear, int defaultMonth, int defaultDay, Action<int, int, int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x600706E")]
	[Address(RVA = "0xB75E20", Offset = "0xB75020", VA = "0x180B75E20")]
	[IteratorStateMachine(typeof(_003CshowErrorDialog_003Ed__40))]
	private IEnumerator showErrorDialog(string title, string msg)
	{
		return null;
	}

	[Token(Token = "0x600706F")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public GameEntrySequenceViewController()
	{
	}
}
