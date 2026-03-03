using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using YgomGame.CardPack;
using YgomGame.Colosseum;
using YgomGame.Duel;
using YgomGame.Menu;
using YgomGame.Shop;
using YgomGame.Utility;

namespace YgomSystem.Utility;

[Token(Token = "0x20003C1")]
public static class ClientWorkUtil
{
	[Token(Token = "0x40012F8")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static long ServerUnixTimeDiff;

	[Token(Token = "0x40012F9")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static DateTime UnixEpoch;

	[Token(Token = "0x1700024A")]
	public static bool HasServerTimeLag
	{
		[Token(Token = "0x60016CE")]
		[Address(RVA = "0x5B6210", Offset = "0x5B5410", VA = "0x1805B6210")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6001698")]
	[Address(RVA = "0x5B2420", Offset = "0x5B1620", VA = "0x1805B2420")]
	public static bool IsExistAccount()
	{
		return default(bool);
	}

	[Token(Token = "0x6001699")]
	[Address(RVA = "0x5B0300", Offset = "0x5AF500", VA = "0x1805B0300")]
	public static string GetToken()
	{
		return null;
	}

	[Token(Token = "0x600169A")]
	[Address(RVA = "0x5B5CC0", Offset = "0x5B4EC0", VA = "0x1805B5CC0")]
	public static void SetPushNotificationToken(string token)
	{
	}

	[Token(Token = "0x600169B")]
	[Address(RVA = "0x5AC9C0", Offset = "0x5ABBC0", VA = "0x1805AC9C0")]
	public static string GetPushNotificationToken()
	{
		return null;
	}

	[Token(Token = "0x600169C")]
	[Address(RVA = "0x5A2F20", Offset = "0x5A2120", VA = "0x1805A2F20")]
	public static string GetAdId()
	{
		return null;
	}

	[Token(Token = "0x600169D")]
	[Address(RVA = "0x5A8F30", Offset = "0x5A8130", VA = "0x1805A8F30")]
	public static string GetLang()
	{
		return null;
	}

	[Token(Token = "0x600169E")]
	[Address(RVA = "0x5B5D40", Offset = "0x5B4F40", VA = "0x1805B5D40")]
	public static void SetSocialId(string id)
	{
	}

	[Token(Token = "0x600169F")]
	[Address(RVA = "0x5AF110", Offset = "0x5AE310", VA = "0x1805AF110")]
	public static string GetSocialId()
	{
		return null;
	}

	[Token(Token = "0x60016A0")]
	[Address(RVA = "0x5B5C10", Offset = "0x5B4E10", VA = "0x1805B5C10")]
	public static void SetLanguage(string lang, bool noSave = false)
	{
	}

	[Token(Token = "0x60016A1")]
	[Address(RVA = "0x5AAB60", Offset = "0x5A9D60", VA = "0x1805AAB60")]
	public static long GetMyPlayerCode()
	{
		return default(long);
	}

	[Token(Token = "0x60016A2")]
	[Address(RVA = "0x5AAA90", Offset = "0x5A9C90", VA = "0x1805AAA90")]
	public static string GetMyPlayerCodeStringForAppIdentifier()
	{
		return null;
	}

	[Token(Token = "0x60016A3")]
	[Address(RVA = "0x5B21C0", Offset = "0x5B13C0", VA = "0x1805B21C0")]
	public static bool IsCrossPlayOK()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A4")]
	[Address(RVA = "0x5B2120", Offset = "0x5B1320", VA = "0x1805B2120")]
	public static bool IsCrossPlayOKOnGame()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A5")]
	[Address(RVA = "0x5B42A0", Offset = "0x5B34A0", VA = "0x1805B42A0")]
	public static bool IsMultiPlayOKByPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A6")]
	[Address(RVA = "0x5B2040", Offset = "0x5B1240", VA = "0x1805B2040")]
	public static bool IsCrossPlayOKByPlatform()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A7")]
	[Address(RVA = "0x5B44D0", Offset = "0x5B36D0", VA = "0x1805B44D0")]
	public static bool IsOptOut()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A8")]
	[Address(RVA = "0x5A24D0", Offset = "0x5A16D0", VA = "0x1805A24D0")]
	public static bool ExistOptOutKey()
	{
		return default(bool);
	}

	[Token(Token = "0x60016A9")]
	[Address(RVA = "0x5A2570", Offset = "0x5A1770", VA = "0x1805A2570")]
	public static bool ExistServerAgreementType()
	{
		return default(bool);
	}

	[Token(Token = "0x60016AA")]
	[Address(RVA = "0x5AE1F0", Offset = "0x5AD3F0", VA = "0x1805AE1F0")]
	public static int GetServerAgreementType()
	{
		return default(int);
	}

	[Token(Token = "0x60016AB")]
	[Address(RVA = "0x5B4740", Offset = "0x5B3940", VA = "0x1805B4740")]
	public static bool IsWCSFinalMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60016AC")]
	[Address(RVA = "0x5B2920", Offset = "0x5B1B20", VA = "0x1805B2920")]
	public static bool IsGameConfigRestrictedWCSMode()
	{
		return default(bool);
	}

	[Token(Token = "0x60016AD")]
	[Address(RVA = "0x5A23D0", Offset = "0x5A15D0", VA = "0x1805A23D0")]
	public static bool DownloadCompleted()
	{
		return default(bool);
	}

	[Token(Token = "0x60016AE")]
	[Address(RVA = "0x5A2470", Offset = "0x5A1670", VA = "0x1805A2470")]
	public static void DownloadFinish()
	{
	}

	[Token(Token = "0x60016AF")]
	[Address(RVA = "0x5A4530", Offset = "0x5A3730", VA = "0x1805A4530")]
	public static List<string> GetDownloadList()
	{
		return null;
	}

	[Token(Token = "0x60016B0")]
	[Address(RVA = "0x5A4850", Offset = "0x5A3A50", VA = "0x1805A4850")]
	public static List<Dictionary<string, string>> GetDownloadUrls()
	{
		return null;
	}

	[Token(Token = "0x60016B1")]
	[Address(RVA = "0x5A4770", Offset = "0x5A3970", VA = "0x1805A4770")]
	public static string GetDownloadRevision()
	{
		return null;
	}

	[Token(Token = "0x60016B2")]
	[Address(RVA = "0x5A4700", Offset = "0x5A3900", VA = "0x1805A4700")]
	public static string GetDownloadPass()
	{
		return null;
	}

	[Token(Token = "0x60016B3")]
	[Address(RVA = "0x5A47E0", Offset = "0x5A39E0", VA = "0x1805A47E0")]
	public static string GetDownloadSalt()
	{
		return null;
	}

	[Token(Token = "0x60016B4")]
	[Address(RVA = "0x5A9000", Offset = "0x5A8200", VA = "0x1805A9000")]
	public static string GetLocalDownloadRevision()
	{
		return null;
	}

	[Token(Token = "0x60016B5")]
	[Address(RVA = "0x5A8FA0", Offset = "0x5A81A0", VA = "0x1805A8FA0")]
	public static int GetLocalDownladListIndex()
	{
		return default(int);
	}

	[Token(Token = "0x60016B6")]
	[Address(RVA = "0x5A7270", Offset = "0x5A6470", VA = "0x1805A7270")]
	public static int GetFirstDownloadNum()
	{
		return default(int);
	}

	[Token(Token = "0x60016B7")]
	[Address(RVA = "0x5AF070", Offset = "0x5AE270", VA = "0x1805AF070")]
	public static bool GetShouldDownload()
	{
		return default(bool);
	}

	[Token(Token = "0x60016B8")]
	[Address(RVA = "0x5AFF50", Offset = "0x5AF150", VA = "0x1805AFF50")]
	public static string GetTakeOverUrl()
	{
		return null;
	}

	[Token(Token = "0x60016B9")]
	[Address(RVA = "0x5AD600", Offset = "0x5AC800", VA = "0x1805AD600")]
	public static string GetRegistUrl()
	{
		return null;
	}

	[Token(Token = "0x60016BA")]
	[Address(RVA = "0x5A8BA0", Offset = "0x5A7DA0", VA = "0x1805A8BA0")]
	public static bool GetInheritEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60016BB")]
	[Address(RVA = "0x5B2380", Offset = "0x5B1580", VA = "0x1805B2380")]
	public static bool IsDoubleNotationCandidate()
	{
		return default(bool);
	}

	[Token(Token = "0x60016BC")]
	[Address(RVA = "0x5A4290", Offset = "0x5A3490", VA = "0x1805A4290")]
	public static string GetDoubleNotationCurrency()
	{
		return null;
	}

	[Token(Token = "0x60016BD")]
	[Address(RVA = "0x5A4370", Offset = "0x5A3570", VA = "0x1805A4370")]
	public static float GetDoubleNotationRate()
	{
		return default(float);
	}

	[Token(Token = "0x60016BE")]
	[Address(RVA = "0x5A44C0", Offset = "0x5A36C0", VA = "0x1805A44C0")]
	public static string GetDoubleNotationUnit()
	{
		return null;
	}

	[Token(Token = "0x60016BF")]
	[Address(RVA = "0x5A4450", Offset = "0x5A3650", VA = "0x1805A4450")]
	public static string GetDoubleNotationSeparator()
	{
		return null;
	}

	[Token(Token = "0x60016C0")]
	[Address(RVA = "0x5A4300", Offset = "0x5A3500", VA = "0x1805A4300")]
	public static string GetDoubleNotationExchangeRateDisplay()
	{
		return null;
	}

	[Token(Token = "0x60016C1")]
	[Address(RVA = "0x5B4570", Offset = "0x5B3770", VA = "0x1805B4570")]
	public static bool IsRealtimeDuelWatchAvailable()
	{
		return default(bool);
	}

	[Token(Token = "0x60016C2")]
	[Address(RVA = "0x5AE250", Offset = "0x5AD450", VA = "0x1805AE250")]
	public static List<object> GetServerTips()
	{
		return null;
	}

	[Token(Token = "0x60016C3")]
	[Address(RVA = "0x5ACA30", Offset = "0x5ABC30", VA = "0x1805ACA30")]
	public static int GetPvpRank()
	{
		return default(int);
	}

	[Token(Token = "0x60016C4")]
	[Address(RVA = "0x5A3D40", Offset = "0x5A2F40", VA = "0x1805A3D40")]
	public static bool GetChatEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x60016C5")]
	[Address(RVA = "0x5B4EB0", Offset = "0x5B40B0", VA = "0x1805B4EB0")]
	public static int ObjectToInt(object i)
	{
		return default(int);
	}

	[Token(Token = "0x60016C6")]
	[Address(RVA = "0x5B4E60", Offset = "0x5B4060", VA = "0x1805B4E60")]
	public static float ObjectToFloat(object i)
	{
		return default(float);
	}

	[Token(Token = "0x60016C7")]
	[Address(RVA = "0x5B4DD0", Offset = "0x5B3FD0", VA = "0x1805B4DD0")]
	public static Color ObjectToColor(object c)
	{
		return default(Color);
	}

	[Token(Token = "0x60016C8")]
	[Address(RVA = "0x5B4F00", Offset = "0x5B4100", VA = "0x1805B4F00")]
	public static Vector2 ObjectToVector2(object c)
	{
		return default(Vector2);
	}

	[Token(Token = "0x60016C9")]
	public static T[] ListToTypedArray<T>(List<object> dic)
	{
		return null;
	}

	[Token(Token = "0x60016CA")]
	[Address(RVA = "0x5B49C0", Offset = "0x5B3BC0", VA = "0x1805B49C0")]
	public static int[] ListToIntArray(List<object> dic)
	{
		return null;
	}

	[Token(Token = "0x60016CB")]
	[Address(RVA = "0x5B09F0", Offset = "0x5AFBF0", VA = "0x1805B09F0")]
	public static long GetUnixTime()
	{
		return default(long);
	}

	[Token(Token = "0x60016CC")]
	[Address(RVA = "0x5AD390", Offset = "0x5AC590", VA = "0x1805AD390")]
	public static long GetRawUnixTime()
	{
		return default(long);
	}

	[Token(Token = "0x60016CD")]
	[Address(RVA = "0x5B5B70", Offset = "0x5B4D70", VA = "0x1805B5B70")]
	public static void ServerTimeNotificator(object v)
	{
	}

	[Token(Token = "0x60016CF")]
	[Address(RVA = "0x5B6000", Offset = "0x5B5200", VA = "0x1805B6000")]
	public static int getIntWithCache(string jsonPath, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60016D0")]
	[Address(RVA = "0x5B5F70", Offset = "0x5B5170", VA = "0x1805B5F70")]
	public static float getFloatWithCache(string jsonPath, float defaultValue = 0f)
	{
		return default(float);
	}

	[Token(Token = "0x60016D1")]
	[Address(RVA = "0x5B6190", Offset = "0x5B5390", VA = "0x1805B6190")]
	public static string getStringWithCache(string jsonPath, string defaultValue = "")
	{
		return null;
	}

	[Token(Token = "0x60016D2")]
	[Address(RVA = "0x5B5E40", Offset = "0x5B5040", VA = "0x1805B5E40")]
	public static bool getBoolByJsonPathWithCache(string jsonPath, bool defaultValue = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60016D3")]
	[Address(RVA = "0x5B5ED0", Offset = "0x5B50D0", VA = "0x1805B5ED0")]
	public static Dictionary<string, object> getDictionaryWithCache(string jsonPath, [Optional] Dictionary<string, object> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60016D4")]
	[Address(RVA = "0x5B6090", Offset = "0x5B5290", VA = "0x1805B6090")]
	public static List<object> getListWithCache(string jsonPath, [Optional] List<object> defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60016D5")]
	[Address(RVA = "0x5B6130", Offset = "0x5B5330", VA = "0x1805B6130")]
	public static object getObjectWithCache(string jsonPath, [Optional] object defaultValue)
	{
		return null;
	}

	[Token(Token = "0x60016D6")]
	[Address(RVA = "0x5B50B0", Offset = "0x5B42B0", VA = "0x1805B50B0")]
	public static void RegisterNotificator()
	{
	}

	[Token(Token = "0x60016D7")]
	[Address(RVA = "0x5B5710", Offset = "0x5B4910", VA = "0x1805B5710")]
	public static void ResetData()
	{
	}

	[Token(Token = "0x60016D8")]
	[Address(RVA = "0x5AB900", Offset = "0x5AAB00", VA = "0x1805AB900")]
	public static string GetPeriodItemName(int pCategory, int pItemId)
	{
		return null;
	}

	[Token(Token = "0x60016D9")]
	[Address(RVA = "0x5AB9C0", Offset = "0x5AABC0", VA = "0x1805AB9C0")]
	public static string GetPeriodItemThumb(int pCategory, int pItemId)
	{
		return null;
	}

	[Token(Token = "0x60016DA")]
	[Address(RVA = "0x5ABA80", Offset = "0x5AAC80", VA = "0x1805ABA80")]
	public static long GetPeriodLimitDateTs(int pCategory, int pItemId)
	{
		return default(long);
	}

	[Token(Token = "0x60016DB")]
	[Address(RVA = "0x5ACF00", Offset = "0x5AC100", VA = "0x1805ACF00")]
	public static string GetRankLabelId(int rank)
	{
		return null;
	}

	[Token(Token = "0x60016DC")]
	[Address(RVA = "0x5ACFF0", Offset = "0x5AC1F0", VA = "0x1805ACFF0")]
	public static string GetRankLabel(int rank, int tier)
	{
		return null;
	}

	[Token(Token = "0x60016DD")]
	[Address(RVA = "0x5A3720", Offset = "0x5A2920", VA = "0x1805A3720")]
	public static Dictionary<string, object> GetCardTermData(int mrk, int termType)
	{
		return null;
	}

	[Token(Token = "0x60016DE")]
	[Address(RVA = "0x5A38A0", Offset = "0x5A2AA0", VA = "0x1805A38A0")]
	public static Dictionary<string, object> GetCardTermData(int termId)
	{
		return null;
	}

	[Token(Token = "0x60016DF")]
	[Address(RVA = "0x5A69D0", Offset = "0x5A5BD0", VA = "0x1805A69D0")]
	public static List<object> GetExchangeProduct_CardPool(int exchangeId)
	{
		return null;
	}

	[Token(Token = "0x60016E0")]
	[Address(RVA = "0x5A6AC0", Offset = "0x5A5CC0", VA = "0x1805A6AC0")]
	public static Dictionary<string, object> GetExchangeProduct_Item(int exchangeId)
	{
		return null;
	}

	[Token(Token = "0x60016E1")]
	[Address(RVA = "0x5A6BC0", Offset = "0x5A5DC0", VA = "0x1805A6BC0")]
	public static Dictionary<string, object> GetExchangeResult()
	{
		return null;
	}

	[Token(Token = "0x60016E2")]
	[Address(RVA = "0x5AFD60", Offset = "0x5AEF60", VA = "0x1805AFD60")]
	public static IReadOnlyDictionary<string, object> GetStructureFirstData()
	{
		return null;
	}

	[Token(Token = "0x60016E3")]
	[Address(RVA = "0x5AFE00", Offset = "0x5AF000", VA = "0x1805AFE00")]
	public static object GetStructureMaster(int structureId)
	{
		return null;
	}

	[Token(Token = "0x60016E4")]
	[Address(RVA = "0x5B0F70", Offset = "0x5B0170", VA = "0x1805B0F70")]
	public static Dictionary<string, object> GetUserProfile()
	{
		return null;
	}

	[Token(Token = "0x60016E5")]
	[Address(RVA = "0x5B0EA0", Offset = "0x5B00A0", VA = "0x1805B0EA0")]
	public static string GetUserName()
	{
		return null;
	}

	[Token(Token = "0x60016E6")]
	[Address(RVA = "0x5B0E40", Offset = "0x5B0040", VA = "0x1805B0E40")]
	public static int GetUserLevel(int defaultValue = 1)
	{
		return default(int);
	}

	[Token(Token = "0x60016E7")]
	[Address(RVA = "0x5B1240", Offset = "0x5B0440", VA = "0x1805B1240")]
	public static int GetUserRank(int defaultValue = 1)
	{
		return default(int);
	}

	[Token(Token = "0x60016E8")]
	[Address(RVA = "0x5B13E0", Offset = "0x5B05E0", VA = "0x1805B13E0")]
	public static int GetUserTier(int defaultValue = 5)
	{
		return default(int);
	}

	[Token(Token = "0x60016E9")]
	[Address(RVA = "0x5B1440", Offset = "0x5B0640", VA = "0x1805B1440")]
	public static int GetUserWallpaper(int defaultValue = 1)
	{
		return default(int);
	}

	[Token(Token = "0x60016EA")]
	[Address(RVA = "0x5B0B90", Offset = "0x5AFD90", VA = "0x1805B0B90")]
	public static int GetUserFavWallpaperRandom(int defaultValue = 1)
	{
		return default(int);
	}

	[Token(Token = "0x60016EB")]
	[Address(RVA = "0x5B0F10", Offset = "0x5B0110", VA = "0x1805B0F10")]
	public static long GetUserPcode()
	{
		return default(long);
	}

	[Token(Token = "0x60016EC")]
	[Address(RVA = "0x5A7AA0", Offset = "0x5A6CA0", VA = "0x1805A7AA0")]
	public static Dictionary<string, object> GetFriendProfile()
	{
		return null;
	}

	[Token(Token = "0x60016ED")]
	[Address(RVA = "0x5B12A0", Offset = "0x5B04A0", VA = "0x1805B12A0")]
	public static Dictionary<string, object> GetUserReplays()
	{
		return null;
	}

	[Token(Token = "0x60016EE")]
	[Address(RVA = "0x5A7C70", Offset = "0x5A6E70", VA = "0x1805A7C70")]
	public static Dictionary<string, object> GetFriendReplays()
	{
		return null;
	}

	[Token(Token = "0x60016EF")]
	[Address(RVA = "0x5AD670", Offset = "0x5AC870", VA = "0x1805AD670")]
	public static object GetReplayInfo()
	{
		return null;
	}

	[Token(Token = "0x60016F0")]
	[Address(RVA = "0x5AE140", Offset = "0x5AD340", VA = "0x1805AE140")]
	public static int GetSavedReplayNum([Optional] object replayInfo)
	{
		return default(int);
	}

	[Token(Token = "0x60016F1")]
	[Address(RVA = "0x5AE090", Offset = "0x5AD290", VA = "0x1805AE090")]
	public static int GetSavableReplayMax([Optional] object replayInfo)
	{
		return default(int);
	}

	[Token(Token = "0x60016F2")]
	[Address(RVA = "0x5A9070", Offset = "0x5A8270", VA = "0x1805A9070")]
	public static int GetLockedReplayNum([Optional] object replayInfo)
	{
		return default(int);
	}

	[Token(Token = "0x60016F3")]
	[Address(RVA = "0x5B27E0", Offset = "0x5B19E0", VA = "0x1805B27E0")]
	public static bool IsFriendInBattle(object friendData)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F4")]
	[Address(RVA = "0x5B2840", Offset = "0x5B1A40", VA = "0x1805B2840")]
	public static bool IsFriendOnline(object friendData)
	{
		return default(bool);
	}

	[Token(Token = "0x60016F5")]
	[Address(RVA = "0x5B0D80", Offset = "0x5AFF80", VA = "0x1805B0D80")]
	public static Dictionary<string, object> GetUserHistory(int mode)
	{
		return null;
	}

	[Token(Token = "0x60016F6")]
	[Address(RVA = "0x5B0D20", Offset = "0x5AFF20", VA = "0x1805B0D20")]
	public static long GetUserHistoryReplayLimit()
	{
		return default(long);
	}

	[Token(Token = "0x60016F7")]
	[Address(RVA = "0x5B0AF0", Offset = "0x5AFCF0", VA = "0x1805B0AF0")]
	public static Dictionary<string, object> GetUserAchievements()
	{
		return null;
	}

	[Token(Token = "0x60016F8")]
	[Address(RVA = "0x5AA9F0", Offset = "0x5A9BF0", VA = "0x1805AA9F0")]
	public static Dictionary<string, object> GetMyCardFiles()
	{
		return null;
	}

	[Token(Token = "0x60016F9")]
	[Address(RVA = "0x5AA920", Offset = "0x5A9B20", VA = "0x1805AA920")]
	public static Dictionary<string, object> GetMyCardFile(int itemId)
	{
		return null;
	}

	[Token(Token = "0x60016FA")]
	[Address(RVA = "0x5AA730", Offset = "0x5A9930", VA = "0x1805AA730")]
	public static Dictionary<string, object> GetMyCardFileCardList(int itemId)
	{
		return null;
	}

	[Token(Token = "0x60016FB")]
	[Address(RVA = "0x5AA800", Offset = "0x5A9A00", VA = "0x1805AA800")]
	public static int GetMyCardFileCompleteStatus(int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x60016FC")]
	[Address(RVA = "0x5AA890", Offset = "0x5A9A90", VA = "0x1805AA890")]
	public static int GetMyCardFileSortType(int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x60016FD")]
	[Address(RVA = "0x5A79A0", Offset = "0x5A6BA0", VA = "0x1805A79A0")]
	public static Dictionary<string, object> GetFriendCardFiles()
	{
		return null;
	}

	[Token(Token = "0x60016FE")]
	[Address(RVA = "0x5A78D0", Offset = "0x5A6AD0", VA = "0x1805A78D0")]
	public static Dictionary<string, object> GetFriendCardFile(int itemId)
	{
		return null;
	}

	[Token(Token = "0x60016FF")]
	[Address(RVA = "0x5A3570", Offset = "0x5A2770", VA = "0x1805A3570")]
	public static List<object> GetCardFileHaveFileList()
	{
		return null;
	}

	[Token(Token = "0x6001700")]
	[Address(RVA = "0x5A3610", Offset = "0x5A2810", VA = "0x1805A3610")]
	public static Dictionary<string, object> GetCardFileNotCollectList()
	{
		return null;
	}

	[Token(Token = "0x6001701")]
	[Address(RVA = "0x5A95E0", Offset = "0x5A87E0", VA = "0x1805A95E0")]
	public static Dictionary<string, object> GetMasterCardFiles()
	{
		return null;
	}

	[Token(Token = "0x6001702")]
	[Address(RVA = "0x5A9510", Offset = "0x5A8710", VA = "0x1805A9510")]
	public static Dictionary<string, object> GetMasterCardFile(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6001703")]
	[Address(RVA = "0x5A9440", Offset = "0x5A8640", VA = "0x1805A9440")]
	public static Dictionary<string, object> GetMasterCardFileCardList(int itemId)
	{
		return null;
	}

	[Token(Token = "0x6001704")]
	[Address(RVA = "0x5A9350", Offset = "0x5A8550", VA = "0x1805A9350")]
	public static Dictionary<string, object> GetMasterCardFileCardInfo(int itemId, int mrk)
	{
		return null;
	}

	[Token(Token = "0x6001705")]
	[Address(RVA = "0x5B2740", Offset = "0x5B1940", VA = "0x1805B2740")]
	public static bool IsExistsUserReview()
	{
		return default(bool);
	}

	[Token(Token = "0x6001706")]
	[Address(RVA = "0x5B1340", Offset = "0x5B0540", VA = "0x1805B1340")]
	public static IReadOnlyDictionary<string, object> GetUserReview()
	{
		return null;
	}

	[Token(Token = "0x6001707")]
	[Address(RVA = "0x5A89C0", Offset = "0x5A7BC0", VA = "0x1805A89C0")]
	public static IReadOnlyDictionary<string, object> GetGemShopProducts()
	{
		return null;
	}

	[Token(Token = "0x6001708")]
	[Address(RVA = "0x5A88F0", Offset = "0x5A7AF0", VA = "0x1805A88F0")]
	public static IReadOnlyDictionary<string, object> GetGemShopProduct(long shopPaidId)
	{
		return null;
	}

	[Token(Token = "0x6001709")]
	[Address(RVA = "0x5A8780", Offset = "0x5A7980", VA = "0x1805A8780")]
	public static List<object> GetGemShopConfirmRegDatas(int confirmRegId)
	{
		return null;
	}

	[Token(Token = "0x600170A")]
	[Address(RVA = "0x5A86E0", Offset = "0x5A78E0", VA = "0x1805A86E0")]
	public static IReadOnlyDictionary<string, object> GetGemShopBuyResult()
	{
		return null;
	}

	[Token(Token = "0x600170B")]
	[Address(RVA = "0x5A8850", Offset = "0x5A7A50", VA = "0x1805A8850")]
	public static IReadOnlyDictionary<string, object> GetGemShopInform()
	{
		return null;
	}

	[Token(Token = "0x600170C")]
	[Address(RVA = "0x5A8A60", Offset = "0x5A7C60", VA = "0x1805A8A60")]
	public static IReadOnlyDictionary<string, object> GetGemShopPromo()
	{
		return null;
	}

	[Token(Token = "0x600170D")]
	[Address(RVA = "0x5AE540", Offset = "0x5AD740", VA = "0x1805AE540")]
	public static bool GetShopIsRequireGetList()
	{
		return default(bool);
	}

	[Token(Token = "0x600170E")]
	[Address(RVA = "0x5AE4D0", Offset = "0x5AD6D0", VA = "0x1805AE4D0")]
	public static string GetShopIsRequireGetList_Dialog_Title()
	{
		return null;
	}

	[Token(Token = "0x600170F")]
	[Address(RVA = "0x5AE460", Offset = "0x5AD660", VA = "0x1805AE460")]
	public static string GetShopIsRequireGetList_Dialog_Message()
	{
		return null;
	}

	[Token(Token = "0x6001710")]
	[Address(RVA = "0x5AE2F0", Offset = "0x5AD4F0", VA = "0x1805AE2F0")]
	public static bool GetShopCloseByFailedPurchase()
	{
		return default(bool);
	}

	[Token(Token = "0x6001711")]
	[Address(RVA = "0x5AEC40", Offset = "0x5ADE40", VA = "0x1805AEC40")]
	public static Dictionary<string, object> GetShopProductsByCategory(ShopDef.ShowcaseCategory productCategory)
	{
		return null;
	}

	[Token(Token = "0x6001712")]
	[Address(RVA = "0x5AE750", Offset = "0x5AD950", VA = "0x1805AE750")]
	public static (ShopDef.ShowcaseCategory, Dictionary<string, object>) GetShopProductData(int shopId, int slotNo = -1)
	{
		return default((ShopDef.ShowcaseCategory, Dictionary<string, object>));
	}

	[Token(Token = "0x6001713")]
	[Address(RVA = "0x5AC0B0", Offset = "0x5AB2B0", VA = "0x1805AC0B0")]
	public static Dictionary<string, object> GetProductByCategory(ShopDef.ShowcaseCategory productCategory, int shopId, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x6001714")]
	[Address(RVA = "0x5AE390", Offset = "0x5AD590", VA = "0x1805AE390")]
	public static List<object> GetShopConfirmRegDatas(int confirmRegId)
	{
		return null;
	}

	[Token(Token = "0x6001715")]
	[Address(RVA = "0x5AEFD0", Offset = "0x5AE1D0", VA = "0x1805AEFD0")]
	public static Dictionary<string, object> GetShopTicketInfo()
	{
		return null;
	}

	[Token(Token = "0x6001716")]
	[Address(RVA = "0x5B4610", Offset = "0x5B3810", VA = "0x1805B4610")]
	public static bool IsShopPayItemSpecial(bool isPeriod, int itemCategory, int itemId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001717")]
	[Address(RVA = "0x5AE5E0", Offset = "0x5AD7E0", VA = "0x1805AE5E0")]
	public static int GetShopPeriodItemHave(int pItemCategory, int pItemId)
	{
		return default(int);
	}

	[Token(Token = "0x6001718")]
	[Address(RVA = "0x5AE690", Offset = "0x5AD890", VA = "0x1805AE690")]
	public static string GetShopPeriodItemLimitDateStr(int pItemCategory, int pItemId)
	{
		return null;
	}

	[Token(Token = "0x6001719")]
	[Address(RVA = "0x5A2C10", Offset = "0x5A1E10", VA = "0x1805A2C10")]
	public static int FindShopPayItemUsableShopId(bool isPeriod, int itemCategory, int itemId)
	{
		return default(int);
	}

	[Token(Token = "0x600171A")]
	[Address(RVA = "0x5A3150", Offset = "0x5A2350", VA = "0x1805A3150")]
	public static Dictionary<string, object> GetAllProductPickup()
	{
		return null;
	}

	[Token(Token = "0x600171B")]
	[Address(RVA = "0x5AC320", Offset = "0x5AB520", VA = "0x1805AC320")]
	public static Dictionary<string, object> GetProductPickup(int shopId, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x600171C")]
	[Address(RVA = "0x5A2F90", Offset = "0x5A2190", VA = "0x1805A2F90")]
	public static Dictionary<string, object> GetAllPackDatas()
	{
		return null;
	}

	[Token(Token = "0x600171D")]
	[Address(RVA = "0x5AC610", Offset = "0x5AB810", VA = "0x1805AC610")]
	public static (ShopDef.ShowcaseCategory, Dictionary<string, object>) GetProduct(int shopId, int slotNo = -1)
	{
		return default((ShopDef.ShowcaseCategory, Dictionary<string, object>));
	}

	[Token(Token = "0x600171E")]
	[Address(RVA = "0x5AB210", Offset = "0x5AA410", VA = "0x1805AB210")]
	public static Dictionary<string, object> GetPackDatasInTypes(params CardPackDef.PackType[] packTypes)
	{
		return null;
	}

	[Token(Token = "0x600171F")]
	[Address(RVA = "0x5AC210", Offset = "0x5AB410", VA = "0x1805AC210")]
	public static Dictionary<string, object> GetProductPack(int shopId, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x6001720")]
	[Address(RVA = "0x5B2620", Offset = "0x5B1820", VA = "0x1805B2620")]
	public static bool IsExistsSecretPack()
	{
		return default(bool);
	}

	[Token(Token = "0x6001721")]
	[Address(RVA = "0x5A3310", Offset = "0x5A2510", VA = "0x1805A3310")]
	public static Dictionary<string, object> GetAllProductStructure()
	{
		return null;
	}

	[Token(Token = "0x6001722")]
	[Address(RVA = "0x5AC500", Offset = "0x5AB700", VA = "0x1805AC500")]
	public static Dictionary<string, object> GetProductStructure(int shopId, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x6001723")]
	[Address(RVA = "0x5A3230", Offset = "0x5A2430", VA = "0x1805A3230")]
	public static Dictionary<string, object> GetAllProductSpecial()
	{
		return null;
	}

	[Token(Token = "0x6001724")]
	[Address(RVA = "0x5AC3F0", Offset = "0x5AB5F0", VA = "0x1805AC3F0")]
	public static Dictionary<string, object> GetProductSpecial(int shopId, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x6001725")]
	[Address(RVA = "0x5A2A60", Offset = "0x5A1C60", VA = "0x1805A2A60")]
	public static bool ExistsShopMarketProduct()
	{
		return default(bool);
	}

	[Token(Token = "0x6001726")]
	[Address(RVA = "0x5A3070", Offset = "0x5A2270", VA = "0x1805A3070")]
	public static Dictionary<string, object> GetAllProductAccessory()
	{
		return null;
	}

	[Token(Token = "0x6001727")]
	[Address(RVA = "0x5ABFE0", Offset = "0x5AB1E0", VA = "0x1805ABFE0")]
	public static Dictionary<string, object> GetProductAccessory(int shopId, int slotNo = -1)
	{
		return null;
	}

	[Token(Token = "0x6001728")]
	[Address(RVA = "0x5AEF30", Offset = "0x5AE130", VA = "0x1805AEF30")]
	public static Dictionary<string, object> GetShopPurchaseResult()
	{
		return null;
	}

	[Token(Token = "0x6001729")]
	[Address(RVA = "0x5A2330", Offset = "0x5A1530", VA = "0x1805A2330")]
	public static bool ContainsGachaDrawInfo()
	{
		return default(bool);
	}

	[Token(Token = "0x600172A")]
	[Address(RVA = "0x5A8540", Offset = "0x5A7740", VA = "0x1805A8540")]
	public static Dictionary<string, object> GetGachaDrawInfo()
	{
		return null;
	}

	[Token(Token = "0x600172B")]
	[Address(RVA = "0x5A7FE0", Offset = "0x5A71E0", VA = "0x1805A7FE0")]
	public static List<object> GetGachaDrawCardInfo()
	{
		return null;
	}

	[Token(Token = "0x600172C")]
	[Address(RVA = "0x5A8640", Offset = "0x5A7840", VA = "0x1805A8640")]
	public static Dictionary<string, object> GetGachaResult()
	{
		return null;
	}

	[Token(Token = "0x600172D")]
	[Address(RVA = "0x5B2560", Offset = "0x5B1760", VA = "0x1805B2560")]
	public static bool IsExistsGachaCardList(int cardListId)
	{
		return default(bool);
	}

	[Token(Token = "0x600172E")]
	[Address(RVA = "0x5A7F10", Offset = "0x5A7110", VA = "0x1805A7F10")]
	public static IReadOnlyList<object> GetGachaCardList(int cardListId)
	{
		return null;
	}

	[Token(Token = "0x600172F")]
	[Address(RVA = "0x5A85E0", Offset = "0x5A77E0", VA = "0x1805A85E0")]
	public static object GetGachaRateData()
	{
		return null;
	}

	[Token(Token = "0x6001730")]
	[Address(RVA = "0x5ABD30", Offset = "0x5AAF30", VA = "0x1805ABD30")]
	public static Dictionary<string, object> GetPrizeData(int prizeId)
	{
		return null;
	}

	[Token(Token = "0x6001731")]
	[Address(RVA = "0x5ABF40", Offset = "0x5AB140", VA = "0x1805ABF40")]
	public static Dictionary<string, object> GetPrizeResultInfo()
	{
		return null;
	}

	[Token(Token = "0x6001732")]
	[Address(RVA = "0x5ABEA0", Offset = "0x5AB0A0", VA = "0x1805ABEA0")]
	public static Dictionary<string, object> GetPrizeItemResultInfo()
	{
		return null;
	}

	[Token(Token = "0x6001733")]
	[Address(RVA = "0x5ABE00", Offset = "0x5AB000", VA = "0x1805ABE00")]
	public static bool GetPrizeIsPresentSend()
	{
		return default(bool);
	}

	[Token(Token = "0x6001734")]
	[Address(RVA = "0x5A2860", Offset = "0x5A1A60", VA = "0x1805A2860")]
	public static bool ExistsMarket()
	{
		return default(bool);
	}

	[Token(Token = "0x6001735")]
	[Address(RVA = "0x5B1DE0", Offset = "0x5B0FE0", VA = "0x1805B1DE0")]
	public static bool IsAgreeMarket()
	{
		return default(bool);
	}

	[Token(Token = "0x6001736")]
	[Address(RVA = "0x5A92F0", Offset = "0x5A84F0", VA = "0x1805A92F0")]
	public static int GetMarketId()
	{
		return default(int);
	}

	[Token(Token = "0x6001737")]
	[Address(RVA = "0x5A2760", Offset = "0x5A1960", VA = "0x1805A2760")]
	public static bool ExistsMarketData(int marketId)
	{
		return default(bool);
	}

	[Token(Token = "0x6001738")]
	[Address(RVA = "0x5A9220", Offset = "0x5A8420", VA = "0x1805A9220")]
	public static Dictionary<string, object> GetMarketData(int marketId)
	{
		return null;
	}

	[Token(Token = "0x6001739")]
	[Address(RVA = "0x5A6140", Offset = "0x5A5340", VA = "0x1805A6140")]
	public static int GetDuelMenuStandardSeason()
	{
		return default(int);
	}

	[Token(Token = "0x600173A")]
	[Address(RVA = "0x5A60A0", Offset = "0x5A52A0", VA = "0x1805A60A0")]
	public static Dictionary<string, object> GetDuelMenuStandardHolding()
	{
		return null;
	}

	[Token(Token = "0x600173B")]
	[Address(RVA = "0x5A5FD0", Offset = "0x5A51D0", VA = "0x1805A5FD0")]
	public static Dictionary<string, object> GetDuelMenuRateDuelHolding(int seasonID)
	{
		return null;
	}

	[Token(Token = "0x600173C")]
	[Address(RVA = "0x5A55F0", Offset = "0x5A47F0", VA = "0x1805A55F0")]
	public static Dictionary<string, object> GetDuelMenuExhibitionHolding(int tid)
	{
		return null;
	}

	[Token(Token = "0x600173D")]
	[Address(RVA = "0x5A5450", Offset = "0x5A4650", VA = "0x1805A5450")]
	public static Dictionary<string, object> GetDuelMenuDiceRallyHolding(int tid)
	{
		return null;
	}

	[Token(Token = "0x600173E")]
	[Address(RVA = "0x5B2EC0", Offset = "0x5B20C0", VA = "0x1805B2EC0")]
	public static bool IsHoldingExhibition(int exid)
	{
		return default(bool);
	}

	[Token(Token = "0x600173F")]
	[Address(RVA = "0x5B3F40", Offset = "0x5B3140", VA = "0x1805B3F40")]
	public static bool IsHoldingStandard()
	{
		return default(bool);
	}

	[Token(Token = "0x6001740")]
	[Address(RVA = "0x5B3DA0", Offset = "0x5B2FA0", VA = "0x1805B3DA0")]
	public static bool IsHoldingRateDuel(int seasonID)
	{
		return default(bool);
	}

	[Token(Token = "0x6001741")]
	[Address(RVA = "0x5B2B80", Offset = "0x5B1D80", VA = "0x1805B2B80")]
	public static bool IsHoldingDiceRally(int drid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001742")]
	[Address(RVA = "0x5B41B0", Offset = "0x5B33B0", VA = "0x1805B41B0")]
	public static bool IsMatchingStandard()
	{
		return default(bool);
	}

	[Token(Token = "0x6001743")]
	[Address(RVA = "0x5A5820", Offset = "0x5A4A20", VA = "0x1805A5820")]
	public static Dictionary<string, object> GetDuelMenuFreeHolding()
	{
		return null;
	}

	[Token(Token = "0x6001744")]
	[Address(RVA = "0x5B3070", Offset = "0x5B2270", VA = "0x1805B3070")]
	public static bool IsHoldingFree()
	{
		return default(bool);
	}

	[Token(Token = "0x6001745")]
	[Address(RVA = "0x5A61A0", Offset = "0x5A53A0", VA = "0x1805A61A0")]
	public static Dictionary<string, object> GetDuelMenuTeamMatchHolding()
	{
		return null;
	}

	[Token(Token = "0x6001746")]
	[Address(RVA = "0x5B4030", Offset = "0x5B3230", VA = "0x1805B4030")]
	public static bool IsHoldingTeam()
	{
		return default(bool);
	}

	[Token(Token = "0x6001747")]
	[Address(RVA = "0x5A6240", Offset = "0x5A5440", VA = "0x1805A6240")]
	public static Dictionary<string, object> GetDuelMenuTeamMatchPreTeamInfo()
	{
		return null;
	}

	[Token(Token = "0x6001748")]
	[Address(RVA = "0x5A5F00", Offset = "0x5A5100", VA = "0x1805A5F00")]
	public static Dictionary<string, object> GetDuelMenuRankEventHolding(int rank_event_id)
	{
		return null;
	}

	[Token(Token = "0x6001749")]
	[Address(RVA = "0x5B3C00", Offset = "0x5B2E00", VA = "0x1805B3C00")]
	public static bool IsHoldingRankEvent(int rank_event_id)
	{
		return default(bool);
	}

	[Token(Token = "0x600174A")]
	[Address(RVA = "0x5A58C0", Offset = "0x5A4AC0", VA = "0x1805A58C0")]
	public static Dictionary<string, object> GetDuelMenuFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
	{
		return null;
	}

	[Token(Token = "0x600174B")]
	[Address(RVA = "0x5A5CF0", Offset = "0x5A4EF0", VA = "0x1805A5CF0")]
	public static Dictionary<string, object> GetDuelMenuHoldingFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
	{
		return null;
	}

	[Token(Token = "0x600174C")]
	[Address(RVA = "0x5B31F0", Offset = "0x5B23F0", VA = "0x1805B31F0")]
	public static bool IsHoldingFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
	{
		return default(bool);
	}

	[Token(Token = "0x600174D")]
	[Address(RVA = "0x5B29C0", Offset = "0x5B1BC0", VA = "0x1805B29C0")]
	private static bool IsHoldingCup(ColosseumUtil.PlayMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x600174E")]
	[Address(RVA = "0x5A7140", Offset = "0x5A6340", VA = "0x1805A7140")]
	public static Dictionary<string, object> GetFirstDlvFromPlayMode(ColosseumUtil.PlayMode mode)
	{
		return null;
	}

	[Token(Token = "0x600174F")]
	[Address(RVA = "0x5A6EE0", Offset = "0x5A60E0", VA = "0x1805A6EE0")]
	public static Dictionary<string, object> GetFinalFromPlayMode(ColosseumUtil.PlayMode mode)
	{
		return null;
	}

	[Token(Token = "0x6001750")]
	[Address(RVA = "0x5A7010", Offset = "0x5A6210", VA = "0x1805A7010")]
	public static Dictionary<string, object> GetFinalInfoFromPlayMode(ColosseumUtil.PlayMode mode)
	{
		return null;
	}

	[Token(Token = "0x6001751")]
	[Address(RVA = "0x5AD180", Offset = "0x5AC380", VA = "0x1805AD180")]
	public static bool GetRankingExistFromPlayMode(ColosseumUtil.PlayMode mode)
	{
		return default(bool);
	}

	[Token(Token = "0x6001752")]
	[Address(RVA = "0x5A5520", Offset = "0x5A4720", VA = "0x1805A5520")]
	public static Dictionary<string, object> GetDuelMenuDuelTrialHolding(int tid)
	{
		return null;
	}

	[Token(Token = "0x6001753")]
	[Address(RVA = "0x5B2D20", Offset = "0x5B1F20", VA = "0x1805B2D20")]
	public static bool IsHoldingDuelTrial(int tid)
	{
		return default(bool);
	}

	[Token(Token = "0x6001754")]
	[Address(RVA = "0x5A4C50", Offset = "0x5A3E50", VA = "0x1805A4C50")]
	public static int GetDuelBGM()
	{
		return default(int);
	}

	[Token(Token = "0x6001755")]
	[Address(RVA = "0x5AA1A0", Offset = "0x5A93A0", VA = "0x1805AA1A0")]
	public static Dictionary<string, object> GetMasterTournament()
	{
		return null;
	}

	[Token(Token = "0x6001756")]
	[Address(RVA = "0x5A9810", Offset = "0x5A8A10", VA = "0x1805A9810")]
	public static Dictionary<string, object> GetMasterFromPlayMode(ColosseumUtil.PlayMode mode, int eventId = 0)
	{
		return null;
	}

	[Token(Token = "0x6001757")]
	[Address(RVA = "0x5B0560", Offset = "0x5AF760", VA = "0x1805B0560")]
	public static string GetTournamentNameTextID(int id)
	{
		return null;
	}

	[Token(Token = "0x6001758")]
	[Address(RVA = "0x5A5390", Offset = "0x5A4590", VA = "0x1805A5390")]
	public static int GetDuelHistoryRegulationId(int mode, int identifier = 0, int idx = 0, bool isOwn = false)
	{
		return default(int);
	}

	[Token(Token = "0x6001759")]
	[Address(RVA = "0x5A4CB0", Offset = "0x5A3EB0", VA = "0x1805A4CB0")]
	public static int GetDuelHistoryRegulationId(Util.GameMode mode, int identifier = 0, int idx = 0, bool isOwn = false)
	{
		return default(int);
	}

	[Token(Token = "0x600175A")]
	[Address(RVA = "0x5B08C0", Offset = "0x5AFAC0", VA = "0x1805B08C0")]
	public static int GetTournamentRegulationID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600175B")]
	[Address(RVA = "0x5A3ED0", Offset = "0x5A30D0", VA = "0x1805A3ED0")]
	public static int GetCupRegulationID()
	{
		return default(int);
	}

	[Token(Token = "0x600175C")]
	[Address(RVA = "0x5B1C70", Offset = "0x5B0E70", VA = "0x1805B1C70")]
	public static int GetWcsRegulationID()
	{
		return default(int);
	}

	[Token(Token = "0x600175D")]
	[Address(RVA = "0x5ACDA0", Offset = "0x5ABFA0", VA = "0x1805ACDA0")]
	public static int GetRankEventRegulationID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600175E")]
	[Address(RVA = "0x5A65D0", Offset = "0x5A57D0", VA = "0x1805A65D0")]
	public static int GetDuelTrialRegulationID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600175F")]
	[Address(RVA = "0x5B14A0", Offset = "0x5B06A0", VA = "0x1805B14A0")]
	public static int GetVersusGroupID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6001760")]
	[Address(RVA = "0x5B18B0", Offset = "0x5B0AB0", VA = "0x1805B18B0")]
	public static int GetVersusRegulationID(int id, int groupId)
	{
		return default(int);
	}

	[Token(Token = "0x6001761")]
	[Address(RVA = "0x5AD540", Offset = "0x5AC740", VA = "0x1805AD540")]
	public static int GetRdcRegulationID()
	{
		return default(int);
	}

	[Token(Token = "0x6001762")]
	[Address(RVA = "0x5A9FB0", Offset = "0x5A91B0", VA = "0x1805A9FB0")]
	public static int GetMasterTournamentGroupNum(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6001763")]
	[Address(RVA = "0x5A6DC0", Offset = "0x5A5FC0", VA = "0x1805A6DC0")]
	public static string GetExhibtionNameTextID(int id)
	{
		return null;
	}

	[Token(Token = "0x6001764")]
	[Address(RVA = "0x5A6C60", Offset = "0x5A5E60", VA = "0x1805A6C60")]
	public static int GetExhibitionRegulationID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6001765")]
	[Address(RVA = "0x5A40F0", Offset = "0x5A32F0", VA = "0x1805A40F0")]
	public static int GetDiceRallyRegulationID(int id)
	{
		return default(int);
	}

	[Token(Token = "0x6001766")]
	[Address(RVA = "0x5A56C0", Offset = "0x5A48C0", VA = "0x1805A56C0")]
	public static Dictionary<string, object> GetDuelMenuExhibitionRentalDeckInfo(int exhid)
	{
		return null;
	}

	[Token(Token = "0x6001767")]
	[Address(RVA = "0x5A5790", Offset = "0x5A4990", VA = "0x1805A5790")]
	public static int GetDuelMenuExhibitionRentalState(int exhid, int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6001768")]
	[Address(RVA = "0x5B04C0", Offset = "0x5AF6C0", VA = "0x1805B04C0")]
	public static Dictionary<string, object> GetTournamentInfo()
	{
		return null;
	}

	[Token(Token = "0x6001769")]
	[Address(RVA = "0x5B0400", Offset = "0x5AF600", VA = "0x1805B0400")]
	public static Dictionary<string, object> GetTournamentInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x600176A")]
	[Address(RVA = "0x5B0950", Offset = "0x5AFB50", VA = "0x1805B0950")]
	public static Dictionary<string, object> GetTournamentResult()
	{
		return null;
	}

	[Token(Token = "0x600176B")]
	[Address(RVA = "0x5AA110", Offset = "0x5A9310", VA = "0x1805AA110")]
	public static int GetMasterTournamentStatus(int id)
	{
		return default(int);
	}

	[Token(Token = "0x600176C")]
	[Address(RVA = "0x5B0680", Offset = "0x5AF880", VA = "0x1805B0680")]
	public static List<object> GetTournamentRankingMembers(int id)
	{
		return null;
	}

	[Token(Token = "0x600176D")]
	[Address(RVA = "0x5B0750", Offset = "0x5AF950", VA = "0x1805B0750")]
	public static Dictionary<string, object> GetTournamentRankingMyself(int id)
	{
		return null;
	}

	[Token(Token = "0x600176E")]
	[Address(RVA = "0x5B0820", Offset = "0x5AFA20", VA = "0x1805B0820")]
	public static Dictionary<string, object> GetTournamentRecvResult()
	{
		return null;
	}

	[Token(Token = "0x600176F")]
	[Address(RVA = "0x5AA040", Offset = "0x5A9240", VA = "0x1805AA040")]
	public static List<object> GetMasterTournamentRewardInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x6001770")]
	[Address(RVA = "0x5A9740", Offset = "0x5A8940", VA = "0x1805A9740")]
	public static Dictionary<string, object> GetMasterDuelTrialRewards(int duel_trial_id)
	{
		return null;
	}

	[Token(Token = "0x6001771")]
	[Address(RVA = "0x5A6CF0", Offset = "0x5A5EF0", VA = "0x1805A6CF0")]
	public static Dictionary<string, object> GetExhibitionRewardInfo(int id)
	{
		return null;
	}

	[Token(Token = "0x6001772")]
	[Address(RVA = "0x5A3A40", Offset = "0x5A2C40", VA = "0x1805A3A40")]
	public static Dictionary<string, object> GetChallengeInfo(int mode = 1)
	{
		return null;
	}

	[Token(Token = "0x6001773")]
	[Address(RVA = "0x5A3970", Offset = "0x5A2B70", VA = "0x1805A3970")]
	public static List<object> GetChallengeInfoRankInfoHistory(int mode = 1)
	{
		return null;
	}

	[Token(Token = "0x6001774")]
	[Address(RVA = "0x5A3B10", Offset = "0x5A2D10", VA = "0x1805A3B10")]
	public static List<object> GetChallengeRankingMembers(int mode = 1)
	{
		return null;
	}

	[Token(Token = "0x6001775")]
	[Address(RVA = "0x5A3BE0", Offset = "0x5A2DE0", VA = "0x1805A3BE0")]
	public static Dictionary<string, object> GetChallengeRankingMyself(int mode = 1)
	{
		return null;
	}

	[Token(Token = "0x6001776")]
	[Address(RVA = "0x5A3CB0", Offset = "0x5A2EB0", VA = "0x1805A3CB0")]
	public static int GetChallengeSelectDeck(int mode = 1)
	{
		return default(int);
	}

	[Token(Token = "0x6001777")]
	[Address(RVA = "0x5A9680", Offset = "0x5A8880", VA = "0x1805A9680")]
	public static Dictionary<string, object> GetMasterChallenge(int mode = 1)
	{
		return null;
	}

	[Token(Token = "0x6001778")]
	[Address(RVA = "0x5AFE90", Offset = "0x5AF090", VA = "0x1805AFE90")]
	public static Dictionary<string, object> GetTDeckList(int tid)
	{
		return null;
	}

	[Token(Token = "0x6001779")]
	[Address(RVA = "0x5A26D0", Offset = "0x5A18D0", VA = "0x1805A26D0")]
	public static bool ExistsMaindeck()
	{
		return default(bool);
	}

	[Token(Token = "0x600177A")]
	[Address(RVA = "0x5A91C0", Offset = "0x5A83C0", VA = "0x1805A91C0")]
	public static int GetMaindeckId()
	{
		return default(int);
	}

	[Token(Token = "0x600177B")]
	[Address(RVA = "0x5AD2B0", Offset = "0x5AC4B0", VA = "0x1805AD2B0")]
	public static int GetRateDeckId()
	{
		return default(int);
	}

	[Token(Token = "0x600177C")]
	[Address(RVA = "0x5A67D0", Offset = "0x5A59D0", VA = "0x1805A67D0")]
	public static Dictionary<string, object> GetEXHDeckList(int exhid)
	{
		return null;
	}

	[Token(Token = "0x600177D")]
	[Address(RVA = "0x5ACE30", Offset = "0x5AC030", VA = "0x1805ACE30")]
	public static Dictionary<string, object> GetRankEvent(int rank_event_id = 1)
	{
		return null;
	}

	[Token(Token = "0x600177E")]
	[Address(RVA = "0x5ACBB0", Offset = "0x5ABDB0", VA = "0x1805ACBB0")]
	public static Dictionary<string, object> GetRankEventInfo(int rank_event_id = 1)
	{
		return null;
	}

	[Token(Token = "0x600177F")]
	[Address(RVA = "0x5ACA90", Offset = "0x5ABC90", VA = "0x1805ACA90")]
	public static int GetRankEventInfoRankInfoNowRank(int rank_event_id, int defaultValue = 1)
	{
		return default(int);
	}

	[Token(Token = "0x6001780")]
	[Address(RVA = "0x5ACB20", Offset = "0x5ABD20", VA = "0x1805ACB20")]
	public static int GetRankEventInfoRankInfoNowTier(int rank_event_id, int defaultValue = 1)
	{
		return default(int);
	}

	[Token(Token = "0x6001781")]
	[Address(RVA = "0x5A3DE0", Offset = "0x5A2FE0", VA = "0x1805A3DE0")]
	public static string GetCupNameTextID()
	{
		return null;
	}

	[Token(Token = "0x6001782")]
	[Address(RVA = "0x5B1B80", Offset = "0x5B0D80", VA = "0x1805B1B80")]
	public static string GetWcsNameTextID()
	{
		return null;
	}

	[Token(Token = "0x6001783")]
	[Address(RVA = "0x5ACC80", Offset = "0x5ABE80", VA = "0x1805ACC80")]
	public static string GetRankEventNameTextID(int id)
	{
		return null;
	}

	[Token(Token = "0x6001784")]
	[Address(RVA = "0x5A64B0", Offset = "0x5A56B0", VA = "0x1805A64B0")]
	public static string GetDuelTrialNameTextID(int id)
	{
		return null;
	}

	[Token(Token = "0x6001785")]
	[Address(RVA = "0x5B1740", Offset = "0x5B0940", VA = "0x1805B1740")]
	public static string GetVersusNameTextID(int id, int index)
	{
		return null;
	}

	[Token(Token = "0x6001786")]
	[Address(RVA = "0x5AD450", Offset = "0x5AC650", VA = "0x1805AD450")]
	public static string GetRdcNameTextID()
	{
		return null;
	}

	[Token(Token = "0x6001787")]
	[Address(RVA = "0x5A4180", Offset = "0x5A3380", VA = "0x1805A4180")]
	public static string GetDicerallyNameTextID(int id)
	{
		return null;
	}

	[Token(Token = "0x6001788")]
	[Address(RVA = "0x5A6660", Offset = "0x5A5860", VA = "0x1805A6660")]
	public static Dictionary<string, object> GetDuelTrial(int duel_trial_id = 1)
	{
		return null;
	}

	[Token(Token = "0x6001789")]
	[Address(RVA = "0x5B1AB0", Offset = "0x5B0CB0", VA = "0x1805B1AB0")]
	public static Dictionary<string, object> GetVersus(int versus_id = 1)
	{
		return null;
	}

	[Token(Token = "0x600178A")]
	[Address(RVA = "0x5B1680", Offset = "0x5B0880", VA = "0x1805B1680")]
	public static long GetVersusGroupTotalPoint(int versus_id, int group_id, long defaultValue = 0L)
	{
		return default(long);
	}

	[Token(Token = "0x600178B")]
	[Address(RVA = "0x5B15C0", Offset = "0x5B07C0", VA = "0x1805B15C0")]
	public static long GetVersusGroupTotalPercent(int versus_id, int group_id, long defaultValue = 0L)
	{
		return default(long);
	}

	[Token(Token = "0x600178C")]
	[Address(RVA = "0x5B1A10", Offset = "0x5B0C10", VA = "0x1805B1A10")]
	public static string GetVersusTotalPointTime(int versus_id)
	{
		return null;
	}

	[Token(Token = "0x600178D")]
	[Address(RVA = "0x5B1530", Offset = "0x5B0730", VA = "0x1805B1530")]
	public static int GetVersusGroupNum(int id, int defaultValue = 2)
	{
		return default(int);
	}

	[Token(Token = "0x600178E")]
	[Address(RVA = "0x5A6380", Offset = "0x5A5580", VA = "0x1805A6380")]
	public static Dictionary<string, object> GetDuelShortCut()
	{
		return null;
	}

	[Token(Token = "0x600178F")]
	[Address(RVA = "0x5A3490", Offset = "0x5A2690", VA = "0x1805A3490")]
	public static Dictionary<string, object> GetBonusCondition(ColosseumUtil.PlayMode mode, int drid)
	{
		return null;
	}

	[Token(Token = "0x6001790")]
	[Address(RVA = "0x5ADFF0", Offset = "0x5AD1F0", VA = "0x1805ADFF0")]
	public static Dictionary<string, object> GetRoom()
	{
		return null;
	}

	[Token(Token = "0x6001791")]
	[Address(RVA = "0x5ADD70", Offset = "0x5ACF70", VA = "0x1805ADD70")]
	public static Dictionary<string, object> GetRoomInfo()
	{
		return null;
	}

	[Token(Token = "0x6001792")]
	[Address(RVA = "0x5ADEB0", Offset = "0x5AD0B0", VA = "0x1805ADEB0")]
	public static string GetRoomName(long pcode)
	{
		return null;
	}

	[Token(Token = "0x6001793")]
	[Address(RVA = "0x5AD950", Offset = "0x5ACB50", VA = "0x1805AD950")]
	public static bool GetRoomInfoIsJoinPlayer(bool defaultValue = true)
	{
		return default(bool);
	}

	[Token(Token = "0x6001794")]
	[Address(RVA = "0x5ADCD0", Offset = "0x5ACED0", VA = "0x1805ADCD0")]
	public static List<object> GetRoomInfoTable()
	{
		return null;
	}

	[Token(Token = "0x6001795")]
	[Address(RVA = "0x5AD810", Offset = "0x5ACA10", VA = "0x1805AD810")]
	public static Dictionary<string, object> GetRoomInfoBattleSetting()
	{
		return null;
	}

	[Token(Token = "0x6001796")]
	[Address(RVA = "0x5ADC30", Offset = "0x5ACE30", VA = "0x1805ADC30")]
	public static Dictionary<string, object> GetRoomInfoRoomMembers()
	{
		return null;
	}

	[Token(Token = "0x6001797")]
	[Address(RVA = "0x5ADB60", Offset = "0x5ACD60", VA = "0x1805ADB60")]
	public static Dictionary<string, object> GetRoomInfoRoomMember(long pcode)
	{
		return null;
	}

	[Token(Token = "0x6001798")]
	[Address(RVA = "0x5ADA00", Offset = "0x5ACC00", VA = "0x1805ADA00")]
	public static Dictionary<string, object> GetRoomInfoLeaveRoomMember(long pcode)
	{
		return null;
	}

	[Token(Token = "0x6001799")]
	[Address(RVA = "0x5ADAD0", Offset = "0x5ACCD0", VA = "0x1805ADAD0")]
	public static int GetRoomInfoNewComment(long pcode)
	{
		return default(int);
	}

	[Token(Token = "0x600179A")]
	[Address(RVA = "0x5AD8B0", Offset = "0x5ACAB0", VA = "0x1805AD8B0")]
	public static Dictionary<string, object> GetRoomInfoInvitedList()
	{
		return null;
	}

	[Token(Token = "0x600179B")]
	[Address(RVA = "0x5ADE10", Offset = "0x5AD010", VA = "0x1805ADE10")]
	public static List<object> GetRoomList()
	{
		return null;
	}

	[Token(Token = "0x600179C")]
	[Address(RVA = "0x5ADF50", Offset = "0x5AD150", VA = "0x1805ADF50")]
	public static Dictionary<string, object> GetRoomRuleList()
	{
		return null;
	}

	[Token(Token = "0x600179D")]
	[Address(RVA = "0x5AD6D0", Offset = "0x5AC8D0", VA = "0x1805AD6D0")]
	public static Dictionary<string, object> GetRoomHoldingRuleList()
	{
		return null;
	}

	[Token(Token = "0x600179E")]
	[Address(RVA = "0x5AD770", Offset = "0x5AC970", VA = "0x1805AD770")]
	public static List<object> GetRoomInfoBattleResultList()
	{
		return null;
	}

	[Token(Token = "0x600179F")]
	[Address(RVA = "0x5ABB30", Offset = "0x5AAD30", VA = "0x1805ABB30")]
	public static int GetPlatformRoomInviteId()
	{
		return default(int);
	}

	[Token(Token = "0x60017A0")]
	[Address(RVA = "0x5ABB90", Offset = "0x5AAD90", VA = "0x1805ABB90")]
	public static int GetPlatformTeamInviteId()
	{
		return default(int);
	}

	[Token(Token = "0x60017A1")]
	[Address(RVA = "0x5A9CD0", Offset = "0x5A8ED0", VA = "0x1805A9CD0")]
	public static Dictionary<string, object> GetMasterSoloGate()
	{
		return null;
	}

	[Token(Token = "0x60017A2")]
	[Address(RVA = "0x5A9C10", Offset = "0x5A8E10", VA = "0x1805A9C10")]
	public static Dictionary<string, object> GetMasterSoloChapter(int gateID)
	{
		return null;
	}

	[Token(Token = "0x60017A3")]
	[Address(RVA = "0x5A9EF0", Offset = "0x5A90F0", VA = "0x1805A9EF0")]
	public static Dictionary<string, object> GetMasterSoloUnlock(int unlockID)
	{
		return null;
	}

	[Token(Token = "0x60017A4")]
	[Address(RVA = "0x5A9E30", Offset = "0x5A9030", VA = "0x1805A9E30")]
	public static Dictionary<string, object> GetMasterSoloUnlockItem(int setID)
	{
		return null;
	}

	[Token(Token = "0x60017A5")]
	[Address(RVA = "0x5A9D70", Offset = "0x5A8F70", VA = "0x1805A9D70")]
	public static Dictionary<string, object> GetMasterSoloReward(int setID)
	{
		return null;
	}

	[Token(Token = "0x60017A6")]
	[Address(RVA = "0x5AF940", Offset = "0x5AEB40", VA = "0x1805AF940")]
	public static int GetSoloGateClearChapter(int gateID)
	{
		return default(int);
	}

	[Token(Token = "0x60017A7")]
	[Address(RVA = "0x5B1E80", Offset = "0x5B1080", VA = "0x1805B1E80")]
	public static bool IsAnimeChapter(int gateId, int chapterId)
	{
		return default(bool);
	}

	[Token(Token = "0x60017A8")]
	[Address(RVA = "0x5AF220", Offset = "0x5AE420", VA = "0x1805AF220")]
	public static Dictionary<string, object> GetSoloChapter(int chapterID)
	{
		return null;
	}

	[Token(Token = "0x60017A9")]
	[Address(RVA = "0x5B26C0", Offset = "0x5B18C0", VA = "0x1805B26C0")]
	public static bool IsExistsSoloChapterDetail(int chapterID)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AA")]
	[Address(RVA = "0x5AF7D0", Offset = "0x5AE9D0", VA = "0x1805AF7D0")]
	public static bool GetSoloClearedGate(int gateID)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AB")]
	[Address(RVA = "0x5AF9D0", Offset = "0x5AEBD0", VA = "0x1805AF9D0")]
	public static long GetSoloLastPlayDate(int gateId)
	{
		return default(long);
	}

	[Token(Token = "0x60017AC")]
	[Address(RVA = "0x5AF6C0", Offset = "0x5AE8C0", VA = "0x1805AF6C0")]
	public static bool GetSoloClearedChapter(int chapterID)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AD")]
	[Address(RVA = "0x5AF560", Offset = "0x5AE760", VA = "0x1805AF560")]
	public static bool GetSoloClearedChapter(int chapterID, out int status)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AE")]
	[Address(RVA = "0x5AF3A0", Offset = "0x5AE5A0", VA = "0x1805AF3A0")]
	public static bool GetSoloClearedChapter(int chapterID, bool isRental)
	{
		return default(bool);
	}

	[Token(Token = "0x60017AF")]
	[Address(RVA = "0x5B1FF0", Offset = "0x5B11F0", VA = "0x1805B1FF0")]
	public static bool IsClearedTutorialChapter()
	{
		return default(bool);
	}

	[Token(Token = "0x60017B0")]
	[Address(RVA = "0x5AF2E0", Offset = "0x5AE4E0", VA = "0x1805AF2E0")]
	public static Dictionary<string, object> GetSoloClearedChapterDic(int gateID)
	{
		return null;
	}

	[Token(Token = "0x60017B1")]
	[Address(RVA = "0x5AFCC0", Offset = "0x5AEEC0", VA = "0x1805AFCC0")]
	public static List<object> GetSoloResultRewards()
	{
		return null;
	}

	[Token(Token = "0x60017B2")]
	[Address(RVA = "0x5AFB00", Offset = "0x5AED00", VA = "0x1805AFB00")]
	public static Dictionary<string, object> GetSoloResultGateClear()
	{
		return null;
	}

	[Token(Token = "0x60017B3")]
	[Address(RVA = "0x5AFBA0", Offset = "0x5AEDA0", VA = "0x1805AFBA0")]
	public static bool GetSoloResultIsPresentSend()
	{
		return default(bool);
	}

	[Token(Token = "0x60017B4")]
	[Address(RVA = "0x5AF8A0", Offset = "0x5AEAA0", VA = "0x1805AF8A0")]
	public static Dictionary<string, object> GetSoloDeckInfo()
	{
		return null;
	}

	[Token(Token = "0x60017B5")]
	[Address(RVA = "0x5AFA60", Offset = "0x5AEC60", VA = "0x1805AFA60")]
	public static Dictionary<string, object> GetSoloNotify()
	{
		return null;
	}

	[Token(Token = "0x60017B6")]
	[Address(RVA = "0x5AF180", Offset = "0x5AE380", VA = "0x1805AF180")]
	public static string GetSoloChapterMovieDataSize(int chapterId)
	{
		return null;
	}

	[Token(Token = "0x60017B7")]
	[Address(RVA = "0x5AA320", Offset = "0x5A9520", VA = "0x1805AA320")]
	public static Dictionary<string, object> GetMissionAllMasters()
	{
		return null;
	}

	[Token(Token = "0x60017B8")]
	[Address(RVA = "0x5A2260", Offset = "0x5A1460", VA = "0x1805A2260")]
	public static bool ContainsCampaignPoolMaster(int poolId)
	{
		return default(bool);
	}

	[Token(Token = "0x60017B9")]
	[Address(RVA = "0x5AA240", Offset = "0x5A9440", VA = "0x1805AA240")]
	public static Dictionary<string, object> GetMissionAllDatas()
	{
		return null;
	}

	[Token(Token = "0x60017BA")]
	[Address(RVA = "0x5B4340", Offset = "0x5B3540", VA = "0x1805B4340")]
	public static bool IsNewMission(int poolId, int missionId)
	{
		return default(bool);
	}

	[Token(Token = "0x60017BB")]
	[Address(RVA = "0x5AA400", Offset = "0x5A9600", VA = "0x1805AA400")]
	public static Dictionary<string, object> GetMissionData(int poolId, int missionId)
	{
		return null;
	}

	[Token(Token = "0x60017BC")]
	[Address(RVA = "0x5AA630", Offset = "0x5A9830", VA = "0x1805AA630")]
	public static Dictionary<string, object> GetMissionRecievedRewardData()
	{
		return null;
	}

	[Token(Token = "0x60017BD")]
	[Address(RVA = "0x5AA4F0", Offset = "0x5A96F0", VA = "0x1805AA4F0")]
	public static Dictionary<string, object> GetMissionRecieveCompletes()
	{
		return null;
	}

	[Token(Token = "0x60017BE")]
	[Address(RVA = "0x5AA590", Offset = "0x5A9790", VA = "0x1805AA590")]
	public static Dictionary<string, object> GetMissionRecieveHides()
	{
		return null;
	}

	[Token(Token = "0x60017BF")]
	[Address(RVA = "0x5B3B30", Offset = "0x5B2D30", VA = "0x1805B3B30")]
	public static bool IsHoldingPanelMission()
	{
		return default(bool);
	}

	[Token(Token = "0x60017C0")]
	[Address(RVA = "0x5AA6D0", Offset = "0x5A98D0", VA = "0x1805AA6D0")]
	public static int GetMissionRecommendMissionId(int defaultValue = 0)
	{
		return default(int);
	}

	[Token(Token = "0x60017C1")]
	[Address(RVA = "0x5A2900", Offset = "0x5A1B00", VA = "0x1805A2900")]
	public static bool ExistsPanelMission(int poolId)
	{
		return default(bool);
	}

	[Token(Token = "0x60017C2")]
	[Address(RVA = "0x5AB4C0", Offset = "0x5AA6C0", VA = "0x1805AB4C0")]
	public static Dictionary<string, object> GetPanelMissionAllMasters()
	{
		return null;
	}

	[Token(Token = "0x60017C3")]
	[Address(RVA = "0x5AB750", Offset = "0x5AA950", VA = "0x1805AB750")]
	public static Dictionary<string, object> GetPanelMissionMaster(int poolId)
	{
		return null;
	}

	[Token(Token = "0x60017C4")]
	[Address(RVA = "0x5AB6B0", Offset = "0x5AA8B0", VA = "0x1805AB6B0")]
	public static string GetPanelMissionMapPath(int poolId)
	{
		return null;
	}

	[Token(Token = "0x60017C5")]
	[Address(RVA = "0x5AB5A0", Offset = "0x5AA7A0", VA = "0x1805AB5A0")]
	public static Dictionary<string, object> GetPanelMissionDatas(int poolId)
	{
		return null;
	}

	[Token(Token = "0x60017C6")]
	[Address(RVA = "0x5AB860", Offset = "0x5AAA60", VA = "0x1805AB860")]
	public static Dictionary<string, object> GetPanelMissionRecievedRewardData()
	{
		return null;
	}

	[Token(Token = "0x60017C7")]
	[Address(RVA = "0x5ABBF0", Offset = "0x5AADF0", VA = "0x1805ABBF0")]
	public static Dictionary<string, object> GetPresentBoxHave()
	{
		return null;
	}

	[Token(Token = "0x60017C8")]
	[Address(RVA = "0x5ABC90", Offset = "0x5AAE90", VA = "0x1805ABC90")]
	public static Dictionary<string, object> GetPresentBoxRecieveResult()
	{
		return null;
	}

	[Token(Token = "0x60017C9")]
	[Address(RVA = "0x5A6730", Offset = "0x5A5930", VA = "0x1805A6730")]
	public static Dictionary<string, object> GetDuel()
	{
		return null;
	}

	[Token(Token = "0x60017CA")]
	[Address(RVA = "0x5A62E0", Offset = "0x5A54E0", VA = "0x1805A62E0")]
	public static Dictionary<string, object> GetDuelResult()
	{
		return null;
	}

	[Token(Token = "0x60017CB")]
	[Address(RVA = "0x5A6420", Offset = "0x5A5620", VA = "0x1805A6420")]
	public static object GetDuelTeam(int myid)
	{
		return null;
	}

	[Token(Token = "0x60017CC")]
	[Address(RVA = "0x5A2D00", Offset = "0x5A1F00", VA = "0x1805A2D00")]
	public static bool GetAccessoryOverwriteId(ItemUtil.Category category, int id, out int overwriteId)
	{
		return default(bool);
	}

	[Token(Token = "0x60017CD")]
	[Address(RVA = "0x5B0260", Offset = "0x5AF460", VA = "0x1805B0260")]
	public static Dictionary<string, object> GetTeamRegulationSetList()
	{
		return null;
	}

	[Token(Token = "0x60017CE")]
	[Address(RVA = "0x5B00C0", Offset = "0x5AF2C0", VA = "0x1805B00C0")]
	public static Dictionary<string, object> GetTeamInfo()
	{
		return null;
	}

	[Token(Token = "0x60017CF")]
	[Address(RVA = "0x5AFFC0", Offset = "0x5AF1C0", VA = "0x1805AFFC0")]
	public static int GetTeamDeckId()
	{
		return default(int);
	}

	[Token(Token = "0x60017D0")]
	[Address(RVA = "0x5B0020", Offset = "0x5AF220", VA = "0x1805B0020")]
	public static Dictionary<string, object> GetTeamDeckInfo()
	{
		return null;
	}

	[Token(Token = "0x60017D1")]
	[Address(RVA = "0x5B0160", Offset = "0x5AF360", VA = "0x1805B0160")]
	public static Dictionary<string, object> GetTeamInvitedList()
	{
		return null;
	}

	[Token(Token = "0x60017D2")]
	[Address(RVA = "0x5B0200", Offset = "0x5AF400", VA = "0x1805B0200")]
	public static int GetTeamNameCardID()
	{
		return default(int);
	}

	[Token(Token = "0x60017D3")]
	[Address(RVA = "0x5B24C0", Offset = "0x5B16C0", VA = "0x1805B24C0")]
	public static bool IsExistAnnounce()
	{
		return default(bool);
	}

	[Token(Token = "0x60017D4")]
	[Address(RVA = "0x5A8B00", Offset = "0x5A7D00", VA = "0x1805A8B00")]
	public static List<object> GetHotNews()
	{
		return null;
	}

	[Token(Token = "0x60017D5")]
	[Address(RVA = "0x5AAFF0", Offset = "0x5AA1F0", VA = "0x1805AAFF0")]
	public static Dictionary<string, object> GetNotification()
	{
		return null;
	}

	[Token(Token = "0x60017D6")]
	[Address(RVA = "0x5AAF50", Offset = "0x5AA150", VA = "0x1805AAF50")]
	public static Dictionary<string, object> GetNotificationNotification()
	{
		return null;
	}

	[Token(Token = "0x60017D7")]
	[Address(RVA = "0x5AAEB0", Offset = "0x5AA0B0", VA = "0x1805AAEB0")]
	public static Dictionary<string, object> GetNotificationMaintenance()
	{
		return null;
	}

	[Token(Token = "0x60017D8")]
	[Address(RVA = "0x5AABC0", Offset = "0x5A9DC0", VA = "0x1805AABC0")]
	public static Dictionary<string, object> GetNotificationBug()
	{
		return null;
	}

	[Token(Token = "0x60017D9")]
	[Address(RVA = "0x5AAC60", Offset = "0x5A9E60", VA = "0x1805AAC60")]
	internal static (NotificationViewController.Type, Dictionary<string, object>) GetNotificationByID(int id)
	{
		return default((NotificationViewController.Type, Dictionary<string, object>));
	}

	[Token(Token = "0x60017DA")]
	[Address(RVA = "0x5B0360", Offset = "0x5AF560", VA = "0x1805B0360")]
	public static List<object> GetTopics()
	{
		return null;
	}

	[Token(Token = "0x60017DB")]
	[Address(RVA = "0x5A6930", Offset = "0x5A5B30", VA = "0x1805A6930")]
	public static List<object> GetEventNotifyNotify()
	{
		return null;
	}

	[Token(Token = "0x60017DC")]
	[Address(RVA = "0x5A6890", Offset = "0x5A5A90", VA = "0x1805A6890")]
	public static Dictionary<string, object> GetEventNotifyBadge()
	{
		return null;
	}

	[Token(Token = "0x60017DD")]
	[Address(RVA = "0x5A9120", Offset = "0x5A8320", VA = "0x1805A9120")]
	public static List<object> GetLoginBonus()
	{
		return null;
	}

	[Token(Token = "0x60017DE")]
	[Address(RVA = "0x5B4430", Offset = "0x5B3630", VA = "0x1805B4430")]
	public static bool IsOpenLoginBonus()
	{
		return default(bool);
	}

	[Token(Token = "0x60017DF")]
	[Address(RVA = "0x5AC770", Offset = "0x5AB970", VA = "0x1805AC770")]
	public static Dictionary<string, object> GetPromoCodesAllData()
	{
		return null;
	}

	[Token(Token = "0x60017E0")]
	[Address(RVA = "0x5AC810", Offset = "0x5ABA10", VA = "0x1805AC810")]
	public static Dictionary<string, object> GetPromoCodesData(int promoCodeId)
	{
		return null;
	}

	[Token(Token = "0x60017E1")]
	[Address(RVA = "0x5AC8E0", Offset = "0x5ABAE0", VA = "0x1805AC8E0")]
	public static Dictionary<string, object> GetPromoCodesResult()
	{
		return null;
	}

	[Token(Token = "0x60017E2")]
	[Address(RVA = "0x5A3F90", Offset = "0x5A3190", VA = "0x1805A3F90")]
	public static Dictionary<string, object> GetCurrentInvitation()
	{
		return null;
	}

	[Token(Token = "0x60017E3")]
	[Address(RVA = "0x5A2610", Offset = "0x5A1810", VA = "0x1805A2610")]
	public static bool ExistsInvitationId(int invitationId)
	{
		return default(bool);
	}

	[Token(Token = "0x60017E4")]
	[Address(RVA = "0x5A8C40", Offset = "0x5A7E40", VA = "0x1805A8C40")]
	public static Dictionary<string, object> GetInvitationAllData()
	{
		return null;
	}

	[Token(Token = "0x60017E5")]
	[Address(RVA = "0x5A8D80", Offset = "0x5A7F80", VA = "0x1805A8D80")]
	public static Dictionary<string, object> GetInvitationOnHomeData(int invitationId)
	{
		return null;
	}

	[Token(Token = "0x60017E6")]
	[Address(RVA = "0x5A8CE0", Offset = "0x5A7EE0", VA = "0x1805A8CE0")]
	public static Dictionary<string, object> GetInvitationDetail()
	{
		return null;
	}

	[Token(Token = "0x60017E7")]
	[Address(RVA = "0x5A8E50", Offset = "0x5A8050", VA = "0x1805A8E50")]
	public static Dictionary<string, object> GetInvitationResult()
	{
		return null;
	}

	[Token(Token = "0x60017E8")]
	[Address(RVA = "0x5AB090", Offset = "0x5AA290", VA = "0x1805AB090")]
	public static IReadOnlyDictionary<string, object> GetOperationDialog()
	{
		return null;
	}

	[Token(Token = "0x60017E9")]
	[Address(RVA = "0x5A7A40", Offset = "0x5A6C40", VA = "0x1805A7A40")]
	public static int GetFriendPollingSpan()
	{
		return default(int);
	}

	[Token(Token = "0x60017EA")]
	[Address(RVA = "0x5A7B90", Offset = "0x5A6D90", VA = "0x1805A7B90")]
	public static IReadOnlyDictionary<string, object> GetFriendRefreshDic()
	{
		return null;
	}

	[Token(Token = "0x60017EB")]
	[Address(RVA = "0x5A7D10", Offset = "0x5A6F10", VA = "0x1805A7D10")]
	public static IReadOnlyList<object> GetFriendSearchProfileTags()
	{
		return null;
	}

	[Token(Token = "0x60017EC")]
	[Address(RVA = "0x5A7510", Offset = "0x5A6710", VA = "0x1805A7510")]
	public static Dictionary<string, object> GetFollowPlayers()
	{
		return null;
	}

	[Token(Token = "0x60017ED")]
	[Address(RVA = "0x5A7440", Offset = "0x5A6640", VA = "0x1805A7440")]
	public static object GetFollowPlayer(long pcode)
	{
		return null;
	}

	[Token(Token = "0x60017EE")]
	[Address(RVA = "0x5A7370", Offset = "0x5A6570", VA = "0x1805A7370")]
	public static bool GetFollowPin(long pcode)
	{
		return default(bool);
	}

	[Token(Token = "0x60017EF")]
	[Address(RVA = "0x5A75B0", Offset = "0x5A67B0", VA = "0x1805A75B0")]
	public static (List<object>, bool) GetFollowerPlayers()
	{
		return default((List<object>, bool));
	}

	[Token(Token = "0x60017F0")]
	[Address(RVA = "0x5A33F0", Offset = "0x5A25F0", VA = "0x1805A33F0")]
	public static Dictionary<string, object> GetBlockPlayers()
	{
		return null;
	}

	[Token(Token = "0x60017F1")]
	[Address(RVA = "0x5B1F30", Offset = "0x5B1130", VA = "0x1805B1F30")]
	public static bool IsBlockPlayerInFriend(long pcode)
	{
		return default(bool);
	}

	[Token(Token = "0x60017F2")]
	[Address(RVA = "0x5A7DB0", Offset = "0x5A6FB0", VA = "0x1805A7DB0")]
	public static (List<object>, bool) GetFriendSearchResult()
	{
		return default((List<object>, bool));
	}

	[Token(Token = "0x60017F3")]
	[Address(RVA = "0x5B0A50", Offset = "0x5AFC50", VA = "0x1805B0A50")]
	public static object GetUpdatedFriend()
	{
		return null;
	}

	[Token(Token = "0x60017F4")]
	[Address(RVA = "0x5A36B0", Offset = "0x5A28B0", VA = "0x1805A36B0")]
	public static string GetCardIllustType()
	{
		return null;
	}

	[Token(Token = "0x60017F5")]
	[Address(RVA = "0x5AB130", Offset = "0x5AA330", VA = "0x1805AB130")]
	public static string GetOtherCardIllustType()
	{
		return null;
	}

	[Token(Token = "0x60017F6")]
	[Address(RVA = "0x5B4910", Offset = "0x5B3B10", VA = "0x1805B4910")]
	public static bool IsWhileTutorial()
	{
		return default(bool);
	}

	[Token(Token = "0x60017F7")]
	[Address(RVA = "0x5B47E0", Offset = "0x5B39E0", VA = "0x1805B47E0")]
	public static bool IsWhileTutorial(out int step)
	{
		return default(bool);
	}

	[Token(Token = "0x60017F8")]
	[Address(RVA = "0x5A72D0", Offset = "0x5A64D0", VA = "0x1805A72D0")]
	public static IReadOnlyList<object> GetFirstStructureDeckIds()
	{
		return null;
	}

	[Token(Token = "0x60017F9")]
	[Address(RVA = "0x5B4B00", Offset = "0x5B3D00", VA = "0x1805B4B00")]
	public static void LoadCommentList(string cwRootPath, out string[] comments, string defaultComment)
	{
	}

	[Token(Token = "0x60017FA")]
	[Address(RVA = "0x5B1D30", Offset = "0x5B0F30", VA = "0x1805B1D30")]
	public static bool InPeriod(long startTs, long endTs)
	{
		return default(bool);
	}
}
