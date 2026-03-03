using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003BF")]
internal struct TransformData : IStyleDataGroup<TransformData>, IEquatable<TransformData>
{
	[Token(Token = "0x4000C7E")]
	[FieldOffset(Offset = "0x0")]
	public Rotate rotate;

	[Token(Token = "0x4000C7F")]
	[FieldOffset(Offset = "0x18")]
	public Scale scale;

	[Token(Token = "0x4000C80")]
	[FieldOffset(Offset = "0x28")]
	public TransformOrigin transformOrigin;

	[Token(Token = "0x4000C81")]
	[FieldOffset(Offset = "0x3C")]
	public Translate translate;

	[Token(Token = "0x6001C86")]
	[Address(RVA = "0x29EC470", Offset = "0x29EB670", VA = "0x1829EC470", Slot = "4")]
	public TransformData Copy()
	{
		return default(TransformData);
	}

	[Token(Token = "0x6001C87")]
	[Address(RVA = "0x29EC440", Offset = "0x29EB640", VA = "0x1829EC440", Slot = "5")]
	public void CopyFrom(ref TransformData other)
	{
	}

	[Token(Token = "0x6001C88")]
	[Address(RVA = "0x29EC7A0", Offset = "0x29EB9A0", VA = "0x1829EC7A0")]
	public static bool operator ==(TransformData lhs, TransformData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C89")]
	[Address(RVA = "0x29EC4A0", Offset = "0x29EB6A0", VA = "0x1829EC4A0", Slot = "6")]
	public bool Equals(TransformData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C8A")]
	[Address(RVA = "0x29EC530", Offset = "0x29EB730", VA = "0x1829EC530", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C8B")]
	[Address(RVA = "0x29EC660", Offset = "0x29EB860", VA = "0x1829EC660", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
