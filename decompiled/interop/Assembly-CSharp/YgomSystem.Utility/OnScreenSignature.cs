using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F2")]
public class OnScreenSignature : MonoBehaviour
{
	[Token(Token = "0x40013B4")]
	[FieldOffset(Offset = "0x0")]
	public static OnScreenSignature instance;

	[Token(Token = "0x40013B5")]
	[FieldOffset(Offset = "0x20")]
	private SpriteRenderer spriteRenderer;

	[Token(Token = "0x40013B6")]
	[FieldOffset(Offset = "0x28")]
	private bool m_isInitialized;

	[Token(Token = "0x6001944")]
	[Address(RVA = "0x5D1900", Offset = "0x5D0B00", VA = "0x1805D1900")]
	private void Start()
	{
	}

	[Token(Token = "0x6001945")]
	[Address(RVA = "0x5D14B0", Offset = "0x5D06B0", VA = "0x1805D14B0")]
	public void SetEnabled(bool enabled)
	{
	}

	[Token(Token = "0x6001946")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public OnScreenSignature()
	{
	}
}
