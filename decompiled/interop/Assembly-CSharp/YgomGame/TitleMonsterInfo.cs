using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x2000716")]
public class TitleMonsterInfo
{
	[Token(Token = "0x400235B")]
	[FieldOffset(Offset = "0x0")]
	private static List<int> s_referenceList;

	[Token(Token = "0x400235C")]
	[FieldOffset(Offset = "0x8")]
	private static List<int> s_dispList;

	[Token(Token = "0x400235D")]
	[FieldOffset(Offset = "0x10")]
	private static uint s_dispIndex;

	[Token(Token = "0x6002EC2")]
	[Address(RVA = "0x7235B0", Offset = "0x7227B0", VA = "0x1807235B0")]
	private static void shuffle()
	{
	}

	[Token(Token = "0x6002EC3")]
	[Address(RVA = "0x723340", Offset = "0x722540", VA = "0x180723340")]
	public static int FetchWallPaperID()
	{
		return default(int);
	}

	[Token(Token = "0x6002EC4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public TitleMonsterInfo()
	{
	}
}
