using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.SocialPlatforms;

namespace UnityEngine;

public static class Social
{
	public static ISocialPlatform Active
	{
		get
		{
			return ActivePlatform.Instance;
		}
		set
		{
			ActivePlatform.Instance = value;
		}
	}

	public static ILocalUser localUser => Active.localUser;

	public static void LoadUsers(Il2CppStringArray userIDs, Action<Il2CppReferenceArray<IUserProfile>> callback)
	{
		Active.LoadUsers(userIDs, callback);
	}

	public static void ReportProgress(string achievementID, double progress, Action<bool> callback)
	{
		Active.ReportProgress(achievementID, progress, callback);
	}

	public static void LoadAchievementDescriptions(Action<Il2CppReferenceArray<IAchievementDescription>> callback)
	{
		Active.LoadAchievementDescriptions(callback);
	}

	public static void LoadAchievements(Action<Il2CppReferenceArray<IAchievement>> callback)
	{
		Active.LoadAchievements(callback);
	}

	public static void ReportScore(long score, string board, Action<bool> callback)
	{
		Active.ReportScore(score, board, callback);
	}

	public static void LoadScores(string leaderboardID, Action<Il2CppReferenceArray<IScore>> callback)
	{
		Active.LoadScores(leaderboardID, callback);
	}

	public static ILeaderboard CreateLeaderboard()
	{
		return Active.CreateLeaderboard();
	}

	public static IAchievement CreateAchievement()
	{
		return Active.CreateAchievement();
	}

	public static void ShowAchievementsUI()
	{
		Active.ShowAchievementsUI();
	}

	public static void ShowLeaderboardUI()
	{
		Active.ShowLeaderboardUI();
	}
}
