using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000476")]
public static class UQuery
{
	[Token(Token = "0x2000477")]
	internal interface IVisualPredicateWrapper
	{
		[Token(Token = "0x60021CF")]
		bool Predicate(object e);
	}

	[Token(Token = "0x2000478")]
	internal class IsOfType<T> : IVisualPredicateWrapper where T : VisualElement
	{
		[Token(Token = "0x4000F03")]
		[FieldOffset(Offset = "0x0")]
		public static IsOfType<T> s_Instance;

		[Token(Token = "0x60021D0")]
		public bool Predicate(object e)
		{
			return default(bool);
		}

		[Token(Token = "0x60021D1")]
		public IsOfType()
		{
		}
	}

	[Token(Token = "0x2000479")]
	internal abstract class UQueryMatcher : HierarchyTraversal
	{
		[Token(Token = "0x4000F04")]
		[FieldOffset(Offset = "0x10")]
		internal List<RuleMatcher> m_Matchers;

		[Token(Token = "0x60021D3")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		protected UQueryMatcher()
		{
		}

		[Token(Token = "0x60021D4")]
		[Address(RVA = "0x2A1B670", Offset = "0x2A1A870", VA = "0x182A1B670", Slot = "4")]
		public override void Traverse(VisualElement element)
		{
		}

		[Token(Token = "0x60021D5")]
		[Address(RVA = "0xA2E980", Offset = "0xA2DB80", VA = "0x180A2E980", Slot = "6")]
		protected virtual bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x60021D6")]
		[Address(RVA = "0x3C7A60", Offset = "0x3C6C60", VA = "0x1803C7A60")]
		private static void NoProcessResult(VisualElement e, MatchResultInfo i)
		{
		}

		[Token(Token = "0x60021D7")]
		[Address(RVA = "0x2A1B450", Offset = "0x2A1A650", VA = "0x182A1B450", Slot = "5")]
		public override void TraverseRecursive(VisualElement element, int depth)
		{
		}

		[Token(Token = "0x60021D8")]
		[Address(RVA = "0x2A1B400", Offset = "0x2A1A600", VA = "0x182A1B400", Slot = "7")]
		public virtual void Run(VisualElement root, List<RuleMatcher> matchers)
		{
		}
	}

	[Token(Token = "0x200047B")]
	internal abstract class SingleQueryMatcher : UQueryMatcher
	{
		[Token(Token = "0x17000908")]
		public VisualElement match
		{
			[Token(Token = "0x60021DC")]
			[Address(RVA = "0x3E7E30", Offset = "0x3E7030", VA = "0x1803E7E30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60021DD")]
			[Address(RVA = "0x417C80", Offset = "0x416E80", VA = "0x180417C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Token(Token = "0x60021DE")]
		[Address(RVA = "0x2A0A610", Offset = "0x2A09810", VA = "0x182A0A610", Slot = "7")]
		public override void Run(VisualElement root, List<RuleMatcher> matchers)
		{
		}

		[Token(Token = "0x60021DF")]
		[Address(RVA = "0x2A0A600", Offset = "0x2A09800", VA = "0x182A0A600")]
		public bool IsInUse()
		{
			return default(bool);
		}

		[Token(Token = "0x60021E0")]
		public abstract SingleQueryMatcher CreateNew();

		[Token(Token = "0x60021E1")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		protected SingleQueryMatcher()
		{
		}
	}

	[Token(Token = "0x200047C")]
	internal class FirstQueryMatcher : SingleQueryMatcher
	{
		[Token(Token = "0x4000F08")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FirstQueryMatcher Instance;

		[Token(Token = "0x60021E2")]
		[Address(RVA = "0x2A09B40", Offset = "0x2A08D40", VA = "0x182A09B40", Slot = "6")]
		protected override bool OnRuleMatchedElement(RuleMatcher matcher, VisualElement element)
		{
			return default(bool);
		}

		[Token(Token = "0x60021E3")]
		[Address(RVA = "0x2A09AF0", Offset = "0x2A08CF0", VA = "0x182A09AF0", Slot = "8")]
		public override SingleQueryMatcher CreateNew()
		{
			return null;
		}

		[Token(Token = "0x60021E4")]
		[Address(RVA = "0x3DC070", Offset = "0x3DB270", VA = "0x1803DC070")]
		public FirstQueryMatcher()
		{
		}
	}
}
