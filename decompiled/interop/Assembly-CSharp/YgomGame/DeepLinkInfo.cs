using Il2CppDummyDll;

namespace YgomGame;

[Token(Token = "0x20006C2")]
public static class DeepLinkInfo
{
	[Token(Token = "0x40021F6")]
	[FieldOffset(Offset = "0x0")]
	private static bool m_isInitialize;

	[Token(Token = "0x17000589")]
	public static bool isAvailable
	{
		[Token(Token = "0x6002D1C")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x6002D17")]
	[Address(RVA = "0x7036A0", Offset = "0x7028A0", VA = "0x1807036A0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6002D18")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void activateUrl(string url)
	{
	}

	[Token(Token = "0x6002D19")]
	[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70")]
	public static bool SetUrl(string url)
	{
		return default(bool);
	}

	[Token(Token = "0x6002D1A")]
	[Address(RVA = "0x703670", Offset = "0x702870", VA = "0x180703670")]
	public static string GetUrl()
	{
		return null;
	}

	[Token(Token = "0x6002D1B")]
	[Address(RVA = "0x703640", Offset = "0x702840", VA = "0x180703640")]
	public static string GetDestination()
	{
		return null;
	}

	[Token(Token = "0x6002D1D")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Clear()
	{
	}

	[Token(Token = "0x6002D1E")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Abort()
	{
	}
}
