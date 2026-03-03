using Il2CppDummyDll;

namespace YgomGame.Duel;

[Token(Token = "0x2001915")]
internal static class BITDEF_STD
{
	[Token(Token = "0x400EA7D")]
	public const int SHIFT_PLAYERIDC = 0;

	[Token(Token = "0x400EA7E")]
	public const int SHIFT_TURN = 32;

	[Token(Token = "0x400EA7F")]
	public const int SHIFT_PLAYERIDL = 0;

	[Token(Token = "0x400EA80")]
	public const int SHIFT_PLAYERIDR = 16;

	[Token(Token = "0x400EA81")]
	public const uint BYTEMASK = 255u;

	[Token(Token = "0x400EA82")]
	public const uint SHORTMASK = 65535u;

	[Token(Token = "0x400EA83")]
	public const uint INTMASK = 4294967295u;

	[Token(Token = "0x600A1B3")]
	[Address(RVA = "0xEE88C0", Offset = "0xEE7AC0", VA = "0x180EE88C0")]
	public static void SetBitData(ref ulong bitdata, int value, int shift)
	{
	}

	[Token(Token = "0x600A1B4")]
	[Address(RVA = "0xEE88E0", Offset = "0xEE7AE0", VA = "0x180EE88E0")]
	public static void SetBitData(ref uint bitdata, int value, int shift)
	{
	}

	[Token(Token = "0x600A1B5")]
	[Address(RVA = "0xEE88B0", Offset = "0xEE7AB0", VA = "0x180EE88B0")]
	public static byte GetByteData(ulong bitdata, int shift)
	{
		return default(byte);
	}

	[Token(Token = "0x600A1B6")]
	[Address(RVA = "0xEE88B0", Offset = "0xEE7AB0", VA = "0x180EE88B0")]
	public static short GetShortData(ulong bitdata, int shift)
	{
		return default(short);
	}

	[Token(Token = "0x600A1B7")]
	[Address(RVA = "0x798B20", Offset = "0x797D20", VA = "0x180798B20")]
	public static byte GetByteData(uint bitdata, int shift)
	{
		return default(byte);
	}

	[Token(Token = "0x600A1B8")]
	[Address(RVA = "0x798B20", Offset = "0x797D20", VA = "0x180798B20")]
	public static short GetShortData(uint bitdata, int shift)
	{
		return default(short);
	}

	[Token(Token = "0x600A1B9")]
	[Address(RVA = "0xEE88B0", Offset = "0xEE7AB0", VA = "0x180EE88B0")]
	public static int GetIntData(ulong bitdata, int shift)
	{
		return default(int);
	}
}
