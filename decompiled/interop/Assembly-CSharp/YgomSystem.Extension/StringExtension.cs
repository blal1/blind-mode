using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomGame.Utility;

namespace YgomSystem.Extension;

[Token(Token = "0x200036E")]
public static class StringExtension
{
	[Token(Token = "0x600154E")]
	[Address(RVA = "0x52B550", Offset = "0x52A750", VA = "0x18052B550")]
	public static int CountLine(this string s)
	{
		return default(int);
	}

	[Token(Token = "0x600154F")]
	[Address(RVA = "0x52BB70", Offset = "0x52AD70", VA = "0x18052BB70")]
	public static long ToPcode(this string s)
	{
		return default(long);
	}

	[Token(Token = "0x6001550")]
	[Address(RVA = "0x52B5C0", Offset = "0x52A7C0", VA = "0x18052B5C0")]
	public static string FilterAddress(this string inStr)
	{
		return null;
	}

	[Token(Token = "0x6001551")]
	[Address(RVA = "0x52B9D0", Offset = "0x52ABD0", VA = "0x18052B9D0")]
	public static string FormatTryCatch(string format, params object[] args)
	{
		return null;
	}

	[Token(Token = "0x6001552")]
	[Address(RVA = "0x52BA00", Offset = "0x52AC00", VA = "0x18052BA00")]
	public static string MakeFormatedText(this string baseText, TextGroupLoadHolder textGroupLoadHolder, [Optional] List<object> args)
	{
		return null;
	}

	[Token(Token = "0x6001553")]
	[Address(RVA = "0x52BB60", Offset = "0x52AD60", VA = "0x18052BB60")]
	public static string ToDummy(this string s)
	{
		return null;
	}

	[Token(Token = "0x6001554")]
	[Address(RVA = "0x52BA10", Offset = "0x52AC10", VA = "0x18052BA10")]
	public static string TextFromTextID(this string textID)
	{
		return null;
	}

	[Token(Token = "0x6001555")]
	[Address(RVA = "0x52BC00", Offset = "0x52AE00", VA = "0x18052BC00")]
	public static object TryParseValue(this string str)
	{
		return null;
	}

	[Token(Token = "0x6001556")]
	[Address(RVA = "0x52B810", Offset = "0x52AA10", VA = "0x18052B810")]
	public static string FormatParenPerText(this string baseText, object parenText1, object parenText2, [Optional] object additionalText)
	{
		return null;
	}
}
