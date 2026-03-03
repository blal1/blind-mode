using Il2CppDummyDll;

namespace Win32;

[Token(Token = "0x20000C7")]
public static class GeneralApi
{
	[Token(Token = "0x600037F")]
	[Address(RVA = "0x679ED0", Offset = "0x6790D0", VA = "0x180679ED0")]
	internal static string GetWin32ErrorMessage(int error)
	{
		return null;
	}

	[Token(Token = "0x6000380")]
	[Address(RVA = "0x679DC0", Offset = "0x678FC0", VA = "0x180679DC0")]
	internal static string GetLastWin32ErrorMessage()
	{
		return null;
	}
}
