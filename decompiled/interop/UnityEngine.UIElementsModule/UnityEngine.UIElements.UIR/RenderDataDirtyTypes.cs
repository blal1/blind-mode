using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.UIR;

[Token(Token = "0x2000560")]
[Flags]
internal enum RenderDataDirtyTypes
{
	[Token(Token = "0x40012EA")]
	None = 0,
	[Token(Token = "0x40012EB")]
	Transform = 1,
	[Token(Token = "0x40012EC")]
	ClipRectSize = 2,
	[Token(Token = "0x40012ED")]
	Clipping = 4,
	[Token(Token = "0x40012EE")]
	ClippingHierarchy = 8,
	[Token(Token = "0x40012EF")]
	Visuals = 0x10,
	[Token(Token = "0x40012F0")]
	VisualsHierarchy = 0x20,
	[Token(Token = "0x40012F1")]
	VisualsOpacityId = 0x40,
	[Token(Token = "0x40012F2")]
	Opacity = 0x80,
	[Token(Token = "0x40012F3")]
	OpacityHierarchy = 0x100,
	[Token(Token = "0x40012F4")]
	Color = 0x200,
	[Token(Token = "0x40012F5")]
	AllVisuals = 0x70
}
