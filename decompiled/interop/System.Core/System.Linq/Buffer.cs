using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq;

[Token(Token = "0x200002D")]
internal struct Buffer<TElement>
{
	[Token(Token = "0x40000AC")]
	[FieldOffset(Offset = "0x0")]
	internal TElement[] items;

	[Token(Token = "0x40000AD")]
	[FieldOffset(Offset = "0x0")]
	internal int count;

	[Token(Token = "0x6000138")]
	internal Buffer(IEnumerable<TElement> source)
	{
	}

	[Token(Token = "0x6000139")]
	internal TElement[] ToArray()
	{
		return null;
	}
}
