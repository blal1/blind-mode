using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UI;

[Token(Token = "0x20000BC")]
[AddComponentMenu("UI/Effects/Text Vertex Gradation", 15)]
[RequireComponent(typeof(Text))]
public class TextVertexGradation : BaseMeshEffect
{
	[Token(Token = "0x20000BD")]
	public enum Direction
	{
		[Token(Token = "0x40003D1")]
		UpToBottom,
		[Token(Token = "0x40003D2")]
		BottomToUp,
		[Token(Token = "0x40003D3")]
		LeftToRight,
		[Token(Token = "0x40003D4")]
		RightToLeft
	}

	[Token(Token = "0x40003CC")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	public Color color;

	[Token(Token = "0x40003CD")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	public Direction direction;

	[Token(Token = "0x40003CE")]
	private const int VERTLEN = 6;

	[Token(Token = "0x40003CF")]
	[FieldOffset(Offset = "0x40")]
	private int[] gradBit;

	[Token(Token = "0x600036F")]
	[Address(RVA = "0x681DD0", Offset = "0x680FD0", VA = "0x180681DD0")]
	public void ModifyVertices(List<UIVertex> verts)
	{
	}

	[Token(Token = "0x6000370")]
	[Address(RVA = "0x681B60", Offset = "0x680D60", VA = "0x180681B60", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x6000371")]
	[Address(RVA = "0x681FA0", Offset = "0x6811A0", VA = "0x180681FA0")]
	public TextVertexGradation()
	{
	}
}
