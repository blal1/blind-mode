using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001A0D")]
internal struct ChainIndo
{
	[Token(Token = "0x400F06B")]
	[FieldOffset(Offset = "0x0")]
	public Transform chainhead;

	[Token(Token = "0x400F06C")]
	[FieldOffset(Offset = "0x8")]
	public float unitlength;

	[Token(Token = "0x400F06D")]
	[FieldOffset(Offset = "0x10")]
	public Stack<Transform> chainstack;

	[Token(Token = "0x400F06E")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 srcpos;

	[Token(Token = "0x400F06F")]
	[FieldOffset(Offset = "0x24")]
	public Vector3 dstpos;

	[Token(Token = "0x170019F2")]
	public Vector3 currentpos
	{
		[Token(Token = "0x600A869")]
		[Address(RVA = "0xF441E0", Offset = "0xF433E0", VA = "0x180F441E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Token(Token = "0x170019F3")]
	public float currentlength
	{
		[Token(Token = "0x600A86A")]
		[Address(RVA = "0xF44190", Offset = "0xF43390", VA = "0x180F44190")]
		get
		{
			return default(float);
		}
	}

	[Token(Token = "0x600A86B")]
	[Address(RVA = "0xF440B0", Offset = "0xF432B0", VA = "0x180F440B0")]
	public ChainIndo(Transform chainhead, float unitlength, Vector3 srcpos, Vector3 dstpos)
	{
	}
}
