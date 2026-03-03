using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI;

[Token(Token = "0x20000B9")]
[AddComponentMenu("UI/Effects/OutlineDouble", 15)]
public class OutlineDouble : Shadow
{
	[Token(Token = "0x40003BB")]
	[FieldOffset(Offset = "0x48")]
	public Vector2 offset;

	[Token(Token = "0x40003BC")]
	[FieldOffset(Offset = "0x50")]
	public Color effectColor2;

	[Token(Token = "0x40003BD")]
	[FieldOffset(Offset = "0x60")]
	public Vector2 effectDistance2;

	[Token(Token = "0x600035E")]
	[Address(RVA = "0x67C240", Offset = "0x67B440", VA = "0x18067C240")]
	protected OutlineDouble()
	{
	}

	[Token(Token = "0x600035F")]
	[Address(RVA = "0x67C250", Offset = "0x67B450", VA = "0x18067C250", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000360")]
	[Address(RVA = "0x67C3B0", Offset = "0x67B5B0", VA = "0x18067C3B0")]
	private int addOutlineVerts(List<UIVertex> verts, int start, Color color, Vector2 ofs, Vector2 dist)
	{
		return default(int);
	}
}
