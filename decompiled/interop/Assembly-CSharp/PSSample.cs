using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200001C")]
public class PSSample : MonoBehaviour
{
	[Token(Token = "0x400007F")]
	[FieldOffset(Offset = "0x0")]
	public static string[] samples;

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x20")]
	public Text text;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x28")]
	private int idx;

	[Token(Token = "0x6000089")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	private void Start()
	{
	}

	[Token(Token = "0x600008A")]
	[Address(RVA = "0x3E3350", Offset = "0x3E2550", VA = "0x1803E3350")]
	private void Update()
	{
	}

	[Token(Token = "0x600008B")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public PSSample()
	{
	}
}
