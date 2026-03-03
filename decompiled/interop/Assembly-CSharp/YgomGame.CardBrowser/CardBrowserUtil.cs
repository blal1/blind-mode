using Il2CppDummyDll;

namespace YgomGame.CardBrowser;

[Token(Token = "0x20015C8")]
public static class CardBrowserUtil
{
	[Token(Token = "0x400CEF1")]
	internal const int k_TermType_NewReleased = 1;

	[Token(Token = "0x6008722")]
	[Address(RVA = "0xCE4EA0", Offset = "0xCE40A0", VA = "0x180CE4EA0")]
	public static bool IsNewReleasedCard(int mrk)
	{
		return default(bool);
	}

	[Token(Token = "0x6008723")]
	[Address(RVA = "0xCE4E10", Offset = "0xCE4010", VA = "0x180CE4E10")]
	public static string GetNewReleasedCardDateStr(int mrk)
	{
		return null;
	}
}
