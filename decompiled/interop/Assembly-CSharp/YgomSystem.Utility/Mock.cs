using System;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Serializable]
[Token(Token = "0x20003ED")]
public class Mock
{
	[Token(Token = "0x40013A8")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x40013A9")]
	[FieldOffset(Offset = "0x18")]
	public string default_url;

	[Token(Token = "0x40013AA")]
	[FieldOffset(Offset = "0x20")]
	public string default_url_polling;

	[Token(Token = "0x6001935")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public Mock()
	{
	}
}
