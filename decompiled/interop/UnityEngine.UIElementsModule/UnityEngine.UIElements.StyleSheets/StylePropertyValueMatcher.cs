using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005D8")]
internal class StylePropertyValueMatcher : BaseStyleMatcher
{
	[Token(Token = "0x4001589")]
	[FieldOffset(Offset = "0x20")]
	private List<StylePropertyValue> m_Values;

	[Token(Token = "0x17000A84")]
	private StylePropertyValue current
	{
		[Token(Token = "0x60028BC")]
		[Address(RVA = "0x2A89C20", Offset = "0x2A88E20", VA = "0x182A89C20")]
		get
		{
			return default(StylePropertyValue);
		}
	}

	[Token(Token = "0x17000A85")]
	public override int valueCount
	{
		[Token(Token = "0x60028BD")]
		[Address(RVA = "0x2A89D70", Offset = "0x2A88F70", VA = "0x182A89D70", Slot = "15")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000A86")]
	public override bool isCurrentVariable
	{
		[Token(Token = "0x60028BE")]
		[Address(RVA = "0x3C7A70", Offset = "0x3C6C70", VA = "0x1803C7A70", Slot = "16")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A87")]
	public override bool isCurrentComma
	{
		[Token(Token = "0x60028BF")]
		[Address(RVA = "0x2A89CC0", Offset = "0x2A88EC0", VA = "0x182A89CC0", Slot = "17")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x60028C0")]
	[Address(RVA = "0x2A898B0", Offset = "0x2A88AB0", VA = "0x182A898B0")]
	public MatchResult Match(Expression exp, List<StylePropertyValue> values)
	{
		return default(MatchResult);
	}

	[Token(Token = "0x60028C1")]
	[Address(RVA = "0x2A89340", Offset = "0x2A88540", VA = "0x182A89340", Slot = "4")]
	protected override bool MatchKeyword(string keyword)
	{
		return default(bool);
	}

	[Token(Token = "0x60028C2")]
	[Address(RVA = "0x2A892A0", Offset = "0x2A884A0", VA = "0x182A892A0", Slot = "5")]
	protected override bool MatchNumber()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C3")]
	[Address(RVA = "0x2A892A0", Offset = "0x2A884A0", VA = "0x182A892A0", Slot = "6")]
	protected override bool MatchInteger()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C4")]
	[Address(RVA = "0x2A89450", Offset = "0x2A88650", VA = "0x182A89450", Slot = "7")]
	protected override bool MatchLength()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C5")]
	[Address(RVA = "0x2A89560", Offset = "0x2A88760", VA = "0x182A89560", Slot = "8")]
	protected override bool MatchPercentage()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C6")]
	[Address(RVA = "0x2A89030", Offset = "0x2A88230", VA = "0x182A89030", Slot = "9")]
	protected override bool MatchColor()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C7")]
	[Address(RVA = "0x2A89670", Offset = "0x2A88870", VA = "0x182A89670", Slot = "10")]
	protected override bool MatchResource()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C8")]
	[Address(RVA = "0x2A89800", Offset = "0x2A88A00", VA = "0x182A89800", Slot = "11")]
	protected override bool MatchUrl()
	{
		return default(bool);
	}

	[Token(Token = "0x60028C9")]
	[Address(RVA = "0x2A89710", Offset = "0x2A88910", VA = "0x182A89710", Slot = "12")]
	protected override bool MatchTime()
	{
		return default(bool);
	}

	[Token(Token = "0x60028CA")]
	[Address(RVA = "0x2A89160", Offset = "0x2A88360", VA = "0x182A89160", Slot = "14")]
	protected override bool MatchCustomIdent()
	{
		return default(bool);
	}

	[Token(Token = "0x60028CB")]
	[Address(RVA = "0x2A88F20", Offset = "0x2A88120", VA = "0x182A88F20", Slot = "13")]
	protected override bool MatchAngle()
	{
		return default(bool);
	}

	[Token(Token = "0x60028CC")]
	[Address(RVA = "0x2A89B70", Offset = "0x2A88D70", VA = "0x182A89B70")]
	public StylePropertyValueMatcher()
	{
	}
}
