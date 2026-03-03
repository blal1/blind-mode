using Il2CppDummyDll;

namespace YgomGame.Menu;

[Token(Token = "0x20013A7")]
public class PvpMenuDefine
{
	[Token(Token = "0x20013A8")]
	public enum MatchingType
	{
		[Token(Token = "0x400C354")]
		UNKNOWN,
		[Token(Token = "0x400C355")]
		FREE,
		[Token(Token = "0x400C356")]
		RANK,
		[Token(Token = "0x400C357")]
		TOURNAMENT,
		[Token(Token = "0x400C358")]
		WATCH,
		[Token(Token = "0x400C359")]
		ROOM,
		[Token(Token = "0x400C35A")]
		EXHIBITION,
		[Token(Token = "0x400C35B")]
		DUELISTCUP,
		[Token(Token = "0x400C35C")]
		RANKEVENT,
		[Token(Token = "0x400C35D")]
		TEAM,
		[Token(Token = "0x400C35E")]
		DUELTRIAL,
		[Token(Token = "0x400C35F")]
		WCS,
		[Token(Token = "0x400C360")]
		VERSUS,
		[Token(Token = "0x400C361")]
		WCS_FINAL,
		[Token(Token = "0x400C362")]
		RATE,
		[Token(Token = "0x400C363")]
		RDC,
		[Token(Token = "0x400C364")]
		DICERALLY,
		[Token(Token = "0x400C365")]
		MAX
	}

	[Token(Token = "0x400C339")]
	public const string ARGNAME_MATCH = "match";

	[Token(Token = "0x400C33A")]
	public const string ARGNAME_PARAM = "param";

	[Token(Token = "0x400C33B")]
	public const string ARGNAME_DPARAM = "dparam";

	[Token(Token = "0x400C33C")]
	public const string ARGNAME_TYPE = "type";

	[Token(Token = "0x400C33D")]
	public const string ARGNAME_OTHER = "other";

	[Token(Token = "0x400C33E")]
	public const string ARGNAME_RANK_EVENT_ID = "rank_event_id";

	[Token(Token = "0x400C33F")]
	public const string ARGNAME_GAMEMODE = "GameMode";

	[Token(Token = "0x400C340")]
	public const string ARGNAME_MODE = "mode";

	[Token(Token = "0x400C341")]
	public const string ARGNAME_RESEARCH = "research";

	[Token(Token = "0x400C342")]
	public const string ARGNAME_RESEARCHTIME = "researchTime";

	[Token(Token = "0x400C343")]
	public const string ARGNAME_PS_ONLINE_ID = "ps_online_id";

	[Token(Token = "0x400C344")]
	public const string ARGNAME_XBOX_ONLINE_ID = "xbox_online_id";

	[Token(Token = "0x400C345")]
	public const string ARGNAME_TID = "tid";

	[Token(Token = "0x400C346")]
	public const string ARGNAME_EXHID = "exhid";

	[Token(Token = "0x400C347")]
	public const string ARGNAME_CID = "cid";

	[Token(Token = "0x400C348")]
	public const string ARGNAME_WCS_ID = "wcs_id";

	[Token(Token = "0x400C349")]
	public const string ARGNAME_DUEL_TRIAL_ID = "duel_trial_id";

	[Token(Token = "0x400C34A")]
	public const string ARGNAME_VERSUS_ID = "versus_id";

	[Token(Token = "0x400C34B")]
	public const string ARGNAME_RID = "rid";

	[Token(Token = "0x400C34C")]
	public const string ARGNAME_DICERALLY_ID = "dicerally_id";

	[Token(Token = "0x400C34D")]
	public const string ARGNAME_RENTAL_STATE = "rental_state";

	[Token(Token = "0x400C34E")]
	public const string ARGNAME_SEASON_ID = "season_id";

	[Token(Token = "0x400C34F")]
	public const string ARGNAME_IS_TEAM_LEADER = "is_team_leader";

	[Token(Token = "0x400C350")]
	public const string ARGNAME_OPP_TEAM_ID = "opp_team_id";

	[Token(Token = "0x400C351")]
	public const string ARGNAME_MATCHING_KEY = "matching_key";

	[Token(Token = "0x400C352")]
	public const string ARGNAME_LASTBGM = "lastbgm";

	[Token(Token = "0x6007A31")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public PvpMenuDefine()
	{
	}
}
