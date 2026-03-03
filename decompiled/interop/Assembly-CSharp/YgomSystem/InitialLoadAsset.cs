using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200015E")]
public class InitialLoadAsset
{
	[Token(Token = "0x4000833")]
	[FieldOffset(Offset = "0x0")]
	private static bool s_isLoaded;

	[Token(Token = "0x4000834")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string[] kLoadList;

	[Token(Token = "0x60008AB")]
	[Address(RVA = "0xAF81A0", Offset = "0xAF73A0", VA = "0x180AF81A0")]
	public static void Load()
	{
	}

	[Token(Token = "0x60008AC")]
	[Address(RVA = "0xAF80E0", Offset = "0xAF72E0", VA = "0x180AF80E0")]
	public static bool IsLoaded()
	{
		return default(bool);
	}

	[Token(Token = "0x60008AD")]
	[Address(RVA = "0xAF82B0", Offset = "0xAF74B0", VA = "0x180AF82B0")]
	public static void Unload()
	{
	}

	[Token(Token = "0x60008AE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public InitialLoadAsset()
	{
	}
}
