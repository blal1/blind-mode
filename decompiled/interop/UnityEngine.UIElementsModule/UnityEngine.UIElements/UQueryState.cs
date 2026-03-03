using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x200047D")]
public struct UQueryState<T> : IEnumerable<T>, IEnumerable, IEquatable<UQueryState<T>> where T : VisualElement
{
	[Token(Token = "0x200047E")]
	private class ListQueryMatcher<TElement> : UQuery.UQueryMatcher where TElement : VisualElement
	{
		[Token(Token = "0x17000909")]
		public List<TElement> matches
		{
			[Token(Token = "0x60021F4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021F5")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60021F6")]
		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x60021F7")]
		public void Reset()
		{
		}

		[Token(Token = "0x60021F8")]
		public ListQueryMatcher()
		{
		}
	}

	[Token(Token = "0x200047F")]
	private class ActionQueryMatcher : UQuery.UQueryMatcher
	{
		[Token(Token = "0x1700090A")]
		internal Action<T> callBack
		{
			[Token(Token = "0x60021F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021FA")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60021FB")]
		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x60021FC")]
		public ActionQueryMatcher()
		{
		}
	}

	[Token(Token = "0x2000480")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Token(Token = "0x4000F10")]
		[FieldOffset(Offset = "0x0")]
		private List<VisualElement> iterationList;

		[Token(Token = "0x4000F11")]
		[FieldOffset(Offset = "0x0")]
		private int currentIndex;

		[Token(Token = "0x1700090B")]
		public T Current
		{
			[Token(Token = "0x60021FE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x1700090C")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x60021FF")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60021FD")]
		internal Enumerator(UQueryState<T> queryState)
		{
		}

		[Token(Token = "0x6002200")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6002201")]
		public void Reset()
		{
		}

		[Token(Token = "0x6002202")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x4000F09")]
	[FieldOffset(Offset = "0x0")]
	private static ActionQueryMatcher s_Action;

	[Token(Token = "0x4000F0A")]
	[FieldOffset(Offset = "0x0")]
	private readonly VisualElement m_Element;

	[Token(Token = "0x4000F0B")]
	[FieldOffset(Offset = "0x0")]
	internal readonly List<RuleMatcher> m_Matchers;

	[Token(Token = "0x4000F0C")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ListQueryMatcher<T> s_List;

	[Token(Token = "0x4000F0D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ListQueryMatcher<VisualElement> s_EnumerationList;

	[Token(Token = "0x60021E6")]
	internal UQueryState(VisualElement element, List<RuleMatcher> matchers)
	{
	}

	[Token(Token = "0x60021E7")]
	public UQueryState<T> RebuildOn(VisualElement element)
	{
		return default(UQueryState<T>);
	}

	[Token(Token = "0x60021E8")]
	private T Single(UQuery.SingleQueryMatcher matcher)
	{
		return null;
	}

	[Token(Token = "0x60021E9")]
	public T First()
	{
		return null;
	}

	[Token(Token = "0x60021EA")]
	public void ToList(List<T> results)
	{
	}

	[Token(Token = "0x60021EB")]
	public List<T> ToList()
	{
		return null;
	}

	[Token(Token = "0x60021EC")]
	public void ForEach(Action<T> funcCall)
	{
	}

	[Token(Token = "0x60021ED")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x60021EE")]
	private IEnumerator<T> System_002ECollections_002EGeneric_002EIEnumerable_003CT_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60021EF")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x60021F0")]
	public bool Equals(UQueryState<T> other)
	{
		return default(bool);
	}

	[Token(Token = "0x60021F1")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60021F2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
