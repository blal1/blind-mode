using System;
using Il2CppDummyDll;
using UnityEngine.UIElements.StyleSheets;

namespace UnityEngine.UIElements;

[Token(Token = "0x20002CD")]
internal struct ComputedTransitionProperty
{
	[Token(Token = "0x4000B3C")]
	[FieldOffset(Offset = "0x0")]
	public StylePropertyId id;

	[Token(Token = "0x4000B3D")]
	[FieldOffset(Offset = "0x4")]
	public int durationMs;

	[Token(Token = "0x4000B3E")]
	[FieldOffset(Offset = "0x8")]
	public int delayMs;

	[Token(Token = "0x4000B3F")]
	[FieldOffset(Offset = "0x10")]
	public Func<float, float> easingCurve;
}
