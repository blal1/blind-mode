using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x20005E1")]
internal struct StyleSyntaxToken
{
	[Token(Token = "0x40015CE")]
	[FieldOffset(Offset = "0x0")]
	public StyleSyntaxTokenType type;

	[Token(Token = "0x40015CF")]
	[FieldOffset(Offset = "0x8")]
	public string text;

	[Token(Token = "0x40015D0")]
	[FieldOffset(Offset = "0x10")]
	public int number;

	[Token(Token = "0x60028E2")]
	[Address(RVA = "0x2A8F590", Offset = "0x2A8E790", VA = "0x182A8F590")]
	public StyleSyntaxToken(StyleSyntaxTokenType t)
	{
	}

	[Token(Token = "0x60028E3")]
	[Address(RVA = "0x2A8F5C0", Offset = "0x2A8E7C0", VA = "0x182A8F5C0")]
	public StyleSyntaxToken(StyleSyntaxTokenType type, string text)
	{
	}

	[Token(Token = "0x60028E4")]
	[Address(RVA = "0x2A8F5F0", Offset = "0x2A8E7F0", VA = "0x182A8F5F0")]
	public StyleSyntaxToken(StyleSyntaxTokenType type, int number)
	{
	}
}
