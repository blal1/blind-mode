using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x20001AB")]
public static class TMP_TextInfoExtended
{
	[Token(Token = "0x20001AC")]
	public enum VERTEXINDEX
	{
		[Token(Token = "0x4000A16")]
		LEFT_BOTTOM,
		[Token(Token = "0x4000A17")]
		LEFT_TOP,
		[Token(Token = "0x4000A18")]
		RIGHT_TOP,
		[Token(Token = "0x4000A19")]
		RIGHT_BOTTOM
	}

	[Token(Token = "0x6000AB4")]
	[Address(RVA = "0xC167F0", Offset = "0xC159F0", VA = "0x180C167F0")]
	public static Vector3 GetMeshVertex(this TMP_TextInfo tmpinfo, int charaindex, VERTEXINDEX vertindex)
	{
		return default(Vector3);
	}

	[Token(Token = "0x6000AB5")]
	[Address(RVA = "0xC16960", Offset = "0xC15B60", VA = "0x180C16960")]
	public static void SetMeshVertex(this TMP_TextInfo tmpinfo, int charaindex, VERTEXINDEX vertindex, Vector3 vertex)
	{
	}

	[Token(Token = "0x6000AB6")]
	[Address(RVA = "0xC167A0", Offset = "0xC159A0", VA = "0x180C167A0")]
	public static float GetMeshHeight(this TMP_TextInfo tmpinfo, int charaindex)
	{
		return default(float);
	}
}
