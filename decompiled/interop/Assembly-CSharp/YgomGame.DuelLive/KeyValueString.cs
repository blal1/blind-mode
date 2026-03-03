using System;
using Il2CppDummyDll;

namespace YgomGame.DuelLive;

[Serializable]
[Token(Token = "0x2000EF1")]
public class KeyValueString
{
	[Token(Token = "0x400A577")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x400A578")]
	[FieldOffset(Offset = "0x18")]
	public string value;

	[Token(Token = "0x6005AA4")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	public KeyValueString(string key, string value)
	{
	}
}
