using System;
using Il2CppDummyDll;

namespace YgomGame.Movie;

[Serializable]
[Token(Token = "0x20016C4")]
public struct Marker
{
	[Token(Token = "0x400D866")]
	[FieldOffset(Offset = "0x0")]
	public double second;

	[Token(Token = "0x400D867")]
	[FieldOffset(Offset = "0x8")]
	public string comment;

	[Token(Token = "0x6008DA5")]
	[Address(RVA = "0xD7A5D0", Offset = "0xD797D0", VA = "0x180D7A5D0")]
	public Marker(double second, string comment)
	{
	}
}
