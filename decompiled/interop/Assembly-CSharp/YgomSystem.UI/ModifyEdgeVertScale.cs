using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x2000540")]
[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
public class ModifyEdgeVertScale : BaseMeshEffect
{
	[Token(Token = "0x4001988")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	private Vector2 m_UpperLeft;

	[Token(Token = "0x4001989")]
	[FieldOffset(Offset = "0x30")]
	[SerializeField]
	private Vector2 m_UpperRight;

	[Token(Token = "0x400198A")]
	[FieldOffset(Offset = "0x38")]
	[SerializeField]
	private Vector2 m_LowerLeft;

	[Token(Token = "0x400198B")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	private Vector2 m_LowerRight;

	[Token(Token = "0x400198C")]
	[FieldOffset(Offset = "0x48")]
	private List<UIVertex> m_VertsCache;

	[Token(Token = "0x6002229")]
	[Address(RVA = "0x64B080", Offset = "0x64A280", VA = "0x18064B080", Slot = "20")]
	public override void ModifyMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x600222A")]
	[Address(RVA = "0x64B650", Offset = "0x64A850", VA = "0x18064B650")]
	public ModifyEdgeVertScale()
	{
	}
}
