using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x200002B")]
internal abstract class EnumerableSorter<TElement>
{
	[Token(Token = "0x6000130")]
	internal abstract void ComputeKeys(TElement[] elements, int count);

	[Token(Token = "0x6000131")]
	internal abstract int CompareKeys(int index1, int index2);

	[Token(Token = "0x6000132")]
	internal int[] Sort(TElement[] elements, int count)
	{
		return null;
	}

	[Token(Token = "0x6000133")]
	private void QuickSort(int[] map, int left, int right)
	{
	}

	[Token(Token = "0x6000134")]
	protected EnumerableSorter()
	{
	}
}
[Token(Token = "0x200002C")]
internal class EnumerableSorter<TElement, TKey> : EnumerableSorter<TElement>
{
	[Token(Token = "0x40000A7")]
	[FieldOffset(Offset = "0x0")]
	internal Func<TElement, TKey> keySelector;

	[Token(Token = "0x40000A8")]
	[FieldOffset(Offset = "0x0")]
	internal IComparer<TKey> comparer;

	[Token(Token = "0x40000A9")]
	[FieldOffset(Offset = "0x0")]
	internal bool descending;

	[Token(Token = "0x40000AA")]
	[FieldOffset(Offset = "0x0")]
	internal EnumerableSorter<TElement> next;

	[Token(Token = "0x40000AB")]
	[FieldOffset(Offset = "0x0")]
	internal TKey[] keys;

	[Token(Token = "0x6000135")]
	internal EnumerableSorter(Func<TElement, TKey> keySelector, IComparer<TKey> comparer, bool descending, EnumerableSorter<TElement> next)
	{
	}

	[Token(Token = "0x6000136")]
	internal override void ComputeKeys(TElement[] elements, int count)
	{
	}

	[Token(Token = "0x6000137")]
	internal override int CompareKeys(int index1, int index2)
	{
		return default(int);
	}
}
