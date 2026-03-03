using System;
using Il2CppInterop.Common.Attributes;

namespace Il2CppTMPro;

[OriginalName("Unity.TextMeshPro.dll", "TMPro", "FontStyles")]
[Flags]
public enum FontStyles
{
	Normal = 0,
	Bold = 1,
	Italic = 2,
	Underline = 4,
	LowerCase = 8,
	UpperCase = 0x10,
	SmallCaps = 0x20,
	Strikethrough = 0x40,
	Superscript = 0x80,
	Subscript = 0x100,
	Highlight = 0x200
}
