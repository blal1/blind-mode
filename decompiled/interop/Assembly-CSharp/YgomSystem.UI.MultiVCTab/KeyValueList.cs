using System;
using Il2CppDummyDll;

namespace YgomSystem.UI.MultiVCTab;

[Serializable]
[Token(Token = "0x20005D6")]
public class KeyValueList
{
	[Token(Token = "0x4001C03")]
	[FieldOffset(Offset = "0x10")]
	public string key;

	[Token(Token = "0x4001C04")]
	[FieldOffset(Offset = "0x18")]
	public string[] value;

	[Token(Token = "0x6002632")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public KeyValueList()
	{
	}
}
