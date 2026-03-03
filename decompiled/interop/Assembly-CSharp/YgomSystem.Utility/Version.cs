using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x2000425")]
public class Version
{
	[Token(Token = "0x4001466")]
	private const string APP_COMMON_VERSION = "2.6.1";

	[Token(Token = "0x4001467")]
	private const string ASSET_DL_RESET_VERSION = "2.6.0";

	[Token(Token = "0x4001468")]
	private const string APP_HASH = "874PbAcbUfdPZUSCcq4W9wucCSENiWSgcCn";

	[Token(Token = "0x4001469")]
	private const string ATOKEN = "eyJhbGciOiJIUzI1NiJ9.eyJkYXRhIjoie1widlwiOlwiMi42LjFcIixcInRcIjpcIjg3NFBiQWNiVWZkUFpVU0NjcTRXOXd1Y0NTRU5pV1NnY0NuXCJ9IiwiZXhwIjoxNzk5OTE2NTgyfQ.u_YnZwdASTmocrPnmFil1_ip6sk984x1KLY_iRAlzgU";

	[Token(Token = "0x400146A")]
	[FieldOffset(Offset = "0x0")]
	private static string rev;

	[Token(Token = "0x1700026D")]
	public static string AppVersion
	{
		[Token(Token = "0x6001AB7")]
		[Address(RVA = "0x5F98F0", Offset = "0x5F8AF0", VA = "0x1805F98F0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026E")]
	public static string realAppVersion
	{
		[Token(Token = "0x6001AB8")]
		[Address(RVA = "0x5F99D0", Offset = "0x5F8BD0", VA = "0x1805F99D0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x1700026F")]
	public static string AppCommonVersion
	{
		[Token(Token = "0x6001AB9")]
		[Address(RVA = "0x5F9860", Offset = "0x5F8A60", VA = "0x1805F9860")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000270")]
	public static string realAppCommonVersion
	{
		[Token(Token = "0x6001ABA")]
		[Address(RVA = "0x5F99A0", Offset = "0x5F8BA0", VA = "0x1805F99A0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000271")]
	public static string AppHash
	{
		[Token(Token = "0x6001ABB")]
		[Address(RVA = "0x5F98C0", Offset = "0x5F8AC0", VA = "0x1805F98C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000272")]
	public static string AToken
	{
		[Token(Token = "0x6001ABC")]
		[Address(RVA = "0x5F9830", Offset = "0x5F8A30", VA = "0x1805F9830")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000273")]
	private static string AssetDLResetVersion
	{
		[Token(Token = "0x6001ABD")]
		[Address(RVA = "0x5F9970", Offset = "0x5F8B70", VA = "0x1805F9970")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001ABE")]
	[Address(RVA = "0x5F9500", Offset = "0x5F8700", VA = "0x1805F9500")]
	public static bool IsAssetDLReset(string target)
	{
		return default(bool);
	}

	[Token(Token = "0x6001ABF")]
	[Address(RVA = "0x5F9440", Offset = "0x5F8640", VA = "0x1805F9440")]
	public static int Compare(string current, string target)
	{
		return default(int);
	}

	[Token(Token = "0x6001AC0")]
	[Address(RVA = "0x5F9580", Offset = "0x5F8780", VA = "0x1805F9580")]
	public static string Revision()
	{
		return null;
	}

	[Token(Token = "0x6001AC1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Version()
	{
	}
}
