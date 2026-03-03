using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x200016D")]
public class SimpleCrypto
{
	[Token(Token = "0x200016E")]
	private class SysRand
	{
		[Token(Token = "0x40008A1")]
		private const int MBIG = 2147483647;

		[Token(Token = "0x40008A2")]
		private const int MSEED = 161803398;

		[Token(Token = "0x40008A3")]
		[FieldOffset(Offset = "0x10")]
		private int inext;

		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0x14")]
		private int inextp;

		[Token(Token = "0x40008A5")]
		[FieldOffset(Offset = "0x18")]
		private int[] seedArray;

		[Token(Token = "0x6000945")]
		[Address(RVA = "0xB09800", Offset = "0xB08A00", VA = "0x180B09800")]
		public SysRand(int Seed)
		{
		}

		[Token(Token = "0x6000946")]
		[Address(RVA = "0xB096C0", Offset = "0xB088C0", VA = "0x180B096C0")]
		public int Next(int minValue, int maxValue)
		{
			return default(int);
		}

		[Token(Token = "0x6000947")]
		[Address(RVA = "0xB09770", Offset = "0xB08970", VA = "0x180B09770")]
		private double Sample()
		{
			return default(double);
		}
	}

	[Token(Token = "0x6000943")]
	[Address(RVA = "0xB04890", Offset = "0xB03A90", VA = "0x180B04890")]
	public static void Encrypt(ref byte[] data, string key)
	{
	}

	[Token(Token = "0x6000944")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SimpleCrypto()
	{
	}
}
