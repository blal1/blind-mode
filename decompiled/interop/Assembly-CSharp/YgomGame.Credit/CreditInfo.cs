using System;
using Il2CppDummyDll;

namespace YgomGame.Credit;

[Serializable]
[Token(Token = "0x2001133")]
public class CreditInfo
{
	[Token(Token = "0x400B570")]
	[FieldOffset(Offset = "0x10")]
	public string group;

	[Token(Token = "0x400B571")]
	[FieldOffset(Offset = "0x18")]
	public string position;

	[Token(Token = "0x400B572")]
	[FieldOffset(Offset = "0x20")]
	public string name;

	[Token(Token = "0x400B573")]
	[FieldOffset(Offset = "0x28")]
	public string name2;

	[Token(Token = "0x400B574")]
	[FieldOffset(Offset = "0x30")]
	public int nameNum;

	[Token(Token = "0x6006BD9")]
	[Address(RVA = "0xB2A490", Offset = "0xB29690", VA = "0x180B2A490")]
	public CreditInfo()
	{
	}

	[Token(Token = "0x6006BDA")]
	[Address(RVA = "0xB2A5A0", Offset = "0xB297A0", VA = "0x180B2A5A0")]
	public CreditInfo(string group, string position, string name)
	{
	}

	[Token(Token = "0x6006BDB")]
	[Address(RVA = "0xB2A390", Offset = "0xB29590", VA = "0x180B2A390")]
	public CreditInfo(string group, string position, string name, string name2)
	{
	}

	[Token(Token = "0x6006BDC")]
	[Address(RVA = "0xB2A290", Offset = "0xB29490", VA = "0x180B2A290")]
	public CreditInfo(string group, string position, string name, string name2, int nameNum)
	{
	}
}
