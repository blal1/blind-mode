using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x2000028")]
internal abstract class OrderedEnumerable<TElement> : IOrderedEnumerable<TElement>, IEnumerable<TElement>, IEnumerable
{
	[Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class _003CGetEnumerator_003Ed__1 : IEnumerator<TElement>, IDisposable, IEnumerator
	{
		[Token(Token = "0x400009D")]
		[FieldOffset(Offset = "0x0")]
		private int _003C_003E1__state;

		[Token(Token = "0x400009E")]
		[FieldOffset(Offset = "0x0")]
		private TElement _003C_003E2__current;

		[Token(Token = "0x400009F")]
		[FieldOffset(Offset = "0x0")]
		public OrderedEnumerable<TElement> _003C_003E4__this;

		[Token(Token = "0x40000A0")]
		[FieldOffset(Offset = "0x0")]
		private Buffer<TElement> _003Cbuffer_003E5__2;

		[Token(Token = "0x40000A1")]
		[FieldOffset(Offset = "0x0")]
		private int[] _003Cmap_003E5__3;

		[Token(Token = "0x40000A2")]
		[FieldOffset(Offset = "0x0")]
		private int _003Ci_003E5__4;

		[Token(Token = "0x17000029")]
		private TElement System_002ECollections_002EGeneric_002EIEnumerator_003CTElement_003E_002ECurrent
		{
			[Token(Token = "0x600012B")]
			[DebuggerHidden]
			get
			{
				return (TElement)null;
			}
		}

		[Token(Token = "0x1700002A")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600012D")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x6000128")]
		[DebuggerHidden]
		public _003CGetEnumerator_003Ed__1(int _003C_003E1__state)
		{
		}

		[Token(Token = "0x6000129")]
		[DebuggerHidden]
		private void System_002EIDisposable_002EDispose()
		{
		}

		[Token(Token = "0x600012A")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x600012C")]
		[DebuggerHidden]
		private void System_002ECollections_002EIEnumerator_002EReset()
		{
		}
	}

	[Token(Token = "0x400009C")]
	[FieldOffset(Offset = "0x0")]
	internal IEnumerable<TElement> source;

	[Token(Token = "0x6000123")]
	[IteratorStateMachine(typeof(OrderedEnumerable<>._003CGetEnumerator_003Ed__1))]
	public IEnumerator<TElement> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000124")]
	internal abstract EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next);

	[Token(Token = "0x6000125")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000126")]
	private IOrderedEnumerable<TElement> System_002ELinq_002EIOrderedEnumerable_003CTElement_003E_002ECreateOrderedEnumerable<TKey>(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
	{
		return null;
	}

	[Token(Token = "0x6000127")]
	protected OrderedEnumerable()
	{
	}
}
[Token(Token = "0x200002A")]
internal class OrderedEnumerable<TElement, TKey> : OrderedEnumerable<TElement>
{
	[Token(Token = "0x40000A3")]
	[FieldOffset(Offset = "0x0")]
	internal OrderedEnumerable<TElement> parent;

	[Token(Token = "0x40000A4")]
	[FieldOffset(Offset = "0x0")]
	internal Func<TElement, TKey> keySelector;

	[Token(Token = "0x40000A5")]
	[FieldOffset(Offset = "0x0")]
	internal IComparer<TKey> comparer;

	[Token(Token = "0x40000A6")]
	[FieldOffset(Offset = "0x0")]
	internal bool descending;

	[Token(Token = "0x600012E")]
	internal OrderedEnumerable(IEnumerable<TElement> source, Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending)
	{
	}

	[Token(Token = "0x600012F")]
	internal override EnumerableSorter<TElement> GetEnumerableSorter(EnumerableSorter<TElement> next)
	{
		return null;
	}
}
