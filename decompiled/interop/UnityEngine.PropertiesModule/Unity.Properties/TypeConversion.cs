using System;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200005D")]
public static class TypeConversion
{
	[Token(Token = "0x200005E")]
	private static class PrimitiveConverters
	{
		[Token(Token = "0x600015F")]
		[Address(RVA = "0x28EFE30", Offset = "0x28EF030", VA = "0x1828EFE30")]
		public static void Register()
		{
		}

		[Token(Token = "0x6000160")]
		[Address(RVA = "0x28E3EA0", Offset = "0x28E30A0", VA = "0x1828E3EA0")]
		private static void RegisterInt8Converters()
		{
		}

		[Token(Token = "0x6000161")]
		[Address(RVA = "0x28DF680", Offset = "0x28DE880", VA = "0x1828DF680")]
		private static void RegisterInt16Converters()
		{
		}

		[Token(Token = "0x6000162")]
		[Address(RVA = "0x28E0E80", Offset = "0x28E0080", VA = "0x1828E0E80")]
		private static void RegisterInt32Converters()
		{
		}

		[Token(Token = "0x6000163")]
		[Address(RVA = "0x28E2690", Offset = "0x28E1890", VA = "0x1828E2690")]
		private static void RegisterInt64Converters()
		{
		}

		[Token(Token = "0x6000164")]
		[Address(RVA = "0x28EE620", Offset = "0x28ED820", VA = "0x1828EE620")]
		private static void RegisterUInt8Converters()
		{
		}

		[Token(Token = "0x6000165")]
		[Address(RVA = "0x28E9DF0", Offset = "0x28E8FF0", VA = "0x1828E9DF0")]
		private static void RegisterUInt16Converters()
		{
		}

		[Token(Token = "0x6000166")]
		[Address(RVA = "0x28EB600", Offset = "0x28EA800", VA = "0x1828EB600")]
		private static void RegisterUInt32Converters()
		{
		}

		[Token(Token = "0x6000167")]
		[Address(RVA = "0x28ECE10", Offset = "0x28EC010", VA = "0x1828ECE10")]
		private static void RegisterUInt64Converters()
		{
		}

		[Token(Token = "0x6000168")]
		[Address(RVA = "0x28DC660", Offset = "0x28DB860", VA = "0x1828DC660")]
		private static void RegisterFloat32Converters()
		{
		}

		[Token(Token = "0x6000169")]
		[Address(RVA = "0x28DDE70", Offset = "0x28DD070", VA = "0x1828DDE70")]
		private static void RegisterFloat64Converters()
		{
		}

		[Token(Token = "0x600016A")]
		[Address(RVA = "0x28D9250", Offset = "0x28D8450", VA = "0x1828D9250")]
		private static void RegisterBooleanConverters()
		{
		}

		[Token(Token = "0x600016B")]
		[Address(RVA = "0x28DAA60", Offset = "0x28D9C60", VA = "0x1828DAA60")]
		private static void RegisterCharConverters()
		{
		}

		[Token(Token = "0x600016C")]
		[Address(RVA = "0x28E6E50", Offset = "0x28E6050", VA = "0x1828E6E50")]
		private static void RegisterStringConverters()
		{
		}

		[Token(Token = "0x600016D")]
		[Address(RVA = "0x28E5640", Offset = "0x28E4840", VA = "0x1828E5640")]
		private static void RegisterObjectConverters()
		{
		}
	}

	[Token(Token = "0x4000084")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ConversionRegistry s_GlobalConverters;

	[Token(Token = "0x6000159")]
	[Address(RVA = "0x28F72F0", Offset = "0x28F64F0", VA = "0x1828F72F0")]
	static TypeConversion()
	{
	}

	[Token(Token = "0x600015A")]
	public static void Register<TSource, TDestination>(TypeConverter<TSource, TDestination> converter)
	{
	}

	[Token(Token = "0x600015B")]
	public static TDestination Convert<TSource, TDestination>(ref TSource value)
	{
		return (TDestination)null;
	}

	[Token(Token = "0x600015C")]
	public static bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
	{
		return default(bool);
	}

	[Token(Token = "0x600015D")]
	private static bool TryConvertToUnityEngineObject<TSource, TDestination>(TSource source, out TDestination destination)
	{
		return default(bool);
	}

	[Token(Token = "0x600015E")]
	[Address(RVA = "0x28F72B0", Offset = "0x28F64B0", VA = "0x1828F72B0")]
	private static bool IsNumericType(Type t)
	{
		return default(bool);
	}
}
