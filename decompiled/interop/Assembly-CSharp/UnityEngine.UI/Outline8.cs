using Il2CppDummyDll;

namespace UnityEngine.UI;

[Token(Token = "0x20000B8")]
[AddComponentMenu("UI/Effects/Outline8", 15)]
public class Outline8 : Shadow
{
	[Token(Token = "0x40003BA")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 offset;

	[Token(Token = "0x600035C")]
	[Address(RVA = "0x67C240", Offset = "0x67B440", VA = "0x18067C240")]
	protected Outline8()
	{
	}

	[Token(Token = "0x600035D")]
	[Address(RVA = "0x67BDD0", Offset = "0x67AFD0", VA = "0x18067BDD0", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}
}
