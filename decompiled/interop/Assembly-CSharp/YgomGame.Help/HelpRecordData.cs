using System;
using Il2CppDummyDll;

namespace YgomGame.Help;

[Serializable]
[Token(Token = "0x2000D90")]
public class HelpRecordData
{
	[Token(Token = "0x4009F3A")]
	[FieldOffset(Offset = "0x10")]
	public string label;

	[Token(Token = "0x4009F3B")]
	[FieldOffset(Offset = "0x18")]
	public string titleTid;

	[Token(Token = "0x4009F3C")]
	[FieldOffset(Offset = "0x20")]
	public string path;

	[Token(Token = "0x4009F3D")]
	[FieldOffset(Offset = "0x28")]
	public string requireCW;

	[Token(Token = "0x600518C")]
	[Address(RVA = "0x990460", Offset = "0x98F660", VA = "0x180990460")]
	public bool Validate()
	{
		return default(bool);
	}

	[Token(Token = "0x600518D")]
	[Address(RVA = "0x9904D0", Offset = "0x98F6D0", VA = "0x1809904D0")]
	public HelpRecordData()
	{
	}
}
