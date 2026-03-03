using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using YgomSystem;
using YgomSystem.Compliance;

namespace YgomGame.Menu;

[Token(Token = "0x20011AE")]
public class GameEntrySequenceV2ViewController : BaseMenuViewController
{
	[Token(Token = "0x20011AF")]
	private enum Step
	{
		[Token(Token = "0x400B893")]
		Start = 0,
		[Token(Token = "0x400B894")]
		CountrySelect = 1,
		[Token(Token = "0x400B895")]
		USAStateSelect = 2,
		[Token(Token = "0x400B896")]
		kID_GetRequirement = 3,
		[Token(Token = "0x400B897")]
		StartingAgeGate = 4,
		[Token(Token = "0x400B898")]
		StartingAdultApproval = 5,
		[Token(Token = "0x400B899")]
		StartingTermOfService = 6,
		[Token(Token = "0x400B89A")]
		StartingPrivacyPolicy = 7,
		[Token(Token = "0x400B89B")]
		StartSurvey = 8,
		[Token(Token = "0x400B89C")]
		AccountCreate = 9,
		[Token(Token = "0x400B89D")]
		ExistingLogin = 10,
		[Token(Token = "0x400B89E")]
		AdditionalUSAStateSelect = 11,
		[Token(Token = "0x400B89F")]
		ContinuingAgeGate = 12,
		[Token(Token = "0x400B8A0")]
		ContinuingAdultApproval = 13,
		[Token(Token = "0x400B8A1")]
		ReagreementAgeGate = 14,
		[Token(Token = "0x400B8A2")]
		ReagreementTermOfService = 15,
		[Token(Token = "0x400B8A3")]
		ReagreementPrivacyPolicy = 16,
		[Token(Token = "0x400B8A4")]
		Reagree = 17,
		[Token(Token = "0x400B8A5")]
		PasswordInput = 18,
		[Token(Token = "0x400B8A6")]
		SetAppSettings = 19,
		[Token(Token = "0x400B8A7")]
		RestoreProduct = 20,
		[Token(Token = "0x400B8A8")]
		Finish = 1000,
		[Token(Token = "0x400B8A9")]
		ErrorAbort = 9999
	}

	[Token(Token = "0x20011B0")]
	private class UserData
	{
		[Token(Token = "0x400B8AA")]
		[FieldOffset(Offset = "0x10")]
		public bool isFirstPlay;

		[Token(Token = "0x400B8AB")]
		[FieldOffset(Offset = "0x14")]
		public int countryCode;

		[Token(Token = "0x400B8AC")]
		[FieldOffset(Offset = "0x18")]
		public int stateCode;

		[Token(Token = "0x400B8AD")]
		[FieldOffset(Offset = "0x1C")]
		public int birthYear;

		[Token(Token = "0x400B8AE")]
		[FieldOffset(Offset = "0x20")]
		public int birthMonth;

		[Token(Token = "0x400B8AF")]
		[FieldOffset(Offset = "0x24")]
		public int birthDay;

		[Token(Token = "0x400B8B0")]
		[FieldOffset(Offset = "0x28")]
		public int age;

		[Token(Token = "0x400B8B1")]
		[FieldOffset(Offset = "0x30")]
		public Dictionary<string, object> surveyAnswer;

		[Token(Token = "0x6006F2C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public UserData()
		{
		}
	}

	[Token(Token = "0x20011B1")]
	private enum AgeGateViewResultType
	{
		[Token(Token = "0x400B8B3")]
		None,
		[Token(Token = "0x400B8B4")]
		Decided,
		[Token(Token = "0x400B8B5")]
		Canceled,
		[Token(Token = "0x400B8B6")]
		Error
	}

	[Token(Token = "0x20011B3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass32_0
	{
		[Token(Token = "0x400B8B9")]
		[FieldOffset(Offset = "0x10")]
		public int countryCode;

		[Token(Token = "0x6006F30")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass32_0()
		{
		}

		[Token(Token = "0x6006F31")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepCountrySelect_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011B4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass33_0
	{
		[Token(Token = "0x400B8BA")]
		[FieldOffset(Offset = "0x10")]
		public int stateCode;

		[Token(Token = "0x6006F32")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass33_0()
		{
		}

		[Token(Token = "0x6006F33")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepUSAStateSelect_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011B5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass34_0
	{
		[Token(Token = "0x400B8BB")]
		[FieldOffset(Offset = "0x10")]
		public int apiCode;

		[Token(Token = "0x6006F34")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass34_0()
		{
		}

		[Token(Token = "0x6006F35")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepkID_GetRequirement_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011B6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_0
	{
		[Token(Token = "0x400B8BC")]
		[FieldOffset(Offset = "0x10")]
		public AgeGateViewResultType inputResult;

		[Token(Token = "0x6006F36")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass35_0()
		{
		}

		[Token(Token = "0x6006F37")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStartingAgeGate_003Eb__0(AgeGateViewResultType _res)
		{
		}
	}

	[Token(Token = "0x20011B7")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass35_1
	{
		[Token(Token = "0x400B8BD")]
		[FieldOffset(Offset = "0x10")]
		public AgeGateCheckResultType checkResult;

		[Token(Token = "0x6006F38")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass35_1()
		{
		}

		[Token(Token = "0x6006F39")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStartingAgeGate_003Eb__1(AgeGateCheckResultType result)
		{
		}
	}

	[Token(Token = "0x20011B8")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass36_0
	{
		[Token(Token = "0x400B8BE")]
		[FieldOffset(Offset = "0x10")]
		public bool result;

		[Token(Token = "0x6006F3A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass36_0()
		{
		}

		[Token(Token = "0x6006F3B")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		internal void _003CstepStartingAdultApproval_003Eb__0(bool res)
		{
		}
	}

	[Token(Token = "0x20011B9")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		[Token(Token = "0x400B8BF")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x6006F3C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass37_0()
		{
		}

		[Token(Token = "0x6006F3D")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStartingTermOfService_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x20011BA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass38_0
	{
		[Token(Token = "0x400B8C0")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x6006F3E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass38_0()
		{
		}

		[Token(Token = "0x6006F3F")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepStartingPrivacyPolicy_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x20011BB")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		[Token(Token = "0x400B8C1")]
		[FieldOffset(Offset = "0x10")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B8C2")]
		[FieldOffset(Offset = "0x18")]
		public bool wait;

		[Token(Token = "0x6006F40")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass39_0()
		{
		}

		[Token(Token = "0x6006F41")]
		[Address(RVA = "0xB6CE50", Offset = "0xB6C050", VA = "0x180B6CE50")]
		internal void _003CstepStartSurvey_003Eb__0(Dictionary<string, object> _values)
		{
		}
	}

	[Token(Token = "0x20011BC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass40_0
	{
		[Token(Token = "0x400B8C3")]
		[FieldOffset(Offset = "0x10")]
		public AccountUtility.LoginResultInfo resultInfo;

		[Token(Token = "0x6006F42")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass40_0()
		{
		}

		[Token(Token = "0x6006F43")]
		[Address(RVA = "0x9941A0", Offset = "0x9933A0", VA = "0x1809941A0")]
		internal void _003CstepAccountCreate_003Eb__0(AccountUtility.LoginResultInfo info)
		{
		}
	}

	[Token(Token = "0x20011BD")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_0
	{
		[Token(Token = "0x400B8C4")]
		[FieldOffset(Offset = "0x10")]
		public AccountUtility.LoginResultInfo resultInfo;

		[Token(Token = "0x6006F44")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_0()
		{
		}

		[Token(Token = "0x6006F45")]
		[Address(RVA = "0x9941A0", Offset = "0x9933A0", VA = "0x1809941A0")]
		internal void _003CstepExistingLogin_003Eb__0(AccountUtility.LoginResultInfo info)
		{
		}
	}

	[Token(Token = "0x20011BE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_1
	{
		[Token(Token = "0x400B8C5")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6006F46")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_1()
		{
		}

		[Token(Token = "0x6006F47")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CstepExistingLogin_003Eb__1()
		{
		}
	}

	[Token(Token = "0x20011BF")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass41_2
	{
		[Token(Token = "0x400B8C6")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6006F48")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass41_2()
		{
		}

		[Token(Token = "0x6006F49")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CstepExistingLogin_003Eb__2()
		{
		}
	}

	[Token(Token = "0x20011C0")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass42_0
	{
		[Token(Token = "0x400B8C7")]
		[FieldOffset(Offset = "0x10")]
		public int stateCode;

		[Token(Token = "0x6006F4A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass42_0()
		{
		}

		[Token(Token = "0x6006F4B")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepAdditionalUSAStateSelect_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011C1")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_0
	{
		[Token(Token = "0x400B8C8")]
		[FieldOffset(Offset = "0x10")]
		public AgeGateViewResultType inputResult;

		[Token(Token = "0x6006F4C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass43_0()
		{
		}

		[Token(Token = "0x6006F4D")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepContinuingAgeGate_003Eb__0(AgeGateViewResultType _res)
		{
		}
	}

	[Token(Token = "0x20011C2")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass43_1
	{
		[Token(Token = "0x400B8C9")]
		[FieldOffset(Offset = "0x10")]
		public AgeGateCheckResultType checkResult;

		[Token(Token = "0x6006F4E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass43_1()
		{
		}

		[Token(Token = "0x6006F4F")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepContinuingAgeGate_003Eb__1(AgeGateCheckResultType result)
		{
		}
	}

	[Token(Token = "0x20011C3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass44_0
	{
		[Token(Token = "0x400B8CA")]
		[FieldOffset(Offset = "0x10")]
		public bool result;

		[Token(Token = "0x6006F50")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass44_0()
		{
		}

		[Token(Token = "0x6006F51")]
		[Address(RVA = "0x71FA70", Offset = "0x71EC70", VA = "0x18071FA70")]
		internal void _003CstepContinuingAdultApproval_003Eb__0(bool res)
		{
		}
	}

	[Token(Token = "0x20011C4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass45_0
	{
		[Token(Token = "0x400B8CB")]
		[FieldOffset(Offset = "0x10")]
		public int res_year;

		[Token(Token = "0x400B8CC")]
		[FieldOffset(Offset = "0x14")]
		public int res_month;

		[Token(Token = "0x400B8CD")]
		[FieldOffset(Offset = "0x18")]
		public int res_day;

		[Token(Token = "0x6006F52")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass45_0()
		{
		}

		[Token(Token = "0x6006F53")]
		[Address(RVA = "0xB6CE90", Offset = "0xB6C090", VA = "0x180B6CE90")]
		internal void _003CstepReagreementAgeGate_003Eb__0(int _year, int _month, int _day)
		{
		}
	}

	[Token(Token = "0x20011C5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass46_0
	{
		[Token(Token = "0x400B8CE")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x6006F54")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass46_0()
		{
		}

		[Token(Token = "0x6006F55")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepReagreementTermOfService_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x20011C6")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass47_0
	{
		[Token(Token = "0x400B8CF")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x6006F56")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass47_0()
		{
		}

		[Token(Token = "0x6006F57")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepReagreementPrivacyPolicy_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x20011C7")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass48_0
	{
		[Token(Token = "0x400B8D0")]
		[FieldOffset(Offset = "0x10")]
		public int resultCode;

		[Token(Token = "0x6006F58")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass48_0()
		{
		}

		[Token(Token = "0x6006F59")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CstepReagree_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011C8")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass49_0
	{
		[Token(Token = "0x400B8D1")]
		[FieldOffset(Offset = "0x10")]
		public string input_str;

		[Token(Token = "0x400B8D2")]
		[FieldOffset(Offset = "0x18")]
		public bool successed;

		[Token(Token = "0x6006F5A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass49_0()
		{
		}

		[Token(Token = "0x6006F5B")]
		[Address(RVA = "0x439010", Offset = "0x438210", VA = "0x180439010")]
		internal void _003CstepPasswordInput_003Eb__0(string str)
		{
		}

		[Token(Token = "0x6006F5C")]
		[Address(RVA = "0x662770", Offset = "0x661970", VA = "0x180662770")]
		internal void _003CstepPasswordInput_003Eb__1(bool _success)
		{
		}
	}

	[Token(Token = "0x20011CA")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass55_0
	{
		[Token(Token = "0x400B8D6")]
		[FieldOffset(Offset = "0x10")]
		public int countryCode;

		[Token(Token = "0x400B8D7")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6006F60")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass55_0()
		{
		}

		[Token(Token = "0x6006F61")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallCountrySelectView_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011CB")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass56_0
	{
		[Token(Token = "0x400B8D8")]
		[FieldOffset(Offset = "0x10")]
		public int stateCode;

		[Token(Token = "0x400B8D9")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6006F62")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass56_0()
		{
		}

		[Token(Token = "0x6006F63")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallUSAStateSelectView_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011CC")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass57_0
	{
		[Token(Token = "0x400B8DA")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x400B8DB")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6006F64")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass57_0()
		{
		}

		[Token(Token = "0x6006F65")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallTermOfServiceView_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x20011CD")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass58_0
	{
		[Token(Token = "0x400B8DC")]
		[FieldOffset(Offset = "0x10")]
		public int result;

		[Token(Token = "0x400B8DD")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6006F66")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass58_0()
		{
		}

		[Token(Token = "0x6006F67")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallPrivacyPolicyView_003Eb__0(int res)
		{
		}
	}

	[Token(Token = "0x20011CE")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass59_0
	{
		[Token(Token = "0x400B8DE")]
		[FieldOffset(Offset = "0x10")]
		public int res_age;

		[Token(Token = "0x400B8DF")]
		[FieldOffset(Offset = "0x14")]
		public bool wait;

		[Token(Token = "0x6006F68")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass59_0()
		{
		}

		[Token(Token = "0x6006F69")]
		[Address(RVA = "0xB6CFF0", Offset = "0xB6C1F0", VA = "0x180B6CFF0")]
		internal void _003CcallAgeSelectView_003Eb__0(int _age)
		{
		}
	}

	[Token(Token = "0x20011CF")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass60_0
	{
		[Token(Token = "0x400B8E0")]
		[FieldOffset(Offset = "0x10")]
		public int res_year;

		[Token(Token = "0x400B8E1")]
		[FieldOffset(Offset = "0x14")]
		public int res_month;

		[Token(Token = "0x400B8E2")]
		[FieldOffset(Offset = "0x18")]
		public int res_day;

		[Token(Token = "0x400B8E3")]
		[FieldOffset(Offset = "0x1C")]
		public bool wait;

		[Token(Token = "0x6006F6A")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass60_0()
		{
		}

		[Token(Token = "0x6006F6B")]
		[Address(RVA = "0xB6D000", Offset = "0xB6C200", VA = "0x180B6D000")]
		internal void _003CcallBirthdateSelectView_003Eb__0(int _year, int _month, int _day)
		{
		}
	}

	[Token(Token = "0x20011D0")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass61_0
	{
		[Token(Token = "0x400B8E4")]
		[FieldOffset(Offset = "0x10")]
		public bool res_approved;

		[Token(Token = "0x400B8E5")]
		[FieldOffset(Offset = "0x11")]
		public bool wait;

		[Token(Token = "0x6006F6C")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass61_0()
		{
		}

		[Token(Token = "0x6006F6D")]
		[Address(RVA = "0x997550", Offset = "0x996750", VA = "0x180997550")]
		internal void _003CcallAdultApprovalView_003Eb__0(bool _res)
		{
		}
	}

	[Token(Token = "0x20011D1")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass63_0
	{
		[Token(Token = "0x400B8E6")]
		[FieldOffset(Offset = "0x10")]
		public int res_age;

		[Token(Token = "0x6006F6E")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass63_0()
		{
		}

		[Token(Token = "0x6006F6F")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CshowAgeGate_003Eb__0(int _age)
		{
		}
	}

	[Token(Token = "0x20011D2")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass63_1
	{
		[Token(Token = "0x400B8E7")]
		[FieldOffset(Offset = "0x10")]
		public int res_year;

		[Token(Token = "0x400B8E8")]
		[FieldOffset(Offset = "0x14")]
		public int res_month;

		[Token(Token = "0x400B8E9")]
		[FieldOffset(Offset = "0x18")]
		public int res_day;

		[Token(Token = "0x6006F70")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass63_1()
		{
		}

		[Token(Token = "0x6006F71")]
		[Address(RVA = "0xB6CE90", Offset = "0xB6C090", VA = "0x180B6CE90")]
		internal void _003CshowAgeGate_003Eb__1(int _year, int _month, int _day)
		{
		}
	}

	[Token(Token = "0x20011D3")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass64_0
	{
		[Token(Token = "0x400B8EA")]
		[FieldOffset(Offset = "0x10")]
		public int apiCode;

		[Token(Token = "0x6006F72")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass64_0()
		{
		}

		[Token(Token = "0x6006F73")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CverifyAgeGate_003Eb__0(int code)
		{
		}
	}

	[Token(Token = "0x20011D4")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass64_1
	{
		[Token(Token = "0x400B8EB")]
		[FieldOffset(Offset = "0x10")]
		public int requirementCode;

		[Token(Token = "0x6006F74")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass64_1()
		{
		}

		[Token(Token = "0x6006F75")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		internal void _003CverifyAgeGate_003Eb__1(int code)
		{
		}
	}

	[Token(Token = "0x20011D5")]
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass66_0
	{
		[Token(Token = "0x400B8EC")]
		[FieldOffset(Offset = "0x10")]
		public bool wait;

		[Token(Token = "0x6006F76")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public _003C_003Ec__DisplayClass66_0()
		{
		}

		[Token(Token = "0x6006F77")]
		[Address(RVA = "0x75BCB0", Offset = "0x75AEB0", VA = "0x18075BCB0")]
		internal void _003CshowErrorDialog_003Eb__0()
		{
		}
	}

	[Token(Token = "0x20011D6")]
	[CompilerGenerated]
	private sealed class _003CcallAdultApprovalView_003Ed__61 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B8ED")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B8EE")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B8EF")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B8F0")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass61_0 _003C_003E8__1;

		[Token(Token = "0x400B8F1")]
		[FieldOffset(Offset = "0x30")]
		public Action<bool> resultCallback;

		[Token(Token = "0x1700116E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F7B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700116F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006F7D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F78")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallAdultApprovalView_003Ed__61(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F79")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F7A")]
		[Address(RVA = "0xB6D390", Offset = "0xB6C590", VA = "0x180B6D390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F7C")]
		[Address(RVA = "0xB6D590", Offset = "0xB6C790", VA = "0x180B6D590", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011D7")]
	[CompilerGenerated]
	private sealed class _003CcallAgeSelectView_003Ed__59 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B8F2")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B8F3")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B8F4")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B8F5")]
		[FieldOffset(Offset = "0x28")]
		public int ageDefault;

		[Token(Token = "0x400B8F6")]
		[FieldOffset(Offset = "0x2C")]
		public int ageAvailable;

		[Token(Token = "0x400B8F7")]
		[FieldOffset(Offset = "0x30")]
		public int ageMin;

		[Token(Token = "0x400B8F8")]
		[FieldOffset(Offset = "0x34")]
		public int ageMax;

		[Token(Token = "0x400B8F9")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass59_0 _003C_003E8__1;

		[Token(Token = "0x400B8FA")]
		[FieldOffset(Offset = "0x40")]
		public Action<int> resultCallback;

		[Token(Token = "0x17001170")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F81")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001171")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006F83")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F7E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallAgeSelectView_003Ed__59(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F7F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F80")]
		[Address(RVA = "0xB6D5D0", Offset = "0xB6C7D0", VA = "0x180B6D5D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F82")]
		[Address(RVA = "0xB6D7F0", Offset = "0xB6C9F0", VA = "0x180B6D7F0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011D8")]
	[CompilerGenerated]
	private sealed class _003CcallBirthdateSelectView_003Ed__60 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B8FB")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B8FC")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B8FD")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B8FE")]
		[FieldOffset(Offset = "0x28")]
		public int defaultYear;

		[Token(Token = "0x400B8FF")]
		[FieldOffset(Offset = "0x2C")]
		public int defaultMonth;

		[Token(Token = "0x400B900")]
		[FieldOffset(Offset = "0x30")]
		public int defaultDay;

		[Token(Token = "0x400B901")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass60_0 _003C_003E8__1;

		[Token(Token = "0x400B902")]
		[FieldOffset(Offset = "0x40")]
		public Action<int, int, int> resultCallback;

		[Token(Token = "0x17001172")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F87")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001173")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006F89")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F84")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallBirthdateSelectView_003Ed__60(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F85")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F86")]
		[Address(RVA = "0xB6D830", Offset = "0xB6CA30", VA = "0x180B6D830", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F88")]
		[Address(RVA = "0xB6DA80", Offset = "0xB6CC80", VA = "0x180B6DA80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011D9")]
	[CompilerGenerated]
	private sealed class _003CcallCountrySelectView_003Ed__55 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B903")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B904")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B905")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B906")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass55_0 _003C_003E8__1;

		[Token(Token = "0x400B907")]
		[FieldOffset(Offset = "0x30")]
		public Action<int> resultCallback;

		[Token(Token = "0x17001174")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F8D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001175")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006F8F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F8A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallCountrySelectView_003Ed__55(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F8B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F8C")]
		[Address(RVA = "0xB6DAC0", Offset = "0xB6CCC0", VA = "0x180B6DAC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F8E")]
		[Address(RVA = "0xB6DD30", Offset = "0xB6CF30", VA = "0x180B6DD30", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011DA")]
	[CompilerGenerated]
	private sealed class _003CcallPrivacyPolicyView_003Ed__58 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B908")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B909")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B90A")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B90B")]
		[FieldOffset(Offset = "0x28")]
		public UserAgreementType agreementType;

		[Token(Token = "0x400B90C")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass58_0 _003C_003E8__1;

		[Token(Token = "0x400B90D")]
		[FieldOffset(Offset = "0x38")]
		public Action<int> resultCallback;

		[Token(Token = "0x17001176")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F93")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001177")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006F95")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F90")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallPrivacyPolicyView_003Ed__58(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F91")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F92")]
		[Address(RVA = "0xB6DD70", Offset = "0xB6CF70", VA = "0x180B6DD70", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F94")]
		[Address(RVA = "0xB6DF80", Offset = "0xB6D180", VA = "0x180B6DF80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011DB")]
	[CompilerGenerated]
	private sealed class _003CcallTermOfServiceView_003Ed__57 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B90E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B90F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B910")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B911")]
		[FieldOffset(Offset = "0x28")]
		public UserAgreementType agreementType;

		[Token(Token = "0x400B912")]
		[FieldOffset(Offset = "0x30")]
		public string url;

		[Token(Token = "0x400B913")]
		[FieldOffset(Offset = "0x38")]
		private _003C_003Ec__DisplayClass57_0 _003C_003E8__1;

		[Token(Token = "0x400B914")]
		[FieldOffset(Offset = "0x40")]
		public Action<int> resultCallback;

		[Token(Token = "0x17001178")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F99")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001179")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006F9B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F96")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallTermOfServiceView_003Ed__57(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F97")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F98")]
		[Address(RVA = "0xB6DFC0", Offset = "0xB6D1C0", VA = "0x180B6DFC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006F9A")]
		[Address(RVA = "0xB6E1E0", Offset = "0xB6D3E0", VA = "0x180B6E1E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011DC")]
	[CompilerGenerated]
	private sealed class _003CcallUSAStateSelectView_003Ed__56 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B915")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B916")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B917")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B918")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass56_0 _003C_003E8__1;

		[Token(Token = "0x400B919")]
		[FieldOffset(Offset = "0x30")]
		public Action<int> resultCallback;

		[Token(Token = "0x1700117A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006F9F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700117B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FA1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006F9C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CcallUSAStateSelectView_003Ed__56(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006F9D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006F9E")]
		[Address(RVA = "0xB6E220", Offset = "0xB6D420", VA = "0x180B6E220", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FA0")]
		[Address(RVA = "0xB6E490", Offset = "0xB6D690", VA = "0x180B6E490", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011DD")]
	[CompilerGenerated]
	private sealed class _003CshowAgeGate_003Ed__63 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B91A")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B91B")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B91C")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B91D")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass63_0 _003C_003E8__1;

		[Token(Token = "0x400B91E")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass63_1 _003C_003E8__2;

		[Token(Token = "0x400B91F")]
		[FieldOffset(Offset = "0x38")]
		public Action<AgeGateViewResultType> resultCallback;

		[Token(Token = "0x1700117C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FA5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700117D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FA7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FA2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowAgeGate_003Ed__63(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FA3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FA4")]
		[Address(RVA = "0xB6E590", Offset = "0xB6D790", VA = "0x180B6E590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FA6")]
		[Address(RVA = "0xB6EA10", Offset = "0xB6DC10", VA = "0x180B6EA10", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011DE")]
	[CompilerGenerated]
	private sealed class _003CshowAgeGateIntroDialog_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B920")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B921")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B922")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x1700117E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FAB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700117F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FAD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FA8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowAgeGateIntroDialog_003Ed__8(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FA9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FAA")]
		[Address(RVA = "0xB6E4D0", Offset = "0xB6D6D0", VA = "0x180B6E4D0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FAC")]
		[Address(RVA = "0xB6E550", Offset = "0xB6D750", VA = "0x180B6E550", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011DF")]
	[CompilerGenerated]
	private sealed class _003CshowErrorAndAbort_003Ed__65 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B923")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B924")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B925")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x400B926")]
		[FieldOffset(Offset = "0x28")]
		public string msg;

		[Token(Token = "0x400B927")]
		[FieldOffset(Offset = "0x30")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x17001180")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FB1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001181")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FB3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FAE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowErrorAndAbort_003Ed__65(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FAF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FB0")]
		[Address(RVA = "0xB6EA50", Offset = "0xB6DC50", VA = "0x180B6EA50", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FB2")]
		[Address(RVA = "0xB6EB00", Offset = "0xB6DD00", VA = "0x180B6EB00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E0")]
	[CompilerGenerated]
	private sealed class _003CshowErrorDialog_003Ed__66 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B928")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B929")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B92A")]
		[FieldOffset(Offset = "0x20")]
		public string title;

		[Token(Token = "0x400B92B")]
		[FieldOffset(Offset = "0x28")]
		public string msg;

		[Token(Token = "0x400B92C")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass66_0 _003C_003E8__1;

		[Token(Token = "0x17001182")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FB7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001183")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FB9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FB4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CshowErrorDialog_003Ed__66(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FB5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FB6")]
		[Address(RVA = "0xB6EB40", Offset = "0xB6DD40", VA = "0x180B6EB40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FB8")]
		[Address(RVA = "0xB6ED00", Offset = "0xB6DF00", VA = "0x180B6ED00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E1")]
	[CompilerGenerated]
	private sealed class _003CstepAccountCreate_003Ed__40 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B92D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B92E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B92F")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B930")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x400B931")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass40_0 _003C_003E8__1;

		[Token(Token = "0x17001184")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FBD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001185")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FBF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FBA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepAccountCreate_003Ed__40(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FBB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FBC")]
		[Address(RVA = "0xB6ED40", Offset = "0xB6DF40", VA = "0x180B6ED40", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FBE")]
		[Address(RVA = "0xB6F180", Offset = "0xB6E380", VA = "0x180B6F180", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E2")]
	[CompilerGenerated]
	private sealed class _003CstepAdditionalUSAStateSelect_003Ed__42 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B932")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B933")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B934")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B935")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass42_0 _003C_003E8__1;

		[Token(Token = "0x400B936")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17001186")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FC3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001187")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FC5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FC0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepAdditionalUSAStateSelect_003Ed__42(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FC1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FC2")]
		[Address(RVA = "0xB6F1C0", Offset = "0xB6E3C0", VA = "0x180B6F1C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FC4")]
		[Address(RVA = "0xB6F550", Offset = "0xB6E750", VA = "0x180B6F550", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E3")]
	[CompilerGenerated]
	private sealed class _003CstepContinuingAdultApproval_003Ed__44 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B937")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B938")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B939")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B93A")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass44_0 _003C_003E8__1;

		[Token(Token = "0x400B93B")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17001188")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FC9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001189")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FCB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FC6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepContinuingAdultApproval_003Ed__44(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FC7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0xB6F590", Offset = "0xB6E790", VA = "0x180B6F590", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0xB6F740", Offset = "0xB6E940", VA = "0x180B6F740", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E4")]
	[CompilerGenerated]
	private sealed class _003CstepContinuingAgeGate_003Ed__43 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B93C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B93D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B93E")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B93F")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass43_0 _003C_003E8__1;

		[Token(Token = "0x400B940")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass43_1 _003C_003E8__2;

		[Token(Token = "0x400B941")]
		[FieldOffset(Offset = "0x38")]
		public StepSequencer seq;

		[Token(Token = "0x1700118A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FCF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700118B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FD1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepContinuingAgeGate_003Ed__43(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FCD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FCE")]
		[Address(RVA = "0xB6F780", Offset = "0xB6E980", VA = "0x180B6F780", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FD0")]
		[Address(RVA = "0xB6FC50", Offset = "0xB6EE50", VA = "0x180B6FC50", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E5")]
	[CompilerGenerated]
	private sealed class _003CstepCountrySelect_003Ed__32 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B942")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B943")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B944")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B945")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass32_0 _003C_003E8__1;

		[Token(Token = "0x400B946")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x1700118C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FD5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700118D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FD7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FD2")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepCountrySelect_003Ed__32(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FD3")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FD4")]
		[Address(RVA = "0xB6FC90", Offset = "0xB6EE90", VA = "0x180B6FC90", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FD6")]
		[Address(RVA = "0xB6FEE0", Offset = "0xB6F0E0", VA = "0x180B6FEE0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E6")]
	[CompilerGenerated]
	private sealed class _003CstepExistingLogin_003Ed__41 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B947")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B948")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B949")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B94A")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass41_0 _003C_003E8__1;

		[Token(Token = "0x400B94B")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass41_1 _003C_003E8__2;

		[Token(Token = "0x400B94C")]
		[FieldOffset(Offset = "0x38")]
		public StepSequencer seq;

		[Token(Token = "0x400B94D")]
		[FieldOffset(Offset = "0x40")]
		private _003C_003Ec__DisplayClass41_2 _003C_003E8__3;

		[Token(Token = "0x400B94E")]
		[FieldOffset(Offset = "0x48")]
		private AccountUtility.BanType _003Ctype_003E5__2;

		[Token(Token = "0x1700118E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FDB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700118F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FDD")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FD8")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepExistingLogin_003Ed__41(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FD9")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FDA")]
		[Address(RVA = "0xB6FF20", Offset = "0xB6F120", VA = "0x180B6FF20", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FDC")]
		[Address(RVA = "0xB706E0", Offset = "0xB6F8E0", VA = "0x180B706E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E7")]
	[CompilerGenerated]
	private sealed class _003CstepPasswordInput_003Ed__49 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B94F")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B950")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B951")]
		[FieldOffset(Offset = "0x20")]
		private _003C_003Ec__DisplayClass49_0 _003C_003E8__1;

		[Token(Token = "0x400B952")]
		[FieldOffset(Offset = "0x28")]
		public StepSequencer seq;

		[Token(Token = "0x17001190")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FE1")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001191")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FE3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FDE")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepPasswordInput_003Ed__49(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FDF")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FE0")]
		[Address(RVA = "0xB82340", Offset = "0xB81540", VA = "0x180B82340", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FE2")]
		[Address(RVA = "0xB82570", Offset = "0xB81770", VA = "0x180B82570", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E8")]
	[CompilerGenerated]
	private sealed class _003CstepReagree_003Ed__48 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B953")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B954")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B955")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B956")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

		[Token(Token = "0x400B957")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17001192")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FE7")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001193")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FE9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FE4")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagree_003Ed__48(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FE5")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FE6")]
		[Address(RVA = "0xB82890", Offset = "0xB81A90", VA = "0x180B82890", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FE8")]
		[Address(RVA = "0xB82B00", Offset = "0xB81D00", VA = "0x180B82B00", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011E9")]
	[CompilerGenerated]
	private sealed class _003CstepReagreementAgeGate_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B958")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B959")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B95A")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B95B")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass45_0 _003C_003E8__1;

		[Token(Token = "0x400B95C")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17001194")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FED")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001195")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FEF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FEA")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagreementAgeGate_003Ed__45(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FEB")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FEC")]
		[Address(RVA = "0xB82E30", Offset = "0xB82030", VA = "0x180B82E30", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FEE")]
		[Address(RVA = "0xB830A0", Offset = "0xB822A0", VA = "0x180B830A0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011EA")]
	[CompilerGenerated]
	private sealed class _003CstepReagreementPrivacyPolicy_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B95D")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B95E")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B95F")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B960")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass47_0 _003C_003E8__1;

		[Token(Token = "0x400B961")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17001196")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FF3")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001197")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FF5")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FF0")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagreementPrivacyPolicy_003Ed__47(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FF1")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FF2")]
		[Address(RVA = "0xB83310", Offset = "0xB82510", VA = "0x180B83310", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FF4")]
		[Address(RVA = "0xB834B0", Offset = "0xB826B0", VA = "0x180B834B0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011EB")]
	[CompilerGenerated]
	private sealed class _003CstepReagreementTermOfService_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B962")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B963")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B964")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B965")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

		[Token(Token = "0x400B966")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x17001198")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FF9")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17001199")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6006FFB")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FF6")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepReagreementTermOfService_003Ed__46(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FF7")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FF8")]
		[Address(RVA = "0xB83770", Offset = "0xB82970", VA = "0x180B83770", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6006FFA")]
		[Address(RVA = "0xB83970", Offset = "0xB82B70", VA = "0x180B83970", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011EC")]
	[CompilerGenerated]
	private sealed class _003CstepStartSurvey_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B967")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B968")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B969")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B96A")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

		[Token(Token = "0x400B96B")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x1700119A")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6006FFF")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700119B")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007001")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6006FFC")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartSurvey_003Ed__39(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6006FFD")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6006FFE")]
		[Address(RVA = "0xB83BE0", Offset = "0xB82DE0", VA = "0x180B83BE0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007000")]
		[Address(RVA = "0xB83D80", Offset = "0xB82F80", VA = "0x180B83D80", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011ED")]
	[CompilerGenerated]
	private sealed class _003CstepStartingAdultApproval_003Ed__36 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B96C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B96D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B96E")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B96F")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass36_0 _003C_003E8__1;

		[Token(Token = "0x400B970")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x1700119C")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007005")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700119D")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007007")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007002")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingAdultApproval_003Ed__36(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007003")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007004")]
		[Address(RVA = "0xB83DC0", Offset = "0xB82FC0", VA = "0x180B83DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007006")]
		[Address(RVA = "0xB83F60", Offset = "0xB83160", VA = "0x180B83F60", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011EE")]
	[CompilerGenerated]
	private sealed class _003CstepStartingAgeGate_003Ed__35 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B971")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B972")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B973")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B974")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass35_0 _003C_003E8__1;

		[Token(Token = "0x400B975")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass35_1 _003C_003E8__2;

		[Token(Token = "0x400B976")]
		[FieldOffset(Offset = "0x38")]
		public StepSequencer seq;

		[Token(Token = "0x1700119E")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600700B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700119F")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600700D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007008")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingAgeGate_003Ed__35(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007009")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600700A")]
		[Address(RVA = "0xB84290", Offset = "0xB83490", VA = "0x180B84290", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600700C")]
		[Address(RVA = "0xB84670", Offset = "0xB83870", VA = "0x180B84670", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011EF")]
	[CompilerGenerated]
	private sealed class _003CstepStartingPrivacyPolicy_003Ed__38 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B977")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B978")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B979")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B97A")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass38_0 _003C_003E8__1;

		[Token(Token = "0x400B97B")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011A0")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007011")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A1")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007013")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600700E")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingPrivacyPolicy_003Ed__38(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600700F")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007010")]
		[Address(RVA = "0xB848E0", Offset = "0xB83AE0", VA = "0x180B848E0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007012")]
		[Address(RVA = "0xB84A90", Offset = "0xB83C90", VA = "0x180B84A90", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011F0")]
	[CompilerGenerated]
	private sealed class _003CstepStartingTermOfService_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B97C")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B97D")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B97E")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B97F")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		[Token(Token = "0x400B980")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011A2")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007017")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A3")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007019")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007014")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepStartingTermOfService_003Ed__37(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007015")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007016")]
		[Address(RVA = "0xB84DC0", Offset = "0xB83FC0", VA = "0x180B84DC0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007018")]
		[Address(RVA = "0xB85020", Offset = "0xB84220", VA = "0x180B85020", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011F1")]
	[CompilerGenerated]
	private sealed class _003CstepSurveySetting_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B981")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B982")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B983")]
		[FieldOffset(Offset = "0x20")]
		public StepSequencer seq;

		[Token(Token = "0x170011A4")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600701D")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A5")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600701F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600701A")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepSurveySetting_003Ed__50(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600701B")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600701C")]
		[Address(RVA = "0xB851C0", Offset = "0xB843C0", VA = "0x180B851C0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600701E")]
		[Address(RVA = "0xB852E0", Offset = "0xB844E0", VA = "0x180B852E0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011F2")]
	[CompilerGenerated]
	private sealed class _003CstepUSAStateSelect_003Ed__33 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B984")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B985")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B986")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B987")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass33_0 _003C_003E8__1;

		[Token(Token = "0x400B988")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011A6")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007023")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A7")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007025")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007020")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepUSAStateSelect_003Ed__33(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007021")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007022")]
		[Address(RVA = "0xB85640", Offset = "0xB84840", VA = "0x180B85640", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007024")]
		[Address(RVA = "0xB857D0", Offset = "0xB849D0", VA = "0x180B857D0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011F3")]
	[CompilerGenerated]
	private sealed class _003CstepkID_GetRequirement_003Ed__34 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B989")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B98A")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B98B")]
		[FieldOffset(Offset = "0x20")]
		public GameEntrySequenceV2ViewController _003C_003E4__this;

		[Token(Token = "0x400B98C")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass34_0 _003C_003E8__1;

		[Token(Token = "0x400B98D")]
		[FieldOffset(Offset = "0x30")]
		public StepSequencer seq;

		[Token(Token = "0x170011A8")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x6007029")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011A9")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600702B")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6007026")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CstepkID_GetRequirement_003Ed__34(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6007027")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x6007028")]
		[Address(RVA = "0xB85810", Offset = "0xB84A10", VA = "0x180B85810", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600702A")]
		[Address(RVA = "0xB85BD0", Offset = "0xB84DD0", VA = "0x180B85BD0", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x20011F4")]
	[CompilerGenerated]
	private sealed class _003CverifyAgeGate_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400B98E")]
		[FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[Token(Token = "0x400B98F")]
		[FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[Token(Token = "0x400B990")]
		[FieldOffset(Offset = "0x20")]
		public UserData userData;

		[Token(Token = "0x400B991")]
		[FieldOffset(Offset = "0x28")]
		private _003C_003Ec__DisplayClass64_0 _003C_003E8__1;

		[Token(Token = "0x400B992")]
		[FieldOffset(Offset = "0x30")]
		private _003C_003Ec__DisplayClass64_1 _003C_003E8__2;

		[Token(Token = "0x400B993")]
		[FieldOffset(Offset = "0x38")]
		public Action<AgeGateCheckResultType> resultCallback;

		[Token(Token = "0x400B994")]
		[FieldOffset(Offset = "0x40")]
		private int _003Cretry_remain_003E5__2;

		[Token(Token = "0x170011AA")]
		private object System_002ECollections_002EGeneric_002EIEnumerator_003CSystem_002EObject_003E_002ECurrent
		{
			[Token(Token = "0x600702F")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x170011AB")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x6007031")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600702C")]
		[Address(RVA = "0x3E7E80", Offset = "0x3E7080", VA = "0x1803E7E80")]
		[DebuggerHidden]
		public _003CverifyAgeGate_003Ed__64(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x600702D")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "5")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600702E")]
		[Address(RVA = "0xB85C10", Offset = "0xB84E10", VA = "0x180B85C10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6007030")]
		[Address(RVA = "0xB86020", Offset = "0xB85220", VA = "0x180B86020", Slot = "8")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400B885")]
	[FieldOffset(Offset = "0xD0")]
	private StepSequencer m_sequencer;

	[Token(Token = "0x400B886")]
	[FieldOffset(Offset = "0xD8")]
	private Stack<Step> m_backSteps;

	[Token(Token = "0x400B887")]
	[FieldOffset(Offset = "0xE0")]
	private UserData m_userData;

	[Token(Token = "0x400B888")]
	[FieldOffset(Offset = "0xE8")]
	private CountryList m_countryList;

	[Token(Token = "0x400B889")]
	[FieldOffset(Offset = "0xF0")]
	private USAStateList m_stateList;

	[Token(Token = "0x400B88A")]
	[FieldOffset(Offset = "0xF8")]
	private bool m_showAgeGateIntroDialog;

	[Token(Token = "0x400B88B")]
	private const int k_ageDefault = 0;

	[Token(Token = "0x400B88C")]
	private const int k_ageAvailable = 1;

	[Token(Token = "0x400B88D")]
	private const int k_ageMin = 0;

	[Token(Token = "0x400B88E")]
	private const int k_ageMax = 35;

	[Token(Token = "0x400B88F")]
	private const int k_birthYearDefault = 0;

	[Token(Token = "0x400B890")]
	private const int k_birthMonthDefault = 0;

	[Token(Token = "0x400B891")]
	private const int k_birthDayDefault = 0;

	[Token(Token = "0x1700116D")]
	protected override Type[] textIds
	{
		[Token(Token = "0x6006EFD")]
		[Address(RVA = "0xB5E1E0", Offset = "0xB5D3E0", VA = "0x180B5E1E0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6006EF6")]
	[Address(RVA = "0xB5E820", Offset = "0xB5DA20", VA = "0x180B5E820")]
	[IteratorStateMachine(typeof(_003CshowAgeGateIntroDialog_003Ed__8))]
	private IEnumerator showAgeGateIntroDialog()
	{
		return null;
	}

	[Token(Token = "0x6006EF7")]
	[Address(RVA = "0xB5E690", Offset = "0xB5D890", VA = "0x180B5E690")]
	private void saveChallengeResumeData()
	{
	}

	[Token(Token = "0x6006EF8")]
	[Address(RVA = "0xB5E370", Offset = "0xB5D570", VA = "0x180B5E370")]
	private bool loadChallengeResumeData()
	{
		return default(bool);
	}

	[Token(Token = "0x6006EF9")]
	[Address(RVA = "0xB5DE00", Offset = "0xB5D000", VA = "0x180B5DE00")]
	private void clearChallengeResumeData()
	{
	}

	[Token(Token = "0x6006EFA")]
	[Address(RVA = "0xB5DF80", Offset = "0xB5D180", VA = "0x180B5DF80")]
	private UserAgreementType currentAgreementType()
	{
		return default(UserAgreementType);
	}

	[Token(Token = "0x6006EFB")]
	[Address(RVA = "0xB5E320", Offset = "0xB5D520", VA = "0x180B5E320")]
	private static bool isMobile()
	{
		return default(bool);
	}

	[Token(Token = "0x6006EFC")]
	[Address(RVA = "0xB5E0D0", Offset = "0xB5D2D0", VA = "0x180B5E0D0")]
	private static AccountUtility.PrivacyOptionType getUSAPrivacyOption(UserData userData)
	{
		return default(AccountUtility.PrivacyOptionType);
	}

	[Token(Token = "0x6006EFE")]
	[Address(RVA = "0xB5CAA0", Offset = "0xB5BCA0", VA = "0x180B5CAA0", Slot = "6")]
	public override void NotificationStackEntry()
	{
	}

	[Token(Token = "0x6006EFF")]
	[Address(RVA = "0xB5D570", Offset = "0xB5C770", VA = "0x180B5D570", Slot = "7")]
	public override void NotificationStackRemove()
	{
	}

	[Token(Token = "0x6006F00")]
	[Address(RVA = "0x755580", Offset = "0x754780", VA = "0x180755580")]
	private void Update()
	{
	}

	[Token(Token = "0x6006F01")]
	[Address(RVA = "0xB5E7C0", Offset = "0xB5D9C0", VA = "0x180B5E7C0")]
	private void saveStepHistory(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006F02")]
	[Address(RVA = "0xB5D870", Offset = "0xB5CA70", VA = "0x180B5D870")]
	private void backStepHistory(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006F03")]
	[Address(RVA = "0xB5DE10", Offset = "0xB5D010", VA = "0x180B5DE10")]
	private void clearStepHistory()
	{
	}

	[Token(Token = "0x6006F04")]
	[Address(RVA = "0xB5DE60", Offset = "0xB5D060", VA = "0x180B5DE60")]
	private IntroductionBackDialogSetting createBackConfirmSetting()
	{
		return null;
	}

	[Token(Token = "0x6006F05")]
	[Address(RVA = "0xB5F470", Offset = "0xB5E670", VA = "0x180B5F470")]
	private void stepStart(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006F06")]
	[Address(RVA = "0xB5ECA0", Offset = "0xB5DEA0", VA = "0x180B5ECA0")]
	[IteratorStateMachine(typeof(_003CstepCountrySelect_003Ed__32))]
	private IEnumerator stepCountrySelect(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F07")]
	[Address(RVA = "0xB5F820", Offset = "0xB5EA20", VA = "0x180B5F820")]
	[IteratorStateMachine(typeof(_003CstepUSAStateSelect_003Ed__33))]
	private IEnumerator stepUSAStateSelect(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F08")]
	[Address(RVA = "0xB5F8B0", Offset = "0xB5EAB0", VA = "0x180B5F8B0")]
	[IteratorStateMachine(typeof(_003CstepkID_GetRequirement_003Ed__34))]
	private IEnumerator stepkID_GetRequirement(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F09")]
	[Address(RVA = "0xB5F600", Offset = "0xB5E800", VA = "0x180B5F600")]
	[IteratorStateMachine(typeof(_003CstepStartingAgeGate_003Ed__35))]
	private IEnumerator stepStartingAgeGate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F0A")]
	[Address(RVA = "0xB5F570", Offset = "0xB5E770", VA = "0x180B5F570")]
	[IteratorStateMachine(typeof(_003CstepStartingAdultApproval_003Ed__36))]
	private IEnumerator stepStartingAdultApproval(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F0B")]
	[Address(RVA = "0xB5F720", Offset = "0xB5E920", VA = "0x180B5F720")]
	[IteratorStateMachine(typeof(_003CstepStartingTermOfService_003Ed__37))]
	private IEnumerator stepStartingTermOfService(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F0C")]
	[Address(RVA = "0xB5F690", Offset = "0xB5E890", VA = "0x180B5F690")]
	[IteratorStateMachine(typeof(_003CstepStartingPrivacyPolicy_003Ed__38))]
	private IEnumerator stepStartingPrivacyPolicy(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F0D")]
	[Address(RVA = "0xB5F3E0", Offset = "0xB5E5E0", VA = "0x180B5F3E0")]
	[IteratorStateMachine(typeof(_003CstepStartSurvey_003Ed__39))]
	private IEnumerator stepStartSurvey(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F0E")]
	[Address(RVA = "0xB5EA60", Offset = "0xB5DC60", VA = "0x180B5EA60")]
	[IteratorStateMachine(typeof(_003CstepAccountCreate_003Ed__40))]
	private IEnumerator stepAccountCreate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F0F")]
	[Address(RVA = "0xB5EDD0", Offset = "0xB5DFD0", VA = "0x180B5EDD0")]
	[IteratorStateMachine(typeof(_003CstepExistingLogin_003Ed__41))]
	private IEnumerator stepExistingLogin(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F10")]
	[Address(RVA = "0xB5EAF0", Offset = "0xB5DCF0", VA = "0x180B5EAF0")]
	[IteratorStateMachine(typeof(_003CstepAdditionalUSAStateSelect_003Ed__42))]
	private IEnumerator stepAdditionalUSAStateSelect(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F11")]
	[Address(RVA = "0xB5EC10", Offset = "0xB5DE10", VA = "0x180B5EC10")]
	[IteratorStateMachine(typeof(_003CstepContinuingAgeGate_003Ed__43))]
	private IEnumerator stepContinuingAgeGate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F12")]
	[Address(RVA = "0xB5EB80", Offset = "0xB5DD80", VA = "0x180B5EB80")]
	[IteratorStateMachine(typeof(_003CstepContinuingAdultApproval_003Ed__44))]
	private IEnumerator stepContinuingAdultApproval(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F13")]
	[Address(RVA = "0xB5F150", Offset = "0xB5E350", VA = "0x180B5F150")]
	[IteratorStateMachine(typeof(_003CstepReagreementAgeGate_003Ed__45))]
	private IEnumerator stepReagreementAgeGate(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F14")]
	[Address(RVA = "0xB5F270", Offset = "0xB5E470", VA = "0x180B5F270")]
	[IteratorStateMachine(typeof(_003CstepReagreementTermOfService_003Ed__46))]
	private IEnumerator stepReagreementTermOfService(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F15")]
	[Address(RVA = "0xB5F1E0", Offset = "0xB5E3E0", VA = "0x180B5F1E0")]
	[IteratorStateMachine(typeof(_003CstepReagreementPrivacyPolicy_003Ed__47))]
	private IEnumerator stepReagreementPrivacyPolicy(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F16")]
	[Address(RVA = "0xB5F0C0", Offset = "0xB5E2C0", VA = "0x180B5F0C0")]
	[IteratorStateMachine(typeof(_003CstepReagree_003Ed__48))]
	private IEnumerator stepReagree(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F17")]
	[Address(RVA = "0xB5F050", Offset = "0xB5E250", VA = "0x180B5F050")]
	[IteratorStateMachine(typeof(_003CstepPasswordInput_003Ed__49))]
	private IEnumerator stepPasswordInput(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F18")]
	[Address(RVA = "0xB5F7B0", Offset = "0xB5E9B0", VA = "0x180B5F7B0")]
	[IteratorStateMachine(typeof(_003CstepSurveySetting_003Ed__50))]
	private IEnumerator stepSurveySetting(StepSequencer seq)
	{
		return null;
	}

	[Token(Token = "0x6006F19")]
	[Address(RVA = "0xB5F300", Offset = "0xB5E500", VA = "0x180B5F300")]
	private void stepRestoreUnfinishedProducts(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006F1A")]
	[Address(RVA = "0xB5ED30", Offset = "0xB5DF30", VA = "0x180B5ED30")]
	private void stepErrorAbort(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006F1B")]
	[Address(RVA = "0xB5EE60", Offset = "0xB5E060", VA = "0x180B5EE60")]
	private void stepFinish(StepSequencer seq)
	{
	}

	[Token(Token = "0x6006F1C")]
	[Address(RVA = "0xB5E610", Offset = "0xB5D810", VA = "0x180B5E610")]
	private static void quitGameEntry()
	{
	}

	[Token(Token = "0x6006F1D")]
	[Address(RVA = "0xB5DB80", Offset = "0xB5CD80", VA = "0x180B5DB80")]
	[IteratorStateMachine(typeof(_003CcallCountrySelectView_003Ed__55))]
	private IEnumerator callCountrySelectView(Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F1E")]
	[Address(RVA = "0xB5DD70", Offset = "0xB5CF70", VA = "0x180B5DD70")]
	[IteratorStateMachine(typeof(_003CcallUSAStateSelectView_003Ed__56))]
	private IEnumerator callUSAStateSelectView(Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F1F")]
	[Address(RVA = "0xB5DCB0", Offset = "0xB5CEB0", VA = "0x180B5DCB0")]
	[IteratorStateMachine(typeof(_003CcallTermOfServiceView_003Ed__57))]
	private IEnumerator callTermOfServiceView(UserAgreementType agreementType, string url, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F20")]
	[Address(RVA = "0xB5DC10", Offset = "0xB5CE10", VA = "0x180B5DC10")]
	[IteratorStateMachine(typeof(_003CcallPrivacyPolicyView_003Ed__58))]
	private IEnumerator callPrivacyPolicyView(UserAgreementType agreementType, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F21")]
	[Address(RVA = "0xB5DA10", Offset = "0xB5CC10", VA = "0x180B5DA10")]
	[IteratorStateMachine(typeof(_003CcallAgeSelectView_003Ed__59))]
	private IEnumerator callAgeSelectView(int ageDefault, int ageAvailable, int ageMin, int ageMax, Action<int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F22")]
	[Address(RVA = "0xB5DAD0", Offset = "0xB5CCD0", VA = "0x180B5DAD0")]
	[IteratorStateMachine(typeof(_003CcallBirthdateSelectView_003Ed__60))]
	private IEnumerator callBirthdateSelectView(int defaultYear, int defaultMonth, int defaultDay, Action<int, int, int> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F23")]
	[Address(RVA = "0xB5D980", Offset = "0xB5CB80", VA = "0x180B5D980")]
	[IteratorStateMachine(typeof(_003CcallAdultApprovalView_003Ed__61))]
	private IEnumerator callAdultApprovalView(Action<bool> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F24")]
	[Address(RVA = "0xB5E890", Offset = "0xB5DA90", VA = "0x180B5E890")]
	[IteratorStateMachine(typeof(_003CshowAgeGate_003Ed__63))]
	private IEnumerator showAgeGate(Action<AgeGateViewResultType> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F25")]
	[Address(RVA = "0xB5F940", Offset = "0xB5EB40", VA = "0x180B5F940")]
	[IteratorStateMachine(typeof(_003CverifyAgeGate_003Ed__64))]
	private static IEnumerator verifyAgeGate(UserData userData, Action<AgeGateCheckResultType> resultCallback)
	{
		return null;
	}

	[Token(Token = "0x6006F26")]
	[Address(RVA = "0xB5E920", Offset = "0xB5DB20", VA = "0x180B5E920")]
	[IteratorStateMachine(typeof(_003CshowErrorAndAbort_003Ed__65))]
	private IEnumerator showErrorAndAbort(string title, string msg)
	{
		return null;
	}

	[Token(Token = "0x6006F27")]
	[Address(RVA = "0xB5E9D0", Offset = "0xB5DBD0", VA = "0x180B5E9D0")]
	[IteratorStateMachine(typeof(_003CshowErrorDialog_003Ed__66))]
	private static IEnumerator showErrorDialog(string title, string msg)
	{
		return null;
	}

	[Token(Token = "0x6006F28")]
	[Address(RVA = "0x3E3340", Offset = "0x3E2540", VA = "0x1803E3340")]
	public GameEntrySequenceV2ViewController()
	{
	}
}
