using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000528")]
[ExecuteInEditMode]
[RequireComponent(typeof(Camera))]
public class BokehCamera : MonoBehaviour
{
	[Token(Token = "0x400192B")]
	[FieldOffset(Offset = "0x20")]
	public Shader shader;

	[Token(Token = "0x400192C")]
	[FieldOffset(Offset = "0x28")]
	private Material material;

	[Token(Token = "0x400192D")]
	[FieldOffset(Offset = "0x30")]
	private RenderTexture[] renderTexture;

	[Token(Token = "0x6002179")]
	[Address(RVA = "0x634D60", Offset = "0x633F60", VA = "0x180634D60")]
	private void Start()
	{
	}

	[Token(Token = "0x600217A")]
	[Address(RVA = "0x6346D0", Offset = "0x6338D0", VA = "0x1806346D0")]
	public void BokeStart()
	{
	}

	[Token(Token = "0x600217B")]
	[Address(RVA = "0x6346E0", Offset = "0x6338E0", VA = "0x1806346E0")]
	public void BokeStop()
	{
	}

	[Token(Token = "0x600217C")]
	[Address(RVA = "0x634820", Offset = "0x633A20", VA = "0x180634820")]
	private void OnRenderImage(RenderTexture src, RenderTexture dst)
	{
	}

	[Token(Token = "0x600217D")]
	[Address(RVA = "0x634DD0", Offset = "0x633FD0", VA = "0x180634DD0")]
	public BokehCamera()
	{
	}
}
