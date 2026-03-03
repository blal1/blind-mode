using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.SocialSystem;

[Token(Token = "0x200032F")]
public interface ISocialSystem
{
	[Token(Token = "0x17000209")]
	bool IsEnableAutoLogin
	{
		[Token(Token = "0x60013E5")]
		get;
	}

	[Token(Token = "0x1700020A")]
	bool IsFirstAutoLogin
	{
		[Token(Token = "0x60013E6")]
		get;
	}

	[Token(Token = "0x1700020B")]
	bool IsAuthenticated
	{
		[Token(Token = "0x60013E7")]
		get;
	}

	[Token(Token = "0x1700020C")]
	string socialId
	{
		[Token(Token = "0x60013E8")]
		get;
	}

	[Token(Token = "0x60013E9")]
	void Activate();

	[Token(Token = "0x60013EA")]
	void Authenticate([Optional] Action<bool> callback);

	[Token(Token = "0x60013EB")]
	void SignOut();

	[Token(Token = "0x60013EC")]
	void ShowAchievementUI();

	[Token(Token = "0x60013ED")]
	string ConvertAchievementIdToKey(int achievementId);

	[Token(Token = "0x60013EE")]
	void UnlockAchievement(string id, [Optional] Action<bool> callback);
}
