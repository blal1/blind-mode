using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Htjson;

[Token(Token = "0x20001EA")]
public class HtjsonLoader
{
	[Token(Token = "0x4000A6D")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<string, object> commonStyles;

	[Token(Token = "0x4000A6E")]
	[FieldOffset(Offset = "0x8")]
	private static Func<string, byte[]> byteloader;

	[Token(Token = "0x6000BB5")]
	[Address(RVA = "0xC08EA0", Offset = "0xC080A0", VA = "0x180C08EA0")]
	public static void OverrideByteLoader(Func<string, byte[]> loader)
	{
	}

	[Token(Token = "0x6000BB6")]
	[Address(RVA = "0xC08D30", Offset = "0xC07F30", VA = "0x180C08D30")]
	public static Dictionary<string, object> GetCommonStyles()
	{
		return null;
	}

	[Token(Token = "0x6000BB7")]
	[Address(RVA = "0xC09170", Offset = "0xC08370", VA = "0x180C09170")]
	public static object byteToJsonObject(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000BB8")]
	[Address(RVA = "0xC09010", Offset = "0xC08210", VA = "0x180C09010")]
	public static Dictionary<string, object> byteToDictionary(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000BB9")]
	[Address(RVA = "0xC09290", Offset = "0xC08490", VA = "0x180C09290")]
	public static List<object> byteToList(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000BBA")]
	[Address(RVA = "0xC09820", Offset = "0xC08A20", VA = "0x180C09820")]
	public static Dictionary<string, object> loadedImmediateResourceDictionary(string path)
	{
		return null;
	}

	[Token(Token = "0x6000BBB")]
	[Address(RVA = "0xC099D0", Offset = "0xC08BD0", VA = "0x180C099D0")]
	public static List<object> loadedImmediateResourceList(string path)
	{
		return null;
	}

	[Token(Token = "0x6000BBC")]
	[Address(RVA = "0xC094A0", Offset = "0xC086A0", VA = "0x180C094A0")]
	public static object loadedImmediateJson(string url)
	{
		return null;
	}

	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0xC093F0", Offset = "0xC085F0", VA = "0x180C093F0")]
	public static void loadSchemeUrl(string url, Action<object> loaded, Action failed)
	{
	}

	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public HtjsonLoader()
	{
	}
}
