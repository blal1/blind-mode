using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x20004C4")]
public static class SelectorUtility
{
	[Token(Token = "0x400179E")]
	[FieldOffset(Offset = "0x0")]
	private static Vector2 directionUp;

	[Token(Token = "0x400179F")]
	[FieldOffset(Offset = "0x8")]
	private static Vector2 directionRight;

	[Token(Token = "0x40017A0")]
	[FieldOffset(Offset = "0x10")]
	private static Vector2 directionDown;

	[Token(Token = "0x40017A1")]
	[FieldOffset(Offset = "0x18")]
	private static Vector2 directionLeft;

	[Token(Token = "0x6001FB4")]
	[Address(RVA = "0x629890", Offset = "0x628A90", VA = "0x180629890")]
	public static bool IsRectContainsPoint(Vector2 rect_point0, Vector2 rect_point1, Vector2 rect_point2, Vector2 rect_point3, Vector2 check_point)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB5")]
	[Address(RVA = "0x629840", Offset = "0x628A40", VA = "0x180629840")]
	public static int GetSign(float v)
	{
		return default(int);
	}

	[Token(Token = "0x6001FB6")]
	[Address(RVA = "0x629490", Offset = "0x628690", VA = "0x180629490")]
	public static SelectorManager.KeyType GamePadKeyTypeToKeyType(int gamepad_key_type)
	{
		return default(SelectorManager.KeyType);
	}

	[Token(Token = "0x6001FB7")]
	[Address(RVA = "0x629580", Offset = "0x628780", VA = "0x180629580")]
	public static (SelectionItem, float) GetClosestItem(Vector2 screenPoint, Vector2 direction, List<SelectionItem> targets, float angleDot, float minSqrDistance = -1f)
	{
		return default((SelectionItem, float));
	}

	[Token(Token = "0x6001FB8")]
	[Address(RVA = "0x629860", Offset = "0x628A60", VA = "0x180629860")]
	public static bool InvokeAction(Action action)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FB9")]
	public static bool InvokeAction<T1>(Action<T1> action, T1 arg1)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FBA")]
	public static bool InvokeAction<T1, T2>(Action<T1, T2> action, T1 arg1, T2 arg2)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FBB")]
	public static bool InvokeAction<T1, T2, T3>(Action<T1, T2, T3> action, T1 arg1, T2 arg2, T3 arg3)
	{
		return default(bool);
	}

	[Token(Token = "0x6001FBC")]
	[Address(RVA = "0x629310", Offset = "0x628510", VA = "0x180629310")]
	public static Vector2 DirectionToVector2(PadInputDirection direction)
	{
		return default(Vector2);
	}
}
