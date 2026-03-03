using System.Diagnostics;
using Il2CppDummyDll;

namespace System.Linq.Expressions;

[Token(Token = "0x2000035")]
[DebuggerTypeProxy(typeof(LambdaExpressionProxy))]
public abstract class LambdaExpression : Expression
{
	[Token(Token = "0x4000107")]
	[FieldOffset(Offset = "0x10")]
	private readonly Expression _body;

	[Token(Token = "0x1700002C")]
	public Expression Body
	{
		[Token(Token = "0x600013D")]
		[Address(RVA = "0x40C440", Offset = "0x40B640", VA = "0x18040C440")]
		get
		{
			return null;
		}
	}
}
