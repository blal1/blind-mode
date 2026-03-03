using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.ResourceSystem;

[Token(Token = "0x20002C5")]
public static class ResourceUtility
{
	[Token(Token = "0x4000F66")]
	public const string kUniversalLangPath = "Universal";

	[Token(Token = "0x4000F67")]
	private const string kConvertLangPath = "#";

	[Token(Token = "0x4000F68")]
	private const string kConvertPlatformPath = "<_PLATFORM_>";

	[Token(Token = "0x4000F69")]
	public const string kCommonResourceTypePath = "SD";

	[Token(Token = "0x4000F6A")]
	private const string kConvertResourceTypePath = "<_RESOURCE_TYPE_>";

	[Token(Token = "0x4000F6B")]
	private const string kConvertCardIllustType = "<_CARD_ILLUST_>";

	[Token(Token = "0x4000F6C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly byte[] CompressedFileHeader;

	[Token(Token = "0x4000F6D")]
	[FieldOffset(Offset = "0x8")]
	public static readonly byte[] AssetBundleHeader;

	[Token(Token = "0x4000F6E")]
	[FieldOffset(Offset = "0x10")]
	private static readonly byte[] PNGFileHeader;

	[Token(Token = "0x60010E5")]
	[Address(RVA = "0xE796C0", Offset = "0xE788C0", VA = "0x180E796C0")]
	public static bool isAssetBundleFile(string path, bool isStreamingAssets = false)
	{
		return default(bool);
	}

	[Token(Token = "0x60010E6")]
	[Address(RVA = "0xE799B0", Offset = "0xE78BB0", VA = "0x180E799B0")]
	public static bool isAssetBundleFile(byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60010E7")]
	[Address(RVA = "0xE78B40", Offset = "0xE77D40", VA = "0x180E78B40")]
	public static bool IsPNGFile(byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60010E8")]
	[Address(RVA = "0xE79460", Offset = "0xE78660", VA = "0x180E79460")]
	private static void descramble(byte[] src, int ofs, byte[] dst)
	{
	}

	[Token(Token = "0x60010E9")]
	[Address(RVA = "0xE79080", Offset = "0xE78280", VA = "0x180E79080")]
	private static bool checkCompressed(byte[] data)
	{
		return default(bool);
	}

	[Token(Token = "0x60010EA")]
	[Address(RVA = "0xE791D0", Offset = "0xE783D0", VA = "0x180E791D0")]
	public static byte[] decompressedData(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x60010EB")]
	[Address(RVA = "0xE793F0", Offset = "0xE785F0", VA = "0x180E793F0")]
	public static byte[] decompressedData(TextAsset textasset)
	{
		return null;
	}

	[Token(Token = "0x60010EC")]
	[Address(RVA = "0xE79150", Offset = "0xE78350", VA = "0x180E79150")]
	public static bool compareHeader(byte[] a, byte[] b, int length)
	{
		return default(bool);
	}

	[Token(Token = "0x60010ED")]
	[Address(RVA = "0xE77C30", Offset = "0xE76E30", VA = "0x180E77C30")]
	public static bool ExistsDownloadFile(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60010EE")]
	[Address(RVA = "0xE78E70", Offset = "0xE78070", VA = "0x180E78E70")]
	public static void UnloadResource(Resource res)
	{
	}

	[Token(Token = "0x60010EF")]
	[Address(RVA = "0xE78CF0", Offset = "0xE77EF0", VA = "0x180E78CF0")]
	private static void UnloadAsset(Object obj)
	{
	}

	[Token(Token = "0x60010F0")]
	[Address(RVA = "0xE78730", Offset = "0xE77930", VA = "0x180E78730")]
	public static uint GetCrc(string path)
	{
		return default(uint);
	}

	[Token(Token = "0x60010F1")]
	[Address(RVA = "0xE77860", Offset = "0xE76A60", VA = "0x180E77860")]
	public static bool ContainConvertPath(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60010F2")]
	[Address(RVA = "0xE779D0", Offset = "0xE76BD0", VA = "0x180E779D0")]
	public static bool ContainLangPath(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60010F3")]
	[Address(RVA = "0xE77A20", Offset = "0xE76C20", VA = "0x180E77A20")]
	public static bool ContainPlatformPath(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60010F4")]
	[Address(RVA = "0xE77A70", Offset = "0xE76C70", VA = "0x180E77A70")]
	public static bool ContainResourceTypePath(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60010F5")]
	[Address(RVA = "0xE77810", Offset = "0xE76A10", VA = "0x180E77810")]
	public static bool ContainCardIllustTypePath(string path)
	{
		return default(bool);
	}

	[Token(Token = "0x60010F6")]
	[Address(RVA = "0xE78C10", Offset = "0xE77E10", VA = "0x180E78C10")]
	public static string RemoveAutoConvertPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60010F7")]
	[Address(RVA = "0xE77CC0", Offset = "0xE76EC0", VA = "0x180E77CC0")]
	public static List<string> GetAllConvertAutoPathList(string path)
	{
		return null;
	}

	[Token(Token = "0x60010F8")]
	[Address(RVA = "0xE77AC0", Offset = "0xE76CC0", VA = "0x180E77AC0")]
	public static string ConvertAutoPath(string path)
	{
		return null;
	}

	[Token(Token = "0x60010F9")]
	[Address(RVA = "0xE78AF0", Offset = "0xE77CF0", VA = "0x180E78AF0")]
	public static bool IsDataDivideByLang()
	{
		return default(bool);
	}

	[Token(Token = "0x60010FA")]
	[Address(RVA = "0xE78910", Offset = "0xE77B10", VA = "0x180E78910")]
	private static string GetPlatformDirectory()
	{
		return null;
	}

	[Token(Token = "0x60010FB")]
	[Address(RVA = "0xE78A30", Offset = "0xE77C30", VA = "0x180E78A30")]
	private static string GetResourceTypeDirectory()
	{
		return null;
	}

	[Token(Token = "0x60010FC")]
	[Address(RVA = "0xE78990", Offset = "0xE77B90", VA = "0x180E78990")]
	private static string GetPlatformTypeDirectory()
	{
		return null;
	}
}
