using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Unity.Properties.Internal;

[Token(Token = "0x200009E")]
internal static class PropertyBagStore
{
	[Token(Token = "0x200009F")]
	internal struct TypedStore<TContainer>
	{
		[Token(Token = "0x4000160")]
		[FieldOffset(Offset = "0x0")]
		public static IPropertyBag<TContainer> PropertyBag;
	}

	[Token(Token = "0x400015D")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ConcurrentDictionary<Type, IPropertyBag> s_PropertyBags;

	[Token(Token = "0x400015E")]
	[FieldOffset(Offset = "0x8")]
	private static readonly List<Type> s_RegisteredTypes;

	[Token(Token = "0x400015F")]
	[FieldOffset(Offset = "0x10")]
	private static ReflectedPropertyBagProvider s_PropertyBagProvider;

	[Token(Token = "0x17000095")]
	private static ReflectedPropertyBagProvider ReflectedPropertyBagProvider
	{
		[Token(Token = "0x6000321")]
		[Address(RVA = "0x28F1870", Offset = "0x28F0A70", VA = "0x1828F1870")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000322")]
	[Address(RVA = "0x28F11F0", Offset = "0x28F03F0", VA = "0x1828F11F0")]
	internal static void CreatePropertyBagProvider()
	{
	}

	[Token(Token = "0x6000323")]
	internal static void AddPropertyBag<TContainer>(IPropertyBag<TContainer> propertyBag)
	{
	}

	[Token(Token = "0x6000324")]
	internal static IPropertyBag<TContainer> GetPropertyBag<TContainer>()
	{
		return null;
	}

	[Token(Token = "0x6000325")]
	[Address(RVA = "0x28F1280", Offset = "0x28F0480", VA = "0x1828F1280")]
	internal static IPropertyBag GetPropertyBag(Type type)
	{
		return null;
	}

	[Token(Token = "0x6000326")]
	internal static bool TryGetPropertyBagForValue<TValue>(ref TValue value, out IPropertyBag propertyBag)
	{
		return default(bool);
	}
}
