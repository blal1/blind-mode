using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Serializable]
[Token(Token = "0x20004D6")]
internal struct GradientSettings
{
	[Token(Token = "0x4000FD5")]
	[FieldOffset(Offset = "0x0")]
	public GradientType gradientType;

	[Token(Token = "0x4000FD6")]
	[FieldOffset(Offset = "0x4")]
	public AddressMode addressMode;

	[Token(Token = "0x4000FD7")]
	[FieldOffset(Offset = "0x8")]
	public Vector2 radialFocus;

	[Token(Token = "0x4000FD8")]
	[FieldOffset(Offset = "0x10")]
	public RectInt location;
}
