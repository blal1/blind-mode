using System.Collections.Generic;
using Il2CppDummyDll;

namespace YgomGame.Utility;

[Token(Token = "0x200090C")]
public class RichTextExtensionTags
{
	[Token(Token = "0x4008963")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string keywordCwork;

	[Token(Token = "0x4008964")]
	[FieldOffset(Offset = "0x8")]
	private static readonly string keywordHtarg;

	[Token(Token = "0x4008965")]
	[FieldOffset(Offset = "0x10")]
	private static Dictionary<string, string> replaceDefine;

	[Token(Token = "0x4008966")]
	[FieldOffset(Offset = "0x18")]
	private static Dictionary<string, object> htargs;

	[Token(Token = "0x6003641")]
	[Address(RVA = "0x7C6510", Offset = "0x7C5710", VA = "0x1807C6510")]
	public static void DefineExtensionMarkupReplace(string src, string dst)
	{
	}

	[Token(Token = "0x6003642")]
	[Address(RVA = "0x7C65A0", Offset = "0x7C57A0", VA = "0x1807C65A0")]
	public static string GetExtensionMarkupReplace(string src)
	{
		return null;
	}

	[Token(Token = "0x6003643")]
	[Address(RVA = "0x7C7D00", Offset = "0x7C6F00", VA = "0x1807C7D00")]
	public static void RemoveExtensionMarkupReplace(string src)
	{
	}

	[Token(Token = "0x6003644")]
	[Address(RVA = "0x7C7D80", Offset = "0x7C6F80", VA = "0x1807C7D80")]
	public static void SetHtArgs(Dictionary<string, object> args)
	{
	}

	[Token(Token = "0x6003645")]
	[Address(RVA = "0x7C6690", Offset = "0x7C5890", VA = "0x1807C6690")]
	public static Dictionary<string, object> GetHtArgs()
	{
		return null;
	}

	[Token(Token = "0x6003646")]
	[Address(RVA = "0x7C6160", Offset = "0x7C5360", VA = "0x1807C6160")]
	public static object ConvertStringCommand(string str)
	{
		return null;
	}

	[Token(Token = "0x6003647")]
	[Address(RVA = "0x7C7B30", Offset = "0x7C6D30", VA = "0x1807C7B30")]
	private static object ProcArg(Dictionary<string, string> param, string aname)
	{
		return null;
	}

	[Token(Token = "0x6003648")]
	[Address(RVA = "0x7C7340", Offset = "0x7C6540", VA = "0x1807C7340")]
	private static string ProcArgAndEnc(string replace, Dictionary<string, string> param)
	{
		return null;
	}

	[Token(Token = "0x6003649")]
	[Address(RVA = "0x7C66E0", Offset = "0x7C58E0", VA = "0x1807C66E0")]
	public static void Init()
	{
	}

	[Token(Token = "0x600364A")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RichTextExtensionTags()
	{
	}
}
