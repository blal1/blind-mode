using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using YgomSystem.Utility;

namespace YgomSystem.UI;

[Token(Token = "0x2000554")]
public class ShortcutIcon : DeviceIcon
{
	[Token(Token = "0x2000555")]
	public enum Mode
	{
		[Token(Token = "0x40019F6")]
		None,
		[Token(Token = "0x40019F7")]
		PadKey,
		[Token(Token = "0x40019F8")]
		Mouse,
		[Token(Token = "0x40019F9")]
		Analog
	}

	[Token(Token = "0x2000556")]
	public enum AnalogDirection
	{
		[Token(Token = "0x40019FB")]
		Horizontal,
		[Token(Token = "0x40019FC")]
		Vertical
	}

	[Token(Token = "0x40019EF")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
	public SelectorManager.KeyType keyType;

	[Token(Token = "0x40019F0")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
	public SelectorManager.AnalogType analogType;

	[Token(Token = "0x40019F1")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
	public SelectorManager.MouseType mouseType;

	[Token(Token = "0x40019F2")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x54")]
	public GamePadIconUtil.Variation iconVariation;

	[Token(Token = "0x40019F3")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
	public Mode mode;

	[Token(Token = "0x40019F4")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x5C")]
	public AnalogDirection analogDirection;

	[Token(Token = "0x60022B3")]
	[Address(RVA = "0x652850", Offset = "0x651A50", VA = "0x180652850")]
	public void SetKeyType(SelectorManager.KeyType keyType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x60022B4")]
	[Address(RVA = "0x652510", Offset = "0x651710", VA = "0x180652510")]
	public void SetAnalogType(SelectorManager.AnalogType analogType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x60022B5")]
	[Address(RVA = "0x652880", Offset = "0x651A80", VA = "0x180652880")]
	public void SetMouseType(SelectorManager.MouseType mouseType, GamePadIconUtil.Variation variation = GamePadIconUtil.Variation.Var00, [Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x60022B6")]
	[Address(RVA = "0x6528B0", Offset = "0x651AB0", VA = "0x1806528B0", Slot = "7")]
	protected override void UpdateDisplay([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x60022B7")]
	[Address(RVA = "0x652540", Offset = "0x651740", VA = "0x180652540")]
	private void SetIcon([Optional] Action onCompleted)
	{
	}

	[Token(Token = "0x60022B8")]
	[Address(RVA = "0x6485E0", Offset = "0x6477E0", VA = "0x1806485E0")]
	public ShortcutIcon()
	{
	}
}
