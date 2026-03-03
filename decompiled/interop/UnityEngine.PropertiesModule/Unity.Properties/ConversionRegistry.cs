using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace Unity.Properties;

[Token(Token = "0x2000059")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEngine.UIElementsModule" })]
internal readonly struct ConversionRegistry : IEqualityComparer<ConversionRegistry>
{
	[Token(Token = "0x200005A")]
	private class ConverterKeyComparer : IEqualityComparer<ConverterKey>
	{
		[Token(Token = "0x6000153")]
		[Address(RVA = "0x28D85B0", Offset = "0x28D77B0", VA = "0x1828D85B0", Slot = "4")]
		public bool Equals(ConverterKey x, ConverterKey y)
		{
			return default(bool);
		}

		[Token(Token = "0x6000154")]
		[Address(RVA = "0x28D8630", Offset = "0x28D7830", VA = "0x1828D8630", Slot = "5")]
		public int GetHashCode(ConverterKey obj)
		{
			return default(int);
		}

		[Token(Token = "0x6000155")]
		[Address(RVA = "0x3C7110", Offset = "0x3C6310", VA = "0x1803C7110")]
		public ConverterKeyComparer()
		{
		}
	}

	[Token(Token = "0x200005B")]
	private readonly struct ConverterKey
	{
		[Token(Token = "0x4000082")]
		[FieldOffset(Offset = "0x0")]
		public readonly Type SourceType;

		[Token(Token = "0x4000083")]
		[FieldOffset(Offset = "0x8")]
		public readonly Type DestinationType;

		[Token(Token = "0x6000156")]
		[Address(RVA = "0x5BF700", Offset = "0x5BE900", VA = "0x1805BF700")]
		public ConverterKey(Type source, Type destination)
		{
		}
	}

	[Token(Token = "0x4000080")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ConverterKeyComparer Comparer;

	[Token(Token = "0x4000081")]
	[FieldOffset(Offset = "0x0")]
	private readonly Dictionary<ConverterKey, Delegate> m_Converters;

	[Token(Token = "0x600014B")]
	[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
	private ConversionRegistry(Dictionary<ConverterKey, Delegate> storage)
	{
	}

	[Token(Token = "0x600014C")]
	[Address(RVA = "0x28D81F0", Offset = "0x28D73F0", VA = "0x1828D81F0")]
	public static ConversionRegistry Create()
	{
		return default(ConversionRegistry);
	}

	[Token(Token = "0x600014D")]
	[Address(RVA = "0x28D83A0", Offset = "0x28D75A0", VA = "0x1828D83A0")]
	public void Register(Type source, Type destination, Delegate converter)
	{
	}

	[Token(Token = "0x600014E")]
	[Address(RVA = "0x28D82B0", Offset = "0x28D74B0", VA = "0x1828D82B0")]
	public Delegate GetConverter(Type source, Type destination)
	{
		return null;
	}

	[Token(Token = "0x600014F")]
	[Address(RVA = "0x28D84A0", Offset = "0x28D76A0", VA = "0x1828D84A0")]
	public bool TryGetConverter(Type source, Type destination, out Delegate converter)
	{
		return default(bool);
	}

	[Token(Token = "0x6000150")]
	[Address(RVA = "0x28D82A0", Offset = "0x28D74A0", VA = "0x1828D82A0", Slot = "4")]
	public bool Equals(ConversionRegistry x, ConversionRegistry y)
	{
		return default(bool);
	}

	[Token(Token = "0x6000151")]
	[Address(RVA = "0x28D8370", Offset = "0x28D7570", VA = "0x1828D8370", Slot = "5")]
	public int GetHashCode(ConversionRegistry obj)
	{
		return default(int);
	}
}
