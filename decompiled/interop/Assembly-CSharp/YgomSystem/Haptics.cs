using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000176")]
public static class Haptics
{
	[Token(Token = "0x40008F8")]
	[FieldOffset(Offset = "0x0")]
	public static readonly int MAX;

	[Token(Token = "0x40008F9")]
	[FieldOffset(Offset = "0x8")]
	private static bool[] s_bEnable;

	[Token(Token = "0x6000976")]
	[Address(RVA = "0xAF7AE0", Offset = "0xAF6CE0", VA = "0x180AF7AE0")]
	public static void Initialize()
	{
	}

	[Token(Token = "0x6000977")]
	[Address(RVA = "0xAF7CC0", Offset = "0xAF6EC0", VA = "0x180AF7CC0")]
	public static void SetVibrateFlag(bool bEnable, int Pad)
	{
	}

	[Token(Token = "0x6000978")]
	[Address(RVA = "0xAF7BF0", Offset = "0xAF6DF0", VA = "0x180AF7BF0")]
	public static void SetVibrateFlagAll(bool bEnable)
	{
	}

	[Token(Token = "0x6000979")]
	[Address(RVA = "0xAF7F10", Offset = "0xAF7110", VA = "0x180AF7F10")]
	public static void Vibrate(GamePad.VIBRATION Id, int Pad)
	{
	}

	[Token(Token = "0x600097A")]
	[Address(RVA = "0xAF7E90", Offset = "0xAF7090", VA = "0x180AF7E90")]
	public static void VibrateForce(GamePad.VIBRATION Id, int Pad)
	{
	}

	[Token(Token = "0x600097B")]
	[Address(RVA = "0xAF7E20", Offset = "0xAF7020", VA = "0x180AF7E20")]
	public static void Stop(int Pad)
	{
	}

	[Token(Token = "0x600097C")]
	[Address(RVA = "0xAF7D40", Offset = "0xAF6F40", VA = "0x180AF7D40")]
	public static void StopAll()
	{
	}
}
