using System.Diagnostics;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x2000179")]
public static class NXDebugLogger
{
	[Token(Token = "0x6000992")]
	[Address(RVA = "0xAFCDD0", Offset = "0xAFBFD0", VA = "0x180AFCDD0")]
	[Conditional("NX_DEBUGLOGGER_ENABLE")]
	public static void Log(string msg)
	{
	}

	[Token(Token = "0x6000993")]
	[Address(RVA = "0xAFCD80", Offset = "0xAFBF80", VA = "0x180AFCD80")]
	[Conditional("NX_DEBUGLOGGER_ENABLE")]
	public static void LogWarning(string msg)
	{
	}

	[Token(Token = "0x6000994")]
	[Address(RVA = "0xAFCD30", Offset = "0xAFBF30", VA = "0x180AFCD30")]
	[Conditional("NX_DEBUGLOGGER_ENABLE")]
	public static void LogError(string msg)
	{
	}
}
