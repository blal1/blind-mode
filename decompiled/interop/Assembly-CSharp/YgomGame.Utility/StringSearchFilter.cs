using Il2CppDummyDll;

namespace YgomGame.Utility;

[Token(Token = "0x200091D")]
public static class StringSearchFilter
{
	[Token(Token = "0x40089AD")]
	private const int HAN_SPACE = 32;

	[Token(Token = "0x40089AE")]
	private const int HAN_YEN = 92;

	[Token(Token = "0x40089AF")]
	private const int HAN_ALPHA_START = 33;

	[Token(Token = "0x40089B0")]
	private const int HAN_ALPHA_END = 126;

	[Token(Token = "0x40089B1")]
	private const int ZEN_SPACE = 12288;

	[Token(Token = "0x40089B2")]
	private const int ZEN_YEN = 65509;

	[Token(Token = "0x40089B3")]
	private const int ZEN_ALPHA_START = 65281;

	[Token(Token = "0x40089B4")]
	private const int ZEN_ALPHA_OFFSET = 65248;

	[Token(Token = "0x40089B5")]
	private const int HIRA_START = 12352;

	[Token(Token = "0x40089B6")]
	private const int HIRA_END = 12442;

	[Token(Token = "0x40089B7")]
	private const int KATA_START = 12448;

	[Token(Token = "0x40089B8")]
	private const int KATA_OFFSET = 96;

	[Token(Token = "0x40089B9")]
	private const int ZAL_START = 65313;

	[Token(Token = "0x40089BA")]
	private const int ZAL_END = 65338;

	[Token(Token = "0x40089BB")]
	private const int ZAS_START = 65345;

	[Token(Token = "0x40089BC")]
	private const int ZAS_OFFSET = 32;

	[Token(Token = "0x60036A4")]
	[Address(RVA = "0x7C9530", Offset = "0x7C8730", VA = "0x1807C9530")]
	public static bool SplitFilter(string keywordStr, string sourceStr)
	{
		return default(bool);
	}

	[Token(Token = "0x60036A5")]
	[Address(RVA = "0x7C9660", Offset = "0x7C8860", VA = "0x1807C9660")]
	public static string convertSearchText(string src)
	{
		return null;
	}

	[Token(Token = "0x60036A6")]
	[Address(RVA = "0x7C9980", Offset = "0x7C8B80", VA = "0x1807C9980")]
	private static string toZenkaku(string src)
	{
		return null;
	}

	[Token(Token = "0x60036A7")]
	[Address(RVA = "0x7C9880", Offset = "0x7C8A80", VA = "0x1807C9880")]
	private static string toKatakana_Komoji(string src)
	{
		return null;
	}
}
