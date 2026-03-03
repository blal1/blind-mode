using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x200052F")]
internal class DrawParams
{
	[Token(Token = "0x4001160")]
	[FieldOffset(Offset = "0x0")]
	internal static readonly Rect k_UnlimitedRect;

	[Token(Token = "0x4001161")]
	[FieldOffset(Offset = "0x10")]
	internal static readonly Rect k_FullNormalizedRect;

	[Token(Token = "0x4001162")]
	[FieldOffset(Offset = "0x10")]
	internal readonly Stack<Matrix4x4> view;

	[Token(Token = "0x4001163")]
	[FieldOffset(Offset = "0x18")]
	internal readonly Stack<Rect> scissor;

	[Token(Token = "0x4001164")]
	[FieldOffset(Offset = "0x20")]
	internal readonly List<RenderTexture> renderTexture;

	[Token(Token = "0x4001165")]
	[FieldOffset(Offset = "0x28")]
	internal readonly List<Material> defaultMaterial;

	[Token(Token = "0x60024F8")]
	[Address(RVA = "0x2A46600", Offset = "0x2A45800", VA = "0x182A46600")]
	public void Reset()
	{
	}

	[Token(Token = "0x60024F9")]
	[Address(RVA = "0x2A46830", Offset = "0x2A45A30", VA = "0x182A46830")]
	public DrawParams()
	{
	}
}
