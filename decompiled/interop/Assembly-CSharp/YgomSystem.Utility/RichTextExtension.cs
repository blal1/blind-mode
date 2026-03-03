using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;

namespace YgomSystem.Utility;

[Token(Token = "0x20003FC")]
public class RichTextExtension
{
	[Token(Token = "0x20003FD")]
	public delegate string replaceMarkup(ref string data, string value, string tag, Dictionary<string, string> param);

	[Token(Token = "0x40013D9")]
	[FieldOffset(Offset = "0x0")]
	public static string[] UguiSupportedTags;

	[Token(Token = "0x40013DA")]
	[FieldOffset(Offset = "0x8")]
	private static Dictionary<string, replaceMarkup> registTag;

	[Token(Token = "0x6001982")]
	[Address(RVA = "0x5D3EA0", Offset = "0x5D30A0", VA = "0x1805D3EA0")]
	private static bool IsSupportedTag(string tag, string[] supportedTags)
	{
		return default(bool);
	}

	[Token(Token = "0x6001983")]
	[Address(RVA = "0x5D4750", Offset = "0x5D3950", VA = "0x1805D4750")]
	private static void StartTags(StringBuilder outstr, List<KeyValuePair<string, string>> tagstack)
	{
	}

	[Token(Token = "0x6001984")]
	[Address(RVA = "0x5D3AC0", Offset = "0x5D2CC0", VA = "0x1805D3AC0")]
	private static void EndTags(StringBuilder outstr, List<KeyValuePair<string, string>> tagstack)
	{
	}

	[Token(Token = "0x6001985")]
	[Address(RVA = "0x5D4830", Offset = "0x5D3A30", VA = "0x1805D4830")]
	public static string Substring(string text, int startIndex, int length, string[] supportedTags)
	{
		return null;
	}

	[Token(Token = "0x6001986")]
	[Address(RVA = "0x5D43C0", Offset = "0x5D35C0", VA = "0x1805D43C0")]
	public static string RemoveMarkup(string text, string[] supportedTags)
	{
		return null;
	}

	[Token(Token = "0x6001987")]
	[Address(RVA = "0x5D3B90", Offset = "0x5D2D90", VA = "0x1805D3B90")]
	private static string GetInnermark(string text, int startIndex, int endIndex)
	{
		return null;
	}

	[Token(Token = "0x6001988")]
	[Address(RVA = "0x5D4360", Offset = "0x5D3560", VA = "0x1805D4360")]
	private static string RemoveInnermarkEndToken(string innermark)
	{
		return null;
	}

	[Token(Token = "0x6001989")]
	[Address(RVA = "0x5D3E00", Offset = "0x5D3000", VA = "0x1805D3E00")]
	private static string GetTag(string innermark)
	{
		return null;
	}

	[Token(Token = "0x600198A")]
	[Address(RVA = "0x5D3F20", Offset = "0x5D3120", VA = "0x1805D3F20")]
	public static int Length(string text, string[] supportedTags)
	{
		return default(int);
	}

	[Token(Token = "0x600198B")]
	[Address(RVA = "0x5D53F0", Offset = "0x5D45F0", VA = "0x1805D53F0")]
	private static string xmlDecode(string src)
	{
		return null;
	}

	[Token(Token = "0x600198C")]
	[Address(RVA = "0x5D5530", Offset = "0x5D4730", VA = "0x1805D5530")]
	private static string xmlEncode(string src)
	{
		return null;
	}

	[Token(Token = "0x600198D")]
	[Address(RVA = "0x5D5390", Offset = "0x5D4590", VA = "0x1805D5390")]
	private static void passSpace(string param, ref int i)
	{
	}

	[Token(Token = "0x600198E")]
	[Address(RVA = "0x5D5180", Offset = "0x5D4380", VA = "0x1805D5180")]
	private static string getId(string param, ref int i)
	{
		return null;
	}

	[Token(Token = "0x600198F")]
	[Address(RVA = "0x5D5240", Offset = "0x5D4440", VA = "0x1805D5240")]
	private static string getValue(string param, ref int i)
	{
		return null;
	}

	[Token(Token = "0x6001990")]
	[Address(RVA = "0x5D3BB0", Offset = "0x5D2DB0", VA = "0x1805D3BB0")]
	private static Dictionary<string, string> GetParams(string param)
	{
		return null;
	}

	[Token(Token = "0x6001991")]
	[Address(RVA = "0x5D3A30", Offset = "0x5D2C30", VA = "0x1805D3A30")]
	public static void AddMarkupTag(string tag, replaceMarkup func)
	{
	}

	[Token(Token = "0x6001992")]
	[Address(RVA = "0x5D3F90", Offset = "0x5D3190", VA = "0x1805D3F90")]
	public static string ProcessMarkup(string text)
	{
		return null;
	}

	[Token(Token = "0x6001993")]
	[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
	public RichTextExtension()
	{
	}
}
