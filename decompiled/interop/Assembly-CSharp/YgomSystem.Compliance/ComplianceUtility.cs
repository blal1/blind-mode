using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Compliance;

[Token(Token = "0x200032C")]
public static class ComplianceUtility
{
	[Token(Token = "0x170001FF")]
	public static bool isEnableComplianceCheck
	{
		[Token(Token = "0x60013CB")]
		[Address(RVA = "0x521E30", Offset = "0x521030", VA = "0x180521E30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000200")]
	public static bool shouldAgeGate
	{
		[Token(Token = "0x60013CD")]
		[Address(RVA = "0x521FB0", Offset = "0x5211B0", VA = "0x180521FB0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000201")]
	public static bool isLegalAdult
	{
		[Token(Token = "0x60013D0")]
		[Address(RVA = "0x521E90", Offset = "0x521090", VA = "0x180521E90")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000202")]
	public static bool isNeedUpgradeChange
	{
		[Token(Token = "0x60013D1")]
		[Address(RVA = "0x521EF0", Offset = "0x5210F0", VA = "0x180521EF0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000203")]
	public static bool isNeedUpgrade
	{
		[Token(Token = "0x60013D2")]
		[Address(RVA = "0x521F50", Offset = "0x521150", VA = "0x180521F50")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000204")]
	public static bool isDisableGemShop
	{
		[Token(Token = "0x60013D3")]
		[Address(RVA = "0x521DD0", Offset = "0x520FD0", VA = "0x180521DD0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000205")]
	public static bool hasApproverEmail
	{
		[Token(Token = "0x60013D4")]
		[Address(RVA = "0x521D70", Offset = "0x520F70", VA = "0x180521D70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60013CC")]
	[Address(RVA = "0x521470", Offset = "0x520670", VA = "0x180521470")]
	public static void ClearkIDSaveData()
	{
	}

	[Token(Token = "0x60013CE")]
	[Address(RVA = "0x521640", Offset = "0x520840", VA = "0x180521640")]
	public static AgeGateType GetAgeGateType()
	{
		return default(AgeGateType);
	}

	[Token(Token = "0x60013CF")]
	[Address(RVA = "0x521550", Offset = "0x520750", VA = "0x180521550")]
	public static AgeGateCheckResultType GetAgeGateCheckResult()
	{
		return default(AgeGateCheckResultType);
	}

	[Token(Token = "0x60013D5")]
	[Address(RVA = "0x521800", Offset = "0x520A00", VA = "0x180521800")]
	public static Dictionary<string, object> GetApprovalChallengeInfo()
	{
		return null;
	}

	[Token(Token = "0x60013D6")]
	[Address(RVA = "0x521990", Offset = "0x520B90", VA = "0x180521990")]
	public static string GetApprovalOtpWebSiteUrl()
	{
		return null;
	}

	[Token(Token = "0x60013D7")]
	[Address(RVA = "0x521B50", Offset = "0x520D50", VA = "0x180521B50")]
	public static string GetApprovalQRCodeUrl()
	{
		return null;
	}

	[Token(Token = "0x60013D8")]
	[Address(RVA = "0x521A40", Offset = "0x520C40", VA = "0x180521A40")]
	public static string GetApprovalOtp()
	{
		return null;
	}

	[Token(Token = "0x60013D9")]
	[Address(RVA = "0x521860", Offset = "0x520A60", VA = "0x180521860")]
	public static long GetApprovalOtpExpireTime()
	{
		return default(long);
	}

	[Token(Token = "0x60013DA")]
	[Address(RVA = "0x521AF0", Offset = "0x520CF0", VA = "0x180521AF0")]
	public static int GetApprovalPollingInterval()
	{
		return default(int);
	}

	[Token(Token = "0x60013DB")]
	[Address(RVA = "0x521C00", Offset = "0x520E00", VA = "0x180521C00")]
	public static ApprovalStatus GetApprovalStatus()
	{
		return default(ApprovalStatus);
	}
}
