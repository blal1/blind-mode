using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace YgomSystem.UI;

[Token(Token = "0x2000448")]
public static class ColorLabelManager
{
	[Token(Token = "0x40014F2")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string assetPath;

	[Token(Token = "0x40014F3")]
	[FieldOffset(Offset = "0x8")]
	private static ColorLabelSetting s_setting;

	[Token(Token = "0x40014F4")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, ColorLabel> s_labelStrToEnumMap;

	[Token(Token = "0x40014F5")]
	[FieldOffset(Offset = "0x18")]
	private static bool s_initalized;

	[Token(Token = "0x6001B75")]
	[Address(RVA = "0x5E2E00", Offset = "0x5E2000", VA = "0x1805E2E00")]
	static ColorLabelManager()
	{
	}

	[Token(Token = "0x6001B76")]
	[Address(RVA = "0x5E25B0", Offset = "0x5E17B0", VA = "0x1805E25B0")]
	public static void Setup()
	{
	}

	[Token(Token = "0x6001B77")]
	[Address(RVA = "0x5E2450", Offset = "0x5E1650", VA = "0x1805E2450")]
	public static Color GetColor(string label)
	{
		return default(Color);
	}

	[Token(Token = "0x6001B78")]
	[Address(RVA = "0x5E2D80", Offset = "0x5E1F80", VA = "0x1805E2D80")]
	public static bool TryGetColor(string label, out Color result)
	{
		return default(bool);
	}

	[Token(Token = "0x6001B79")]
	[Address(RVA = "0x5E2390", Offset = "0x5E1590", VA = "0x1805E2390")]
	public static Color GetColor(ColorLabel label)
	{
		return default(Color);
	}

	[Token(Token = "0x6001B7A")]
	[Address(RVA = "0x5E24E0", Offset = "0x5E16E0", VA = "0x1805E24E0")]
	public static ColorLabel LabelStringToEnum(string label)
	{
		return default(ColorLabel);
	}
}
