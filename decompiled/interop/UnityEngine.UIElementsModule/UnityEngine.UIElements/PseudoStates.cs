using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x20004D8")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
[Flags]
internal enum PseudoStates
{
	[Token(Token = "0x4000FE0")]
	Active = 1,
	[Token(Token = "0x4000FE1")]
	Hover = 2,
	[Token(Token = "0x4000FE2")]
	Checked = 8,
	[Token(Token = "0x4000FE3")]
	Disabled = 0x20,
	[Token(Token = "0x4000FE4")]
	Focus = 0x40,
	[Token(Token = "0x4000FE5")]
	Root = 0x80
}
