using System;

namespace UnityEngine.SocialPlatforms;

public static class ActivePlatform
{
	public static ISocialPlatform Instance
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

	public static ISocialPlatform SelectSocialPlatform()
	{
		return (ISocialPlatform)new Local();
	}
}
