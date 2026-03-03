using System.Dynamic.Utils;
using System.Reflection;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq.Expressions;

[Token(Token = "0x200002E")]
public abstract class Expression
{
	[Token(Token = "0x200002F")]
	internal class LambdaExpressionProxy
	{
	}

	[Token(Token = "0x2000030")]
	internal class MemberExpressionProxy
	{
	}

	[Token(Token = "0x2000031")]
	internal class UnaryExpressionProxy
	{
	}

	[Token(Token = "0x2000032")]
	private class ExtensionInfo
	{
		[Token(Token = "0x40000B0")]
		[FieldOffset(Offset = "0x10")]
		internal readonly ExpressionType NodeType;
	}

	[Token(Token = "0x40000AE")]
	[FieldOffset(Offset = "0x0")]
	private static readonly CacheDict<Type, MethodInfo> s_lambdaDelegateCache;

	[Token(Token = "0x40000AF")]
	[FieldOffset(Offset = "0x8")]
	private static ConditionalWeakTable<Expression, ExtensionInfo> s_legacyCtorSupportTable;

	[Token(Token = "0x1700002B")]
	public virtual ExpressionType NodeType
	{
		[Token(Token = "0x600013A")]
		[Address(RVA = "0x20602D0", Offset = "0x205F4D0", VA = "0x1820602D0", Slot = "4")]
		get
		{
			return default(ExpressionType);
		}
	}
}
[Token(Token = "0x2000036")]
public class Expression<TDelegate> : LambdaExpression
{
}
