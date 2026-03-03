using System;
using Il2CppSystem;

namespace UnityEngine.SocialPlatforms.Impl;

public class UserProfile
{
	public const string legacyIdObsoleteMessage = "legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead";

	public string userName
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string id
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public string legacyId
	{
		get
		{
			throw new NotSupportedException("legacyId returns playerID from GKPlayer, which became obsolete in iOS 12.4 . id returns playerID for devices running versions before iOS 12.4, and the newer teamPlayerID for later versions. Please use IUserProfile.id or UserProfile.id instead");
		}
	}

	public string gameId
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public bool isFriend
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public UserState state
	{
		get
		{
			//IL_0005: Unknown result type (might be due to invalid IL or missing references)
			throw new NotSupportedException("Method unstripping failed");
		}
	}

	public Texture2D image
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

	public void SetUserName(string name)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetUserID(string id)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetLegacyUserID(string id)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetUserGameID(string id)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetImage(Texture2D image)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetIsFriend(bool value)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}

	public void SetState(UserState state)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		throw new NotSupportedException("Method unstripping failed");
	}
}
