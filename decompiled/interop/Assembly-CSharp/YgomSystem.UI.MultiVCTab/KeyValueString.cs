using System;
using Il2CppDummyDll;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005D5")]
public class KeyValueString
{
	[Token(Token = "0x4001C01")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x4001C02")]
	[FieldOffset(Offset = "0x18")]
	public string value;

	[Token(Token = "0x6002631")]
	[Address(RVA = "0x5FF240", Offset = "0x5FE440", VA = "0x1805FF240")]
	public KeyValueString(string key, string value)
	{
	}
}
