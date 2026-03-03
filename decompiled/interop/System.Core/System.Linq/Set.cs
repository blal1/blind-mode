using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x2000024")]
internal class Set<TElement>
{
	[Token(Token = "0x2000025")]
	internal struct Slot
	{
		[Token(Token = "0x4000090")]
		[FieldOffset(Offset = "0x0")]
		internal int hashCode;

		[Token(Token = "0x4000091")]
		[FieldOffset(Offset = "0x0")]
		internal TElement value;

		[Token(Token = "0x4000092")]
		[FieldOffset(Offset = "0x0")]
		internal int next;
	}

	[Token(Token = "0x400008B")]
	[FieldOffset(Offset = "0x0")]
	private int[] buckets;

	[Token(Token = "0x400008C")]
	[FieldOffset(Offset = "0x0")]
	private Slot[] slots;

	[Token(Token = "0x400008D")]
	[FieldOffset(Offset = "0x0")]
	private int count;

	[Token(Token = "0x400008E")]
	[FieldOffset(Offset = "0x0")]
	private int freeList;

	[Token(Token = "0x400008F")]
	[FieldOffset(Offset = "0x0")]
	private IEqualityComparer<TElement> comparer;

	[Token(Token = "0x6000118")]
	public Set(IEqualityComparer<TElement> comparer)
	{
	}

	[Token(Token = "0x6000119")]
	public bool Add(TElement value)
	{
		return default(bool);
	}

	[Token(Token = "0x600011A")]
	private bool Find(TElement value, bool add)
	{
		return default(bool);
	}

	[Token(Token = "0x600011B")]
	private void Resize()
	{
	}

	[Token(Token = "0x600011C")]
	internal int InternalGetHashCode(TElement value)
	{
		return default(int);
	}
}
