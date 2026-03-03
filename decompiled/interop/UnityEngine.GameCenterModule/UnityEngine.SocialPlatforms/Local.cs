using System;
using Il2CppInterop.Runtime.InteropTypes;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;
using UnityEngine.SocialPlatforms.Impl;

namespace UnityEngine.SocialPlatforms;

public class Local
{
	[Serializable]
	public sealed class _003C_003Ec
	{
	}

	public sealed class _003C_003Ec__DisplayClass10_0
	{
	}

	public ILocalUser localUser
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void UnityEngine_002ESocialPlatforms_002EISocialPlatform_002EAuthenticate(ILocalUser user, Action<bool> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void UnityEngine_002ESocialPlatforms_002EISocialPlatform_002EAuthenticate(ILocalUser user, Action<bool, string> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void UnityEngine_002ESocialPlatforms_002EISocialPlatform_002ELoadFriends(ILocalUser user, Action<bool> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void LoadUsers(Il2CppStringArray userIDs, Action<Il2CppReferenceArray<IUserProfile>> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void ReportProgress(string id, double progress, Action<bool> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void LoadAchievementDescriptions(Action<Il2CppReferenceArray<IAchievementDescription>> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void LoadAchievements(Action<Il2CppReferenceArray<IAchievement>> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void ReportScore(long score, string board, Action<bool> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void LoadScores(string leaderboardID, Action<Il2CppReferenceArray<IScore>> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void UnityEngine_002ESocialPlatforms_002EISocialPlatform_002ELoadScores(ILeaderboard board, Action<bool> callback)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public bool UnityEngine_002ESocialPlatforms_002EISocialPlatform_002EGetLoading(ILeaderboard board)
	{
		if (!VerifyUser())
		{
			return false;
		}
		return ((Il2CppObjectBase)board).Cast<Leaderboard>().loading;
	}

	public void SortScores(Leaderboard board)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetLocalPlayerScore(Leaderboard board)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void ShowAchievementsUI()
	{
		Debug.Log("ShowAchievementsUI not implemented");
	}

	public void ShowLeaderboardUI()
	{
		Debug.Log("ShowLeaderboardUI not implemented");
	}

	public ILeaderboard CreateLeaderboard()
	{
		return (ILeaderboard)new Leaderboard();
	}

	public IAchievement CreateAchievement()
	{
		return (IAchievement)new Achievement();
	}

	public bool VerifyUser()
	{
		if (!localUser.authenticated)
		{
			Debug.LogError("Must authenticate first");
			return false;
		}
		return true;
	}

	public void PopulateStaticData()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public Texture2D CreateDummyTexture(int width, int height)
	{
		Texture2D texture2D = new Texture2D(width, height);
		for (int i = 0; i < height; i++)
		{
			for (int j = 0; j < width; j++)
			{
				Color color = (((j & i) > 0) ? Color.white : Color.gray);
				texture2D.SetPixel(j, i, color);
			}
		}
		texture2D.Apply();
		return texture2D;
	}
}
