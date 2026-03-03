using System;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl;

public class LocalUser : UserProfile
{
	public Il2CppReferenceArray<IUserProfile> friends
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool authenticated
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool underage
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public void Authenticate(Action<bool> callback)
	{
		ActivePlatform.Instance.Authenticate((ILocalUser)this, callback);
	}

	public void Authenticate(Action<bool, string> callback)
	{
		ActivePlatform.Instance.Authenticate((ILocalUser)this, callback);
	}

	public void LoadFriends(Action<bool> callback)
	{
		ActivePlatform.Instance.LoadFriends((ILocalUser)this, callback);
	}

	public void SetFriends(Il2CppReferenceArray<IUserProfile> friends)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetAuthenticated(bool value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetUnderage(bool value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}
}
