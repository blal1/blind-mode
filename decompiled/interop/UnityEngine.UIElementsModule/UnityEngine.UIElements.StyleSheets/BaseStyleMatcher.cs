using System.Collections.Generic;
using System.Text.RegularExpressions;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets.Syntax;

namespace UnityEngine.UIElements.StyleSheets;

[Token(Token = "0x20005D6")]
internal abstract class BaseStyleMatcher
{
	[Token(Token = "0x20005D7")]
	private struct MatchContext
	{
		[Token(Token = "0x4001587")]
		[FieldOffset(Offset = "0x0")]
		public int valueIndex;

		[Token(Token = "0x4001588")]
		[FieldOffset(Offset = "0x4")]
		public int matchedVariableCount;
	}

	[Token(Token = "0x4001584")]
	[FieldOffset(Offset = "0x0")]
	protected static readonly Regex s_CustomIdentRegex;

	[Token(Token = "0x4001585")]
	[FieldOffset(Offset = "0x10")]
	private Stack<MatchContext> m_ContextStack;

	[Token(Token = "0x4001586")]
	[FieldOffset(Offset = "0x18")]
	private MatchContext m_CurrentContext;

	[Token(Token = "0x17000A7E")]
	public abstract int valueCount
	{
		[Token(Token = "0x60028A1")]
		get;
	}

	[Token(Token = "0x17000A7F")]
	public abstract bool isCurrentVariable
	{
		[Token(Token = "0x60028A2")]
		get;
	}

	[Token(Token = "0x17000A80")]
	public abstract bool isCurrentComma
	{
		[Token(Token = "0x60028A3")]
		get;
	}

	[Token(Token = "0x17000A81")]
	public bool hasCurrent
	{
		[Token(Token = "0x60028A4")]
		[Address(RVA = "0x2A81E30", Offset = "0x2A81030", VA = "0x182A81E30")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000A82")]
	public int currentIndex
	{
		[Token(Token = "0x60028A5")]
		[Address(RVA = "0x5C7C60", Offset = "0x5C6E60", VA = "0x1805C7C60")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A6")]
		[Address(RVA = "0x615AB0", Offset = "0x614CB0", VA = "0x180615AB0")]
		set
		{
		}
	}

	[Token(Token = "0x17000A83")]
	public int matchedVariableCount
	{
		[Token(Token = "0x60028A7")]
		[Address(RVA = "0x62E220", Offset = "0x62D420", VA = "0x18062E220")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x60028A8")]
		[Address(RVA = "0x62E250", Offset = "0x62D450", VA = "0x18062E250")]
		set
		{
		}
	}

	[Token(Token = "0x6002896")]
	protected abstract bool MatchKeyword(string keyword);

	[Token(Token = "0x6002897")]
	protected abstract bool MatchNumber();

	[Token(Token = "0x6002898")]
	protected abstract bool MatchInteger();

	[Token(Token = "0x6002899")]
	protected abstract bool MatchLength();

	[Token(Token = "0x600289A")]
	protected abstract bool MatchPercentage();

	[Token(Token = "0x600289B")]
	protected abstract bool MatchColor();

	[Token(Token = "0x600289C")]
	protected abstract bool MatchResource();

	[Token(Token = "0x600289D")]
	protected abstract bool MatchUrl();

	[Token(Token = "0x600289E")]
	protected abstract bool MatchTime();

	[Token(Token = "0x600289F")]
	protected abstract bool MatchAngle();

	[Token(Token = "0x60028A0")]
	protected abstract bool MatchCustomIdent();

	[Token(Token = "0x60028A9")]
	[Address(RVA = "0x2A80C30", Offset = "0x2A7FE30", VA = "0x182A80C30")]
	protected void Initialize()
	{
	}

	[Token(Token = "0x60028AA")]
	[Address(RVA = "0x2A81C40", Offset = "0x2A80E40", VA = "0x182A81C40")]
	public void MoveNext()
	{
	}

	[Token(Token = "0x60028AB")]
	[Address(RVA = "0x2A81CD0", Offset = "0x2A80ED0", VA = "0x182A81CD0")]
	public void SaveContext()
	{
	}

	[Token(Token = "0x60028AC")]
	[Address(RVA = "0x2A81C80", Offset = "0x2A80E80", VA = "0x182A81C80")]
	public void RestoreContext()
	{
	}

	[Token(Token = "0x60028AD")]
	[Address(RVA = "0x2A80BE0", Offset = "0x2A7FDE0", VA = "0x182A80BE0")]
	public void DropContext()
	{
	}

	[Token(Token = "0x60028AE")]
	[Address(RVA = "0x2A81AB0", Offset = "0x2A80CB0", VA = "0x182A81AB0")]
	protected bool Match(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028AF")]
	[Address(RVA = "0x2A812B0", Offset = "0x2A804B0", VA = "0x182A812B0")]
	private bool MatchExpression(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B0")]
	[Address(RVA = "0x2A81190", Offset = "0x2A80390", VA = "0x182A81190")]
	private bool MatchExpressionWithMultiplier(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B1")]
	[Address(RVA = "0x2A81500", Offset = "0x2A80700", VA = "0x182A81500")]
	private bool MatchGroup(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B2")]
	[Address(RVA = "0x2A80CC0", Offset = "0x2A7FEC0", VA = "0x182A80CC0")]
	private bool MatchCombinator(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B3")]
	[Address(RVA = "0x2A81980", Offset = "0x2A80B80", VA = "0x182A81980")]
	private bool MatchOr(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B4")]
	[Address(RVA = "0x2A81960", Offset = "0x2A80B60", VA = "0x182A81960")]
	private bool MatchOrOr(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B5")]
	[Address(RVA = "0x2A80C80", Offset = "0x2A7FE80", VA = "0x182A80C80")]
	private bool MatchAndAnd(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B6")]
	[Address(RVA = "0x2A817A0", Offset = "0x2A809A0", VA = "0x182A817A0")]
	private int MatchMany(Expression exp)
	{
		return default(int);
	}

	[Token(Token = "0x60028B7")]
	[Address(RVA = "0x2A81630", Offset = "0x2A80830", VA = "0x182A81630")]
	private unsafe int MatchManyByOrder(Expression exp, int* matchOrder)
	{
		return default(int);
	}

	[Token(Token = "0x60028B8")]
	[Address(RVA = "0x2A815B0", Offset = "0x2A807B0", VA = "0x182A815B0")]
	private bool MatchJuxtaposition(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028B9")]
	[Address(RVA = "0x2A81010", Offset = "0x2A80210", VA = "0x182A81010")]
	private bool MatchDataType(Expression exp)
	{
		return default(bool);
	}

	[Token(Token = "0x60028BA")]
	[Address(RVA = "0x2A81DB0", Offset = "0x2A80FB0", VA = "0x182A81DB0")]
	protected BaseStyleMatcher()
	{
	}
}
