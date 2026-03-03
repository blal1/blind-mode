using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.UI;

[Token(Token = "0x200055E")]
[ExecuteAlways]
[RequireComponent(typeof(CanvasRenderer))]
[RequireComponent(typeof(RectTransform))]
[RequireComponent(typeof(ParticleSystem))]
public class UGUIParticle : MaskableGraphic
{
	[Token(Token = "0x4001A21")]
	[FieldOffset(Offset = "0xE0")]
	private Camera m_RenderCameraCache;

	[Token(Token = "0x4001A22")]
	[FieldOffset(Offset = "0xE8")]
	private ParticleSystemRenderer m_ParticleSystemRendererCache;

	[Token(Token = "0x4001A23")]
	[FieldOffset(Offset = "0xF0")]
	private Mesh m_Mesh;

	[Token(Token = "0x4001A24")]
	[FieldOffset(Offset = "0xF8")]
	private List<Vector3> m_Vertices;

	[Token(Token = "0x4001A25")]
	[FieldOffset(Offset = "0x100")]
	private List<Vector3> m_UVs;

	[Token(Token = "0x4001A26")]
	[FieldOffset(Offset = "0x108")]
	private List<int> m_Triangles;

	[Token(Token = "0x4001A27")]
	[FieldOffset(Offset = "0x110")]
	private List<Color32> m_Colors32;

	[Token(Token = "0x170003B5")]
	private Camera renderCamera
	{
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x6581C0", Offset = "0x6573C0", VA = "0x1806581C0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B6")]
	public ParticleSystemRenderer particleSystemRenderer
	{
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x658120", Offset = "0x657320", VA = "0x180658120")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B7")]
	public override Texture mainTexture
	{
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x657EE0", Offset = "0x6570E0", VA = "0x180657EE0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170003B8")]
	public override Material material
	{
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x657FE0", Offset = "0x6571E0", VA = "0x180657FE0", Slot = "32")]
		get
		{
			return null;
		}
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x6582A0", Offset = "0x6574A0", VA = "0x1806582A0", Slot = "33")]
		set
		{
		}
	}

	[Token(Token = "0x60022D3")]
	[Address(RVA = "0x657D20", Offset = "0x656F20", VA = "0x180657D20", Slot = "6")]
	protected override void Start()
	{
	}

	[Token(Token = "0x60022D4")]
	[Address(RVA = "0x657EB0", Offset = "0x6570B0", VA = "0x180657EB0")]
	private void Update()
	{
	}

	[Token(Token = "0x60022D5")]
	[Address(RVA = "0x657770", Offset = "0x656970", VA = "0x180657770", Slot = "44")]
	protected override void OnPopulateMesh(VertexHelper vh)
	{
	}

	[Token(Token = "0x60022D6")]
	[Address(RVA = "0x657710", Offset = "0x656910", VA = "0x180657710", Slot = "13")]
	protected override void OnDidApplyAnimationProperties()
	{
	}

	[Token(Token = "0x60022D7")]
	[Address(RVA = "0x657ED0", Offset = "0x6570D0", VA = "0x180657ED0")]
	public UGUIParticle()
	{
	}
}
