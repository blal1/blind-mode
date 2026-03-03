using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x2000423")]
public class UrlScheme
{
	[Token(Token = "0x400145A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static SortedDictionary<string, Action<string, object, object>> schemeFuncs;

	[Token(Token = "0x400145B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Dictionary<string, Func<string, object>> argsCommands;

	[Token(Token = "0x400145C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	public static bool fatalAbort;

	[Token(Token = "0x400145D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	public static string LatestUrl;

	[Token(Token = "0x6001AA7")]
	[Address(RVA = "0x5F7E40", Offset = "0x5F7040", VA = "0x1805F7E40")]
	public static Dictionary<string, object> GetArgs(string url)
	{
		return null;
	}

	[Token(Token = "0x6001AA8")]
	[Address(RVA = "0x5F8D00", Offset = "0x5F7F00", VA = "0x1805F8D00")]
	public static bool SplitArgs(string url, out string baseUrl, out Dictionary<string, object> args)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AA9")]
	[Address(RVA = "0x5F8540", Offset = "0x5F7740", VA = "0x1805F8540")]
	public static bool OpenList(object urls, [Optional] object option, [Optional] object context)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AAA")]
	[Address(RVA = "0x5F8B50", Offset = "0x5F7D50", VA = "0x1805F8B50")]
	public static string ProcRelativePath(string path)
	{
		return null;
	}

	[Token(Token = "0x6001AAB")]
	[Address(RVA = "0x5F8E00", Offset = "0x5F8000", VA = "0x1805F8E00")]
	public static bool SplitUrl(string url, out string scheme, out string host, out string option)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AAC")]
	[Address(RVA = "0x5F7970", Offset = "0x5F6B70", VA = "0x1805F7970")]
	public static (bool, string[], Dictionary<string, object>) AnalyzeUrl(string url)
	{
		return default((bool, string[], Dictionary<string, object>));
	}

	[Token(Token = "0x6001AAD")]
	[Address(RVA = "0x5F78E0", Offset = "0x5F6AE0", VA = "0x1805F78E0")]
	public static void AddScheme(string url, Action<string, object, object> act)
	{
	}

	[Token(Token = "0x6001AAE")]
	[Address(RVA = "0x5F77B0", Offset = "0x5F69B0", VA = "0x1805F77B0")]
	public static void AddArgsCommand(string cmd, Func<string, object> act)
	{
	}

	[Token(Token = "0x6001AAF")]
	[Address(RVA = "0x5F7BC0", Offset = "0x5F6DC0", VA = "0x1805F7BC0")]
	public static object ExecuteArgsCommand(string val)
	{
		return null;
	}

	[Token(Token = "0x6001AB0")]
	[Address(RVA = "0x5F8440", Offset = "0x5F7640", VA = "0x1805F8440")]
	public static bool IsUrlScheme(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AB1")]
	[Address(RVA = "0x5F8870", Offset = "0x5F7A70", VA = "0x1805F8870")]
	public static bool Open(string url, [Optional] object option, [Optional] object context)
	{
		return default(bool);
	}

	[Token(Token = "0x6001AB2")]
	[Address(RVA = "0x5F82E0", Offset = "0x5F74E0", VA = "0x1805F82E0")]
	private static int GetUrlEndTokenIndex(string str, char endToken, int startIndex = 0)
	{
		return default(int);
	}

	[Token(Token = "0x6001AB3")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public UrlScheme()
	{
	}
}
