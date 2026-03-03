using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20003C0")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal struct TransitionData : IStyleDataGroup<TransitionData>, IEquatable<TransitionData>
{
	[Token(Token = "0x4000C82")]
	[FieldOffset(Offset = "0x0")]
	public List<TimeValue> transitionDelay;

	[Token(Token = "0x4000C83")]
	[FieldOffset(Offset = "0x8")]
	public List<TimeValue> transitionDuration;

	[Token(Token = "0x4000C84")]
	[FieldOffset(Offset = "0x10")]
	public List<StylePropertyName> transitionProperty;

	[Token(Token = "0x4000C85")]
	[FieldOffset(Offset = "0x18")]
	public List<EasingFunction> transitionTimingFunction;

	[Token(Token = "0x6001C8C")]
	[Address(RVA = "0x29ED3B0", Offset = "0x29EC5B0", VA = "0x1829ED3B0", Slot = "4")]
	public TransitionData Copy()
	{
		return default(TransitionData);
	}

	[Token(Token = "0x6001C8D")]
	[Address(RVA = "0x29ED240", Offset = "0x29EC440", VA = "0x1829ED240", Slot = "5")]
	public void CopyFrom(ref TransitionData other)
	{
	}

	[Token(Token = "0x6001C8E")]
	[Address(RVA = "0x29ED710", Offset = "0x29EC910", VA = "0x1829ED710")]
	public static bool operator ==(TransitionData lhs, TransitionData rhs)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C8F")]
	[Address(RVA = "0x29ED550", Offset = "0x29EC750", VA = "0x1829ED550", Slot = "6")]
	public bool Equals(TransitionData other)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C90")]
	[Address(RVA = "0x29ED590", Offset = "0x29EC790", VA = "0x1829ED590", Slot = "0")]
	public override bool Equals(object obj)
	{
		return default(bool);
	}

	[Token(Token = "0x6001C91")]
	[Address(RVA = "0x29ED650", Offset = "0x29EC850", VA = "0x1829ED650", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
