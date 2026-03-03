using System.Diagnostics;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets;

[StructLayout(2)]
[Token(Token = "0x20005D2")]
[DebuggerDisplay("id = {id}, keyword = {keyword}, number = {number}, boolean = {boolean}, color = {color}, object = {resource}")]
internal struct StyleValue
{
	[Token(Token = "0x4001572")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
	public StylePropertyId id;

	[Token(Token = "0x4001573")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x4")]
	public StyleKeyword keyword;

	[Token(Token = "0x4001574")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public float number;

	[Token(Token = "0x4001575")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Length length;

	[Token(Token = "0x4001576")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public Color color;

	[Token(Token = "0x4001577")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public GCHandle resource;

	[Token(Token = "0x4001578")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public BackgroundPosition position;

	[Token(Token = "0x4001579")]
	[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
	public BackgroundRepeat repeat;
}
