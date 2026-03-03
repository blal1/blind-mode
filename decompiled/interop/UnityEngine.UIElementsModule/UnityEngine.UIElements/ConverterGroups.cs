using System.Collections.Generic;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000029")]
public static class ConverterGroups
{
	[Token(Token = "0x4000058")]
	[FieldOffset(Offset = "0x0")]
	private static readonly ConverterGroup s_GlobalConverters;

	[Token(Token = "0x4000059")]
	[FieldOffset(Offset = "0x8")]
	private static readonly ConverterGroup s_PrimitivesConverters;

	[Token(Token = "0x400005A")]
	[FieldOffset(Offset = "0x10")]
	private static readonly Dictionary<string, ConverterGroup> s_BindingConverterGroups;

	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x298CAB0", Offset = "0x298BCB0", VA = "0x18298CAB0")]
	static ConverterGroups()
	{
	}

	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x29864C0", Offset = "0x29856C0", VA = "0x1829864C0")]
	private static void RegisterPrimitivesConverter()
	{
	}

	[Token(Token = "0x60000C9")]
	internal static void RegisterGlobal<TSource, TDestination>(TypeConverter<TSource, TDestination> converter)
	{
	}

	[Token(Token = "0x60000CA")]
	public static bool TryConvert<TSource, TDestination>(ref TSource source, out TDestination destination)
	{
		return default(bool);
	}

	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x2984C50", Offset = "0x2983E50", VA = "0x182984C50")]
	private static void RegisterInt8Converters()
	{
	}

	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x29801F0", Offset = "0x297F3F0", VA = "0x1829801F0")]
	private static void RegisterInt16Converters()
	{
	}

	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x2981AB0", Offset = "0x2980CB0", VA = "0x182981AB0")]
	private static void RegisterInt32Converters()
	{
	}

	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x2983380", Offset = "0x2982580", VA = "0x182983380")]
	private static void RegisterInt64Converters()
	{
	}

	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x298AFD0", Offset = "0x298A1D0", VA = "0x18298AFD0")]
	private static void RegisterUInt8Converters()
	{
	}

	[Token(Token = "0x60000D0")]
	[Address(RVA = "0x2986560", Offset = "0x2985760", VA = "0x182986560")]
	private static void RegisterUInt16Converters()
	{
	}

	[Token(Token = "0x60000D1")]
	[Address(RVA = "0x2987E30", Offset = "0x2987030", VA = "0x182987E30")]
	private static void RegisterUInt32Converters()
	{
	}

	[Token(Token = "0x60000D2")]
	[Address(RVA = "0x2989700", Offset = "0x2988900", VA = "0x182989700")]
	private static void RegisterUInt64Converters()
	{
	}

	[Token(Token = "0x60000D3")]
	[Address(RVA = "0x297E710", Offset = "0x297D910", VA = "0x18297E710")]
	private static void RegisterFloatConverters()
	{
	}

	[Token(Token = "0x60000D4")]
	[Address(RVA = "0x297CC30", Offset = "0x297BE30", VA = "0x18297CC30")]
	private static void RegisterDoubleConverters()
	{
	}

	[Token(Token = "0x60000D5")]
	[Address(RVA = "0x29795F0", Offset = "0x29787F0", VA = "0x1829795F0")]
	private static void RegisterBooleanConverters()
	{
	}

	[Token(Token = "0x60000D6")]
	[Address(RVA = "0x297AEC0", Offset = "0x297A0C0", VA = "0x18297AEC0")]
	private static void RegisterCharConverters()
	{
	}

	[Token(Token = "0x60000D7")]
	[Address(RVA = "0x297C790", Offset = "0x297B990", VA = "0x18297C790")]
	private static void RegisterColorConverters()
	{
	}
}
