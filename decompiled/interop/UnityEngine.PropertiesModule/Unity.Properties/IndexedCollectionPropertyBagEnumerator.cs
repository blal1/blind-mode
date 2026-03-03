using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200002A")]
internal struct IndexedCollectionPropertyBagEnumerator<TContainer> : IEnumerator<IProperty<TContainer>>, IEnumerator, IDisposable
{
	[Token(Token = "0x4000047")]
	[FieldOffset(Offset = "0x0")]
	private readonly IIndexedCollectionPropertyBagEnumerator<TContainer> m_Impl;

	[Token(Token = "0x4000048")]
	[FieldOffset(Offset = "0x0")]
	private readonly IndexedCollectionSharedPropertyState m_Previous;

	[Token(Token = "0x4000049")]
	[FieldOffset(Offset = "0x0")]
	private TContainer m_Container;

	[Token(Token = "0x400004A")]
	[FieldOffset(Offset = "0x0")]
	private int m_Position;

	[Token(Token = "0x17000023")]
	public IProperty<TContainer> Current
	{
		[Token(Token = "0x600009E")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000024")]
	private object System_002ECollections_002EIEnumerator_002ECurrent
	{
		[Token(Token = "0x600009F")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600009D")]
	internal IndexedCollectionPropertyBagEnumerator(IIndexedCollectionPropertyBagEnumerator<TContainer> impl, TContainer container)
	{
	}

	[Token(Token = "0x60000A0")]
	public bool MoveNext()
	{
		return default(bool);
	}

	[Token(Token = "0x60000A1")]
	public void Reset()
	{
	}

	[Token(Token = "0x60000A2")]
	public void Dispose()
	{
	}
}
