using Il2CppDummyDll;

namespace YgomGame.WCS.Portal;

[Token(Token = "0x2000785")]
public class Def
{
	[Token(Token = "0x2000786")]
	public enum BattleResult
	{
		[Token(Token = "0x40025B8")]
		UNKOWN,
		[Token(Token = "0x40025B9")]
		WIN,
		[Token(Token = "0x40025BA")]
		LOSE,
		[Token(Token = "0x40025BB")]
		DRAW
	}

	[Token(Token = "0x2000787")]
	public enum LeagueLayoutType
	{
		[Token(Token = "0x40025BD")]
		WCS2023,
		[Token(Token = "0x40025BE")]
		WCS2024
	}

	[Token(Token = "0x2000788")]
	public enum CampaignStatus
	{
		[Token(Token = "0x40025C0")]
		Off,
		[Token(Token = "0x40025C1")]
		Prepare,
		[Token(Token = "0x40025C2")]
		Primary,
		[Token(Token = "0x40025C3")]
		AfterPrimary,
		[Token(Token = "0x40025C4")]
		PreSemifinal,
		[Token(Token = "0x40025C5")]
		_SemiFinal_,
		[Token(Token = "0x40025C6")]
		SemiFinal1,
		[Token(Token = "0x40025C7")]
		PreSemiFinal2,
		[Token(Token = "0x40025C8")]
		SemiFinal2,
		[Token(Token = "0x40025C9")]
		PreFinal,
		[Token(Token = "0x40025CA")]
		Final,
		[Token(Token = "0x40025CB")]
		Result
	}

	[Token(Token = "0x2000789")]
	public class CWPath
	{
		[Token(Token = "0x40025CC")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string WcsfCampaign;

		[Token(Token = "0x40025CD")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string MasterWcsfCampaign;

		[Token(Token = "0x40025CE")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string MasterWcsfTeam;

		[Token(Token = "0x40025CF")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string WcsfCampaign_room_info;

		[Token(Token = "0x40025D0")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string WcsfCampaign_table_info;

		[Token(Token = "0x40025D1")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string WcsfCampaign_room_member;

		[Token(Token = "0x40025D2")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string WcsfCampaign_date_list;

		[Token(Token = "0x6003156")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public CWPath()
		{
		}
	}

	[Token(Token = "0x200078A")]
	public static class MMAAssetPath
	{
		[Token(Token = "0x40025D3")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string DUEL_RULE;
	}

	[Token(Token = "0x40025B6")]
	public const int TEAM_MEMBER_MAX = 3;

	[Token(Token = "0x6003155")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Def()
	{
	}
}
