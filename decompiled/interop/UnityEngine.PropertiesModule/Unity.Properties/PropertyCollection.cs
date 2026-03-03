using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000042")]
public readonly struct PropertyCollection<TContainer> : IEnumerable<IProperty<TContainer>>, IEnumerable
{
	[Token(Token = "0x2000043")]
	private enum EnumeratorType
	{
		[Token(Token = "0x4000066")]
		Empty,
		[Token(Token = "0x4000067")]
		Enumerable,
		[Token(Token = "0x4000068")]
		List,
		[Token(Token = "0x4000069")]
		IndexedCollectionPropertyBag
	}

	[Token(Token = "0x2000044")]
	public struct Enumerator : IEnumerator<IProperty<TContainer>>, IEnumerator, IDisposable
	{
		[Token(Token = "0x400006A")]
		[FieldOffset(Offset = "0x0")]
		private readonly EnumeratorType m_Type;

		[Token(Token = "0x400006B")]
		[FieldOffset(Offset = "0x0")]
		private IEnumerator<IProperty<TContainer>> m_Enumerator;

		[Token(Token = "0x400006C")]
		[FieldOffset(Offset = "0x0")]
		private List<IProperty<TContainer>>.Enumerator m_Properties;

		[Token(Token = "0x400006D")]
		[FieldOffset(Offset = "0x0")]
		private IndexedCollectionPropertyBagEnumerator<TContainer> m_IndexedCollectionPropertyBag;

		[Token(Token = "0x17000034")]
		public IProperty<TContainer> Current
		{
			[Token(Token = "0x600010C")]
			[CompilerGenerated]
			readonly get
			{
				return null;
			}
			[Token(Token = "0x600010D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Token(Token = "0x17000035")]
		private object System_002ECollections_002EIEnumerator_002ECurrent
		{
			[Token(Token = "0x600010E")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x600010F")]
		internal Enumerator(IEnumerator<IProperty<TContainer>> enumerator)
		{
		}

		[Token(Token = "0x6000110")]
		internal Enumerator(List<IProperty<TContainer>>.Enumerator properties)
		{
		}

		[Token(Token = "0x6000111")]
		internal Enumerator(IndexedCollectionPropertyBagEnumerator<TContainer> enumerator)
		{
		}

		[Token(Token = "0x6000112")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Token(Token = "0x6000113")]
		public void Reset()
		{
		}

		[Token(Token = "0x6000114")]
		public void Dispose()
		{
		}
	}

	[Token(Token = "0x4000060")]
	[FieldOffset(Offset = "0x0")]
	private readonly EnumeratorType m_Type;

	[Token(Token = "0x4000061")]
	[FieldOffset(Offset = "0x0")]
	private readonly IEnumerable<IProperty<TContainer>> m_Enumerable;

	[Token(Token = "0x4000062")]
	[FieldOffset(Offset = "0x0")]
	private readonly List<IProperty<TContainer>> m_Properties;

	[Token(Token = "0x4000063")]
	[FieldOffset(Offset = "0x0")]
	private readonly IndexedCollectionPropertyBagEnumerable<TContainer> m_IndexedCollectionPropertyBag;

	[Token(Token = "0x17000033")]
	public static PropertyCollection<TContainer> Empty
	{
		[Token(Token = "0x6000104")]
		[CompilerGenerated]
		get
		{
			return default(PropertyCollection<TContainer>);
		}
	}

	[Token(Token = "0x6000105")]
	public PropertyCollection(IEnumerable<IProperty<TContainer>> enumerable)
	{
	}

	[Token(Token = "0x6000106")]
	public PropertyCollection(List<IProperty<TContainer>> properties)
	{
	}

	[Token(Token = "0x6000107")]
	internal PropertyCollection(IndexedCollectionPropertyBagEnumerable<TContainer> enumerable)
	{
	}

	[Token(Token = "0x6000108")]
	public Enumerator GetEnumerator()
	{
		return default(Enumerator);
	}

	[Token(Token = "0x6000109")]
	private IEnumerator<IProperty<TContainer>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002EProperties_002EIProperty_003CTContainer_003E_003E_002EGetEnumerator()
	{
		return null;
	}

	[Token(Token = "0x600010A")]
	private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
	{
		return null;
	}
}
