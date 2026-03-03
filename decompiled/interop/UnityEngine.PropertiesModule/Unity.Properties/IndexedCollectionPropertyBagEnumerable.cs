using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000029")]
internal readonly struct IndexedCollectionPropertyBagEnumerable<TContainer>
{
	[Token(Token = "0x4000045")]
	[FieldOffset(Offset = "0x0")]
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl;

	[Token(Token = "0x4000046")]
	[FieldOffset(Offset = "0x0")]
	private readonly TContainer m_Container;

	[Token(Token = "0x600009B")]
	public IndexedCollectionPropertyBagEnumerable(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container)
	{
	}

	[Token(Token = "0x600009C")]
	public IndexedCollectionPropertyBagEnumerator<TContainer> GetEnumerator()
	{
		return default(IndexedCollectionPropertyBagEnumerator<TContainer>);
	}
}
