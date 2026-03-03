using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements;

[Token(Token = "0x2000287")]
[Flags]
public enum VersionChangeType
{
	[Token(Token = "0x4000A02")]
	Bindings = 1,
	[Token(Token = "0x4000A03")]
	ViewData = 2,
	[Token(Token = "0x4000A04")]
	Hierarchy = 4,
	[Token(Token = "0x4000A05")]
	Layout = 8,
	[Token(Token = "0x4000A06")]
	StyleSheet = 0x10,
	[Token(Token = "0x4000A07")]
	Styles = 0x20,
	[Token(Token = "0x4000A08")]
	Overflow = 0x40,
	[Token(Token = "0x4000A09")]
	BorderRadius = 0x80,
	[Token(Token = "0x4000A0A")]
	BorderWidth = 0x100,
	[Token(Token = "0x4000A0B")]
	Transform = 0x200,
	[Token(Token = "0x4000A0C")]
	Size = 0x400,
	[Token(Token = "0x4000A0D")]
	Repaint = 0x800,
	[Token(Token = "0x4000A0E")]
	Opacity = 0x1000,
	[Token(Token = "0x4000A0F")]
	Color = 0x2000,
	[Token(Token = "0x4000A10")]
	RenderHints = 0x4000,
	[Token(Token = "0x4000A11")]
	TransitionProperty = 0x8000,
	[Token(Token = "0x4000A12")]
	EventCallbackCategories = 0x10000,
	[Token(Token = "0x4000A13")]
	DisableRendering = 0x20000,
	[Token(Token = "0x4000A14")]
	BindingRegistration = 0x40000,
	[Token(Token = "0x4000A15")]
	DataSource = 0x80000,
	[Token(Token = "0x4000A16")]
	Picking = 0x100000
}
