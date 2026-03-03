using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002D4")]
public static class StreamAssetList
{
	[Token(Token = "0x4000F8E")]
	private const string kStreamAssetListFileName = "streamAssetList.json";

	[Token(Token = "0x4000F8F")]
	[FieldOffset(Offset = "0x0")]
	private static HashSet<string> assetList;

	[Token(Token = "0x600114E")]
	[Address(RVA = "0xE7A7F0", Offset = "0xE799F0", VA = "0x180E7A7F0")]
	static StreamAssetList()
	{
	}

	[Token(Token = "0x600114F")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public static bool IsEnable()
	{
		return default(bool);
	}

	[Token(Token = "0x6001150")]
	[Address(RVA = "0xE7A7F0", Offset = "0xE799F0", VA = "0x180E7A7F0")]
	private static void LoadFromFile()
	{
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0xE7A7A0", Offset = "0xE799A0", VA = "0x180E7A7A0")]
	public static bool Exists(string relativePath)
	{
		return default(bool);
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0xE7A740", Offset = "0xE79940", VA = "0x180E7A740")]
	public static bool ExistsAssetBundle(string relativePath)
	{
		return default(bool);
	}
}
