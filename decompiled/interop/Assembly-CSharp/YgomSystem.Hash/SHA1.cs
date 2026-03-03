using System.IO;
using Il2CppDummyDll;

namespace YgomSystem.Hash;

[Token(Token = "0x200029E")]
public class SHA1
{
	[Token(Token = "0x4000EE0")]
	[FieldOffset(Offset = "0x0")]
	private static readonly int CHUNK_SIZE;

	[Token(Token = "0x6000FE0")]
	[Address(RVA = "0xE7A610", Offset = "0xE79810", VA = "0x180E7A610")]
	public static string ToString(byte[] sha)
	{
		return null;
	}

	[Token(Token = "0x6000FE1")]
	[Address(RVA = "0xE7A2D0", Offset = "0xE794D0", VA = "0x180E7A2D0")]
	public static byte[] GetBinaryStreamSHA1(BinaryReader br, long dataLength)
	{
		return null;
	}

	[Token(Token = "0x6000FE2")]
	[Address(RVA = "0xE7A010", Offset = "0xE79210", VA = "0x180E7A010")]
	public static byte[] GetBinarySHA1(byte[] data)
	{
		return null;
	}

	[Token(Token = "0x6000FE3")]
	[Address(RVA = "0xE7A580", Offset = "0xE79780", VA = "0x180E7A580")]
	public static byte[] GetStringSHA1(string str)
	{
		return null;
	}

	[Token(Token = "0x6000FE4")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SHA1()
	{
	}
}
