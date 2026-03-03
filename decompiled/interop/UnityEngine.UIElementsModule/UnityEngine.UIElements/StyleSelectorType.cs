using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.UIElements;

[Token(Token = "0x200043C")]
[UnityEngine.Bindings.VisibleToOtherModules(new string[] { "UnityEditor.UIBuilderModule" })]
internal enum StyleSelectorType
{
	[Token(Token = "0x4000DCA")]
	Unknown,
	[Token(Token = "0x4000DCB")]
	Wildcard,
	[Token(Token = "0x4000DCC")]
	Type,
	[Token(Token = "0x4000DCD")]
	Class,
	[Token(Token = "0x4000DCE")]
	PseudoClass,
	[Token(Token = "0x4000DCF")]
	RecursivePseudoClass,
	[Token(Token = "0x4000DD0")]
	ID,
	[Token(Token = "0x4000DD1")]
	Predicate
}
