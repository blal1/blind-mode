using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000026")]
internal readonly struct TypeConverterRegistry : IEqualityComparer<TypeConverterRegistry>
{
	[Token(Token = "0x2000027")]
	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x28D85B0", Offset = "0x28D77B0", VA = "0x1828D85B0", Slot = "4")]
		public bool Equals(ConverterKey x, ConverterKey y)
		{
			return default(bool);
		}

		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x28D8630", Offset = "0x28D7830", VA = "0x1828D8630", Slot = "5")]
		public int GetHashCode(ConverterKey obj)
		{
			return default(int);
		}

		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ConverterKeyComparer()
		{
		}
	}

	[Token(Token = "0x2000028")]
	private readonly struct ConverterKey
	{
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x0")]
		public readonly Type SourceType;

		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x8")]
		public readonly Type DestinationType;

		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public ConverterKey(Type source, Type destination)
		{
		}
	}

	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ConverterKeyComparer k_Comparer;

	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<ConverterKey, Delegate> m_Converters;

	[Token(Token = "0x60000BA")]
	[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
	private TypeConverterRegistry(Dictionary<ConverterKey, Delegate> storage)
	{
	}

	[Token(Token = "0x60000BB")]
	[Address(RVA = "0x2998420", Offset = "0x2997620", VA = "0x182998420")]
	public static TypeConverterRegistry Create()
	{
		return default(TypeConverterRegistry);
	}

	[Token(Token = "0x60000BC")]
	[Address(RVA = "0x2998590", Offset = "0x2997790", VA = "0x182998590")]
	public void Register(Type source, Type destination, Delegate converter)
	{
	}

	[Token(Token = "0x60000BD")]
	[Address(RVA = "0x29981D0", Offset = "0x29973D0", VA = "0x1829981D0")]
	internal void Apply(TypeConverterRegistry registry)
	{
	}

	[Token(Token = "0x60000BE")]
	[Address(RVA = "0x29984D0", Offset = "0x29976D0", VA = "0x1829984D0")]
	public Delegate GetConverter(Type source, Type destination)
	{
		return null;
	}

	[Token(Token = "0x60000BF")]
	[Address(RVA = "0x2998690", Offset = "0x2997890", VA = "0x182998690")]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C0")]
	[Address(RVA = "0x28D82A0", Offset = "0x28D74A0", VA = "0x1828D82A0", Slot = "4")]
	public bool Equals(TypeConverterRegistry x, TypeConverterRegistry y)
	{
		return default(bool);
	}

	[Token(Token = "0x60000C1")]
	[Address(RVA = "0x28D8370", Offset = "0x28D7570", VA = "0x1828D8370", Slot = "5")]
	public int GetHashCode(TypeConverterRegistry obj)
	{
		return default(int);
	}
}
