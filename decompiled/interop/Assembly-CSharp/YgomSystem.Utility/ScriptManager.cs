using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x2000402")]
public class ScriptManager
{
	[Token(Token = "0x2000403")]
	public interface IScriptContextOwner
	{
		[Token(Token = "0x60019AE")]
		IScriptContext GetScriptContext(string lang);
	}

	[Token(Token = "0x2000404")]
	public interface IScriptContext
	{
		[Token(Token = "0x60019AF")]
		void Exec(string code);
	}

	[Token(Token = "0x40013F9")]
	[FieldOffset(Offset = "0x0")]
	private static SortedDictionary<string, Func<object, IScriptContext>> scriptctxgen;

	[Token(Token = "0x40013FA")]
	[FieldOffset(Offset = "0x8")]
	private static SortedDictionary<string, IScriptContext> globalctx;

	[Token(Token = "0x60019A4")]
	[Address(RVA = "0x5D6850", Offset = "0x5D5A50", VA = "0x1805D6850")]
	public static void AddScript(string lang, Func<object, IScriptContext> ctxgen)
	{
	}

	[Token(Token = "0x60019A5")]
	[Address(RVA = "0x5D75D0", Offset = "0x5D67D0", VA = "0x1805D75D0")]
	public static void ResetGlobalContext()
	{
	}

	[Token(Token = "0x60019A6")]
	[Address(RVA = "0x5D68E0", Offset = "0x5D5AE0", VA = "0x1805D68E0")]
	public static IScriptContext CreateContext(string lang, object ctx)
	{
		return null;
	}

	[Token(Token = "0x60019A7")]
	[Address(RVA = "0x5D72E0", Offset = "0x5D64E0", VA = "0x1805D72E0")]
	public static string LoadImmediateText(string url)
	{
		return null;
	}

	[Token(Token = "0x60019A8")]
	[Address(RVA = "0x5D6BF0", Offset = "0x5D5DF0", VA = "0x1805D6BF0")]
	public static void ExecUrlScript(string url, object ctx)
	{
	}

	[Token(Token = "0x60019A9")]
	[Address(RVA = "0x5D71A0", Offset = "0x5D63A0", VA = "0x1805D71A0")]
	public static IScriptContext GetGlobalContext(string lang)
	{
		return null;
	}

	[Token(Token = "0x60019AA")]
	[Address(RVA = "0x5D69A0", Offset = "0x5D5BA0", VA = "0x1805D69A0")]
	public static void ExecLoadScript(string lang, string srcurl, object ctx)
	{
	}

	[Token(Token = "0x60019AB")]
	[Address(RVA = "0x5D6A40", Offset = "0x5D5C40", VA = "0x1805D6A40")]
	public static void ExecScript(string lang, string code, object ctx)
	{
	}

	[Token(Token = "0x60019AC")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public ScriptManager()
	{
	}
}
