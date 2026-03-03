using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Deck;

[Token(Token = "0x2001124")]
public class SoloDeckUtil
{
	[Token(Token = "0x2001125")]
	public enum SoloDeckType
	{
		[Token(Token = "0x400B4FA")]
		Story,
		[Token(Token = "0x400B4FB")]
		NPC
	}

	[Token(Token = "0x6006B79")]
	[Address(RVA = "0xB38280", Offset = "0xB37480", VA = "0x180B38280")]
	public static int GetStoryDeckID(int chapterId)
	{
		return default(int);
	}

	[Token(Token = "0x6006B7A")]
	[Address(RVA = "0xB38330", Offset = "0xB37530", VA = "0x180B38330")]
	public static string GetStoryDeckName(int chapterId)
	{
		return null;
	}

	[Token(Token = "0x6006B7B")]
	[Address(RVA = "0xB38140", Offset = "0xB37340", VA = "0x180B38140")]
	public static string GetStoryDeckDesc(int chapterId)
	{
		return null;
	}

	[Token(Token = "0x6006B7C")]
	[Address(RVA = "0xB38470", Offset = "0xB37670", VA = "0x180B38470")]
	public static Dictionary<string, object> GetStoryDeck(int chapterId, DeckInfo.DeckType deckType)
	{
		return null;
	}

	[Token(Token = "0x6006B7D")]
	[Address(RVA = "0xB37DD0", Offset = "0xB36FD0", VA = "0x180B37DD0")]
	public static int GetNPCDeckID(int chapterId)
	{
		return default(int);
	}

	[Token(Token = "0x6006B7E")]
	[Address(RVA = "0xB37E80", Offset = "0xB37080", VA = "0x180B37E80")]
	public static string GetNPCDeckName(int chapterId)
	{
		return null;
	}

	[Token(Token = "0x6006B7F")]
	[Address(RVA = "0xB37C90", Offset = "0xB36E90", VA = "0x180B37C90")]
	public static string GetNPCDeckDesc(int chapterId)
	{
		return null;
	}

	[Token(Token = "0x6006B80")]
	[Address(RVA = "0xB37FC0", Offset = "0xB371C0", VA = "0x180B37FC0")]
	public static Dictionary<string, object> GetNPCDeck(int chapterId, DeckInfo.DeckType deckType)
	{
		return null;
	}

	[Token(Token = "0x6006B81")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SoloDeckUtil()
	{
	}
}
