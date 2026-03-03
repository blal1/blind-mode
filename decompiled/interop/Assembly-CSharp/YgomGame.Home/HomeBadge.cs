using System.Collections.Generic;
using Il2CppDummyDll;
using YgomSystem.ElementSystem;

namespace YgomGame.Home;

[Token(Token = "0x2000D47")]
public class HomeBadge
{
	[Token(Token = "0x2000D48")]
	public enum Badge
	{
		[Token(Token = "0x4009E86")]
		MISSION = 1,
		[Token(Token = "0x4009E87")]
		FRIEND = 2,
		[Token(Token = "0x4009E88")]
		DUEL = 3,
		[Token(Token = "0x4009E89")]
		SHOP = 4,
		[Token(Token = "0x4009E8A")]
		PRESENT = 5,
		[Token(Token = "0x4009E8B")]
		NOTICE = 6,
		[Token(Token = "0x4009E8C")]
		QUEST = 7,
		[Token(Token = "0x4009E8D")]
		DUELPASS = 8,
		[Token(Token = "0x4009E8E")]
		CERTIFICATION = 9,
		[Token(Token = "0x4009E8F")]
		DUELSHORTCUT = 11,
		[Token(Token = "0x4009E90")]
		DUELLIVE = 12,
		[Token(Token = "0x4009E91")]
		DECK = 100,
		[Token(Token = "0x4009E92")]
		SUBMENU = 101,
		[Token(Token = "0x4009E93")]
		CARDFILE = 102
	}

	[Token(Token = "0x4009E80")]
	[FieldOffset(Offset = "0x10")]
	private readonly string IMG_NUMBADGE_LABEL;

	[Token(Token = "0x4009E81")]
	[FieldOffset(Offset = "0x18")]
	private readonly string IMG_NEWBADGE_LABEL_KIND0;

	[Token(Token = "0x4009E82")]
	[FieldOffset(Offset = "0x20")]
	private readonly string IMG_NEWBADGE_LABEL_KIND1;

	[Token(Token = "0x4009E83")]
	[FieldOffset(Offset = "0x28")]
	private readonly string TXT_BADGE_LABEL;

	[Token(Token = "0x4009E84")]
	[FieldOffset(Offset = "0x30")]
	private Dictionary<Badge, ElementObjectManager[]> badgeMap;

	[Token(Token = "0x6005050")]
	[Address(RVA = "0x96DE60", Offset = "0x96D060", VA = "0x18096DE60")]
	public void InitBadge(Badge badge, params ElementObjectManager[] buttonEoms)
	{
	}

	[Token(Token = "0x6005051")]
	[Address(RVA = "0x96E070", Offset = "0x96D270", VA = "0x18096E070")]
	public void SetBadge(Badge badge, int count = 0, int kind = 0)
	{
	}

	[Token(Token = "0x6005052")]
	[Address(RVA = "0x96E3D0", Offset = "0x96D5D0", VA = "0x18096E3D0")]
	public HomeBadge()
	{
	}
}
