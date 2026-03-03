using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x200041A")]
public class TransformRouter : MonoBehaviour
{
	[Token(Token = "0x4001435")]
	[FieldOffset(Offset = "0x20")]
	public Transform routingTarget;

	[Token(Token = "0x4001436")]
	[FieldOffset(Offset = "0x28")]
	public bool routingPosX;

	[Token(Token = "0x4001437")]
	[FieldOffset(Offset = "0x29")]
	public bool routingPosY;

	[Token(Token = "0x4001438")]
	[FieldOffset(Offset = "0x2A")]
	public bool routingPosZ;

	[Token(Token = "0x4001439")]
	[FieldOffset(Offset = "0x2B")]
	public bool routingRotX;

	[Token(Token = "0x400143A")]
	[FieldOffset(Offset = "0x2C")]
	public bool routingRotY;

	[Token(Token = "0x400143B")]
	[FieldOffset(Offset = "0x2D")]
	public bool routingRotZ;

	[Token(Token = "0x400143C")]
	[FieldOffset(Offset = "0x2E")]
	public bool routingScaleX;

	[Token(Token = "0x400143D")]
	[FieldOffset(Offset = "0x2F")]
	public bool routingScaleY;

	[Token(Token = "0x400143E")]
	[FieldOffset(Offset = "0x30")]
	public bool routingScaleZ;

	[Token(Token = "0x6001A7D")]
	[Address(RVA = "0x5F0BB0", Offset = "0x5EFDB0", VA = "0x1805F0BB0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001A7E")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TransformRouter()
	{
	}
}
