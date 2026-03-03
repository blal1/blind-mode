using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomGame.Bg;

[Token(Token = "0x2001D7E")]
public class ScreenPositionUV_Controller : MonoBehaviour
{
	[Token(Token = "0x4010419")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private Material m_OriginMat;

	[Token(Token = "0x401041A")]
	[FieldOffset(Offset = "0x28")]
	private Material m_TargetMat;

	[Token(Token = "0x401041B")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private List<Image> m_ImageList;

	[Token(Token = "0x600BD3B")]
	[Address(RVA = "0x58E1C0", Offset = "0x58D3C0", VA = "0x18058E1C0")]
	private void Awake()
	{
	}

	[Token(Token = "0x600BD3C")]
	[Address(RVA = "0x58E330", Offset = "0x58D530", VA = "0x18058E330")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x600BD3D")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public ScreenPositionUV_Controller()
	{
	}
}
