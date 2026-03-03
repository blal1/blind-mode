using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001A56")]
internal class AllCardBreaker
{
	[Token(Token = "0x2001A57")]
	public enum Type
	{
		[Token(Token = "0x400F2AE")]
		Break,
		[Token(Token = "0x400F2AF")]
		DeckOut
	}

	[Token(Token = "0x400F2A5")]
	[FieldOffset(Offset = "0x10")]
	private DuelGameObjectManager goManager;

	[Token(Token = "0x400F2A6")]
	[FieldOffset(Offset = "0x18")]
	private Queue<CardRoot> breakTargets;

	[Token(Token = "0x400F2A7")]
	[FieldOffset(Offset = "0x20")]
	private float timer;

	[Token(Token = "0x400F2A8")]
	private const float breakPerSecond = 5f;

	[Token(Token = "0x400F2A9")]
	private const float maxSecond = 3f;

	[Token(Token = "0x400F2AA")]
	[FieldOffset(Offset = "0x24")]
	private int numMovings;

	[Token(Token = "0x400F2AB")]
	[FieldOffset(Offset = "0x28")]
	private int targetNum;

	[Token(Token = "0x400F2AC")]
	[FieldOffset(Offset = "0x2C")]
	private Type type;

	[Token(Token = "0x17001A69")]
	private float intervalTime
	{
		[Token(Token = "0x600AAF7")]
		[Address(RVA = "0xF62430", Offset = "0xF61630", VA = "0x180F62430")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x17001A6A")]
	public bool finished
	{
		[Token(Token = "0x600AAF8")]
		[Address(RVA = "0xF62420", Offset = "0xF61620", VA = "0x180F62420")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600AAF9")]
	[Address(RVA = "0xF618D0", Offset = "0xF60AD0", VA = "0x180F618D0")]
	public void Play(DuelGameObjectManager goManager, int loser, Type type)
	{
	}

	[Token(Token = "0x600AAFA")]
	[Address(RVA = "0xF61DF0", Offset = "0xF60FF0", VA = "0x180F61DF0")]
	public bool UpdateBreakLoserCard()
	{
		return default(bool);
	}

	[Token(Token = "0x600AAFB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public AllCardBreaker()
	{
	}
}
