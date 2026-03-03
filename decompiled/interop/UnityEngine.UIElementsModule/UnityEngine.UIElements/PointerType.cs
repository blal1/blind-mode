using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000221")]
public static class PointerType
{
	[Token(Token = "0x40008B6")]
	[FieldOffset(Offset = "0x0")]
	public static readonly string mouse;

	[Token(Token = "0x40008B7")]
	[FieldOffset(Offset = "0x8")]
	public static readonly string touch;

	[Token(Token = "0x40008B8")]
	[FieldOffset(Offset = "0x10")]
	public static readonly string pen;

	[Token(Token = "0x40008B9")]
	[FieldOffset(Offset = "0x18")]
	public static readonly string unknown;

	[Token(Token = "0x6000EED")]
	[Address(RVA = "0x2B22520", Offset = "0x2B21720", VA = "0x182B22520")]
	internal static string GetPointerType(int pointerId)
	{
		return null;
	}

	[Token(Token = "0x6000EEE")]
	[Address(RVA = "0x2B22630", Offset = "0x2B21830", VA = "0x182B22630")]
	internal static bool IsDirectManipulationDevice(string pointerType)
	{
		return default(bool);
	}
}
