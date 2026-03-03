using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.U2D;
using YgomSystem.UI;

namespace YgomSystem.Utility;

[Token(Token = "0x20003D9")]
public class GamePadIconUtil
{
	[Token(Token = "0x20003DA")]
	public enum Variation
	{
		[Token(Token = "0x400136D")]
		Var00,
		[Token(Token = "0x400136E")]
		Var01
	}

	[Token(Token = "0x4001363")]
	private const string atlasPath = "Images/GamePad/<_PLATFORM_>/ButtonIcon/GamePadAtlasVar{0:00}";

	[Token(Token = "0x4001364")]
	private const string buttonIconName = "button{0:000}";

	[Token(Token = "0x4001365")]
	private const string analogIconName = "analog{0:000}";

	[Token(Token = "0x4001366")]
	private const string mouseIconName = "mouse{0:000}";

	[Token(Token = "0x4001367")]
	[FieldOffset(Offset = "0x0")]
	private static Dictionary<Variation, SpriteAtlas> atlases;

	[Token(Token = "0x4001368")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<int, Sprite> buttonIconSprites;

	[Token(Token = "0x4001369")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<int, Sprite> analogIconSprites;

	[Token(Token = "0x400136A")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<int, Sprite> mouseIconSprites;

	[Token(Token = "0x400136B")]
	public const int extraButtonID_AnyDirectionalKey = 104;

	[Token(Token = "0x17000257")]
	public static bool isLoaded
	{
		[Token(Token = "0x60018B6")]
		[Address(RVA = "0x5C7190", Offset = "0x5C6390", VA = "0x1805C7190")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60018B7")]
	[Address(RVA = "0x5C6DF0", Offset = "0x5C5FF0", VA = "0x1805C6DF0")]
	public static void LoadAtlases(bool immediate)
	{
	}

	[Token(Token = "0x60018B8")]
	[Address(RVA = "0x5C6BF0", Offset = "0x5C5DF0", VA = "0x1805C6BF0")]
	private static void LoadAtlas(Variation variation, bool immediate, Action<SpriteAtlas> onLoaded)
	{
	}

	[Token(Token = "0x60018B9")]
	[Address(RVA = "0x5C6240", Offset = "0x5C5440", VA = "0x1805C6240")]
	private static string GetAtlasPath(Variation variation)
	{
		return null;
	}

	[Token(Token = "0x60018BA")]
	[Address(RVA = "0x5C63F0", Offset = "0x5C55F0", VA = "0x1805C63F0")]
	public static Sprite GetButtonIconSprite(int button_id, Variation variation = Variation.Var00)
	{
		return null;
	}

	[Token(Token = "0x60018BB")]
	[Address(RVA = "0x5C6690", Offset = "0x5C5890", VA = "0x1805C6690")]
	public static bool GetButtonIconSprite(Action<Sprite> on_load, SelectorManager.KeyType keyType, Variation variation = Variation.Var00)
	{
		return default(bool);
	}

	[Token(Token = "0x60018BC")]
	[Address(RVA = "0x5C6340", Offset = "0x5C5540", VA = "0x1805C6340")]
	public static bool GetButtonIconSprite(Action<Sprite> on_load, int button_id, Variation variation = Variation.Var00)
	{
		return default(bool);
	}

	[Token(Token = "0x60018BD")]
	[Address(RVA = "0x5C62A0", Offset = "0x5C54A0", VA = "0x1805C62A0")]
	private static string GetButtonIconName(int button_id)
	{
		return null;
	}

	[Token(Token = "0x60018BE")]
	[Address(RVA = "0x5C67A0", Offset = "0x5C59A0", VA = "0x1805C67A0")]
	private static string GetMouseIconName(int mouse_button)
	{
		return null;
	}

	[Token(Token = "0x60018BF")]
	[Address(RVA = "0x5C5DC0", Offset = "0x5C4FC0", VA = "0x1805C5DC0")]
	private static string GetAnalogIconName(int analog_id)
	{
		return null;
	}

	[Token(Token = "0x60018C0")]
	[Address(RVA = "0x5C5E20", Offset = "0x5C5020", VA = "0x1805C5E20")]
	public static Sprite GetAnalogIconSprite(int analog_id, Variation variation = Variation.Var00)
	{
		return null;
	}

	[Token(Token = "0x60018C1")]
	[Address(RVA = "0x5C6120", Offset = "0x5C5320", VA = "0x1805C6120")]
	public static bool GetAnalogIconSprite(Action<Sprite> on_load, SelectorManager.AnalogType analogType, bool isHorizontal, Variation variation = Variation.Var00)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C2")]
	[Address(RVA = "0x5C6070", Offset = "0x5C5270", VA = "0x1805C6070")]
	public static bool GetAnalogIconSprite(Action<Sprite> on_load, int analog_id, Variation variation = Variation.Var00)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C3")]
	[Address(RVA = "0x5C6900", Offset = "0x5C5B00", VA = "0x1805C6900")]
	public static Sprite GetMouseIconSprite(int mouse_button, Variation variation = Variation.Var00)
	{
		return null;
	}

	[Token(Token = "0x60018C4")]
	[Address(RVA = "0x5C6800", Offset = "0x5C5A00", VA = "0x1805C6800")]
	public static bool GetMouseIconSprite(Action<Sprite> on_load, SelectorManager.MouseType mouseType, Variation variation = Variation.Var00)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C5")]
	[Address(RVA = "0x5C6B50", Offset = "0x5C5D50", VA = "0x1805C6B50")]
	public static bool GetMouseIconSprite(Action<Sprite> on_load, int mouse_button, Variation variation = Variation.Var00)
	{
		return default(bool);
	}

	[Token(Token = "0x60018C6")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public GamePadIconUtil()
	{
	}
}
