using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.Menu;
using YgomGame.Settings;

namespace YgomGame.Duel;

[Token(Token = "0x20017C6")]
public class Util
{
	[Token(Token = "0x20017C7")]
	public enum GameMode
	{
		[Token(Token = "0x400DE78")]
		Normal,
		[Token(Token = "0x400DE79")]
		Free,
		[Token(Token = "0x400DE7A")]
		Single,
		[Token(Token = "0x400DE7B")]
		Rank,
		[Token(Token = "0x400DE7C")]
		Tournament,
		[Token(Token = "0x400DE7D")]
		TournamentSingle,
		[Token(Token = "0x400DE7E")]
		Audience,
		[Token(Token = "0x400DE7F")]
		Replay,
		[Token(Token = "0x400DE80")]
		RankSingle,
		[Token(Token = "0x400DE81")]
		SoloSingle,
		[Token(Token = "0x400DE82")]
		Room,
		[Token(Token = "0x400DE83")]
		Exhibition,
		[Token(Token = "0x400DE84")]
		DuelistCup,
		[Token(Token = "0x400DE85")]
		RankEvent,
		[Token(Token = "0x400DE86")]
		TeamMatch,
		[Token(Token = "0x400DE87")]
		DuelTrial,
		[Token(Token = "0x400DE88")]
		WCS,
		[Token(Token = "0x400DE89")]
		Versus,
		[Token(Token = "0x400DE8A")]
		WcsFinal,
		[Token(Token = "0x400DE8B")]
		Rate,
		[Token(Token = "0x400DE8C")]
		RDC,
		[Token(Token = "0x400DE8D")]
		Dicerally,
		[Token(Token = "0x400DE8E")]
		Null
	}

	[Token(Token = "0x20017C8")]
	public enum EvalType
	{
		[Token(Token = "0x400DE90")]
		Advantage,
		[Token(Token = "0x400DE91")]
		Normal,
		[Token(Token = "0x400DE92")]
		Danger
	}

	[Token(Token = "0x20017C9")]
	public enum AttackLevel
	{
		[Token(Token = "0x400DE94")]
		Small,
		[Token(Token = "0x400DE95")]
		Medium,
		[Token(Token = "0x400DE96")]
		Large,
		[Token(Token = "0x400DE97")]
		Largest
	}

	[Token(Token = "0x20017CA")]
	public enum OpeningMessageType
	{
		[Token(Token = "0x400DE99")]
		None,
		[Token(Token = "0x400DE9A")]
		Promotion,
		[Token(Token = "0x400DE9B")]
		Demotion
	}

	[Token(Token = "0x20017CB")]
	public enum PlatformID
	{
		[Token(Token = "0x400DE9D")]
		Invalid = 0,
		[Token(Token = "0x400DE9E")]
		Android = 1,
		[Token(Token = "0x400DE9F")]
		iOS = 2,
		[Token(Token = "0x400DEA0")]
		Steam = 3,
		[Token(Token = "0x400DEA1")]
		PS4 = 4,
		[Token(Token = "0x400DEA2")]
		NX = 5,
		[Token(Token = "0x400DEA3")]
		XboxOne = 6,
		[Token(Token = "0x400DEA4")]
		Stadia = 7,
		[Token(Token = "0x400DEA5")]
		PS5 = 8,
		[Token(Token = "0x400DEA6")]
		XboxSX = 9,
		[Token(Token = "0x400DEA7")]
		Editor = 100
	}

	[Token(Token = "0x20017CC")]
	public enum PublicLevel
	{
		[Token(Token = "0x400DEA9")]
		AllClose = 0,
		[Token(Token = "0x400DEAA")]
		FrontOpen = 1,
		[Token(Token = "0x400DEAB")]
		AllOpen = 2,
		[Token(Token = "0x400DEAC")]
		Unknown = 255
	}

	[Token(Token = "0x20017CD")]
	public enum DisplayType
	{
		[Token(Token = "0x400DEAE")]
		Vista,
		[Token(Token = "0x400DEAF")]
		Standard,
		[Token(Token = "0x400DEB0")]
		MobileDevice
	}

	[Token(Token = "0x400DE62")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static DuelClientWorkInfo workInfo;

	[Token(Token = "0x400DE63")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public static Dictionary<int, int> initDeckNum;

	[Token(Token = "0x400DE64")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static Dictionary<int, int> initExDeckNum;

	[Token(Token = "0x400DE65")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static GameObject profileCardParent;

	[Token(Token = "0x400DE66")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static List<Engine.SpSummonType> playedSpSummonEffect;

	[Token(Token = "0x400DE67")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static List<int> playedMonsterCutinCardID;

	[Token(Token = "0x400DE68")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
	private static List<int> playedCardRunEffectCardID;

	[Token(Token = "0x400DE69")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
	private static bool resultSubAvatar;

	[Token(Token = "0x400DE6A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
	private static Dictionary<int, string> filteredPlayerNames;

	[Token(Token = "0x400DE6B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	private static bool isInitFilteredName0;

	[Token(Token = "0x400DE6C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x49")]
	private static bool isInitFilteredName1;

	[Token(Token = "0x400DE6D")]
	private const string PLAYER_NAME_MASKED = "DUELIST";

	[Token(Token = "0x400DE6E")]
	private const string PLAYER_NAME_MASKED_A = "DUELIST A";

	[Token(Token = "0x400DE6F")]
	private const string PLAYER_NAME_MASKED_B = "DUELIST B";

	[Token(Token = "0x400DE70")]
	private const string PLAYER_NAME_MASKED_C = "DUELIST C";

	[Token(Token = "0x400DE71")]
	private const string PLAYER_NAME_MASKED_D = "DUELIST D";

	[Token(Token = "0x400DE72")]
	private const string PLAYER_NAME_MASKED_E = "DUELIST E";

	[Token(Token = "0x400DE73")]
	private const int SpAccessoryId_WCS = 2008;

	[Token(Token = "0x400DE74")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	private static PublicLevel publicLevelCache;

	[Token(Token = "0x400DE75")]
	public const int PosPhaseButton = 19;

	[Token(Token = "0x400DE76")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public static int expandRowCount;

	[Token(Token = "0x170016CC")]
	public static bool isInitFilteredName
	{
		[Token(Token = "0x60095CB")]
		[Address(RVA = "0xE4E230", Offset = "0xE4D430", VA = "0x180E4E230")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60095CC")]
	[Address(RVA = "0xE4A7C0", Offset = "0xE499C0", VA = "0x180E4A7C0")]
	public static void Initiaize()
	{
	}

	[Token(Token = "0x60095CD")]
	[Address(RVA = "0xE4DB40", Offset = "0xE4CD40", VA = "0x180E4DB40")]
	public static void Terminate()
	{
	}

	[Token(Token = "0x60095CE")]
	[Address(RVA = "0xE4A750", Offset = "0xE49950", VA = "0x180E4A750")]
	public static void InitWorkInfo()
	{
	}

	[Token(Token = "0x60095CF")]
	[Address(RVA = "0xE4CDB0", Offset = "0xE4BFB0", VA = "0x180E4CDB0")]
	public static void RemakeWorkInfo()
	{
	}

	[Token(Token = "0x60095D0")]
	[Address(RVA = "0xE4DA30", Offset = "0xE4CC30", VA = "0x180E4DA30")]
	public static int ShowResult()
	{
		return default(int);
	}

	[Token(Token = "0x60095D1")]
	[Address(RVA = "0xE482B0", Offset = "0xE474B0", VA = "0x180E482B0")]
	public static GameMode GetGameMode()
	{
		return default(GameMode);
	}

	[Token(Token = "0x60095D2")]
	[Address(RVA = "0xE4BEA0", Offset = "0xE4B0A0", VA = "0x180E4BEA0")]
	public static bool IsSingleMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60095D3")]
	[Address(RVA = "0xE4B9F0", Offset = "0xE4ABF0", VA = "0x180E4B9F0")]
	public static bool IsSelfOperating()
	{
		return default(bool);
	}

	[Token(Token = "0x60095D4")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public static bool IsQuestionMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60095D5")]
	[Address(RVA = "0xE4AA30", Offset = "0xE49C30", VA = "0x180E4AA30")]
	public static bool IsAudience()
	{
		return default(bool);
	}

	[Token(Token = "0x60095D6")]
	[Address(RVA = "0xE4B9A0", Offset = "0xE4ABA0", VA = "0x180E4B9A0")]
	public static bool IsReplay()
	{
		return default(bool);
	}

	[Token(Token = "0x60095D7")]
	[Address(RVA = "0xE4B6B0", Offset = "0xE4A8B0", VA = "0x180E4B6B0")]
	public static bool IsOnlineMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60095D8")]
	[Address(RVA = "0xE45A40", Offset = "0xE44C40", VA = "0x180E45A40")]
	public static EvalType EvaluatorGetEval(int player)
	{
		return default(EvalType);
	}

	[Token(Token = "0x60095D9")]
	[Address(RVA = "0xE49020", Offset = "0xE48220", VA = "0x180E49020")]
	public static string GetNextPath()
	{
		return null;
	}

	[Token(Token = "0x60095DA")]
	[Address(RVA = "0xE48AD0", Offset = "0xE47CD0", VA = "0x180E48AD0")]
	public static int[] GetMrkByFinishType(Engine.FinishType finishType)
	{
		return null;
	}

	[Token(Token = "0x60095DB")]
	[Address(RVA = "0xE49E80", Offset = "0xE49080", VA = "0x180E49E80")]
	public static int GetSleeveId(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x60095DC")]
	[Address(RVA = "0xE49DC0", Offset = "0xE48FC0", VA = "0x180E49DC0")]
	public static int GetSleeveIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095DD")]
	[Address(RVA = "0xE47BB0", Offset = "0xE46DB0", VA = "0x180E47BB0")]
	public static int GetFaceIconIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095DE")]
	[Address(RVA = "0xE47AF0", Offset = "0xE46CF0", VA = "0x180E47AF0")]
	public static int GetFaceIconFrameIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095DF")]
	[Address(RVA = "0xE45E80", Offset = "0xE45080", VA = "0x180E45E80")]
	public static int GetAvatarIconIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095E0")]
	[Address(RVA = "0xE45F40", Offset = "0xE45140", VA = "0x180E45F40")]
	public static int GetAvatarStandIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095E1")]
	[Address(RVA = "0xE48380", Offset = "0xE47580", VA = "0x180E48380")]
	public static int GetGraveIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095E2")]
	[Address(RVA = "0xE489D0", Offset = "0xE47BD0", VA = "0x180E489D0")]
	public static int GetMatIdFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095E3")]
	[Address(RVA = "0xE49440", Offset = "0xE48640", VA = "0x180E49440")]
	public static long GetPcodeFromPlayer(int player)
	{
		return default(long);
	}

	[Token(Token = "0x60095E4")]
	[Address(RVA = "0xE4A450", Offset = "0xE49650", VA = "0x180E4A450")]
	public static bool IncludeMySelf()
	{
		return default(bool);
	}

	[Token(Token = "0x60095E5")]
	[Address(RVA = "0xE498F0", Offset = "0xE48AF0", VA = "0x180E498F0")]
	public static int GetRankFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095E6")]
	[Address(RVA = "0xE49500", Offset = "0xE48700", VA = "0x180E49500")]
	public static PlatformID GetPlatformID(int player)
	{
		return default(PlatformID);
	}

	[Token(Token = "0x60095E7")]
	[Address(RVA = "0xE4C8F0", Offset = "0xE4BAF0", VA = "0x180E4C8F0")]
	public static int Myself()
	{
		return default(int);
	}

	[Token(Token = "0x60095E8")]
	[Address(RVA = "0xE45B40", Offset = "0xE44D40", VA = "0x180E45B40")]
	public static int FirstPlayer()
	{
		return default(int);
	}

	[Token(Token = "0x60095E9")]
	[Address(RVA = "0xE493A0", Offset = "0xE485A0", VA = "0x180E493A0")]
	public static OpeningMessageType GetOpeningMessageType(int player)
	{
		return default(OpeningMessageType);
	}

	[Token(Token = "0x60095EA")]
	[Address(RVA = "0xE49160", Offset = "0xE48360", VA = "0x180E49160")]
	public static string GetOpeningMessageBgPath(int player)
	{
		return null;
	}

	[Token(Token = "0x60095EB")]
	[Address(RVA = "0xE49300", Offset = "0xE48500", VA = "0x180E49300")]
	public static string GetOpeningMessageText(int player)
	{
		return null;
	}

	[Token(Token = "0x60095EC")]
	[Address(RVA = "0xE4A270", Offset = "0xE49470", VA = "0x180E4A270")]
	public static string GetUserName(int player)
	{
		return null;
	}

	[Token(Token = "0x60095ED")]
	[Address(RVA = "0xE47E90", Offset = "0xE47090", VA = "0x180E47E90")]
	public static void GetFilteredUserNamePair(int player, Action<string, string> onFinished)
	{
	}

	[Token(Token = "0x60095EE")]
	[Address(RVA = "0xE4A4E0", Offset = "0xE496E0", VA = "0x180E4A4E0")]
	public static void InitFilteredPlayerName()
	{
	}

	[Token(Token = "0x60095EF")]
	[Address(RVA = "0xE47C70", Offset = "0xE46E70", VA = "0x180E47C70")]
	public static string GetFilteredPlayerName(int player, bool hideNameCheck = true)
	{
		return null;
	}

	[Token(Token = "0x60095F0")]
	[Address(RVA = "0xE49430", Offset = "0xE48630", VA = "0x180E49430")]
	public static string GetOriginalPlayerName(int player)
	{
		return null;
	}

	[Token(Token = "0x60095F1")]
	[Address(RVA = "0xE48900", Offset = "0xE47B00", VA = "0x180E48900")]
	public static string GetMaskedName(int idx)
	{
		return null;
	}

	[Token(Token = "0x60095F2")]
	[Address(RVA = "0xE49FB0", Offset = "0xE491B0", VA = "0x180E49FB0")]
	public static int GetSpAccountTypeid(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095F3")]
	[Address(RVA = "0xE47F70", Offset = "0xE47170", VA = "0x180E47F70")]
	public static int GetFinalBlowFromPlayer(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095F4")]
	[Address(RVA = "0xE46270", Offset = "0xE45470", VA = "0x180E46270")]
	public static int GetCoinID(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095F5")]
	[Address(RVA = "0xE4ACB0", Offset = "0xE49EB0", VA = "0x180E4ACB0")]
	public static bool IsBlockRelativeCardList()
	{
		return default(bool);
	}

	[Token(Token = "0x60095F6")]
	[Address(RVA = "0xE4C470", Offset = "0xE4B670", VA = "0x180E4C470")]
	public static bool IsSpFieldUsed()
	{
		return default(bool);
	}

	[Token(Token = "0x60095F7")]
	[Address(RVA = "0xE47A20", Offset = "0xE46C20", VA = "0x180E47A20")]
	public static int GetDuelistLevel(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095F8")]
	[Address(RVA = "0xE49B30", Offset = "0xE48D30", VA = "0x180E49B30")]
	public static string GetRankText(int player)
	{
		return null;
	}

	[Token(Token = "0x60095F9")]
	[Address(RVA = "0xE499C0", Offset = "0xE48BC0", VA = "0x180E499C0")]
	public static string[] GetRankIconPaths(int player)
	{
		return null;
	}

	[Token(Token = "0x60095FA")]
	[Address(RVA = "0xE4A1D0", Offset = "0xE493D0", VA = "0x180E4A1D0")]
	public static string GetUserDetailBgPath(int player)
	{
		return null;
	}

	[Token(Token = "0x60095FB")]
	[Address(RVA = "0xE463A0", Offset = "0xE455A0", VA = "0x180E463A0")]
	public static int GetCountryId(int player)
	{
		return default(int);
	}

	[Token(Token = "0x60095FC")]
	[Address(RVA = "0xE46430", Offset = "0xE45630", VA = "0x180E46430")]
	public static string GetCountryName(int player)
	{
		return null;
	}

	[Token(Token = "0x60095FD")]
	[Address(RVA = "0xE4B620", Offset = "0xE4A820", VA = "0x180E4B620")]
	public static bool IsNewCountry(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x60095FE")]
	[Address(RVA = "0xE48140", Offset = "0xE47340", VA = "0x180E48140")]
	public static string[] GetFreeTextOfWin(int player)
	{
		return null;
	}

	[Token(Token = "0x60095FF")]
	[Address(RVA = "0xE45C70", Offset = "0xE44E70", VA = "0x180E45C70")]
	public static bool FreeTextOfWinExists(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009600")]
	[Address(RVA = "0xE480A0", Offset = "0xE472A0", VA = "0x180E480A0")]
	public static string GetFreeTextOfTurnChange(int player)
	{
		return null;
	}

	[Token(Token = "0x6009601")]
	[Address(RVA = "0xE45BA0", Offset = "0xE44DA0", VA = "0x180E45BA0")]
	public static bool FreeTextOfTurnChangeExists(int player)
	{
		return default(bool);
	}

	[Token(Token = "0x6009602")]
	[Address(RVA = "0xE49BD0", Offset = "0xE48DD0", VA = "0x180E49BD0")]
	public static bool GetRealtimeSpectate()
	{
		return default(bool);
	}

	[Token(Token = "0x6009603")]
	[Address(RVA = "0xE487B0", Offset = "0xE479B0", VA = "0x180E487B0")]
	public static (int, int, PvpMenuDefine.MatchingType, int) GetLogoInfo(int logoMixID)
	{
		return default((int, int, PvpMenuDefine.MatchingType, int));
	}

	[Token(Token = "0x6009604")]
	[Address(RVA = "0xE48660", Offset = "0xE47860", VA = "0x180E48660")]
	public static (int, int, PvpMenuDefine.MatchingType, int) GetLogoInfoFromClientWork()
	{
		return default((int, int, PvpMenuDefine.MatchingType, int));
	}

	[Token(Token = "0x6009605")]
	[Address(RVA = "0xE479E0", Offset = "0xE46BE0", VA = "0x180E479E0")]
	public static int GetDuelLiveContinuousCount()
	{
		return default(int);
	}

	[Token(Token = "0x6009606")]
	[Address(RVA = "0xE4AF40", Offset = "0xE4A140", VA = "0x180E4AF40")]
	public static bool IsDuelLiveCoutinuous()
	{
		return default(bool);
	}

	[Token(Token = "0x6009607")]
	[Address(RVA = "0xE45980", Offset = "0xE44B80", VA = "0x180E45980")]
	public static void DecDuelLiveContinuousCount()
	{
	}

	[Token(Token = "0x6009608")]
	[Address(RVA = "0xE4CF70", Offset = "0xE4C170", VA = "0x180E4CF70")]
	public static void SetDuelLiveCoutinuousCount(int count)
	{
	}

	[Token(Token = "0x6009609")]
	[Address(RVA = "0xE45E10", Offset = "0xE45010", VA = "0x180E45E10")]
	public static AttackLevel GetAttackLevel(int atk)
	{
		return default(AttackLevel);
	}

	[Token(Token = "0x600960A")]
	[Address(RVA = "0xE49880", Offset = "0xE48A80", VA = "0x180E49880")]
	public static byte[] GetQuestionData(int qid)
	{
		return null;
	}

	[Token(Token = "0x600960B")]
	[Address(RVA = "0xE46F80", Offset = "0xE46180", VA = "0x180E46F80")]
	public static string GetDuelEndReasonTextFormat(Engine.ResultType resultType, Engine.FinishType finishType, string playerNameNear, string playerNameFar, bool isAutoSurrender)
	{
		return null;
	}

	[Token(Token = "0x600960C")]
	[Address(RVA = "0xE47720", Offset = "0xE46920", VA = "0x180E47720")]
	public static string GetDuelEndReasonText(string textFormat, Engine.ResultType resultType, Engine.FinishType finishType, string playerNameNear, string playerNameFar)
	{
		return null;
	}

	[Token(Token = "0x600960D")]
	[Address(RVA = "0xE4C9C0", Offset = "0xE4BBC0", VA = "0x180E4C9C0")]
	public static int PvpNetworkTimedOutThrethold(int defaultTime = 30)
	{
		return default(int);
	}

	[Token(Token = "0x600960E")]
	[Address(RVA = "0xE4CA20", Offset = "0xE4BC20", VA = "0x180E4CA20")]
	public static float PvpNetworkWaitTime(float defaultTime = 20f)
	{
		return default(float);
	}

	[Token(Token = "0x600960F")]
	[Address(RVA = "0xE4C950", Offset = "0xE4BB50", VA = "0x180E4C950")]
	public static float PvpNetworkRetryTime(float defaultTime = 5f)
	{
		return default(float);
	}

	[Token(Token = "0x6009610")]
	[Address(RVA = "0xE46040", Offset = "0xE45240", VA = "0x180E46040")]
	public static int GetCardOwner(int uniqueId)
	{
		return default(int);
	}

	[Token(Token = "0x6009611")]
	[Address(RVA = "0xE4B820", Offset = "0xE4AA20", VA = "0x180E4B820")]
	public static bool IsPveMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6009612")]
	[Address(RVA = "0xE4B750", Offset = "0xE4A950", VA = "0x180E4B750")]
	public static bool IsPvPMode()
	{
		return default(bool);
	}

	[Token(Token = "0x6009613")]
	[Address(RVA = "0xE49CB0", Offset = "0xE48EB0", VA = "0x180E49CB0")]
	public static int GetReplayMaxTurn()
	{
		return default(int);
	}

	[Token(Token = "0x6009614")]
	[Address(RVA = "0xE496A0", Offset = "0xE488A0", VA = "0x180E496A0")]
	public static PublicLevel GetPublicLevel()
	{
		return default(PublicLevel);
	}

	[Token(Token = "0x6009615")]
	[Address(RVA = "0xE46190", Offset = "0xE45390", VA = "0x180E46190")]
	public static int GetChapter()
	{
		return default(int);
	}

	[Token(Token = "0x6009616")]
	[Address(RVA = "0xE4B880", Offset = "0xE4AA80", VA = "0x180E4B880")]
	public static bool IsRentalDeck()
	{
		return default(bool);
	}

	[Token(Token = "0x6009617")]
	[Address(RVA = "0xE4B1D0", Offset = "0xE4A3D0", VA = "0x180E4B1D0")]
	public static int IsFollowing()
	{
		return default(int);
	}

	[Token(Token = "0x6009618")]
	[Address(RVA = "0xE4B140", Offset = "0xE4A340", VA = "0x180E4B140")]
	public static bool IsFollowMax()
	{
		return default(bool);
	}

	[Token(Token = "0x6009619")]
	[Address(RVA = "0xE4B6F0", Offset = "0xE4A8F0", VA = "0x180E4B6F0")]
	public static bool IsProfileRemake()
	{
		return default(bool);
	}

	[Token(Token = "0x600961A")]
	[Address(RVA = "0xE495D0", Offset = "0xE487D0", VA = "0x180E495D0")]
	public static Dictionary<string, object> GetPlayerProfile(int player, bool isMyself)
	{
		return null;
	}

	[Token(Token = "0x600961B")]
	[Address(RVA = "0xE48590", Offset = "0xE47790", VA = "0x180E48590")]
	public static bool GetIsSameOS(int player, bool myself)
	{
		return default(bool);
	}

	[Token(Token = "0x600961C")]
	[Address(RVA = "0xE49090", Offset = "0xE48290", VA = "0x180E49090")]
	public static string GetOnlineID(int player, bool isSameOS)
	{
		return null;
	}

	[Token(Token = "0x600961D")]
	[Address(RVA = "0xE46F00", Offset = "0xE46100", VA = "0x180E46F00")]
	public static DisplayType GetDisplayType()
	{
		return default(DisplayType);
	}

	[Token(Token = "0x600961E")]
	[Address(RVA = "0xE4B4D0", Offset = "0xE4A6D0", VA = "0x180E4B4D0")]
	public static bool IsMobileLayout()
	{
		return default(bool);
	}

	[Token(Token = "0x600961F")]
	[Address(RVA = "0xE4ADA0", Offset = "0xE49FA0", VA = "0x180E4ADA0")]
	public static bool IsCameraTypeNear()
	{
		return default(bool);
	}

	[Token(Token = "0x6009620")]
	[Address(RVA = "0xE4CE40", Offset = "0xE4C040", VA = "0x180E4CE40")]
	public static Vector3 ScreenPointToFixedHeightWorldPoint(Vector2 screenPoint, float height, Camera camera)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6009621")]
	[Address(RVA = "0xE4C5E0", Offset = "0xE4B7E0", VA = "0x180E4C5E0")]
	public static bool IsStrategicTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x6009622")]
	[Address(RVA = "0xE4C770", Offset = "0xE4B970", VA = "0x180E4C770")]
	public static bool IsTutorialDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6009623")]
	[Address(RVA = "0xE46110", Offset = "0xE45310", VA = "0x180E46110")]
	public static SettingsUtil.DuelParam.CHAIN_TYPE GetChainTypeSetting()
	{
		return default(SettingsUtil.DuelParam.CHAIN_TYPE);
	}

	[Token(Token = "0x6009624")]
	[Address(RVA = "0xE4AEC0", Offset = "0xE4A0C0", VA = "0x180E4AEC0")]
	public static bool IsDecisionActivationOrder()
	{
		return default(bool);
	}

	[Token(Token = "0x6009625")]
	[Address(RVA = "0xE4AA80", Offset = "0xE49C80", VA = "0x180E4AA80")]
	public static bool IsAutoLocation()
	{
		return default(bool);
	}

	[Token(Token = "0x6009626")]
	[Address(RVA = "0xE4DE30", Offset = "0xE4D030", VA = "0x180E4DE30")]
	public static bool UseRetry()
	{
		return default(bool);
	}

	[Token(Token = "0x6009627")]
	[Address(RVA = "0xE4AB00", Offset = "0xE49D00", VA = "0x180E4AB00")]
	public static bool IsAutoShowCardInfo(bool cardShow)
	{
		return default(bool);
	}

	[Token(Token = "0x6009628")]
	[Address(RVA = "0xE4BC70", Offset = "0xE4AE70", VA = "0x180E4BC70")]
	public static bool IsShowCardReport()
	{
		return default(bool);
	}

	[Token(Token = "0x6009629")]
	[Address(RVA = "0xE4BA50", Offset = "0xE4AC50", VA = "0x180E4BA50")]
	public static bool IsShowAudienceInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x600962A")]
	[Address(RVA = "0xE4BB60", Offset = "0xE4AD60", VA = "0x180E4BB60")]
	public static bool IsShowBattleStep()
	{
		return default(bool);
	}

	[Token(Token = "0x600962B")]
	[Address(RVA = "0xE4BD90", Offset = "0xE4AF90", VA = "0x180E4BD90")]
	public static bool IsShowSetCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600962C")]
	[Address(RVA = "0xE488C0", Offset = "0xE47AC0", VA = "0x180E488C0")]
	public static SettingsUtil.DuelParam.MANUAL_TYPE GetManualType()
	{
		return default(SettingsUtil.DuelParam.MANUAL_TYPE);
	}

	[Token(Token = "0x600962D")]
	[Address(RVA = "0xE46EC0", Offset = "0xE460C0", VA = "0x180E46EC0")]
	public static bool GetCustomConfirmUseSwitch()
	{
		return default(bool);
	}

	[Token(Token = "0x600962E")]
	[Address(RVA = "0xE46E00", Offset = "0xE46000", VA = "0x180E46E00")]
	public static SettingsUtil.DuelParam.CONFIRM_MODE GetCustomConfirmDefault()
	{
		return default(SettingsUtil.DuelParam.CONFIRM_MODE);
	}

	[Token(Token = "0x600962F")]
	[Address(RVA = "0xE46E40", Offset = "0xE46040", VA = "0x180E46E40")]
	public static SettingsUtil.DuelParam.CONFIRM_MODE GetCustomConfirmHold0()
	{
		return default(SettingsUtil.DuelParam.CONFIRM_MODE);
	}

	[Token(Token = "0x6009630")]
	[Address(RVA = "0xE46E80", Offset = "0xE46080", VA = "0x180E46E80")]
	public static SettingsUtil.DuelParam.CONFIRM_MODE GetCustomConfirmHold1()
	{
		return default(SettingsUtil.DuelParam.CONFIRM_MODE);
	}

	[Token(Token = "0x6009631")]
	[Address(RVA = "0xE48480", Offset = "0xE47680", VA = "0x180E48480")]
	public static SettingsUtil.SHOW_HAPPENEDEFFECT_TYPE GetHappenedEffectType()
	{
		return default(SettingsUtil.SHOW_HAPPENEDEFFECT_TYPE);
	}

	[Token(Token = "0x6009632")]
	[Address(RVA = "0xE46090", Offset = "0xE45290", VA = "0x180E46090")]
	public static int GetCardSelectionListLayoutType()
	{
		return default(int);
	}

	[Token(Token = "0x6009633")]
	[Address(RVA = "0xE48340", Offset = "0xE47540", VA = "0x180E48340")]
	public static int GetGenericCardListLayoutType()
	{
		return default(int);
	}

	[Token(Token = "0x6009634")]
	[Address(RVA = "0xE45E40", Offset = "0xE45040", VA = "0x180E45E40")]
	public static int GetAudienceGenericCardListLayoutType()
	{
		return default(int);
	}

	[Token(Token = "0x6009635")]
	[Address(RVA = "0xE4D010", Offset = "0xE4C210", VA = "0x180E4D010")]
	public static void SetShortKeyIconVisible(RunEffectWorker worker, bool active, bool isDialog)
	{
	}

	[Token(Token = "0x6009636")]
	[Address(RVA = "0xE4B010", Offset = "0xE4A210", VA = "0x180E4B010")]
	public static bool IsFastestReplay()
	{
		return default(bool);
	}

	[Token(Token = "0x6009637")]
	[Address(RVA = "0xE4C2A0", Offset = "0xE4B4A0", VA = "0x180E4C2A0")]
	public static bool IsSkipSummonEffect(Engine.SpSummonType spSummonType)
	{
		return default(bool);
	}

	[Token(Token = "0x6009638")]
	[Address(RVA = "0xE4CC70", Offset = "0xE4BE70", VA = "0x180E4CC70")]
	public static void RecordPlayedSpSummonEffectType(Engine.SpSummonType spSummonType)
	{
	}

	[Token(Token = "0x6009639")]
	[Address(RVA = "0xE4C0D0", Offset = "0xE4B2D0", VA = "0x180E4C0D0")]
	public static bool IsSkipMonsterCutin(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600963A")]
	[Address(RVA = "0xE4CB80", Offset = "0xE4BD80", VA = "0x180E4CB80")]
	public static void RecordPlayedMonsterCutinCardID(int cardID)
	{
	}

	[Token(Token = "0x600963B")]
	[Address(RVA = "0xE4BF00", Offset = "0xE4B100", VA = "0x180E4BF00")]
	public static bool IsSkipCardRunEffect(int cardID)
	{
		return default(bool);
	}

	[Token(Token = "0x600963C")]
	[Address(RVA = "0xE4CA90", Offset = "0xE4BC90", VA = "0x180E4CA90")]
	public static void RecordPlayedCardRunEffectCardID(int cardID)
	{
	}

	[Token(Token = "0x600963D")]
	[Address(RVA = "0xE4B260", Offset = "0xE4A460", VA = "0x180E4B260")]
	public static bool IsHidePlayerName()
	{
		return default(bool);
	}

	[Token(Token = "0x600963E")]
	[Address(RVA = "0x404830", Offset = "0x403A30", VA = "0x180404830")]
	public static bool UseDoubleClickDecide()
	{
		return default(bool);
	}

	[Token(Token = "0x600963F")]
	[Address(RVA = "0xE464D0", Offset = "0xE456D0", VA = "0x180E464D0")]
	public static (SharedDefinition.Location, int, int, int, int) GetCrossPos(SharedDefinition.Location location, int centerPosition)
	{
		return default((SharedDefinition.Location, int, int, int, int));
	}

	[Token(Token = "0x6009640")]
	[Address(RVA = "0xE4B410", Offset = "0xE4A610", VA = "0x180E4B410")]
	public static bool IsInsightTargetCard(int player, int position, bool showSetCardOption)
	{
		return default(bool);
	}

	[Token(Token = "0x6009641")]
	[Address(RVA = "0xE4C5D0", Offset = "0xE4B7D0", VA = "0x180E4C5D0")]
	public static bool IsStatusDetailTargetCard(int position)
	{
		return default(bool);
	}

	[Token(Token = "0x6009642")]
	[Address(RVA = "0xE4A0D0", Offset = "0xE492D0", VA = "0x180E4A0D0")]
	public static int GetTotalAtk(int player)
	{
		return default(int);
	}

	[Token(Token = "0x6009643")]
	[Address(RVA = "0xE4D830", Offset = "0xE4CA30", VA = "0x180E4D830")]
	public static void ShowProfileCard(Transform parent, Transform buttonParent, int player, bool isMyself, bool force, [Optional] Dictionary<string, object> profileData)
	{
	}

	[Token(Token = "0x6009644")]
	[Address(RVA = "0xE4D210", Offset = "0xE4C410", VA = "0x180E4D210")]
	public static GameObject ShowProfileCard(Transform parent, Transform buttonParent, bool force, Dictionary<string, object> profileData)
	{
		return null;
	}

	[Token(Token = "0x6009645")]
	[Address(RVA = "0xE4B0F0", Offset = "0xE4A2F0", VA = "0x180E4B0F0")]
	public static bool IsFixedPositonCommand()
	{
		return default(bool);
	}

	[Token(Token = "0x6009646")]
	[Address(RVA = "0xE4A080", Offset = "0xE49280", VA = "0x180E4A080")]
	public static int GetStyleID(int uniqueID)
	{
		return default(int);
	}

	[Token(Token = "0x6009647")]
	[Address(RVA = "0xE4DD10", Offset = "0xE4CF10", VA = "0x180E4DD10")]
	public static void UpdateOverrider(GameObject gob, bool force = false)
	{
	}

	[Token(Token = "0x6009648")]
	[Address(RVA = "0xE4CFB0", Offset = "0xE4C1B0", VA = "0x180E4CFB0")]
	public static void SetResultSubAvatar(bool flg)
	{
	}

	[Token(Token = "0x6009649")]
	[Address(RVA = "0xE49D70", Offset = "0xE48F70", VA = "0x180E49D70")]
	public static bool GetResultSubAvatar()
	{
		return default(bool);
	}

	[Token(Token = "0x600964A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Util()
	{
	}
}
