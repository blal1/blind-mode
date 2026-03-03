using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl;

public class Score
{
	public string leaderboardID
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public long value
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
		set
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public DateTime date
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string formattedValue
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string userID
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public int rank
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public virtual string ToString()
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void ReportScore(Action<bool> callback)
	{
		ActivePlatform.Instance.ReportScore(value, leaderboardID, callback);
	}

	public void SetDate(DateTime date)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetFormattedValue(string value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetUserID(string userID)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetRank(int rank)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}
}
