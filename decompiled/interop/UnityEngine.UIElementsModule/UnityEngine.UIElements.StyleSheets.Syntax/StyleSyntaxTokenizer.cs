using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x20005E2")]
internal class StyleSyntaxTokenizer
{
	[Token(Token = "0x40015D1")]
	[FieldOffset(Offset = "0x10")]
	private List<StyleSyntaxToken> m_Tokens;

	[Token(Token = "0x40015D2")]
	[FieldOffset(Offset = "0x18")]
	private int m_CurrentTokenIndex;

	[Token(Token = "0x17000A89")]
	public StyleSyntaxToken current
	{
		[Token(Token = "0x60028E5")]
		[Address(RVA = "0x2A904F0", Offset = "0x2A8F6F0", VA = "0x182A904F0")]
		get
		{
			return default(StyleSyntaxToken);
		}
	}

	[Token(Token = "0x60028E6")]
	[Address(RVA = "0x2A8F7F0", Offset = "0x2A8E9F0", VA = "0x182A8F7F0")]
	public StyleSyntaxToken MoveNext()
	{
		return default(StyleSyntaxToken);
	}

	[Token(Token = "0x60028E7")]
	[Address(RVA = "0x2A8F8C0", Offset = "0x2A8EAC0", VA = "0x182A8F8C0")]
	public StyleSyntaxToken PeekNext()
	{
		return default(StyleSyntaxToken);
	}

	[Token(Token = "0x60028E8")]
	[Address(RVA = "0x2A8F980", Offset = "0x2A8EB80", VA = "0x182A8F980")]
	public void Tokenize(string syntax)
	{
	}

	[Token(Token = "0x60028E9")]
	[Address(RVA = "0x2A8F690", Offset = "0x2A8E890", VA = "0x182A8F690")]
	private static bool IsNextCharacter(string s, int index, char c)
	{
		return default(bool);
	}

	[Token(Token = "0x60028EA")]
	[Address(RVA = "0x2A8F6E0", Offset = "0x2A8E8E0", VA = "0x182A8F6E0")]
	private static bool IsNextLetterOrDash(string s, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60028EB")]
	[Address(RVA = "0x2A8F790", Offset = "0x2A8E990", VA = "0x182A8F790")]
	private static bool IsNextNumber(string s, int index)
	{
		return default(bool);
	}

	[Token(Token = "0x60028EC")]
	[Address(RVA = "0x2A8F630", Offset = "0x2A8E830", VA = "0x182A8F630")]
	private static int GlobCharacter(string s, int index, char c)
	{
		return default(int);
	}

	[Token(Token = "0x60028ED")]
	[Address(RVA = "0x2A90470", Offset = "0x2A8F670", VA = "0x182A90470")]
	public StyleSyntaxTokenizer()
	{
	}
}
