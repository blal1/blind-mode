using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using Il2CppDummyDll;

namespace System.Linq.Expressions;

[Token(Token = "0x2000037")]
[DebuggerTypeProxy(typeof(MemberExpressionProxy))]
public class MemberExpression : Expression
{
	[Token(Token = "0x1700002D")]
	public MemberInfo Member
	{
		[Token(Token = "0x600013E")]
		[Address(RVA = "0x417C60", Offset = "0x416E60", VA = "0x180417C60")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600013F")]
	[Address(RVA = "0x20603C0", Offset = "0x205F5C0", VA = "0x1820603C0", Slot = "5")]
	[ExcludeFromCodeCoverage]
	internal virtual MemberInfo GetMember()
	{
		return null;
	}
}
