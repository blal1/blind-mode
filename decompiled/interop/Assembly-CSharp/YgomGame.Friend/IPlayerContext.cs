using System;
using Il2CppDummyDll;

namespace YgomGame.Friend;

[Token(Token = "0x2000DC7")]
public interface IPlayerContext : IComparable<IPlayerContext>
{
	[Token(Token = "0x17000C07")]
	long pcode
	{
		[Token(Token = "0x60052B3")]
		get;
	}

	[Token(Token = "0x17000C08")]
	string playerName
	{
		[Token(Token = "0x60052B4")]
		get;
	}

	[Token(Token = "0x17000C09")]
	string platformPlayerName
	{
		[Token(Token = "0x60052B5")]
		get;
	}

	[Token(Token = "0x17000C0A")]
	bool isRegistedPlatform
	{
		[Token(Token = "0x60052B6")]
		get;
	}

	[Token(Token = "0x17000C0B")]
	bool isSamePlatform
	{
		[Token(Token = "0x60052B7")]
		get;
	}

	[Token(Token = "0x17000C0C")]
	int iconId
	{
		[Token(Token = "0x60052B8")]
		get;
	}

	[Token(Token = "0x17000C0D")]
	int iconFrameId
	{
		[Token(Token = "0x60052B9")]
		get;
	}

	[Token(Token = "0x17000C0E")]
	int wallpaperId
	{
		[Token(Token = "0x60052BA")]
		get;
	}

	[Token(Token = "0x17000C0F")]
	FollowState followState
	{
		[Token(Token = "0x60052BB")]
		get;
	}

	[Token(Token = "0x17000C10")]
	bool isPin
	{
		[Token(Token = "0x60052BC")]
		get;
	}

	[Token(Token = "0x17000C11")]
	long onlineTime
	{
		[Token(Token = "0x60052BD")]
		get;
	}

	[Token(Token = "0x17000C12")]
	long loginTime
	{
		[Token(Token = "0x60052BE")]
		get;
	}

	[Token(Token = "0x17000C13")]
	long followedTime
	{
		[Token(Token = "0x60052BF")]
		get;
	}

	[Token(Token = "0x17000C14")]
	bool isOnline
	{
		[Token(Token = "0x60052C0")]
		get;
	}

	[Token(Token = "0x17000C15")]
	bool isEnableDuelWatch
	{
		[Token(Token = "0x60052C1")]
		get;
	}

	[Token(Token = "0x17000C16")]
	int invitedRoomId
	{
		[Token(Token = "0x60052C2")]
		get;
	}

	[Token(Token = "0x17000C17")]
	int invitedTeamId
	{
		[Token(Token = "0x60052C3")]
		get;
	}

	[Token(Token = "0x17000C18")]
	bool blocked
	{
		[Token(Token = "0x60052C4")]
		get;
	}
}
