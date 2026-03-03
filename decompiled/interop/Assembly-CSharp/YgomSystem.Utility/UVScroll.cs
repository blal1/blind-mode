using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003D6")]
public class UVScroll : MonoBehaviour
{
	[Token(Token = "0x4001357")]
	[FieldOffset(Offset = "0x20")]
	public float offsetU;

	[Token(Token = "0x4001358")]
	[FieldOffset(Offset = "0x24")]
	public float offsetV;

	[Token(Token = "0x4001359")]
	[FieldOffset(Offset = "0x28")]
	public bool isShared;

	[Token(Token = "0x400135A")]
	[FieldOffset(Offset = "0x30")]
	private Renderer rend;

	[Token(Token = "0x400135B")]
	[FieldOffset(Offset = "0x38")]
	private int propMainTex;

	[Token(Token = "0x6001894")]
	[Address(RVA = "0x5E1E70", Offset = "0x5E1070", VA = "0x1805E1E70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001895")]
	[Address(RVA = "0x5E1EE0", Offset = "0x5E10E0", VA = "0x1805E1EE0")]
	private void Update()
	{
	}

	[Token(Token = "0x6001896")]
	[Address(RVA = "0x5E2110", Offset = "0x5E1310", VA = "0x1805E2110")]
	public UVScroll()
	{
	}
}
