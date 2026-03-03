using System;
using System.Reflection;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004F6")]
[DefaultMember("Item")]
public struct VisualElementStyleSheetSet : IEquatable<VisualElementStyleSheetSet>
{
	[Token(Token = "0x4001043")]
	[FieldOffset(Offset = "0x0")]
	private readonly VisualElement m_Element;

	[Token(Token = "0x17000960")]
	public int count
	{
		[Token(Token = "0x60023C0")]
		[Address(RVA = "0x2A3F040", Offset = "0x2A3E240", VA = "0x182A3F040")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x60023BC")]
	[Address(RVA = "0x5BF760", Offset = "0x5BE960", VA = "0x1805BF760")]
	internal VisualElementStyleSheetSet(VisualElement element)
	{
	}

	[Token(Token = "0x60023BD")]
	[Address(RVA = "0x2A3EC20", Offset = "0x2A3DE20", VA = "0x182A3EC20")]
	public void Add(StyleSheet styleSheet)
	{
	}

	[Token(Token = "0x60023BE")]
	[Address(RVA = "0x2A3ED30", Offset = "0x2A3DF30", VA = "0x182A3ED30")]
	public void Insert(int index, StyleSheet styleSheet)
	{
	}

	[Token(Token = "0x60023BF")]
	[Address(RVA = "0x2A3EEE0", Offset = "0x2A3E0E0", VA = "0x182A3EEE0")]
	public bool Remove(StyleSheet styleSheet)
	{
		return default(bool);
	}

	[Token(Token = "0x60023C1")]
	[Address(RVA = "0x2A3ED20", Offset = "0x2A3DF20", VA = "0x182A3ED20", Slot = "4")]
	public bool Equals(VisualElementStyleSheetSet other)
	{
		return default(bool);
	}

	[Token(Token = "0x60023C2")]
	[Address(RVA = "0x2A3EC90", Offset = "0x2A3DE90", VA = "0x182A3EC90", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x60023C3")]
	[Address(RVA = "0x29DC1C0", Offset = "0x29DB3C0", VA = "0x1829DC1C0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
