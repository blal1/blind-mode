using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x2000026")]
internal class GroupedEnumerable<TSource, TKey, TElement, TResult> : IEnumerable<TResult>, IEnumerable
{
	[Token(Token = "0x4000093")]
	[FieldOffset(Offset = "0x0")]
	private IEnumerable<TSource> source;

	[Token(Token = "0x4000094")]
	[FieldOffset(Offset = "0x0")]
	private Func<TSource, TKey> keySelector;

	[Token(Token = "0x4000095")]
	[FieldOffset(Offset = "0x0")]
	private Func<TSource, TElement> elementSelector;

	[Token(Token = "0x4000096")]
	[FieldOffset(Offset = "0x0")]
	private IEqualityComparer<TKey> comparer;

	[Token(Token = "0x4000097")]
	[FieldOffset(Offset = "0x0")]
	private Func<TKey, IEnumerable<TElement>, TResult> resultSelector;

	[Token(Token = "0x600011D")]
	public GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, Func<TKey, IEnumerable<TElement>, TResult> resultSelector, IEqualityComparer<TKey> comparer)
	{
	}

	[Token(Token = "0x600011E")]
	public IEnumerator<TResult> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600011F")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
[Token(Token = "0x2000027")]
internal class GroupedEnumerable<TSource, TKey, TElement> : IEnumerable<IGrouping<TKey, TElement>>, IEnumerable
{
	[Token(Token = "0x4000098")]
	[FieldOffset(Offset = "0x0")]
	private IEnumerable<TSource> source;

	[Token(Token = "0x4000099")]
	[FieldOffset(Offset = "0x0")]
	private Func<TSource, TKey> keySelector;

	[Token(Token = "0x400009A")]
	[FieldOffset(Offset = "0x0")]
	private Func<TSource, TElement> elementSelector;

	[Token(Token = "0x400009B")]
	[FieldOffset(Offset = "0x0")]
	private IEqualityComparer<TKey> comparer;

	[Token(Token = "0x6000120")]
	public GroupedEnumerable(IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TElement> elementSelector, IEqualityComparer<TKey> comparer)
	{
	}

	[Token(Token = "0x6000121")]
	public IEnumerator<IGrouping<TKey, TElement>> GetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x6000122")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
