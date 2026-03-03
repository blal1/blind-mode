using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003D7")]
public class FontRasterizer : MonoBehaviour
{
	[Token(Token = "0x400135C")]
	[FieldOffset(Offset = "0x20")]
	private Action<RenderTexture, Texture2D> onFinish;

	[Token(Token = "0x400135D")]
	[FieldOffset(Offset = "0x28")]
	private RenderTextureBuilder renderTexBuilder;

	[Token(Token = "0x400135E")]
	[FieldOffset(Offset = "0x30")]
	private Camera cam;

	[Token(Token = "0x400135F")]
	[FieldOffset(Offset = "0x38")]
	private RectTransform rootTransform;

	[Token(Token = "0x4001360")]
	[FieldOffset(Offset = "0x40")]
	private Text textComponent;

	[Token(Token = "0x4001361")]
	[FieldOffset(Offset = "0x48")]
	private int oldCullingMask;

	[Token(Token = "0x6001897")]
	[Address(RVA = "0x5C4940", Offset = "0x5C3B40", VA = "0x1805C4940")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001898")]
	[Address(RVA = "0x5C4B20", Offset = "0x5C3D20", VA = "0x1805C4B20")]
	public void Initialize(int renderTexW, int renderTexH, string text, Action<Text> onSetup, Action<RenderTexture, Texture2D> onFinish)
	{
	}

	[Token(Token = "0x6001899")]
	[Address(RVA = "0x5C4C50", Offset = "0x5C3E50", VA = "0x1805C4C50")]
	private void OnFinishRender(RenderTextureBuilder renderTexBuilder)
	{
	}

	[Token(Token = "0x600189A")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public FontRasterizer()
	{
	}
}
