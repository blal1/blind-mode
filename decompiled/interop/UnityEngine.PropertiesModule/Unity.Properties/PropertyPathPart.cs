using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Unity.Properties;

[Token(Token = "0x200001A")]
public readonly struct PropertyPathPart : IEquatable<PropertyPathPart>
{
	[Token(Token = "0x4000028")]
	[FieldOffset(Offset = "0x0")]
	private readonly PropertyPathPartKind m_Kind;

	[Token(Token = "0x4000029")]
	[FieldOffset(Offset = "0x8")]
	private readonly string m_Name;

	[Token(Token = "0x400002A")]
	[FieldOffset(Offset = "0x10")]
	private readonly int m_Index;

	[Token(Token = "0x400002B")]
	[FieldOffset(Offset = "0x18")]
	private readonly object m_Key;

	[Token(Token = "0x1700000C")]
	public bool IsName
	{
		[Token(Token = "0x6000041")]
		[Address(RVA = "0x407B60", Offset = "0x406D60", VA = "0x180407B60")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000D")]
	public bool IsIndex
	{
		[Token(Token = "0x6000042")]
		[Address(RVA = "0x23661E0", Offset = "0x23653E0", VA = "0x1823661E0")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x1700000E")]
	public PropertyPathPartKind Kind
	{
		[Token(Token = "0x6000043")]
		[Address(RVA = "0x8C8B50", Offset = "0x8C7D50", VA = "0x1808C8B50")]
		get
		{
			return default(PropertyPathPartKind);
		}
	}

	[Token(Token = "0x1700000F")]
	public string Name
	{
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x28F1F30", Offset = "0x28F1130", VA = "0x1828F1F30")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x17000010")]
	public int Index
	{
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x28F1E70", Offset = "0x28F1070", VA = "0x1828F1E70")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x17000011")]
	public object Key
	{
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x28F1ED0", Offset = "0x28F10D0", VA = "0x1828F1ED0")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x6000047")]
	[Address(RVA = "0x28F1E30", Offset = "0x28F1030", VA = "0x1828F1E30")]
	public PropertyPathPart(string name)
	{
	}

	[Token(Token = "0x6000048")]
	[Address(RVA = "0x28F1DD0", Offset = "0x28F0FD0", VA = "0x1828F1DD0")]
	public PropertyPathPart(int index)
	{
	}

	[Token(Token = "0x6000049")]
	[Address(RVA = "0x28F1D70", Offset = "0x28F0F70", VA = "0x1828F1D70")]
	public PropertyPathPart(object key)
	{
	}

	[MethodImpl(256)]
	[Token(Token = "0x600004A")]
	[Address(RVA = "0x28F1A30", Offset = "0x28F0C30", VA = "0x1828F1A30")]
	private void CheckKind(PropertyPathPartKind type)
	{
	}

	[Token(Token = "0x600004B")]
	[Address(RVA = "0x28F1C60", Offset = "0x28F0E60", VA = "0x1828F1C60", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600004C")]
	[Address(RVA = "0x28F1B50", Offset = "0x28F0D50", VA = "0x1828F1B50", Slot = "4")]
	public bool Equals(PropertyPathPart other)
	{
		return default(bool);
	}

	[Token(Token = "0x600004D")]
	[Address(RVA = "0x28F1A80", Offset = "0x28F0C80", VA = "0x1828F1A80", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x600004E")]
	[Address(RVA = "0x28F1BB0", Offset = "0x28F0DB0", VA = "0x1828F1BB0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
