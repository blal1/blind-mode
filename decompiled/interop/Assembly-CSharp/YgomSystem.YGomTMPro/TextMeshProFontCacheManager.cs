using System.Collections.Generic;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem.YGomTMPro;

[Token(Token = "0x2000234")]
public class TextMeshProFontCacheManager : MonoBehaviour
{
	[Token(Token = "0x4000B57")]
	[FieldOffset(Offset = "0x0")]
	private static TextMeshProFontCacheManager s_Instance;

	[Token(Token = "0x4000B58")]
	[FieldOffset(Offset = "0x20")]
	private List<TMP_FontAsset> m_SearchList;

	[Token(Token = "0x4000B59")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<TMP_FontAsset, List<GameObject>> m_FontReferenceMap;

	[Token(Token = "0x6000D15")]
	[Address(RVA = "0xD3B620", Offset = "0xD3A820", VA = "0x180D3B620")]
	private void Awake()
	{
	}

	[Token(Token = "0x6000D16")]
	[Address(RVA = "0xD3B990", Offset = "0xD3AB90", VA = "0x180D3B990")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6000D17")]
	[Address(RVA = "0xD3B680", Offset = "0xD3A880", VA = "0x180D3B680")]
	public static TMP_FontAsset GetCache(GameObject owner, TMP_FontAsset fontAssetRef)
	{
		return null;
	}

	[Token(Token = "0x6000D18")]
	[Address(RVA = "0xD3BB80", Offset = "0xD3AD80", VA = "0x180D3BB80")]
	public static void ReleaseCache(GameObject owner, TMP_FontAsset fontAssetRef)
	{
	}

	[Token(Token = "0x6000D19")]
	[Address(RVA = "0xD3B9A0", Offset = "0xD3ABA0", VA = "0x180D3B9A0")]
	public static void ReleaseAllCache()
	{
	}

	[Token(Token = "0x6000D1A")]
	[Address(RVA = "0xD3BEB0", Offset = "0xD3B0B0", VA = "0x180D3BEB0")]
	public TextMeshProFontCacheManager()
	{
	}
}
