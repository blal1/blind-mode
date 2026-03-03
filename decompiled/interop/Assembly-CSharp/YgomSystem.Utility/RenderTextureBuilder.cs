using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003F9")]
[RequireComponent(typeof(Camera))]
public class RenderTextureBuilder : MonoBehaviour
{
	[Token(Token = "0x40013C8")]
	[FieldOffset(Offset = "0x20")]
	public int textureW;

	[Token(Token = "0x40013C9")]
	[FieldOffset(Offset = "0x24")]
	public int textureH;

	[Token(Token = "0x40013CA")]
	[FieldOffset(Offset = "0x28")]
	public int depth;

	[Token(Token = "0x40013CB")]
	[FieldOffset(Offset = "0x30")]
	public RenderTexture texture;

	[Token(Token = "0x40013CC")]
	[FieldOffset(Offset = "0x38")]
	public RawImage targetRawImage;

	[Token(Token = "0x40013CD")]
	[FieldOffset(Offset = "0x40")]
	public int snapshotDelay;

	[Token(Token = "0x40013CE")]
	[FieldOffset(Offset = "0x44")]
	public bool snapshotAndDestroy;

	[Token(Token = "0x40013CF")]
	[FieldOffset(Offset = "0x48")]
	public Action<RenderTextureBuilder> snapshotAction;

	[Token(Token = "0x40013D0")]
	[FieldOffset(Offset = "0x50")]
	public bool useHDRFormat;

	[Token(Token = "0x40013D1")]
	[FieldOffset(Offset = "0x54")]
	public int antiAliasing;

	[Token(Token = "0x40013D2")]
	[FieldOffset(Offset = "0x58")]
	private Camera renderCamera;

	[Token(Token = "0x600196B")]
	[Address(RVA = "0x5D2D70", Offset = "0x5D1F70", VA = "0x1805D2D70")]
	public void Restart()
	{
	}

	[Token(Token = "0x600196C")]
	[Address(RVA = "0x5D2E20", Offset = "0x5D2020", VA = "0x1805D2E20")]
	private void Start()
	{
	}

	[Token(Token = "0x600196D")]
	[Address(RVA = "0x5D2B70", Offset = "0x5D1D70", VA = "0x1805D2B70")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600196E")]
	[Address(RVA = "0x5D2CA0", Offset = "0x5D1EA0", VA = "0x1805D2CA0")]
	private void OnPostRender()
	{
	}

	[Token(Token = "0x600196F")]
	[Address(RVA = "0x5D3100", Offset = "0x5D2300", VA = "0x1805D3100")]
	public RenderTextureBuilder()
	{
	}
}
