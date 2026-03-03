using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003BD")]
internal struct LayoutData : IStyleDataGroup<LayoutData>, IEquatable<LayoutData>
{
	[Token(Token = "0x4000C52")]
	[FieldOffset(Offset = "0x0")]
	public Align alignContent;

	[Token(Token = "0x4000C53")]
	[FieldOffset(Offset = "0x4")]
	public Align alignItems;

	[Token(Token = "0x4000C54")]
	[FieldOffset(Offset = "0x8")]
	public Align alignSelf;

	[Token(Token = "0x4000C55")]
	[FieldOffset(Offset = "0xC")]
	public float borderBottomWidth;

	[Token(Token = "0x4000C56")]
	[FieldOffset(Offset = "0x10")]
	public float borderLeftWidth;

	[Token(Token = "0x4000C57")]
	[FieldOffset(Offset = "0x14")]
	public float borderRightWidth;

	[Token(Token = "0x4000C58")]
	[FieldOffset(Offset = "0x18")]
	public float borderTopWidth;

	[Token(Token = "0x4000C59")]
	[FieldOffset(Offset = "0x1C")]
	public Length bottom;

	[Token(Token = "0x4000C5A")]
	[FieldOffset(Offset = "0x24")]
	public DisplayStyle display;

	[Token(Token = "0x4000C5B")]
	[FieldOffset(Offset = "0x28")]
	public Length flexBasis;

	[Token(Token = "0x4000C5C")]
	[FieldOffset(Offset = "0x30")]
	public FlexDirection flexDirection;

	[Token(Token = "0x4000C5D")]
	[FieldOffset(Offset = "0x34")]
	public float flexGrow;

	[Token(Token = "0x4000C5E")]
	[FieldOffset(Offset = "0x38")]
	public float flexShrink;

	[Token(Token = "0x4000C5F")]
	[FieldOffset(Offset = "0x3C")]
	public Wrap flexWrap;

	[Token(Token = "0x4000C60")]
	[FieldOffset(Offset = "0x40")]
	public Length height;

	[Token(Token = "0x4000C61")]
	[FieldOffset(Offset = "0x48")]
	public Justify justifyContent;

	[Token(Token = "0x4000C62")]
	[FieldOffset(Offset = "0x4C")]
	public Length left;

	[Token(Token = "0x4000C63")]
	[FieldOffset(Offset = "0x54")]
	public Length marginBottom;

	[Token(Token = "0x4000C64")]
	[FieldOffset(Offset = "0x5C")]
	public Length marginLeft;

	[Token(Token = "0x4000C65")]
	[FieldOffset(Offset = "0x64")]
	public Length marginRight;

	[Token(Token = "0x4000C66")]
	[FieldOffset(Offset = "0x6C")]
	public Length marginTop;

	[Token(Token = "0x4000C67")]
	[FieldOffset(Offset = "0x74")]
	public Length maxHeight;

	[Token(Token = "0x4000C68")]
	[FieldOffset(Offset = "0x7C")]
	public Length maxWidth;

	[Token(Token = "0x4000C69")]
	[FieldOffset(Offset = "0x84")]
	public Length minHeight;

	[Token(Token = "0x4000C6A")]
	[FieldOffset(Offset = "0x8C")]
	public Length minWidth;

	[Token(Token = "0x4000C6B")]
	[FieldOffset(Offset = "0x94")]
	public Length paddingBottom;

	[Token(Token = "0x4000C6C")]
	[FieldOffset(Offset = "0x9C")]
	public Length paddingLeft;

	[Token(Token = "0x4000C6D")]
	[FieldOffset(Offset = "0xA4")]
	public Length paddingRight;

	[Token(Token = "0x4000C6E")]
	[FieldOffset(Offset = "0xAC")]
	public Length paddingTop;

	[Token(Token = "0x4000C6F")]
	[FieldOffset(Offset = "0xB4")]
	public Position position;

	[Token(Token = "0x4000C70")]
	[FieldOffset(Offset = "0xB8")]
	public Length right;

	[Token(Token = "0x4000C71")]
	[FieldOffset(Offset = "0xC0")]
	public Length top;

	[Token(Token = "0x4000C72")]
	[FieldOffset(Offset = "0xC8")]
	public Length width;

	[Token(Token = "0x6001C7A")]
	[Address(RVA = "0x29DDE50", Offset = "0x29DD050", VA = "0x1829DDE50", Slot = "4")]
	public LayoutData Copy()
	{
		return default(LayoutData);
	}

	[Token(Token = "0x6001C7B")]
	[Address(RVA = "0x29DDD40", Offset = "0x29DCF40", VA = "0x1829DDD40", Slot = "5")]
	public void CopyFrom(ref LayoutData other)
	{
	}

	[Token(Token = "0x6001C7C")]
	[Address(RVA = "0x29DE470", Offset = "0x29DD670", VA = "0x1829DE470")]
	public static bool operator ==(LayoutData lhs, LayoutData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C7D")]
	[Address(RVA = "0x29DE000", Offset = "0x29DD200", VA = "0x1829DE000", Slot = "6")]
	public bool Equals(LayoutData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C7E")]
	[Address(RVA = "0x29DDED0", Offset = "0x29DD0D0", VA = "0x1829DDED0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C7F")]
	[Address(RVA = "0x29DE130", Offset = "0x29DD330", VA = "0x1829DE130", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
