using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.Utility;

[Token(Token = "0x20003B7")]
public class BarCode
{
	[Token(Token = "0x600165B")]
	[Address(RVA = "0x5A1900", Offset = "0x5A0B00", VA = "0x1805A1900")]
	public static Texture2D GetBarCodeTexture2D(string ImageLink, int width, int height)
	{
		return null;
	}

	[Token(Token = "0x600165C")]
	[Address(RVA = "0x5A1710", Offset = "0x5A0910", VA = "0x1805A1710")]
	private static Color32[] Encode(string textForEncoding, int width, int height)
	{
		return null;
	}

	[Token(Token = "0x600165D")]
	[Address(RVA = "0x5A1810", Offset = "0x5A0A10", VA = "0x1805A1810")]
	public static string GetBarCodeString(Texture2D BarCodeTexture)
	{
		return null;
	}

	[Token(Token = "0x600165E")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public BarCode()
	{
	}
}
