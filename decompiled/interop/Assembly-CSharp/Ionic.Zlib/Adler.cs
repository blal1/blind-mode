using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000DE")]
public sealed class Adler
{
	[Token(Token = "0x400050D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly uint BASE;

	[Token(Token = "0x400050E")]
	[FieldOffset(Offset = "0x4")]
	private static readonly int NMAX;

	[Token(Token = "0x60003FC")]
	[Address(RVA = "0x77F770", Offset = "0x77E970", VA = "0x18077F770")]
	public static uint Adler32(uint adler, byte[] buf, int index, int len)
	{
		return default(uint);
	}

	[Token(Token = "0x60003FD")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Adler()
	{
	}
}
