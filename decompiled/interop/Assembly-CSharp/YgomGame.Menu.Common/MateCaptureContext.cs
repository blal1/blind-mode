using System;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Menu.Common;

[Serializable]
[Token(Token = "0x2001483")]
public class MateCaptureContext
{
	[Token(Token = "0x400C6AF")]
	[FieldOffset(Offset = "0x10")]
	public int mateId;

	[Token(Token = "0x400C6B0")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 position;

	[Token(Token = "0x400C6B1")]
	[FieldOffset(Offset = "0x20")]
	public Quaternion rotate;

	[Token(Token = "0x400C6B2")]
	[FieldOffset(Offset = "0x30")]
	public Vector3 scale;

	[Token(Token = "0x400C6B3")]
	[FieldOffset(Offset = "0x40")]
	public string settingPath;

	[Token(Token = "0x400C6B4")]
	[FieldOffset(Offset = "0x48")]
	public GameObject locator;

	[Token(Token = "0x400C6B5")]
	[FieldOffset(Offset = "0x50")]
	public int width;

	[Token(Token = "0x400C6B6")]
	[FieldOffset(Offset = "0x54")]
	public int height;

	[Token(Token = "0x6007F73")]
	[Address(RVA = "0xC76560", Offset = "0xC75760", VA = "0x180C76560", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6007F74")]
	[Address(RVA = "0x58A430", Offset = "0x589630", VA = "0x18058A430", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6007F75")]
	[Address(RVA = "0xC76790", Offset = "0xC75990", VA = "0x180C76790")]
	public MateCaptureContext()
	{
	}
}
