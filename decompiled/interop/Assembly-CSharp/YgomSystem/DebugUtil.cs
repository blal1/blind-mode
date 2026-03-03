using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace YgomSystem;

[Token(Token = "0x20001D5")]
public class DebugUtil
{
	[Token(Token = "0x6000AEE")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Log(string message)
	{
	}

	[Token(Token = "0x6000AEF")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void LogFormat(string format, params object[] args)
	{
	}

	[Token(Token = "0x6000AF0")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void LogWarning(string message)
	{
	}

	[Token(Token = "0x6000AF1")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void LogError(string message)
	{
	}

	[Token(Token = "0x6000AF2")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	public static void ThreadLog(string message, [CallerMemberName] string member = "")
	{
	}

	[Token(Token = "0x6000AF3")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	public static void ThreadLogWarning(string message, [CallerMemberName] string member = "")
	{
	}

	[Token(Token = "0x6000AF4")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	public static void ThreadLogError(string message, [CallerMemberName] string member = "")
	{
	}

	[Token(Token = "0x6000AF5")]
	[Address(RVA = "0xC07850", Offset = "0xC06A50", VA = "0x180C07850")]
	private static string makeThreadLogString(string member, string message)
	{
		return null;
	}

	[Token(Token = "0x6000AF6")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void TimeStampLog(string message)
	{
	}

	[Token(Token = "0x6000AF7")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Assert(bool condition)
	{
	}

	[Token(Token = "0x6000AF8")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Assert(bool condition, string message)
	{
	}

	[Token(Token = "0x6000AF9")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	public static void Assert(bool condition, Func<string> getMessage)
	{
	}

	[Token(Token = "0x6000AFA")]
	[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
	[Conditional("YGO_DEBUG")]
	public static void PrintObj(object obj, string label = "")
	{
	}

	[Token(Token = "0x6000AFB")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public DebugUtil()
	{
	}
}
