using System.Collections.Generic;
using System.Diagnostics;
using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomGame;

[Token(Token = "0x20006F7")]
public static class AgreementUtility
{
	[Token(Token = "0x20006F8")]
	private class AgreementKindInfo
	{
		[Token(Token = "0x4002300")]
		[FieldOffset(Offset = "0x10")]
		public AgreementKind kind;

		[Token(Token = "0x4002301")]
		[FieldOffset(Offset = "0x18")]
		public long revision;

		[Token(Token = "0x4002302")]
		[FieldOffset(Offset = "0x20")]
		public LanguageStringSet urls;

		[Token(Token = "0x6002E40")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		private AgreementKindInfo()
		{
		}

		[Token(Token = "0x6002E41")]
		[Address(RVA = "0x7182A0", Offset = "0x7174A0", VA = "0x1807182A0")]
		public AgreementKindInfo(AgreementKind kind, long revision, LanguageStringSet urls)
		{
		}
	}

	[Token(Token = "0x20006F9")]
	private class DataManager
	{
		[Token(Token = "0x4002303")]
		[FieldOffset(Offset = "0x10")]
		private Dictionary<AgreementKind, AgreementKindInfo> m_kindInfos;

		[Token(Token = "0x4002304")]
		[FieldOffset(Offset = "0x18")]
		private UserAgreementType m_currentAgreementType;

		[Token(Token = "0x4002305")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<PlatformTOSKind, LanguageStringSet> m_TOSUrls;

		[Token(Token = "0x4002306")]
		[FieldOffset(Offset = "0x28")]
		private AgreeRequirementType m_requirementType;

		[Token(Token = "0x4002307")]
		[FieldOffset(Offset = "0x30")]
		private List<AgreementKind> m_reagreeKinds;

		[Token(Token = "0x4002308")]
		[FieldOffset(Offset = "0x38")]
		private bool m_reagreeAgeGate;

		[Token(Token = "0x170005B6")]
		public UserAgreementType currentAgreementType
		{
			[Token(Token = "0x6002E45")]
			[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
			get
			{
				return default(UserAgreementType);
			}
		}

		[Token(Token = "0x170005B7")]
		public AgreeRequirementType requirementType
		{
			[Token(Token = "0x6002E4A")]
			[Address(RVA = "0x62E210", Offset = "0x62D410", VA = "0x18062E210")]
			get
			{
				return default(AgreeRequirementType);
			}
		}

		[Token(Token = "0x170005B8")]
		public bool isNeedReagreeAgeGate
		{
			[Token(Token = "0x6002E4C")]
			[Address(RVA = "0x406E70", Offset = "0x406070", VA = "0x180406E70")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x6002E42")]
		[Address(RVA = "0x71C9E0", Offset = "0x71BBE0", VA = "0x18071C9E0")]
		private AgreementKindInfo getAgreementKindInfo(AgreementKind kind)
		{
			return null;
		}

		[Token(Token = "0x6002E43")]
		[Address(RVA = "0x71C900", Offset = "0x71BB00", VA = "0x18071C900")]
		public DataManager()
		{
		}

		[Token(Token = "0x6002E44")]
		[Address(RVA = "0x71AB80", Offset = "0x719D80", VA = "0x18071AB80")]
		public void Clear()
		{
		}

		[Token(Token = "0x6002E46")]
		[Address(RVA = "0x71AC20", Offset = "0x719E20", VA = "0x18071AC20")]
		public long GetAgreementKindRevision(AgreementKind kind)
		{
			return default(long);
		}

		[Token(Token = "0x6002E47")]
		[Address(RVA = "0x71AC40", Offset = "0x719E40", VA = "0x18071AC40")]
		public string GetAgreementKindUrl(AgreementKind kind, string lang)
		{
			return null;
		}

		[Token(Token = "0x6002E48")]
		[Address(RVA = "0x71AD00", Offset = "0x719F00", VA = "0x18071AD00")]
		public PlatformTOSKind GetPlatformTOSKind()
		{
			return default(PlatformTOSKind);
		}

		[Token(Token = "0x6002E49")]
		[Address(RVA = "0x71AD10", Offset = "0x719F10", VA = "0x18071AD10")]
		public string GetTermOfServiceUrl(PlatformTOSKind TOSKind, string lang)
		{
			return null;
		}

		[Token(Token = "0x6002E4B")]
		[Address(RVA = "0x402CE0", Offset = "0x401EE0", VA = "0x180402CE0")]
		public List<AgreementKind> GetReagreeKinds()
		{
			return null;
		}

		[Token(Token = "0x6002E4D")]
		[Address(RVA = "0x71AB30", Offset = "0x719D30", VA = "0x18071AB30")]
		public void ClearReagree()
		{
		}

		[Token(Token = "0x6002E4E")]
		[Address(RVA = "0x71C610", Offset = "0x71B810", VA = "0x18071C610")]
		public string[] MakeAgreementRevisionParameter(IReadOnlyList<AgreementKind> kinds)
		{
			return null;
		}

		[Token(Token = "0x6002E4F")]
		[Address(RVA = "0x71AE10", Offset = "0x71A010", VA = "0x18071AE10")]
		public void ImportAgreementInfo(object value)
		{
		}

		[Token(Token = "0x6002E50")]
		[Address(RVA = "0x71BE00", Offset = "0x71B000", VA = "0x18071BE00")]
		public void ImportNeedReagree(object value)
		{
		}
	}

	[Token(Token = "0x40022FE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly Dictionary<UserAgreementType, AgreementKind[]> c_requiredKindsTable;

	[Token(Token = "0x40022FF")]
	[FieldOffset(Offset = "0x8")]
	private static DataManager s_instance;

	[Token(Token = "0x6002E30")]
	[Address(RVA = "0x718B90", Offset = "0x717D90", VA = "0x180718B90")]
	static AgreementUtility()
	{
	}

	[Token(Token = "0x6002E31")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	private static void debugLog(string msg)
	{
	}

	[Token(Token = "0x6002E32")]
	[Address(RVA = "0x718390", Offset = "0x717590", VA = "0x180718390")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6002E33")]
	[Address(RVA = "0x718610", Offset = "0x717810", VA = "0x180718610")]
	public static UserAgreementType GetCurrentAgreementType()
	{
		return default(UserAgreementType);
	}

	[Token(Token = "0x6002E34")]
	[Address(RVA = "0x718740", Offset = "0x717940", VA = "0x180718740")]
	public static AgreementKind[] GetRequiredKinds(UserAgreementType agreementType)
	{
		return null;
	}

	[Token(Token = "0x6002E35")]
	[Address(RVA = "0x718670", Offset = "0x717870", VA = "0x180718670")]
	public static PlatformTOSKind GetPlatformTOSKind()
	{
		return default(PlatformTOSKind);
	}

	[Token(Token = "0x6002E36")]
	[Address(RVA = "0x718480", Offset = "0x717680", VA = "0x180718480")]
	public static long GetAgreementKindRevision(AgreementKind kind)
	{
		return default(long);
	}

	[Token(Token = "0x6002E37")]
	[Address(RVA = "0x718500", Offset = "0x717700", VA = "0x180718500")]
	public static string GetAgreementKindUrl(AgreementKind kind, string lang = "")
	{
		return null;
	}

	[Token(Token = "0x6002E38")]
	[Address(RVA = "0x718890", Offset = "0x717A90", VA = "0x180718890")]
	public static string GetTermOfServiceUrl(PlatformTOSKind TOSKind, string lang = "")
	{
		return null;
	}

	[Token(Token = "0x6002E39")]
	[Address(RVA = "0x718830", Offset = "0x717A30", VA = "0x180718830")]
	public static AgreeRequirementType GetRequirementType()
	{
		return default(AgreeRequirementType);
	}

	[Token(Token = "0x6002E3A")]
	[Address(RVA = "0x7186E0", Offset = "0x7178E0", VA = "0x1807186E0")]
	public static List<AgreementKind> GetReagreeKinds()
	{
		return null;
	}

	[Token(Token = "0x6002E3B")]
	[Address(RVA = "0x718AC0", Offset = "0x717CC0", VA = "0x180718AC0")]
	public static bool IsNeedReagreeAgeGate()
	{
		return default(bool);
	}

	[Token(Token = "0x6002E3C")]
	[Address(RVA = "0x718300", Offset = "0x717500", VA = "0x180718300")]
	public static void ClearReagree()
	{
	}

	[Token(Token = "0x6002E3D")]
	[Address(RVA = "0x718B20", Offset = "0x717D20", VA = "0x180718B20")]
	public static string[] MakeAgreementRevisionParameter(IReadOnlyList<AgreementKind> kinds)
	{
		return null;
	}

	[Token(Token = "0x6002E3E")]
	[Address(RVA = "0x7189E0", Offset = "0x717BE0", VA = "0x1807189E0")]
	public static void ImportAgreementInfo(object value)
	{
	}

	[Token(Token = "0x6002E3F")]
	[Address(RVA = "0x718A50", Offset = "0x717C50", VA = "0x180718A50")]
	public static void ImportNeedReagree(object value)
	{
	}
}
