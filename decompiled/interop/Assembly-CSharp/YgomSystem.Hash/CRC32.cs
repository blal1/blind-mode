using System.IO;
using Il2CppDummyDll;

namespace YgomSystem.Hash;

[Token(Token = "0x200029D")]
public class CRC32
{
	[Token(Token = "0x4000EDD")]
	[FieldOffset(Offset = "0x0")]
	private static readonly uint[] CRC32Table;

	[Token(Token = "0x4000EDE")]
	[FieldOffset(Offset = "0x8")]
	private static readonly int CHAR_BIT;

	[Token(Token = "0x4000EDF")]
	[FieldOffset(Offset = "0xC")]
	private static readonly int CHUNK_SIZE;

	[Token(Token = "0x6000FDA")]
	[Address(RVA = "0xE6C640", Offset = "0xE6B840", VA = "0x180E6C640")]
	private static uint GetMemCRC32(uint crc32, byte[] data, int size)
	{
		return default(uint);
	}

	[Token(Token = "0x6000FDB")]
	[Address(RVA = "0xE6C530", Offset = "0xE6B730", VA = "0x180E6C530")]
	public static uint GetBinaryStreamCRC32(BinaryReader br)
	{
		return default(uint);
	}

	[Token(Token = "0x6000FDC")]
	[Address(RVA = "0xE6C720", Offset = "0xE6B920", VA = "0x180E6C720")]
	public static uint GetStringCRC32(string str)
	{
		return default(uint);
	}

	[Token(Token = "0x6000FDD")]
	[Address(RVA = "0xE6C4C0", Offset = "0xE6B6C0", VA = "0x180E6C4C0")]
	public static uint GetBinaryCRC32(byte[] data)
	{
		return default(uint);
	}

	[Token(Token = "0x6000FDE")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public CRC32()
	{
	}
}
