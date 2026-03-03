using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomGame.Team;
using YgomSystem.Network;
using YgomSystem.UI;

namespace YgomGame.Colosseum;

[Token(Token = "0x2001CDF")]
public class ColosseumUtil
{
	[Token(Token = "0x2001CE0")]
	public enum StatusTournament
	{
		[Token(Token = "0x4010122")]
		NOT_WATCHED_START = -3,
		[Token(Token = "0x4010123")]
		NOT_ENTRY,
		[Token(Token = "0x4010124")]
		ENTRY_IMPOSSIBLE,
		[Token(Token = "0x4010125")]
		ENTRY_POSSIBLE,
		[Token(Token = "0x4010126")]
		ENTRY,
		[Token(Token = "0x4010127")]
		JOIN,
		[Token(Token = "0x4010128")]
		DEFEATED,
		[Token(Token = "0x4010129")]
		RESULT_UNRECV,
		[Token(Token = "0x401012A")]
		RESULT_RECV,
		[Token(Token = "0x401012B")]
		STATUS_RESULT_NO_ENTRY
	}

	[Token(Token = "0x2001CE1")]
	public enum StatusTournamentHolding
	{
		[Token(Token = "0x401012D")]
		PRECEDE,
		[Token(Token = "0x401012E")]
		ENTRY,
		[Token(Token = "0x401012F")]
		START,
		[Token(Token = "0x4010130")]
		FINISH,
		[Token(Token = "0x4010131")]
		CLOSE
	}

	[Token(Token = "0x2001CE2")]
	public enum StatusExhibition
	{
		[Token(Token = "0x4010133")]
		BEFORE_HOLDING = -1,
		[Token(Token = "0x4010134")]
		NOT_WATCHED_START,
		[Token(Token = "0x4010135")]
		HOLDING,
		[Token(Token = "0x4010136")]
		AFTER_HOLDING
	}

	[Token(Token = "0x2001CE3")]
	public enum StatusRankEvent
	{
		[Token(Token = "0x4010138")]
		TERM_STATUS_PREPARE,
		[Token(Token = "0x4010139")]
		TERM_STATUS_OPEN,
		[Token(Token = "0x401013A")]
		TERM_STATUS_START,
		[Token(Token = "0x401013B")]
		TERM_STATUS_END,
		[Token(Token = "0x401013C")]
		TERM_STATUS_RESULT_END
	}

	[Token(Token = "0x2001CE4")]
	public enum StatusRankEventUser
	{
		[Token(Token = "0x401013E")]
		STATUS_NONE,
		[Token(Token = "0x401013F")]
		STATUS_JOIN
	}

	[Token(Token = "0x2001CE5")]
	public enum StatusDuelistCup
	{
		[Token(Token = "0x4010141")]
		USER_STATUS_NO_ENTRY,
		[Token(Token = "0x4010142")]
		USER_STATUS_ENTRY,
		[Token(Token = "0x4010143")]
		USER_STATUS_STAGE_1ST,
		[Token(Token = "0x4010144")]
		USER_STATUS_STAGE_2ND,
		[Token(Token = "0x4010145")]
		USER_STATUS_PRE_RESULT,
		[Token(Token = "0x4010146")]
		USER_STATUS_RESULT,
		[Token(Token = "0x4010147")]
		USER_STATUS_RESULT_COMP
	}

	[Token(Token = "0x2001CE6")]
	public enum StatusDuelTrial
	{
		[Token(Token = "0x4010149")]
		TERM_STATUS_PREPARE,
		[Token(Token = "0x401014A")]
		TERM_STATUS_OPEN,
		[Token(Token = "0x401014B")]
		TERM_STATUS_START,
		[Token(Token = "0x401014C")]
		TERM_STATUS_END,
		[Token(Token = "0x401014D")]
		TERM_STATUS_RESULT_END
	}

	[Token(Token = "0x2001CE7")]
	public enum StatusVersus
	{
		[Token(Token = "0x401014F")]
		TERM_STATUS_PREPARE,
		[Token(Token = "0x4010150")]
		TERM_STATUS_OPEN,
		[Token(Token = "0x4010151")]
		TERM_STATUS_START,
		[Token(Token = "0x4010152")]
		TERM_STATUS_END,
		[Token(Token = "0x4010153")]
		TERM_STATUS_RESULT_OPEN,
		[Token(Token = "0x4010154")]
		TERM_STATUS_RESULT_END
	}

	[Token(Token = "0x2001CE8")]
	public enum StatusDiceRally
	{
		[Token(Token = "0x4010156")]
		TERM_STATUS_PREPARE,
		[Token(Token = "0x4010157")]
		TERM_STATUS_OPEN,
		[Token(Token = "0x4010158")]
		TERM_STATUS_START,
		[Token(Token = "0x4010159")]
		TERM_STATUS_END,
		[Token(Token = "0x401015A")]
		TERM_STATUS_RESULT_END
	}

	[Token(Token = "0x2001CE9")]
	public enum TransitionProcess
	{
		[Token(Token = "0x401015C")]
		NONE,
		[Token(Token = "0x401015D")]
		NORMAL,
		[Token(Token = "0x401015E")]
		QUICK
	}

	[Token(Token = "0x2001CEA")]
	public enum RankingType
	{
		[Token(Token = "0x4010160")]
		SCORE,
		[Token(Token = "0x4010161")]
		WINLOSE
	}

	[Token(Token = "0x2001CEB")]
	public enum ChallengeMode
	{
		[Token(Token = "0x4010163")]
		STANDARD = 1,
		[Token(Token = "0x4010164")]
		BOT = 10
	}

	[Token(Token = "0x2001CEC")]
	public enum StandardRank
	{
		[Token(Token = "0x4010166")]
		ROOKIE = 1,
		[Token(Token = "0x4010167")]
		BRONZE,
		[Token(Token = "0x4010168")]
		SILVER,
		[Token(Token = "0x4010169")]
		GOLD,
		[Token(Token = "0x401016A")]
		PLATINUM,
		[Token(Token = "0x401016B")]
		DIAMOND,
		[Token(Token = "0x401016C")]
		MASTER,
		[Token(Token = "0x401016D")]
		TEMP08,
		[Token(Token = "0x401016E")]
		TEMP09,
		[Token(Token = "0x401016F")]
		TEMP10
	}

	[Token(Token = "0x2001CED")]
	public enum Turn
	{
		[Token(Token = "0x4010171")]
		FIRST = 0,
		[Token(Token = "0x4010172")]
		SECOND = 1,
		[Token(Token = "0x4010173")]
		RANDOM = 2,
		[Token(Token = "0x4010174")]
		NONE = 10
	}

	[Token(Token = "0x2001CEE")]
	public enum PlayMode
	{
		[Token(Token = "0x4010176")]
		NONE,
		[Token(Token = "0x4010177")]
		RANK,
		[Token(Token = "0x4010178")]
		TOURNAMENT,
		[Token(Token = "0x4010179")]
		ROOM,
		[Token(Token = "0x401017A")]
		EXHIBITION,
		[Token(Token = "0x401017B")]
		FREE,
		[Token(Token = "0x401017C")]
		DUELISTCUP,
		[Token(Token = "0x401017D")]
		RANKEVENT,
		[Token(Token = "0x401017E")]
		TEAMMATCH,
		[Token(Token = "0x401017F")]
		DUELTRIAL,
		[Token(Token = "0x4010180")]
		WCS,
		[Token(Token = "0x4010181")]
		VERSUS,
		[Token(Token = "0x4010182")]
		WCS_FINAL,
		[Token(Token = "0x4010183")]
		RATE,
		[Token(Token = "0x4010184")]
		RDC,
		[Token(Token = "0x4010185")]
		DICERALLY
	}

	[Token(Token = "0x2001CEF")]
	public enum Region
	{
		[Token(Token = "0x4010187")]
		NONE,
		[Token(Token = "0x4010188")]
		JAPAN,
		[Token(Token = "0x4010189")]
		ASIA,
		[Token(Token = "0x401018A")]
		NORTH_AMERICA,
		[Token(Token = "0x401018B")]
		LATIN_AMERICA,
		[Token(Token = "0x401018C")]
		EUROPE_OTHER
	}

	[Token(Token = "0x4010120")]
	public const string k_BGM_DICERALLY = "BGM_DICERALLY";

	[Token(Token = "0x600BA91")]
	[Address(RVA = "0x554A80", Offset = "0x553C80", VA = "0x180554A80")]
	public static void CallDuelBeginPvE(ViewControllerManager manager, Util.GameMode gameMode, int tid = 0, bool isSwap = false)
	{
	}

	[Token(Token = "0x600BA92")]
	[Address(RVA = "0x554C70", Offset = "0x553E70", VA = "0x180554C70")]
	public static void CallDuelBeginSolo(ViewController swapTarget, ViewControllerManager manager, int chapterID, Turn turn = Turn.NONE)
	{
	}

	[Token(Token = "0x600BA93")]
	[Address(RVA = "0x5576D0", Offset = "0x5568D0", VA = "0x1805576D0")]
	public static void StartMatching(ViewControllerManager manager, PvpMenuDefine.MatchingType type, PvpMenuDefine.MatchingType match, int id = 0, int logoId = 0, int rentalState = 0, int researchTime = 0)
	{
	}

	[Token(Token = "0x600BA94")]
	[Address(RVA = "0x5574C0", Offset = "0x5566C0", VA = "0x1805574C0")]
	public static void StartMatchingTeam(ViewControllerManager manager, bool isLeader, [Optional] OpponentTeamInfo oppTeamInfo)
	{
	}

	[Token(Token = "0x600BA95")]
	[Address(RVA = "0x5575B0", Offset = "0x5567B0", VA = "0x1805575B0")]
	private static void StartMatching(ViewControllerManager manager, PvpMenuDefine.MatchingType type, PvpMenuDefine.MatchingType match, Dictionary<string, object> duelParams, Dictionary<string, object> matchingParams, [Optional] Dictionary<string, object> otherParams)
	{
	}

	[Token(Token = "0x600BA96")]
	[Address(RVA = "0x554ED0", Offset = "0x5540D0", VA = "0x180554ED0")]
	public static void CallTournamentEntry(int tid, [Optional] Action endAction)
	{
	}

	[Token(Token = "0x600BA97")]
	[Address(RVA = "0x554FA0", Offset = "0x5541A0", VA = "0x180554FA0")]
	public static string GetOrderString(int order, bool changeScale = true)
	{
		return null;
	}

	[Token(Token = "0x600BA98")]
	[Address(RVA = "0x554890", Offset = "0x553A90", VA = "0x180554890")]
	public static void CallAPIDeckCheck(PlayMode playMode, int tid = 0, [Optional] Action onFinish, int regulationId = 0)
	{
	}

	[Token(Token = "0x600BA99")]
	[Address(RVA = "0x554990", Offset = "0x553B90", VA = "0x180554990")]
	public static void CallAPIPlayReplay(Util.GameMode gameMode, long did, int idx = 0, int eid = 0, [Optional] Action<PvPCode> onFailed)
	{
	}

	[Token(Token = "0x600BA9A")]
	[Address(RVA = "0x5551C0", Offset = "0x5543C0", VA = "0x1805551C0")]
	public static string GetResultStringWithColor(Engine.ResultType resultType)
	{
		return null;
	}

	[Token(Token = "0x600BA9B")]
	[Address(RVA = "0x555BB0", Offset = "0x554DB0", VA = "0x180555BB0")]
	public static void HandleResultCodeDuelMenu(Handle handle, [Optional] Action onSuccess, [Optional] Action<DuelMenuCode> onFailed)
	{
	}

	[Token(Token = "0x600BA9C")]
	[Address(RVA = "0x5555C0", Offset = "0x5547C0", VA = "0x1805555C0")]
	public static void HandleResultCodeChallenge(Handle handle, [Optional] Action onSuccess, [Optional] Action<ChallengeCode> onFailed)
	{
	}

	[Token(Token = "0x600BA9D")]
	[Address(RVA = "0x5566E0", Offset = "0x5558E0", VA = "0x1805566E0")]
	public static void HandleResultCodeTournament(Handle handle, [Optional] Action onSuccess, [Optional] Action<TournamentCode> onFailed)
	{
	}

	[Token(Token = "0x600BA9E")]
	[Address(RVA = "0x555ED0", Offset = "0x5550D0", VA = "0x180555ED0")]
	public static void HandleResultCodeExhibition(Handle handle, [Optional] Action onSuccess, [Optional] Action<ExhibitionCode> onFailed)
	{
	}

	[Token(Token = "0x600BA9F")]
	[Address(RVA = "0x5553D0", Offset = "0x5545D0", VA = "0x1805553D0")]
	public static void HandleResultCodeCasual(Handle handle, [Optional] Action onSuccess, [Optional] Action<CasualCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA0")]
	[Address(RVA = "0x556100", Offset = "0x555300", VA = "0x180556100")]
	public static void HandleResultCodeRankEvent(Handle handle, [Optional] Action onSuccess, [Optional] Action<RankEventCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA1")]
	[Address(RVA = "0x5557C0", Offset = "0x5549C0", VA = "0x1805557C0")]
	public static void HandleResultCodeCup(Handle handle, [Optional] Action onSuccess, [Optional] Action<CupCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA2")]
	[Address(RVA = "0x556B60", Offset = "0x555D60", VA = "0x180556B60")]
	public static void HandleResultCodeWcs(Handle handle, [Optional] Action onSuccess, [Optional] Action<WcsCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA3")]
	[Address(RVA = "0x555C20", Offset = "0x554E20", VA = "0x180555C20")]
	public static void HandleResultCodeDuelTrial(Handle handle, [Optional] Action onSuccess, [Optional] Action<DuelTrialCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA4")]
	[Address(RVA = "0x556910", Offset = "0x555B10", VA = "0x180556910")]
	public static void HandleResultCodeVersus(Handle handle, [Optional] Action onSuccess, [Optional] Action<VersusCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA5")]
	[Address(RVA = "0x5562F0", Offset = "0x5554F0", VA = "0x1805562F0")]
	public static void HandleResultCodeRateDuel(Handle handle, [Optional] Action onSuccess, [Optional] Action<RateDuelCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA6")]
	[Address(RVA = "0x5564F0", Offset = "0x5556F0", VA = "0x1805564F0")]
	public static void HandleResultCodeRdc(Handle handle, [Optional] Action onSuccess, [Optional] Action<RdcCode> onFailed)
	{
	}

	[Token(Token = "0x600BAA7")]
	[Address(RVA = "0x5559B0", Offset = "0x554BB0", VA = "0x1805559B0")]
	public static bool HandleResultCodeDiceRally(Handle handle, [Optional] Action onSuccess, [Optional] Action<DicerallyCode> onFailed)
	{
		return default(bool);
	}

	[Token(Token = "0x600BAA8")]
	[Address(RVA = "0x557280", Offset = "0x556480", VA = "0x180557280")]
	public static bool PopColosseumViewControler(PlayMode playMode)
	{
		return default(bool);
	}

	[Token(Token = "0x600BAA9")]
	[Address(RVA = "0x556F00", Offset = "0x556100", VA = "0x180556F00")]
	public static void OpenItemConfirmDialogUnpackRight(string title, bool isPeriod, int itemCategory, int itemId, int itemNum, [Optional] Action closeCallback, bool hideNum = false, int shopId = 0)
	{
	}

	[Token(Token = "0x600BAAA")]
	[Address(RVA = "0x556D50", Offset = "0x555F50", VA = "0x180556D50")]
	public static void InitPrefLinkerLabel(ViewCreater viewCreater, PlayMode mode, int identifier = 0, string defaultLabel = "View")
	{
	}

	[Token(Token = "0x600BAAB")]
	[Address(RVA = "0x5573D0", Offset = "0x5565D0", VA = "0x1805573D0")]
	public static string ReplaceTextSize(string convertText, int percent = 66, string target = ".")
	{
		return null;
	}

	[Token(Token = "0x600BAAC")]
	[Address(RVA = "0x556E40", Offset = "0x556040", VA = "0x180556E40")]
	public static bool IsFixedAccessory(Dictionary<string, object> masterInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600BAAD")]
	[Address(RVA = "0x556EA0", Offset = "0x5560A0", VA = "0x180556EA0")]
	public static bool IsFixedPickCards(Dictionary<string, object> masterInfo)
	{
		return default(bool);
	}

	[Token(Token = "0x600BAAE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ColosseumUtil()
	{
	}
}
