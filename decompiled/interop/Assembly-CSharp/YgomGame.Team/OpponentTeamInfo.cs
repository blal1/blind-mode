using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomGame.Team;

[Token(Token = "0x2001642")]
public class OpponentTeamInfo
{
	[Token(Token = "0x400D586")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string CW_PATH;

	[Token(Token = "0x400D587")]
	private const string CW_PATH_DURATIONID = "duel_time";

	[Token(Token = "0x400D588")]
	private const string CW_PATH_TEAM_ID = "opp_team_id";

	[Token(Token = "0x400D589")]
	private const string CW_PATH_MRK = "opp_team_mrk";

	[Token(Token = "0x400D58A")]
	private const string CW_PATH_MATCHING_KEY = "matching_key";

	[Token(Token = "0x17001526")]
	public int duelDurationId
	{
		[Token(Token = "0x6008A70")]
		[Address(RVA = "0x3C7100", Offset = "0x3C6300", VA = "0x1803C7100")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008A6F")]
		[Address(RVA = "0x5F4710", Offset = "0x5F3910", VA = "0x1805F4710")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001527")]
	public int teamId
	{
		[Token(Token = "0x6008A72")]
		[Address(RVA = "0x64B770", Offset = "0x64A970", VA = "0x18064B770")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008A71")]
		[Address(RVA = "0x64B780", Offset = "0x64A980", VA = "0x18064B780")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001528")]
	public int mrk
	{
		[Token(Token = "0x6008A74")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Token(Token = "0x6008A73")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x17001529")]
	public string matchKey
	{
		[Token(Token = "0x6008A76")]
		[Address(RVA = "0x3D8370", Offset = "0x3D7570", VA = "0x1803D8370")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Token(Token = "0x6008A75")]
		[Address(RVA = "0x3D8380", Offset = "0x3D7580", VA = "0x1803D8380")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Token(Token = "0x1700152A")]
	public bool isValid
	{
		[Token(Token = "0x6008A77")]
		[Address(RVA = "0xD575D0", Offset = "0xD567D0", VA = "0x180D575D0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6008A78")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	private OpponentTeamInfo()
	{
	}

	[Token(Token = "0x6008A79")]
	[Address(RVA = "0xD57220", Offset = "0xD56420", VA = "0x180D57220")]
	public static OpponentTeamInfo AcquireFromCW()
	{
		return null;
	}

	[Token(Token = "0x6008A7A")]
	[Address(RVA = "0xD57420", Offset = "0xD56620", VA = "0x180D57420")]
	public static OpponentTeamInfo LoadFromCW(object root)
	{
		return null;
	}

	[Token(Token = "0x6008A7B")]
	[Address(RVA = "0xD57390", Offset = "0xD56590", VA = "0x180D57390")]
	public static bool IsOpponentFixed()
	{
		return default(bool);
	}
}
