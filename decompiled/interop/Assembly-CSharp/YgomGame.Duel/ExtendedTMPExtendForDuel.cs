using Il2CppDummyDll;
using TMPro;

namespace YgomGame.Duel;

[Token(Token = "0x2001B73")]
public static class ExtendedTMPExtendForDuel
{
	[Token(Token = "0x400F8F0")]
	public const int MAXDISPBATTLEPOWER = 99999999;

	[Token(Token = "0x400F8F1")]
	public const int MAXDISPLIFEPOINT = 999999;

	[Token(Token = "0x400F8F2")]
	public const int MAX2DIGITNUM = 99;

	[Token(Token = "0x600B108")]
	[Address(RVA = "0x488140", Offset = "0x487340", VA = "0x180488140")]
	public static void SetLifePoint(this TextMeshPro exTmp, int value, int digitnum = 0, bool coloring = false)
	{
	}

	[Token(Token = "0x600B109")]
	[Address(RVA = "0x488140", Offset = "0x487340", VA = "0x180488140")]
	public static void SetLifePoint(this TextMeshProUGUI exTmp, int value, int digitnum = 0, bool coloring = false)
	{
	}

	[Token(Token = "0x600B10A")]
	[Address(RVA = "0x4880F0", Offset = "0x4872F0", VA = "0x1804880F0")]
	public static void Set2DigitNum(this TextMeshPro exTmp, int value, int orgvalue)
	{
	}

	[Token(Token = "0x600B10B")]
	[Address(RVA = "0x4880F0", Offset = "0x4872F0", VA = "0x1804880F0")]
	public static void Set2DigitNum(this TextMeshProUGUI exTmp, int value, int orgvalue)
	{
	}

	[Token(Token = "0x600B10C")]
	[Address(RVA = "0x488230", Offset = "0x487430", VA = "0x180488230")]
	public static void SetOverlayUnit(this TextMeshPro exTmp, int value)
	{
	}

	[Token(Token = "0x600B10D")]
	[Address(RVA = "0x488190", Offset = "0x487390", VA = "0x180488190")]
	public static void SetOverlayUnit(this TextMeshProUGUI exTmp, int value)
	{
	}

	[Token(Token = "0x600B10E")]
	[Address(RVA = "0x487FA0", Offset = "0x4871A0", VA = "0x180487FA0")]
	private static string GetLifePointStr(int value, int digitnum = 0, bool coloring = false)
	{
		return null;
	}

	[Token(Token = "0x600B10F")]
	[Address(RVA = "0x487E60", Offset = "0x487060", VA = "0x180487E60")]
	private static string GetLevelRankStr(int value, int orgvalue)
	{
		return null;
	}
}
