using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003C1")]
internal struct VisualData : IStyleDataGroup<VisualData>, IEquatable<VisualData>
{
	[Token(Token = "0x4000C86")]
	[FieldOffset(Offset = "0x0")]
	public Color backgroundColor;

	[Token(Token = "0x4000C87")]
	[FieldOffset(Offset = "0x10")]
	public Background backgroundImage;

	[Token(Token = "0x4000C88")]
	[FieldOffset(Offset = "0x30")]
	public BackgroundPosition backgroundPositionX;

	[Token(Token = "0x4000C89")]
	[FieldOffset(Offset = "0x3C")]
	public BackgroundPosition backgroundPositionY;

	[Token(Token = "0x4000C8A")]
	[FieldOffset(Offset = "0x48")]
	public BackgroundRepeat backgroundRepeat;

	[Token(Token = "0x4000C8B")]
	[FieldOffset(Offset = "0x50")]
	public BackgroundSize backgroundSize;

	[Token(Token = "0x4000C8C")]
	[FieldOffset(Offset = "0x64")]
	public Color borderBottomColor;

	[Token(Token = "0x4000C8D")]
	[FieldOffset(Offset = "0x74")]
	public Length borderBottomLeftRadius;

	[Token(Token = "0x4000C8E")]
	[FieldOffset(Offset = "0x7C")]
	public Length borderBottomRightRadius;

	[Token(Token = "0x4000C8F")]
	[FieldOffset(Offset = "0x84")]
	public Color borderLeftColor;

	[Token(Token = "0x4000C90")]
	[FieldOffset(Offset = "0x94")]
	public Color borderRightColor;

	[Token(Token = "0x4000C91")]
	[FieldOffset(Offset = "0xA4")]
	public Color borderTopColor;

	[Token(Token = "0x4000C92")]
	[FieldOffset(Offset = "0xB4")]
	public Length borderTopLeftRadius;

	[Token(Token = "0x4000C93")]
	[FieldOffset(Offset = "0xBC")]
	public Length borderTopRightRadius;

	[Token(Token = "0x4000C94")]
	[FieldOffset(Offset = "0xC4")]
	public float opacity;

	[Token(Token = "0x4000C95")]
	[FieldOffset(Offset = "0xC8")]
	public OverflowInternal overflow;

	[Token(Token = "0x6001C92")]
	[Address(RVA = "0x29DDE50", Offset = "0x29DD050", VA = "0x1829DDE50", Slot = "4")]
	public VisualData Copy()
	{
		return default(VisualData);
	}

	[Token(Token = "0x6001C93")]
	[Address(RVA = "0x29F2360", Offset = "0x29F1560", VA = "0x1829F2360", Slot = "5")]
	public void CopyFrom(ref VisualData other)
	{
	}

	[Token(Token = "0x6001C94")]
	[Address(RVA = "0x29F2880", Offset = "0x29F1A80", VA = "0x1829F2880")]
	public static bool operator ==(VisualData lhs, VisualData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C95")]
	[Address(RVA = "0x29F2480", Offset = "0x29F1680", VA = "0x1829F2480", Slot = "6")]
	public bool Equals(VisualData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C96")]
	[Address(RVA = "0x29F25B0", Offset = "0x29F17B0", VA = "0x1829F25B0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C97")]
	[Address(RVA = "0x29F26E0", Offset = "0x29F18E0", VA = "0x1829F26E0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
