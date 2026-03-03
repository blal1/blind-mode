using System;
using Il2CppDummyDll;

namespace YgomGame.Tdy;

[Token(Token = "0x2000850")]
public static class KizunaID
{
	[Token(Token = "0x40085D4")]
	public const int None = 0;

	[Token(Token = "0x40085D5")]
	public const int Base = 1;

	[Token(Token = "0x40085D6")]
	public const int Num = 4;

	[Token(Token = "0x40085D7")]
	public const int Green = 1;

	[Token(Token = "0x40085D8")]
	public const int Yellow = 2;

	[Token(Token = "0x40085D9")]
	public const int Red = 3;

	[Token(Token = "0x40085DA")]
	public const int Orange = 4;

	[Token(Token = "0x60032A5")]
	[Address(RVA = "0x74F830", Offset = "0x74EA30", VA = "0x18074F830")]
	public static bool isValid(int id)
	{
		return default(bool);
	}

	[Token(Token = "0x60032A6")]
	[Address(RVA = "0x74F7F0", Offset = "0x74E9F0", VA = "0x18074F7F0")]
	public static void ForEach(Action<int> callback)
	{
	}
}
