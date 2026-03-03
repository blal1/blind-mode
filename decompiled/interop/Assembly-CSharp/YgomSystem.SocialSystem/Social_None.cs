using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.SocialSystem;

[Token(Token = "0x2000334")]
public class Social_None : ISocialSystem
{
	[Token(Token = "0x17000214")]
	public bool IsEnableAutoLogin
	{
		[Token(Token = "0x600140E")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000215")]
	public bool IsFirstAutoLogin
	{
		[Token(Token = "0x600140F")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "5")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000216")]
	public bool IsAuthenticated
	{
		[Token(Token = "0x6001410")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000217")]
	public string socialId
	{
		[Token(Token = "0x6001411")]
		[Address(RVA = "0x52A620", Offset = "0x529820", VA = "0x18052A620", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6001412")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "8")]
	public void Activate()
	{
	}

	[Token(Token = "0x6001413")]
	[Address(RVA = "0x51E110", Offset = "0x51D310", VA = "0x18051E110", Slot = "9")]
	public void Authenticate([Optional] Action<bool> callback)
	{
	}

	[Token(Token = "0x6001414")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "10")]
	public void SignOut()
	{
	}

	[Token(Token = "0x6001415")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60", Slot = "11")]
	public void ShowAchievementUI()
	{
	}

	[Token(Token = "0x6001416")]
	[Address(RVA = "0x4C7DC0", Offset = "0x4C6FC0", VA = "0x1804C7DC0", Slot = "12")]
	public string ConvertAchievementIdToKey(int achievementId)
	{
		return null;
	}

	[Token(Token = "0x6001417")]
	[Address(RVA = "0x52A600", Offset = "0x529800", VA = "0x18052A600", Slot = "13")]
	public void UnlockAchievement(string id, [Optional] Action<bool> callback)
	{
	}

	[Token(Token = "0x6001418")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Social_None()
	{
	}
}
