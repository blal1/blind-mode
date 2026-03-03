using System;
using Il2CppDummyDll;
using UnityEngine;

[Serializable]
[Token(Token = "0x200008D")]
public struct ThumbPath
{
	[Token(Token = "0x40002DF")]
	[FieldOffset(Offset = "0x0")]
	public int gateID;

	[Token(Token = "0x40002E0")]
	[FieldOffset(Offset = "0x8")]
	public string path;

	[Token(Token = "0x40002E1")]
	[FieldOffset(Offset = "0x10")]
	[Tooltip("サイズは2のべき乗にすること")]
	public Vector2 textureSize;
}
