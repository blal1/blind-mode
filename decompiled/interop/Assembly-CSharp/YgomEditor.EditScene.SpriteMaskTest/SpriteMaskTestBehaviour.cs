using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomEditor.EditScene.SpriteMaskTest;

[Token(Token = "0x2000120")]
[ExecuteAlways]
public class SpriteMaskTestBehaviour : MonoBehaviour
{
	[Token(Token = "0x40006BE")]
	[FieldOffset(Offset = "0x20")]
	[Header("InnerParams")]
	[SerializeField]
	private Vector2 m_RectSize;

	[Token(Token = "0x40006BF")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 m_SpriteSize;

	[Token(Token = "0x40006C0")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 m_SpriteNativeSize;

	[Token(Token = "0x40006C1")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector4 m_BorderSize;

	[Token(Token = "0x40006C2")]
	[FieldOffset(Offset = "0x48")]
	[SerializeField]
	private Vector4 m_BorderNativeSize;

	[Token(Token = "0x40006C3")]
	[FieldOffset(Offset = "0x58")]
	[Header("MatParams")]
	[SerializeField]
	private Vector2 m_BorderScale;

	[Token(Token = "0x40006C4")]
	[FieldOffset(Offset = "0x60")]
	[SerializeField]
	private Vector2 m_BorderPos;

	[Token(Token = "0x40006C5")]
	[FieldOffset(Offset = "0x68")]
	[SerializeField]
	private Vector4 m_BorderMask;

	[Token(Token = "0x40006C6")]
	[FieldOffset(Offset = "0x78")]
	[SerializeField]
	private Vector2 m_CenterScale;

	[Token(Token = "0x40006C7")]
	[FieldOffset(Offset = "0x80")]
	[SerializeField]
	private Vector2 m_CenterPos;

	[Token(Token = "0x40006C8")]
	[FieldOffset(Offset = "0x88")]
	[SerializeField]
	private Vector2 m_MainTexScale;

	[Token(Token = "0x40006C9")]
	[FieldOffset(Offset = "0x90")]
	[SerializeField]
	private Vector4 m_MainTexMinMax;

	[Token(Token = "0x40006CA")]
	[FieldOffset(Offset = "0xA0")]
	private Image m_Image;

	[Token(Token = "0x170000A0")]
	private Image image
	{
		[Token(Token = "0x600071C")]
		[Address(RVA = "0x9E5B70", Offset = "0x9E4D70", VA = "0x1809E5B70")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600071D")]
	[Address(RVA = "0x9E5600", Offset = "0x9E4800", VA = "0x1809E5600")]
	private void Update()
	{
	}

	[Token(Token = "0x600071E")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public SpriteMaskTestBehaviour()
	{
	}
}
