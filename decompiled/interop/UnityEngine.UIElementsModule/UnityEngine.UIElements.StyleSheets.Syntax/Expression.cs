using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements.StyleSheets.Syntax;

[Token(Token = "0x20005D9")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal class Expression
{
	[Token(Token = "0x400158A")]
	[FieldOffset(Offset = "0x10")]
	public ExpressionType type;

	[Token(Token = "0x400158B")]
	[FieldOffset(Offset = "0x14")]
	public ExpressionMultiplier multiplier;

	[Token(Token = "0x400158C")]
	[FieldOffset(Offset = "0x20")]
	public DataType dataType;

	[Token(Token = "0x400158D")]
	[FieldOffset(Offset = "0x24")]
	public ExpressionCombinator combinator;

	[Token(Token = "0x400158E")]
	[FieldOffset(Offset = "0x28")]
	public Expression[] subExpressions;

	[Token(Token = "0x400158F")]
	[FieldOffset(Offset = "0x30")]
	public string keyword;

	[Token(Token = "0x60028CD")]
	[Address(RVA = "0x2A82C90", Offset = "0x2A81E90", VA = "0x182A82C90")]
	public Expression(ExpressionType type)
	{
	}
}
