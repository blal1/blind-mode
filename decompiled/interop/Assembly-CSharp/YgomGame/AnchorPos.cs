using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame;

[Token(Token = "0x20006DD")]
public class AnchorPos
{
	[Token(Token = "0x4002288")]
	[FieldOffset(Offset = "0x10")]
	public float x;

	[Token(Token = "0x4002289")]
	[FieldOffset(Offset = "0x14")]
	public float y;

	[Token(Token = "0x400228A")]
	[FieldOffset(Offset = "0x18")]
	public float z;

	[Token(Token = "0x6002DD1")]
	[Address(RVA = "0x718EA0", Offset = "0x7180A0", VA = "0x180718EA0")]
	public AnchorPos(float x, float y, float z)
	{
	}

	[Token(Token = "0x6002DD2")]
	[Address(RVA = "0x718EF0", Offset = "0x7180F0", VA = "0x180718EF0")]
	public AnchorPos(Vector3 vector)
	{
	}
}
