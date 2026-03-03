using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using YgomSystem.UI;

namespace YgomSystem.Extension.UGUI.ScrollRectExtension;

[Token(Token = "0x2000371")]
public static class ScrollRectExtension
{
	[Token(Token = "0x2000372")]
	public enum InputMode
	{
		[Token(Token = "0x40011E1")]
		DirectionalKey = 1,
		[Token(Token = "0x40011E2")]
		AnalogMain = 2,
		[Token(Token = "0x40011E3")]
		AnalogSub = 4
	}

	[Token(Token = "0x600155E")]
	[Address(RVA = "0x528790", Offset = "0x527990", VA = "0x180528790")]
	public static bool IsScrollable(this ScrollRect scrollRect)
	{
		return default(bool);
	}

	[Token(Token = "0x600155F")]
	[Address(RVA = "0x528690", Offset = "0x527890", VA = "0x180528690")]
	public static bool IsScrollableHorizontal(this ScrollRect scrollRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6001560")]
	[Address(RVA = "0x528710", Offset = "0x527910", VA = "0x180528710")]
	public static bool IsScrollableVertical(this ScrollRect scrollRect)
	{
		return default(bool);
	}

	[Token(Token = "0x6001561")]
	[Address(RVA = "0x529410", Offset = "0x528610", VA = "0x180529410")]
	public static void SetGamePadInputScroll(this ScrollRect scrollRect, InputMode inputMode = (InputMode)7)
	{
	}

	[Token(Token = "0x6001562")]
	[Address(RVA = "0x528FE0", Offset = "0x5281E0", VA = "0x180528FE0")]
	public static void ScrollAnalogMovement(this ScrollRect scrollRect, Vector2 dir)
	{
	}

	[Token(Token = "0x6001563")]
	[Address(RVA = "0x529170", Offset = "0x528370", VA = "0x180529170")]
	public static void ScrollMovement(this ScrollRect scrollRect, PadInputDirection direction)
	{
	}

	[Token(Token = "0x6001564")]
	[Address(RVA = "0x5290B0", Offset = "0x5282B0", VA = "0x1805290B0")]
	public static void ScrollMovementRight(this ScrollRect scrollRect)
	{
	}

	[Token(Token = "0x6001565")]
	[Address(RVA = "0x529050", Offset = "0x528250", VA = "0x180529050")]
	public static void ScrollMovementLeft(this ScrollRect scrollRect)
	{
	}

	[Token(Token = "0x6001566")]
	[Address(RVA = "0x529110", Offset = "0x528310", VA = "0x180529110")]
	public static void ScrollMovementUp(this ScrollRect scrollRect)
	{
	}

	[Token(Token = "0x6001567")]
	[Address(RVA = "0x528FF0", Offset = "0x5281F0", VA = "0x180528FF0")]
	public static void ScrollMovementDown(this ScrollRect scrollRect)
	{
	}

	[Token(Token = "0x6001568")]
	[Address(RVA = "0x529290", Offset = "0x528490", VA = "0x180529290")]
	public static void ScrollMovement(this ScrollRect scrollRect, Vector2 dir, bool adjustDeltaTime = false)
	{
	}

	[Token(Token = "0x6001569")]
	[Address(RVA = "0x5284B0", Offset = "0x5276B0", VA = "0x1805284B0")]
	public static Vector2 GetMovementAmount(this ScrollRect scrollRect, PadInputDirection direction)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600156A")]
	[Address(RVA = "0x528630", Offset = "0x527830", VA = "0x180528630")]
	public static Vector2 GetMovementAmount(this ScrollRect scrollRect, Vector2 dir)
	{
		return default(Vector2);
	}

	[Token(Token = "0x600156B")]
	[Address(RVA = "0x529850", Offset = "0x528A50", VA = "0x180529850")]
	public static void SetOnSelectedItemInnerFocus(this ExtendedScrollRect scrollRect, SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x600156C")]
	[Address(RVA = "0x5289B0", Offset = "0x527BB0", VA = "0x1805289B0")]
	private static void OnSelectedItemInnerFocus(this ExtendedScrollRect scrollRect, SelectionItem selectionItem)
	{
	}

	[Token(Token = "0x600156D")]
	[Address(RVA = "0x529770", Offset = "0x528970", VA = "0x180529770")]
	public static void SetOnSelectedItemEdgeFocus(this ExtendedScrollRect scrollRect, SelectionItem selectionItem, PadInputDirection direction)
	{
	}

	[Token(Token = "0x600156E")]
	[Address(RVA = "0x528870", Offset = "0x527A70", VA = "0x180528870")]
	private static void OnSelectedItemEdgeFocus(this ExtendedScrollRect scrollRect, PadInputDirection direction)
	{
	}
}
