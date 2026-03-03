using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003BE")]
internal struct RareData : IStyleDataGroup<RareData>, IEquatable<RareData>
{
	[Token(Token = "0x4000C73")]
	[FieldOffset(Offset = "0x0")]
	public Cursor cursor;

	[Token(Token = "0x4000C74")]
	[FieldOffset(Offset = "0x18")]
	public TextOverflow textOverflow;

	[Token(Token = "0x4000C75")]
	[FieldOffset(Offset = "0x1C")]
	public Color unityBackgroundImageTintColor;

	[Token(Token = "0x4000C76")]
	[FieldOffset(Offset = "0x2C")]
	public OverflowClipBox unityOverflowClipBox;

	[Token(Token = "0x4000C77")]
	[FieldOffset(Offset = "0x30")]
	public int unitySliceBottom;

	[Token(Token = "0x4000C78")]
	[FieldOffset(Offset = "0x34")]
	public int unitySliceLeft;

	[Token(Token = "0x4000C79")]
	[FieldOffset(Offset = "0x38")]
	public int unitySliceRight;

	[Token(Token = "0x4000C7A")]
	[FieldOffset(Offset = "0x3C")]
	public float unitySliceScale;

	[Token(Token = "0x4000C7B")]
	[FieldOffset(Offset = "0x40")]
	public int unitySliceTop;

	[Token(Token = "0x4000C7C")]
	[FieldOffset(Offset = "0x44")]
	public SliceType unitySliceType;

	[Token(Token = "0x4000C7D")]
	[FieldOffset(Offset = "0x48")]
	public TextOverflowPosition unityTextOverflowPosition;

	[Token(Token = "0x6001C80")]
	[Address(RVA = "0x29E2BB0", Offset = "0x29E1DB0", VA = "0x1829E2BB0", Slot = "4")]
	public RareData Copy()
	{
		return default(RareData);
	}

	[Token(Token = "0x6001C81")]
	[Address(RVA = "0x29E2B80", Offset = "0x29E1D80", VA = "0x1829E2B80", Slot = "5")]
	public void CopyFrom(ref RareData other)
	{
	}

	[Token(Token = "0x6001C82")]
	[Address(RVA = "0x29E2EF0", Offset = "0x29E20F0", VA = "0x1829E2EF0")]
	public static bool operator ==(RareData lhs, RareData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C83")]
	[Address(RVA = "0x29E2CA0", Offset = "0x29E1EA0", VA = "0x1829E2CA0", Slot = "6")]
	public bool Equals(RareData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C84")]
	[Address(RVA = "0x29E2BE0", Offset = "0x29E1DE0", VA = "0x1829E2BE0", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C85")]
	[Address(RVA = "0x29E2E60", Offset = "0x29E2060", VA = "0x1829E2E60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
