using System;
using Il2CppDummyDll;
using Unity.Properties;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004E2")]
public readonly struct BindingId : IEquatable<BindingId>
{
	[Token(Token = "0x4001007")]
	[FieldOffset(Offset = "0x0")]
	public static readonly BindingId Invalid;

	[Token(Token = "0x4001008")]
	[FieldOffset(Offset = "0x0")]
	private readonly PropertyPath m_PropertyPath;

	[Token(Token = "0x4001009")]
	[FieldOffset(Offset = "0x90")]
	private readonly string m_Path;

	[Token(Token = "0x6002378")]
	[Address(RVA = "0x2A2AD50", Offset = "0x2A29F50", VA = "0x182A2AD50")]
	public BindingId(string path)
	{
	}

	[Token(Token = "0x6002379")]
	[Address(RVA = "0x2A2AE30", Offset = "0x2A2A030", VA = "0x182A2AE30")]
	public BindingId(in PropertyPath path)
	{
	}

	[Token(Token = "0x600237A")]
	[Address(RVA = "0x29DD230", Offset = "0x29DC430", VA = "0x1829DD230")]
	public static implicit operator PropertyPath(in BindingId vep)
	{
		return default(PropertyPath);
	}

	[Token(Token = "0x600237B")]
	[Address(RVA = "0x287DB90", Offset = "0x287CD90", VA = "0x18287DB90")]
	public static implicit operator string(in BindingId vep)
	{
		return null;
	}

	[Token(Token = "0x600237C")]
	[Address(RVA = "0x2A2B0C0", Offset = "0x2A2A2C0", VA = "0x182A2B0C0")]
	public static implicit operator BindingId(string name)
	{
		return default(BindingId);
	}

	[Token(Token = "0x600237D")]
	[Address(RVA = "0x2A2AFC0", Offset = "0x2A2A1C0", VA = "0x182A2AFC0")]
	public static implicit operator BindingId(in PropertyPath path)
	{
		return default(BindingId);
	}

	[Token(Token = "0x600237E")]
	[Address(RVA = "0x287DB90", Offset = "0x287CD90", VA = "0x18287DB90", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Token(Token = "0x600237F")]
	[Address(RVA = "0x2A2A9A0", Offset = "0x2A29BA0", VA = "0x182A2A9A0", Slot = "4")]
	public bool Equals(BindingId other)
	{
		return default(bool);
	}

	[Token(Token = "0x6002380")]
	[Address(RVA = "0x2A2AAC0", Offset = "0x2A29CC0", VA = "0x182A2AAC0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6002381")]
	[Address(RVA = "0x2A2ACD0", Offset = "0x2A29ED0", VA = "0x182A2ACD0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Token(Token = "0x6002382")]
	[Address(RVA = "0x2A2AEF0", Offset = "0x2A2A0F0", VA = "0x182A2AEF0")]
	public static bool operator ==(in BindingId lhs, in BindingId rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6002383")]
	[Address(RVA = "0x2A2B1C0", Offset = "0x2A2A3C0", VA = "0x182A2B1C0")]
	public static bool operator !=(in BindingId lhs, in BindingId rhs)
	{
		return default(bool);
	}
}
