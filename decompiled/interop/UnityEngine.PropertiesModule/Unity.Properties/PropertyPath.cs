using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200001B")]
public readonly struct PropertyPath : IEquatable<PropertyPath>
{
	[Token(Token = "0x400002C")]
	internal const int k_InlineCount = 4;

	[Token(Token = "0x400002D")]
	[FieldOffset(Offset = "0x0")]
	private readonly PropertyPathPart m_Part0;

	[Token(Token = "0x400002E")]
	[FieldOffset(Offset = "0x20")]
	private readonly PropertyPathPart m_Part1;

	[Token(Token = "0x400002F")]
	[FieldOffset(Offset = "0x40")]
	private readonly PropertyPathPart m_Part2;

	[Token(Token = "0x4000030")]
	[FieldOffset(Offset = "0x60")]
	private readonly PropertyPathPart m_Part3;

	[Token(Token = "0x4000031")]
	[FieldOffset(Offset = "0x80")]
	private readonly PropertyPathPart[] m_AdditionalParts;

	[Token(Token = "0x17000012")]
	public int Length
	{
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x865350", Offset = "0x864550", VA = "0x180865350")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000013")]
	public bool IsEmpty
	{
		[Token(Token = "0x6000050")]
		[Address(RVA = "0xCD3960", Offset = "0xCD2B60", VA = "0x180CD3960")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x17000014")]
	public PropertyPathPart this[int index]
	{
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x28F5CF0", Offset = "0x28F4EF0", VA = "0x1828F5CF0")]
		get
		{
			return default(PropertyPathPart);
		}
	}

	[Token(Token = "0x6000052")]
	[Address(RVA = "0x28F5810", Offset = "0x28F4A10", VA = "0x1828F5810")]
	public PropertyPath(string path)
	{
	}

	[Token(Token = "0x6000053")]
	[Address(RVA = "0x28F5710", Offset = "0x28F4910", VA = "0x1828F5710")]
	private PropertyPath(in PropertyPathPart part)
	{
	}

	[Token(Token = "0x6000054")]
	[Address(RVA = "0x28F5780", Offset = "0x28F4980", VA = "0x1828F5780")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1)
	{
	}

	[Token(Token = "0x6000055")]
	[Address(RVA = "0x28F5920", Offset = "0x28F4B20", VA = "0x1828F5920")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2)
	{
	}

	[Token(Token = "0x6000056")]
	[Address(RVA = "0x28F5C30", Offset = "0x28F4E30", VA = "0x1828F5C30")]
	private PropertyPath(in PropertyPathPart part0, in PropertyPathPart part1, in PropertyPathPart part2, in PropertyPathPart part3)
	{
	}

	[Token(Token = "0x6000057")]
	[Address(RVA = "0x28F59D0", Offset = "0x28F4BD0", VA = "0x1828F59D0")]
	internal PropertyPath(List<PropertyPathPart> parts)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x6000058")]
	[Address(RVA = "0x28F4400", Offset = "0x28F3600", VA = "0x1828F4400")]
	public static PropertyPath FromIndex(int index)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x6000059")]
	[Address(RVA = "0x28F2960", Offset = "0x28F1B60", VA = "0x1828F2960")]
	public static PropertyPath Combine(in PropertyPath path, in PropertyPath pathToAppend)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x600005A")]
	[Address(RVA = "0x28F2090", Offset = "0x28F1290", VA = "0x1828F2090")]
	public static PropertyPath AppendPart(in PropertyPath path, in PropertyPathPart part)
	{
		return default(PropertyPath);
	}

	[MethodImpl(256)]
	[Token(Token = "0x600005B")]
	[Address(RVA = "0x28F1F90", Offset = "0x28F1190", VA = "0x1828F1F90")]
	public static PropertyPath AppendIndex(in PropertyPath path, int index)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x600005C")]
	[Address(RVA = "0x28F2580", Offset = "0x28F1780", VA = "0x1828F2580")]
	public static PropertyPath AppendProperty(in PropertyPath path, IProperty property)
	{
		return default(PropertyPath);
	}

	[MethodImpl(256)]
	[Token(Token = "0x600005D")]
	[Address(RVA = "0x28F47E0", Offset = "0x28F39E0", VA = "0x1828F47E0")]
	public static PropertyPath Pop(in PropertyPath path)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x600005E")]
	[Address(RVA = "0x28F4870", Offset = "0x28F3A70", VA = "0x1828F4870")]
	public static PropertyPath SubPath(in PropertyPath path, int startIndex, int length)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x600005F")]
	[Address(RVA = "0x28F52B0", Offset = "0x28F44B0", VA = "0x1828F52B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x6000060")]
	[Address(RVA = "0x28F28A0", Offset = "0x28F1AA0", VA = "0x1828F28A0")]
	private static void AppendToBuilder(in PropertyPathPart part, StringBuilder builder)
	{
	}

	[Token(Token = "0x6000061")]
	[Address(RVA = "0x28F46D0", Offset = "0x28F38D0", VA = "0x1828F46D0")]
	private static void GetParts(in PropertyPath path, List<PropertyPathPart> parts)
	{
	}

	[Token(Token = "0x6000062")]
	[Address(RVA = "0x28F3060", Offset = "0x28F2260", VA = "0x1828F3060")]
	private static PropertyPath ConstructFromPath(string path)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x6000063")]
	[Address(RVA = "0x28F5EF0", Offset = "0x28F50F0", VA = "0x1828F5EF0")]
	public static bool operator ==(PropertyPath lhs, PropertyPath rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000064")]
	[Address(RVA = "0x28F5F60", Offset = "0x28F5160", VA = "0x1828F5F60")]
	public static bool operator !=(PropertyPath lhs, PropertyPath rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6000065")]
	[Address(RVA = "0x28F41D0", Offset = "0x28F33D0", VA = "0x1828F41D0", Slot = "4")]
	public bool Equals(PropertyPath other)
	{
		return default(bool);
	}

	[Token(Token = "0x6000066")]
	[Address(RVA = "0x28F4300", Offset = "0x28F3500", VA = "0x1828F4300", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6000067")]
	[Address(RVA = "0x28F44F0", Offset = "0x28F36F0", VA = "0x1828F44F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
