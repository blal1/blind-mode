using System;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EF2")]
public class KeyValueList
{
	[Token(Token = "0x400A579")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x400A57A")]
	[FieldOffset(Offset = "0x18")]
	public string[] value;

	[Token(Token = "0x6005AA5")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	public KeyValueList(string key, string[] value)
	{
	}
}
