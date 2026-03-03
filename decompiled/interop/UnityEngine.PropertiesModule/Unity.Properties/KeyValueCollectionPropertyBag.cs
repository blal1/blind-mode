using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x2000038")]
public class KeyValueCollectionPropertyBag<TDictionary, TKey, TValue> : PropertyBag<TDictionary>, IDictionaryPropertyBag<TDictionary, TKey, TValue>, ICollectionPropertyBag<TDictionary, KeyValuePair<TKey, TValue>>, IPropertyBag<TDictionary>, IPropertyBag, ICollectionPropertyBagAccept<TDictionary>, IDictionaryPropertyBagAccept<TDictionary>, IKeyedProperties<TDictionary, object> where TDictionary : IDictionary<TKey, TValue>
{
	[Token(Token = "0x2000039")]
	private class KeyValuePairProperty : Property<TDictionary, KeyValuePair<TKey, TValue>>, IDictionaryElementProperty
	{
		[Token(Token = "0x17000028")]
		public override string Name
		{
			[Token(Token = "0x60000C8")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x17000029")]
		public override bool IsReadOnly
		{
			[Token(Token = "0x60000C9")]
			get
			{
				return default(bool);
			}
		}

		[Token(Token = "0x1700002A")]
		public TKey Key
		{
			[Token(Token = "0x60000CC")]
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
			[Token(Token = "0x60000CD")]
			[CompilerGenerated]
			internal set
			{
			}
		}

		[Token(Token = "0x1700002B")]
		public object ObjectKey
		{
			[Token(Token = "0x60000CE")]
			get
			{
				return null;
			}
		}

		[Token(Token = "0x60000CA")]
		public override KeyValuePair<TKey, TValue> GetValue(ref TDictionary container)
		{
			return default(KeyValuePair<TKey, TValue>);
		}

		[Token(Token = "0x60000CB")]
		public override void SetValue(ref TDictionary container, KeyValuePair<TKey, TValue> value)
		{
		}

		[Token(Token = "0x60000CF")]
		public KeyValuePairProperty()
		{
		}
	}

	[Token(Token = "0x200003A")]
	private readonly struct Enumerable : IEnumerable<IProperty<TDictionary>>, IEnumerable
	{
		[Token(Token = "0x200003B")]
		private class Enumerator : IEnumerator<IProperty<TDictionary>>, IEnumerator, IDisposable
		{
			[Token(Token = "0x4000054")]
			[FieldOffset(Offset = "0x0")]
			private readonly TDictionary m_Dictionary;

			[Token(Token = "0x4000055")]
			[FieldOffset(Offset = "0x0")]
			private readonly KeyValuePairProperty m_Property;

			[Token(Token = "0x4000056")]
			[FieldOffset(Offset = "0x0")]
			private readonly TKey m_Previous;

			[Token(Token = "0x4000057")]
			[FieldOffset(Offset = "0x0")]
			private readonly List<TKey> m_Keys;

			[Token(Token = "0x4000058")]
			[FieldOffset(Offset = "0x0")]
			private int m_Position;

			[Token(Token = "0x1700002C")]
			public IProperty<TDictionary> Current
			{
				[Token(Token = "0x60000D4")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x1700002D")]
			private object System_002ECollections_002EIEnumerator_002ECurrent
			{
				[Token(Token = "0x60000D5")]
				get
				{
					return null;
				}
			}

			[Token(Token = "0x60000D3")]
			public Enumerator(TDictionary dictionary, KeyValuePairProperty property)
			{
			}

			[Token(Token = "0x60000D6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Token(Token = "0x60000D7")]
			public void Reset()
			{
			}

			[Token(Token = "0x60000D8")]
			public void Dispose()
			{
			}
		}

		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x0")]
		private readonly TDictionary m_Dictionary;

		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x0")]
		private readonly KeyValuePairProperty m_Property;

		[Token(Token = "0x60000D0")]
		public Enumerable(TDictionary dictionary, KeyValuePairProperty property)
		{
		}

		[Token(Token = "0x60000D1")]
		private IEnumerator System_002ECollections_002EIEnumerable_002EGetEnumerator()
		{
			return null;
		}

		[Token(Token = "0x60000D2")]
		private IEnumerator<IProperty<TDictionary>> System_002ECollections_002EGeneric_002EIEnumerable_003CUnity_002EProperties_002EIProperty_003CTDictionary_003E_003E_002EGetEnumerator()
		{
			return null;
		}
	}

	[Token(Token = "0x4000050")]
	[FieldOffset(Offset = "0x0")]
	private readonly KeyValuePairProperty m_KeyValuePairProperty;

	[Token(Token = "0x60000C2")]
	public override PropertyCollection<TDictionary> GetProperties()
	{
		return default(PropertyCollection<TDictionary>);
	}

	[Token(Token = "0x60000C3")]
	public override PropertyCollection<TDictionary> GetProperties(ref TDictionary container)
	{
		return default(PropertyCollection<TDictionary>);
	}

	[Token(Token = "0x60000C4")]
	private void Unity_002EProperties_002EICollectionPropertyBagAccept_003CTDictionary_003E_002EAccept(ICollectionPropertyBagVisitor visitor, ref TDictionary container)
	{
	}

	[Token(Token = "0x60000C5")]
	private void Unity_002EProperties_002EIDictionaryPropertyBagAccept_003CTDictionary_003E_002EAccept(IDictionaryPropertyBagVisitor visitor, ref TDictionary container)
	{
	}

	[Token(Token = "0x60000C6")]
	private bool Unity_002EProperties_002EIKeyedProperties_003CTDictionary_002CSystem_002EObject_003E_002ETryGetProperty(ref TDictionary container, object key, out IProperty<TDictionary> property)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C7")]
	public KeyValueCollectionPropertyBag()
	{
	}
}
