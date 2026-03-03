using Il2CppDummyDll;
using UnityEngine;

namespace YgomGame.Duel;

[Token(Token = "0x2001932")]
public class AffectRelativeEffect : SimpleEffect
{
	[Token(Token = "0x400EAFF")]
	[FieldOffset(Offset = "0xB0")]
	private MeshRenderer meshRenderer;

	[Token(Token = "0x600A27D")]
	[Address(RVA = "0xEE6F60", Offset = "0xEE6160", VA = "0x180EE6F60")]
	private void Awake()
	{
	}

	[Token(Token = "0x600A27E")]
	[Address(RVA = "0xEE6FB0", Offset = "0xEE61B0", VA = "0x180EE6FB0")]
	public void SetTexture(Engine.AffectType affectType)
	{
	}

	[Token(Token = "0x600A27F")]
	[Address(RVA = "0xEE7170", Offset = "0xEE6370", VA = "0x180EE7170")]
	public AffectRelativeEffect()
	{
	}
}
