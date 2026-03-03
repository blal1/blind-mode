using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x20005DE")]
internal struct ExpressionMultiplier
{
	[Token(Token = "0x40015B0")]
	public const int Infinity = 100;

	[Token(Token = "0x40015B1")]
	[FieldOffset(Offset = "0x0")]
	private ExpressionMultiplierType m_Type;

	[Token(Token = "0x40015B2")]
	[FieldOffset(Offset = "0x4")]
	public int min;

	[Token(Token = "0x40015B3")]
	[FieldOffset(Offset = "0x8")]
	public int max;

	[Token(Token = "0x17000A88")]
	public ExpressionMultiplierType type
	{
		[Token(Token = "0x60028CE")]
		[Address(RVA = "0x1500B10", Offset = "0x14FFD10", VA = "0x181500B10")]
		get
		{
			return default(ExpressionMultiplierType);
		}
		[Token(Token = "0x60028CF")]
		[Address(RVA = "0x2A82C80", Offset = "0x2A81E80", VA = "0x182A82C80")]
		set
		{
		}
	}

	[Token(Token = "0x60028D0")]
	[Address(RVA = "0x2A82C60", Offset = "0x2A81E60", VA = "0x182A82C60")]
	public ExpressionMultiplier(ExpressionMultiplierType type = ExpressionMultiplierType.None)
	{
	}

	[Token(Token = "0x60028D1")]
	[Address(RVA = "0x2A82BE0", Offset = "0x2A81DE0", VA = "0x182A82BE0")]
	private void SetType(ExpressionMultiplierType value)
	{
	}
}
