using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003D5")]
public class SimpleRot : MonoBehaviour
{
	[Token(Token = "0x4001354")]
	[FieldOffset(Offset = "0x20")]
	public float rotX;

	[Token(Token = "0x4001355")]
	[FieldOffset(Offset = "0x24")]
	public float rotY;

	[Token(Token = "0x4001356")]
	[FieldOffset(Offset = "0x28")]
	public float rotZ;

	[Token(Token = "0x6001892")]
	[Address(RVA = "0x5D7740", Offset = "0x5D6940", VA = "0x1805D7740")]
	private void Update()
	{
	}

	[Token(Token = "0x6001893")]
	[Address(RVA = "0x5D77B0", Offset = "0x5D69B0", VA = "0x1805D77B0")]
	public SimpleRot()
	{
	}
}
