using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using Steamworks;

namespace YgomSystem;

[Token(Token = "0x2000182")]
public class SteamSoftwareKeyboard
{
	[Token(Token = "0x2000183")]
	public enum TEXT
	{
		[Token(Token = "0x400092F")]
		Normal,
		[Token(Token = "0x4000930")]
		Password
	}

	[Token(Token = "0x2000184")]
	public enum MODE
	{
		[Token(Token = "0x4000932")]
		SingleLine,
		[Token(Token = "0x4000933")]
		MultipleLines,
		[Token(Token = "0x4000934")]
		Email,
		[Token(Token = "0x4000935")]
		Numelic
	}

	[Token(Token = "0x2000185")]
	public enum POSITION
	{
		[Token(Token = "0x4000937")]
		BOTTOM,
		[Token(Token = "0x4000938")]
		TOP,
		[Token(Token = "0x4000939")]
		DIRECT
	}

	[Token(Token = "0x4000928")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	private static bool s_isOpen;

	[Token(Token = "0x4000929")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	private static Action<bool, string> s_callback;

	[Token(Token = "0x400092A")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
	private static Callback<GamepadTextInputDismissed_t> s_onInputFinish;

	[Token(Token = "0x400092B")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
	private static bool s_isOpenFloat;

	[Token(Token = "0x400092C")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
	private static Action s_FloatCallback;

	[Token(Token = "0x400092D")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
	private static Callback<FloatingGamepadTextInputDismissed_t> s_onFinish;

	[Token(Token = "0x60009BD")]
	[Address(RVA = "0xB093F0", Offset = "0xB085F0", VA = "0x180B093F0")]
	public static bool Open(Action<bool, string> callback, TEXT text = TEXT.Normal, MODE mode = MODE.SingleLine, [Optional] string desc, uint charmax = 4096u, [Optional] string exist)
	{
		return default(bool);
	}

	[Token(Token = "0x60009BE")]
	[Address(RVA = "0xB09210", Offset = "0xB08410", VA = "0x180B09210")]
	public static bool OpenFloat(MODE mode = MODE.SingleLine, POSITION pos = POSITION.BOTTOM, [Optional] Action callback, int x = -1, int y = -1, int w = -1, int h = -1)
	{
		return default(bool);
	}

	[Token(Token = "0x60009BF")]
	[Address(RVA = "0xB09130", Offset = "0xB08330", VA = "0x180B09130")]
	private static void OnGamepadTextInputFinish(GamepadTextInputDismissed_t t)
	{
	}

	[Token(Token = "0x60009C0")]
	[Address(RVA = "0xB09090", Offset = "0xB08290", VA = "0x180B09090")]
	private static void OnFloatingKeyboardFinish(FloatingGamepadTextInputDismissed_t t)
	{
	}

	[Token(Token = "0x60009C1")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public SteamSoftwareKeyboard()
	{
	}
}
