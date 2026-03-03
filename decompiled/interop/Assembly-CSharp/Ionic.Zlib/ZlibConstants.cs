using Il2CppDummyDll;

namespace Ionic.Zlib;

[Token(Token = "0x20000E3")]
public static class ZlibConstants
{
	[Token(Token = "0x4000533")]
	public const int WindowBitsMax = 15;

	[Token(Token = "0x4000534")]
	public const int WindowBitsDefault = 15;

	[Token(Token = "0x4000535")]
	public const int Z_OK = 0;

	[Token(Token = "0x4000536")]
	public const int Z_STREAM_END = 1;

	[Token(Token = "0x4000537")]
	public const int Z_NEED_DICT = 2;

	[Token(Token = "0x4000538")]
	public const int Z_STREAM_ERROR = -2;

	[Token(Token = "0x4000539")]
	public const int Z_DATA_ERROR = -3;

	[Token(Token = "0x400053A")]
	public const int Z_BUF_ERROR = -5;

	[Token(Token = "0x400053B")]
	public const int WorkingBufferSizeDefault = 16384;

	[Token(Token = "0x400053C")]
	public const int WorkingBufferSizeMin = 1024;
}
