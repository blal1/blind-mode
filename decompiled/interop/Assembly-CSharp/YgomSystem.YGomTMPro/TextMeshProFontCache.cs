using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x2000232")]
[AddComponentMenu("Ygom/UI/TextMeshPro FontCache")]
[RequireComponent(typeof(TextMeshPro))]
[Obsolete("Instead Use ExtendedTextMeshPro")]
public class TextMeshProFontCache : MonoBehaviour
{
	[Token(Token = "0x4000B56")]
	[FieldOffset(Offset = "0x20")]
	private TMP_FontAsset m_CachedFontAsset;

	[Token(Token = "0x6000D0F")]
	[Address(RVA = "0xD3BF70", Offset = "0xD3B170", VA = "0x180D3BF70")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D10")]
	[Address(RVA = "0xD3C020", Offset = "0xD3B220", VA = "0x180D3C020")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000D11")]
	[Address(RVA = "0x3D2BD0", Offset = "0x3D1DD0", VA = "0x1803D2BD0")]
	public TextMeshProFontCache()
	{
	}
}
