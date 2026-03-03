using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x20005DF")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class StyleSyntaxParser
{
	[Token(Token = "0x40015B4")]
	[FieldOffset(Offset = "0x10")]
	private List<Expression> m_ProcessExpressionList;

	[Token(Token = "0x40015B5")]
	[FieldOffset(Offset = "0x18")]
	private Stack<Expression> m_ExpressionStack;

	[Token(Token = "0x40015B6")]
	[FieldOffset(Offset = "0x20")]
	private Stack<ExpressionCombinator> m_CombinatorStack;

	[Token(Token = "0x40015B7")]
	[FieldOffset(Offset = "0x28")]
	private Dictionary<string, Expression> m_ParsedExpressionCache;

	[Token(Token = "0x60028D2")]
	[Address(RVA = "0x2A8EF30", Offset = "0x2A8E130", VA = "0x182A8EF30")]
	public Expression Parse(string syntax)
	{
		return null;
	}

	[Token(Token = "0x60028D3")]
	[Address(RVA = "0x2A8DD80", Offset = "0x2A8CF80", VA = "0x182A8DD80")]
	private Expression ParseExpression(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	[Token(Token = "0x60028D4")]
	[Address(RVA = "0x2A8F0E0", Offset = "0x2A8E2E0", VA = "0x182A8F0E0")]
	private void ProcessCombinatorStack()
	{
	}

	[Token(Token = "0x60028D5")]
	[Address(RVA = "0x2A8ED80", Offset = "0x2A8DF80", VA = "0x182A8ED80")]
	private Expression ParseTerm(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	[Token(Token = "0x60028D6")]
	[Address(RVA = "0x2A8D510", Offset = "0x2A8C710", VA = "0x182A8D510")]
	private ExpressionCombinator ParseCombinatorType(StyleSyntaxTokenizer tokenizer)
	{
		return default(ExpressionCombinator);
	}

	[Token(Token = "0x60028D7")]
	[Address(RVA = "0x2A8E020", Offset = "0x2A8D220", VA = "0x182A8E020")]
	private Expression ParseGroup(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	[Token(Token = "0x60028D8")]
	[Address(RVA = "0x2A8D760", Offset = "0x2A8C960", VA = "0x182A8D760")]
	private Expression ParseDataType(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	[Token(Token = "0x60028D9")]
	[Address(RVA = "0x2A8E5C0", Offset = "0x2A8D7C0", VA = "0x182A8E5C0")]
	private Expression ParseNonTerminalValue(string syntax)
	{
		return null;
	}

	[Token(Token = "0x60028DA")]
	[Address(RVA = "0x2A8E770", Offset = "0x2A8D970", VA = "0x182A8E770")]
	private Expression ParseProperty(StyleSyntaxTokenizer tokenizer)
	{
		return null;
	}

	[Token(Token = "0x60028DB")]
	[Address(RVA = "0x2A8E320", Offset = "0x2A8D520", VA = "0x182A8E320")]
	private void ParseMultiplier(StyleSyntaxTokenizer tokenizer, ref ExpressionMultiplier multiplier)
	{
	}

	[Token(Token = "0x60028DC")]
	[Address(RVA = "0x2A8EC20", Offset = "0x2A8DE20", VA = "0x182A8EC20")]
	private void ParseRanges(StyleSyntaxTokenizer tokenizer, out int min, out int max)
	{
	}

	[Token(Token = "0x60028DD")]
	[Address(RVA = "0x2A8D440", Offset = "0x2A8C640", VA = "0x182A8D440")]
	private static void EatSpace(StyleSyntaxTokenizer tokenizer)
	{
	}

	[Token(Token = "0x60028DE")]
	[Address(RVA = "0x2A8D4C0", Offset = "0x2A8C6C0", VA = "0x182A8D4C0")]
	private static bool IsExpressionEnd(StyleSyntaxToken token)
	{
		return default(bool);
	}

	[Token(Token = "0x60028DF")]
	[Address(RVA = "0x2A8D4A0", Offset = "0x2A8C6A0", VA = "0x182A8D4A0")]
	private static bool IsCombinator(StyleSyntaxToken token)
	{
		return default(bool);
	}

	[Token(Token = "0x60028E0")]
	[Address(RVA = "0x2A8D4E0", Offset = "0x2A8C6E0", VA = "0x182A8D4E0")]
	private static bool IsMultiplier(StyleSyntaxToken token)
	{
		return default(bool);
	}

	[Token(Token = "0x60028E1")]
	[Address(RVA = "0x2A8F440", Offset = "0x2A8E640", VA = "0x182A8F440")]
	public StyleSyntaxParser()
	{
	}
}
