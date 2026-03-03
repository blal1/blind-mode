using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl;

public class Achievement
{
	public string id
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

	public double percentCompleted
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

	public bool completed
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool hidden
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public DateTime lastReportedDate
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

	public void ReportProgress(Action<bool> callback)
	{
		ActivePlatform.Instance.ReportProgress(id, percentCompleted, callback);
	}

	public void SetCompleted(bool value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetHidden(bool value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetLastReportedDate(DateTime date)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}
}
