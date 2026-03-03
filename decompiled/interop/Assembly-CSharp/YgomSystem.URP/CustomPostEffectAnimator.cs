using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.URP;

[Token(Token = "0x2000316")]
[ExecuteAlways]
[RequireComponent(typeof(SpriteRenderer))]
public class CustomPostEffectAnimator : MonoBehaviour
{
	[Token(Token = "0x40010F1")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	private CustomPostEffectRegister m_Register;

	[Token(Token = "0x600134E")]
	[Address(RVA = "0x4049B0", Offset = "0x403BB0", VA = "0x1804049B0")]
	private void Start()
	{
	}

	[Token(Token = "0x600134F")]
	[Address(RVA = "0x4048D0", Offset = "0x403AD0", VA = "0x1804048D0")]
	private void LateUpdate()
	{
	}

	[Token(Token = "0x6001350")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public CustomPostEffectAnimator()
	{
	}
}
