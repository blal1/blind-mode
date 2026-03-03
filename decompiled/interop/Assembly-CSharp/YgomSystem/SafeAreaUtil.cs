using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem;

[Token(Token = "0x2000190")]
public static class SafeAreaUtil
{
	[Token(Token = "0x400095E")]
	[FieldOffset(Offset = "0x0")]
	private static bool setup;

	[Token(Token = "0x400095F")]
	[FieldOffset(Offset = "0x4")]
	private static Rect _safeArea;

	[Token(Token = "0x4000960")]
	[FieldOffset(Offset = "0x14")]
	private static Vector2 _anchorMin;

	[Token(Token = "0x4000961")]
	[FieldOffset(Offset = "0x1C")]
	private static Vector2 _anchorMax;

	[Token(Token = "0x17000104")]
	public static Rect safeArea
	{
		[Token(Token = "0x60009DE")]
		[Address(RVA = "0xB03B50", Offset = "0xB02D50", VA = "0x180B03B50")]
		get
		{
			return default(Rect);
		}
	}

	[Token(Token = "0x17000105")]
	public static Vector2 anchorMin
	{
		[Token(Token = "0x60009DF")]
		[Address(RVA = "0xB03B00", Offset = "0xB02D00", VA = "0x180B03B00")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x17000106")]
	public static Vector2 anchorMax
	{
		[Token(Token = "0x60009E0")]
		[Address(RVA = "0xB03AB0", Offset = "0xB02CB0", VA = "0x180B03AB0")]
		get
		{
			return default(Vector2);
		}
	}

	[Token(Token = "0x60009E1")]
	[Address(RVA = "0xB03930", Offset = "0xB02B30", VA = "0x180B03930")]
	public static void Setup(bool force = false)
	{
	}

	[Token(Token = "0x60009E2")]
	[Address(RVA = "0xB03900", Offset = "0xB02B00", VA = "0x180B03900")]
	public static Rect GetSafeArea()
	{
		return default(Rect);
	}
}
