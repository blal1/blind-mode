using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.CameraSystem;

[Token(Token = "0x200032D")]
public class CameraSetUpper : MonoBehaviour
{
	[Token(Token = "0x400115D")]
	[FieldOffset(Offset = "0x20")]
	public float depth;

	[Token(Token = "0x400115E")]
	[FieldOffset(Offset = "0x24")]
	public bool allowHDR;

	[Token(Token = "0x400115F")]
	[FieldOffset(Offset = "0x25")]
	public bool allowMSAA;

	[Token(Token = "0x60013DC")]
	[Address(RVA = "0x521370", Offset = "0x520570", VA = "0x180521370")]
	public void Start()
	{
	}

	[Token(Token = "0x60013DD")]
	[Address(RVA = "0x521370", Offset = "0x520570", VA = "0x180521370")]
	public void Setup()
	{
	}

	[Token(Token = "0x60013DE")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CameraSetUpper()
	{
	}
}
