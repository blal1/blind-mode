using System;
using Il2CppDummyDll;

namespace YgomGame.Notification;

[Token(Token = "0x2000C37")]
public class AnnounceUtil
{
	[Token(Token = "0x2000C38")]
	public enum AnnounceType
	{
		[Token(Token = "0x4009A95")]
		Notification = 1,
		[Token(Token = "0x4009A96")]
		HotNews
	}

	[Token(Token = "0x6004A9C")]
	[Address(RVA = "0x930E50", Offset = "0x930050", VA = "0x180930E50")]
	public static HomeAnnounceBehaviourBase CreateAnnounceBehaviour(AnnounceType announceType)
	{
		return null;
	}

	[Token(Token = "0x6004A9D")]
	[Address(RVA = "0x930D80", Offset = "0x92FF80", VA = "0x180930D80")]
	public static void CallAPI(Action onFinish)
	{
	}

	[Token(Token = "0x6004A9E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AnnounceUtil()
	{
	}
}
